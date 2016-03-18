namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tfi_JerarquiaAgrupTDCompTesoreria : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tfi_JerarquiaAgrupTDCompTesoreria()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tfi_JerarquiaAgrupTDCompTesoreria
		/// </summary>
		public static tfi_JerarquiaAgrupTDCompTesoreriaDataset GetList()
		{
			return mz.erp.dataaccess.tfi_JerarquiaAgrupTDCompTesoreria.GetList();
		}
		//Pasarle parametro solo los de nivel 0
		//
		//Trae solo los NO AGRUPADOS
		public static DataTable GetListByNivel(long Nivel)
		{
			tfi_JerarquiaAgrupTDCompTesoreriaDataset data=mz.erp.dataaccess.tfi_JerarquiaAgrupTDCompTesoreria.GetList(null,  null,  Nivel, null, null,DateTime.MinValue, long.MinValue, null, long.MinValue, long.MinValue, Guid.Empty,long.MinValue, long.MinValue, null,false,null,null);
			return  data.Tables[0];
		}
		
		//Trae solo los NO AGRUPADOS
		public static DataTable GetListByNivelAndPadre(long Nivel,string IdPadre)
		{
			tfi_JerarquiaAgrupTDCompTesoreriaDataset data=mz.erp.dataaccess.tfi_JerarquiaAgrupTDCompTesoreria.GetList(null,  null,  Nivel, IdPadre, null,DateTime.MinValue, long.MinValue, null, long.MinValue, long.MinValue, Guid.Empty,long.MinValue, long.MinValue, null,false,null,null);
			return  data.Tables[0];
		}
		//Trae todos agrupados o no
		public static DataTable GetListTodosByNivelAndPadre(long Nivel,string IdPadre)
		{
			tfi_JerarquiaAgrupTDCompTesoreriaDataset data=mz.erp.dataaccess.tfi_JerarquiaAgrupTDCompTesoreria.GetList(null,  null,  Nivel, IdPadre, null,DateTime.MinValue, long.MinValue, null, long.MinValue, long.MinValue, Guid.Empty,long.MinValue, long.MinValue, null,null,null);
			return  data.Tables[0];
		}

