namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Data.SqlClient;
	using System.Collections;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;
	using mz.erp.businessrules.comprobantes;
		
	public class tfi_TDCompTesoreria : IDisposable
	{

		
	
		#region Custom Members
		
		static mz.erp.commontypes.data.sy_VariablesDataset _dataVariables;
		static mz.erp.commontypes.data.sy_VariablesPerfilesDataset _dataVariablesPerfiles;
		static mz.erp.commontypes.data.sy_VariablesDataset _dataVariablesABorrar;
		static mz.erp.commontypes.data.sy_VariablesPerfilesDataset _dataVariablesPerfilesABorrar;
		static mz.erp.commontypes.data.tfi_TDCompTesoreria_EntidadesDataset _dataCompEntidades;
		static mz.erp.commontypes.data.tui_ConfiguracionFormasDePagoDataset _dataConfiguracionFDP;
		static tfi_TDCompTesoreria_CondicionesDeVentaDataset _dataTDCompTesoreria_CondicionesDeVentas;
		static tfi_TDCompTesoreriasMonedasRecargosDataset _dataTDCompTesoreria_Monedas_Recargos;
		static tsa_CuentasCondicionesDeVenta_TDCompTesoreriaDataset _dataCuentas_CondicionesDeVentas_TDCompTesoreria;
		static Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset _dataTiposDeComprobantes_CondicionesDeVentas_TDCompTesoreria;
		//static mz.erp.commontypes.data.tfi_AgrupTDCompTesoreriaDataset _dataConfiguracionFDP;
		static mz.erp.commontypes.data.tfi_AgrupTDCompTesoreriaDataset _dataAgrupamientoTDCompTesoreria;
		static string _state = "NEW";

		static string _tipo = string.Empty;

		public static tfi_TDCompTesoreriaDataset GetListByDescripcion( string Descripcion )
		{
			return mz.erp.dataaccess.tfi_TDCompTesoreria.GetListByDescripcion(Descripcion);
		}

		public static string State
		{
			set{_state = value;}
		}

		public static Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset DataTiposDeComprobantes_CondicionesDeVentas_TDCompTesoreria
		{
			set{ _dataTiposDeComprobantes_CondicionesDeVentas_TDCompTesoreria = value;}
		}
		
		public static tsa_CuentasCondicionesDeVenta_TDCompTesoreriaDataset DataCuentas_CondicionesDeVentas_TDCompTesoreria
		{
			set{ _dataCuentas_CondicionesDeVentas_TDCompTesoreria = value;}
		}

		public static tfi_TDCompTesoreriasMonedasRecargosDataset DataTDCompTesoreria_Monedas_Recargos
		{
			set{ _dataTDCompTesoreria_Monedas_Recargos = value;}
		}


		public static tfi_TDCompTesoreria_CondicionesDeVentaDataset DataTDCompTesoreria_CondicionesDeVentas
		{
			set{ _dataTDCompTesoreria_CondicionesDeVentas = value;}
		}

		public static mz.erp.commontypes.data.tui_ConfiguracionFormasDePagoDataset DataConfiguracionFDP
		{
			set{ _dataConfiguracionFDP = value;}
		}
		public static mz.erp.commontypes.data.tfi_AgrupTDCompTesoreriaDataset DataAgrupamientoTDCompTesoreria
		{
			set{ _dataAgrupamientoTDCompTesoreria = value;}
		}
		
		public static mz.erp.commontypes.data.sy_VariablesDataset DataVariables
		{
			set{_dataVariables = value;}
		}
		public static mz.erp.commontypes.data.sy_VariablesPerfilesDataset DataVariablesPerfiles
		{
			set{_dataVariablesPerfiles = value;}
		}

		public static mz.erp.commontypes.data.sy_VariablesDataset DataVariablesABorrar
		{
			set{_dataVariablesABorrar = value;}
		}
		public static mz.erp.commontypes.data.sy_VariablesPerfilesDataset DataVariablesPerfilesABorrar
		{
			set{_dataVariablesPerfilesABorrar = value;}
		}

		public static mz.erp.commontypes.data.tfi_TDCompTesoreria_EntidadesDataset DataCompEntidades
		{
			set{_dataCompEntidades = value;}
		}
		public static string Tipo
		{
			set{_tipo = value;}
		}

		
		#endregion
		
		public tfi_TDCompTesoreria()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tfi_TDCompTesoreria
		/// </summary>
		public static tfi_TDCompTesoreriaDataset GetList()
		{
			return mz.erp.dataaccess.tfi_TDCompTesoreria.GetList();
		}

		/// <summary>
		/// Retorna la lista completa de la tabla tfi_TDCompTesoreria  en forma de Array
		/// </summary>
		
		public static FormasDePagos GetFormasDePago()
		{
			FormasDePagos result = new FormasDePagos();
			DataTable table = mz.erp.dataaccess.tfi_TDCompTesoreria.GetListActivas().Tables[0];
			
			foreach(tfi_TDCompTesoreriaDataset.tfi_TDCompTesoreriaRow row in table.Rows)
			{
				//string IdTipoDeComprobante = Convert.ToString(row["IdTipoDeComprobante"]);
				string Descripcion = Convert.ToString(row["Descripcion"]);
				FormaDePago fp = new FormaDePago();
				fp.Descripcion = Descripcion;
				string IdTDCompTesoreria = Convert.ToString(row["IdTDCompTesoreria"]);
				fp.IdFormaDePago = IdTDCompTesoreria;
				result.Add(fp);
			}

			result.Sort();
			return result;
		}

		public static DataSet GetListEx()
		{
			return mz.erp.dataaccess.tfi_TDCompTesoreria.GetListEx();
		}
		
		public static System.Data.DataSet GetList(string ListaTiposDeComp)
		{
			return (System.Data.DataSet) mz.erp.dataaccess.tfi_TDCompTesoreria.GetList(ListaTiposDeComp);
		}
		
		/// <summary>
		/// Obtiene tabla tfi_TDCompTesoreria filtrada por las condiciones de bsqueda
		/// </summary>
		public static tfi_TDCompTesoreriaDataset GetListDescripcion( string Descripcion, bool Activo )
		{
			string IdMoneda = Variables.GetValueString("Contabilidad.MonedaReferencia");
			return mz.erp.dataaccess.tfi_TDCompTesoreria.GetListDescripcion( Descripcion , IdMoneda, Activo);
		}

		public static DataTable GetListByJerarquia( string jerarquia)
		{
			//string IdMoneda = Variables.GetValueString("Contabilidad.MonedaReferencia");
			DataSet data= mz.erp.dataaccess.tfi_TDCompTesoreria.GetListExJerarquia( string.Empty, string.Empty, false, false, DateTime.MinValue, long.MinValue, null, long.MinValue, long.MinValue, Guid.Empty, long.MinValue, long.MinValue, string.Empty, short.MinValue,jerarquia);
			return data.Tables[0];
	
			
		}


		public static DataSet GetList( string IdTDCompTesoreria, string Descripcion, bool Sistema, bool Agrupado, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa, long IdSucursal, short cuotas)
		{
			string IdMoneda = Variables.GetValueString("Contabilidad.MonedaReferencia");
			return mz.erp.dataaccess.tfi_TDCompTesoreria.GetList( IdTDCompTesoreria, Descripcion, Sistema, Agrupado, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa, IdSucursal, IdMoneda, cuotas);
		}

	/*	public static DataSet GetListEx( string IdTDCompTesoreria, string Descripcion, bool Sistema, bool Agrupado, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa, long IdSucursal, short cuotas)
		{
			string IdMoneda = Variables.GetValueString("Contabilidad.MonedaReferencia");
			return mz.erp.dataaccess.tfi_TDCompTesoreria.GetListExJerarquia( IdTDCompTesoreria, Descripcion, Sistema, Agrupado, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa, IdSucursal, IdMoneda, cuotas);
		}*/
		/// <summary>
		/// Crea un tfi_TDCompTesoreriaRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tfi_TDCompTesoreriaDataset.tfi_TDCompTesoreriaRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_TDCompTesoreria.NewRow());
		}
		/// <summary>
		/// Obtiene un registro de la tabla tfi_TDCompTesoreria que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tfi_TDCompTesoreriaDataset.tfi_TDCompTesoreriaRow GetByPk( string IdTDCompTesoreria )
		{
			tfi_TDCompTesoreriaDataset.tfi_TDCompTesoreriaRow row = mz.erp.dataaccess.tfi_TDCompTesoreria.GetByPk( IdTDCompTesoreria  );
			if (row != null)
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
		/// Obtiene un registro de la tabla tfi_TDCompTesoreria que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tfi_TDCompTesoreriaDataset.tfi_TDCompTesoreriaRow GetByPk( object IdTDCompTesoreria )
		{
			return GetByPk( ( string )IdTDCompTesoreria );
		}

		/// <summary>
		/// Establece los valores por defecto de tfi_TDCompTesoreriaRow.
		/// </summary>
		public static tfi_TDCompTesoreriaDataset.tfi_TDCompTesoreriaRow SetRowDefaultValues( tfi_TDCompTesoreriaDataset.tfi_TDCompTesoreriaRow row )
		{
			row.IdTDCompTesoreria = Util.NewStringId(); 
			row.Descripcion = string.Empty;
			row.Sistema = false;
			row.Agrupado = false;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			row.Cuotas=1;
			row.Activo = true;
			return row;
		}

		
		/// <summary>
		/// Envia los cambios del tfi_TDCompTesoreriaRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_TDCompTesoreriaDataset.tfi_TDCompTesoreriaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( IsValid( row ) )
			{
				SqlConnection cnx = dbhelper.Connection.GetConnection();;
				cnx.Open();

				SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

				try
				{
					string IdTDCompTesoreria = string.Empty;
					Update( row , trx);
					IdTDCompTesoreria = Convert.ToString(row.IdTDCompTesoreria);

					// se actualizan la variables terminadas en ',', apra que se agregue el ID recientemente insertado
					if(_state.ToUpper().Equals("NEW"))
					{
						foreach ( sy_VariablesDataset.sy_VariablesRow rowV in _dataVariables.sy_Variables.Rows) 
						{
							string str = Convert.ToString(rowV["ValorDefault"]);
							int x = str.LastIndexOf(',');
							if ( str.Length != 0  && (x+1 == str.Length))
								rowV["ValorDefault"]= str + Convert.ToString(row["IdTDCompTesoreria"]);
						}
					}
					
					if(_dataCompEntidades != null)
					{
						foreach ( tfi_TDCompTesoreria_EntidadesDataset.tfi_TDCompTesoreria_EntidadesRow rowE in _dataCompEntidades.tfi_TDCompTesoreria_Entidades.Rows) 
						{
							//actualizo el id del comp tesoreria
							rowE["TDCompTesoreria"]= row["idTDCompTesoreria"];
						}
					}
					if(_dataTDCompTesoreria_CondicionesDeVentas != null)
					{
						foreach(tfi_TDCompTesoreria_CondicionesDeVentaDataset.tfi_TDCompTesoreria_CondicionesDeVentaRow row_TDCT_CV in _dataTDCompTesoreria_CondicionesDeVentas.tfi_TDCompTesoreria_CondicionesDeVenta.Rows)
						{
							row_TDCT_CV.idTDCompTesoreria = IdTDCompTesoreria;
						}
					}

					if(_dataTDCompTesoreria_Monedas_Recargos != null)
					{
						foreach(tfi_TDCompTesoreriasMonedasRecargosDataset.tfi_TDCompTesoreriasMonedasRecargosRow row_TDCT_M_R in _dataTDCompTesoreria_Monedas_Recargos.tfi_TDCompTesoreriasMonedasRecargos.Rows)
						{
							row_TDCT_M_R.IdTDCompTesoreria = IdTDCompTesoreria;
						}
					}
					if(_dataCuentas_CondicionesDeVentas_TDCompTesoreria != null)
					{
						foreach(tsa_CuentasCondicionesDeVenta_TDCompTesoreriaDataset.tsa_CuentasCondicionesDeVenta_TDCompTesoreriaRow row_C_CV_TDCT in _dataCuentas_CondicionesDeVentas_TDCompTesoreria.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.Rows)
						{
							row_C_CV_TDCT.idTDCompTesoreria = IdTDCompTesoreria;
						}
					}

					if(_dataTiposDeComprobantes_CondicionesDeVentas_TDCompTesoreria != null)
					{
						foreach(Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow row_TC_CV_TDCT in _dataTiposDeComprobantes_CondicionesDeVentas_TDCompTesoreria.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.Rows)
						{
							row_TC_CV_TDCT.IdTDCompTesoreria = IdTDCompTesoreria;
						}
					}

					if(_dataConfiguracionFDP != null)
					{
						if(_dataConfiguracionFDP.tui_ConfiguracionFormasDePago.Rows.Count > 0)
							_dataConfiguracionFDP.tui_ConfiguracionFormasDePago.Rows[0]["IdTDCompTesoreria"] = Convert.ToString(row["IdTDCompTesoreria"]);
					}
					if(_dataAgrupamientoTDCompTesoreria!=null)
						if(_dataAgrupamientoTDCompTesoreria.tfi_AgrupTDCompTesoreria.Rows.Count>0)
							_dataAgrupamientoTDCompTesoreria.tfi_AgrupTDCompTesoreria.Rows[0]["IdTDCompTesoreria"]=Convert.ToString(row["IdTDCompTesoreria"]);
					mz.erp.dataaccess.sy_Variables.Update(_dataVariables.sy_Variables, trx);
					mz.erp.dataaccess.sy_VariablesPerfiles.Update(_dataVariablesPerfiles.sy_VariablesPerfiles , trx);	
					//mz.erp.dataaccess.sy_Variables.Update(_dataVariablesABorrar.sy_Variables, trx);
					//mz.erp.dataaccess.sy_VariablesPerfiles.Update(_dataVariablesPerfilesABorrar.sy_VariablesPerfiles , trx);	
					mz.erp.dataaccess.tfi_TDCompTesoreria_Entidades.Update(_dataCompEntidades.tfi_TDCompTesoreria_Entidades ,trx);
					mz.erp.dataaccess.tui_ConfiguracionFormasDePago.Update(_dataConfiguracionFDP.tui_ConfiguracionFormasDePago, trx);
					if(_dataAgrupamientoTDCompTesoreria != null)
						if(_state.Equals("NEW"))
							mz.erp.dataaccess.tfi_AgrupTDCompTesoreria.Update(_dataAgrupamientoTDCompTesoreria.tfi_AgrupTDCompTesoreria,trx);
					if(_dataTDCompTesoreria_CondicionesDeVentas != null)
						mz.erp.dataaccess.tfi_TDCompTesoreria_CondicionesDeVenta.Update(_dataTDCompTesoreria_CondicionesDeVentas.tfi_TDCompTesoreria_CondicionesDeVenta,trx);
					mz.erp.dataaccess.tfi_TDCompTesoreriasMonedasRecargos.Update(_dataTDCompTesoreria_Monedas_Recargos.tfi_TDCompTesoreriasMonedasRecargos, trx);
					if(_dataCuentas_CondicionesDeVentas_TDCompTesoreria != null)
						mz.erp.dataaccess.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.Update(_dataCuentas_CondicionesDeVentas_TDCompTesoreria.tsa_CuentasCondicionesDeVenta_TDCompTesoreria, trx);
					if(_dataTiposDeComprobantes_CondicionesDeVentas_TDCompTesoreria != null)
						mz.erp.dataaccess.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.Update(_dataTiposDeComprobantes_CondicionesDeVentas_TDCompTesoreria.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria, trx);
					Variables.Reset(); //reinicia las variables;
					MAPStaticInfo.Reset();
					trx.Commit();
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message.ToString());
					trx.Rollback();
				}
				finally
				{
					cnx.Close();
				}	
			}
		}
		
		/// <summary>
		/// Envia los cambios del tfi_TDCompTesoreriaRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		/// ver que hacer con esto
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_TDCompTesoreriaDataset.tfi_TDCompTesoreriaRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_TDCompTesoreriaRow a la base de datos.
		/// </summary>
		public static void Update( tfi_TDCompTesoreriaDataset.tfi_TDCompTesoreriaRow row , SqlTransaction trx)
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_TDCompTesoreria.Update( row , trx);
		}

		/// <summary>
		/// Envia los cambios del tfi_TDCompTesoreriaDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_TDCompTesoreriaDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_TDCompTesoreria.Rows.Count > 0, "La tabla dataSet.tfi_TDCompTesoreriaDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_TDCompTesoreria.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_TDCompTesoreriaDataset.tfi_TDCompTesoreriaDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_TDCompTesoreriaDataset.tfi_TDCompTesoreriaDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_TDCompTesoreria.Update( dataTable );
		}


		public static bool IsValid(tfi_TDCompTesoreriaDataset.tfi_TDCompTesoreriaRow row)
		{
			bool ok = true;
			ok = ok && RowIsValid(row)&& IsValidDescripcion(row)&& IsValidActivo(row);
			if(ok)
				ok = ok && ValidarCompleto(row);
					return ok; 
		}


		private static bool IsValidActivo(tfi_TDCompTesoreriaDataset.tfi_TDCompTesoreriaRow row)
		{
			bool Activo = Convert.ToBoolean(row["Activo"]);
			string IdTDCompTesoreria = Convert.ToString(row["IdTDCompTesoreria"]);
			if(Activo) return true;
			DataSet data = mz.erp.businessrules.tsa_CondicionesDeVentas.GetCondicionesDeVentaByIdTDCompTesoreria(IdTDCompTesoreria);
			string error = "No se puede Desactivar la forma de pago porque esta asociada a las siguientes condiciones de ventas: ";

			foreach(DataRow r in data.Tables[0].Rows)
			{
				
				string desc = Convert.ToString(r["Descripcion"]);
				error = error + " - " + desc;	
				

			}
			if(data.Tables[0].Rows.Count > 0)
			{
				row.SetColumnError( "Descripcion" , error);
				return false;
			}
			
			return true;
		}

		private static bool IsValidDescripcion(tfi_TDCompTesoreriaDataset.tfi_TDCompTesoreriaRow row)
		{
			string Descripcion = Convert.ToString(row["Descripcion"]);
			DataSet data = mz.erp.businessrules.tfi_TDCompTesoreria.GetListByDescripcion(Descripcion);
			foreach(DataRow r in data.Tables[0].Rows)
			{
				if(Convert.ToString(r["IdTDCompTesoreria"]) != Convert.ToString(row["IdTDCompTesoreria"]))
				{
					row.SetColumnError( "Descripcion" , "Ya existe una forma de pago con ese nombre");
					return false;
				}
			}
			
			return true;
		}

		private static bool ValidarCompleto(tfi_TDCompTesoreriaDataset.tfi_TDCompTesoreriaRow row)
		{
			bool ok = true;
			string messageError = row.GetColumnError("IdTDCompTesoreria");
			bool validadRelacionCondicionesDeVentas = Variables.GetValueBool("ProcesoABMFormasDePagos", "ABMFormasDePagos","Validar.RelacionObligatoriaCondicionesDeVentas");
			if(validadRelacionCondicionesDeVentas && _dataTDCompTesoreria_CondicionesDeVentas.tfi_TDCompTesoreria_CondicionesDeVenta.Rows.Count == 0)
			{
				messageError = messageError + ". " + "Debe seleccionar La Condición de Venta a la que se asocia la Forma de Pago";
				ok = false;
			}


			return ok;
		}
		
		
		/// <summary>
		/// Valida un tfi_TDCompTesoreriaRow.
		/// </summary>
		public static bool RowIsValid( tfi_TDCompTesoreriaDataset.tfi_TDCompTesoreriaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdTDCompTesoreriaIsValid( row.IdTDCompTesoreria, out mensaje) )
			{ 
				row.SetColumnError( "IdTDCompTesoreria" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
				isValid=false;
			
			}
						
			if ( !SistemaIsValid( row.Sistema, out mensaje) )
			{ 
				row.SetColumnError( "Sistema" , mensaje);
				isValid=false;
			
			}
						
			if ( !AgrupadoIsValid( row.Agrupado, out mensaje) )
			{ 
				row.SetColumnError( "Agrupado" , mensaje);
				isValid=false;
			
			}
						
			/*
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
			*/
						
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
		/// Valida el campo IdTDCompTesoreria.
		/// </summary>
		public static bool IdTDCompTesoreriaIsValid( string IdTDCompTesoreria , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTDCompTesoreria. Metodo Sobrecargado
		/// </summary>
		public static bool IdTDCompTesoreriaIsValid( string IdTDCompTesoreria)
		{
			string mensaje;
			return IdTDCompTesoreriaIsValid( IdTDCompTesoreria, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Descripcion.
		/// </summary>
		public static bool DescripcionIsValid( string Descripcion , out string mensaje )
		{
			if(Descripcion == null || Descripcion.Equals(string.Empty))
			{
				mensaje = "Debe ingresar el nombre de la forma de pago";
				return false;
			}
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
		/// Valida el campo Sistema.
		/// </summary>
		public static bool SistemaIsValid( bool Sistema , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Sistema. Metodo Sobrecargado
		/// </summary>
		public static bool SistemaIsValid( bool Sistema)
		{
			string mensaje;
			return SistemaIsValid( Sistema, out mensaje );
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


