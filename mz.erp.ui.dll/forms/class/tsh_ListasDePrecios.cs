using System;
using System.Data;
using System.Collections;
using System.Text;
    
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.ui.controllers;
//Sabrina 20100727 - Tarea 802
using mz.erp.businessrules;
//Fin Sabrina 20100727 - Tarea 802

namespace mz.erp.ui.forms.classes
{
	/// <summary>
	/// Descripción breve de tsh_ListasDePrecios.
	/// </summary>
	public class tsh_ListasDePrecios: IDisposable, IGridDocument
	{
		public tsh_ListasDePrecios()
		{
		}

		public tsh_ListasDePrecios(string[] fieldList)
		{
			_fieldList = fieldList;
		}
		private string[] _fieldList;
		public string[] FieldList
		{
			get
			{
				return _fieldList;
			}
			set
			{
				_fieldList = value;
			}
		}

		public string GetLayout()
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			//Cristian 20101201 Tarea 937
			if ( fl.Contains( "IdListaDePrecio" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdListaDePrecio", "IdListaDePrecio",160,Types.ColumnTypes.Text,Types.EditType.NoEdit ) );
            //Fin Tarea 937
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripción",250 ) );
			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Código",50 ) );
			if ( fl.Contains( "Coeficiente" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Coeficiente", "Coeficiente",50) );
			if ( fl.Contains( "Activo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo", 50, Types.ColumnTypes.CheckBox, Types.EditType.CheckBox) );
			//German 20100831 - Tarea 823
            //if ( fl.Contains( "isDefault" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "isDefault", "isDefault", 50, Types.ColumnTypes.CheckBox, Types.EditType.CheckBox,) );
            if ( fl.Contains( "isDefault" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "isDefault", "isDefault", true) );
            //Fin German 20100831 - Tarea 823
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal",true ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa",true ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion",true ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion", true) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado",true ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion",true) );

			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tsh_ListasDePrecios.GetList().tsh_ListasDePrecios;
		}
		
		public void Update( object dataTable )
		{
			//Sabrina 20100727 - Tarea 802	
			tsh_ListasDePreciosExDataset dataLPEx = new tsh_ListasDePreciosExDataset();
			dataLPEx.Merge((DataTable)dataTable);	

			foreach(tsh_ListasDePreciosExDataset.tsh_ListasDePreciosRow row in dataLPEx.tsh_ListasDePrecios.Rows)
			{
				if(row.RowState.Equals(DataRowState.Added)) //Si es una lista nueva se la agrego a todos los productos
				{
					CargarListaDePrecioAProductos(row, dataLPEx);
				}
				else if(row.RowState.Equals(DataRowState.Modified)) //Si es una lista modificada para cada producto que la tenga como General y el coeficiente difiera se lo modifico.
				{
					ModificarCoeficienteListaDePrecioAProductos(row, dataLPEx);
				}
			}
			mz.erp.businessrules.tsh_ListasDePreciosEx.Update(dataLPEx);
			//Fin Sabrina 20100727 - Tarea 802
		}
		
		public void DeletingRowValidate( DataRow row )
		{
		}
		
		public void Dispose()
		{
		}

