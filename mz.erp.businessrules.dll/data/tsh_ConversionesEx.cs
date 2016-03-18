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
	/// Descripción breve de tsh_ConversionesEx.
	/// </summary>
	public class tsh_ConversionesEx
	{
		public tsh_ConversionesEx()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		

		[ atMethodNewRow ]
		public static tsh_ConversionesExDataset NewRow()
		{
			tsh_ConversionesExDataset dataEx= new tsh_ConversionesExDataset();
			tsh_ConversionesDataset data = new tsh_ConversionesDataset();
			System.Data.DataRow row = mz.erp.businessrules.tsh_Conversiones.NewRow();
		//	System.Data.DataRow rowDetalle = mz.erp.businessrules.tsh_DetalleConversiones.NewRow();
		//	rowDetalle["IdConversion"] = row["IdConversion"];
			dataEx.tsh_Conversiones.LoadDataRow(row.ItemArray,false);
		//	dataEx.tsh_DetalleConversiones.LoadDataRow(rowDetalle.ItemArray, false);

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
			replication.NombreTabla = "dataaccess.tsh_Conversiones";
			return replication;
		}


		[atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsh_ConversionesExDataset data )
		{
			ApplicationAssert.Check( data != null, "El argumento data no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( DatasetIsValid( data ) )
			{
				Update( data );
			}
			
		}


		public static bool DatasetIsValid(tsh_ConversionesExDataset data)
		{	
			return true;
		}

		public static void Update( tsh_ConversionesExDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_Conversiones.Rows.Count > 0, "La tabla tsh_Conversiones debe poseer alguna fila.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_DetalleConversiones.Rows.Count > 0, "La tabla tsh_DetalleConversiones debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			SentenciasReplicacion replicacion = GenerateReplication();
			mz.erp.dataaccess.tsh_ConversionesEx.Update(dataSet, replicacion);
		}




		[ atMethodGetByPkRow ]
		public static tsh_ConversionesExDataset GetByPk( object IdConversion )
		{
			return GetByPk( ( string )IdConversion );
		}
		
		public static tsh_ConversionesExDataset GetByPk( string IdConversion )
		{
		
			tsh_ConversionesExDataset data= new tsh_ConversionesExDataset();
			data.tsh_Conversiones.ImportRow(mz.erp.businessrules.tsh_Conversiones.GetByPk(IdConversion));
			data.Merge(mz.erp.businessrules.tsh_DetalleConversiones.GetList(IdConversion, null, null).tsh_DetalleConversiones);
			
			
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
