using System;
using System.Text;
using System.Data;
using System.Collections;
//using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.businessrules;


namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de AgrupProductosController.
	/// </summary>
	public class AgrupProductosController: IObserver
	{
		#region Constructores
		public AgrupProductosController()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		#endregion

		#region Variables Privadas
		
		#endregion
	
		#region Propiedades
		private DataRow _row;
		public DataRow Row 
		{
			get 
			{
				return _row;
			}
		}
		private ArrayList _items = new ArrayList();
		public ArrayList Items 
		{
			get {return _items;}
			set {_items = value;}
		}


		#endregion

		#region Metodos Privados
	
		#endregion

		#region Metodos Publicos
		public void Delete(string Jerarquia)
		{			
			foreach (object objeto in _items)
			{
				mz.erp.businessrules.comprobantes.Item _item = (mz.erp.businessrules.comprobantes.Item) objeto;
				_row = businessrules.tsh_AgrupProductos.NewRow();
				_row = businessrules.tsh_AgrupProductos.GetByPk(_item.IdProducto, Jerarquia);
				if (_row != null)
				{
					_row.Delete();
					businessrules.tsh_AgrupProductos.Update ( (tsh_AgrupProductosDataset.tsh_AgrupProductosRow)_row );
					//Si hay otra agrupproductos no hay q eliminarla solo actualizarla, si no hay otra directamente borro la de productos jerarquia
					tsh_AgrupProductosExDataset dataset=businessrules.tsh_AgrupProductos.GetList(_item.IdProducto);
					if (dataset.Tables[0].Rows.Count==0)
					{
						tsh_ProductosJerarquiasDataset.tsh_ProductosJerarquiasRow _rowPJ=businessrules.tsh_ProductosJerarquias.GetByPk(_item.IdProducto);
						_rowPJ.Delete();
						businessrules.tsh_ProductosJerarquias.Update ( (tsh_ProductosJerarquiasDataset.tsh_ProductosJerarquiasRow)_rowPJ );
					}
					//Else hay q actualizar la q jerarquia q corresponde = ""
					else {
						ProductosJerarquiaAuxiliar p= new ProductosJerarquiaAuxiliar();
						string nomenclatura=p.nomenclaturaReal(Jerarquia);
						ArrayList aux=mz.erp.systemframework.Util.Parse(Jerarquia,20);
						tsh_ProductosJerarquiasDataset.tsh_ProductosJerarquiasRow _rowPJ=_rowPJ=AddTsh_ProductosJerarquias(_item.IdProducto);
						_rowPJ[nomenclatura+"a"]=string.Empty;
						_rowPJ[nomenclatura+"b"]=string.Empty;
						_rowPJ[nomenclatura+"c"]=string.Empty;
						_rowPJ[nomenclatura+"d"]=string.Empty;
						businessrules.tsh_ProductosJerarquias.Update(_rowPJ);
					 }
					
				}
				
			}			
		}

		public bool UpdateWithValidation(string Jerarquia)
		{
			bool result = true;
			foreach (object objeto in _items)
			{
				mz.erp.businessrules.comprobantes.Item _item = (mz.erp.businessrules.comprobantes.Item) objeto;
				_row = businessrules.tsh_AgrupProductos.NewRow();
				_row["IdProducto"] = _item.IdProducto;
				_row["Jerarquia"] = Jerarquia;		
				tsh_ProductosJerarquiasDataset.tsh_ProductosJerarquiasRow _rowPJ=null;
				ProductosJerarquiaAuxiliar p= new ProductosJerarquiaAuxiliar();
				ArrayList aux=mz.erp.systemframework.Util.Parse(Jerarquia,20);
				_rowPJ=AddTsh_ProductosJerarquias(_item.IdProducto);
				string nomenclatura=p.nomenclaturaReal(Jerarquia);
				_rowPJ[nomenclatura+"a"]=(aux.Count >0 && aux[0] != null)? Convert.ToString(aux[0]) : string.Empty;
				_rowPJ[nomenclatura+"b"]=(aux.Count >1 && aux[1] != null)? Convert.ToString(aux[1]) : string.Empty;
				_rowPJ[nomenclatura+"c"]=(aux.Count >2 && aux[2] != null)? Convert.ToString(aux[2]) : string.Empty;	
				_rowPJ[nomenclatura+"d"]=(aux.Count >3 && aux[3] != null)? Convert.ToString(aux[3]) : string.Empty;
				if (businessrules.tsh_AgrupProductos.UpdateWithValidation(_row))
				{
					businessrules.tsh_ProductosJerarquias.Update(_rowPJ);
				}
				else {result = false;}
			}
			return result;
		}
	
		public string GetLayoutAgrupProductos() 
		{
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );			
			sb.Append( LayoutBuilder.GetRow( i++, "Jerarquia", "Jerarquia", true) );
			sb.Append( LayoutBuilder.GetRow( i++, "Padre", "Padre", 200 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion", 200 ) );
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}
		public string GetLayoutProductos()
		{
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );			
			sb.Append( LayoutBuilder.GetRow( i++, "IdProducto", "IdProducto", true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Código", 100, Types.EditType.NoEdit) );
			sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripción", 500, Types.EditType.NoEdit) );
			sb.Append( LayoutBuilder.GetFooter() );			
			return sb.ToString();
		}

		private tsh_ProductosJerarquiasDataset.tsh_ProductosJerarquiasRow AddTsh_ProductosJerarquias(string idProducto)
		{	tsh_ProductosJerarquiasDataset.tsh_ProductosJerarquiasRow _row=businessrules.tsh_ProductosJerarquias.GetByPk(idProducto);
			if (_row==null)
				_row= businessrules.tsh_ProductosJerarquias.NewRow();
			_row["IdProducto"]=idProducto;
			return _row;
							
		}
		
		/*	public void Delete(string IdJerarquia, string IdProducto)
		{
			_row = businessrules.tsh_AgrupProductos.NewRow();
			_row = businessrules.tsh_AgrupProductos.GetByPk(IdJerarquia, IdProducto);
			_row.Delete();
			businessrules.tsh_AgrupProductos.Update ( (tsh_AgrupProductosDataset.tsh_AgrupProductosRow)_row );
		
			
		}
		public bool UpdateWithValidation(string IdJerarquia, string IdProducto)
		{
			_row = businessrules.tsh_AgrupProductos.NewRow();
			_row["IdProducto"] = IdProducto;
			_row["Jerarquia"] = IdJerarquia;
			return businessrules.tsh_AgrupProductos.UpdateWithValidation(_row);
		}*/
			
		#endregion

		#region Miembros de IObserver

		public void UpdateObject(object sender, object valores)
		{			
			if ((valores.GetType()) == typeof(System.Collections.ArrayList))
			{				
				ArrayList lista = (ArrayList)valores;				
				foreach ( mz.erp.businessrules.comprobantes.Item item in lista )
				{					
					string IdProducto = item.IdProducto;
					bool agregar = true;
					foreach (object objeto in _items)
					{
						mz.erp.businessrules.comprobantes.Item _item = (mz.erp.businessrules.comprobantes.Item) objeto;
						if (_item.IdProducto == item.IdProducto)
						{
							agregar = false;
						}
					}
					if (agregar)
						_items.Add(item);
					/*ItemAjuste itemAj = new ItemAjuste();
					itemAj.Cantidad = item.Cantidad;
					itemAj.IdProducto = item.IdProducto;		
					itemAj.Codigo = item.Codigo;
					itemAj.Descripcion = item.Descripcion;
					DataRow row = mz.erp.businessrules.tsh_ProductosSucursales.GetByPk(item.IdProducto, Security.IdSucursal, Security.IdEmpresa);
					if(row != null)
						itemAj.StockDisponible = Convert.ToDecimal(row["StockDisponible"]);
					else itemAj.StockDisponible =0;
					_items.Add(itemAj);*/
				}
				if (OnModelChanged != null) OnModelChanged(this, new System.EventArgs());
			}
		}

		#endregion

		#region Eventos
		public event EventHandler OnModelChanged;
		#endregion

	}

}
