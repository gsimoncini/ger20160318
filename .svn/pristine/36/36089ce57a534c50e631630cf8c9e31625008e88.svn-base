namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_JerarquiaAgrupVariables : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public sy_JerarquiaAgrupVariables()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_JerarquiaAgrupVariables
		/// </summary>
		/// 		

		public static sy_JerarquiaAgrupVariablesDataset GetList(Char str)
		{
			return mz.erp.dataaccess.sy_JerarquiaAgrupVariables.GetList(str);
		}

		public static sy_JerarquiaAgrupVariablesDataset GetList(string IdPadre)
		{
			return mz.erp.dataaccess.sy_JerarquiaAgrupVariables.GetList(IdPadre);
		}

		public static sy_JerarquiaAgrupVariablesDataset GetList()
		{
			return mz.erp.dataaccess.sy_JerarquiaAgrupVariables.GetList();
		}


		/// <summary>
		/// Crea un sy_JerarquiaAgrupVariablesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static sy_JerarquiaAgrupVariablesDataset.sy_JerarquiaAgrupVariablesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.sy_JerarquiaAgrupVariables.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_JerarquiaAgrupVariables que luego puede ser persistido en la base de datos.
		/// </summary>
		///		
		
		public static sy_JerarquiaAgrupVariablesDataset.sy_JerarquiaAgrupVariablesRow GetByPk( string Id )
		{
			sy_JerarquiaAgrupVariablesDataset.sy_JerarquiaAgrupVariablesRow row = mz.erp.dataaccess.sy_JerarquiaAgrupVariables.GetByPk( Id  );
			foreach ( DataColumn dc in row.Table.Columns ) 
			{
				if (row[dc] == System.DBNull.Value)
				{
					row[dc] = Util.DefaultValue( dc.DataType );
				}
			}
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_JerarquiaAgrupVariables que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static sy_JerarquiaAgrupVariablesDataset.sy_JerarquiaAgrupVariablesRow GetByPk( object Id )
		{
			return GetByPk( ( string )Id );
		}

		/// <summary>
		/// Establece los valores por defecto de sy_JerarquiaAgrupVariablesRow.
		/// </summary>
		public static sy_JerarquiaAgrupVariablesDataset.sy_JerarquiaAgrupVariablesRow SetRowDefaultValues( sy_JerarquiaAgrupVariablesDataset.sy_JerarquiaAgrupVariablesRow row )
		{
			row.Id = Util.NewStringId(); 
			row.Descripcion = string.Empty;
			row.Nivel = 0;
			row.IdPadre = string.Empty;
			row.Jerarquia = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del sy_JerarquiaAgrupVariablesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( sy_JerarquiaAgrupVariablesDataset.sy_JerarquiaAgrupVariablesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del sy_JerarquiaAgrupVariablesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( sy_JerarquiaAgrupVariablesDataset.sy_JerarquiaAgrupVariablesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del sy_JerarquiaAgrupVariablesRow a la base de datos.
		/// </summary>
		public static void Update( sy_JerarquiaAgrupVariablesDataset.sy_JerarquiaAgrupVariablesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_JerarquiaAgrupVariables.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_JerarquiaAgrupVariablesDataset a la base de datos.
		/// </summary>
		public static void Update( sy_JerarquiaAgrupVariablesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_JerarquiaAgrupVariables.Rows.Count > 0, "La tabla dataSet.sy_JerarquiaAgrupVariablesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_JerarquiaAgrupVariables.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_JerarquiaAgrupVariablesDataset.sy_JerarquiaAgrupVariablesDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_JerarquiaAgrupVariablesDataset.sy_JerarquiaAgrupVariablesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_JerarquiaAgrupVariables.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_JerarquiaAgrupVariablesRow.
		/// </summary>
		/// 
		public static bool RowIsValid( sy_JerarquiaAgrupVariablesDataset.sy_JerarquiaAgrupVariablesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdIsValid( row.Id, out mensaje) )
			{ 
				row.SetColumnError( "Id" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
				isValid=false;
			
			}
						
			if ( !NivelIsValid( row.Nivel, out mensaje) )
			{ 
				row.SetColumnError( "Nivel" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdPadreIsValid( row.IdPadre, out mensaje) )
			{ 
				row.SetColumnError( "IdPadre" , mensaje);
				isValid=false;
			
			}
						
			if ( !JerarquiaIsValid( row.Jerarquia, out mensaje) )
			{ 
				row.SetColumnError( "Jerarquia" , mensaje);
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
			;
			
			return isValid;
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
		/// Valida el campo Nivel.
		/// </summary>
		public static bool NivelIsValid( long Nivel , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Nivel. Metodo Sobrecargado
		/// </summary>
		public static bool NivelIsValid( long Nivel)
		{
			string mensaje;
			return NivelIsValid( Nivel, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdPadre.
		/// </summary>
		public static bool IdPadreIsValid( string IdPadre , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdPadre. Metodo Sobrecargado
		/// </summary>
		public static bool IdPadreIsValid( string IdPadre)
		{
			string mensaje;
			return IdPadreIsValid( IdPadre, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Jerarquia.
		/// </summary>
		public static bool JerarquiaIsValid( string Jerarquia , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Jerarquia. Metodo Sobrecargado
		/// </summary>
		public static bool JerarquiaIsValid( string Jerarquia)
		{
			string mensaje;
			return JerarquiaIsValid( Jerarquia, out mensaje );
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
		

		public void Dispose()
		{
		}
		
	}
}

