using System;
using mz.erp.commontypes.data;
using mz.erp.commontypes.CommonInterfaces;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de TipoDeComprobante.
	/// </summary>
	public class TipoDeComprobante:IComparable, IToolTip
	{

		public TipoDeComprobante()
		{

		}

		#region Propiedades públicas

		private bool _sourceBD = false;
		public bool SourceBD
		{
			get{return _sourceBD;}
			set{_sourceBD = value;}
		}

		private bool _agregado = false;
		public bool Agregado
		{
			get{return _agregado;}
			set{_agregado = value;}
		}

		private string _idTipoComprobante = string.Empty;
		public string IdTipoComprobante
		{
			get { return _idTipoComprobante; }
			set
			{
				_idTipoComprobante = value;
			}
		}

		private string _descripcion = string.Empty;
		public string Descripcion
		{
			get { return _descripcion; }
			set
			{
				_descripcion = value;
			}
		}

		private string _mascara = string.Empty;
		public string Mascara
		{
			get { return _mascara; }
			set
			{
				_mascara = value;
			}
		}

		private int _signo;
		public int Signo
		{
			get { return _signo; }
			set
			{
				_signo = value;
			}
		}

		private bool _activo = false;
		public bool Activo
		{
			get { return _activo; }
			set
			{
				_activo = value;
			}
		}

		private bool _requiereCondicionDeVenta = false;
		public bool RequiereCondicionDeVenta
		{
			get { return _requiereCondicionDeVenta; }
			set
			{
				_requiereCondicionDeVenta = value;
			}
		}

		private string _familia = string.Empty;
		public string Familia
		{
			get { return _familia; }
			set
			{
				_familia = value;
			}
		}

		private int _signoCuentaCorriente;
		public int SignoCuentaCorriente
		{
			get { return _signoCuentaCorriente; }
			set
			{
				_signoCuentaCorriente = value;
			}
		}

		private bool _afectaCuentaCorriente = false;
		public bool AfectaCuentaCorriente
		{
			get { return _afectaCuentaCorriente; }
			set
			{
				_afectaCuentaCorriente = value;
			}
		}

		private int _tipoCuentaCorriente;
		public int TipoCuentaCorriente
		{
			get { return _tipoCuentaCorriente; }
			set
			{
				_tipoCuentaCorriente = value;
			}
		}

		#endregion

		#region Métodos privados
		private void Init() 
		{
			this.GetTipoDeComprobante_IdTipoDeComprobante(_idTipoComprobante);
		}
	
		// COMPLETAR, MIRAR BIEN QUE ES LO QUE RECUPERO Y GUARDO
		private void FillStaticData(Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow row) 
		{			/* 
			if (row !=null)
			{
				this._activo = row.IdCondicionDeVenta;
				this._
				row.IdTDCompTesoreria;
				row.IdTipoDeComprobante;
				row.IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria;
				row.MetodoDeAsignacion;	
							
				}*/

		}
		#endregion

		#region Métodos públicos
		public void GetTipoDeComprobante_IdTipoDeComprobante(string IdTipoDeComprobante) 
		{
			Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow row = mz.erp.dataaccess.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.GetByPk(IdTipoDeComprobante);
			this.FillStaticData(row);

		}

		public override string ToString()
		{
			return _idTipoComprobante;
		}

		public TipoDeComprobante ShallowClone()
		{
			return (TipoDeComprobante)this.MemberwiseClone();
		}
		
		#endregion

		#region Miembros de IComparable

		public int CompareTo(object obj)
		{
			TipoDeComprobante tdc = (TipoDeComprobante)obj;
			int result = tdc.Descripcion.CompareTo(this.Descripcion);
			return result;
		}

		#endregion

		#region Miembros de IToolTip

		public string ToStringToolTip()
		{
			return _descripcion;
		}

		#endregion


	}
}
