
using System;
using System.Data;
using System.Text;
using System.Collections;
    
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;

using mz.erp.businessrules;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de DetalleArticulosPorCompra.
	/// </summary>
	public class DetalleArticulosPorCompra: IDetailController
	{
		public DetalleArticulosPorCompra()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		private object _source;

		#region Miembros de IDetailController

		public void SetObject(object obj)
		{
			_source = obj;
		}

		public string GetLayout()
		{
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			sb.Append( LayoutBuilder.GetRow( i++, "NumeroDeSerie", "Nº de Serie", 300 ,Types.EditType.NoEdit));
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}

		public object RefreshData()
		{
			
			
			return mz.erp.businessrules.reportes.rep_DetalleListadoDeComprasPorArt.GetList(_source).Tables[0];


		}

		public string GetCaption()
		{
			return "Detalle de Numeros de Serie";
		}

		#endregion
	}
}
