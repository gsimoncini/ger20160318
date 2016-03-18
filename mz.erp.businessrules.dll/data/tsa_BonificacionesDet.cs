namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_BonificacionesDet : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsa_BonificacionesDet()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_BonificacionesDet
		/// </summary>
		public static tsa_BonificacionesDetDataset GetList()
		{
			return mz.erp.dataaccess.tsa_BonificacionesDet.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsa_BonificacionesDet filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_BonificacionesDetDataset GetList( string IdBonificacion, decimal Valor )
		{
			return mz.erp.dataaccess.tsa_BonificacionesDet.GetList( IdBonificacion, Valor );
		}

		/// <summary>
		/// Crea un tsa_BonificacionesDetRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsa_BonificacionesDetDataset.tsa_BonificacionesDetRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsa_BonificacionesDet.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_BonificacionesDet que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_BonificacionesDetDataset.tsa_BonificacionesDetRow GetByPk( string IdBonificacion, long Ordinal )
		{
			tsa_BonificacionesDetDataset.tsa_BonificacionesDetRow row = mz.erp.dataaccess.tsa_BonificacionesDet.GetByPk( IdBonificacion, Ordinal  );
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
		/// Obtiene un registro de la tabla tsa_BonificacionesDet que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsa_BonificacionesDetDataset.tsa_BonificacionesDetRow GetByPk( object IdBonificacion, object Ordinal )
		{
			return GetByPk( ( string )IdBonificacion, ( long )Ordinal );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_BonificacionesDetRow.
		/// </summary>
		public static tsa_BonificacionesDetDataset.tsa_BonificacionesDetRow SetRowDefaultValues( tsa_BonificacionesDetDataset.tsa_BonificacionesDetRow row )
		{
			row.IdBonificacion = Util.NewStringId(); 
			row.Ordinal = 0; 
			row.Minimo = 0;
			row.Maximo = 0;
			row.Valor = 0;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsa_BonificacionesDetRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsa_BonificacionesDetDataset.tsa_BonificacionesDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsa_BonificacionesDetRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsa_BonificacionesDetDataset.tsa_BonificacionesDetRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_BonificacionesDetRow a la base de datos.
		/// </summary>
		public static void Update( tsa_BonificacionesDetDataset.tsa_BonificacionesDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_BonificacionesDet.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_BonificacionesDetDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_BonificacionesDetDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_BonificacionesDet.Rows.Count > 0, "La tabla dataSet.tsa_BonificacionesDetDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_BonificacionesDet.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_BonificacionesDetDataset.tsa_BonificacionesDetDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_BonificacionesDetDataset.tsa_BonificacionesDetDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_BonificacionesDet.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_BonificacionesDetRow.
		/// </summary>
		public static bool RowIsValid( tsa_BonificacionesDetDataset.tsa_BonificacionesDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdBonificacionIsValid( row.IdBonificacion, out mensaje) )
			{ 
				row.SetColumnError( "IdBonificacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !OrdinalIsValid( row.Ordinal, out mensaje) )
			{ 
				row.SetColumnError( "Ordinal" , mensaje);
				isValid=false;
			
			}
						
			if ( !MinimoIsValid( row.Minimo, out mensaje) )
			{ 
				row.SetColumnError( "Minimo" , mensaje);
				isValid=false;
			
			}
						
			if ( !MaximoIsValid( row.Maximo, out mensaje) )
			{ 
				row.SetColumnError( "Maximo" , mensaje);
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
		/// Valida el campo IdBonificacion.
		/// </summary>
		public static bool IdBonificacionIsValid( string IdBonificacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdBonificacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdBonificacionIsValid( string IdBonificacion)
		{
			string mensaje;
			return IdBonificacionIsValid( IdBonificacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Ordinal.
		/// </summary>
		public static bool OrdinalIsValid( long Ordinal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Ordinal. Metodo Sobrecargado
		/// </summary>
		public static bool OrdinalIsValid( long Ordinal)
		{
			string mensaje;
			return OrdinalIsValid( Ordinal, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Minimo.
		/// </summary>
		public static bool MinimoIsValid( decimal Minimo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Minimo. Metodo Sobrecargado
		/// </summary>
		public static bool MinimoIsValid( decimal Minimo)
		{
			string mensaje;
			return MinimoIsValid( Minimo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Maximo.
		/// </summary>
		public static bool MaximoIsValid( decimal Maximo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Maximo. Metodo Sobrecargado
		/// </summary>
		public static bool MaximoIsValid( decimal Maximo)
		{
			string mensaje;
			return MaximoIsValid( Maximo, out mensaje );
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

