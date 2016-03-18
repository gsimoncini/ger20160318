using System;
using System.Collections;
namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Descripción breve de Retencion.
	/// </summary>
	public class Retencion
	{
		#region Constructores 
		public Retencion(long IdRetencion, string IdTipoDeRetencion, decimal MontoNeto, decimal MontoRetencion, string NumeroRetencion, DateTime FechaRetencion, string NumeroRecibo, string IdComprobante, string IdProveedor, ArrayList Detalle)
		{
			_idRetencion = IdRetencion;
			_idTipoDeRetencion = IdTipoDeRetencion;
			_montoNeto = MontoNeto;
			_montoRetencion = MontoRetencion;
			_numeroRetencion = NumeroRetencion;
			_fechaRetencion = FechaRetencion;
			_numeroRecibo = NumeroRecibo;
			_idComprobante = IdComprobante;
			_idProveedor = IdProveedor;
			_detalle = Detalle;

		}
		#endregion 

    	#region Variables Privadas 
		private long _idRetencion;
		private string _idTipoDeRetencion;
		private decimal _montoNeto;
		private decimal _montoRetencion;
		private string _numeroRetencion;
		private DateTime _fechaRetencion;
		private string _numeroRecibo;
		private string _idComprobante;
		private string _idProveedor;
		private ArrayList _detalle = new ArrayList();
		#endregion 

		#region  Acceso a Variables Privadas
		public long IdRetencion
		{
			get{return _idRetencion;}
			set{_idRetencion = value;}
		}
		public string IdTipoDeRetencion
		{
			get{return _idTipoDeRetencion;}
			set{_idTipoDeRetencion = value;}
		}
		public decimal MontoNeto
		{
			get{return _montoNeto;}
			set{_montoNeto = value;}
		}
		public decimal MontoRetencion
		{
			get{return _montoRetencion;}
			set{_montoRetencion = value;}
		}
		public string NumeroRetencion
		{
			get{return _numeroRetencion;}
			set{_numeroRetencion = value;}
		}
		public DateTime FechaRetencion
		{
			get{return _fechaRetencion;}
			set{_fechaRetencion = value;}
		}
		public string NumeroRecibo
		{
			get{return _numeroRecibo;}
			set{_numeroRecibo = value;}
		}
		public string IdComprobante
		{
			get{return _idComprobante;}
			set{_idComprobante = value;}
		}
		public string IdProveedor
		{
			get{return _idProveedor;}
			set{_idProveedor = value;}
		}
		public ArrayList Detalle
		{
			get{return _detalle;}
			set{_detalle = value;}
		}

		#endregion 
	}
}
