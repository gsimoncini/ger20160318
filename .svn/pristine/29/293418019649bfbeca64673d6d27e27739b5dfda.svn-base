using System;
using mz.erp.commontypes.data;
using System.Data;

namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Descripción breve de Cotizacion.
	/// </summary>
	public class Cotizacion
	{
		public Cotizacion()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		private string _idCotizacion = string.Empty;
		private string _idMonedaOrigen = string.Empty;
		private string _idMonedaDestino = string.Empty;
		private decimal _valor = 1;
		private string _idFuenteDeCambio = string.Empty;
		private string _monedaOrigen = string.Empty;
		private string _monedaDestino = string.Empty;
		private string _fuenteDeCambio = string.Empty;

		public string IdMonedaOrigen 
		{
			get { return _idMonedaOrigen ;}
			set 
			{
				_idMonedaOrigen = value ;
				if(_idMonedaOrigen != null && !_idMonedaOrigen.Equals(string.Empty))
				{
					DataRow row = mz.erp.businessrules.tfi_Monedas.GetByPk(_idMonedaOrigen);
					if(row != null)
						_monedaOrigen = Convert.ToString(row["Descripcion"]);
				}
			}

		}
		public string IdMonedaDestino 
		{
			get { return _idMonedaDestino;}
			set 
			{
				_idMonedaDestino= value ;
				if(_idMonedaDestino != null && !_idMonedaDestino.Equals(string.Empty))
				{
					DataRow row = mz.erp.businessrules.tfi_Monedas.GetByPk(_idMonedaDestino);
					if(row != null)
						_monedaDestino = Convert.ToString(row["Descripcion"]);
				}
			}

		}

		public string IdCotizacion
		{
			get { return _idCotizacion;}
			set {_idCotizacion= value ;}

		}

		public decimal Valor
		{
			get {return _valor;}
			set {_valor = value;}

		}

		public string IdFuenteDeCambio
		{
			get{return _idFuenteDeCambio;}
			set
			{
				_idFuenteDeCambio = value;
				if(_idFuenteDeCambio != null && !_idFuenteDeCambio.Equals(string.Empty))
				{
					DataRow row = mz.erp.businessrules.tfi_FuentesDeCambio.GetByPk(_idFuenteDeCambio);
					if(row != null)
						_fuenteDeCambio = Convert.ToString(row["Descripcion"]);
				}
			}
		}

	}


	public class CotizacionWrapper
	{
		private Cotizacion _cotizacion;
		private bool _isValid = false;
		
		public CotizacionWrapper(Cotizacion cotizacion)
		{
			_cotizacion = cotizacion;
			_isValid = true;
		}

		public CotizacionWrapper(string IdMonedaOrigen, string IdMonedaDestino, string IdFuenteDeCambio)
		{
			_cotizacion = new Cotizacion();
			_cotizacion.IdMonedaOrigen = IdMonedaOrigen;
			_cotizacion.IdMonedaDestino = IdMonedaDestino;
			_cotizacion.IdFuenteDeCambio = IdFuenteDeCambio;
			GenerateCotizacion();
		}

		
		public CotizacionWrapper(string IdCotizacion)
		{
			_cotizacion =  mz.erp.businessrules.tfi_CotizacionesMonedas.GetCotizacion(IdCotizacion);
			_isValid = true;
		}
		

		public bool IsValid
		{
			get{return _isValid;}
		}

		public string IdCotizacion
		{
			get{return _cotizacion.IdCotizacion;}
		}

		public string IdMonedaOrigen
		{
			get{return _cotizacion.IdMonedaOrigen;}
			set
			{
				if(value != _cotizacion.IdMonedaOrigen)
				{
					_cotizacion.IdMonedaOrigen = value;
					GenerateCotizacion();
				}
			}
		}

		public string IdMonedaDestino
		{
			get{return _cotizacion.IdMonedaDestino;}
		}

		public decimal Valor 
		{
			get{return _cotizacion.Valor;}
		}

		public string IdFuenteDeCambio
		{
			get{return _cotizacion.IdFuenteDeCambio;}
			set
			{
				if(value != _cotizacion.IdFuenteDeCambio)
				{
					_cotizacion.IdFuenteDeCambio = value;
					GenerateCotizacion();
				}
			}
		}


		private void GenerateCotizacion()
		{
			Cotizacion cotAux =  mz.erp.businessrules.tfi_CotizacionesMonedas.GetCoeficienteCotizacion(_cotizacion.IdMonedaOrigen, _cotizacion.IdMonedaDestino, _cotizacion.IdFuenteDeCambio);
			if(cotAux != null)
			{
				_cotizacion.IdCotizacion = cotAux.IdCotizacion;
				_cotizacion.IdMonedaOrigen = cotAux.IdMonedaOrigen;
				_cotizacion.IdFuenteDeCambio = cotAux.IdFuenteDeCambio;
				_cotizacion.Valor = cotAux.Valor;
				_isValid = true;
			}
			else _isValid = false;
			
		}
	}
}
