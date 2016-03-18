using System;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using System.Data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de AuditoriaControlCajas.
	/// </summary>
	public class AuditoriaControlCajas
	{
		#region Constructores
		public AuditoriaControlCajas(string Cajero)
		{
			_cajero = Cajero;
			_estado = "NEW";
			//comienza a contar el tiempo q se tarda desde q se crea hasta q se guarda
			_horaInicial = DateTime.Now;
			
		}
		#endregion

		#region Variables privadas
		private long _idAuditoria;
		private DateTime _fecha = DateTime.Now;
		private DateTime _fechaCierre;
		private string _cajero = string.Empty;
		private string _idInstanciaCaja = string.Empty;
		private long _tiempo = 0;
		private bool _auditadoSupervisor = false;
		private bool _auditadoGerente = false;
		private bool _esCierre = false;
		private string _estado = string.Empty;
		private ArrayList _detalle = new ArrayList();
		private DateTime _horaInicial;
		#endregion

		#region Propiedades

		public long IdAuditoria 
		{
			get{return _idAuditoria;}
			set{_idAuditoria = value;}
		}

		public DateTime Fecha 
		{
			get{return _fecha;}
			set{_fecha = value;}
		}

		public DateTime FechaCierre 
		{
			get{return _fechaCierre;}
			set{_fechaCierre = value;}
		}

		public string Cajero
		{
			get{return _cajero;}
			set{_cajero = value;}
		}
		
		public string IdInstanciaCaja 
		{
			get{return _idInstanciaCaja;}
			set{_idInstanciaCaja = value;}
		}
		
		public long Tiempo 
		{
			get{return _tiempo;}
			set{_tiempo = value;}
		}
		
		public bool AuditadoSupervisor 
		{
			get{return _auditadoSupervisor;}
			set{_auditadoSupervisor = value;}
		}
		
		public bool AuditadoGerente 
		{
			get{return _auditadoGerente;}
			set{_auditadoGerente = value;}
		}
		
		public bool EsCierre 
		{
			get{return _esCierre;}
			set{_esCierre = value;}
		}
		
		public string Estado
		{
			get{return _estado;}
			set{_estado = value;}
		}

		public ArrayList Detalle 
		{
			get{return _detalle;}
			set{_detalle = value;}
		}
		#endregion
	
		#region Métodos Públicos
		//Agrega en AuditoriaControlCajasDet y AuditoriaControlCajasDetalleBilletes
		public void AgregarItemAuditoria(string IdControlDeCajasFamiliasComprobanteTesoreria, string TDCompTesoreria, string IdMoneda, string Moneda, long CantidadInformada, decimal ValorBillete, long IdTipoBillete, string TipoBillete)
		{
			AuditoriaControlCajasDet auditoriaControlCajasDet = getAuditoriaControlCajasDet(IdControlDeCajasFamiliasComprobanteTesoreria, IdMoneda);
			if(auditoriaControlCajasDet == null)
			{
				long ordinal = _detalle.Count + 1;
				auditoriaControlCajasDet = new AuditoriaControlCajasDet(ordinal, IdControlDeCajasFamiliasComprobanteTesoreria, TDCompTesoreria, IdMoneda, Moneda);
				AuditoriaControlCajasDetalleBilletes auditoriaControlCajasDetalleBilletes = new AuditoriaControlCajasDetalleBilletes(ordinal, CantidadInformada, ValorBillete, IdTipoBillete, TipoBillete);
				auditoriaControlCajasDet.Detalle.Add(auditoriaControlCajasDetalleBilletes);
				auditoriaControlCajasDet.MontoInformado = auditoriaControlCajasDetalleBilletes.MontoInformado;
				_detalle.Add(auditoriaControlCajasDet);
				if(AuditoriaControlCajasDetalleBilletesAdded != null)
					AuditoriaControlCajasDetalleBilletesAdded(this, new AuditoriaControlCajasDetEventArgs(auditoriaControlCajasDet, auditoriaControlCajasDetalleBilletes));	
			}
			else
			{
				AuditoriaControlCajasDetalleBilletes auditoriaControlCajasDetalleBilletes = auditoriaControlCajasDet.getAuditoriaControlCajasDetalleBilletes(IdTipoBillete);
				if(auditoriaControlCajasDetalleBilletes == null)
				{
					auditoriaControlCajasDetalleBilletes = new AuditoriaControlCajasDetalleBilletes(auditoriaControlCajasDet.Ordinal, CantidadInformada, ValorBillete, IdTipoBillete, TipoBillete);
					auditoriaControlCajasDet.Detalle.Add(auditoriaControlCajasDetalleBilletes);
					auditoriaControlCajasDet.MontoInformado = auditoriaControlCajasDet.MontoInformado + auditoriaControlCajasDetalleBilletes.MontoInformado;
					if(AuditoriaControlCajasDetalleBilletesAdded != null)
						AuditoriaControlCajasDetalleBilletesAdded(this, new AuditoriaControlCajasDetEventArgs(auditoriaControlCajasDet, auditoriaControlCajasDetalleBilletes));	
				}
				else
				{
					auditoriaControlCajasDet.MontoInformado = (auditoriaControlCajasDet.MontoInformado - auditoriaControlCajasDetalleBilletes.MontoInformado);
					auditoriaControlCajasDetalleBilletes.CantidadInformada = CantidadInformada;
					auditoriaControlCajasDet.MontoInformado = auditoriaControlCajasDet.MontoInformado + auditoriaControlCajasDetalleBilletes.MontoInformado;
					if(AuditoriaControlCajasDetalleBilletesModified != null)
						AuditoriaControlCajasDetalleBilletesModified(this, new AuditoriaControlCajasDetEventArgs(auditoriaControlCajasDet, auditoriaControlCajasDetalleBilletes));	
				}
			}
		}

		//Agrega en AuditoriaControlCajasDet pues en AuditoriaControlCajasDetalleBilletes no corresponde
		public void AgregarItemAuditoria(string IdControlDeCajasFamiliasComprobanteTesoreria, string TDCompTesoreria, string IdMoneda, string Moneda, long CantidadInformada, decimal MontoInformado)
		{
			AuditoriaControlCajasDet auditoriaControlCajasDet = getAuditoriaControlCajasDet(IdControlDeCajasFamiliasComprobanteTesoreria, IdMoneda);
			if(auditoriaControlCajasDet == null)
			{
				long ordinal = _detalle.Count + 1;
				auditoriaControlCajasDet = new AuditoriaControlCajasDet(ordinal, IdControlDeCajasFamiliasComprobanteTesoreria, TDCompTesoreria, IdMoneda, Moneda, CantidadInformada, MontoInformado);
				_detalle.Add(auditoriaControlCajasDet);
				if(AuditoriaControlCajasDetAdded != null)
					AuditoriaControlCajasDetAdded(this, new AuditoriaControlCajasDetEventArgs(auditoriaControlCajasDet));	
			}
			else
			{
				auditoriaControlCajasDet.MontoInformado = MontoInformado;
				auditoriaControlCajasDet.CantidadInformada = CantidadInformada;
			}
		}

		//Elimina de AuditoriaControlCajasDet y AuditoriaControlCajasDetalleBilletes
		public void EliminarItemAuditoria(AuditoriaControlCajasDet det, AuditoriaControlCajasDetalleBilletes detB)
		{
			if(det.Detalle.Count > 1)
			{
				det.MontoInformado = det.MontoInformado - detB.MontoInformado;
				det.Detalle.Remove(detB);
			}
			else
				this.EliminarItemAuditoria(det);
		}

		//Elimina de AuditoriaControlCajasDet pues en AuditoriaControlCajasDetalleBilletes no corresponde
		public void EliminarItemAuditoria(AuditoriaControlCajasDet det)
		{
			//modifico el ordinal de los q le siguen para que queden bien numerados
			foreach(AuditoriaControlCajasDet d in _detalle)
			{
				if(d.Ordinal > det.Ordinal)
					d.Ordinal = d.Ordinal - 1;
			}
			_detalle.Remove(det);
		}
		
		public void Commit(tfi_AuditoriaControlCajasExDataset Data)
		{
			tfi_AuditoriaControlCajasExDataset.tfi_AuditoriaControlCajasRow rowA = Data.tfi_AuditoriaControlCajas.Newtfi_AuditoriaControlCajasRow();
			rowA.IdAuditoria = this.IdAuditoria;
			rowA.Fecha = DateTime.Now;
			rowA.Cajero = this.Cajero;
			rowA.IdInstanciaCaja = this.IdInstanciaCaja;
			TimeSpan difTiempo = DateTime.Now.Subtract(_horaInicial);
			double tiempoEnSegundos = difTiempo.TotalSeconds;
			rowA.Tiempo =  Convert.ToInt64(tiempoEnSegundos);
			rowA.AuditadoSupervisor = this.AuditadoSupervisor;
			rowA.AuditadoGerente = this.AuditadoGerente;
			rowA.EsCierre = this.EsCierre;
			rowA.FechaCreacion = DateTime.Now;
			rowA.IdConexionCreacion = Security.IdConexion;
			Data.tfi_AuditoriaControlCajas.Addtfi_AuditoriaControlCajasRow(rowA);
			foreach(AuditoriaControlCajasDet det in this.Detalle)
			{
				det.Commit(Data);
			}

		}
		#endregion

		#region Métodos Privados
		private AuditoriaControlCajasDet getAuditoriaControlCajasDet(string IdControlDeCajasFamiliasComprobanteTesoreria, string IdMoneda)
		{
			AuditoriaControlCajasDet det = null;
			int i = 0;
			while(det == null && i < _detalle.Count)
			{
				AuditoriaControlCajasDet d = (AuditoriaControlCajasDet)_detalle[i];
				if(d.IdControlDeCajasFamiliasComprobanteTesoreria.Equals(IdControlDeCajasFamiliasComprobanteTesoreria) && d.IdMoneda.Equals(IdMoneda))
					det = d;
				i++;
			}
			return det;
		}


		#endregion

		#region Eventos
		public delegate void AuditoriaControlCajasDetEventHandler(object sender, AuditoriaControlCajasDetEventArgs e);
		public event AuditoriaControlCajasDetEventHandler AuditoriaControlCajasDetAdded;
		public event AuditoriaControlCajasDetEventHandler AuditoriaControlCajasDetalleBilletesAdded;
		public event AuditoriaControlCajasDetEventHandler AuditoriaControlCajasDetalleBilletesModified;

		#endregion

	}

	
	public class AuditoriaControlCajasDet
	{
		#region Constructores
		public AuditoriaControlCajasDet(long Ordinal, string IdControlDeCajasFamiliasComprobanteTesoreria, string TDCompTesoreria, string IdMoneda, string Moneda)
		{
			_ordinal = Ordinal;
			_idControlDeCajasFamiliasComprobanteTesoreria = IdControlDeCajasFamiliasComprobanteTesoreria;
			_tDCompTesoreria = TDCompTesoreria;
			_idMoneda = IdMoneda;
			_moneda = Moneda;
		}

		public AuditoriaControlCajasDet(long Ordinal, string IdControlDeCajasFamiliasComprobanteTesoreria, string TDCompTesoreria, string IdMoneda, string Moneda, long CantidadInformada, decimal MontoInformado)
		{
			_ordinal = Ordinal;
			_idControlDeCajasFamiliasComprobanteTesoreria = IdControlDeCajasFamiliasComprobanteTesoreria;
			_tDCompTesoreria = TDCompTesoreria;
			_idMoneda = IdMoneda;
			_moneda = Moneda;
			_cantidadInformada = CantidadInformada;
			_montoInformado = MontoInformado;
		}
		#endregion

		#region Variables privadas
		private long _idAuditoria;
		private long _ordinal;
		private string _idControlDeCajasFamiliasComprobanteTesoreria = string.Empty;
		private string _tDCompTesoreria = string.Empty;
		private string _idMoneda = string.Empty;
		private string _moneda = string.Empty;
		private long _cantidadInformada;
		private long _cantidadSistema;
		private decimal _montoInformado;
		private decimal _montoSistema;
		private long _diferenciaCantidad;
		private decimal _diferenciaMonto;
		private bool _codigoCalidadCantidad = false;
		private bool _codigoCalidadMonto = false;
		private ArrayList _detalle = new ArrayList();
		#endregion

		#region Propiedades

		public long IdAuditoria 
		{
			get{return _idAuditoria;}
			set{_idAuditoria = value;}
		}

		public long Ordinal 
		{
			get{return _ordinal;}
			set
			{
				_ordinal = value;
				foreach(AuditoriaControlCajasDetalleBilletes detB in Detalle)
					detB.Ordinal = value;
			}
		}

		public string IdControlDeCajasFamiliasComprobanteTesoreria
		{
			get{return _idControlDeCajasFamiliasComprobanteTesoreria;}
			set{_idControlDeCajasFamiliasComprobanteTesoreria = value;}
		}

		public string TDCompTesoreria
		{
			get{return _tDCompTesoreria;}
			set{_tDCompTesoreria = value;}
		}

		public string IdMoneda 
		{
			get{return _idMoneda;}
			set{_idMoneda = value;}
		}
		
		public string Moneda 
		{
			get{return _moneda;}
			set{_moneda = value;}
		}

		public long CantidadInformada 
		{
			get{return _cantidadInformada;}
			set{_cantidadInformada = value;}
		}
		
		public long CantidadSistema 
		{
			get{return _cantidadSistema;}
			set{_cantidadSistema = value;}
		}
		
		public decimal MontoInformado 
		{
			get{return _montoInformado;}
			set{_montoInformado = value;}
		}
		
		public decimal MontoSistema
		{
			get{return _montoSistema;}
			set{_montoSistema = value;}
		}

		public long DiferenciaCantidad 
		{
			get{return _diferenciaCantidad;}
			set{_diferenciaCantidad = value;}
		}
		
		public decimal DiferenciaMonto 
		{
			get{return _diferenciaMonto;}
			set{_diferenciaMonto = value;}
		}

		public bool CodigoCalidadCantidad 
		{
			get{return _codigoCalidadCantidad;}
			set{_codigoCalidadCantidad = value;}
		}
		
		public bool CodigoCalidadMonto 
		{
			get{return _codigoCalidadMonto;}
			set{_codigoCalidadMonto = value;}
		}
		
		public ArrayList Detalle 
		{
			get{return _detalle;}
			set{_detalle = value;}
		}
		#endregion
	
		#region Métodos Públicos
		public AuditoriaControlCajasDetalleBilletes getAuditoriaControlCajasDetalleBilletes(long IdTipoBillete)
		{
			AuditoriaControlCajasDetalleBilletes det = null;
			int i = 0;
			while(det == null && i < _detalle.Count)
			{
				AuditoriaControlCajasDetalleBilletes d = (AuditoriaControlCajasDetalleBilletes)_detalle[i];
				if(d.IdTipoBillete.Equals(IdTipoBillete))
					det = d;
				i++;
			}
			return det;
		}
		
		public void Commit(tfi_AuditoriaControlCajasExDataset Data)
		{
			tfi_AuditoriaControlCajasExDataset.tfi_AuditoriaControlCajasDetRow rowD = Data.tfi_AuditoriaControlCajasDet.Newtfi_AuditoriaControlCajasDetRow();
			rowD.IdAuditoria = this.IdAuditoria;
			rowD.Ordinal = this.Ordinal;
			rowD.IdControlDeCajasFamiliasComprobanteTesoreria = this.IdControlDeCajasFamiliasComprobanteTesoreria;
			rowD.IdMoneda = this.IdMoneda;
			rowD.CantidadInformada = this.CantidadInformada;
			rowD.CantidadSistema = this.CantidadSistema;
			rowD.MontoInformado = this.MontoInformado;
			rowD.MontoSistema = this.MontoSistema;
			rowD.DiferenciaCantidad = this.DiferenciaCantidad;
			rowD.DiferenciaMonto = this.DiferenciaMonto;
			rowD.CodigoCalidadCantidad = this.CodigoCalidadCantidad;
			rowD.CodigoCalidadMonto = this.CodigoCalidadMonto;
			rowD.FechaCreacion = DateTime.Now;
			rowD.IdConexionCreacion = Security.IdConexion;
			Data.tfi_AuditoriaControlCajasDet.Addtfi_AuditoriaControlCajasDetRow(rowD);
			foreach(AuditoriaControlCajasDetalleBilletes detB in this.Detalle)
			{
				detB.Commit(Data);
			}

		}
		#endregion

		#region Métodos Privados

		#endregion

		#region Eventos
			
		#endregion

	}

	
	public class AuditoriaControlCajasDetalleBilletes
	{
		#region Constructores
		public AuditoriaControlCajasDetalleBilletes(long Ordinal, long CantidadInformada, decimal ValorBillete, long IdTipoBillete, string TipoBillete)
		{
			_ordinal = Ordinal;
			_cantidadInformada = CantidadInformada;
			_valorBillete = ValorBillete;
			_idTipoBillete = IdTipoBillete;
			_tipoBillete = TipoBillete;
		}
		#endregion

		#region Variables privadas
		private long _idAuditoria;
		private long _ordinal;
		private long _idTipoBillete;
		private string _tipoBillete;
		private long _cantidadInformada;
		private decimal _montoInformado;
		private decimal _valorBillete;
		#endregion

		#region Propiedades

		public long IdAuditoria 
		{
			get{return _idAuditoria;}
			set{_idAuditoria = value;}
		}

		public long Ordinal 
		{
			get{return _ordinal;}
			set{_ordinal = value;}
		}

		public long IdTipoBillete 
		{
			get{return _idTipoBillete;}
			set{_idTipoBillete = value;}
		}

		public string TipoBillete 
		{
			get{return _tipoBillete;}
			set{_tipoBillete = value;}
		}

		public long CantidadInformada 
		{
			get{return _cantidadInformada;}
			set{_cantidadInformada = value;}
		}
		
		public decimal MontoInformado 
		{
			get{return _cantidadInformada * _valorBillete;}
		}
		
		public decimal ValorBillete 
		{
			get{return _valorBillete;}
			set{_valorBillete = value;}
		}
		#endregion
	
		#region Métodos Públicos
		public void Commit(tfi_AuditoriaControlCajasExDataset Data)
		{
			tfi_AuditoriaControlCajasExDataset.tfi_AuditoriaControlCajasDetalleBilletesRow rowDB = Data.tfi_AuditoriaControlCajasDetalleBilletes.Newtfi_AuditoriaControlCajasDetalleBilletesRow();
			rowDB.IdAuditoria = this.IdAuditoria;
			rowDB.Ordinal = this.Ordinal;
			rowDB.IdTipoBillete = this.IdTipoBillete;
			rowDB.CantidadInformada = this.CantidadInformada;
			rowDB.MontoInformado = this.MontoInformado;
			rowDB.FechaCreacion = DateTime.Now;
			rowDB.IdConexionCreacion = Security.IdConexion;
			Data.tfi_AuditoriaControlCajasDetalleBilletes.Addtfi_AuditoriaControlCajasDetalleBilletesRow(rowDB);

		}
		#endregion

		#region Métodos Privados

		#endregion

		#region Eventos
			
		#endregion

	}

	
	//Mezcla las clases AuditoriaControlCajasDet y AuditoriaControlCajasDetalleBilletes para mostrarlas complementadas
	public class AuditoriaControlCajasDetView
	{
		#region Constructores
		public AuditoriaControlCajasDetView(AuditoriaControlCajasDet auditoriaControlCajasDet, AuditoriaControlCajasDetalleBilletes auditoriaControlCajasDetalleBilletes)
		{
			_usaDetalleBilletes = true;
			_auditoriaControlCajasDet = auditoriaControlCajasDet;
			_auditoriaControlCajasDetalleBilletes = auditoriaControlCajasDetalleBilletes;
		}

		public AuditoriaControlCajasDetView(AuditoriaControlCajasDet auditoriaControlCajasDet)
		{
			_usaDetalleBilletes = false;
			_auditoriaControlCajasDet = auditoriaControlCajasDet;
		}

		#endregion

		#region Variables privadas
		private bool _usaDetalleBilletes = false;
		private AuditoriaControlCajasDet _auditoriaControlCajasDet;
		private AuditoriaControlCajasDetalleBilletes _auditoriaControlCajasDetalleBilletes;
		#endregion

		#region Propiedades

		public AuditoriaControlCajasDet AuditoriaControlCajasDet
		{     
			get { return _auditoriaControlCajasDet;}      
		}

		public AuditoriaControlCajasDetalleBilletes AuditoriaControlCajasDetalleBilletes
		{     
			get { return _auditoriaControlCajasDetalleBilletes;}      
		}

		public string IdControlDeCajasFamiliasComprobanteTesoreria
		{
			get{return _auditoriaControlCajasDet.IdControlDeCajasFamiliasComprobanteTesoreria;}
		}

		public string TDCompTesoreria
		{
			get{return _auditoriaControlCajasDet.TDCompTesoreria;}
		}

		public string IdMoneda 
		{
			get{return _auditoriaControlCajasDet.IdMoneda;}
		}
		
		public string Moneda 
		{
			get{return _auditoriaControlCajasDet.Moneda;}
		}

		public long CantidadInformada 
		{
			get
			{
				if(_usaDetalleBilletes)
					return _auditoriaControlCajasDetalleBilletes.CantidadInformada;
				else
                    return _auditoriaControlCajasDet.CantidadInformada;
			}
			set
			{
				if(_usaDetalleBilletes)
				{
					_auditoriaControlCajasDet.MontoInformado = (_auditoriaControlCajasDet.MontoInformado - _auditoriaControlCajasDetalleBilletes.MontoInformado);
					_auditoriaControlCajasDetalleBilletes.CantidadInformada = value;
					_auditoriaControlCajasDet.MontoInformado = _auditoriaControlCajasDet.MontoInformado + _auditoriaControlCajasDetalleBilletes.MontoInformado;
				}
				else
					_auditoriaControlCajasDet.CantidadInformada = value;
			}
		}
		
		public decimal MontoInformado 
		{
			get
			{
				if(_usaDetalleBilletes)
					return _auditoriaControlCajasDetalleBilletes.MontoInformado;
				else
					return _auditoriaControlCajasDet.MontoInformado;
			}

			set
			{
				if(!_usaDetalleBilletes)
					_auditoriaControlCajasDet.MontoInformado = value;
			}
		}
		
		public long IdTipoBillete 
		{
			get
			{
				if(_usaDetalleBilletes)
					return _auditoriaControlCajasDetalleBilletes.IdTipoBillete;
				else
					return long.MinValue;
			}
		}

		public string TipoBillete 
		{
			get
			{
				if(_usaDetalleBilletes)
					return _auditoriaControlCajasDetalleBilletes.TipoBillete;
				else
					return string.Empty;
			}
		}

		public bool UsaDetalleBilletes 
		{
			get{return _usaDetalleBilletes;}
		}

		#endregion
	
		#region Métodos Públicos
		public override System.Boolean Equals ( System.Object obj )
		{
			return this.IdControlDeCajasFamiliasComprobanteTesoreria.Equals(((AuditoriaControlCajasDetView)obj).IdControlDeCajasFamiliasComprobanteTesoreria) && this.IdMoneda.Equals(((AuditoriaControlCajasDetView)obj).IdMoneda) && this.IdTipoBillete == (((AuditoriaControlCajasDetView)obj).IdTipoBillete);
		}
		#endregion

		#region Métodos Privados

		#endregion

		#region Eventos
			
		#endregion

	}


	public class AuditoriaControlCajasDetEventArgs : EventArgs 
	{  
		private readonly AuditoriaControlCajasDet _auditoriaControlCajasDet;
		private readonly AuditoriaControlCajasDetalleBilletes _auditoriaControlCajasDetalleBilletes;

		public AuditoriaControlCajasDetEventArgs(AuditoriaControlCajasDet auditoriaControlCajasDet, AuditoriaControlCajasDetalleBilletes auditoriaControlCajasDetalleBilletes) 
		{
			this._auditoriaControlCajasDet = auditoriaControlCajasDet;
			this._auditoriaControlCajasDetalleBilletes = auditoriaControlCajasDetalleBilletes;
		}
      
		public AuditoriaControlCajasDetEventArgs(AuditoriaControlCajasDet auditoriaControlCajasDet) 
		{
			this._auditoriaControlCajasDet = auditoriaControlCajasDet;
		}

		public AuditoriaControlCajasDet AuditoriaControlCajasDet
		{     
			get { return _auditoriaControlCajasDet;}      
		}

		public AuditoriaControlCajasDetalleBilletes AuditoriaControlCajasDetalleBilletes
		{     
			get { return _auditoriaControlCajasDetalleBilletes;}      
		}
      
	}

	public class AuditoriasControlCajas
	{
		#region Constructores
		private AuditoriasControlCajas()
		{
		}
		#endregion

		#region Variables privadas
		private static AuditoriasControlCajas instance = null;
		#endregion

		#region Propiedades

		#endregion
	
		#region Métodos Públicos
		public static AuditoriasControlCajas GetInstance()
		{
			if(instance == null)
				instance = new AuditoriasControlCajas();
			return instance;
		}

		/**
		 * Devuelve un string indicando el motivo por el cual no se puede cerrar la caja o el string vacio si 
		 * se puede cerrar la misma. 
		 **/
		public string PuedeCerrarCaja(string IdInstanciaCaja)
		{
			string mje = string.Empty;
			bool ok = true;
			//Obtengo la ultima auditoria para esa caja
			tfi_AuditoriaControlCajasDataset.tfi_AuditoriaControlCajasRow rowA = tfi_AuditoriaControlCajas.GetUltimoControl(IdInstanciaCaja);
			ok = rowA != null;
			if(ok) //Si hubo un control
			{
				long IdAuditoria = rowA.IdAuditoria;
				DateTime fechaUltimoControl = rowA.Fecha;
				//Obtengo los movimientos posteriores a la fecha del ultimo control
				DataSet movPost = reportes.ReportsFactory.GetMovimientosDeCajaPosterioresA( fechaUltimoControl, IdInstanciaCaja);
				ok = movPost.Tables[0].Rows.Count == 0;				
				if(ok)//Si no existen movimientos posteriores
				{			
					tfi_AuditoriaControlCajasDetDataset.tfi_AuditoriaControlCajasDetDataTable tableDet = tfi_AuditoriaControlCajasDet.GetByIdAuditoria(IdAuditoria).tfi_AuditoriaControlCajasDet;
					//Me fijo si el ultimo control fue exitoso		
					int i = 0;
					while(ok && i < tableDet.Rows.Count)
					{
						tfi_AuditoriaControlCajasDetDataset.tfi_AuditoriaControlCajasDetRow rowD = (tfi_AuditoriaControlCajasDetDataset.tfi_AuditoriaControlCajasDetRow)tableDet.Rows[i];

						//Si son cupones y el monto total coincide se puede cerrar solo si la cantidad informada es menor o igual a la que figura en el sistema 
						if(MAPStaticInfo.PerteneceAControlDeCajasFamiliasTarjeta(rowD.IdControlDeCajasFamiliasComprobanteTesoreria))
						{
							ok = !rowD.CodigoCalidadMonto && rowD.CantidadInformada <= rowD.CantidadSistema;
						}
							//Si son cheques debe concidir tanto el monto total como la cantidad
							//Entra al caso default
							/*else if(MAPStaticInfo.PerteneceACheque(rowD.IdTDCompTesoreria))//Cheques
							{
								ok = !rowD.CodigoCalidadMonto && !rowD.CodigoCalidadCantidad;
							}*/
							//Si es efectivo debe concidir el monto sin importar la cantidad
						else if(MAPStaticInfo.PerteneceAControlDeCajasFamiliasEfectivo(rowD.IdControlDeCajasFamiliasComprobanteTesoreria))//Efectivo
						{
							ok = !rowD.CodigoCalidadMonto;
						}
						else //Por defecto debe concidir tanto el monto total como la cantidad
							ok = !rowD.CodigoCalidadMonto && !rowD.CodigoCalidadCantidad;
						i++;
					}
					if(!ok) //el ultimo control no fue exitoso
						mje = "el último control no fue exitoso";
				}
				else // existen movimientos posteriores
					mje = "se han realizado movimientos posteriores al último control";
			}
			else //No hubo ningun control
				mje = "no se realizó ningún control";
			return mje;
		}

		#endregion

		#region Métodos Privados

		#endregion

		#region Eventos

		#endregion

	}
}