		//Sabrina 20100727 - Tarea 802			
		private void CargarListaDePrecioAProductos(tsh_ListasDePreciosExDataset.tsh_ListasDePreciosRow rowLP, tsh_ListasDePreciosExDataset dataLPEx)
		{
			tsh_ProductosDataset.tsh_ProductosDataTable tableProd = mz.erp.businessrules.tsh_Productos.GetList().tsh_Productos;			
			foreach(tsh_ProductosDataset.tsh_ProductosRow rowP in tableProd.Rows)
			{
				tsh_ListasDePreciosExDataset.tsh_ProductosListasDePreciosRow rowPLP = dataLPEx.tsh_ProductosListasDePrecios.Newtsh_ProductosListasDePreciosRow();
				rowPLP.IdProducto = rowP.IdProducto;
				rowPLP.IdListaDePrecio = rowLP.IdListaDePrecio;
				rowPLP.ModoDeAplicacion = "G";
				rowPLP.Coeficiente = rowLP.Coeficiente;
				rowPLP.PrecioDeVentaBruto = rowP.PrecioDeVentaNeto + ((rowP.PrecioDeVentaNeto * rowLP.Coeficiente) / 100);
				System.Collections.Hashtable formulas = mz.erp.businessrules.comprobantes.FuncionesImpuestos.ObtenerFormulas( null, null, rowP.IdProducto );                 
				decimal impuestosBrutos = mz.erp.businessrules.comprobantes.FuncionesImpuestos.Calcular( formulas, rowPLP.PrecioDeVentaBruto);
				rowPLP.PrecioDeVentaBrutoConImpuesto = rowPLP.PrecioDeVentaBruto + impuestosBrutos; 
				if(rowPLP.PrecioDeVentaBruto != 0)
				{
					rowPLP.MaxDescuento = rowPLP.PrecioDeVentaBruto - rowP.PrecioDeVentaNeto;
					rowPLP.MaxDescuentoPorcentual = (rowPLP.MaxDescuento *100)/rowPLP.PrecioDeVentaBruto;
				}
				rowPLP.FechaCreacion = DateTime.Now;
				rowPLP.IdConexionCreacion = Security.IdConexion;
				rowPLP.IdConexionUltimaModificacion = Security.IdConexion;
				rowPLP.IdReservado = 0;
				rowPLP.RowId = Guid.Empty;
				rowPLP.IdEmpresa = Security.IdEmpresa;			
				rowPLP.IdSucursal = Security.IdSucursal;
				
				dataLPEx.tsh_ProductosListasDePrecios.Addtsh_ProductosListasDePreciosRow(rowPLP);
			}
		}
		//Fin Sabrina 20100727 - Tarea 802			

		//Sabrina 20100727 - Tarea 802			
		private void ModificarCoeficienteListaDePrecioAProductos(tsh_ListasDePreciosExDataset.tsh_ListasDePreciosRow rowLP, tsh_ListasDePreciosExDataset dataLPEx)
		{
			tsh_ProductosDataset.tsh_ProductosDataTable tableProd = mz.erp.businessrules.tsh_Productos.GetList().tsh_Productos;			
			foreach(tsh_ProductosDataset.tsh_ProductosRow rowP in tableProd.Rows)
			{
				tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow rowPLP = tsh_ProductosListasDePrecios.GetByPk(rowP.IdProducto, rowLP.IdListaDePrecio);
				if(rowPLP != null)
				{
                    if ((rowPLP.ModoDeAplicacion == "G" && rowPLP.Coeficiente != rowLP.Coeficiente) || rowPLP.ModoDeAplicacion == "P") // Si la lista es general para el producto y el coeficiente cambio la actualizo con el nuevo coeficiente
					{
                        rowPLP.ModoDeAplicacion = "G";
						rowPLP.Coeficiente = rowLP.Coeficiente;
						rowPLP.PrecioDeVentaBruto = rowP.PrecioDeVentaNeto + ((rowP.PrecioDeVentaNeto * rowLP.Coeficiente) / 100);
						System.Collections.Hashtable formulas = mz.erp.businessrules.comprobantes.FuncionesImpuestos.ObtenerFormulas( null, null, rowP.IdProducto );                 
						decimal impuestosBrutos = mz.erp.businessrules.comprobantes.FuncionesImpuestos.Calcular( formulas, rowPLP.PrecioDeVentaBruto);
						rowPLP.PrecioDeVentaBrutoConImpuesto = rowPLP.PrecioDeVentaBruto + impuestosBrutos; 
						if(rowPLP.PrecioDeVentaBruto != 0)
						{
							rowPLP.MaxDescuento = rowPLP.PrecioDeVentaBruto - rowP.PrecioDeVentaNeto;
							rowPLP.MaxDescuentoPorcentual = (rowPLP.MaxDescuento *100)/rowPLP.PrecioDeVentaBruto;
						}
						dataLPEx.tsh_ProductosListasDePrecios.ImportRow(rowPLP);
					}
				}
			}
		}
		//Fin Sabrina 20100727 - Tarea 802			
	}
}
