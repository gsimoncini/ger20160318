
namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tfi_AgrupTDCompTesoreria : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tfi_AgrupTDCompTesoreria()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tfi_AgrupTDCompTesoreria
		/// </summary>
		public static tfi_AgrupTDCompTesoreriaDataset GetList()
		{
			return mz.erp.dataaccess.tfi_AgrupTDCompTesoreria.GetList();
		}
		public static tfi_AgrupTDCompTesoreriaDataset GetList(string IdTdCompTesoreria,string Jerarquia)
		{
			return mz.erp.dataaccess.tfi_AgrupTDCompTesoreria.GetList(IdTdCompTesoreria,Jerarquia);
		}
		/// <summary>
		/// Obtiene tabla tfi_AgrupTDCompTesoreria filtrada por las condiciones de bsqueda
		/// </summary>
		/*public static tfi_AgrupTDCompTesoreriaDataset GetList(  )
		{
			return mz.erp.dataaccess.tfi_AgrupTDCompTesoreria.GetList(  );
		}*/

		/// <summary>
		/// Crea un tfi_AgrupTDCompTesoreriaRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tfi_AgrupTDCompTesoreriaDataset.tfi_AgrupTDCompTesoreriaRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_AgrupTDCompTesoreria.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_AgrupTDCompTesoreria que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tfi_AgrupTDCompTesoreriaDataset.tfi_AgrupTDCompTesoreriaRow GetByPk( string IdTDCompTesoreria, string Jerarquia )
		{
			tfi_AgrupTDCompTesoreriaDataset.tfi_AgrupTDCompTesoreriaRow row = mz.erp.dataaccess.tfi_AgrupTDCompTesoreria.GetByPk( IdTDCompTesoreria, Jerarquia  );
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
		/// Obtiene un registro de la tabla tfi_AgrupTDCompTesoreria que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tfi_AgrupTDCompTesoreriaDataset.tfi_AgrupTDCompTesoreriaRow GetByPk( object IdTDCompTesoreria, object Jerarquia )
		{
			return GetByPk( ( string )IdTDCompTesoreria, ( string )Jerarquia );
		}

		/// <summary>
		/// Establece los valores por defecto de tfi_AgrupTDCompTesoreriaRow.
		/// </summary>
		public static tfi_AgrupTDCompTesoreriaDataset.tfi_AgrupTDCompTesoreriaRow SetRowDefaultValues( tfi_AgrupTDCompTesoreriaDataset.tfi_AgrupTDCompTesoreriaRow row )
		{
			row.IdTDCompTesoreria = Util.NewStringId(); 
			row.Jerarquia = Util.NewStringId(); 
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tfi_AgrupTDCompTesoreriaRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_AgrupTDCompTesoreriaDataset.tfi_AgrupTDCompTesoreriaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tfi_AgrupTDCompTesoreriaRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_AgrupTDCompTesoreriaDataset.tfi_AgrupTDCompTesoreriaRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_AgrupTDCompTesoreriaRow a la base de datos.
		/// </summary>
		public static void Update( tfi_AgrupTDCompTesoreriaDataset.tfi_AgrupTDCompTesoreriaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_AgrupTDCompTesoreria.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tfi_AgrupTDCompTesoreriaDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_AgrupTDCompTesoreriaDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_AgrupTDCompTesoreria.Rows.Count > 0, "La tabla dataSet.tfi_AgrupTDCompTesoreriaDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_AgrupTDCompTesoreria.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_AgrupTDCompTesoreriaDataset.tfi_AgrupTDCompTesoreriaDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_AgrupTDCompTesoreriaDataset.tfi_AgrupTDCompTesoreriaDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_AgrupTDCompTesoreria.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tfi_AgrupTDCompTesoreriaRow.
		/// </summary>
		public static bool RowIsValid( tfi_AgrupTDCompTesoreriaDataset.tfi_AgrupTDCompTesoreriaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdTDCompTesoreriaIsValid( row.IdTDCompTesoreria, out mensaje) )
			{ 
				row.SetColumnError( "IdTDCompTesoreria" , mensaje);
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
						
			if ( !IdEmpresaIsValid( row.IdEmpresa, out mensaje) )
			{ 
				row.SetColumnError( "IdEmpresa" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdTDCompTesoreria.
		/// </summary>
		public static bool IdTDCompTesoreriaIsValid( string IdTDCompTesoreria , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTDCompTesoreria. Metodo Sobrecargado
		/// </summary>
		public static bool IdTDCompTesoreriaIsValid( string IdTDCompTesoreria)
		{
			string mensaje;
			return IdTDCompTesoreriaIsValid( IdTDCompTesoreria, out mensaje );
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
		

		public void Dispose()
		{
		}
		
	}
}

