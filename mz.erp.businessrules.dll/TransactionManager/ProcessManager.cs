using System;
using System.Collections;
using System.Reflection;
//using mz.erp.businessrules;
using mz.erp.commontypes;


namespace mz.erp.businessrules.transactionmanager
{
	/// <summary>
	/// Descripción breve de ProcessManager.
	/// </summary>
	public class ProcessManager
	{
		private static System.Collections.SortedList _classtypes = new SortedList();
		private static void DeclareTypes()
		{
			_classtypes.Add( "Prevender",						  "ComprobanteDeVenta" );
			_classtypes.Add( "Vender",							  "ComprobanteDeVenta" );
			_classtypes.Add( "Presupuestar",					  "ComprobanteDeVenta" );
			_classtypes.Add( "Devolver",						  "ComprobanteDeVenta" );
			_classtypes.Add( "DevolverManual",					  "ComprobanteDeVenta" );
			_classtypes.Add( "Prestar",							  "ComprobanteDeVenta" );
			
			_classtypes.Add( "PredefinirPreparar",				  "ComprobanteDeEntrega" );
			_classtypes.Add( "Preparar",						  "ComprobanteDeEntrega" );
			_classtypes.Add( "PredefinirEntregar",				  "ComprobanteDeEntrega" );
			_classtypes.Add( "Entregar",						  "ComprobanteDeEntrega" );
			_classtypes.Add( "PredefinirNotificarDisponibilidad", "ComprobanteDeEntrega" );			
			_classtypes.Add( "NotificarDisponibilidad",			  "ComprobanteDeEntrega" );			
			_classtypes.Add( "PredefinirPrepararDiferido",		  "ComprobanteDeEntrega" );
			_classtypes.Add( "PrepararDiferido",				  "ComprobanteDeEntrega" );
			
			/*_classtypes.Add( "PredefinirPagar",					  typeof(mz.erp.businessrules.comprobantes.ComprobanteDePago) );
			_classtypes.Add( "Pagar",							  typeof(mz.erp.businessrules.comprobantes.ComprobanteDePago) );*/
		
		}

		public static void Flush(ArrayList tasksTypes)
		{
		/*	mz.erp.commontypes.SentenciasReplicacion _replication = null;
			string IdTransaction = dataaccess.PoolTransaction.BeginTransaction();
			try
			{
				ArrayList datasets = new ArrayList();
				foreach(TaskDynamicInfo taskInfo in tasksTypes)
				{
					if(taskInfo.TaskInstance is IPersistentTask)
					{
						IPersistentTask persistentTask = (IPersistentTask)taskInfo.TaskInstance;
						ArrayList arrayDataSets = persistentTask.GetData();
						foreach(System.Data.DataSet data in arrayDataSets)
						{
							//data.DataSetName = taskInfo.KeyTask;
							datasets.Add(data);
						}
						
					}
				}
				if (_classtypes.Count == 0)
				{
					DeclareTypes();
				}
				foreach(TaskDynamicInfo taskInfo in tasksTypes)
				{
					if(taskInfo.TaskInstance is IPersistentTask)
					{
						string _grupo = (string)_classtypes[ taskInfo.KeyTask ];
						switch (_grupo )
						{
							case "ComprobanteDeEntrega": 
							{
								mz.erp.businessrules.comprobantes.ComprobanteDeEntrega comprobanteDeEntrega = (mz.erp.businessrules.comprobantes.ComprobanteDeEntrega)taskInfo.TaskInstance;
								mz.erp.businessrules.transactionmanager.ComprobanteDeEntrega.BRComprobanteDeEntrega = comprobanteDeEntrega;
								datasets = mz.erp.businessrules.transactionmanager.ComprobanteDeEntrega.PutExtraData(datasets,comprobanteDeEntrega.GetData());
								mz.erp.businessrules.transactionmanager.ComprobanteDeEntrega.Flush(comprobanteDeEntrega.GetData(), IdTransaction);
								if(_replication == null)
									_replication = ComprobanteDeEntrega.Replication;
								else
									_replication.Sentence.Append(ComprobanteDeEntrega.Replication.Sentence.ToString());
							}
							break;
							case "ComprobanteDeVenta":
							{
								mz.erp.businessrules.comprobantes.ComprobanteDeVenta comprobanteDeVenta = (mz.erp.businessrules.comprobantes.ComprobanteDeVenta)taskInfo.TaskInstance;
								mz.erp.businessrules.transactionmanager.ComprobanteDeVenta.BRComprobanteDeVenta = comprobanteDeVenta;
								datasets = mz.erp.businessrules.transactionmanager.ComprobanteDeVenta.PutExtraData(datasets, comprobanteDeVenta.GetData());
								mz.erp.businessrules.transactionmanager.ComprobanteDeVenta.Flush(comprobanteDeVenta.GetData(), IdTransaction);
								if(_replication == null)
									_replication = ComprobanteDeVenta.Replication;
								else
									_replication.Sentence.Append(ComprobanteDeVenta.Replication.Sentence.ToString());

							}
							break;
							case "ComprobanteDePago":
							{

								mz.erp.businessrules.comprobantes.ComprobanteDePago comprobanteDePago = (mz.erp.businessrules.comprobantes.ComprobanteDePago)taskInfo.TaskInstance;
								mz.erp.businessrules.transactionmanager.ComprobanteDePago.BRComprobanteDePago = comprobanteDePago;
								datasets = mz.erp.businessrules.transactionmanager.ComprobanteDePago.PutExtraData(datasets,comprobanteDePago.GetData());
								mz.erp.businessrules.transactionmanager.ComprobanteDePago.Flush(comprobanteDePago.GetData(), IdTransaction);
								if(_replication == null)
									_replication = ComprobanteDePago.Replication;
								else
									_replication.Sentence.Append(ComprobanteDePago.Replication.Sentence.ToString());
							}
							break;

						}

					}
					
				}
				mz.erp.businessrules.transactionmanager.SentenciasReplicacion.Flush(IdTransaction, _replication);
				dataaccess.PoolTransaction.Commit(IdTransaction);
			}
			catch(Exception e)
			{
				dataaccess.PoolTransaction.RollBack(IdTransaction);
			}

*/

		}

		



	}
}
