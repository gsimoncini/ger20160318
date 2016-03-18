using System;

namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Descripción breve de ItemRetencion.
	/// </summary>
	public class ItemRetencion
	{
		#region Constructores 
		public ItemRetencion(long IdRetencion, string IdComprobante, string IdConcepto, decimal MontoNeto, decimal AlicuotaAplicada, decimal MontoRetencion)
		{
			_idRetencion = IdRetencion;
			_idComprobante = IdComprobante;
			_idConcepto = IdConcepto;
			_montoNeto = MontoNeto;
			_alicuotaAplicada = AlicuotaAplicada;
			_montoRetencion = MontoRetencion;
		}
		#endregion 

		#region Variables Privadas 
		private long _idRetencion;
		private string _idComprobante;
		private string _idConcepto;
		private decimal _montoNeto;
		private decimal _alicuotaAplicada;
		private decimal _montoRetencion;
		#endregion 

		#region  Acceso a Variables Privadas
		public long IdRetencion
		{
			get{return _idRetencion;}
			set{_idRetencion = value;}
		}
		public string IdComprobante
		{
			get{return _idComprobante;}
			set{_idComprobante = value;}
		}
		public string IdConcepto
		{
			get{return _idConcepto;}
			set{_idConcepto = value;}
		}
		public decimal MontoNeto
		{
			get{return _montoNeto;}
			set{_montoNeto = value;}
		}
		public decimal AlicuotaAplicada
		{
			get{return _alicuotaAplicada;}
			set{_alicuotaAplicada = value;}
		}
		public decimal MontoRetencion
		{
			get{return _montoRetencion;}
			set{_montoRetencion = value;}
		}
		#endregion 
	}
}
