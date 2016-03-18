namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_Herramientas : IDisposable
	{
	
		#region Custom Members

		public static sy_HerramientasDataset GetList( string ShortCut )
		{
			return GetList(long.MinValue, long.MinValue, string.Empty, ShortCut, short.MinValue,false );

		}

		public static sy_HerramientasDataset GetList( long IdBarraHerramienta, long IdPerfil )
		{
			return mz.erp.dataaccess.sy_Herramientas.GetList( IdBarraHerramienta, IdPerfil );

		}

		public static DataSet GetListPadres( long IdBarraHerramienta )
		{
			return mz.erp.dataaccess.sy_Herramientas.GetListPadres( IdBarraHerramienta );

		}

		public static DataSet GetListHijos( long IdBarraHerramienta, long IdHerramientaPadre )
		{
			return mz.erp.dataaccess.sy_Herramientas.GetListHijos( IdBarraHerramienta, IdHerramientaPadre);

		}
		
		public static DataRow GetHerramientaEx_By_IdHerramientaIdRecurso(long IdHerramienta, long IdRecurso)
		{
            return mz.erp.dataaccess.sy_Herramientas.GetHerramientaEx_By_IdHerramientaIdRecurso(IdHerramienta, IdRecurso);
		}

		public static DataRow GetImagen_By_IdHerramienta(long IdHerramienta)
		{
			return mz.erp.dataaccess.sy_Herramientas.GetImagen_By_IdHerramienta(IdHerramienta);
		}

		public static void AddSeparator(string Id, long IdherramientaPadre)
		{
			mz.erp.dataaccess.sy_Herramientas.AddSeparator(Id, IdherramientaPadre);
		}

		#endregion
		
		/// <summary>
		/// Obtiene la lista completa de la tabla sy_Herramientas
		/// </summary>
		public static sy_HerramientasDataset GetList()
		{
			return mz.erp.dataaccess.sy_Herramientas.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla sy_Herramientas filtrada por las condiciones de bsqueda
		/// </summary>
		public static sy_HerramientasDataset GetList( long IdHerramienta, long IdHerramientaPadre, string Id, string ShortCut, short orden, bool Habilitado)
		{
			return mz.erp.dataaccess.sy_Herramientas.GetList( IdHerramienta, IdHerramientaPadre, Id, ShortCut, orden, Habilitado);
		}

		public static bool IncluirHerramientasDe(string idTransaction, string PerfilesNuevos, string PerfilesACopiar)
		{
			return mz.erp.dataaccess.sy_Herramientas.IncluirHerramientasDe(idTransaction, PerfilesNuevos, PerfilesACopiar);
		}

		/// <summary>
		/// Crea un sy_HerramientasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static sy_HerramientasDataset.sy_HerramientasRow NewRow()
		{
			return (sy_HerramientasDataset.sy_HerramientasRow)SetRowDefaultValues(mz.erp.dataaccess.sy_Herramientas.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_Herramientas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_HerramientasDataset.sy_HerramientasRow GetByPk( long IdHerramienta )
		{
			sy_HerramientasDataset.sy_HerramientasRow row = mz.erp.dataaccess.sy_Herramientas.GetByPk( IdHerramienta  );
			if(row != null)
			{
				foreach ( DataColumn dc in row.Table.Columns ) 
				{
					if (row[dc] == System.DBNull.Value)
					{
						if (dc.Caption != "RowId" && dc.Caption != "UltimaModificacion" && dc.Caption != "IdHerramientaPadre") 
						{ 
							row[dc] = Util.DefaultValue( dc.DataType );
						}
					}
				}
			}
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_Herramientas que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static sy_HerramientasDataset.sy_HerramientasRow GetByPk( object IdHerramienta )
		{
			return GetByPk( ( long )IdHerramienta );
		}

		/// <summary>
		/// Establece los valores por defecto de sy_HerramientasRow.
		/// </summary>
		public static DataRow SetRowDefaultValues( DataRow row )
		{
			row["IdHerramienta"] = 0; 
			row["IdHerramientaPadre"] = 0;
			row["Id"] = string.Empty;
			row["orden"] = 0;
			row["Habilitado"] = false;
			row["IdConexion"] = 0;
			row["FechaCreacion"] = mz.erp.businessrules.Sistema.DateTime.Now;
			row["IdConexionCreacion"] = Security.IdConexion;
			//row["UltimaModificacion"] = null;
			row["IdConexionUltimaModificacion"] = Security.IdConexion;
			row["RowId"] = Guid.Empty;
			row["Shortcut"] = string.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del sy_HerramientasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( sy_HerramientasDataset.sy_HerramientasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del sy_HerramientasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( sy_HerramientasDataset.sy_HerramientasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del sy_HerramientasRow a la base de datos.
		/// </summary>
		public static void Update( sy_HerramientasDataset.sy_HerramientasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Herramientas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_HerramientasDataset a la base de datos.
		/// </summary>
		public static void Update( sy_HerramientasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_Herramientas.Rows.Count > 0, "La tabla dataSet.sy_HerramientasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Herramientas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_HerramientasDataset.sy_HerramientasDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_HerramientasDataset.sy_HerramientasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Herramientas.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_HerramientasRow.
		/// </summary>
		public static bool RowIsValid( sy_HerramientasDataset.sy_HerramientasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdHerramientaIsValid( row.IdHerramienta, out mensaje) )
			{ 
				row.SetColumnError( "IdHerramienta" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdHerramientaPadreIsValid( row.IdHerramientaPadre, out mensaje) )
			{ 
				row.SetColumnError( "IdHerramientaPadre" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdIsValid( row.Id, out mensaje) )
			{ 
				row.SetColumnError( "Id" , mensaje);
				isValid=false;
			
			}
						
			if ( !ordenIsValid( row.orden, out mensaje) )
			{ 
				row.SetColumnError( "orden" , mensaje);
				isValid=false;
			
			}
						
			if ( !HabilitadoIsValid( row.Habilitado, out mensaje) )
			{ 
				row.SetColumnError( "Habilitado" , mensaje);
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
						
			if ( !ShortcutIsValid( row.Shortcut, out mensaje) )
			{ 
				row.SetColumnError( "Shortcut" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdHerramienta.
		/// </summary>
		public static bool IdHerramientaIsValid( long IdHerramienta , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdHerramienta. Metodo Sobrecargado
		/// </summary>
		public static bool IdHerramientaIsValid( long IdHerramienta)
		{
			string mensaje;
			return IdHerramientaIsValid( IdHerramienta, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdHerramientaPadre.
		/// </summary>
		public static bool IdHerramientaPadreIsValid( long IdHerramientaPadre , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdHerramientaPadre. Metodo Sobrecargado
		/// </summary>
		public static bool IdHerramientaPadreIsValid( long IdHerramientaPadre)
		{
			string mensaje;
			return IdHerramientaPadreIsValid( IdHerramientaPadre, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Id.
		/// </summary>
		public static bool IdIsValid( string Id , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Id. Metodo Sobrecargado
		/// </summary>
		public static bool IdIsValid( string Id)
		{
			string mensaje;
			return IdIsValid( Id, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo orden.
		/// </summary>
		public static bool ordenIsValid( short orden , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo orden. Metodo Sobrecargado
		/// </summary>
		public static bool ordenIsValid( short orden)
		{
			string mensaje;
			return ordenIsValid( orden, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Habilitado.
		/// </summary>
		public static bool HabilitadoIsValid( bool Habilitado , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Habilitado. Metodo Sobrecargado
		/// </summary>
		public static bool HabilitadoIsValid( bool Habilitado)
		{
			string mensaje;
			return HabilitadoIsValid( Habilitado, out mensaje );
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
		
		/// <summary>
		/// Valida el campo Shortcut.
		/// </summary>
		public static bool ShortcutIsValid( string Shortcut , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Shortcut. Metodo Sobrecargado
		/// </summary>
		public static bool ShortcutIsValid( string Shortcut)
		{
			string mensaje;
			return ShortcutIsValid( Shortcut, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}

