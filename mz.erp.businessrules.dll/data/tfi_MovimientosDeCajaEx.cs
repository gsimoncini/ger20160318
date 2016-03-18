namespace mz.erp.businessrules
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.businessrules.comprobantes;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;
	using mz.erp.systemframework;
	using System.Collections;
	


	/// <summary>
	/// Descripción breve de tfi_MovimientosDeCajaEx.
	/// </summary>
	public class tfi_MovimientosDeCajaEx
	{
	
		public tfi_MovimientosDeCajaEx()
		{
		}

		public static System.Data.DataSet GetComprobantesTesoreria (System.Data.DataSet data)
		{
			return mz.erp.dataaccess.tfi_MovimientosDeCajaEx.GetComprobantesTesoreria(data);
		}

		
		#region Nueva Row

		[ atMethodNewRow ]
		public static tfi_MovimientosDeCajaExDataset NewRow()
		{
			tfi_MovimientosDeCajaExDataset data= new tfi_MovimientosDeCajaExDataset();
			tfi_MovimientosDeCajaExDataset.tfi_MovimientosDeCajaRow row= mz.erp.dataaccess.tfi_MovimientosDeCajaEx.NewRow(data);
			SetRowDefaultValues(row);
			data.tfi_MovimientosDeCaja.Rows.Add(row);
			return data;

		}

		public static tfi_MovimientosDeCajaExDataset.tfi_MovimientosDeCajaRow SetRowDefaultValues( tfi_MovimientosDeCajaExDataset.tfi_MovimientosDeCajaRow row )
		{
			row.IdMovimiento = Util.NewStringId(); 
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			row.IdInstanciaCaja = string.Empty;
			row.IdTipoDeMovimiento = string.Empty;
			row.Numero = Util.NewStringId();
			row.Fecha = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdResponsable = Security.IdPersona;
			row.Total = 0;
			row.IdMonedaCierre =string.Empty;
			row.IdCotizacionCierre = string.Empty;

			row.IdAceptacion = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;

			row.Observaciones = string.Empty;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;

			return row;
		}

		public static tfi_MovimientosDeCajaExDataset.tfi_PagosMovimientosCajasRow SetRowDefaultValues( tfi_MovimientosDeCajaExDataset.tfi_PagosMovimientosCajasRow row )
		{
			row.IdMovimiento = Util.NewStringId(); 
			row.IdEmpresa = Convert.ToString(Security.IdEmpresa);
			row.IdSucursal = Convert.ToString(Security.IdSucursal);
			row.IdInstanciaCaja = string.Empty;
			row.IdTipoDeMovimiento = string.Empty;
			row.Numero = Util.NewStringId();
			row.IdValor= Util.NewStringId();
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;

			return row;
		}

	#endregion
		
		public static tfi_MovimientosDeCajaExDataset Commit (tfi_MovimientosDeCajaExDataset data,MovimientoDeCaja movimiento, System.Data.DataSet valoresEx)
		{		
			data = (tfi_MovimientosDeCajaExDataset) mz.erp.businessrules.data.tfi_ValoresEx.Commit(movimiento.Valores, valoresEx,data);
			
			tfi_MovimientosDeCajaExDataset.tfi_MovimientosDeCajaDataTable TableDeMov= data.tfi_MovimientosDeCaja;
			tfi_MovimientosDeCajaExDataset.tfi_MovimientosDeCajaRow RowDeMov = (tfi_MovimientosDeCajaExDataset.tfi_MovimientosDeCajaRow)TableDeMov.Rows[0];
			SetRowValues(RowDeMov, movimiento);
			tfi_MovimientosDeCajaExDataset.tfi_PagosMovimientosCajasDataTable tablaPagos= data.tfi_PagosMovimientosCajas;
			foreach (Valor valor in movimiento.Valores)
			{
				tfi_MovimientosDeCajaExDataset.tfi_PagosMovimientosCajasRow rowPagos = tablaPagos.Newtfi_PagosMovimientosCajasRow();
							
				SetRowDefaultValues(rowPagos);
				rowPagos.IdValor = valor.IdValor;
				rowPagos.IdMovimiento = RowDeMov.IdMovimiento;
				rowPagos.IdInstanciaCaja= RowDeMov.IdInstanciaCaja;
				rowPagos.Numero= RowDeMov.Numero;
				rowPagos.IdTipoDeMovimiento= RowDeMov.IdTipoDeMovimiento;
				
				tablaPagos.Addtfi_PagosMovimientosCajasRow(rowPagos);
			}
			return data;
		}
		
		public static bool EsValidoElMovimiento(Valor valor, tfi_MovimientosDeCajaExDataset.tfi_PagosMovimientosCajasRow rowPagos)
		{
			string IdTDComTesoreria = valor.IdTDCompTesoreria;
			string IdMoneda = valor.IdMoneda;
				
			tfi_InstanciasCajaDataset.tfi_InstanciasCajaRow InstanciaRow= tfi_InstanciasCaja.GetByPk(rowPagos.IdInstanciaCaja);
			string IdCaja = Convert.ToString(InstanciaRow["IdCaja"]);
				
			decimal importeEnCaja = tfi_Cajas.GetImportePorTipoDeComprobante(IdTDComTesoreria,IdMoneda, IdCaja);
			return (importeEnCaja >= System.Math.Abs(valor.Monto));
		}
		
		public static bool EsValidoElMovimiento(tfi_MovimientosDeCajaExDataset data)
		{
			string tipoMovimiento = Convert.ToString(data.tfi_MovimientosDeCaja.Rows[0]["IdTipoDeMovimiento"]);
			string IdInstanciaCaja = Convert.ToString(data.tfi_MovimientosDeCaja.Rows[0]["IdInstanciaCaja"]);
			
			tsy_TiposMovimientosDataset.tsy_TiposMovimientosRow rowTipoMov = mz.erp.businessrules.tsy_TiposMovimientos.GetByPk(tipoMovimiento);
			string signoMovimiento = Convert.ToString(rowTipoMov.signo);
				
			bool ok = (data.tfi_Valores.Rows.Count != 0); //hay valores agregados
			if ( ok )
			{
				foreach ( DataRow row in data.tfi_Valores.Rows)
				{
					string IdTDComTesoreria = Convert.ToString(row["IdTDCompTesoreria"]);
					string IdMoneda = Convert.ToString(row["IdMoneda"]);
					decimal monto = Convert.ToDecimal(row["Valor"]);
					tfi_InstanciasCajaDataset.tfi_InstanciasCajaRow InstanciaRow =	tfi_InstanciasCaja.GetByPk(IdInstanciaCaja);
					string IdCaja = Convert.ToString(InstanciaRow["IdCaja"]);
				
					if ( signoMovimiento == "-1") //si es un egreso hago la verificaciones sino  no
					{
						decimal importeEnCaja = tfi_Cajas.GetImportePorTipoDeComprobante(IdTDComTesoreria,IdMoneda, IdCaja);
						if((importeEnCaja < System.Math.Abs(monto)))
						{
							ok = false;
							row.SetColumnError("Valor", "No se puede hacer el movimiento debido a que no se cuenta con los valores espeificados en la caja.");
						}
					}
				}
			}
			else // no tiene valores (esta solo la cabecera llena)
			{
				DataRow row2 = data.tfi_MovimientosDeCaja.Rows[0];
				row2.SetColumnError("Observaciones", "No se puede hacer el movimiento debido a que no se han especificado valores para el mismo.");
			}
			return ok;
		}


		public static void SetRowValues(tfi_MovimientosDeCajaExDataset.tfi_MovimientosDeCajaRow RowDeMov,MovimientoDeCaja movimiento)
		{
			RowDeMov.IdTipoDeMovimiento= movimiento.IdTipoMovimiento;
			RowDeMov.IdSubTipoMovimiento= movimiento.IdSubTipoMovimiento;	
			RowDeMov.Numero = movimiento.Numero;
			RowDeMov.Total = movimiento.Total*movimiento.Signo;
			RowDeMov.IdInstanciaCaja = movimiento.IdInstanciaDeCaja;
			RowDeMov.IdMonedaCierre= movimiento.IdMonedaCierre;
			RowDeMov.Observaciones = movimiento.Observaciones;
			RowDeMov.IdAceptacion = null;
		}

		public static void UpdateWithValidation(tfi_MovimientosDeCajaExDataset data)
		{
			ApplicationAssert.Check( data != null, "El argumento data no debe ser nulo.", ApplicationAssert.LineNumber );		
			if ( DatasetIsValid( data ) )			
				Update( data );
		}

		

		public static void Update (tfi_MovimientosDeCajaExDataset data)
		{
			ApplicationAssert.Check( data != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( data.tfi_MovimientosDeCaja.Rows.Count > 0, "La tabla Movimientos de Caja debe poseer alguna fila.", ApplicationAssert.LineNumber );
			string IdVariable = UpdateNumero(data);
			mz.erp.dataaccess.tfi_MovimientosDeCajaEx.Update( data,IdVariable );
		}
		
		private static string  UpdateNumero(tfi_MovimientosDeCajaExDataset data)
		{
			if (Variables.GetValueBool("Movimientos.Numeracion.Automatica")) //si es autonumerico tapo el numero q trae desde la UI
			{
				string numeracion = Variables.GetValueString("Movimientos.Numeracion");
				string Numero = Util.StcZero(numeracion,8);
				data.tfi_MovimientosDeCaja.Rows[0]["Numero"]= Numero;
				//actualizo la variable
				sy_VariablesDataset.sy_VariablesRow row = mz.erp.businessrules.sy_Variables.GetByPk("Movimientos.Numeracion" );
				mz.erp.dataaccess.sy_Variables.Update(row.IdVariable, (string)data.tfi_MovimientosDeCaja.Rows[0]["Numero"], 1);
				return row.IdVariable;
			}
			sy_VariablesDataset.sy_VariablesRow row2 = mz.erp.businessrules.sy_Variables.GetByPk("Movimientos.Numeracion" );
			return row2.IdVariable;

		}


		#region Validaciones

		public static bool DatasetIsValid(tfi_MovimientosDeCajaExDataset data)
		{	
			tfi_MovimientosDeCajaExDataset.tfi_MovimientosDeCajaDataTable tableMov=data.tfi_MovimientosDeCaja;
			tfi_MovimientosDeCajaExDataset.tfi_MovimientosDeCajaRow  row=(tfi_MovimientosDeCajaExDataset.tfi_MovimientosDeCajaRow)tableMov.Rows[0];
			bool ok= false;
			ok = EsValidoElMovimiento(data);
			
			if(!ok) return false;
			if (RowIsValid(row))
			{
				tfi_MovimientosDeCajaExDataset.tfi_PagosMovimientosCajasDataTable table= data.tfi_PagosMovimientosCajas;
				foreach (tfi_MovimientosDeCajaExDataset.tfi_PagosMovimientosCajasRow rowSP in table.Rows)		
				{
					if ( !RowIsValid(rowSP)){ok=false; break;}			
				}
			}
			return ok;	
		}


		
		#region Movimientos
		public static bool RowIsValid( tfi_MovimientosDeCajaExDataset.tfi_MovimientosDeCajaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdMovimientoIsValid( row.IdMovimiento, out mensaje) )
			{ 
				row.SetColumnError( "IdMovimiento" , mensaje);
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
						
			if ( !IdInstanciaCajaIsValid( row.IdInstanciaCaja, out mensaje) )
			{ 
				row.SetColumnError( "IdInstanciaCaja" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTipoDeMovimientoIsValid( row.IdTipoDeMovimiento, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoDeMovimiento" , mensaje);
				isValid=false;
			
			}
						
			if ( !NumeroIsValid( row.Numero, out mensaje) )
			{ 
				row.SetColumnError( "Numero" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaIsValid( row.Fecha, out mensaje) )
			{ 
				row.SetColumnError( "Fecha" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdResponsableIsValid( row.IdResponsable, out mensaje) )
			{ 
				row.SetColumnError( "IdResponsable" , mensaje);
				isValid=false;
			
			}
						
			if ( !TotalIsValid( row.Total, out mensaje) )
			{ 
				row.SetColumnError( "Total" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdMonedaCierreIsValid( row.IdMonedaCierre, out mensaje) )
			{ 
				row.SetColumnError( "IdMonedaCierre" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCotizacionCierreIsValid( row.IdCotizacionCierre, out mensaje) )
			{ 
				row.SetColumnError( "IdCotizacionCierre" , mensaje);
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
						
		/*	if ( !UltimaModificacionIsValid( row.UltimaModificacion, out mensaje) )
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
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdMovimiento.
		/// </summary>
		public static bool IdMovimientoIsValid( string IdMovimiento , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMovimiento. Metodo Sobrecargado
		/// </summary>
		public static bool IdMovimientoIsValid( string IdMovimiento)
		{
			string mensaje;
			return IdMovimientoIsValid( IdMovimiento, out mensaje );
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
		/// Valida el campo IdInstanciaCaja.
		/// </summary>
		public static bool IdInstanciaCajaIsValid( string IdInstanciaCaja , out string mensaje )
		{
			if (IdInstanciaCaja =="")
			{
				mensaje = "Debe seleccionar una Caja Abierta";
				return false;
			}
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
		/// Valida el campo IdTipoDeMovimiento.
		/// </summary>
		public static bool IdTipoDeMovimientoIsValid( string IdTipoDeMovimiento , out string mensaje )
		{
			if (IdTipoDeMovimiento =="")
			{
				mensaje = "Debe seleccionar el tipo de Movimiento";
				return false;
			}
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoDeMovimiento. Metodo Sobrecargado
		/// </summary>
		public static bool IdTipoDeMovimientoIsValid( string IdTipoDeMovimiento)
		{
			string mensaje;
			return IdTipoDeMovimientoIsValid( IdTipoDeMovimiento, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Numero.
		/// </summary>
		public static bool NumeroIsValid( string Numero , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Numero. Metodo Sobrecargado
		/// </summary>
		public static bool NumeroIsValid( string Numero)
		{
			string mensaje;
			return NumeroIsValid( Numero, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Fecha.
		/// </summary>
		public static bool FechaIsValid( DateTime Fecha , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Fecha. Metodo Sobrecargado
		/// </summary>
		public static bool FechaIsValid( DateTime Fecha)
		{
			string mensaje;
			return FechaIsValid( Fecha, out mensaje );
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
		/// Valida el campo Total.
		/// </summary>
		public static bool TotalIsValid( decimal Total , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Total. Metodo Sobrecargado
		/// </summary>
		public static bool TotalIsValid( decimal Total)
		{
			string mensaje;
			return TotalIsValid( Total, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdMonedaCierre.
		/// </summary>
		public static bool IdMonedaCierreIsValid( string IdMonedaCierre , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMonedaCierre. Metodo Sobrecargado
		/// </summary>
		public static bool IdMonedaCierreIsValid( string IdMonedaCierre)
		{
			string mensaje;
			return IdMonedaCierreIsValid( IdMonedaCierre, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdCotizacionCierre.
		/// </summary>
		public static bool IdCotizacionCierreIsValid( string IdCotizacionCierre , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCotizacionCierre. Metodo Sobrecargado
		/// </summary>
		public static bool IdCotizacionCierreIsValid( string IdCotizacionCierre)
		{
			string mensaje;
			return IdCotizacionCierreIsValid( IdCotizacionCierre, out mensaje );
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

		#region Pagos de Movimientos

		public static bool RowIsValid( tfi_MovimientosDeCajaExDataset.tfi_PagosMovimientosCajasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdMovimientoIsValid( row.IdMovimiento, out mensaje) )
			{ 
				row.SetColumnError( "IdMovimiento" , mensaje);
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
						
			if ( !IdInstanciaCajaIsValid( row.IdInstanciaCaja, out mensaje) )
			{ 
				row.SetColumnError( "IdInstanciaCaja" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTipoDeMovimientoIsValid( row.IdTipoDeMovimiento, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoDeMovimiento" , mensaje);
				isValid=false;
			
			}
						
			if ( !NumeroIsValid( row.Numero, out mensaje) )
			{ 
				row.SetColumnError( "Numero" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdValorIsValid( row.IdValor, out mensaje) )
			{ 
				row.SetColumnError( "IdValor" , mensaje);
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
			;
			
			return isValid;
		}
		

		
		/// <summary>
		/// Valida el campo IdValor.
		/// </summary>
		public static bool IdValorIsValid( string IdValor , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdValor. Metodo Sobrecargado
		/// </summary>
		public static bool IdValorIsValid( string IdValor)
		{
			string mensaje;
			return IdValorIsValid( IdValor, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaCreacion.
		/// </summary>
		public static bool IdEmpresaIsValid( string IdEmpresa , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEmpresa. Metodo Sobrecargado
		/// </summary>
		public static bool IdEmpresaIsValid( string IdEmpresa)
		{
			string mensaje;
			return IdEmpresaIsValid( IdEmpresa, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdSucursal.
		/// </summary>
		public static bool IdSucursalIsValid( string IdSucursal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdSucursal. Metodo Sobrecargado
		/// </summary>
		public static bool IdSucursalIsValid( string IdSucursal)
		{
			string mensaje;
			return IdSucursalIsValid( IdSucursal, out mensaje );
		}	
		


		#endregion


		#endregion
	

	}
}
