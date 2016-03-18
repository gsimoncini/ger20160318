using System;
using System.Collections;
using System.Data;

namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Descripción breve de OrdenesDeComprasItems.
	/// </summary>
	public class OrdenesDeComprasItems
	{
		private Hashtable _items = new Hashtable();

		public OrdenesDeComprasItems()
		{
		}

		public void LoadItems(ArrayList ListaIdComprobantes)
		{
			_items.Clear();
			foreach(string IdComprobanteDestino in ListaIdComprobantes)
			{
				DataSet data = mz.erp.dataaccess.tpu_OrdenesDeComprasRemitos.GetItems(IdComprobanteDestino);
				foreach(DataRow row in data.Tables[0].Rows)
				{
					OrdenDeCompraItem item = new OrdenDeCompraItem(row);
					item.AddOrigen(new RelacionComprobanteDeCompraOrigen(item.IdComprobanteOrigen, item.OrdinalOrigen, item.CantidadOrigen, item.CantidadOrigen, item.PrecioDeCosto));
					string clave = item.IdComprobanteDestino + "-" + Convert.ToString(item.OrdinalDestino);
					if(!_items.Contains(clave))
						_items.Add(clave, item);
					else
					{
						OrdenDeCompraItem it = (OrdenDeCompraItem)_items[clave];
						it.OrigenMultiple = true;
						if((it.PrecioDeCosto * it.ValorCotizacion) >= (item.PrecioDeCosto * item.ValorCotizacion))
						{
							it.PrecioDeCosto = item.PrecioDeCosto;
							it.IdMoneda = item.IdMoneda;
							it.IdFuenteDeCambio = item.IdFuenteDeCambio;
							it.ValorCotizacion = item.ValorCotizacion;
							it.OrdinalOrigen = item.OrdinalOrigen;
							it.IdComprobanteOrigen = item.IdComprobanteOrigen;
							it.NumeroComprobanteOrigen = item.NumeroComprobanteOrigen;
							it.FechaComprobanteOrigen = item.FechaComprobanteOrigen;
							
						}
						it.CantidadOrigen = it.CantidadOrigen + item.CantidadOrigen;
						it.AddOrigen(new RelacionComprobanteDeCompraOrigen(item.IdComprobanteOrigen, item.OrdinalOrigen, item.CantidadOrigen, item.CantidadOrigen, item.PrecioDeCosto));

						


					}
				}
			}
		}

		public OrdenDeCompraItem GetItem(string IdComprobanteDestino, long OrdinalDestino)
		{
			if(IdComprobanteDestino != null)
			{
				string clave = IdComprobanteDestino + "-" + Convert.ToString(OrdinalDestino);
				if(_items.Contains(clave))
					return (OrdenDeCompraItem)_items[clave];
			}
			return null;
		}

	}

	public class OrdenDeCompraItem
	{
		
		#region Constructores
	
		public OrdenDeCompraItem(DataRow row)
		{
			_idComprobanteOrigen = Convert.ToString(row["IdComprobanteOrigen"]);
			_idComprobanteDestino = Convert.ToString(row["IdComprobanteDestino"]);
			_ordinalOrigen = Convert.ToInt64(row["OrdinalOrigen"]);
			_ordinalDestino = Convert.ToInt64(row["OrdinalDestino"]);
			_cantidadOrigen = Convert.ToDecimal(row["CantidadOrigen"]);
			_cantidadDestino = Convert.ToDecimal(row["CantidadDestino"]);
			_idProducto = Convert.ToString(row["IdProducto"]);
			_idMoneda = Convert.ToString(row["IdMonedaOrigen"]);
			_idFuenteDeCambio = Convert.ToString(row["IdFuenteDeCambioProveedor"]);
			_valorCotizacion = Convert.ToDecimal(row["ValorCotizacionProveedor"]);
			_precioDeCosto =  Convert.ToDecimal(row["PrecioDeCostoMonedaOrigen"]);
			_fechaComprobanteOrigen = Convert.ToDateTime(row["Fecha"]);
			_numeroComprobanteOrigen = Convert.ToString(row["Numero"]);
			
		}
		
		#endregion

		#region Variables Privadas
		
		private string _idProducto = string.Empty;
		private long _ordinalOrigen = 0;
		private string _idComprobanteOrigen = string.Empty;
		private long _ordinalDestino = 0;
		private string _idComprobanteDestino = string.Empty;
		private decimal _cantidadOrigen = 0;
		private decimal _cantidadDestino = 0;
		private decimal _precioDeCosto = 0;
		private string _idMoneda = string.Empty;
		private string _idFuenteDeCambio = string.Empty;
		private decimal _valorCotizacion = 1;
		private DateTime _fechaComprobanteOrigen = DateTime.Now;
		private string _numeroComprobanteOrigen = string.Empty;
		private bool _origenMultiple = false;
		private ArrayList _origenes = new ArrayList();
		
		

		#endregion

		public void AddOrigen(RelacionComprobanteDeCompraOrigen origen)
		{
			this._origenes.Add(origen);
			
		}

		#region Variables Publicas

		public bool OrigenMultiple
		{
			get{return _origenMultiple;}
			set{_origenMultiple = value;}
		}

		public DateTime FechaComprobanteOrigen
		{
			get{return _fechaComprobanteOrigen;}
			set{_fechaComprobanteOrigen = value;}
		}

		public string NumeroComprobanteOrigen
		{
			get{return _numeroComprobanteOrigen;}
			set{_numeroComprobanteOrigen = value;}
		}

		
		public decimal ValorCotizacion
		{
			get{return _valorCotizacion;}
			set{_valorCotizacion = value;}
		}

		public string IdFuenteDeCambio
		{
			get{return _idFuenteDeCambio;}
			set{_idFuenteDeCambio = value;}
		}

		public string IdMoneda
		{
			get{return _idMoneda;}
			set{_idMoneda = value;}
		}

		public decimal PrecioDeCosto
		{
			get{return _precioDeCosto;}
			set{_precioDeCosto = value;}
		}

		public string IdComprobanteDestino
		{
			get{return _idComprobanteDestino;}
		}

		public string IdComprobanteOrigen
		{
			get{return _idComprobanteOrigen;}
			set{_idComprobanteOrigen = value;}
		}

		public long OrdinalOrigen
		{
			get{return _ordinalOrigen;}
			set{_ordinalOrigen = value;}
		}
			
		public long OrdinalDestino
		{
			get{return _ordinalDestino;}
		}

		public string IdProducto
		{
			get{return _idProducto;}
		}
		
		public decimal CantidadOrigen
		{
			get{return _cantidadOrigen;}
			set{_cantidadOrigen = value;}
		}

		public decimal CantidadDestino
		{
			get{return _cantidadDestino;}
		}

		#endregion


	}
}
