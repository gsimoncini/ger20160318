namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsy_SubTipoMovimiento : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsy_SubTipoMovimiento()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsy_SubTipoMovimiento
		/// </summary>
		public static tsy_SubTipoMovimientoDataset GetList()
		{
			return mz.erp.dataaccess.tsy_SubTipoMovimiento.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsy_SubTipoMovimiento filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsy_SubTipoMovimientoDataset GetList( string IdTipoMovimiento )
		{
			return mz.erp.dataaccess.tsy_SubTipoMovimiento.GetList( IdTipoMovimiento );
		}

		/// <summary>
		/// Crea un tsy_SubTipoMovimientoRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsy_SubTipoMovimientoDataset.tsy_SubTipoMovimientoRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsy_SubTipoMovimiento.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsy_SubTipoMovimiento que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsy_SubTipoMovimientoDataset.tsy_SubTipoMovimientoRow GetByPk( string IdSubTipoMovimiento, string IdTipoMovimiento )
		{
			tsy_SubTipoMovimientoDataset.tsy_SubTipoMovimientoRow row = mz.erp.dataaccess.tsy_SubTipoMovimiento.GetByPk( IdSubTipoMovimiento, IdTipoMovimiento  );
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
		/// Obtiene un registro de la tabla tsy_SubTipoMovimiento que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsy_SubTipoMovimientoDataset.tsy_SubTipoMovimientoRow GetByPk( object IdSubTipoMovimiento, string IdTipoMovimiento )
		{
			return GetByPk( ( string )IdSubTipoMovimiento, ( string )IdTipoMovimiento );
		}

		/// <summary>
		/// Establece los valores por defecto de tsy_SubTipoMovimientoRow.
		/// </summary>
		public static tsy_SubTipoMovimientoDataset.tsy_SubTipoMovimientoRow SetRowDefaultValues( tsy_SubTipoMovimientoDataset.tsy_SubTipoMovimientoRow row )
		{
			row.IdSubTipoMovimiento = Util.NewStringId(); 
			row.IdTipoMovimiento = Util.NewStringId(); 
			row.Descripcion = string.Empty;
			row.Sistema = false;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.Activo = true;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsy_SubTipoMovimientoRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsy_SubTipoMovimientoDataset.tsy_SubTipoMovimientoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsy_SubTipoMovimientoRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsy_SubTipoMovimientoDataset.tsy_SubTipoMovimientoRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_SubTipoMovimientoRow a la base de datos.
		/// </summary>
		public static void Update( tsy_SubTipoMovimientoDataset.tsy_SubTipoMovimientoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_SubTipoMovimiento.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsy_SubTipoMovimientoDataset a la base de datos.
		/// </summary>
		public static void Update( tsy_SubTipoMovimientoDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsy_SubTipoMovimiento.Rows.Count > 0, "La tabla dataSet.tsy_SubTipoMovimientoDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_SubTipoMovimiento.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_SubTipoMovimientoDataset.tsy_SubTipoMovimientoDataTable a la base de datos.
		/// </summary>
		public static void Update( tsy_SubTipoMovimientoDataset.tsy_SubTipoMovimientoDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_SubTipoMovimiento.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsy_SubTipoMovimientoRow.
		/// </summary>
		public static bool RowIsValid( tsy_SubTipoMovimientoDataset.tsy_SubTipoMovimientoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdSubTipoMovimientoIsValid( row.IdSubTipoMovimiento, out mensaje) )
			{ 
				row.SetColumnError( "IdSubTipoMovimiento" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTipoMovimientoIsValid( row.IdTipoMovimiento, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoMovimiento" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
				isValid=false;
			
			}
						
			if ( !SistemaIsValid( row.Sistema, out mensaje) )
			{ 
				row.SetColumnError( "Sistema" , mensaje);
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
		/// Valida el campo IdSubTipoMovimiento.
		/// </summary>
		public static bool IdSubTipoMovimientoIsValid( string IdSubTipoMovimiento , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdSubTipoMovimiento. Metodo Sobrecargado
		/// </summary>
		public static bool IdSubTipoMovimientoIsValid( string IdSubTipoMovimiento)
		{
			string mensaje;
			return IdSubTipoMovimientoIsValid( IdSubTipoMovimiento, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTipoMovimiento.
		/// </summary>
		public static bool IdTipoMovimientoIsValid( string IdTipoMovimiento , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoMovimiento. Metodo Sobrecargado
		/// </summary>
		public static bool IdTipoMovimientoIsValid( string IdTipoMovimiento)
		{
			string mensaje;
			return IdTipoMovimientoIsValid( IdTipoMovimiento, out mensaje );
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
		/// Valida el campo Sistema.
		/// </summary>
		public static bool SistemaIsValid( bool Sistema , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Sistema. Metodo Sobrecargado
		/// </summary>
		public static bool SistemaIsValid( bool Sistema)
		{
			string mensaje;
			return SistemaIsValid( Sistema, out mensaje );
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

