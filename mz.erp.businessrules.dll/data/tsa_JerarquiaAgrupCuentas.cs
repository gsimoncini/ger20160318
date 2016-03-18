namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_JerarquiaAgrupCuentas : IDisposable
	{
	
		#region Custom Members
		

		public static DataTable GetList(string IdPadre)
		{
			return mz.erp.dataaccess.tsa_JerarquiaAgrupCuentas.GetList(IdPadre).Tables[0];
		}

		public static DataTable GetNomenclaturas()
		{
			return mz.erp.dataaccess.tsa_JerarquiaAgrupCuentas.GetNomenclaturas().Tables[0];
		}

        //German 20120517 - Tarea 0000329
        public static DataTable GetNomenclaturasFiltrandoCampoAuxiliar6()
        {
            return mz.erp.dataaccess.tsa_JerarquiaAgrupCuentas.GetNomenclaturasFiltrandoCampoAuxiliar6().Tables[0];
        }
        //Fin German 20120517 - Tarea 0000329

		public static DataSet GetList(Char IdTipoProducto, bool Activo)
		{			
			return mz.erp.dataaccess.tsa_JerarquiaAgrupCuentas.GetList(IdTipoProducto);
		}

		public static commontypes.data.tsa_JerarquiaAgrupCuentasDataset GetList(string IdPadre, bool Activo)
		{
			return mz.erp.dataaccess.tsa_JerarquiaAgrupCuentas.GetList(IdPadre);
		}
        //Cristian Tarea 000069 20110907
        public static commontypes.data.tsa_JerarquiaAgrupCuentasDataset GetListActivas(string IdPadre, bool Activo)
        {
            return mz.erp.dataaccess.tsa_JerarquiaAgrupCuentas.GetList(IdPadre, Activo);
        }
        //Fin Cristian
		public static string GetPkByJerarquia(string Jerarquia)
		{
			return mz.erp.dataaccess.tsa_JerarquiaAgrupCuentas.GetPkByJerarquia(Jerarquia);
		}

        /* Silvina 20111104 - Tarea 0000222 */
        public static tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasRow GetPkByDescripcion(string Descripcion)
        {
            return mz.erp.dataaccess.tsa_JerarquiaAgrupCuentas.GetPkByDescripcion(Descripcion);
        }
        /* Fin Silvina 20111104 - Tarea 0000222 */
		
		#endregion
		
		public tsa_JerarquiaAgrupCuentas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_JerarquiaAgrupCuentas
		/// </summary>
		public static tsa_JerarquiaAgrupCuentasDataset GetList()
		{
			return mz.erp.dataaccess.tsa_JerarquiaAgrupCuentas.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsa_JerarquiaAgrupCuentas filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_JerarquiaAgrupCuentasDataset GetList( string IdNomenclatura, string Descripcion, long Nivel, string IdPadre, string Jerarquia, string IdTipoCuenta, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa, long IdSucursal, string OldIdNomenclatura )
		{
			return mz.erp.dataaccess.tsa_JerarquiaAgrupCuentas.GetList( IdNomenclatura, Descripcion, Nivel, IdPadre, Jerarquia, IdTipoCuenta, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa, IdSucursal, OldIdNomenclatura );
		}

		/// <summary>
		/// Crea un tsa_JerarquiaAgrupCuentasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsa_JerarquiaAgrupCuentas.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_JerarquiaAgrupCuentas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasRow GetByPk( string IdNomenclatura )
		{
			tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasRow row = mz.erp.dataaccess.tsa_JerarquiaAgrupCuentas.GetByPk( IdNomenclatura  );
			if (row!=null)
			{
				foreach ( DataColumn dc in row.Table.Columns ) 
				{
					if (row[dc] == System.DBNull.Value)
					{
						row[dc] = Util.DefaultValue( dc.DataType );
					}
				}
				return row;
			}
		return null;
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_JerarquiaAgrupCuentas que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasRow GetByPk( object IdNomenclatura )
		{
			return GetByPk( ( string )IdNomenclatura );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_JerarquiaAgrupCuentasRow.
		/// </summary>
		public static tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasRow SetRowDefaultValues( tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasRow row )
		{
			row.IdNomenclatura = Util.NewStringId(); 
			row.Descripcion = string.Empty;
			row.Nivel = 0;
			row.IdPadre = string.Empty;
			row.Jerarquia = string.Empty;
			row.IdTipoCuenta = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			row.OldIdNomenclatura = string.Empty;
			row.Activo = true;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsa_JerarquiaAgrupCuentasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsa_JerarquiaAgrupCuentasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_JerarquiaAgrupCuentasRow a la base de datos.
		/// </summary>
		public static void Update( tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_JerarquiaAgrupCuentas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_JerarquiaAgrupCuentasDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_JerarquiaAgrupCuentasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_JerarquiaAgrupCuentas.Rows.Count > 0, "La tabla dataSet.tsa_JerarquiaAgrupCuentasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_JerarquiaAgrupCuentas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_JerarquiaAgrupCuentas.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_JerarquiaAgrupCuentasRow.
		/// </summary>
		public static bool RowIsValid( tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdNomenclaturaIsValid( row.IdNomenclatura, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura" , mensaje);
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
						
			if ( !IdTipoCuentaIsValid( row.IdTipoCuenta, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoCuenta" , mensaje);
				isValid=false;
			
			}
            //Cristian Tarea 0000069 20110831
			/*
			if ( !FechaCreacionIsValid( row.FechaCreacion, out mensaje) )
			{ 
				row.SetColumnError( "FechaCreacion" , mensaje);
				isValid=false;
			
			}
             */
            //Cristian Tarea 0000069
						
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
						
			if ( !OldIdNomenclaturaIsValid( row.OldIdNomenclatura, out mensaje) )
			{ 
				row.SetColumnError( "OldIdNomenclatura" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura.
		/// </summary>
		public static bool IdNomenclaturaIsValid( string IdNomenclatura , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclaturaIsValid( string IdNomenclatura)
		{
			string mensaje;
			return IdNomenclaturaIsValid( IdNomenclatura, out mensaje );
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
		/// Valida el campo IdTipoCuenta.
		/// </summary>
		public static bool IdTipoCuentaIsValid( string IdTipoCuenta , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoCuenta. Metodo Sobrecargado
		/// </summary>
		public static bool IdTipoCuentaIsValid( string IdTipoCuenta)
		{
			string mensaje;
			return IdTipoCuentaIsValid( IdTipoCuenta, out mensaje );
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
		
		/// <summary>
		/// Valida el campo OldIdNomenclatura.
		/// </summary>
		public static bool OldIdNomenclaturaIsValid( string OldIdNomenclatura , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo OldIdNomenclatura. Metodo Sobrecargado
		/// </summary>
		public static bool OldIdNomenclaturaIsValid( string OldIdNomenclatura)
		{
			string mensaje;
			return OldIdNomenclaturaIsValid( OldIdNomenclatura, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}


