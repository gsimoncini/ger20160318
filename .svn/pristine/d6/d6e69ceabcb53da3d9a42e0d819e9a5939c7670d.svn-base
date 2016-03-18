// Modelo estático
using System;
using mz.erp.commontypes;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Contiene una instancia de un objeto impuesto. Asociado a una coleccion de impuestos.
	/// </summary>
	public class Impuesto: DataObject
	{
		/// <summary>
		/// Crea una nueva instancia de un impuesto
		/// </summary>
		/// <param name="sender">
		/// La coleccion de impuestos que lo contiene
		/// </param>
		/// <param name="idImpuesto">
		/// El codigo del impuesto. Relación con la tabla tsy_Impuestos del RDBM
		/// </param>
		/// <param name="descripcion">
		/// La descripcion del impuesto
		/// </param>
		/// <param name="aplicadoA">
		/// A que entidad aplica el impuesto.
		/// Valor constante puede ser los que se definieron en el documento Aplicación de Impuestos variables a Comprobantes de Venta
		/// </param>
		/// <param name="formulaDeCalculo"></param>
		/// 

		
		public Impuesto(string idImpuesto,string Impuesto, string descripcion,string descripcionCorta, string descripcionLarga,  string aplicadoA, string formulaDeCalculo, decimal Alicuota )
		{
			
			_aplicadoA = aplicadoA;
			_formula = formulaDeCalculo;
			_nombre = descripcion;
			_idImpuesto = idImpuesto;
			_key = Impuesto;
			_descripcionCorta = descripcionCorta;
			_descripcionLarga = descripcionLarga;
			_alicuota = Alicuota;
		}


		public Impuesto( Impuestos sender , string idImpuesto,string Impuesto, string descripcion,string descripcionCorta, string descripcionLarga,  string aplicadoA, string formulaDeCalculo, decimal Alicuota )
		{
			_impuestos = sender;
			_aplicadoA = aplicadoA;
			_formula = formulaDeCalculo;
			_nombre = descripcion;
			_idImpuesto = idImpuesto;
			_key = Impuesto;
			_descripcionCorta = descripcionCorta;
			_descripcionLarga = descripcionLarga;
			_alicuota = Alicuota;
		}
		

		private string _descripcionCorta = string.Empty;
		private string _descripcionLarga = string.Empty;
		private Impuestos _impuestos;
		private decimal _alicuota = 0;
		private decimal _alicuotaMonto = 0;
		
		/// <summary>
		/// Retorna la coleccion de impuestos que contiene a la instancia del impuesto
		/// </summary>
		/// 

		public decimal Alicuota
		{
			get{return _alicuota;}
			set {_alicuota = value;}
		}
		public decimal AlicuotaMonto
		{
			get {return _alicuotaMonto;}
			set {_alicuotaMonto = value;}
		}
		public Impuestos Impuestos
		{
			get { return _impuestos; }
		}

        
		public string DescripcionLarga
		{
			get{return _descripcionLarga;}
		}
        
		public string DescripcionCorta
		{
			get{return _descripcionCorta;}
		}
		

		private string _aplicadoA;
		/// <summary>
		/// Retorna a quien aplica el impuesto
		/// Valor constante puede ser los que se definieron en el documento Aplicación de Impuestos variables a Comprobantes de Venta
		/// </summary>
		public string AplicadoA
		{
			set { _aplicadoA = value; }
			get	{ return _aplicadoA; }
	
		}

		private string _idImpuesto;
		/// <summary>
		/// Retorna el código del impuesto. Correspondencia con al tabla impuestos.
		/// </summary>
		public string IdImpuesto
		{
			set { _idImpuesto = value; }
			get { return _idImpuesto; }
		}

		private string _key = string.Empty;

		public string Key
		{
			get{return _key;}
			set{_key = value;}
		}

		private string _nombre;
		/// <summary>
		/// Retorna el nombre descriptivo del impuesto
		/// </summary>
		public string Nombre
		{
			get { return _nombre; }
			set	{ _nombre = value; }
		}

		private bool _isDirty = true;
		public bool IsDirty
		{
			get
			{
				return _isDirty;
			}
			set
			{
				_isDirty = value;
			}
		}
		private decimal _valor = 0;
		/// <summary>
		/// Calcula el valor del impuesto. Invoca a la función de calculo de impuestos cada vez
		/// que se lo solicita
		/// </summary>
		public decimal Valor
		{
			get
			{
				if (_isDirty )
				{
					_valor = FuncionesImpuestos.Calcular( this );
					_isDirty = false;
				}
				return _valor;
			}

		}

		public decimal ValorBruto
		{
			get
			{
				/*if (_isDirty )
				{
					_valor = FuncionesImpuestos.Calcular( this, this.Impuestos.ItemComprobante.PrecioDeVentaBruto );
				/*	_isDirty = false;
				}*/
				return FuncionesImpuestos.Calcular( this, this.Impuestos.ItemComprobante.PrecioDeVentaBruto );;
			}

		}

		private decimal _valorEditable = 0;
		public decimal ValorEditable
		{
			get
			{
				return _valorEditable;
			}
			set
			{
				_valorEditable = value;
			}
		}
		/// <summary>
		/// Multiplica el valor del impuesto por la cantidad de items que contiene la instancia
		/// items que contiene la coleccion de impuestos que contiene esta intancia del impuesto
		/// </summary>
		public decimal SubTotalImpuesto
		{
			get
			{
				if(_impuestos != null)
				{
					ItemComprobante item = _impuestos.ItemComprobante;
					return Convert.ToDecimal(Valor * item.Cantidad);
				}
				return 0;
			}
		}

		private string _formula;
		/// <summary>
		/// Retorna la formula de aplicación. Dinamica. Definida por el implementador y almacenada en el RDBM
		/// </summary>
		public string Formula
		{
			get { return _formula; }
			set	{ _formula = value;	}
		}

		/// <summary>
		/// Escribe los datos de la intancia que estan en memoria en el dataset de comprobantes de venta para
		/// dejarlos listo para enviar a la capa de acceso a datos y almacenarlo en el RDBM
		/// </summary>
		public override void Commit()
		{
			ComprobanteDeVenta comprobante = this.Impuestos.ItemComprobante.ItemsComprobantes.ComprobanteDeVenta;
			tsa_ComprobantesExDataset data = this.Impuestos.ItemComprobante.ItemsComprobantes.ComprobanteDeVenta.DatasetComprobante;
			tsa_ComprobantesExDataset.tsa_ComprobanteDetalleImpuestosRow row = data.tsa_ComprobanteDetalleImpuestos.Newtsa_ComprobanteDetalleImpuestosRow();

			row.AplicadoA = this._aplicadoA;
			row.Ordinal = this.Impuestos.ItemComprobante.Ordinal;
			row.Valor = this.Valor;
			row.IdImpuesto = this.IdImpuesto;
			

			row.Fecha = comprobante.FechaComprobante;
			row.IdComprobante = ((tsa_ComprobantesExDataset.tsa_ComprobantesRow)data.tsa_Comprobantes.Rows[0]).IdComprobante;
			row.IdTipoDeComprobante = comprobante.TipoComprobanteDestino;
			row.Numero = ((tsa_ComprobantesExDataset.tsa_ComprobantesRow)data.tsa_Comprobantes.Rows[0]).Numero;
			
			row.IdMonedaCierre = ComprobantesRules.Contabilidad_MonedaReferencia;
			row.IdMonedaOrigen = ComprobantesRules.Contabilidad_MonedaReferencia;
			row.IdCotizacionCierre = ComprobantesRules.Contabilidad_CotizacionReferencia;

			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			row.IdReservado = 0;

			data.tsa_ComprobanteDetalleImpuestos.Addtsa_ComprobanteDetalleImpuestosRow( row );


			
		}


	}
}