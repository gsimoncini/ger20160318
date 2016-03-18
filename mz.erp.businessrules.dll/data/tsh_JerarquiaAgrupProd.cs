namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsh_JerarquiaAgrupProd : IDisposable
	{
	
		#region Custom Members

//		public static tsh_JerarquiaAgrupProdDataset GetNomenclaturas()
//		{
//			return mz.erp.dataaccess.tsh_JerarquiaAgrupProd.GetNomenclaturas();
//		}

		public static DataTable GetNomenclaturas()
		{
			return mz.erp.dataaccess.tsh_JerarquiaAgrupProd.GetNomenclaturas().Tables[0];
		}

		public static string GetPkByJerarquia(string Jerarquia)
        {
			return mz.erp.dataaccess.tsh_JerarquiaAgrupProd.GetPkByJerarquia(Jerarquia);
		}

		public static tsh_JerarquiaAgrupProdDataset GetListByJerarquia(string Jerarquia)
		{
			return mz.erp.dataaccess.tsh_JerarquiaAgrupProd.GetListByJerarquia(Jerarquia);
		}

        //German 06/01/2012 - Tarea 0000248 
        //Cristian Tarea 000069
        public static tsh_JerarquiaAgrupProdDataset GetListByJerarquia(string Jerarquia, bool activo)
        {
            return mz.erp.dataaccess.tsh_JerarquiaAgrupProd.GetListByJerarquia(Jerarquia, activo);
        }
        //fin Cristian Tarea 00069
        //German 06/01/2012 - Tarea 0000248 

		public static tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdRow GetPkByDescripcion(string Descripcion)
		{
			return mz.erp.dataaccess.tsh_JerarquiaAgrupProd.GetPkByDescripcion(Descripcion);
		}

		public static string GetIdNomenclaturaByDescripcion(string Descripcion)
		{
			return mz.erp.dataaccess.tsh_JerarquiaAgrupProd.GetIdNomenclaturaByDescripcion(Descripcion);
		}
		public static string GetJerarquiaByIdNomenclatura(string IdNomenclatura)
		{
			return dataaccess.tsh_JerarquiaAgrupProd.GetJerarquiaByIdNomenclatura(IdNomenclatura);
		}
		#endregion
		
		public tsh_JerarquiaAgrupProd()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_JerarquiaAgrupProd
		/// </summary>
		
		public static tsh_JerarquiaAgrupProdDataset GetList(Char IdTipoProducto, bool Activo)
		{			
			return mz.erp.dataaccess.tsh_JerarquiaAgrupProd.GetList(IdTipoProducto, Activo);
		}

        //German 20120412 - Tarea 0000271
        public static tsh_JerarquiaAgrupProdDataset GetListFiltrandoCampoAuxiliar6(Char IdTipoProducto, bool Activo)
        {
            return mz.erp.dataaccess.tsh_JerarquiaAgrupProd.GetListFiltrandoCampoAuxiliar6(IdTipoProducto, Activo);
        }

        //Fin German 20120412 - Tarea 0000271

		public static DataTable GetListGeneric(Char IdTipoProducto, bool Activo)
		{			
			return mz.erp.dataaccess.tsh_JerarquiaAgrupProd.GetList(IdTipoProducto, Activo).Tables[0];;
		}


		public static tsh_JerarquiaAgrupProdDataset GetList(string IdPadre, bool Activo)
		{
			return mz.erp.dataaccess.tsh_JerarquiaAgrupProd.GetList(IdPadre, Activo);
		}

		public static DataTable GetList(string IdPadre)
		{
			return mz.erp.dataaccess.tsh_JerarquiaAgrupProd.GetList(IdPadre, true).Tables[0];
		}

		public static tsh_JerarquiaAgrupProdDataset GetList()
		{
			return mz.erp.dataaccess.tsh_JerarquiaAgrupProd.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsh_JerarquiaAgrupProd filtrada por las condiciones de bsqueda
		/// </summary>
		/*public static tsh_JerarquiaAgrupProdDataset GetList(  )
		{
			return mz.erp.dataaccess.tsh_JerarquiaAgrupProd.GetList(  );
		}*/

		/// <summary>
		/// Crea un tsh_JerarquiaAgrupProdRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ] 
		public static tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsh_JerarquiaAgrupProd.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_JerarquiaAgrupProd que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdRow GetByPk( string IdNomenclatura )
		{
			tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdRow row = mz.erp.dataaccess.tsh_JerarquiaAgrupProd.GetByPk( IdNomenclatura  );
			if (row != null) 
			{
				foreach ( DataColumn dc in row.Table.Columns ) 
				{
					if (!dc.Caption.Equals("RowID"))
						if (row[dc] == System.DBNull.Value)
						{
							row[dc] = Util.DefaultValue( dc.DataType );
						}
				}
			}
			return row;
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_JerarquiaAgrupProd que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdRow GetByPk( object IdNomenclatura )
		{
			return GetByPk( ( string )IdNomenclatura );
		}



		#region delete
		[ atMethodDeleteRow]
		public static void Delete(tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdRow row)
		//public static void Delete(tsh_PersonasDataset.tsh_PersonasRow row)
		{
			
			row.Delete();
			Update(row);
			if	(row.Table.HasErrors)
			{
				row.RejectChanges();
				row["Activo"] = false;
				Update(row);
				if (row.Table.HasErrors)
				{
					row.SetColumnError("IdNomenclatura","No se ha podido eliminar el item");
				}
				else
				{
					row.SetColumnError("IdNomenclatura","No se ha podido eliminar el item porque existen tablas relacionadas. Se ha procede a desactivar");
				}
			}

		}
		#endregion


		/// <summary>
		/// Establece los valores por defecto de tsh_JerarquiaAgrupProdRow.
		/// </summary>
		public static tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdRow SetRowDefaultValues( tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdRow row )
		{
			row.IdNomenclatura = Util.NewStringId(); 
			row.Descripcion = string.Empty;
			row.Nivel = 0;
			row.IdPadre = string.Empty;
			row.Jerarquia = string.Empty;
			row.IdTipoProducto = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;			
			row.IdConexionCreacion = Security.IdConexion;
			row.Activo = true;	
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			row.SetIdGeneradoNull();
			row.SetRowIdGeneradoNull();
            /* Silvina 20120420 - Tarea 0000294 */
            row.Comision = 0;
            /* Fin Silvina 20120420 - Tarea 0000294 */
			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsh_JerarquiaAgrupProdRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsh_JerarquiaAgrupProdRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_JerarquiaAgrupProdRow a la base de datos.
		/// </summary>
		public static void Update( tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			
			SentenciasReplicacion replication = new SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tsh_JerarquiaAgrupProd";
			mz.erp.dataaccess.tsh_JerarquiaAgrupProd.Replicacion = replication;	

			mz.erp.dataaccess.tsh_JerarquiaAgrupProd.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsh_JerarquiaAgrupProdDataset a la base de datos.
		/// </summary>
		public static void Update( tsh_JerarquiaAgrupProdDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_JerarquiaAgrupProd.Rows.Count > 0, "La tabla dataSet.tsh_JerarquiaAgrupProdDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			SentenciasReplicacion replication = new SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tsh_JerarquiaAgrupProd";
			mz.erp.dataaccess.tsh_JerarquiaAgrupProd.Replicacion = replication;	
			
			mz.erp.dataaccess.tsh_JerarquiaAgrupProd.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdDataTable a la base de datos.
		/// </summary>
		public static void Update( tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			SentenciasReplicacion replication = new SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tsh_JerarquiaAgrupProd";
			mz.erp.dataaccess.tsh_JerarquiaAgrupProd.Replicacion = replication;	
			
			mz.erp.dataaccess.tsh_JerarquiaAgrupProd.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsh_JerarquiaAgrupProdRow.
		/// </summary>
		public static bool RowIsValid( tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdRow row )
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
						
			if ( !IdTipoProductoIsValid( row.IdTipoProducto, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoProducto" , mensaje);
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
						
			/*if ( !UltimaModificacionIsValid( row.UltimaModificacion, out mensaje) )
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
			if (IdPadre == String.Empty) 
			{
				IdPadre = "";
			}
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
		/// Valida el campo IdTipoProducto.
		/// </summary>
		public static bool IdTipoProductoIsValid( string IdTipoProducto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoProducto. Metodo Sobrecargado
		/// </summary>
		public static bool IdTipoProductoIsValid( string IdTipoProducto)
		{
			string mensaje;
			return IdTipoProductoIsValid( IdTipoProducto, out mensaje );
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

