using System;
using System.Collections;
using mz.erp.businessrules;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Descripción breve de Valores.
	/// </summary>
	public class Valores
	{
		public Valores()
		{
			
		}

		private ArrayList _valores = new ArrayList();
		private System.Data.DataSet _dataValoresEx = new tfi_ValoresExDataset();
		private tpu_ComprobanteDetalleDePagosDataset _dataDetallePagosCompras = new tpu_ComprobanteDetalleDePagosDataset();
		private System.Data.DataSet _parentDataSet = new System.Data.DataSet();
		private bool _creaIdValoresNuevos = true;
		private string _idInstanciaCaja = string.Empty;

		public tpu_ComprobanteDetalleDePagosDataset DataDetallePagosCompras
		{
			get{return _dataDetallePagosCompras;}
		}
		
		public tfi_ValoresExDataset DataValores
		{
			get{return (tfi_ValoresExDataset)_dataValoresEx;}
		}

		private string IdInstanciaCaja
		{
			get{return _idInstanciaCaja;}
			set
			{
				_idInstanciaCaja = value;
				foreach(Valor valor in this._valores)
				{
					valor.IdInstanciaCaja = _idInstanciaCaja;
				}
			}
		}

		
		public bool CreaIdValoresNuevos
		{
			get{return _creaIdValoresNuevos;}
			set{_creaIdValoresNuevos = value;}
		}

		public ArrayList MisValores
		{
			get {return _valores;}
			set {_valores = value;}
		}

		public void Add(Valor valor)
		{
			this.MisValores.Add(valor);			
		}

		public System.Data.DataSet ParentDataSet
		{
			get{return _parentDataSet;}
			set{_parentDataSet = value;}
		}

		public bool Contains(Valor valor)
		{
			foreach(Valor v in this.MisValores)
			{
				if(v.State.ToUpper().Equals("EDIT") && v.IdValor.Equals(valor.IdValor))
					return true;
			}
			return false;
		}

		public void CommitPagosServiciosGastos(string IdInsCaja, int SignoParent)
		{
			_dataValoresEx.Clear();
			for (int i = 1; i <= MisValores.Count; i++)  
			{				
				if(MisValores[i-1] != null)
				{
					Valor valor = (Valor) MisValores[i-1];
					valor.IdInstanciaCaja = IdInsCaja;
					valor.Signo = SignoParent;
					if(valor.State.ToUpper().Equals("NEW") || valor.Agrupado)
					{
						valor.Commit((tfi_ValoresExDataset)_dataValoresEx);
					}
					else
					{
						if(valor.State.ToUpper().Equals("EDIT"))
						{
							if((valor.SignoDB + SignoParent) == 0)
							{
								valor.Signo = 0;
								valor.IdInstanciaCaja = string.Empty;
								/*Ver el estado en el q deberia quedar el cheque*/
								/*Por ahora NO INDICA, ver si depende del tipo de Cheque*/
								/*Ver documentacion de Vivi*/
								valor.IdEstado = "4";
							}
							valor.Update((tfi_ValoresExDataset)_dataValoresEx);
						}
					}
				}
			}
		}

		public void CommitCompras(string IdInsCaja, int SignoParent)
		{
			_dataValoresEx.Clear();
			_dataDetallePagosCompras.Clear();
			for (int i = 1; i <= MisValores.Count; i++)  
			{				
				if(MisValores[i-1] != null)
				{
					Valor valor = (Valor) MisValores[i-1];
					valor.IdInstanciaCaja = IdInsCaja;
					valor.Signo = SignoParent;
					if(valor.State.ToUpper().Equals("NEW") || valor.Agrupado)
					{
						valor.Commit((tfi_ValoresExDataset)_dataValoresEx);
					}
					else
					{
						if(valor.State.ToUpper().Equals("EDIT"))
						{
							if((valor.SignoDB + SignoParent) == 0)
							{
								valor.Signo = 0;
								valor.IdInstanciaCaja = string.Empty;
								/*Ver el estado en el q deberia quedar el cheque*/
								/*Por ahora NO INDICA, ver si depende del tipo de Cheque*/
								/*Ver documentacion de Vivi*/
								valor.IdEstado = "4";
							}
							valor.Update((tfi_ValoresExDataset)_dataValoresEx);
						}
					}
					tpu_ComprobanteDetalleDePagosDataset.tpu_ComprobanteDetalleDePagosRow rowDP = _dataDetallePagosCompras.tpu_ComprobanteDetalleDePagos.Newtpu_ComprobanteDetalleDePagosRow();
					valor.CommitDetalleDePagos(rowDP);
					_dataDetallePagosCompras.tpu_ComprobanteDetalleDePagos.Addtpu_ComprobanteDetalleDePagosRow(rowDP);


				}
			}
		}


		public void Commit(string IdInsCaja, int SignoParent)
		{
			for (int i = 1; i <= MisValores.Count; i++)  
			{				
				if(MisValores[i-1] != null)
				{
					Valor valor = (Valor) MisValores[i-1];
					valor.IdInstanciaCaja = IdInsCaja;
					valor.Signo = SignoParent;
					if(valor.State.ToUpper().Equals("NEW") || valor.Agrupado)
					{
						valor.Commit((tfi_ValoresExDataset)_dataValoresEx);
					}
					else
					{
						if(valor.State.ToUpper().Equals("EDIT"))
						{
							if((valor.SignoDB + SignoParent) == 0)
							{
								valor.Signo = 0;
								valor.IdInstanciaCaja = string.Empty;
							}
							valor.Update((tfi_ValoresExDataset)_dataValoresEx);
						}
					}
				}
			}	
			tfi_ValoresExDataset dataValores = (tfi_ValoresExDataset) this._dataValoresEx;
			foreach(System.Data.DataRow row in dataValores.Tables["tfi_Valores"].Rows)
			{
				if(this.ParentDataSet.Tables["tfi_valores"].Rows.Find(row["IdValor"]) == null)
					this.ParentDataSet.Tables["tfi_valores"].ImportRow(row);		
			}
			foreach(System.Data.DataRow row in dataValores.Tables["tfi_ValoresDatosAuxiliares"].Rows)
			{
				this.ParentDataSet.Tables["tfi_ValoresDatosAuxiliares"].ImportRow(row);
			}
		}



		public void Reset()
		{
			this.MisValores.Clear();
			_dataValoresEx = new tfi_ValoresExDataset();
		}



	}
}
