namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_ProveedoresCondicionesImpuestoGanancias : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tpu_ProveedoresCondicionesImpuestoGanancias()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_ProveedoresCondicionesImpuestoGanancias
		/// </summary>
		public static tpu_ProveedoresCondicionesImpuestoGananciasDataset GetList()
		{
			return mz.erp.dataaccess.tpu_ProveedoresCondicionesImpuestoGanancias.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_ProveedoresCondicionesImpuestoGanancias filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_ProveedoresCondicionesImpuestoGananciasDataset GetList( long IdCondicionImpuestoGanancias, string Descripcion, decimal Alicuota, bool AplicaImpuesto, bool Activo )
		{
			return mz.erp.dataaccess.tpu_ProveedoresCondicionesImpuestoGanancias.GetList( IdCondicionImpuestoGanancias, Descripcion, Alicuota, AplicaImpuesto, Activo );
		}

		/// <summary>
		/// Crea un tpu_ProveedoresCondicionesImpuestoGananciasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tpu_ProveedoresCondicionesImpuestoGananciasDataset.tpu_ProveedoresCondicionesImpuestoGananciasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tpu_ProveedoresCondicionesImpuestoGanancias.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_ProveedoresCondicionesImpuestoGanancias que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_ProveedoresCondicionesImpuestoGananciasDataset.tpu_ProveedoresCondicionesImpuestoGananciasRow GetByPk( long IdCondicionImpuestoGanancias )
		{
			tpu_ProveedoresCondicionesImpuestoGananciasDataset.tpu_ProveedoresCondicionesImpuestoGananciasRow row = mz.erp.dataaccess.tpu_ProveedoresCondicionesImpuestoGanancias.GetByPk( IdCondicionImpuestoGanancias  );
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
		/// Obtiene un registro de la tabla tpu_ProveedoresCondicionesImpuestoGanancias que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tpu_ProveedoresCondicionesImpuestoGananciasDataset.tpu_ProveedoresCondicionesImpuestoGananciasRow GetByPk( object IdCondicionImpuestoGanancias )
		{
			return GetByPk( ( long )IdCondicionImpuestoGanancias );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_ProveedoresCondicionesImpuestoGananciasRow.
		/// </summary>
		public static tpu_ProveedoresCondicionesImpuestoGananciasDataset.tpu_ProveedoresCondicionesImpuestoGananciasRow SetRowDefaultValues( tpu_ProveedoresCondicionesImpuestoGananciasDataset.tpu_ProveedoresCondicionesImpuestoGananciasRow row )
		{
			row.IdCondicionImpuestoGanancias = 0; 
			row.Descripcion = string.Empty;
			row.Alicuota = 0;
			row.AplicaImpuesto = false;
			row.Activo = false;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProveedoresCondicionesImpuestoGananciasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tpu_ProveedoresCondicionesImpuestoGananciasDataset.tpu_ProveedoresCondicionesImpuestoGananciasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProveedoresCondicionesImpuestoGananciasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tpu_ProveedoresCondicionesImpuestoGananciasDataset.tpu_ProveedoresCondicionesImpuestoGananciasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProveedoresCondicionesImpuestoGananciasRow a la base de datos.
		/// </summary>
		public static void Update( tpu_ProveedoresCondicionesImpuestoGananciasDataset.tpu_ProveedoresCondicionesImpuestoGananciasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ProveedoresCondicionesImpuestoGanancias.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_ProveedoresCondicionesImpuestoGananciasDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_ProveedoresCondicionesImpuestoGananciasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_ProveedoresCondicionesImpuestoGanancias.Rows.Count > 0, "La tabla dataSet.tpu_ProveedoresCondicionesImpuestoGananciasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ProveedoresCondicionesImpuestoGanancias.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProveedoresCondicionesImpuestoGananciasDataset.tpu_ProveedoresCondicionesImpuestoGananciasDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_ProveedoresCondicionesImpuestoGananciasDataset.tpu_ProveedoresCondicionesImpuestoGananciasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ProveedoresCondicionesImpuestoGanancias.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_ProveedoresCondicionesImpuestoGananciasRow.
		/// </summary>
		public static bool RowIsValid( tpu_ProveedoresCondicionesImpuestoGananciasDataset.tpu_ProveedoresCondicionesImpuestoGananciasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdCondicionImpuestoGananciasIsValid( row.IdCondicionImpuestoGanancias, out mensaje) )
			{ 
				row.SetColumnError( "IdCondicionImpuestoGanancias" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
				isValid=false;
			
			}
						
			if ( !AlicuotaIsValid( row.Alicuota, out mensaje) )
			{ 
				row.SetColumnError( "Alicuota" , mensaje);
				isValid=false;
			
			}
						
			if ( !AplicaImpuestoIsValid( row.AplicaImpuesto, out mensaje) )
			{ 
				row.SetColumnError( "AplicaImpuesto" , mensaje);
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
			
			}
					*/	
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
		/// Valida el campo IdCondicionImpuestoGanancias.
		/// </summary>
		public static bool IdCondicionImpuestoGananciasIsValid( long IdCondicionImpuestoGanancias , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCondicionImpuestoGanancias. Metodo Sobrecargado
		/// </summary>
		public static bool IdCondicionImpuestoGananciasIsValid( long IdCondicionImpuestoGanancias)
		{
			string mensaje;
			return IdCondicionImpuestoGananciasIsValid( IdCondicionImpuestoGanancias, out mensaje );
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
		/// Valida el campo Alicuota.
		/// </summary>
		public static bool AlicuotaIsValid( decimal Alicuota , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Alicuota. Metodo Sobrecargado
		/// </summary>
		public static bool AlicuotaIsValid( decimal Alicuota)
		{
			string mensaje;
			return AlicuotaIsValid( Alicuota, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo AplicaImpuesto.
		/// </summary>
		public static bool AplicaImpuestoIsValid( bool AplicaImpuesto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo AplicaImpuesto. Metodo Sobrecargado
		/// </summary>
		public static bool AplicaImpuestoIsValid( bool AplicaImpuesto)
		{
			string mensaje;
			return AplicaImpuestoIsValid( AplicaImpuesto, out mensaje );
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

