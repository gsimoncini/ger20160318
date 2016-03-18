namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using System.Collections;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tfi_ResponsablesCajas : IDisposable
	{
	
		#region Custom Members
		public static ArrayList GetCajas( string IdResponsable )
		{
			ArrayList _array = new ArrayList();
			tfi_ResponsablesCajasDataset _data = GetList( null , IdResponsable );
			foreach ( tfi_ResponsablesCajasDataset.tfi_ResponsablesCajasRow row in _data.tfi_ResponsablesCajas.Rows)
			{
				_array.Add( Convert.ToString(row["IdCaja"]) );
			}
			return _array;
		}
		#endregion
		
		public tfi_ResponsablesCajas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tfi_ResponsablesCajas
		/// </summary>
		public static tfi_ResponsablesCajasDataset GetList()
		{
			return mz.erp.dataaccess.tfi_ResponsablesCajas.GetList(null,null);
		}
		
		/// <summary>
		/// Obtiene tabla tfi_ResponsablesCajas filtrada por las condiciones de bsqueda
		/// </summary>
		public static tfi_ResponsablesCajasDataset GetList(string IdCaja, string IdResponsable  )
		{
			return mz.erp.dataaccess.tfi_ResponsablesCajas.GetList( IdCaja, IdResponsable  );
		}

		/// <summary>
		/// Crea un tfi_ResponsablesCajasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tfi_ResponsablesCajasDataset.tfi_ResponsablesCajasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_ResponsablesCajas.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_ResponsablesCajas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tfi_ResponsablesCajasDataset.tfi_ResponsablesCajasRow GetByPk( string IdCaja, string IdResponsable )
		{
			tfi_ResponsablesCajasDataset.tfi_ResponsablesCajasRow row = mz.erp.dataaccess.tfi_ResponsablesCajas.GetByPk( IdCaja, IdResponsable  );
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
		/// Obtiene un registro de la tabla tfi_ResponsablesCajas que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tfi_ResponsablesCajasDataset.tfi_ResponsablesCajasRow GetByPk( object IdCaja, object IdResponsable )
		{
			return GetByPk( ( string )IdCaja, ( string )IdResponsable );
		}

		/// <summary>
		/// Establece los valores por defecto de tfi_ResponsablesCajasRow.
		/// </summary>
		public static tfi_ResponsablesCajasDataset.tfi_ResponsablesCajasRow SetRowDefaultValues( tfi_ResponsablesCajasDataset.tfi_ResponsablesCajasRow row )
		{
			row.IdCaja = Util.NewStringId(); 
			row.IdResponsable = Util.NewStringId(); 
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
		/// Envia los cambios del tfi_ResponsablesCajasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_ResponsablesCajasDataset.tfi_ResponsablesCajasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tfi_ResponsablesCajasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_ResponsablesCajasDataset.tfi_ResponsablesCajasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_ResponsablesCajasRow a la base de datos.
		/// </summary>
		public static void Update( tfi_ResponsablesCajasDataset.tfi_ResponsablesCajasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_ResponsablesCajas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tfi_ResponsablesCajasDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_ResponsablesCajasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_ResponsablesCajas.Rows.Count > 0, "La tabla dataSet.tfi_ResponsablesCajasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_ResponsablesCajas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_ResponsablesCajasDataset.tfi_ResponsablesCajasDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_ResponsablesCajasDataset.tfi_ResponsablesCajasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			if(TableIsValid(dataTable))
			{

				string PerfilesSuperiores = mz.erp.businessrules.Variables.GetValueString("Seguridad.Perfiles.PerfilesSuperiores");
				string IdCajaTemporalDefault = mz.erp.businessrules.Variables.GetValueString("Cajas.CajaTemporalDefault");
				ArrayList PerfilesSuperioresList = mz.erp.systemframework.Util.Parse(PerfilesSuperiores);
				DataTable tableUsuariosSegunPerfiles = null;
				if(!PerfilesSuperioresList.Contains(mz.erp.businessrules.Security.IdPerfil.ToString()))
				{
					ArrayList CajasAAgregar = ObtenerCajasAAgregar(dataTable);
					tableUsuariosSegunPerfiles = mz.erp.businessrules.sy_Usuarios.GetUsuariosActivosSegunPerfiles(PerfilesSuperiores);
					foreach(DataRow rowU in tableUsuariosSegunPerfiles.Rows)
					{
							//Recupero las Cajas de la Base de datos para el usuario en cuestion
							ArrayList cajasUsuarioDB =  mz.erp.businessrules.tfi_ResponsablesCajas.GetCajas(Convert.ToString(rowU["IdUsuario"]));
							foreach(string IdCaja in CajasAAgregar)
							{
								//Sino contiene la caja en la base de datos
								if(!cajasUsuarioDB.Contains(IdCaja))
								{
									//Chequeo que ya no haya agregado la tupla en el dataset
									if(dataTable.FindByIdCajaIdResponsable(IdCaja, Convert.ToString(rowU["IdUsuario"])) == null)
									{
										tfi_ResponsablesCajasDataset.tfi_ResponsablesCajasRow rowRC = dataTable.Newtfi_ResponsablesCajasRow();
										mz.erp.businessrules.tfi_ResponsablesCajas.SetRowDefaultValues(rowRC);
										rowRC.IdResponsable = Convert.ToString(rowU["IdUsuario"]);
										rowRC.IdCaja = IdCaja;
										dataTable.Addtfi_ResponsablesCajasRow(rowRC);
									}
								}
							}
					}
				}
				mz.erp.dataaccess.tfi_ResponsablesCajas.Update( dataTable );
				//Elimina las filas del dataset asociadas a usuarios superiores siempre y cuando el que agrega no es un usuario superior
				ArrayList aux = new ArrayList();
				if(!PerfilesSuperioresList.Contains(mz.erp.businessrules.Security.IdPerfil.ToString()))
				{
					foreach(DataRow row in dataTable.Rows)
					{
						foreach(DataRow rowU in tableUsuariosSegunPerfiles.Rows)
						{
							if(Convert.ToString(rowU["IdUsuario"]).Equals(Convert.ToString(row["IdResponsable"])))
								aux.Add(row);
						}
					
					}
					foreach(DataRow rowAux in aux)
					{
						dataTable.Rows.Remove(rowAux);
					}
				}
			}

			
		}

		public static ArrayList ObtenerCajasAAgregar(tfi_ResponsablesCajasDataset.tfi_ResponsablesCajasDataTable dataTable)
		{
			
			ArrayList res = new ArrayList();
			foreach(DataRow row in dataTable.Rows)
			{
				if(row.RowState.Equals(DataRowState.Added))
					res.Add(Convert.ToString(row["IdCaja"]));
			}


			return res;
		}

		public static bool TableIsValid( tfi_ResponsablesCajasDataset.tfi_ResponsablesCajasDataTable dataTable )
		{
			/*
			foreach(DataRow row in dataTable.Rows)
			{
				if(row.RowState.Equals(DataRowState.Deleted))
				{
					string IdCaja = Convert.ToString(row["IdCaja", DataRowVersion.Original]);
					DataSet data = mz.erp.businessrules.tfi_InstanciasCaja.GetListByIdCaja(IdCaja);
					if(data.Tables[0].Rows.Count > 0)
					{
						row.SetColumnError( "IdCaja", "La Caja " + IdCaja + " no se puede eliminar porque ha sido usada");
						return false;
					}


				}
			}
			foreach(DataRow row in dataTable.Rows)
			{
				if(row.RowState.Equals(DataRowState.Modified))
				{
					string IdCaja = Convert.ToString(row["IdCaja", DataRowVersion.Original]);
					string IdCajaActual = Convert.ToString(row["IdCaja", DataRowVersion.Current]);
					if(!IdCaja.Equals(IdCajaActual))
					{
						row.SetColumnError( "IdCaja", "No se puede modificar el IdCaja. Elimine y Vuelva a crear la Caja");
						return false;
					}


				}
			}
			*/
			return true;
		}

		
		/// <summary>
		/// Valida un tfi_ResponsablesCajasRow.
		/// </summary>
		public static bool RowIsValid( tfi_ResponsablesCajasDataset.tfi_ResponsablesCajasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdCajaIsValid( row.IdCaja, out mensaje) )
			{ 
				row.SetColumnError( "IdCaja" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdResponsableIsValid( row.IdResponsable, out mensaje) )
			{ 
				row.SetColumnError( "IdResponsable" , mensaje);
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
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdCaja.
		/// </summary>
		public static bool IdCajaIsValid( string IdCaja , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCaja. Metodo Sobrecargado
		/// </summary>
		public static bool IdCajaIsValid( string IdCaja)
		{
			string mensaje;
			return IdCajaIsValid( IdCaja, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdResponsable.
		/// </summary>
		public static bool IdResponsableIsValid( string IdResponsable , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdResponsable. Metodo Sobrecargado
		/// </summary>
		public static bool IdResponsableIsValid( string IdResponsable)
		{
			string mensaje;
			return IdResponsableIsValid( IdResponsable, out mensaje );
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


