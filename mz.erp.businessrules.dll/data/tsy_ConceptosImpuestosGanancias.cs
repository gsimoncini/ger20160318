namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsy_ConceptosImpuestosGanancias : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsy_ConceptosImpuestosGanancias()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsy_ConceptosImpuestosGanancias
		/// </summary>
		public static tsy_ConceptosImpuestosGananciasDataset GetList()
		{
			return mz.erp.dataaccess.tsy_ConceptosImpuestosGanancias.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsy_ConceptosImpuestosGanancias filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsy_ConceptosImpuestosGananciasDataset GetList( long IdConceptoImpuestoGanancias, string Descripcion, bool Activo )
		{
			return mz.erp.dataaccess.tsy_ConceptosImpuestosGanancias.GetList( IdConceptoImpuestoGanancias, Descripcion, Activo );
		}

		/// <summary>
		/// Crea un tsy_ConceptosImpuestosGananciasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsy_ConceptosImpuestosGananciasDataset.tsy_ConceptosImpuestosGananciasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsy_ConceptosImpuestosGanancias.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsy_ConceptosImpuestosGanancias que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsy_ConceptosImpuestosGananciasDataset.tsy_ConceptosImpuestosGananciasRow GetByPk( long IdConceptoImpuestoGanancias )
		{
			tsy_ConceptosImpuestosGananciasDataset.tsy_ConceptosImpuestosGananciasRow row = mz.erp.dataaccess.tsy_ConceptosImpuestosGanancias.GetByPk( IdConceptoImpuestoGanancias  );
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
		/// Obtiene un registro de la tabla tsy_ConceptosImpuestosGanancias que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsy_ConceptosImpuestosGananciasDataset.tsy_ConceptosImpuestosGananciasRow GetByPk( object IdConceptoImpuestoGanancias )
		{
			return GetByPk( ( long )IdConceptoImpuestoGanancias );
		}

		/// <summary>
		/// Establece los valores por defecto de tsy_ConceptosImpuestosGananciasRow.
		/// </summary>
		public static tsy_ConceptosImpuestosGananciasDataset.tsy_ConceptosImpuestosGananciasRow SetRowDefaultValues( tsy_ConceptosImpuestosGananciasDataset.tsy_ConceptosImpuestosGananciasRow row )
		{
			row.IdConceptoImpuestoGanancias = 0; 
			row.Descripcion = string.Empty;
			row.Activo = false;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsy_ConceptosImpuestosGananciasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsy_ConceptosImpuestosGananciasDataset.tsy_ConceptosImpuestosGananciasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsy_ConceptosImpuestosGananciasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsy_ConceptosImpuestosGananciasDataset.tsy_ConceptosImpuestosGananciasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_ConceptosImpuestosGananciasRow a la base de datos.
		/// </summary>
		public static void Update( tsy_ConceptosImpuestosGananciasDataset.tsy_ConceptosImpuestosGananciasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_ConceptosImpuestosGanancias.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsy_ConceptosImpuestosGananciasDataset a la base de datos.
		/// </summary>
		public static void Update( tsy_ConceptosImpuestosGananciasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsy_ConceptosImpuestosGanancias.Rows.Count > 0, "La tabla dataSet.tsy_ConceptosImpuestosGananciasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_ConceptosImpuestosGanancias.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_ConceptosImpuestosGananciasDataset.tsy_ConceptosImpuestosGananciasDataTable a la base de datos.
		/// </summary>
		public static void Update( tsy_ConceptosImpuestosGananciasDataset.tsy_ConceptosImpuestosGananciasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_ConceptosImpuestosGanancias.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsy_ConceptosImpuestosGananciasRow.
		/// </summary>
		public static bool RowIsValid( tsy_ConceptosImpuestosGananciasDataset.tsy_ConceptosImpuestosGananciasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdConceptoImpuestoGananciasIsValid( row.IdConceptoImpuestoGanancias, out mensaje) )
			{ 
				row.SetColumnError( "IdConceptoImpuestoGanancias" , mensaje);
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
				/*		
			if ( !UltimaModificacionIsValid( row.UltimaModificacion, out mensaje) )
			{ 
				row.SetColumnError( "UltimaModificacion" , mensaje);
				isValid=false;
			
			}*/
						
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
						
			if ( !IdSucursalIsValid( row.IdSucursal, out mensaje) )
			{ 
				row.SetColumnError( "IdSucursal" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdConceptoImpuestoGanancias.
		/// </summary>
		public static bool IdConceptoImpuestoGananciasIsValid( long IdConceptoImpuestoGanancias , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConceptoImpuestoGanancias. Metodo Sobrecargado
		/// </summary>
		public static bool IdConceptoImpuestoGananciasIsValid( long IdConceptoImpuestoGanancias)
		{
			string mensaje;
			return IdConceptoImpuestoGananciasIsValid( IdConceptoImpuestoGanancias, out mensaje );
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

