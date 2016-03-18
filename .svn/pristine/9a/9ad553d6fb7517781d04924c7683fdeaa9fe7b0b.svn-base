namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsh_Localidades : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsh_Localidades()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_Localidades
		/// </summary>
		public static tsh_LocalidadesDataset GetList()
		{
			return mz.erp.dataaccess.tsh_Localidades.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsh_Localidades filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsh_LocalidadesDataset GetList( string IdLocalidad, string CodigoPostal, string Descripcion )
		{
			return mz.erp.dataaccess.tsh_Localidades.GetList( IdLocalidad, CodigoPostal , Descripcion);
		}

		/// <summary>
		/// Crea un tsh_LocalidadesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsh_LocalidadesDataset.tsh_LocalidadesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsh_Localidades.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_Localidades que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_LocalidadesDataset.tsh_LocalidadesRow GetByPk( string IdLocalidad )
		{
			tsh_LocalidadesDataset.tsh_LocalidadesRow row = mz.erp.dataaccess.tsh_Localidades.GetByPk( IdLocalidad  );
			if(row != null)
			{
				foreach ( DataColumn dc in row.Table.Columns ) 
				{
					if (row[dc] == System.DBNull.Value)
					{
						row[dc] = Util.DefaultValue( dc.DataType );
					}
				}
			}
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_Localidades que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsh_LocalidadesDataset.tsh_LocalidadesRow GetByPk( object IdLocalidad )
		{
			return GetByPk( ( string )IdLocalidad );
		}

		/// <summary>
		/// Establece los valores por defecto de tsh_LocalidadesRow.
		/// </summary>
		public static tsh_LocalidadesDataset.tsh_LocalidadesRow SetRowDefaultValues( tsh_LocalidadesDataset.tsh_LocalidadesRow row )
		{
			row.IdLocalidad = Util.NewStringId(); 
			row.Descripcion = string.Empty;
			row.CodigoPostal = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
		//	row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
		//	row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsh_LocalidadesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsh_LocalidadesDataset.tsh_LocalidadesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsh_LocalidadesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsh_LocalidadesDataset.tsh_LocalidadesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_LocalidadesRow a la base de datos.
		/// </summary>
		public static void Update( tsh_LocalidadesDataset.tsh_LocalidadesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			//Nuevo
			SentenciasReplicacion replication = new SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tsh_Localidades";
			mz.erp.dataaccess.tsh_Localidades.Replicacion = replication;	
			
			mz.erp.dataaccess.tsh_Localidades.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsh_LocalidadesDataset a la base de datos.
		/// </summary>
		public static void Update( tsh_LocalidadesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_Localidades.Rows.Count > 0, "La tabla dataSet.tsh_LocalidadesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_Localidades.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_LocalidadesDataset.tsh_LocalidadesDataTable a la base de datos.
		/// </summary>
		public static void Update( tsh_LocalidadesDataset.tsh_LocalidadesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			SentenciasReplicacion replicacion = GenerateReplication();
			mz.erp.dataaccess.tsh_Localidades.Update( dataTable, replicacion );
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
			replication.NombreTabla = "dataaccess.tsa_Cuentas";
			return replication;
		}
		/// <summary>
		/// Valida un tsh_LocalidadesRow.
		/// </summary>
		public static bool RowIsValid( tsh_LocalidadesDataset.tsh_LocalidadesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdLocalidadIsValid( row.IdLocalidad, out mensaje) )
			{ 
				row.SetColumnError( "IdLocalidad" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
				isValid=false;
			
			}
						
			if ( !CodigoPostalIsValid( row.CodigoPostal, out mensaje) )
			{ 
				row.SetColumnError( "CodigoPostal" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaCreacionIsValid( row.FechaCreacion, out mensaje) )
			{ 
				row.SetColumnError( "FechaCreacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdConexionCreacionIsValid( row.IdConexionCreacion, out mensaje) )
			{ 
				row.SetColumnError( "IdConexionCreacion" , mensaje);
				isValid=false;
			
			}
						
			/*if ( !UltimaModificacionIsValid( row.UltimaModificacion, out mensaje) )
			{ 
				row.SetColumnError( "UltimaModificacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdConexionUltimaModificacionIsValid( row.IdConexionUltimaModificacion, out mensaje) )
			{ 
				row.SetColumnError( "IdConexionUltimaModificacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdReservadoIsValid( row.IdReservado, out mensaje) )
			{ 
				row.SetColumnError( "IdReservado" , mensaje);
				isValid=false;
			
			}
						
			if ( !RowIdIsValid( row.RowId, out mensaje) )
			{ 
				row.SetColumnError( "RowId" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdEmpresaIsValid( row.IdEmpresa, out mensaje) )
			{ 
				row.SetColumnError( "IdEmpresa" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdSucursalIsValid( row.IdSucursal, out mensaje) )
			{ 
				row.SetColumnError( "IdSucursal" , mensaje);
				isValid=false;
			
			}*/
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdLocalidad.
		/// </summary>
		public static bool IdLocalidadIsValid( string IdLocalidad , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdLocalidad. Metodo Sobrecargado
		/// </summary>
		public static bool IdLocalidadIsValid( string IdLocalidad)
		{
			string mensaje;
			return IdLocalidadIsValid( IdLocalidad, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Descripcion.
		/// </summary>
		public static bool DescripcionIsValid( string Descripcion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Descripcion. Metodo Sobrecargado
		/// </summary>
		public static bool DescripcionIsValid( string Descripcion)
		{
			string mensaje;
			return DescripcionIsValid( Descripcion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CodigoPostal.
		/// </summary>
		public static bool CodigoPostalIsValid( string CodigoPostal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CodigoPostal. Metodo Sobrecargado
		/// </summary>
		public static bool CodigoPostalIsValid( string CodigoPostal)
		{
			string mensaje;
			return CodigoPostalIsValid( CodigoPostal, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaCreacion.
		/// </summary>
		public static bool FechaCreacionIsValid( DateTime FechaCreacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaCreacion. Metodo Sobrecargado
		/// </summary>
		public static bool FechaCreacionIsValid( DateTime FechaCreacion)
		{
			string mensaje;
			return FechaCreacionIsValid( FechaCreacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdConexionCreacion.
		/// </summary>
		public static bool IdConexionCreacionIsValid( long IdConexionCreacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConexionCreacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdConexionCreacionIsValid( long IdConexionCreacion)
		{
			string mensaje;
			return IdConexionCreacionIsValid( IdConexionCreacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo UltimaModificacion.
		/// </summary>
		public static bool UltimaModificacionIsValid( byte[] UltimaModificacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo UltimaModificacion. Metodo Sobrecargado
		/// </summary>
		public static bool UltimaModificacionIsValid( byte[] UltimaModificacion)
		{
			string mensaje;
			return UltimaModificacionIsValid( UltimaModificacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdConexionUltimaModificacion.
		/// </summary>
		public static bool IdConexionUltimaModificacionIsValid( long IdConexionUltimaModificacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConexionUltimaModificacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdConexionUltimaModificacionIsValid( long IdConexionUltimaModificacion)
		{
			string mensaje;
			return IdConexionUltimaModificacionIsValid( IdConexionUltimaModificacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdReservado.
		/// </summary>
		public static bool IdReservadoIsValid( long IdReservado , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdReservado. Metodo Sobrecargado
		/// </summary>
		public static bool IdReservadoIsValid( long IdReservado)
		{
			string mensaje;
			return IdReservadoIsValid( IdReservado, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo RowId.
		/// </summary>
		public static bool RowIdIsValid( Guid RowId , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo RowId. Metodo Sobrecargado
		/// </summary>
		public static bool RowIdIsValid( Guid RowId)
		{
			string mensaje;
			return RowIdIsValid( RowId, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdEmpresa.
		/// </summary>
		public static bool IdEmpresaIsValid( long IdEmpresa , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEmpresa. Metodo Sobrecargado
		/// </summary>
		public static bool IdEmpresaIsValid( long IdEmpresa)
		{
			string mensaje;
			return IdEmpresaIsValid( IdEmpresa, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdSucursal.
		/// </summary>
		public static bool IdSucursalIsValid( long IdSucursal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdSucursal. Metodo Sobrecargado
		/// </summary>
		public static bool IdSucursalIsValid( long IdSucursal)
		{
			string mensaje;
			return IdSucursalIsValid( IdSucursal, out mensaje );
		}		
		

		public void Dispose()
		{
		}

		public static DataSet ValidarExistenciaLocalidad(string Id, long IdProvincia, long IdPais, string CodigoPostal, string nombre)
		{
			return mz.erp.dataaccess.tsh_Localidades.ValidarExistenciaLocalidad(Id,IdProvincia,IdPais,CodigoPostal,nombre);
		}
	}
}

