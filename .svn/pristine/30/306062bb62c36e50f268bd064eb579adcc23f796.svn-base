using System;
using System.Collections;
using System.Data;
using mz.erp.dataaccess;
using mz.erp.commontypes.data;
using mz.erp.commontypes;
using mz.erp.systemframework;

namespace mz.erp.businessrules.transactionmanager
{
	/// <summary>
	/// Descripción breve de ComprobanteDePago.
	/// </summary>
	public class ComprobanteDePago
	{
		public ComprobanteDePago()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		/*
		private static mz.erp.businessrules.comprobantes.ComprobanteDePago _brComprobanteDePago;
		public static mz.erp.businessrules.comprobantes.ComprobanteDePago BRComprobanteDePago
		{
			get
			{
				return _brComprobanteDePago;
			}
			set
			{
				_brComprobanteDePago = value;
			}
		}

		public static void Flush(ArrayList Datasets, string IdTransaction)
		{						
			if (Datasets.Count == 1)
			{
				Flush( (DataSet)Datasets[0], IdTransaction );
			}
		}

		public static ArrayList PutExtraData(ArrayList _arrayDataSet, ArrayList data)
		{
			return new ArrayList();
		}
		public static void Flush(DataSet data , string IdTransaction)
		{						
			string IdVariable;
			tsa_ComprobantesExDataset dataEx = (tsa_ComprobantesExDataset) data;
			if (BRComprobanteDePago.ActualizaNumeracion) 
			{
				IdVariable = UpdateNumero(dataEx);
			}
			else 
			{
				IdVariable = dataEx.tsa_Comprobantes.Rows[0]["Numero"].ToString();
			}
			//_replication = GenerateReplicaction();
			//mz.erp.dataaccess.tsa_ComprobantesEx.UpdateComprobanteDePago(dataEx, IdVariable, _replication, IdTransaction);
		}

		private static string  UpdateNumero(tsa_ComprobantesExDataset data)
		{
			foreach(System.Data.DataRow row1 in data.tsa_Comprobantes.Rows)
			{
				if (true) 
				{
					string numeracion = Variables.GetValueStringWithoutCache("Comprobantes.Numeracion." + (string)row1["IdTipoDeComprobante"]);
					string Numero = Util.StcZero(numeracion,8);
					row1["Numero"]= Numero;
					sy_VariablesDataset.sy_VariablesRow row = mz.erp.businessrules.sy_Variables.GetByPk("Comprobantes.Numeracion." + row1["IdTipoDeComprobante"]);

					return row.IdVariable;
				}
				
			}

			return null;
		}
		*/
	
	}
}

