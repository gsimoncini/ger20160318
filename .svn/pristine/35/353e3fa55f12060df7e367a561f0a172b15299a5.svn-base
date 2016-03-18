using System;
using System.Collections;
using System.Reflection;


namespace mz.erp.transactionManager
{
	/// <summary>
	/// Descripción breve de ProcessManager.
	/// </summary>
	public class ProcessManager
	{
	
		public static void Flush(ArrayList tasksTypes)
		{
			
			string IdTransaction = dataaccess.PoolTransaction.BeginTransaction();
			try
			{
				ArrayList datasets = new ArrayList();
				foreach(TaskDynamicInfo taskInfo in tasksTypes)
				{
					datasets.AddRange(taskInfo.Data);
				}
				
				foreach(TaskDynamicInfo taskInfo in tasksTypes)
				{
					string keyTask = taskInfo.KeyTask;
					if(keyTask.ToUpper().Equals("Entregar"))
					{	
						datasets = mz.erp.transactionManager.ComprobanteDeEntrega.PutExtraData(datasets, taskInfo.Data);
						mz.erp.transactionManager.ComprobanteDeEntrega.Flush(taskInfo.Data, IdTransaction);
					}
					if(keyTask.ToUpper().Equals("Vender") || keyTask.ToUpper().Equals("Prevender"))
					{
						datasets = mz.erp.transactionManager.ComprobanteDeVenta.PutExtraData(datasets, taskInfo.Data);
						mz.erp.transactionManager.ComprobanteDeVenta.Flush(taskInfo.Data, IdTransaction);


					}
					
				}
				dataaccess.PoolTransaction.Commit(IdTransaction);
			}
			catch(Exception e)
			{
				dataaccess.PoolTransaction.RollBack(IdTransaction);
			}


		}

		



	}
}
