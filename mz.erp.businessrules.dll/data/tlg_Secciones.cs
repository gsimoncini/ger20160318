namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tlg_Secciones : IDisposable
	{
	
		#region Custom Members
        //Sabrina: Tarea 990. 20101214
        public static tlg_SeccionesDataset.tlg_SeccionesDataTable GetByIdDepositoDescripcion(string IdDeposito, string Descripcion)
        {
            return mz.erp.dataaccess.tlg_Secciones.GetByIdDepositoDescripcion(IdDeposito, Descripcion);
        }
        //Fin Sabrina: Tarea 990. 20101214
		#endregion
		
		public tlg_Secciones()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tlg_Secciones
		/// </summary>
		public static tlg_SeccionesDataset GetList()
		{
			return mz.erp.dataaccess.tlg_Secciones.GetList();
		}

		public static tlg_SeccionesDataset GetList(string IdDeposito, bool Activo)
		{
			string IdSeccion = string.Empty;			
			string Descripcion = string.Empty;
			string Ubicacion = string.Empty;
			string Comentario = string.Empty;
			long IdSucursal = long.MinValue;
			long IdEmpresa = long.MinValue;
			return mz.erp.dataaccess.tlg_Secciones.GetList(IdSeccion, IdDeposito, Descripcion, Ubicacion, Comentario, IdSucursal, IdEmpresa, Activo);				
		}
		
		/// <summary>
		/// Obtiene tabla tlg_Secciones filtrada por las condiciones de bsqueda
		/// </summary>
		public static tlg_SeccionesDataset GetList( string IdSeccion, string IdDeposito, string Descripcion, string Ubicacion, string Comentario, bool Activo, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{			
			return mz.erp.dataaccess.tlg_Secciones.GetList(IdSeccion, IdDeposito, Descripcion, Ubicacion, Comentario, IdSucursal, IdEmpresa, true);				
		}
		public static tlg_SeccionesDataset GetList( string IdSeccion, string IdDeposito, string Descripcion, string Ubicacion, string Comentario, long IdSucursal, long IdEmpresa, bool Activo )
		{			
			return mz.erp.dataaccess.tlg_Secciones.GetList(IdSeccion, IdDeposito, Descripcion, Ubicacion, Comentario, IdSucursal, IdEmpresa, Activo);				
		}
		public static tlg_SeccionesDataset GetList( string IdSeccion, string Descripcion, string Ubicacion, bool Activo)
		{			
			return mz.erp.dataaccess.tlg_Secciones.GetList(IdSeccion, Descripcion, Ubicacion, Activo);				
		}
		/// <summary>
		/// Crea un tlg_SeccionesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tlg_SeccionesDataset.tlg_SeccionesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tlg_Secciones.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tlg_Secciones que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tlg_SeccionesDataset.tlg_SeccionesRow GetByPk( string IdSeccion, string IdDeposito )
		{
			tlg_SeccionesDataset.tlg_SeccionesRow row = mz.erp.dataaccess.tlg_Secciones.GetByPk( IdSeccion, IdDeposito  );
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
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla tlg_Secciones que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tlg_SeccionesDataset.tlg_SeccionesRow GetByPk( object IdSeccion, string IdDeposito )
		{
			return GetByPk( ( string )IdSeccion, ( string )IdDeposito );
		}

		/// <summary>
		/// Establece los valores por defecto de tlg_SeccionesRow.
		/// </summary>
		public static tlg_SeccionesDataset.tlg_SeccionesRow SetRowDefaultValues( tlg_SeccionesDataset.tlg_SeccionesRow row )
		{
			row.IdSeccion = Util.NewStringId(); 
			row.IdDeposito = Util.NewStringId(); 
			row.Descripcion = string.Empty;
			row.Ubicacion = string.Empty;
			row.Comentario = string.Empty;
			row.Activo = true;			
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = Security.IdSucursal;
			row.IdEmpresa = Security.IdEmpresa;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tlg_SeccionesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tlg_SeccionesDataset.tlg_SeccionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tlg_SeccionesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tlg_SeccionesDataset.tlg_SeccionesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_SeccionesRow a la base de datos.
		/// </summary>
		public static void Update( tlg_SeccionesDataset.tlg_SeccionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_Secciones.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tlg_SeccionesDataset a la base de datos.
		/// </summary>
		public static void Update( tlg_SeccionesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tlg_Secciones.Rows.Count > 0, "La tabla dataSet.tlg_SeccionesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_Secciones.Update( dataSet );
		}

        //Sabrina: Tarea 990. 20101214
        public static void UpdateWithValidation(tlg_SeccionesDataset.tlg_SeccionesDataTable dataTable)
        {
            bool isValid = true;
            foreach (tlg_SeccionesDataset.tlg_SeccionesRow row in dataTable.Rows)
            {
                //Si es un alta o una modificación verifico que no ingrese una descripcion de seccion existente en el mismo deposito
                if (row.RowState.Equals(DataRowState.Added) || row.RowState.Equals(DataRowState.Modified))
                {
                    tlg_SeccionesDataset.tlg_SeccionesDataTable tableSD = GetByIdDepositoDescripcion(row.IdDeposito, row.Descripcion);
                    if (tableSD.Rows.Count > 0)
                    {
                        row.SetColumnError("Descripcion", "La sección " + row.Descripcion + " ya existe en este depósito.");
                        isValid = false;
                    }
                }
            }
            if (isValid)
            {
                Update(dataTable);
            }
        }
        //Fin Sabrina: Tarea 990. 20101214

		/// <summary>
		/// Envia los cambios del tlg_SeccionesDataset.tlg_SeccionesDataTable a la base de datos.
		/// </summary>
		public static void Update( tlg_SeccionesDataset.tlg_SeccionesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_Secciones.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tlg_SeccionesRow.
		/// </summary>
		public static bool RowIsValid( tlg_SeccionesDataset.tlg_SeccionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdSeccionIsValid( row.IdSeccion, out mensaje) )
			{ 
				row.SetColumnError( "IdSeccion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdDepositoIsValid( row.IdDeposito, out mensaje) )
			{ 
				row.SetColumnError( "IdDeposito" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
				isValid=false;
			
			}
						
			if ( !UbicacionIsValid( row.Ubicacion, out mensaje) )
			{ 
				row.SetColumnError( "Ubicacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !ComentarioIsValid( row.Comentario, out mensaje) )
			{ 
				row.SetColumnError( "Comentario" , mensaje);
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
						
			if ( !IdSucursalIsValid( row.IdSucursal, out mensaje) )
			{ 
				row.SetColumnError( "IdSucursal" , mensaje);
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
		/// Valida el campo IdSeccion.
		/// </summary>
		public static bool IdSeccionIsValid( string IdSeccion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdSeccion. Metodo Sobrecargado
		/// </summary>
		public static bool IdSeccionIsValid( string IdSeccion)
		{
			string mensaje;
			return IdSeccionIsValid( IdSeccion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdDeposito.
		/// </summary>
		public static bool IdDepositoIsValid( string IdDeposito , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdDeposito. Metodo Sobrecargado
		/// </summary>
		public static bool IdDepositoIsValid( string IdDeposito)
		{
			string mensaje;
			return IdDepositoIsValid( IdDeposito, out mensaje );
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
		/// Valida el campo Ubicacion.
		/// </summary>
		public static bool UbicacionIsValid( string Ubicacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Ubicacion. Metodo Sobrecargado
		/// </summary>
		public static bool UbicacionIsValid( string Ubicacion)
		{
			string mensaje;
			return UbicacionIsValid( Ubicacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Comentario.
		/// </summary>
		public static bool ComentarioIsValid( string Comentario , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Comentario. Metodo Sobrecargado
		/// </summary>
		public static bool ComentarioIsValid( string Comentario)
		{
			string mensaje;
			return ComentarioIsValid( Comentario, out mensaje );
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