//Trae todos agrupados o no
		public static DataTable GetListTodosByNivel(long Nivel)
		{
			tfi_JerarquiaAgrupTDCompTesoreriaDataset data=mz.erp.dataaccess.tfi_JerarquiaAgrupTDCompTesoreria.GetList(null,  null,  Nivel, null, null,DateTime.MinValue, long.MinValue, null, long.MinValue, long.MinValue, Guid.Empty,long.MinValue, long.MinValue, null,null,null);
			return  data.Tables[0];
		}
	
		/// <summary>
		/// Obtiene tabla tfi_JerarquiaAgrupTDCompTesoreria filtrada por las condiciones de bsqueda
		/// </summary>
		public static tfi_JerarquiaAgrupTDCompTesoreriaDataset GetList(string IdNomenclatura, string Descripcion, long Nivel, string IdPadre, string Jerarquia, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa, long IdSucursal, string OldIdNomenclatura, bool Agrupado,string ClaveCorta,string ClaveLarga)
		{
			return mz.erp.dataaccess.tfi_JerarquiaAgrupTDCompTesoreria.GetList( IdNomenclatura,  Descripcion,  Nivel,  IdPadre,  Jerarquia,  FechaCreacion,  IdConexionCreacion,UltimaModificacion,  IdConexionUltimaModificacion,  IdReservado,  RowId,  IdEmpresa,  IdSucursal,  OldIdNomenclatura,  Agrupado, ClaveCorta, ClaveLarga  );
		}

		/// <summary>
		/// Crea un tfi_JerarquiaAgrupTDCompTesoreriaRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tfi_JerarquiaAgrupTDCompTesoreriaDataset.tfi_JerarquiaAgrupTDCompTesoreriaRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_JerarquiaAgrupTDCompTesoreria.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_JerarquiaAgrupTDCompTesoreria que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tfi_JerarquiaAgrupTDCompTesoreriaDataset.tfi_JerarquiaAgrupTDCompTesoreriaRow GetByPk( string IdNomenclatura )
		{
			tfi_JerarquiaAgrupTDCompTesoreriaDataset.tfi_JerarquiaAgrupTDCompTesoreriaRow row = mz.erp.dataaccess.tfi_JerarquiaAgrupTDCompTesoreria.GetByPk( IdNomenclatura  );
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
		/// Obtiene un registro de la tabla tfi_JerarquiaAgrupTDCompTesoreria que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tfi_JerarquiaAgrupTDCompTesoreriaDataset.tfi_JerarquiaAgrupTDCompTesoreriaRow GetByPk( object IdNomenclatura )
		{
			return GetByPk( ( string )IdNomenclatura );
		}

		/// <summary>
		/// Establece los valores por defecto de tfi_JerarquiaAgrupTDCompTesoreriaRow.
		/// </summary>
		public static tfi_JerarquiaAgrupTDCompTesoreriaDataset.tfi_JerarquiaAgrupTDCompTesoreriaRow SetRowDefaultValues( tfi_JerarquiaAgrupTDCompTesoreriaDataset.tfi_JerarquiaAgrupTDCompTesoreriaRow row )
		{
			row.IdNomenclatura = Util.NewStringId(); 
			row.Descripcion = string.Empty;
			row.Nivel = 0;
			row.IdPadre = string.Empty;
			row.Jerarquia = string.Empty;
			row.Agrupado = false;
			row.ClaveCorta = string.Empty;
			row.ClaveLarga = string.Empty;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = 0;
			row.IdSucursal = 0;
			row.OldIdNomenclatura = string.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tfi_JerarquiaAgrupTDCompTesoreriaRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_JerarquiaAgrupTDCompTesoreriaDataset.tfi_JerarquiaAgrupTDCompTesoreriaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tfi_JerarquiaAgrupTDCompTesoreriaRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_JerarquiaAgrupTDCompTesoreriaDataset.tfi_JerarquiaAgrupTDCompTesoreriaRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_JerarquiaAgrupTDCompTesoreriaRow a la base de datos.
		/// </summary>
		public static void Update( tfi_JerarquiaAgrupTDCompTesoreriaDataset.tfi_JerarquiaAgrupTDCompTesoreriaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_JerarquiaAgrupTDCompTesoreria.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tfi_JerarquiaAgrupTDCompTesoreriaDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_JerarquiaAgrupTDCompTesoreriaDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_JerarquiaAgrupTDCompTesoreria.Rows.Count > 0, "La tabla dataSet.tfi_JerarquiaAgrupTDCompTesoreriaDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_JerarquiaAgrupTDCompTesoreria.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_JerarquiaAgrupTDCompTesoreriaDataset.tfi_JerarquiaAgrupTDCompTesoreriaDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_JerarquiaAgrupTDCompTesoreriaDataset.tfi_JerarquiaAgrupTDCompTesoreriaDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_JerarquiaAgrupTDCompTesoreria.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tfi_JerarquiaAgrupTDCompTesoreriaRow.
		/// </summary>
		public static bool RowIsValid( tfi_JerarquiaAgrupTDCompTesoreriaDataset.tfi_JerarquiaAgrupTDCompTesoreriaRow row )
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
						
			if ( !AgrupadoIsValid( row.Agrupado, out mensaje) )
			{ 
				row.SetColumnError( "Agrupado" , mensaje);
				isValid=false;
			
			}
						
			if ( !ClaveCortaIsValid( row.ClaveCorta, out mensaje) )
			{ 
				row.SetColumnError( "ClaveCorta" , mensaje);
				isValid=false;
			
			}
						
			if ( !ClaveLargaIsValid( row.ClaveLarga, out mensaje) )
			{ 
				row.SetColumnError( "ClaveLarga" , mensaje);
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
		/// Valida el campo Agrupado.
		/// </summary>
		public static bool AgrupadoIsValid( bool Agrupado , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Agrupado. Metodo Sobrecargado
		/// </summary>
		public static bool AgrupadoIsValid( bool Agrupado)
		{
			string mensaje;
			return AgrupadoIsValid( Agrupado, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo ClaveCorta.
		/// </summary>
		public static bool ClaveCortaIsValid( string ClaveCorta , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ClaveCorta. Metodo Sobrecargado
		/// </summary>
		public static bool ClaveCortaIsValid( string ClaveCorta)
		{
			string mensaje;
			return ClaveCortaIsValid( ClaveCorta, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo ClaveLarga.
		/// </summary>
		public static bool ClaveLargaIsValid( string ClaveLarga , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ClaveLarga. Metodo Sobrecargado
		/// </summary>
		public static bool ClaveLargaIsValid( string ClaveLarga)
		{
			string mensaje;
			return ClaveLargaIsValid( ClaveLarga, out mensaje );
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

