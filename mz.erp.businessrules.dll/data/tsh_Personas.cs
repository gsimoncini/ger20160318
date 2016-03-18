namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsh_Personas : IDisposable
	{
	
		#region Custom Members
		public static tsh_PersonasDataset GetList(string IdPersona, string Nombre, string Telefonos,  string Email, bool ByActivo, bool Activo )
		{
			return mz.erp.dataaccess.tsh_Personas.GetList(IdPersona, Nombre, Telefonos, Email, ByActivo, Activo );
		}

		#endregion
		
		public tsh_Personas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_Personas
		/// </summary>
		public static tsh_PersonasDataset GetList()
		{
			return mz.erp.dataaccess.tsh_Personas.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsh_Personas filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsh_PersonasDataset GetList( string IdPersona, string Nombre, string Telefonos )
		{
			return mz.erp.dataaccess.tsh_Personas.GetList( IdPersona, Nombre, Telefonos );
		}

		/// <summary>
		/// Crea un tsh_PersonasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsh_PersonasDataset.tsh_PersonasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsh_Personas.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_Personas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_PersonasDataset.tsh_PersonasRow GetByPk( string IdPersona )
		{
			tsh_PersonasDataset.tsh_PersonasRow row = mz.erp.dataaccess.tsh_Personas.GetByPk( IdPersona  );
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
		/// Obtiene un registro de la tabla tsh_Personas que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsh_PersonasDataset.tsh_PersonasRow GetByPk( object IdPersona )
		{
			return GetByPk( ( string )IdPersona );
		}

		#region delete
		[ atMethodDeleteRow]
		public static void Delete(tsh_PersonasDataset.tsh_PersonasRow row)
		{
			
			row.Delete();
			Update(row);
			if	(row.Table.HasErrors)
			{
				row.RejectChanges();
				row["Activo"] = false;
				Update(row);
				if (row.Table.HasErrors)
				{
					row.SetColumnError("IdPersona","No se ha podido eliminar el item.");
				}
				else
				{
					row.SetColumnError("IdPersona","No se ha podido eliminar el item porque existen tablas relacionadas. Se procede a desactivarlo.");
				}
			}

		}
		
		#endregion

		/// <summary>
		/// Establece los valores por defecto de tsh_PersonasRow.
		/// </summary>
		public static tsh_PersonasDataset.tsh_PersonasRow SetRowDefaultValues( tsh_PersonasDataset.tsh_PersonasRow row )
		{
			row.IdPersona = Util.NewStringId(); 
			row.Nombre = string.Empty;
			row.Comentarios = string.Empty;
			row.Telefonos = string.Empty;
			row.Email = string.Empty;
			row.Activo = true;
			row.InstantMesseger = string.Empty;
			row.Observaciones = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdTratamiento = 0;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsh_PersonasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsh_PersonasDataset.tsh_PersonasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsh_PersonasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsh_PersonasDataset.tsh_PersonasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_PersonasRow a la base de datos.
		/// </summary>
		public static void Update( tsh_PersonasDataset.tsh_PersonasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			//Nuevo
			SentenciasReplicacion replication = new SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tsh_Personas";
			mz.erp.dataaccess.tsh_Personas.Replicacion = replication;	
			
			
			mz.erp.dataaccess.tsh_Personas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsh_PersonasDataset a la base de datos.
		/// </summary>
		public static void Update( tsh_PersonasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_Personas.Rows.Count > 0, "La tabla dataSet.tsh_PersonasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			//Nuevo
			SentenciasReplicacion replication = new SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdEmpresa;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tsa_Cuentas";
			mz.erp.dataaccess.tsh_Personas.Replicacion = replication;	
			mz.erp.dataaccess.tsh_Personas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_PersonasDataset.tsh_PersonasDataTable a la base de datos.
		/// </summary>
		public static void Update( tsh_PersonasDataset.tsh_PersonasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			//Nuevo
			SentenciasReplicacion replication = new SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tsa_Cuentas";
			mz.erp.dataaccess.tsh_Personas.Replicacion = replication;	
			
			
			mz.erp.dataaccess.tsh_Personas.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsh_PersonasRow.
		/// </summary>
		public static bool RowIsValid( tsh_PersonasDataset.tsh_PersonasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdPersonaIsValid( row.IdPersona, out mensaje) )
			{ 
				row.SetColumnError( "IdPersona" , mensaje);
				isValid=false;
			
			}
						
			if ( !NombreIsValid( row.Nombre, out mensaje) )
			{ 
				row.SetColumnError( "Nombre" , mensaje);
				isValid=false;
			
			}
						
			if ( !ComentariosIsValid( row.Comentarios, out mensaje) )
			{ 
				row.SetColumnError( "Comentarios" , mensaje);
				isValid=false;
			
			}
						
			if ( !TelefonosIsValid( row.Telefonos, out mensaje) )
			{ 
				row.SetColumnError( "Telefonos" , mensaje);
				isValid=false;
			
			}
						
			if ( !EmailIsValid( row.Email, out mensaje) )
			{ 
				row.SetColumnError( "Email" , mensaje);
				isValid=false;
			
			}
						
			if ( !InstantMessegerIsValid( row.InstantMesseger, out mensaje) )
			{ 
				row.SetColumnError( "InstantMesseger" , mensaje);
				isValid=false;
			
			}
						
			if ( !ObservacionesIsValid( row.Observaciones, out mensaje) )
			{ 
				row.SetColumnError( "Observaciones" , mensaje);
				isValid=false;
			
			}
						
		/*	if ( !FechaCreacionIsValid( row.FechaCreacion, out mensaje) )
			{ 
				row.SetColumnError( "FechaCreacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdConexionCreacionIsValid( row.IdConexionCreacion, out mensaje) )
			{ 
				row.SetColumnError( "IdConexionCreacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !UltimaModificacionIsValid( row.UltimaModificacion, out mensaje) )
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
						
			if ( !IdTratamientoIsValid( row.IdTratamiento, out mensaje) )
			{ 
				row.SetColumnError( "IdTratamiento" , mensaje);
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
			
			}
			;*/
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdPersona.
		/// </summary>
		public static bool IdPersonaIsValid( string IdPersona , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdPersona. Metodo Sobrecargado
		/// </summary>
		public static bool IdPersonaIsValid( string IdPersona)
		{
			string mensaje;
			return IdPersonaIsValid( IdPersona, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Nombre.
		/// </summary>
		public static bool NombreIsValid( string Nombre , out string mensaje )
		{
			if (Nombre =="")
			{	
				mensaje = "Debe Ingresar el nombre de la Persona";
				return false;
			}
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Nombre. Metodo Sobrecargado
		/// </summary>
		public static bool NombreIsValid( string Nombre)
		{
			string mensaje;
			return NombreIsValid( Nombre, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Comentarios.
		/// </summary>
		public static bool ComentariosIsValid( string Comentarios , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Comentarios. Metodo Sobrecargado
		/// </summary>
		public static bool ComentariosIsValid( string Comentarios)
		{
			string mensaje;
			return ComentariosIsValid( Comentarios, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Telefonos.
		/// </summary>
		public static bool TelefonosIsValid( string Telefonos , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Telefonos. Metodo Sobrecargado
		/// </summary>
		public static bool TelefonosIsValid( string Telefonos)
		{
			string mensaje;
			return TelefonosIsValid( Telefonos, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Email.
		/// </summary>
		public static bool EmailIsValid( string Email , out string mensaje )
		{
			if(!Email.Equals(string.Empty))
			{
				if  (!mz.erp.systemframework.Util.IsValidEmail(Email))
				{	
					mensaje ="Ingrese un email valido: cuenta@proveedor.dominio";
					return false;
				}
			}
			
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Email. Metodo Sobrecargado
		/// </summary>
		public static bool EmailIsValid( string Email)
		{
			string mensaje;
			return EmailIsValid( Email, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo InstantMesseger.
		/// </summary>
		public static bool InstantMessegerIsValid( string InstantMesseger , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo InstantMesseger. Metodo Sobrecargado
		/// </summary>
		public static bool InstantMessegerIsValid( string InstantMesseger)
		{
			string mensaje;
			return InstantMessegerIsValid( InstantMesseger, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Observaciones.
		/// </summary>
		public static bool ObservacionesIsValid( string Observaciones , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Observaciones. Metodo Sobrecargado
		/// </summary>
		public static bool ObservacionesIsValid( string Observaciones)
		{
			string mensaje;
			return ObservacionesIsValid( Observaciones, out mensaje );
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
		/// Valida el campo IdTratamiento.
		/// </summary>
		public static bool IdTratamientoIsValid( long IdTratamiento , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTratamiento. Metodo Sobrecargado
		/// </summary>
		public static bool IdTratamientoIsValid( long IdTratamiento)
		{
			string mensaje;
			return IdTratamientoIsValid( IdTratamiento, out mensaje );
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
		
	}
}

