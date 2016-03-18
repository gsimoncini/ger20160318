namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class st_Falla : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public st_Falla()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla st_Falla
		/// </summary>
        public static st_FallaDataset GetList()
		{
			return mz.erp.dataaccess.st_Falla.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla st_Falla filtrada por las condiciones de bsqueda
		/// </summary>
        public static st_FallaDataset GetList(long IdFalla, string Descripcion, int DuracionDias, decimal Costo, decimal CostoMaximo, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, Guid RowId, decimal CostoPresupuesto)
		{
			return mz.erp.dataaccess.st_Falla.GetList( IdFalla, Descripcion, DuracionDias, Costo, CostoMaximo, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, RowId, CostoPresupuesto );
		}

		/// <summary>
		/// Crea un st_FallaRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static st_FallaDataset.st_FallaRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.st_Falla.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla st_Falla que luego puede ser persistido en la base de datos.
		/// </summary>
		public static st_FallaDataset.st_FallaRow GetByPk( long IdFalla )
		{
			st_FallaDataset.st_FallaRow row = mz.erp.dataaccess.st_Falla.GetByPk( IdFalla  );
			if(row != null)
			{
				foreach ( DataColumn dc in row.Table.Columns ) 
				{
					if(!dc.Caption.ToUpper().Equals("ROWID"))
					{
						if (row[dc] == System.DBNull.Value)
						{
							row[dc] = Util.DefaultValue( dc.DataType );
						}
					}
				}
			}
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla st_Falla que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static st_FallaDataset.st_FallaRow GetByPk( object IdFalla )
		{
			return GetByPk( ( long )IdFalla );
		}

		/// <summary>
		/// Establece los valores por defecto de st_FallaRow.
		/// </summary>
		public static st_FallaDataset.st_FallaRow SetRowDefaultValues( st_FallaDataset.st_FallaRow row )
		{
			row.IdFalla = 0; 
			row.Descripcion = string.Empty;
			row.DuracionDias = 0;
			row.Costo = 0;
			row.CostoMaximo = 0;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;
			row.CostoPresupuesto = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del st_FallaRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( st_FallaDataset.st_FallaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del st_FallaRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( st_FallaDataset.st_FallaRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del st_FallaRow a la base de datos.
		/// </summary>
		public static void Update( st_FallaDataset.st_FallaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.st_Falla.Update( row );
		}

		/// <summary>
		/// Envia los cambios del st_FallaDataset a la base de datos.
		/// </summary>
		public static void Update( st_FallaDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.st_Falla.Rows.Count > 0, "La tabla dataSet.st_FallaDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.st_Falla.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del st_FallaDataset.st_FallaDataTable a la base de datos.
		/// </summary>
		public static void Update( st_FallaDataset.st_FallaDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.st_Falla.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un st_FallaRow.
		/// </summary>
		public static bool RowIsValid( st_FallaDataset.st_FallaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdFallaIsValid( row.IdFalla, out mensaje) )
			{ 
				row.SetColumnError( "IdFalla" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
				isValid=false;
			
			}
						
			if ( !DuracionDiasIsValid( row.DuracionDias, out mensaje) )
			{ 
				row.SetColumnError( "DuracionDias" , mensaje);
				isValid=false;
			
			}
						
			if ( !CostoIsValid( row.Costo, out mensaje) )
			{ 
				row.SetColumnError( "Costo" , mensaje);
				isValid=false;
			
			}
						
			if ( !CostoMaximoIsValid( row.CostoMaximo, out mensaje) )
			{ 
				row.SetColumnError( "CostoMaximo" , mensaje);
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
						
			if ( !CostoPresupuestoIsValid( row.CostoPresupuesto, out mensaje) )
			{ 
				row.SetColumnError( "CostoPresupuesto" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdFalla.
		/// </summary>
		public static bool IdFallaIsValid( long IdFalla , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdFalla. Metodo Sobrecargado
		/// </summary>
		public static bool IdFallaIsValid( long IdFalla)
		{
			string mensaje;
			return IdFallaIsValid( IdFalla, out mensaje );
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
		/// Valida el campo DuracionDias.
		/// </summary>
		public static bool DuracionDiasIsValid( int DuracionDias , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo DuracionDias. Metodo Sobrecargado
		/// </summary>
		public static bool DuracionDiasIsValid( int DuracionDias)
		{
			string mensaje;
			return DuracionDiasIsValid( DuracionDias, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Costo.
		/// </summary>
		public static bool CostoIsValid( decimal Costo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Costo. Metodo Sobrecargado
		/// </summary>
		public static bool CostoIsValid( decimal Costo)
		{
			string mensaje;
			return CostoIsValid( Costo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CostoMaximo.
		/// </summary>
		public static bool CostoMaximoIsValid( decimal CostoMaximo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CostoMaximo. Metodo Sobrecargado
		/// </summary>
		public static bool CostoMaximoIsValid( decimal CostoMaximo)
		{
			string mensaje;
			return CostoMaximoIsValid( CostoMaximo, out mensaje );
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
		/// Valida el campo CostoPresupuesto.
		/// </summary>
		public static bool CostoPresupuestoIsValid( decimal CostoPresupuesto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CostoPresupuesto. Metodo Sobrecargado
		/// </summary>
		public static bool CostoPresupuestoIsValid( decimal CostoPresupuesto)
		{
			string mensaje;
			return CostoPresupuestoIsValid( CostoPresupuesto, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}

