using System;
using System.Collections;
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using System.Data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de Conversion.
	/// </summary>
	public class Conversion
	{

		#region Region Dinamica
		#region Propiedades Privadas
		
		private ConversionItems _items;
		private string _nombre;
		private string _descripcion;
		private tsh_ConversionesExDataset _data;

		#endregion

		#region Propiedades Publicas
		
		public tsh_ConversionesExDataset Data
		{
			get
			{
				return _data;
			}
		}

		public ConversionItems Items
		{
			get{return _items;}
			set{_items = value;}
		}

		public string Nombre
		{
			get{return _nombre;}
			set{_nombre = value;}
		}
		
		public string Descripcion
		{
			get{return _descripcion;}
			set{_descripcion = value;}
		}
			

		#endregion

		#region Contructores
			
		public Conversion ()
		{
			this._items = new ConversionItems();
		}

		#endregion
		#endregion

		#region Region Estatica
		public static ArrayList UnidadesMedidaPorDefault( string Momento )
		{
			
			string medidas = Variables.GetValueString( "Momentos."+Momento+ ".MedidasPorDefault");
			if (medidas.CompareTo(string.Empty) == 0)
			{
				medidas = Variables.GetValueString( "Productos.MedidasPorDefault");
			}
			ArrayList array = Util.Parse( medidas, ",");
			ArrayList unidades = new ArrayList();
			foreach (string name in array )
			{
				unidades.Add( tsh_Unidades.GetIdUnidadbyName( name ) );
			}
			return unidades;
		}
		
		/*private static ArrayList SugerirMedidasPorPorcentual()
		{
			ArrayList result = new ArrayList();
			string aux = Variables.GetValueString("Productos.Medidas.PorcentajesSugeridos");
			ArrayList lista = mz.erp.systemframework.Util.Parse("0,10,15,20,25",",");
			ConversionItem item = _conversion.Items.Get(0);
			foreach(string procentaje in lista)
			{	
				PorcentajeSugeridoItem psi = new PorcentajeSugeridoItem();
				psi.Porcentaje = Convert.ToDecimal(procentaje);
				psi.IncrementoOrigen = item.ValorSinConvertir*psi.Porcentaje/100;
				psi.CantidadOrigen = item.ValorSinConvertir + psi.IncrementoOrigen;
				_itemAux.ValorSinConvertir = psi.CantidadOrigen;
				psi.CantidadDestino = _itemAux.ValorConvertido;
				result.Add(psi);
			}
		}*/
		/*private static ArrayList SugerirMedidasPorCantidad()
		{
			ArrayList result = new ArrayList();
			string aux = Variables.GetValueString("Productos.Medidas.PorcentajesSugeridos");
			ArrayList lista = mz.erp.systemframework.Util.Parse("0,10,15,20,25",",");
			ConversionItem item = _conversion.Items.Get(0);
			foreach(string procentaje in lista)
			{	
				PorcentajeSugeridoItem psi = new PorcentajeSugeridoItem();
				psi.Porcentaje = Convert.ToDecimal(procentaje);
				psi.IncrementoOrigen = item.ValorSinConvertir*psi.Porcentaje/100;
				psi.CantidadOrigen = item.ValorSinConvertir + psi.IncrementoOrigen;
				_itemAux.ValorSinConvertir = psi.CantidadOrigen;
				psi.CantidadDestino = _itemAux.ValorConvertido;
				result.Add(psi);
			}
		}
		*/
		#endregion

		public void Commit()
		{
			_data = new tsh_ConversionesExDataset();
			tsh_ConversionesExDataset.tsh_ConversionesRow row = _data.tsh_Conversiones.Newtsh_ConversionesRow();
			
			row.IdConversion = mz.erp.systemframework.Util.NewStringId();
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.Nombre = this.Nombre;
			row.Descripcion = this.Descripcion;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			
			_data.tsh_Conversiones.Addtsh_ConversionesRow(row);
			short ordinal = 0;
			foreach(ConversionItem item in this.Items)
			{
				tsh_ConversionesExDataset.tsh_DetalleConversionesRow rowDetalleConv = _data.tsh_DetalleConversiones.Newtsh_DetalleConversionesRow();
				rowDetalleConv.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
				rowDetalleConv.FormulaConversion = string.Empty;
				rowDetalleConv.IdConversion = row.IdConversion;
				rowDetalleConv.IdEmpresa = Security.IdEmpresa;
				rowDetalleConv.IdSucursal = Security.IdSucursal;
				rowDetalleConv.IdUnidadOrigen = item.IdUnidadOrigen;
				rowDetalleConv.IdUnidadDestino = item.IdUnidadDestino;
				rowDetalleConv.Ordinal = ordinal;
				rowDetalleConv.ValorConversion = item.ValorConversion;
				rowDetalleConv.IdConexionCreacion = Security.IdConexion;
				rowDetalleConv.IdConexionUltimaModificacion = Security.IdConexion;
				rowDetalleConv.IdReservado = 0;
				rowDetalleConv.RowId = Guid.Empty;
				rowDetalleConv.IsDefault = true;
				_data.tsh_DetalleConversiones.Addtsh_DetalleConversionesRow(rowDetalleConv);
			
				ordinal++;
			}
			

		}

	}
}
