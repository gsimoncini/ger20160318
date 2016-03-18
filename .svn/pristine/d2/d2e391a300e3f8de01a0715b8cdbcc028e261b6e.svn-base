namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_ConfiguracionesReglas : IDisposable
	{
	
		#region Custom Members
		public static sy_ConfiguracionesReglasDataset GetList(string IdRegla)
		{
			return mz.erp.dataaccess.sy_ConfiguracionesReglas.GetList( IdRegla );
		}
		#endregion
		
		public sy_ConfiguracionesReglas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_ConfiguracionesReglas
		/// </summary>
		public static sy_ConfiguracionesReglasDataset GetList()
		{
			return mz.erp.dataaccess.sy_ConfiguracionesReglas.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla sy_ConfiguracionesReglas filtrada por las condiciones de bsqueda
		/// </summary>
		public static sy_ConfiguracionesReglasDataset GetList( string IdConfiguracion, string nombre, string ValorDefault, string Valor, string IdRegla)
		{
			return mz.erp.dataaccess.sy_ConfiguracionesReglas.GetList( IdConfiguracion, nombre, ValorDefault, Valor, IdRegla);
		}

		/// <summary>
		/// Crea un sy_ConfiguracionesReglasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static sy_ConfiguracionesReglasDataset.sy_ConfiguracionesReglasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.sy_ConfiguracionesReglas.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_ConfiguracionesReglas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_ConfiguracionesReglasDataset.sy_ConfiguracionesReglasRow GetByPk( string IdConfiguracion )
		{
			sy_ConfiguracionesReglasDataset.sy_ConfiguracionesReglasRow row = mz.erp.dataaccess.sy_ConfiguracionesReglas.GetByPk( IdConfiguracion  );
			if (row!=null)
			{
				foreach ( DataColumn dc in row.Table.Columns ) 
				{
					if (row[dc] == System.DBNull.Value)
					{
						if (dc.Caption != "RowId" && !dc.Caption.ToUpper().Equals("ULTIMAMODIFICACION"))
                            row[dc] = Util.DefaultValue( dc.DataType );
					}
				}
			}
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_ConfiguracionesReglas que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static sy_ConfiguracionesReglasDataset.sy_ConfiguracionesReglasRow GetByPk( object IdConfiguracion )
		{
			return GetByPk( ( string )IdConfiguracion );
		}

		/// <summary>
		/// Establece los valores por defecto de sy_ConfiguracionesReglasRow.
		/// </summary>
		public static sy_ConfiguracionesReglasDataset.sy_ConfiguracionesReglasRow SetRowDefaultValues( sy_ConfiguracionesReglasDataset.sy_ConfiguracionesReglasRow row )
		{
			row.IdConfiguracion = Util.NewStringId(); 
			row.nombre = string.Empty;
			row.ValorDefault = string.Empty;
			row.Valor = string.Empty;
			row.IdRegla = string.Empty;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del sy_ConfiguracionesReglasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( sy_ConfiguracionesReglasDataset.sy_ConfiguracionesReglasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del sy_ConfiguracionesReglasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( sy_ConfiguracionesReglasDataset.sy_ConfiguracionesReglasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del sy_ConfiguracionesReglasRow a la base de datos.
		/// </summary>
		public static void Update( sy_ConfiguracionesReglasDataset.sy_ConfiguracionesReglasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_ConfiguracionesReglas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_ConfiguracionesReglasDataset a la base de datos.
		/// </summary>
		public static void Update( sy_ConfiguracionesReglasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_ConfiguracionesReglas.Rows.Count > 0, "La tabla dataSet.sy_ConfiguracionesReglasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_ConfiguracionesReglas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_ConfiguracionesReglasDataset.sy_ConfiguracionesReglasDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_ConfiguracionesReglasDataset.sy_ConfiguracionesReglasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_ConfiguracionesReglas.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_ConfiguracionesReglasRow.
		/// </summary>
		public static bool RowIsValid( sy_ConfiguracionesReglasDataset.sy_ConfiguracionesReglasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdConfiguracionIsValid( row.IdConfiguracion, out mensaje) )
			{ 
				row.SetColumnError( "IdConfiguracion" , mensaje);
				isValid=false;
			
			}
						
			if ( !nombreIsValid( row.nombre, out mensaje) )
			{ 
				row.SetColumnError( "nombre" , mensaje);
				isValid=false;
			
			}
						
			if ( !ValorDefaultIsValid( row.ValorDefault, out mensaje) )
			{ 
				row.SetColumnError( "ValorDefault" , mensaje);
				isValid=false;
			
			}
						
			if ( !ValorIsValid( row.Valor, out mensaje) )
			{ 
				row.SetColumnError( "Valor" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdReglaIsValid( row.IdRegla, out mensaje) )
			{ 
				row.SetColumnError( "IdRegla" , mensaje);
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
		/// Valida el campo IdConfiguracion.
		/// </summary>
		public static bool IdConfiguracionIsValid( string IdConfiguracion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConfiguracion. Metodo Sobrecargado
		/// </summary>
		public static bool IdConfiguracionIsValid( string IdConfiguracion)
		{
			string mensaje;
			return IdConfiguracionIsValid( IdConfiguracion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo nombre.
		/// </summary>
		public static bool nombreIsValid( string nombre , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo nombre. Metodo Sobrecargado
		/// </summary>
		public static bool nombreIsValid( string nombre)
		{
			string mensaje;
			return nombreIsValid( nombre, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo ValorDefault.
		/// </summary>
		public static bool ValorDefaultIsValid( string ValorDefault , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ValorDefault. Metodo Sobrecargado
		/// </summary>
		public static bool ValorDefaultIsValid( string ValorDefault)
		{
			string mensaje;
			return ValorDefaultIsValid( ValorDefault, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Valor.
		/// </summary>
		public static bool ValorIsValid( string Valor , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Valor. Metodo Sobrecargado
		/// </summary>
		public static bool ValorIsValid( string Valor)
		{
			string mensaje;
			return ValorIsValid( Valor, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdRegla.
		/// </summary>
		public static bool IdReglaIsValid( string IdRegla , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdRegla. Metodo Sobrecargado
		/// </summary>
		public static bool IdReglaIsValid( string IdRegla)
		{
			string mensaje;
			return IdReglaIsValid( IdRegla, out mensaje );
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

