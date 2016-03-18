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
	/// Descripción breve de ComprobanteDeVenta.
	/// </summary>
	public class ComprobanteDeVenta
	{
		
		private static mz.erp.commontypes.SentenciasReplicacion _replication;
		public static mz.erp.commontypes.SentenciasReplicacion Replication
		{
			get
			{
				return _replication;
			}
		}
		private static mz.erp.businessrules.comprobantes.ComprobanteDeVenta _brComprobanteDeVenta;
		public static mz.erp.businessrules.comprobantes.ComprobanteDeVenta BRComprobanteDeVenta
		{
			get
			{
				return _brComprobanteDeVenta;
			}
			set
			{
				_brComprobanteDeVenta = value;
			}
		}
		public ComprobanteDeVenta()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
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
			if (BRComprobanteDeVenta.ActualizaNumeracion) 
			{
				IdVariable = UpdateNumero(dataEx);
			}
			else 
			{
				IdVariable = dataEx.tsa_Comprobantes.Rows[0]["Numero"].ToString();
			}
			_replication = GenerateReplicaction();
			mz.erp.dataaccess.tsa_ComprobantesEx.Update(dataEx, IdVariable, _replication, IdTransaction);
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
	
		private static mz.erp.commontypes.SentenciasReplicacion  GenerateReplicaction()
		{
			mz.erp.commontypes.SentenciasReplicacion replication = new mz.erp.commontypes.SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tsa_Comprobantes";
			return replication;
			
		}
	}
}
