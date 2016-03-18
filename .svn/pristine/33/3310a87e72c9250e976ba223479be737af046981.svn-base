using System;
using System.Collections;
using System.Data;
using mz.erp.dataaccess;
using mz.erp.commontypes.data;
using mz.erp.commontypes;


namespace mz.erp.businessrules.transactionmanager
{
	/// <summary>
	/// Descripción breve de ComprobanteDeEntrega.
	/// </summary>
	public class ComprobanteDeEntrega
	{
		
		private static mz.erp.businessrules.comprobantes.ComprobanteDeEntrega _brComprobanteDeEntrega;
		public static mz.erp.businessrules.comprobantes.ComprobanteDeEntrega BRComprobanteDeEntrega
		{
			get
			{
				return _brComprobanteDeEntrega;
			}
			set
			{
				_brComprobanteDeEntrega = value;
			}
		}
		public ComprobanteDeEntrega()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public static void Flush(ArrayList arrData, string IdTransaction) 
		{
			
			/*_replication = GenerateReplicaction();
			foreach(DataSet data in arrData) 
			{

				if (data.DataSetName == "tsa_ComprobantesExDataset") 
				{					
					_brComprobanteDeEntrega.SetComprobanteDeVenta();
					ComprobanteDeVenta.Flush((tsa_ComprobantesExDataset) data, IdTransaction);
					_replication.Sentence  = ComprobanteDeVenta.Replication.Sentence;
					UsarDatosDeComprobantes(data, ref arrData);
				}
				if (data.DataSetName == "tlg_ComprobantesDataset") 
				{
					MyFlush((tlg_ComprobantesDataset) data, IdTransaction);
				}
			}*/
		}
	/*	private static void MyFlush(tlg_ComprobantesDataset data, string IdTransaction)
		{						
			dataaccess.tlg_Comprobantes.Update(data.Tables[0],_replication, IdTransaction);
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
			return _arrayDataSet;
		}*/
		
		
	}
}
