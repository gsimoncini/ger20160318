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
	using System.Windows.Forms;

	public class tfi_InstanciasCaja : IDisposable
	{
	
		#region Custom Members

		public static DataSet GetListByIdCaja(string IdCaja)
		{
			return  mz.erp.dataaccess.tfi_InstanciasCaja.GetListByIdCaja(IdCaja);
		}
		






	
		public static tfi_InstanciasCajaExDataset.tfi_InstanciasCajaRow AbrirCaja (string IdCaja)
		{
			try 
			{
				tfi_InstanciasCajaExDataset data = new tfi_InstanciasCajaExDataset();
				//tfi_InstanciasCajaExDataset.tfi_InstanciasCajaDataTable table = data.tfi_InstanciasCaja;
				tfi_InstanciasCajaExDataset.tfi_InstanciasCajaRow row = mz.erp.dataaccess.tfi_InstanciasCaja.NewRowEx();
				SetRowDefaultValues(row);
				row.IdCaja= IdCaja;
				Update(row);
				return row;
				

			}
			catch (Exception e){;return null;}
		}

		public static tfi_InstanciasCajaExDataset.tfi_InstanciasCajaRow AbrirCajaConSaldo (string IdCaja, string IdInstanciaCaja, bool poseeValores)
		{
			string IdTransaction = dataaccess.PoolTransaction.BeginTransaction();
			try 
			{
				tfi_InstanciasCajaExDataset data = new tfi_InstanciasCajaExDataset();
				
				tfi_InstanciasCajaExDataset.tfi_InstanciasCajaRow row = mz.erp.dataaccess.tfi_InstanciasCaja.NewRowEx();
				SetRowDefaultValues(row);
				row.IdCaja= IdCaja;
				data.tfi_InstanciasCaja.LoadDataRow(row.ItemArray, false);
				TransferenciaValores _transferencia = new TransferenciaValores();
				mz.erp.commontypes.ApplicationLog.WriteInfo("Apertura de la Caja " + IdCaja + " Responsable " + Security.IdUsuario + ". Instancia " + Convert.ToString(IdInstanciaCaja));
				if(poseeValores)
				{
					//realizar la transferencia entre esta instancia row y la caja anterior
					mz.erp.commontypes.ApplicationLog.WriteInfo("La caja Posee Valores");
					_transferencia.Init("AbrirCaja", "ProcesoAbrirCaja");
					_transferencia.KeyValueCajaOrigen = IdInstanciaCaja;
					_transferencia.KeyValueCajaDestino = row.IdInstanciaCaja;
					_transferencia.SearchValoresDisponibles();
					mz.erp.commontypes.ApplicationLog.WriteInfo("Valores Disponibles " + _transferencia.ValoresDisponibles.Count.ToString());
					_transferencia.TransferirTodo();
					_transferencia.Commit();
				}
				else
					mz.erp.commontypes.ApplicationLog.WriteInfo("La caja NO Posee Valores");
				mz.erp.dataaccess.tfi_InstanciasCaja.Update(data.tfi_InstanciasCaja, IdTransaction );
				if(poseeValores)
				{
					string IdInstanciaCajaDestino = Convert.ToString(data.tfi_InstanciasCaja.Rows[0]["IdInstanciaCaja"]);
					DataSet dataValoresD = _transferencia.DataValoresDestino;
					if ( dataValoresD.Tables.Count > 0 )
					{
						foreach(DataRow rowV in dataValoresD.Tables[0].Rows)
						{
							rowV["IdInstanciaCaja"] = IdInstanciaCajaDestino;
						}
					}
					DataSet dataAux = _transferencia.DataMovimientosD;
					if ( dataAux.Tables.Count > 0)
					{
						foreach(DataRow rowMD in dataAux.Tables[0].Rows)
						{
							rowMD["IdInstanciaCaja"] = IdInstanciaCajaDestino;
						}
					}
					dataAux = _transferencia.DataPagosMovimientosD;
					if (dataAux.Tables.Count > 0 )
					{
						foreach(DataRow rowPMD in dataAux.Tables[0].Rows)
						{
							rowPMD["IdInstanciaCaja"] = IdInstanciaCajaDestino;
						}
					}
					_transferencia.Flush(IdTransaction);
				}
			
				PoolTransaction.Commit(IdTransaction);
				return row;
			}
			catch (Exception e) 
			{
				mz.erp.commontypes.ApplicationLog.WriteInfo("EXCEPCION en la Apertura de la Caja " + IdCaja + " Responsable " + Security.IdUsuario + ". Instancia " + Convert.ToString(IdInstanciaCaja));
				PoolTransaction.RollBack(IdTransaction);
				throw e;
				return null;
			}
		}



		public static tfi_InstanciasCajaExDataset CerrarCaja (string IdInstanciaCaja)
		{
			return GetCierre(IdInstanciaCaja);
			
		}

		public static void Update( tfi_InstanciasCajaExDataset.tfi_InstanciasCajaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_InstanciasCaja.Update( row );
		}

		public static tfi_InstanciasCajaExDataset.tfi_InstanciasCajaRow SetRowDefaultValues( tfi_InstanciasCajaExDataset.tfi_InstanciasCajaRow row )
		{
			row.IdInstanciaCaja = Util.NewStringId(); 
			row.IdCaja = string.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			row.Apertura = mz.erp.businessrules.Sistema.DateTime.Now;
			row.Cierre = DateTime.MinValue;
			row.IdResponsable = Security.IdPersona;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/*
		public static DataSet GetListXPersona(string IdPersona)
		{
			if ( Variables.GetValueBool("Cajas.Seguridad.PermiteMovimientosPorPerfilSuperior") == true)
			{
				IdPersona = null;
			}
			return mz.erp.dataaccess.tfi_InstanciasCaja.GetListXPersona(IdPersona);
		}

		*/
		
		/*Se llama desde la clase MovimientosCaja*/
		public static DataSet GetList(string IdResponsable)
		{
			
			if ( IdResponsable != null && IdResponsable != string.Empty && Variables.GetValueBool("Cajas.Seguridad.PermiteMovimientosPorTodosLosResponsables") == true)
			{
				return  mz.erp.dataaccess.tfi_InstanciasCaja.GetListCajasDeTodosLosResponsables(IdResponsable, null);
			}
			
			return mz.erp.dataaccess.tfi_InstanciasCaja.GetList(IdResponsable, null);
		}
		
		
		/*Se llama desde ComprobanteDePago*/
		public static DataSet GetList(string IdResponsable, string idCajasValidas)
		{
			
			if (IdResponsable != null && IdResponsable != string.Empty && Variables.GetValueBool("Cajas.Seguridad.PermiteMovimientosPorTodosLosResponsables") == true)
			{
				return  mz.erp.dataaccess.tfi_InstanciasCaja.GetListCajasDeTodosLosResponsables(IdResponsable, idCajasValidas);
			}
			
			return mz.erp.dataaccess.tfi_InstanciasCaja.GetList(IdResponsable, idCajasValidas);
		}
		
		/*Indirectamente lo usa ComprobanteDePago*/
		public static ArrayList GetListArray( string IdResponsable, string IdCaja )
		{
			SortedArray lista = new SortedArray();
			DataSet instancias = null;
			if (IdResponsable != null && IdResponsable != string.Empty && Variables.GetValueBool("Cajas.Seguridad.PermiteMovimientosPorTodosLosResponsables") == true)
			{
				instancias = mz.erp.dataaccess.tfi_InstanciasCaja.GetListCajasDeTodosLosResponsables(IdResponsable,IdCaja);
			}
			else
				instancias = mz.erp.dataaccess.tfi_InstanciasCaja.GetList(IdResponsable, IdCaja);
			foreach ( DataRow row in instancias.Tables[0].Rows )
			{
				lista.Add( (string)row["IdInstanciaCaja"] );
			}
			return (ArrayList)lista;
		}

		public static ArrayList GetListParaConsultaValores(string IdResponsable,bool permiteConsultarValoresCajasOtrosUser)
		{
			ArrayList _array = new ArrayList();	
			DataSet _data=new DataSet();
			if ( IdResponsable != null && IdResponsable != string.Empty && permiteConsultarValoresCajasOtrosUser)
			{
				_data=mz.erp.dataaccess.tfi_InstanciasCaja.GetListCajasDeTodosLosResponsables(IdResponsable, null);
			}
			else
				if ( IdResponsable != null && IdResponsable != string.Empty && !permiteConsultarValoresCajasOtrosUser)
					_data= mz.erp.dataaccess.tfi_InstanciasCaja.GetList(IdResponsable, null);
			foreach ( DataRow row in _data.Tables[0].Rows)
			{
				_array.Add( Convert.ToString(row["IdCaja"]) );
			}
			return _array;
		}
		
		public static System.Collections.Hashtable GetListArrayXPersona( string IdPersona )
		{			
			Hashtable lista = new Hashtable();
			DataSet instancias = mz.erp.dataaccess.tfi_InstanciasCaja.GetListXPersona(IdPersona);
			foreach ( DataRow row in instancias.Tables[0].Rows )
			{
				lista.Add(Convert.ToString(row["IdInstanciaCaja"]),Convert.ToString(row["Descripcion"]));
				
			}
			return lista;
		}

		public static bool InstanciaDeCajaAbierta(string IdInstanciaCaja)
		{			
			System.Collections.Hashtable hash = GetListArrayAbiertas();
			return hash.Contains(IdInstanciaCaja);
		}
		public static System.Collections.Hashtable GetListArrayAbiertas( )
		{
			Hashtable lista = new Hashtable();
			DataSet instancias = mz.erp.dataaccess.tfi_InstanciasCaja.GetListAbiertas();
			foreach ( DataRow row in instancias.Tables[0].Rows )
			{
				lista.Add(Convert.ToString(row["IdInstanciaCaja"]),Convert.ToString(row["Descripcion"]));
				
			}
			return lista;
		}

		public static System.Collections.Hashtable GetListArrayAbiertasWF(string ProcessName, string TaskName )
		{
			Hashtable lista = new Hashtable();
			DataTable instancias = mz.erp.dataaccess.tfi_InstanciasCaja.GetListAbiertas().Tables[0];
			instancias =  VariablesListComparer.FilterDataTable(ProcessName, TaskName, "ListaCajasDestino", "IdCaja", instancias);
            foreach ( DataRow row in instancias.Rows )
			{
				lista.Add(Convert.ToString(row["IdInstanciaCaja"]),Convert.ToString(row["Descripcion"]));
				
			}
			return lista;
		}

		

		
		
		public static tfi_InstanciasCajaExDataset GetCierre(string IdInstanciaCaja)
		{
			return mz.erp.dataaccess.tfi_InstanciasCaja.GetCierre(IdInstanciaCaja);
		}

		public static DataTable GetListXInstanciaAnterior(string IdInstanciaCaja) 
		{
			return dataaccess.tfi_InstanciasCaja.GetListXInstanciaAnterior(IdInstanciaCaja);
		}
		

		public static DataTable GetListXInstancia(string IdInstanciaCaja) 
		{
			return dataaccess.tfi_InstanciasCaja.GetListXInstancia(IdInstanciaCaja);
		}
		
		public static DataTable GetTotalInstanciaPorTDCompTesoreria(string IdTDCompTesoreria, string InstanciaCaja)
		{
			return mz.erp.dataaccess.tfi_InstanciasCaja.GetTotalInstanciaPorTDCompTesoreria( IdTDCompTesoreria, InstanciaCaja);
		}


		public static tfi_InstanciasCajaExDataset GuardarArqueoCaja (tfi_InstanciasCajaExDataset data)
		{
			tfi_InstanciasCajaExDataset.Pr_tfi_InstanciasCaja_CierreCajaDataTable table= data.Pr_tfi_InstanciasCaja_CierreCaja;
			tfi_InstanciasCajaExDataset.tfi_InstanciasCajaCierresDataTable tableInsCajaCierre = data.tfi_InstanciasCajaCierres;
			if (table.Rows.Count > 0)
			{
					foreach (tfi_InstanciasCajaExDataset.Pr_tfi_InstanciasCaja_CierreCajaRow row in table.Rows)
					{
						tfi_InstanciasCajaExDataset.tfi_InstanciasCajaCierresRow rowCajaCierre = data.tfi_InstanciasCajaCierres.Newtfi_InstanciasCajaCierresRow();
						//	mz.erp.businessrules.tfi_InstanciasCajaCierres.NewRow();
						//	mz.erp.businessrules.tfi_InstanciasCajaCierres.SetRowDefaultValues(rowCajaCierre);
						rowCajaCierre.IdInstanciaCaja= row.IdInstanciaCaja;
						rowCajaCierre.IdTDCompTesoreria= row.IdTDCompTesoreria;
						rowCajaCierre.IdMonedaCierre= row.IdMoneda;
						rowCajaCierre.IdCotizacionCierre= row.IdCotizacionMoneda;
						rowCajaCierre.Total = row.Neto;
						tableInsCajaCierre.Addtfi_InstanciasCajaCierresRow(rowCajaCierre);

					}
				
			} else System.Windows.Forms.MessageBox.Show("No se han realizado pagos en esta Caja hasta el momento");
			tfi_InstanciasCajaExDataset.tfi_InstanciasCajaRow rowInsCaja= (tfi_InstanciasCajaExDataset.tfi_InstanciasCajaRow)data.tfi_InstanciasCaja.Rows[0];
			rowInsCaja.Cierre= mz.erp.businessrules.Sistema.DateTime.Now;
			
			Update(data);
			return data;
		}

		public static void Update( tfi_InstanciasCajaExDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_InstanciasCaja.Rows.Count > 0, "La tabla dataSet.tfi_InstanciasCajaDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
		mz.erp.dataaccess.tfi_InstanciasCaja.Update(dataSet);
		}

		public static tfi_InstanciasCajaExDataset GetDetalleIngresosEgresos(tfi_InstanciasCajaExDataset data, string IdInstanciaCaja)
		{
			
			string TiposDeComprobantes = Variables.GetValueString("Cajas.Comprobantes.TiposDeComprobantes");
			string TiposDeMovimientos = Variables.GetValueString("Cajas.Movimientos.TiposDeMovimientos");
			
			return mz.erp.dataaccess.tfi_InstanciasCaja.GetDetalleIngresosEgresos(data, IdInstanciaCaja, TiposDeComprobantes,TiposDeMovimientos);
		}
		
		public static tfi_InstanciasCajaExDataset GetDetallePagosMovimientosDeCaja(tfi_InstanciasCajaExDataset data, string IdMovimiento)
		{
			
			return mz.erp.dataaccess.tfi_InstanciasCaja.GetDetallePagosMovimientosDeCaja(data, IdMovimiento);
		}

		public static tfi_InstanciasCajaExDataset GetDetallePagosComprobantes(tfi_InstanciasCajaExDataset data, string IdComprobante)
		{
			
			return mz.erp.dataaccess.tfi_InstanciasCaja.GetDetallePagosComprobantes(data, IdComprobante);
		}

		public static DataSet GetDetallePagosMovimientosDeCaja( string IdMovimiento)
		{
			
			return mz.erp.dataaccess.tfi_InstanciasCaja.GetDetallePagosMovimientosDeCaja(IdMovimiento);
		}

		public static DataSet GetDetallePagosComprobantes(string IdComprobante)
		{
			
			return mz.erp.dataaccess.tfi_InstanciasCaja.GetDetallePagosComprobantes( IdComprobante);
		}

		public static string GetResponsableXInstanciaDeCaja(string IdInstanciaCaja) 
		{
			tfi_InstanciasCajaDataset.tfi_InstanciasCajaRow row = tfi_InstanciasCaja.GetByPk(IdInstanciaCaja);						
			if (row == null)
				return Security.IdPersona;
			tsh_PersonasDataset.tsh_PersonasRow rowP = tsh_Personas.GetByPk(row.IdResponsable);
			return rowP.Nombre;			
		}


		#endregion
		
		#region Code Smith
		
		public tfi_InstanciasCaja()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tfi_InstanciasCaja
		/// </summary>
		public static tfi_InstanciasCajaDataset GetList()
		{
			return mz.erp.dataaccess.tfi_InstanciasCaja.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tfi_InstanciasCaja filtrada por las condiciones de bsqueda
		/// </summary>
		public static tfi_InstanciasCajaDataset GetList( string IdInstanciaCaja, string IdCaja, DateTime Apertura, DateTime Cierre , string IdResponsable)
		{
			return mz.erp.dataaccess.tfi_InstanciasCaja.GetList( IdInstanciaCaja, IdCaja, Apertura, Cierre, IdResponsable );
		}

		/// <summary>
		/// Crea un tfi_InstanciasCajaRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tfi_InstanciasCajaDataset.tfi_InstanciasCajaRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_InstanciasCaja.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_InstanciasCaja que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tfi_InstanciasCajaDataset.tfi_InstanciasCajaRow GetByPk( string IdInstanciaCaja )
		{
			tfi_InstanciasCajaDataset.tfi_InstanciasCajaRow row = mz.erp.dataaccess.tfi_InstanciasCaja.GetByPk( IdInstanciaCaja  );
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

		public static string GetCajaByPkIdInstanciaCaja( string IdInstanciaCaja )
		{
			tfi_InstanciasCajaDataset.tfi_InstanciasCajaRow row = mz.erp.dataaccess.tfi_InstanciasCaja.GetByPk( IdInstanciaCaja  );
			if (row != null)
			{
				return Convert.ToString(row["IdCaja"]);
			}
			return string.Empty;

		}
		/// <summary>
		/// Obtiene un registro de la tabla tfi_InstanciasCaja que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tfi_InstanciasCajaDataset.tfi_InstanciasCajaRow GetByPk( object IdInstanciaCaja )
		{
			return GetByPk( ( string )IdInstanciaCaja );
		}

		/// <summary>
		/// Establece los valores por defecto de tfi_InstanciasCajaRow.
		/// </summary>
		public static tfi_InstanciasCajaDataset.tfi_InstanciasCajaRow SetRowDefaultValues( tfi_InstanciasCajaDataset.tfi_InstanciasCajaRow row )
		{
			row.IdInstanciaCaja = Util.NewStringId(); 
			row.IdCaja = string.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			row.Apertura = mz.erp.businessrules.Sistema.DateTime.Now;
			row.Cierre = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdResponsable = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
		//	row.UltimaModificacion = new DateTime(1157,1,1);
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;

			return row;
		}

		
		/// <summary>
		/// Envia los cambios del tfi_InstanciasCajaRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_InstanciasCajaDataset.tfi_InstanciasCajaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tfi_InstanciasCajaRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_InstanciasCajaDataset.tfi_InstanciasCajaRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_InstanciasCajaRow a la base de datos.
		/// </summary>
		public static void Update( tfi_InstanciasCajaDataset.tfi_InstanciasCajaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_InstanciasCaja.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tfi_InstanciasCajaDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_InstanciasCajaDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_InstanciasCaja.Rows.Count > 0, "La tabla dataSet.tfi_InstanciasCajaDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_InstanciasCaja.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_InstanciasCajaDataset.tfi_InstanciasCajaDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_InstanciasCajaDataset.tfi_InstanciasCajaDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_InstanciasCaja.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tfi_InstanciasCajaRow.
		/// </summary>
		public static bool RowIsValid( tfi_InstanciasCajaDataset.tfi_InstanciasCajaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdInstanciaCajaIsValid( row.IdInstanciaCaja, out mensaje) )
			{ 
				row.SetColumnError( "IdInstanciaCaja" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCajaIsValid( row.IdCaja, out mensaje) )
			{ 
				row.SetColumnError( "IdCaja" , mensaje);
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
						
			if ( !AperturaIsValid( row.Apertura, out mensaje) )
			{ 
				row.SetColumnError( "Apertura" , mensaje);
				isValid=false;
			
			}
						
			if ( !CierreIsValid( row.Cierre, out mensaje) )
			{ 
				row.SetColumnError( "Cierre" , mensaje);
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
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdInstanciaCaja.
		/// </summary>
		public static bool IdInstanciaCajaIsValid( string IdInstanciaCaja , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdInstanciaCaja. Metodo Sobrecargado
		/// </summary>
		public static bool IdInstanciaCajaIsValid( string IdInstanciaCaja)
		{
			string mensaje;
			return IdInstanciaCajaIsValid( IdInstanciaCaja, out mensaje );
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
		/// Valida el campo Apertura.
		/// </summary>
		public static bool AperturaIsValid( DateTime Apertura , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Apertura. Metodo Sobrecargado
		/// </summary>
		public static bool AperturaIsValid( DateTime Apertura)
		{
			string mensaje;
			return AperturaIsValid( Apertura, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Cierre.
		/// </summary>
		public static bool CierreIsValid( DateTime Cierre , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Cierre. Metodo Sobrecargado
		/// </summary>
		public static bool CierreIsValid( DateTime Cierre)
		{
			string mensaje;
			return CierreIsValid( Cierre, out mensaje );
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
	
		#endregion

		

		public void Dispose()
		{
		}
		
	}
}

