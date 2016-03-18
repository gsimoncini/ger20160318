using System;
using System.Collections;

namespace mz.erp.businessrules.comprobantes
{
	using mz.erp.commontypes.data;
	/// <summary>
	/// Descripción breve de MovimientoDeCaja.
	/// </summary>
	public class MovimientoDeCaja
	{
		public MovimientoDeCaja()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		private string _idMovimientoDeCaja= string.Empty;
		private string _idResponsable= string.Empty;
		private string _idInstanciaDeCaja= string.Empty;
		private string _idMonedaCierre= string.Empty;
		private string _idCotizacionCierre= string.Empty;
		private string _idTipoMovimiento= string.Empty;
		private string _idSubTipoMovimiento= string.Empty;
		private string _numero = string.Empty;
		private ArrayList _valores;
		private string _descripcionTipoMovimiento= string.Empty;
		private string _descripcionSubTipoMovimiento= string.Empty;
		private int _signo;
		private decimal _total;
		private DateTime _fecha;
		private string _observaciones= string.Empty;

	
		public event EventHandler	TotalChanged;


		public string Observaciones
		{
			get	{return _observaciones;	}
			set	{_observaciones = value;}
		}

		public string IdMovimientoDeCaja
		{	
			get { return _idMovimientoDeCaja ;}
			set { _idMovimientoDeCaja = value ;}
		}

		public string IdResponsable
		{	
			get { return _idResponsable;}
			set { _idResponsable= value ;}
		}

		public string IdInstanciaDeCaja
		{	
			get { return _idInstanciaDeCaja;}
			set { _idInstanciaDeCaja= value ;}
		}
		
		public string IdCotizacionCierre
		{	
			get { return _idCotizacionCierre;}
			set { _idCotizacionCierre= value ;}
		}

		public string IdMonedaCierre
		{	
			get { return _idMonedaCierre;}
			set { _idMonedaCierre= value ;}
		}

		public string IdTipoMovimiento
		{	
			get { return _idTipoMovimiento;}
			set { _idTipoMovimiento= value ;}
		}

		public string IdSubTipoMovimiento
		{	
			get { return _idSubTipoMovimiento;}
			set { _idSubTipoMovimiento= value ;}
		}

		public string Numero
		{	
			get { return _numero;}
			set { _numero= value ;}
		}

		public string DescripcionTipoMovimiento
		{	
			get { return _descripcionTipoMovimiento;}
			set { _descripcionTipoMovimiento= value ;}
		}

		public string DescripcionSubTipoMovimiento
		{	
			get { return _descripcionSubTipoMovimiento;}
			set { _descripcionSubTipoMovimiento= value ;}
		}

		public int Signo
		{	
			get { return _signo;}
			set { _signo= value ;}
		}

		public decimal Total
		{	
			get { return _total;}
			set 
			{
				if (_total != value) 
				{
					_total= value ;
					if (TotalChanged != null)
						TotalChanged(this, new EventArgs());
				}
			}
		}

		public DateTime Fecha
		{
			get {return _fecha;}
			set 
			{
				DateTime actual = mz.erp.businessrules.Sistema.DateTime.Now;
				_fecha = new DateTime(value.Year, value.Month,value.Day, actual.Hour, actual.Minute, actual.Second, actual.Millisecond);
			}
		}


		public ArrayList Valores
		{
			get{return _valores;}
			set {_valores = value;}
		}

		public void AddValor(Valor valor)
		{
			this.Valores.Add(valor);
			valor.ValorChange += new Valor.ValorChangeEventHandler(Recalcular);
		}

		public void Recalcular()
		{
			decimal total=0;
			foreach (Valor valor in this.Valores)
			{
				total = total + valor.MontoCotizado;
			}	
			this.Total= total;
		}

		public void EliminarValor (ArrayList valores, int posicion, tfi_ValoresExDataset data)
		{
			string IdValor = ((Valor)Valores[posicion]).IdValor;
			valores.RemoveAt(posicion);
			mz.erp.businessrules.data.tfi_ValoresEx.EliminarValor(data, IdValor);
		}
	}
}
