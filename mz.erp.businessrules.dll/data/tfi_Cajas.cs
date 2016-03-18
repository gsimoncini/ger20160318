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

	public class tfi_Cajas : IDisposable
	{
	
		#region Custom Members

		public static decimal GetImportePorTipoDeComprobante (string IdTDCompTesoreria, string IdMoneda, string Caja)
		{ 
			string IdMonedaReferencia = Variables.GetValueString("Contabilidad.MonedaReferencia");
			return mz.erp.dataaccess.reportes.GenericReports.GetTotalPorComprobanteTesoreria(IdMonedaReferencia, IdTDCompTesoreria, IdMoneda, Caja);

		}

		
		
		public static decimal GetImportePorTipoDeComprobanteAnterior (string IdTDComTesoreria, string Moneda, string Caja)
		{ 
			string IdMonedaReferencia = Variables.GetValueString("Contabilidad.MonedaReferencia");
			string IdEntidades = null;
			string IdTDCompTesoreria = IdTDComTesoreria;
			System.DateTime FechaDesde = System.DateTime.MinValue; 
			System.DateTime FechaHasta = System.DateTime.MaxValue;
			string IdPersona = null;
			string Estado= "Abierta";
			string IdCajas = Caja;
			string IdMoneda = Moneda;

   			DataSet _data = mz.erp.dataaccess.reportes.GenericReports.GetConsultaDeCajaDetallado( 
			IdMonedaReferencia, IdEntidades, IdTDCompTesoreria, FechaDesde, FechaHasta,
			IdPersona, Estado, IdCajas, IdMoneda, "Abiertas");

			decimal suma = 0;
			if (_data.Tables.Count > 0 )
			{
				foreach ( System.Data.DataRow row in _data.Tables[0].Rows)
					//suma = suma + (Convert.ToDecimal(row["valor"]) * Convert.ToDecimal(row["signo"]));
					suma = suma + (Convert.ToDecimal(row["importe"]));
			}
			return suma;
		}

		public static Hashtable GetTiposDeMovimientosDeCaja(string IdTipo, System.Int16 signo, bool Sistema)
		{
			DataSet _data = mz.erp.dataaccess.tfi_Cajas.GetTiposDeMovimientosDeCaja( IdTipo, signo , Sistema);
			Hashtable _hash = new Hashtable();
			if (_data.Tables.Count > 0)
			{
				foreach(System.Data.DataRow _row in _data.Tables[0].Rows)
				{
					_hash.Add( Convert.ToString( _row["IdTipo"]),Convert.ToString(_row["Descripcion"]));
				}
			}
			return _hash;
		}
		
		public static Hashtable GetTiposDeMovimientos(string IdTipo, System.Int16 signo)
		{
			DataSet _data = mz.erp.dataaccess.tfi_Cajas.GetTiposDeMovimientos( IdTipo, signo );
			Hashtable _hash = new Hashtable();
			if (_data.Tables.Count > 0)
			{
				foreach(System.Data.DataRow _row in _data.Tables[0].Rows)
				{
					_hash.Add( Convert.ToString( _row["IdTipo"]),Convert.ToString(_row["Descripcion"]));
				}
			}
			return _hash;
		}
		public static Hashtable GetListHashTable( )
		{
			string param = null;
			tfi_CajasDataset _data = mz.erp.dataaccess.tfi_Cajas.GetList( param, param );
			Hashtable _hash = new Hashtable();
			
			foreach(System.Data.DataRow _row in _data.tfi_Cajas.Rows )
			{
				_hash.Add( Convert.ToString(_row["IdCaja"]),Convert.ToString(_row["Descripcion"] ) );
			}
			return _hash;
		}
		public static tfi_InstanciasCajaExDataset GetList( string IdResponsable )
		{
			return mz.erp.dataaccess.tfi_Cajas.GetList( IdResponsable );
		}
				
		
		public static string GetInstanciaAbiertaDeCaja( string IdResponsable, string IdCaja )
		{
			ArrayList array = tfi_InstanciasCaja.GetListArray( IdResponsable, IdCaja );
			if (array.Count > 0)
			{
				return (string)array[0];
			}
			else
			{
				return null;
			}							
		}

		
		
		public static Hashtable GetInstanciaAbiertaDeCaja( string IdPersona ) 
		{
			Hashtable array = tfi_InstanciasCaja.GetListArrayXPersona( IdPersona );
			if (array.Count > 0)
			{
				return array;
			}
			else
			{
				return null;
			}			
		}
		public static Hashtable GetInstanciaAbiertaDeCaja( ) 
		{
			Hashtable array = tfi_InstanciasCaja.GetListArrayAbiertas();
			if (array.Count > 0)
			{
				return array;
			}
			else
			{
				return null;
			}			
		}

		public static Hashtable GetInstanciaAbiertaDeCajaWF(string ProcessName, string TaskName ) 
		{
			Hashtable array = tfi_InstanciasCaja.GetListArrayAbiertasWF(ProcessName, TaskName);
			if (array.Count > 0)
			{
				return array;
			}
			else
			{
				return null;
			}			
		}
			
			
		#endregion
		
		public tfi_Cajas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tfi_Cajas
		/// </summary>
		public static tfi_CajasDataset GetList()
		{
			return mz.erp.dataaccess.tfi_Cajas.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tfi_Cajas filtrada por las condiciones de bsqueda
		/// </summary>
		public static tfi_CajasDataset GetList( string IdCaja, string Descripcion )
		{
			return mz.erp.dataaccess.tfi_Cajas.GetList( IdCaja, Descripcion );
		}

		public static System.Data.DataTable GetByResponsableTodasLasCajas(string IdPersona, string Cajas)
		{
			return mz.erp.dataaccess.tfi_Cajas.GetByResponsableTodasLasCajas(IdPersona, Cajas);
		}

		public static System.Data.DataTable GetByResponsableTodasLasCajasConAperturaConSaldo(string IdPersona, string Cajas)
		{
			return mz.erp.dataaccess.tfi_Cajas.GetByResponsableTodasLasCajasConAperturaConSaldo(IdPersona, Cajas);
		}

		public static System.Data.DataTable GetByResponsableConAperturaConSaldo(string IdPersona)
		{
			return mz.erp.dataaccess.tfi_Cajas.GetByResponsableConAperturaConSaldo(IdPersona);
		}

		public static System.Data.DataSet rep_ListadoEstadoCajas()
		{
			return mz.erp.dataaccess.tfi_Cajas.rep_ListadoEstadoCajas();
		}

		/// <summary>
		/// Crea un tfi_CajasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tfi_CajasDataset.tfi_CajasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_Cajas.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_Cajas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tfi_CajasDataset.tfi_CajasRow GetByPk( string IdCaja )
		{
			tfi_CajasDataset.tfi_CajasRow row = mz.erp.dataaccess.tfi_Cajas.GetByPk( IdCaja  );
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
		/// Obtiene un registro de la tabla tfi_Cajas que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tfi_CajasDataset.tfi_CajasRow GetByPk( object IdCaja )
		{
			return GetByPk( ( string )IdCaja );
		}

		/// <summary>
		/// Establece los valores por defecto de tfi_CajasRow.
		/// </summary>
		public static tfi_CajasDataset.tfi_CajasRow SetRowDefaultValues( tfi_CajasDataset.tfi_CajasRow row )
		{
			row.IdCaja = Util.NewStringId(); 
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			row.Descripcion = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tfi_CajasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_CajasDataset.tfi_CajasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tfi_CajasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_CajasDataset.tfi_CajasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_CajasRow a la base de datos.
		/// </summary>
		public static void Update( tfi_CajasDataset.tfi_CajasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_Cajas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tfi_CajasDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_CajasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_Cajas.Rows.Count > 0, "La tabla dataSet.tfi_CajasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_Cajas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_CajasDataset.tfi_CajasDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_CajasDataset.tfi_CajasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			if(TableIsValid(dataTable))
			{

				ArrayList CajasAAgregar = ObtenerCajasAAgregar(dataTable);
				ArrayList CajasAEliminar = ObtenerCajasAEliminar(dataTable);
				DataSet dataVariables = ActualizaVariablesCajas( dataTable, CajasAAgregar, CajasAEliminar);

				mz.erp.dataaccess.tfi_Cajas.Update( dataTable, dataVariables.Tables[0] );
			}
		}

		public static bool TableIsValid( tfi_CajasDataset.tfi_CajasDataTable dataTable )
		{
			
			foreach(DataRow row in dataTable.Rows)
			{
				if(row.RowState.Equals(DataRowState.Modified) || row.RowState.Equals(DataRowState.Added))
				{
					string Caja = Convert.ToString(row["Descripcion"]);
					if(Caja.Trim().Equals(string.Empty))
					{
						row.SetColumnError( "Descripcion", "La Descripción de la Caja no puede ser vacía");
						return false;
					}


				}
			}

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

			return true;
		}


		public static ArrayList ObtenerCajasAEliminar(tfi_CajasDataset.tfi_CajasDataTable dataTable)
		{
			ArrayList res = new ArrayList();
			foreach(DataRow row in dataTable.Rows)
			{
				if(row.RowState.Equals(DataRowState.Deleted))
					res.Add(Convert.ToString(row["IdCaja", DataRowVersion.Original]));
			}


			return res;
		}


		public static ArrayList ObtenerCajasAAgregar(tfi_CajasDataset.tfi_CajasDataTable dataTable)
		{
			ArrayList res = new ArrayList();
			foreach(DataRow row in dataTable.Rows)
			{
				if(row.RowState.Equals(DataRowState.Added))
					res.Add(Convert.ToString(row["IdCaja"]));
			}


			return res;
		}


		public static DataSet ActualizaVariablesCajas(tfi_CajasDataset.tfi_CajasDataTable dataTable, ArrayList CajasAgregadas, ArrayList CajasEliminadas)
		{
			
			string IdCajaTemporal = Variables.GetValueString("Cajas.CajaTemporalDefault");
			DataSet data = mz.erp.businessrules.sy_Variables.GetListByCola(".Cajas");
			foreach(DataRow row in data.Tables[0].Rows)
			{
				string valor = Convert.ToString(row["ValorDefault"]);
				ArrayList valores = mz.erp.systemframework.Util.Parse(valor);
				//Excluye a las variables que solo se configuran con la caja Temporal Default
				if(!valores.Contains(IdCajaTemporal))
				{
					foreach(string IdCaja in CajasAgregadas)
					{
						if(!valores.Contains(IdCaja))
							valores.Add(IdCaja);
					}
					foreach(string IdCaja in CajasEliminadas)
					{
						if(valores.Contains(IdCaja))
							valores.Remove(IdCaja);
					}
					row["ValorDefault"] = mz.erp.systemframework.Util.PackString(valores);
				}

			}
			return data;
		}

		
		/// <summary>
		/// Valida un tfi_CajasRow.
		/// </summary>
		public static bool RowIsValid( tfi_CajasDataset.tfi_CajasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
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
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
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
		

		public void Dispose()
		{
		}
		
	}
}

