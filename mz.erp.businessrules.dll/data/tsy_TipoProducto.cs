namespace mz.erp.businessrules 
{
	using System;
	using System.Collections;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsy_TipoProducto : IDisposable
	{
	
		#region Custom Members
		public static tsy_TipoProductoDataset GetListByActivo( bool Activo )
		{
			return dataaccess.tsy_TipoProducto.GetListByActivo(Activo);
		}
		public static ArrayList GetListArray()
		{
			mz.erp.commontypes.data.tsy_TipoProductoDataset _data = GetList();
			ArrayList array = new ArrayList();
			foreach ( System.Data.DataRow _row in _data.tsy_TipoProducto.Rows )
			{
				array.Add(_row.ItemArray );
			}
			return array;
		}
		public static bool AfectaStock(string IdTipoProducto)
		{
			tsy_TipoProductoDataset.tsy_TipoProductoRow row = GetByPk( IdTipoProducto );
			if (row != null)
				return Convert.ToBoolean( row.AfectaStock );
			return false;
		}

		
		#endregion
		
		public tsy_TipoProducto()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsy_TipoProducto
		/// </summary>
		public static tsy_TipoProductoDataset GetList()
		{
			return mz.erp.dataaccess.tsy_TipoProducto.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsy_TipoProducto filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsy_TipoProductoDataset GetList( string IdTipoProducto, string Descripcion, long IdEmpresa, bool Activo )
		{
			return mz.erp.dataaccess.tsy_TipoProducto.GetList( IdTipoProducto, Descripcion, IdEmpresa, Activo );
		}

		/// <summary>
		/// Crea un tsy_TipoProductoRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsy_TipoProductoDataset.tsy_TipoProductoRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsy_TipoProducto.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsy_TipoProducto que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsy_TipoProductoDataset.tsy_TipoProductoRow GetByPk( string IdTipoProducto )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tsy_TipoProducto.GetByPk( IdTipoProducto ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tsy_TipoProductoRow.
		/// </summary>
		public static tsy_TipoProductoDataset.tsy_TipoProductoRow SetRowDefaultValues( tsy_TipoProductoDataset.tsy_TipoProductoRow row )
		{
			row.IdTipoProducto = Util.NewStringId(); 
			row.Descripcion = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
		//	row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.AfectaStock = false;
			row.Activo = true;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsy_TipoProductoRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsy_TipoProductoDataset.tsy_TipoProductoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsy_TipoProductoRow a la base de datos.
		/// </summary>
		public static void Update( tsy_TipoProductoDataset.tsy_TipoProductoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_TipoProducto.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsy_TipoProductoDataset a la base de datos.
		/// </summary>
		public static void Update( tsy_TipoProductoDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsy_TipoProducto.Rows.Count > 0, "La tabla dataSet.tsy_TipoProductoDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_TipoProducto.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_TipoProductoDataset.tsy_TipoProductoDataTable a la base de datos.
		/// </summary>
		public static void Update( tsy_TipoProductoDataset.tsy_TipoProductoDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			if(TableIsValid(dataTable))
			{

				mz.erp.dataaccess.tsy_TipoProducto.Update( dataTable );
			}
		}
		
		public static bool TableIsValid( tsy_TipoProductoDataset.tsy_TipoProductoDataTable dataTable )
		{
			
			foreach(DataRow row in dataTable.Rows)
			{
				if(row.RowState.Equals(DataRowState.Added))
				{
					string tipo = Convert.ToString(row["Descripcion"]);
					if(tipo.Trim().Equals(string.Empty))
					{
						row.SetColumnError( "Descripcion", "La Descripción del Tipo de producto no puede ser vacía");
						return false;
					}


				}
				else if(row.RowState.Equals(DataRowState.Deleted))
				{
					bool ok = true;
					string IdTipoProducto = Convert.ToString(row["IdTipoProducto", DataRowVersion.Original]);
					DataSet data = mz.erp.businessrules.tsh_Productos.GetListByIdTipoProducto(IdTipoProducto);
					if(data.Tables[0].Rows.Count > 0)
					{
						row.SetColumnError( "IdTipoProducto", "El tipo de producto " + IdTipoProducto + " no se puede eliminar porque esta siendo utilizado por un producto");
						ok = false;
					}

					DataTable tableVars = sy_VariablesEx.GetListByCola("TipoDeProducto");
					if(tableVars.Rows.Count > 0)
					{
						foreach(DataRow rowV in tableVars.Rows)
						{
							string valor = Convert.ToString(rowV["ValorDefault"]);
							if(valor.Equals(IdTipoProducto))
							{
								string IdVariable = Convert.ToString(rowV["IdVariable"]);
								string error = row.GetColumnError("IdTipoProducto");
								if(!error.Equals(string.Empty))
									row.SetColumnError( "IdTipoProducto", error + " y por la variable " + IdVariable);
								else
                                    row.SetColumnError( "IdTipoProducto", "El tipo de producto " + IdTipoProducto + " no se puede eliminar porque esta siendo utilizado por la variable " + IdVariable);
								ok = false;
							}
						}
					}

					return ok;

				}
				else if(row.RowState.Equals(DataRowState.Modified))
				{
					bool ok = true;
					string IdTipoProducto = Convert.ToString(row["IdTipoProducto", DataRowVersion.Original]);
					string IdTipoProductoActual = Convert.ToString(row["IdTipoProducto", DataRowVersion.Current]);
					if(!IdTipoProducto.Equals(IdTipoProductoActual))
					{
						row.SetColumnError( "IdTipoProducto", "No se puede modificar el IdTipoProducto. Elimine y Vuelva a crear el tipo de producto");
						ok = false;
					}
					bool Activo = Convert.ToBoolean(row["Activo", DataRowVersion.Current]);
					if(!Activo) //Si desactivo un tipo me fijo q no lo este usando un producto
					{
						DataSet data = mz.erp.businessrules.tsh_Productos.GetListByIdTipoProducto(IdTipoProducto);
						if(data.Tables[0].Rows.Count > 0)
						{
							row.SetColumnError( "Activo", "El tipo de producto " + IdTipoProducto + " no se puede desactivar porque esta siendo utilizado por un producto");
							ok = false;
						}

						DataTable tableVars = sy_VariablesEx.GetListByCola("TipoDeProducto");
						if(tableVars.Rows.Count > 0)
						{
							foreach(DataRow rowV in tableVars.Rows)
							{
								string valor = Convert.ToString(rowV["ValorDefault"]);
								if(valor.Equals(IdTipoProducto))
								{
									string IdVariable = Convert.ToString(rowV["IdVariable"]);
									string error = row.GetColumnError("Activo");
									if(!error.Equals(string.Empty))
										row.SetColumnError( "Activo", error + " y por la variable " + IdVariable);
									else
										row.SetColumnError( "Activo", "El tipo de producto " + IdTipoProducto + " no se puede desactivar porque esta siendo utilizado por la variable " + IdVariable);
									ok = false;
								}
							}
						}

					}

					string tipo = Convert.ToString(row["Descripcion"]);
					if(tipo.Trim().Equals(string.Empty))
					{
						row.SetColumnError( "Descripcion", "La Descripción del Tipo de producto no puede ser vacía");
						ok = false;
					}

					return ok;


				}
			}

			return true;
		}


		/// <summary>
		/// Valida un tsy_TipoProductoRow.
		/// </summary>
		public static bool RowIsValid( tsy_TipoProductoDataset.tsy_TipoProductoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdTipoProductoIsValid( row.IdTipoProducto ) )
			{ 
				return false;
			}
						
			if ( !DescripcionIsValid( row.Descripcion ) )
			{ 
				return false;
			}
						
			/*if ( !FechaCreacionIsValid( row.FechaCreacion ) )
			{ 
				return false;
			}
						
			if ( !IdConexionCreacionIsValid( row.IdConexionCreacion ) )
			{ 
				return false;
			}
						
			if ( !UltimaModificacionIsValid( row.UltimaModificacion ) )
			{ 
				return false;
			}
						
			if ( !IdConexionUltimaModificacionIsValid( row.IdConexionUltimaModificacion ) )
			{ 
				return false;
			}
						
			if ( !IdReservadoIsValid( row.IdReservado ) )
			{ 
				return false;
			}
						
			if ( !RowIdIsValid( row.RowId ) )
			{ 
				return false;
			}
						
			if ( !IdEmpresaIsValid( row.IdEmpresa ) )
			{ 
				return false;
			}*/
			;
			
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoProducto.
		/// </summary>
		public static bool IdTipoProductoIsValid( string IdTipoProducto )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Descripcion.
		/// </summary>
		public static bool DescripcionIsValid( string Descripcion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaCreacion.
		/// </summary>
		public static bool FechaCreacionIsValid( DateTime FechaCreacion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConexionCreacion.
		/// </summary>
		public static bool IdConexionCreacionIsValid( long IdConexionCreacion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo UltimaModificacion.
		/// </summary>
		public static bool UltimaModificacionIsValid( byte[] UltimaModificacion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConexionUltimaModificacion.
		/// </summary>
		public static bool IdConexionUltimaModificacionIsValid( long IdConexionUltimaModificacion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdReservado.
		/// </summary>
		public static bool IdReservadoIsValid( long IdReservado )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo RowId.
		/// </summary>
		public static bool RowIdIsValid( Guid RowId )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEmpresa.
		/// </summary>
		public static bool IdEmpresaIsValid( long IdEmpresa )
		{
			//Agregar cdigo de validacin
			return true;
		}
		

		public void Dispose()
		{
		}
		
	}
}

