using System;

namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Descripción breve de FormaDePago.
	/// </summary>
	public class FormaDePago:IComparable
	{
		public FormaDePago()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		private string _idFormaDePago= string.Empty;
		private string _idTDComprobante= string.Empty;
		private string _idEntidad= string.Empty;
		private decimal _recargo = 0;
		private string _idMoneda= string.Empty;
		private string _idCotizacion= string.Empty;
		private bool _agrupado = false;
		private FormasDePagos _detalle;
		private string _descripcionMoneda= string.Empty;
		private string _descripcionComprobante= string.Empty;
		private string _descripcionEntidad= string.Empty;
		private int _cuotas = 1;
		private bool _hasDetail = false;
		private decimal _importeConRecargo = 0;
		private decimal _valorDeLaCuota = 0;
		private string _descripcion = string.Empty;
		private int _orden = 0;
	
		// Sirve para ver si la forma de pago ya esta en la BD
		private bool _sourceBD = false;				
		private bool _agregada = false;

		public bool SourceBD
		{
			get{return _sourceBD;}
			set{_sourceBD = value;}
		}

		public bool Agregada
		{
			get{return _agregada;}
			set{_agregada = value;}
		}

		public int Orden
		{
			get{return _orden;}
			set{_orden = value;}
		}

		private Valor _valor;

		public void BuildDescription()
		{
			if(Agrupado)
				Descripcion = DescripcionComprobante +" " +DescripcionEntidad;
			else
				Descripcion = DescripcionComprobante +" " +  DescripcionMoneda + " " +DescripcionEntidad;
			if(Cuotas > 1)
				Descripcion = Descripcion + " " + Convert.ToString(Cuotas) + " Cuotas";
			if(Recargo > 0)
				Descripcion = Descripcion + " .Rcgo: " +Convert.ToString(decimal.Round(Recargo,2)) + " %";

		}

		public string Descripcion 
		{
			get
			{
				return _descripcion;
			}
			set
			{
				_descripcion = value;
			}
		}



		
		public void SetIdTDCompTesoreria (string i)
		{
			_idTDComprobante=i;
		}
		public string GetIdTDCompTesoreria()
		{
			return _idTDComprobante;
		}
		public void SetIdEntidad (string i)
		{
			_idEntidad=i;
		}
		public string GetIdEntidad()
		{
			return _idEntidad;
		}
		public void SetIdMoneda(string i)
		{
			_idMoneda=i;
		}
		public string GetIdMoneda()
		{
			return _idMoneda;
		}
		public void SetIdCotizacion(string i)
		{
			_idCotizacion=i;
		}
		public string GetIdCotizacion()
		{
			return _idCotizacion;
		}
		public void SetIdFormaDePago(string i)
		{
			_idFormaDePago=i;
		}
		public string GetIdFormaDePago()
		{
			return _idFormaDePago;
		}

		public Valor Valor
		{
			get
			{
				return _valor;
			}
			set
			{
				_valor = value;
			}
		}

		public decimal ImporteConRecargo
		{
			get { return _importeConRecargo; }
			set { _importeConRecargo = value; }
		}
		public decimal ValorDeLaCuota
		{
			get { return _valorDeLaCuota ; }
			set { _valorDeLaCuota = value ; }
		}

		public string DescripcionMoneda
		{
			set 
			{
				  _descripcionMoneda = value;
			}
		
			get
			{
				return _descripcionMoneda ;
			}
		}
		public string DescripcionEntidad
		{
			set 
			{
				 _descripcionEntidad = value;
			}
		
			get
			{
				return _descripcionEntidad ;
			}
		}
		public string DescripcionComprobante
		{
			set 
			{
				_descripcionComprobante = value;
			}
		
			get
			{
				return _descripcionComprobante;
			}
		}

		public decimal Recargo
		{
			set 
			{
				_recargo = value ;
			}
		
			get
			{
				return _recargo;
			}
		}
		public int Cuotas
		{
			set 
			{
				_cuotas = value ;
			}
		
			get
			{
				return _cuotas;
			}
		}
		public FormasDePagos Detalle
		{
			set 
			{
				 _detalle = value;

			}
		
			get
			{
				return _detalle;
			}
		}
		public bool Agrupado
		{
				
			get
			{
				return _agrupado;
			}
			set
			{
				_agrupado= value;
			}
		}
		public bool HasDetail
		{
				
			get
			{
				return _hasDetail;
			}
			set
			{
				_hasDetail= value;
			}
		}
		public string IdFormaDePago
		{
			set 
			{
				_idFormaDePago = value ;
			}
		
			get
			{
				return _idFormaDePago;
			}
		}

		public string IdTDComprobante
		{
			get
			{
				return _idTDComprobante;
			}
			set
			{
				_idTDComprobante = value;
			}
		}

		public string IdMoneda
		{
			get
			{
				return _idMoneda;
			}
			set
			{
				_idMoneda = value;
			}


		}
		#region Miembros de IComparable

		public int CompareTo(object obj)
		{
			FormaDePago fdp = (FormaDePago)obj;
			int result = fdp.DescripcionComprobante.CompareTo(this.DescripcionComprobante);
			if(result != 0) return result;
			else
			{
				result = fdp._idMoneda.CompareTo(this._idMoneda);
				if(result != 0) return result;
				else
				{
					result = fdp._idEntidad.CompareTo(this._idEntidad);
					if(result != 0) return result;
					else
					{
						result = fdp._cuotas.CompareTo(this._cuotas);
						return result;
					}

				}

			}
		}

		#endregion

		public override string ToString()
		{
			return _descripcion;
		}

		public FormaDePago ShallowClone()
		{
			return (FormaDePago)this.MemberwiseClone();
		}
	}
}
