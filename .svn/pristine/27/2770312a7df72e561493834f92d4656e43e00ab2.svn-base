using System;
using System.Collections;
using System.Data;
using mz.erp.dataaccess;
using mz.erp.commontypes.data;


namespace mz.erp.transactionManager
{
	/// <summary>
	/// Descripción breve de ComprobanteDeEntrega.
	/// </summary>
	public class ComprobanteDeEntrega
	{
		public ComprobanteDeEntrega()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public static void Flush(ArrayList arrData, string IdTransaction) 
		{
			foreach(DataSet data in arrData) 
			{
				if (data.DataSetName == "tsa_ComprobantesExDataset") 
				{					
					transactionManager.ComprobanteDeVenta.Flush((tsa_ComprobantesExDataset) data, IdTransaction);
					UsarDatosDeComprobantes(data, ref arrData);
				}
				if (data.DataSetName == "tlg_ComprobantesDataset") 
				{
					MyFlush((tlg_ComprobantesDataset) data, IdTransaction);
				}
			}
		}
		private static void MyFlush(tlg_ComprobantesDataset data, string IdTransaction)
		{						
			//Ver como se hace aca?????????????????????????????????????
			//Aca se recupera la transaccion y se la pasa al update????????????? o se hace en dataaccess????????
			//dataaccess.PoolTransaction.GetTransactionById(IdTransaction);
			
			dataaccess.tlg_Comprobantes.Update(data);
		}
		private static void UsarDatosDeComprobantes(DataSet comprobanteDeVenta, ref ArrayList arrData) 
		{			
			foreach(DataSet data in arrData) 
			{
				if (data.DataSetName == "tlg_ComprobantesDataset") 
				{
					((tlg_ComprobantesDataset) data).tlg_Comprobantes.Rows[0]["IdComprobante"] = comprobanteDeVenta.Tables["tsa_Comprobantes"].Rows[0]["IdComprobante"];					
				}
			}
		}
		

		public static ArrayList PutExtraData(ArrayList _arrayDataSet, ArrayList data)
		{
			return new ArrayList();
		}

		
	}
}
