

		
		namespace mz.erp.businessrules 
		{
			using System;
			using System.Data;
			using System.Text.RegularExpressions;
			using mz.erp.systemframework;
			using mz.erp.commontypes;
			using mz.erp.commontypes.data;
			using mz.erp.dataaccess;

			public class sy_Perfiles : IDisposable
			{
	
				#region Custom Members
				public static sy_PerfilesDataset GetList( long IdEmpresa, string IdUsuario )
				{
					return mz.erp.dataaccess.sy_Perfiles.GetList( IdEmpresa, IdUsuario );
				}
				
				#endregion
		
				public sy_Perfiles()
				{
				}

				/// <summary>
				/// Obtiene la lista completa de la tabla sy_Perfiles
				/// </summary>
				public static sy_PerfilesDataset GetList()
				{
					return mz.erp.dataaccess.sy_Perfiles.GetList();
				}
				public static sy_PerfilesDataset GetList( bool Activo )
				{
					return (sy_PerfilesDataset) mz.erp.dataaccess.sy_Perfiles.GetList(Activo);
				}
		
				/// <summary>
				/// Obtiene tabla sy_Perfiles filtrada por las condiciones de bsqueda
				/// </summary>
				public static sy_PerfilesDataset GetList( long IdPerfil, string Descripcion, bool Activo, string Comentario, long IdConexion, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, Guid RowId )
				{
					return mz.erp.dataaccess.sy_Perfiles.GetList( IdPerfil, Descripcion, Activo, Comentario, IdConexion, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, RowId );
				}

				/// <summary>
				/// Crea un sy_PerfilesRow que luego puede ser persistido en la base de datos.
				/// </summary>
				[ atMethodNewRow ]
				public static sy_PerfilesDataset.sy_PerfilesRow NewRow()
				{
					return SetRowDefaultValues(mz.erp.dataaccess.sy_Perfiles.NewRow());
				}

				/// <summary>
				/// Obtiene un registro de la tabla sy_Perfiles que luego puede ser persistido en la base de datos.
				/// </summary>
				public static sy_PerfilesDataset.sy_PerfilesRow GetByPk( long IdPerfil )
				{
					sy_PerfilesDataset.sy_PerfilesRow row = mz.erp.dataaccess.sy_Perfiles.GetByPk( IdPerfil  );
					if(row != null)
					{
						foreach ( DataColumn dc in row.Table.Columns ) 
						{
							if (row[dc] == System.DBNull.Value)
							{
								if (dc.Caption != "RowId" ) 
								{ 
									row[dc] = Util.DefaultValue( dc.DataType ); //esta linea dejarla
								}	
							}
						}
					}
					return row;

				}

				/// <summary>
				/// Obtiene un registro de la tabla sy_Perfiles que luego puede ser persistido en la base de datos. Metodo Sobrecargado
				/// </summary>
				[ atMethodGetByPkRow ]
				public static sy_PerfilesDataset.sy_PerfilesRow GetByPk( object IdPerfil )
				{
					return GetByPk( ( long )IdPerfil );
				}

				/// <summary>
				/// Establece los valores por defecto de sy_PerfilesRow.
				/// </summary>
				public static sy_PerfilesDataset.sy_PerfilesRow SetRowDefaultValues( sy_PerfilesDataset.sy_PerfilesRow row )
				{
					row.IdPerfil = 0; 
					row.Descripcion = string.Empty;
					row.Activo = false;
					row.Comentario = string.Empty;
					row.IdConexion = 0;
					row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
					row.IdConexionCreacion = Security.IdConexion;
					row.UltimaModificacion = null;
					row.IdConexionUltimaModificacion = Security.IdConexion;
					row.RowId = Guid.Empty;

					return row;
				}
				
				public static DataRow SetRowDefaultValues( DataRow row )
				{
					row["IdPerfil"] = 0; 
					row["Descripcion"] = string.Empty;
					row["Activo"] = false;
					row["Comentario"] = string.Empty;
					row["IdConexion"] = 0;
					row["FechaCreacion"] = mz.erp.businessrules.Sistema.DateTime.Now;
					row["IdConexionCreacion"] = Security.IdConexion;
					//row["UltimaModificacion"] = null;
					row["IdConexionUltimaModificacion"] = Security.IdConexion;
					row["RowId"] = Guid.Empty;

					return row;
				}
		
				/// <summary>
				/// Envia los cambios del sy_PerfilesRow a la base de datos realizando una validacin previa.
				/// </summary>
				[ atMethodSaveRowWithValidation ]
				public static void UpdateWithValidation( sy_PerfilesDataset.sy_PerfilesRow row )
				{
					ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
					if ( RowIsValid( row ) )
					{
						Update( row );
					}
				}
		
				/// <summary>
				/// Envia los cambios del sy_PerfilesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
				/// </summary>
				public static void UpdateWithValidation( System.Data.DataRow row )
				{
					UpdateWithValidation( ( sy_PerfilesDataset.sy_PerfilesRow )row );
				}
		
				/// <summary>
				/// Envia los cambios del sy_PerfilesRow a la base de datos.
				/// </summary>
				public static void Update( sy_PerfilesDataset.sy_PerfilesRow row )
				{
					ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
					mz.erp.dataaccess.sy_Perfiles.Update( row );
				}

				/// <summary>
				/// Envia los cambios del sy_PerfilesDataset a la base de datos.
				/// </summary>
				public static void Update( sy_PerfilesDataset dataSet )
				{
					ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
					ApplicationAssert.Check( dataSet.sy_Perfiles.Rows.Count > 0, "La tabla dataSet.sy_PerfilesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
					mz.erp.dataaccess.sy_Perfiles.Update( dataSet );
				}
		
				/// <summary>
				/// Envia los cambios del sy_PerfilesDataset.sy_PerfilesDataTable a la base de datos.
				/// </summary>
				public static void Update( sy_PerfilesDataset.sy_PerfilesDataTable dataTable )
				{
					ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
					ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
					mz.erp.dataaccess.sy_Perfiles.Update( dataTable );
				}
		
				/// <summary>
				/// Valida un sy_PerfilesRow.
				/// </summary>
				public static bool RowIsValid( sy_PerfilesDataset.sy_PerfilesRow row )
				{
					ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
					bool isValid=true;
					string mensaje;
			
			
					if ( !IdPerfilIsValid( row.IdPerfil, out mensaje) )
					{ 
						row.SetColumnError( "IdPerfil" , mensaje);
						isValid=false;
			
					}
						
					if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
					{ 
						row.SetColumnError( "Descripcion" , mensaje);
						isValid=false;
			
					}
						
					if ( !ActivoIsValid( row.Activo, out mensaje) )
					{ 
						row.SetColumnError( "Activo" , mensaje);
						isValid=false;
			
					}
						
					if ( !ComentarioIsValid( row.Comentario, out mensaje) )
					{ 
						row.SetColumnError( "Comentario" , mensaje);
						isValid=false;
			
					}
						
					if ( !IdConexionIsValid( row.IdConexion, out mensaje) )
					{ 
						row.SetColumnError( "IdConexion" , mensaje);
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
						
					if ( !RowIdIsValid( row.RowId, out mensaje) )
					{ 
						row.SetColumnError( "RowId" , mensaje);
						isValid=false;
			
					}
					;
			
					return isValid;
				}
		
				/// <summary>
				/// Valida el campo IdPerfil.
				/// </summary>
				public static bool IdPerfilIsValid( long IdPerfil , out string mensaje )
				{
					//Agregar cdigo de validacin
					mensaje="";
					return true;
				}
		
				/// <summary>
				/// Valida el campo IdPerfil. Metodo Sobrecargado
				/// </summary>
				public static bool IdPerfilIsValid( long IdPerfil)
				{
					string mensaje;
					return IdPerfilIsValid( IdPerfil, out mensaje );
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
				/// Valida el campo Activo.
				/// </summary>
				public static bool ActivoIsValid( bool Activo , out string mensaje )
				{
					//Agregar cdigo de validacin
					mensaje="";
					return true;
				}
		
				/// <summary>
				/// Valida el campo Activo. Metodo Sobrecargado
				/// </summary>
				public static bool ActivoIsValid( bool Activo)
				{
					string mensaje;
					return ActivoIsValid( Activo, out mensaje );
				}		
		
				/// <summary>
				/// Valida el campo Comentario.
				/// </summary>
				public static bool ComentarioIsValid( string Comentario , out string mensaje )
				{
					//Agregar cdigo de validacin
					mensaje="";
					return true;
				}
		
				/// <summary>
				/// Valida el campo Comentario. Metodo Sobrecargado
				/// </summary>
				public static bool ComentarioIsValid( string Comentario)
				{
					string mensaje;
					return ComentarioIsValid( Comentario, out mensaje );
				}		
		
				/// <summary>
				/// Valida el campo IdConexion.
				/// </summary>
				public static bool IdConexionIsValid( long IdConexion , out string mensaje )
				{
					//Agregar cdigo de validacin
					mensaje="";
					return true;
				}
		
				/// <summary>
				/// Valida el campo IdConexion. Metodo Sobrecargado
				/// </summary>
				public static bool IdConexionIsValid( long IdConexion)
				{
					string mensaje;
					return IdConexionIsValid( IdConexion, out mensaje );
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
		

				public void Dispose()
				{
				}
		
			}
		}

