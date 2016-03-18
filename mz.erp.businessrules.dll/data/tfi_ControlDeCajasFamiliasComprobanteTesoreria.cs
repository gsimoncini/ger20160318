namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tfi_ControlDeCajasFamiliasComprobanteTesoreria : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tfi_ControlDeCajasFamiliasComprobanteTesoreria()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tfi_ControlDeCajasFamiliasComprobanteTesoreria
		/// </summary>
		public static tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset GetList()
		{
			return mz.erp.dataaccess.tfi_ControlDeCajasFamiliasComprobanteTesoreria.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tfi_ControlDeCajasFamiliasComprobanteTesoreria filtrada por las condiciones de bsqueda
		/// </summary>
		public static tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset GetList( string IdControlDeCajasFamiliasComprobanteTesoreria, string Descripcion, bool Activo, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, Guid RowId )
		{
			return mz.erp.dataaccess.tfi_ControlDeCajasFamiliasComprobanteTesoreria.GetList( IdControlDeCajasFamiliasComprobanteTesoreria, Descripcion, Activo, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, RowId );
		}

		/// <summary>
		/// Crea un tfi_ControlDeCajasFamiliasComprobanteTesoreriaRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset.tfi_ControlDeCajasFamiliasComprobanteTesoreriaRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_ControlDeCajasFamiliasComprobanteTesoreria.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_ControlDeCajasFamiliasComprobanteTesoreria que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset.tfi_ControlDeCajasFamiliasComprobanteTesoreriaRow GetByPk( string IdControlDeCajasFamiliasComprobanteTesoreria )
		{
			tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset.tfi_ControlDeCajasFamiliasComprobanteTesoreriaRow row = mz.erp.dataaccess.tfi_ControlDeCajasFamiliasComprobanteTesoreria.GetByPk( IdControlDeCajasFamiliasComprobanteTesoreria  );
			if (row != null)
			{
				foreach ( DataColumn dc in row.Table.Columns ) 
				{
					if (row[dc] == System.DBNull.Value)
					{
						if (dc.Caption != "RowId")
                            row[dc] = Util.DefaultValue( dc.DataType );
					}
				}
			}
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_ControlDeCajasFamiliasComprobanteTesoreria que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset.tfi_ControlDeCajasFamiliasComprobanteTesoreriaRow GetByPk( object IdControlDeCajasFamiliasComprobanteTesoreria )
		{
			return GetByPk( ( string )IdControlDeCajasFamiliasComprobanteTesoreria );
		}

		/// <summary>
		/// Establece los valores por defecto de tfi_ControlDeCajasFamiliasComprobanteTesoreriaRow.
		/// </summary>
		public static tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset.tfi_ControlDeCajasFamiliasComprobanteTesoreriaRow SetRowDefaultValues( tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset.tfi_ControlDeCajasFamiliasComprobanteTesoreriaRow row )
		{
			row.IdControlDeCajasFamiliasComprobanteTesoreria = Util.NewStringId(); 
			row.Descripcion = string.Empty;
			row.Activo = false;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tfi_ControlDeCajasFamiliasComprobanteTesoreriaRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset.tfi_ControlDeCajasFamiliasComprobanteTesoreriaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tfi_ControlDeCajasFamiliasComprobanteTesoreriaRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset.tfi_ControlDeCajasFamiliasComprobanteTesoreriaRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_ControlDeCajasFamiliasComprobanteTesoreriaRow a la base de datos.
		/// </summary>
		public static void Update( tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset.tfi_ControlDeCajasFamiliasComprobanteTesoreriaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_ControlDeCajasFamiliasComprobanteTesoreria.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_ControlDeCajasFamiliasComprobanteTesoreria.Rows.Count > 0, "La tabla dataSet.tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_ControlDeCajasFamiliasComprobanteTesoreria.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset.tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset.tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_ControlDeCajasFamiliasComprobanteTesoreria.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tfi_ControlDeCajasFamiliasComprobanteTesoreriaRow.
		/// </summary>
		public static bool RowIsValid( tfi_ControlDeCajasFamiliasComprobanteTesoreriaDataset.tfi_ControlDeCajasFamiliasComprobanteTesoreriaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdControlDeCajasFamiliasComprobanteTesoreriaIsValid( row.IdControlDeCajasFamiliasComprobanteTesoreria, out mensaje) )
			{ 
				row.SetColumnError( "IdControlDeCajasFamiliasComprobanteTesoreria" , mensaje);
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
		/// Valida el campo IdControlDeCajasFamiliasComprobanteTesoreria.
		/// </summary>
		public static bool IdControlDeCajasFamiliasComprobanteTesoreriaIsValid( string IdControlDeCajasFamiliasComprobanteTesoreria , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdControlDeCajasFamiliasComprobanteTesoreria. Metodo Sobrecargado
		/// </summary>
		public static bool IdControlDeCajasFamiliasComprobanteTesoreriaIsValid( string IdControlDeCajasFamiliasComprobanteTesoreria)
		{
			string mensaje;
			return IdControlDeCajasFamiliasComprobanteTesoreriaIsValid( IdControlDeCajasFamiliasComprobanteTesoreria, out mensaje );
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

