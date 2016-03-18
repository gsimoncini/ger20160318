using System;
using System.Collections;
using System.Data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de VisualizacionDeStock.
	/// </summary>
	public class VisualizacionDeStock
	{
		#region Constructores
		
		public VisualizacionDeStock(string IdVisualizacionDeStock)
		{
			Init(IdVisualizacionDeStock);
		}

		#endregion

		#region Variables Privadas

			private string _idVisualizacionDeStock = string.Empty;
			private string _descripcion = string.Empty;
			private string _idProducto = string.Empty;
			private ArrayList _detalle = new ArrayList();
			

		#endregion

		#region Metodos Privados

		private void Init(string IdVisualizacionDeStock)
		{
			DataRow row;
			row = mz.erp.businessrules.tlg_VisualizacionDeStock.GetByPk(IdVisualizacionDeStock);
			if(row != null)
			{
				_idVisualizacionDeStock = IdVisualizacionDeStock;
				_descripcion = Convert.ToString(row["Descripcion"]);
				DataSet data = mz.erp.businessrules.tlg_VisualizacionDeStockDet.GetList(_idVisualizacionDeStock,null,short.MinValue);
				foreach(DataRow rowDet in data.Tables[0].Rows)
				{
					ItemVisualizacionDeStock item = new ItemVisualizacionDeStock();
					item.IdEstadoDeStock = Convert.ToString(rowDet["IdEstadoDeStock"]);
					item.Operacion = Convert.ToInt16(rowDet["Operacion"]);
					this._detalle.Add(item);
				}
			}
		}

		#endregion

		#region Metodos Publicos
		
		public decimal CalcularStock(string IdProducto)
		{
			return mz.erp.businessrules.tlg_VisualizacionDeStock.CalculateStock(IdProducto, this._idVisualizacionDeStock);			
		}

		#endregion
	}

	public sealed class ItemVisualizacionDeStock
	{
		#region Constructores
		public ItemVisualizacionDeStock()
		{

		}
		#endregion

		#region Variables Privadas
			
			private string _idDeposisto = string.Empty;
			private string _idSeccion = string.Empty;
			private string _idEstadoDeStock = string.Empty;
			private short _operacion = 0;
			private decimal _cantidad = 0;
			
		
		#endregion

		#region Propiedades

		public string IdDeposito
		{
			get{return _idDeposisto;}
			set{_idDeposisto = value;}
		}

		public string IdSeccion
		{
			get{return _idSeccion;}
			set{_idSeccion = value;}
		}

		public string IdEstadoDeStock
		{
			get{return _idEstadoDeStock;}
			set{_idEstadoDeStock = value;}
		}

		public short Operacion 
		{
			get{return _operacion;}
			set{_operacion = value;}
		}

		public decimal Cantidad
		{
			get{return _cantidad;}
			set{_cantidad = value;}
		}

		#endregion

	}
}
