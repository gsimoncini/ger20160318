using System;
using mz.erp.commontypes.data;
using mz.erp.commontypes;
using System.Collections;

namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Descripción breve de GuardarSaldoCuentaCorriente.
	/// </summary>
	public class GuardarSaldoCuentaCorriente
	{
		#region Variables Privadas
		private static GuardarSaldoCuentaCorriente instance = null;
		private Hashtable datasetsPorProceso = new Hashtable();
		#endregion

		#region Constructores y Destructores
		public GuardarSaldoCuentaCorriente()
		{
		}
		#endregion

		#region Métodos Publicos

		public static GuardarSaldoCuentaCorriente GetInstance()
		{
			if(instance == null)
				instance = new GuardarSaldoCuentaCorriente();
			return instance;
		}

		public void CommitSaldoCuentaCorriente(Process process, string IdCuenta, decimal Importe, string IdTipoDeComprobante)
		{
			if(process != null)
			{
				tsy_TiposDeComprobantesDataset.tsy_TiposDeComprobantesRow rowTC = tsy_TiposDeComprobantes.GetByPk(IdTipoDeComprobante);
				if(this.TipoDeComprobanteAfectaCtaCte(rowTC.TipoCtaCte))
				{
					if(!datasetsPorProceso.ContainsKey(process))
						datasetsPorProceso.Add(process, new tsa_CuentasDataset());
					tsa_CuentasDataset dataCuentas = (tsa_CuentasDataset)datasetsPorProceso[process];
					tsa_CuentasDataset.tsa_CuentasRow rowCuenta = dataCuentas.tsa_Cuentas.FindByIdCuenta(IdCuenta);
					switch(rowTC.TipoCtaCte)
					{
						case 1:
						{
							if(rowCuenta == null)
							{
								rowCuenta = tsa_Cuentas.GetByPk(IdCuenta);
								rowCuenta.SaldoCtaCte = rowCuenta.SaldoCtaCte + Importe * -1;
								dataCuentas.tsa_Cuentas.ImportRow(rowCuenta);
							}
							else
								rowCuenta.SaldoCtaCte = rowCuenta.SaldoCtaCte + Importe * -1;
							break;
						}
						case 2:
						{
							if(rowCuenta == null)
							{
								rowCuenta = tsa_Cuentas.GetByPk(IdCuenta);
								rowCuenta.SaldoCtaCteDV = rowCuenta.SaldoCtaCteDV + Importe * -1;
								dataCuentas.tsa_Cuentas.ImportRow(rowCuenta);
							}
							else
								rowCuenta.SaldoCtaCteDV = rowCuenta.SaldoCtaCteDV + Importe * -1;
							break;
						}
					}
					
				}
			}
		}

		public void FlushSaldoCuentaCorriente(Process process, string IdTransaction, SentenciasReplicacion Replication)
		{
			if(datasetsPorProceso.ContainsKey(process))
			{
				tsa_CuentasDataset dataCuentas = (tsa_CuentasDataset)datasetsPorProceso[process];
				mz.erp.dataaccess.tsa_Cuentas.Update(dataCuentas.tsa_Cuentas, IdTransaction, Replication);
			}
		}	

		public void ClearDataSet(Process process)
		{
			if(datasetsPorProceso.ContainsKey(process))
			{
				datasetsPorProceso.Remove(process);
			}
		}	
		
		#endregion

		#region Métodos Privados
		public bool TipoDeComprobanteAfectaCtaCte(long TipoCtaCte)
		{
			return TipoCtaCte == 1 || TipoCtaCte == 2;
		}
		#endregion
	}
}
