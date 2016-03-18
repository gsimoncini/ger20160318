
namespace mz.erp.businessrules
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tfi_ValoresDatosAuxiliares : IDisposable
	{

		#region Custom Members
		public static string GetHTML(string IdValor)
		{
			DataSet data = mz.erp.dataaccess.tfi_ValoresDatosAuxiliares.GetHTML(IdValor);
			if(data.Tables[0].Rows.Count > 0)
				return Convert.ToString(data.Tables[0].Rows[0]["TextoHTML"]);
			return string.Empty;
		}

		#endregion

		public tfi_ValoresDatosAuxiliares()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tfi_ValoresDatosAuxiliares
		/// </summary>
		public static tfi_ValoresDatosAuxiliaresDataset GetList()
		{
			return mz.erp.dataaccess.tfi_ValoresDatosAuxiliares.GetList();
		}

		/// <summary>
		/// Obtiene tabla tfi_ValoresDatosAuxiliares filtrada por las condiciones de bsqueda
		/// </summary>
		
		public static tfi_ValoresDatosAuxiliaresDataset GetList( string IdValor )
		{
			return mz.erp.dataaccess.tfi_ValoresDatosAuxiliares.GetList( IdValor );
		}
		

		/// <summary>
		/// Crea un tfi_ValoresDatosAuxiliaresRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tfi_ValoresDatosAuxiliaresDataset.tfi_ValoresDatosAuxiliaresRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_ValoresDatosAuxiliares.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_ValoresDatosAuxiliares que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tfi_ValoresDatosAuxiliaresDataset.tfi_ValoresDatosAuxiliaresRow GetByPk( string IdValor )
		{
			tfi_ValoresDatosAuxiliaresDataset.tfi_ValoresDatosAuxiliaresRow row = mz.erp.dataaccess.tfi_ValoresDatosAuxiliares.GetByPk( IdValor );
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
		/// Obtiene un registro de la tabla tfi_ValoresDatosAuxiliares que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tfi_ValoresDatosAuxiliaresDataset.tfi_ValoresDatosAuxiliaresRow GetByPk( object IdValor )
		{
			return GetByPk( ( string )IdValor );
		}

		/// <summary>
		/// Establece los valores por defecto de tfi_ValoresDatosAuxiliaresRow.
		/// </summary>
		public static tfi_ValoresDatosAuxiliaresDataset.tfi_ValoresDatosAuxiliaresRow SetRowDefaultValues( tfi_ValoresDatosAuxiliaresDataset.tfi_ValoresDatosAuxiliaresRow row )
		{
			row.IdValor = Util.NewStringId();
			row.CODIGO_AUT_TC_TD_TCCUO_ = string.Empty;
			row.CUPON_TC_TD_TCCUO_ = string.Empty;
			row.FECHA_ACREDIT_TC_TCCUO_ = DateTime.Now;
			row.FECHA_AUT_TC_TD_TCCUO_ = DateTime.Now;
			row.LOTE_TC_TD_TCCUO_ = string.Empty;
			row.CANTIDAD_CUOTAS_TCCUO_ = short.MinValue;
			row.CTA_BANCARIA_CHE_T_C_DT_D_DP_ = string.Empty;
			row.LIBRADOR_CHE_T_DT_ = string.Empty;
			row.SUCURSAL_CHE_T_C_DT_D_DP_ = string.Empty;
			row.FECHA_PAGO_CHE_T_DT_ = DateTime.Now;
			row.FECHA_RECEP_CHE_T_C_DT_D_ = DateTime.Now;
			row.TIPO_RETENCION_RET_ = string.Empty;
			row.FECHA_INGRESO_RET_= DateTime.Now;
			row.FECHA_COMP_RET_ = DateTime.Now;
			row.NROBOLETA_CHE_T_C_DT_D_ = string.Empty;
			row.FECHAINGBANCO_CHE_T_C_DT_D_ = DateTime.Now;
			row.CODIGO10_TC_TD_TCCUO_ = string.Empty;
			row.DESTINATARIO_CHE_DP_=string.Empty;
			row.CRUZADO_CHE_T_C_DT_D_DP_=false;
			row.SELLADO_CHE_T_C_DT_D_DP_=false;
			row.IDBANCO_CHE_DP_ = string.Empty;
			row.BANCO_CHE_DP_ = string.Empty;
			row.IDDESTINATARIO_CHE_DP_ = string.Empty;
			
				
			return row;
		}

		/// <summary>
		/// Envia los cambios del tfi_ValoresDatosAuxiliaresRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_ValoresDatosAuxiliaresDataset.tfi_ValoresDatosAuxiliaresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );

			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}

		/// <summary>
		/// Envia los cambios del tfi_ValoresDatosAuxiliaresRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_ValoresDatosAuxiliaresDataset.tfi_ValoresDatosAuxiliaresRow )row );
		}

		/// <summary>
		/// Envia los cambios del tfi_ValoresDatosAuxiliaresRow a la base de datos.
		/// </summary>
		public static void Update( tfi_ValoresDatosAuxiliaresDataset.tfi_ValoresDatosAuxiliaresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );

			mz.erp.dataaccess.tfi_ValoresDatosAuxiliares.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tfi_ValoresDatosAuxiliaresDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_ValoresDatosAuxiliaresDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_ValoresDatosAuxiliares.Rows.Count > 0, "La tabla dataSet.tfi_ValoresDatosAuxiliaresDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );

			mz.erp.dataaccess.tfi_ValoresDatosAuxiliares.Update( dataSet );
		}

		/// <summary>
		/// Envia los cambios del tfi_ValoresDatosAuxiliaresDataset.tfi_ValoresDatosAuxiliaresDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_ValoresDatosAuxiliaresDataset.tfi_ValoresDatosAuxiliaresDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );

			mz.erp.dataaccess.tfi_ValoresDatosAuxiliares.Update( dataTable );
		}

		/// <summary>
		/// Valida un tfi_ValoresDatosAuxiliaresRow.
		/// </summary>
		public static bool RowIsValid( tfi_ValoresDatosAuxiliaresDataset.tfi_ValoresDatosAuxiliaresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;


			if ( !IdValorIsValid( row.IdValor, out mensaje) )
			{
				row.SetColumnError( "IdValor" , mensaje);
				isValid=false;

			}

			if ( !CODIGO_AUT_TC_TD_TCCUO_IsValid( row.CODIGO_AUT_TC_TD_TCCUO_, out mensaje) )
			{
				row.SetColumnError( "CODIGO_AUT_TC_TD_TCCUO_" , mensaje);
				isValid=false;

			}

			if ( !CUPON_TC_TD_TCCUO_IsValid( row.CUPON_TC_TD_TCCUO_, out mensaje) )
			{
				row.SetColumnError( "CUPON_TC_TD_TCCUO_" , mensaje);
				isValid=false;

			}

			if ( !FECHA_ACREDIT_TC_TCCUO_IsValid( row.FECHA_ACREDIT_TC_TCCUO_, out mensaje) )
			{
				row.SetColumnError( "FECHA_ACREDIT_TC_TCCUO_" , mensaje);
				isValid=false;

			}

			if ( !FECHA_AUT_TC_TD_TCCUO_IsValid( row.FECHA_AUT_TC_TD_TCCUO_, out mensaje) )
			{
				row.SetColumnError( "FECHA_AUT_TC_TD_TCCUO_" , mensaje);
				isValid=false;

			}

			if ( !LOTE_TC_TD_TCCUO_IsValid( row.LOTE_TC_TD_TCCUO_, out mensaje) )
			{
				row.SetColumnError( "LOTE_TC_TD_TCCUO_" , mensaje);
				isValid=false;

			}

			if ( !CANTIDAD_CUOTAS_TCCUO_IsValid( row.CANTIDAD_CUOTAS_TCCUO_, out mensaje) )
			{
				row.SetColumnError( "CANTIDAD_CUOTAS_TCCUO_" , mensaje);
				isValid=false;

			}

			if ( !CTA_BANCARIA_CHE_T_C_DT_D_IsValid( row.CTA_BANCARIA_CHE_T_C_DT_D_DP_, out mensaje) )
			{
				row.SetColumnError( "CTA_BANCARIA_CHE_T_C_DT_D_" , mensaje);
				isValid=false;

			}

			if ( !LIBRADOR_CHE_T_DT_IsValid( row.LIBRADOR_CHE_T_DT_, out mensaje) )
			{
				row.SetColumnError( "LIBRADOR_CHE_T_DT_" , mensaje);
				isValid=false;

			}

			if ( !SUCURSAL_CHE_T_C_DT_D_IsValid( row.SUCURSAL_CHE_T_C_DT_D_DP_, out mensaje) )
			{
				row.SetColumnError( "SUCURSAL_CHE_T_C_DT_D_" , mensaje);
				isValid=false;

			}

			if ( !FECHA_PAGO_CHE_T_DT_IsValid( row.FECHA_PAGO_CHE_T_DT_, out mensaje) )
			{
				row.SetColumnError( "FECHA_PAGO_CHE_T_DT_" , mensaje);
				isValid=false;

			}

			if ( !FECHA_RECEP_CHE_T_C_DT_D_IsValid( row.FECHA_RECEP_CHE_T_C_DT_D_, out mensaje) )
			{
				row.SetColumnError( "FECHA_RECEP_CHE_T_C_DT_D_" , mensaje);
				isValid=false;

			}
			if ( !NROBOLETA_CHE_T_C_DT_D_IsValid( row.NROBOLETA_CHE_T_C_DT_D_, out mensaje) )
			{
				row.SetColumnError( "NROBOLETA_CHE_T_C_DT_D_" , mensaje);
				isValid=false;

			}
			if ( !FECHAINGBANCO_CHE_T_C_DT_D_IsValid( row.FECHAINGBANCO_CHE_T_C_DT_D_, out mensaje) )
			{
				row.SetColumnError( "FECHAINGBANCO_CHE_T_C_DT_D_" , mensaje);
				isValid=false;
			}
			if ( !CODIGO10_TC_TD_TCCUO_IsValid( row.CODIGO10_TC_TD_TCCUO_, out mensaje) )
			{
				row.SetColumnError( "CODIGO10_TC_TD_TCCUO_" , mensaje);
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
		/// Valida el campo CODIGO_AUT_TC_TD_TCCUO_.
		/// </summary>
		public static bool CODIGO_AUT_TC_TD_TCCUO_IsValid( string CODIGO_AUT_TC_TD_TCCUO_ , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}

		/// <summary>
		/// Valida el campo CODIGO_AUT_TC_TD_TCCUO_. Metodo Sobrecargado
		/// </summary>
		public static bool CODIGO_AUT_TC_TD_TCCUO_IsValid( string CODIGO_AUT_TC_TD_TCCUO_)
		{
			string mensaje;
			return CODIGO_AUT_TC_TD_TCCUO_IsValid( CODIGO_AUT_TC_TD_TCCUO_, out mensaje );
		}

		/// <summary>
		/// Valida el campo CUPON_TC_TD_TCCUO_.
		/// </summary>
		public static bool CUPON_TC_TD_TCCUO_IsValid( string CUPON_TC_TD_TCCUO_ , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}

		/// <summary>
		/// Valida el campo CUPON_TC_TD_TCCUO_. Metodo Sobrecargado
		/// </summary>
		public static bool CUPON_TC_TD_TCCUO_IsValid( string CUPON_TC_TD_TCCUO_)
		{
			string mensaje;
			return CUPON_TC_TD_TCCUO_IsValid( CUPON_TC_TD_TCCUO_, out mensaje );
		}

		/// <summary>
		/// Valida el campo FECHA_ACREDIT_TC_TCCUO_.
		/// </summary>
		public static bool FECHA_ACREDIT_TC_TCCUO_IsValid( DateTime FECHA_ACREDIT_TC_TCCUO_ , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}

		/// <summary>
		/// Valida el campo FECHA_ACREDIT_TC_TCCUO_. Metodo Sobrecargado
		/// </summary>
		public static bool FECHA_ACREDIT_TC_TCCUO_IsValid( DateTime FECHA_ACREDIT_TC_TCCUO_)
		{
			string mensaje;
			return FECHA_ACREDIT_TC_TCCUO_IsValid( FECHA_ACREDIT_TC_TCCUO_, out mensaje );
		}

		/// <summary>
		/// Valida el campo FECHA_AUT_TC_TD_TCCUO_.
		/// </summary>
		public static bool FECHA_AUT_TC_TD_TCCUO_IsValid( DateTime FECHA_AUT_TC_TD_TCCUO_ , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}

		/// <summary>
		/// Valida el campo FECHA_AUT_TC_TD_TCCUO_. Metodo Sobrecargado
		/// </summary>
		public static bool FECHA_AUT_TC_TD_TCCUO_IsValid( DateTime FECHA_AUT_TC_TD_TCCUO_)
		{
			string mensaje;
			return FECHA_AUT_TC_TD_TCCUO_IsValid( FECHA_AUT_TC_TD_TCCUO_, out mensaje );
		}

		/// <summary>
		/// Valida el campo LOTE_TC_TD_TCCUO_.
		/// </summary>
		public static bool LOTE_TC_TD_TCCUO_IsValid( string LOTE_TC_TD_TCCUO_ , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}

		/// <summary>
		/// Valida el campo LOTE_TC_TD_TCCUO_. Metodo Sobrecargado
		/// </summary>
		public static bool LOTE_TC_TD_TCCUO_IsValid( string LOTE_TC_TD_TCCUO_)
		{
			string mensaje;
			return LOTE_TC_TD_TCCUO_IsValid( LOTE_TC_TD_TCCUO_, out mensaje );
		}

		/// <summary>
		/// Valida el campo CANTIDAD_CUOTAS_TCCUO_.
		/// </summary>
		public static bool CANTIDAD_CUOTAS_TCCUO_IsValid( short CANTIDAD_CUOTAS_TCCUO_ , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}

		/// <summary>
		/// Valida el campo CANTIDAD_CUOTAS_TCCUO_. Metodo Sobrecargado
		/// </summary>
		public static bool CANTIDAD_CUOTAS_TCCUO_IsValid( short CANTIDAD_CUOTAS_TCCUO_)
		{
			string mensaje;
			return CANTIDAD_CUOTAS_TCCUO_IsValid( CANTIDAD_CUOTAS_TCCUO_, out mensaje );
		}

		/// <summary>
		/// Valida el campo CTA_BANCARIA_CHE_T_C_DT_D_.
		/// </summary>
		public static bool CTA_BANCARIA_CHE_T_C_DT_D_IsValid( string CTA_BANCARIA_CHE_T_C_DT_D_ , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}

		/// <summary>
		/// Valida el campo CTA_BANCARIA_CHE_T_C_DT_D_. Metodo Sobrecargado
		/// </summary>
		public static bool CTA_BANCARIA_CHE_T_C_DT_D_IsValid( string CTA_BANCARIA_CHE_T_C_DT_D_)
		{
			string mensaje;
			return CTA_BANCARIA_CHE_T_C_DT_D_IsValid( CTA_BANCARIA_CHE_T_C_DT_D_, out mensaje );
		}

		/// <summary>
		/// Valida el campo LIBRADOR_CHE_T_DT_.
		/// </summary>
		public static bool LIBRADOR_CHE_T_DT_IsValid( string LIBRADOR_CHE_T_DT_ , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}

		/// <summary>
		/// Valida el campo LIBRADOR_CHE_T_DT_. Metodo Sobrecargado
		/// </summary>
		public static bool LIBRADOR_CHE_T_DT_IsValid( string LIBRADOR_CHE_T_DT_)
		{
			string mensaje;
			return LIBRADOR_CHE_T_DT_IsValid( LIBRADOR_CHE_T_DT_, out mensaje );
		}

		/// <summary>
		/// Valida el campo SUCURSAL_CHE_T_C_DT_D_.
		/// </summary>
		public static bool SUCURSAL_CHE_T_C_DT_D_IsValid( string SUCURSAL_CHE_T_C_DT_D_ , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}

		/// <summary>
		/// Valida el campo SUCURSAL_CHE_T_C_DT_D_. Metodo Sobrecargado
		/// </summary>
		public static bool SUCURSAL_CHE_T_C_DT_D_IsValid( string SUCURSAL_CHE_T_C_DT_D_)
		{
			string mensaje;
			return SUCURSAL_CHE_T_C_DT_D_IsValid( SUCURSAL_CHE_T_C_DT_D_, out mensaje );
		}

		/// <summary>
		/// Valida el campo FECHA_PAGO_CHE_T_DT_.
		/// </summary>
		public static bool FECHA_PAGO_CHE_T_DT_IsValid( DateTime FECHA_PAGO_CHE_T_DT_ , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}

		/// <summary>
		/// Valida el campo FECHA_PAGO_CHE_T_DT_. Metodo Sobrecargado
		/// </summary>
		public static bool FECHA_PAGO_CHE_T_DT_IsValid( DateTime FECHA_PAGO_CHE_T_DT_)
		{
			string mensaje;
			return FECHA_PAGO_CHE_T_DT_IsValid( FECHA_PAGO_CHE_T_DT_, out mensaje );
		}

		/// <summary>
		/// Valida el campo FECHA_RECEP_CHE_T_C_DT_D_.
		/// </summary>
		public static bool FECHA_RECEP_CHE_T_C_DT_D_IsValid( DateTime FECHA_RECEP_CHE_T_C_DT_D_ , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}

		/// <summary>
		/// Valida el campo FECHA_RECEP_CHE_T_C_DT_D_. Metodo Sobrecargado
		/// </summary>
		public static bool FECHA_RECEP_CHE_T_C_DT_D_IsValid( DateTime FECHA_RECEP_CHE_T_C_DT_D_)
		{
			string mensaje;
			return FECHA_RECEP_CHE_T_C_DT_D_IsValid( FECHA_RECEP_CHE_T_C_DT_D_, out mensaje );
		}

		public static bool NROBOLETA_CHE_T_C_DT_D_IsValid( string NROBOLETA_CHE_T_C_DT_D_ , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		public static bool NROBOLETA_CHE_T_C_DT_D_IsValid( string NROBOLETA_CHE_T_C_DT_D_ )
		{
			string mensaje;
			return NROBOLETA_CHE_T_C_DT_D_IsValid( NROBOLETA_CHE_T_C_DT_D_, out mensaje);
		}


		public static bool FECHAINGBANCO_CHE_T_C_DT_D_IsValid( DateTime FECHAINGBANCO_CHE_T_C_DT_D_ , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		public static bool FECHAINGBANCO_CHE_T_C_DT_D_IsValid( DateTime FECHAINGBANCO_CHE_T_C_DT_D_ )
		{
			string mensaje;
			return FECHAINGBANCO_CHE_T_C_DT_D_IsValid( FECHAINGBANCO_CHE_T_C_DT_D_, out mensaje);
		}

		public static bool CODIGO10_TC_TD_TCCUO_IsValid( string CODIGO10_TC_TD_TCCUO_ , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		public static bool CODIGO10_TC_TD_TCCUO_IsValid( string CODIGO10_TC_TD_TCCUO_ )
		{
			string mensaje;
			return CODIGO10_TC_TD_TCCUO_IsValid( CODIGO10_TC_TD_TCCUO_, out mensaje);
		}

		

		public void Dispose()
		{
		}

	}
}



