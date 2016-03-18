using System;
using System.Data;
using System.Text.RegularExpressions;

using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.dataaccess;
using mz.erp.systemframework;



namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de tsa_CondicionesDeVentasEx.
	/// </summary>
	public class tsa_CondicionesDeVentasEx
	{
		public tsa_CondicionesDeVentasEx()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		


		[ atMethodNewRow ]
		public static tsa_CondicionesDeVentasExDataset NewRow()
		{
			tsa_CondicionesDeVentasExDataset dataEx= new tsa_CondicionesDeVentasExDataset();
			
			tsa_CondicionesDeVentasDataset data = new tsa_CondicionesDeVentasDataset();
			System.Data.DataRow row = mz.erp.businessrules.tsa_CondicionesDeVentas.NewRow();
			try
			{
				dataEx.tsa_CondicionesDeVentas.LoadDataRow(row.ItemArray,false);
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
				
			return dataEx;
		}
		private static SentenciasReplicacion GenerateReplication()
		{
			//Nuevo
			SentenciasReplicacion replication = new SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tsa_CondicionesDeVentas";
			return replication;
		}


		[atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsa_CondicionesDeVentasExDataset data )
		{
			ApplicationAssert.Check( data != null, "El argumento data no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( DatasetIsValid( data ) )
			{
				Update( data );
			}
			
		}


		public static bool DatasetIsValid(tsa_CondicionesDeVentasExDataset data)
		{	
			return true;
		}

		public static void Update( tsa_CondicionesDeVentasExDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_CondicionesDeVentas.Rows.Count > 0, "La tabla tsa_CondicionesDeVenta debe poseer alguna fila.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_CondicionesDeVentaDet.Rows.Count > 0, "La tabla tsa_CondicionesDeVentaDet debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			SentenciasReplicacion replicacion = GenerateReplication();
			mz.erp.dataaccess.tsa_CondicionesDeVentasEx.Update(dataSet, replicacion);
		}




		[ atMethodGetByPkRow ]
		public static tsa_CondicionesDeVentasExDataset GetByPk( object idCondicionDeVenta  )
		{
			return GetByPk( ( string )idCondicionDeVenta  );
		}
		
		public static tsa_CondicionesDeVentasExDataset GetByPk( string idCondicionDeVenta )
		{
		
			tsa_CondicionesDeVentasExDataset data= new tsa_CondicionesDeVentasExDataset();
			data.tsa_CondicionesDeVentas.ImportRow(mz.erp.businessrules.tsa_CondicionesDeVentas.GetByPk(idCondicionDeVenta));
			data.Merge(mz.erp.businessrules.tsa_CondicionesDeVentaDet.GetList(idCondicionDeVenta).tsa_CondicionesDeVentaDet);
			
			
			foreach ( DataTable table in data.Tables) 
			{
				foreach ( DataRow row1 in table.Rows )
				{
					foreach ( DataColumn dc in row1.Table.Columns )
					{
						if (row1[dc] == System.DBNull.Value)
						{
							row1[dc] = Util.DefaultValue( dc.DataType );
						}
					}
				}
				
			}
			return data;
		
		
		}






	}
}
