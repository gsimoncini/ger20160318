using System;
using System.Data;
using System.Collections;


using System.Data.SqlClient;
using System.Text.RegularExpressions;
    
using mz.erp.dbhelper;
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;


namespace mz.erp.dataaccess.reportes
{
	/// <summary>
	/// Descripción breve de GenericReports.
	/// </summary>
	public class GenericReports
	{
		public GenericReports()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		
		/*---------------------------------- CONSULTAS DE CAJA --------------------------------------*/
		public static System.Data.DataSet GetConsultasCobranzasYPagos( string IdCaja, System.DateTime fechaApertura, System.DateTime fechaCierre, string IdResponsable, string IdTipo, string EstadoCajas)
		{
			System.Data.DataSet data = new DataSet();
			try
			{
				SqlDataAdapter adapter = new SqlDataAdapter();

				SqlCommand cmd = new SqlCommand( "Pr_tfi_Cajas_CobranzasYPagos", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);
			
				cmd.Parameters.Add( new SqlParameter( "@IdCaja", SqlDbType.VarChar));
				cmd.Parameters["@IdCaja"].Value = IdCaja;

				cmd.Parameters.Add( new SqlParameter( "@fechaApertura", SqlDbType.DateTime ) );
				if (fechaApertura.Equals( DateTime.MinValue ) )
				{
					cmd.Parameters["@FechaApertura"].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters["@FechaApertura"].Value = fechaApertura;
				}
				cmd.Parameters.Add( new SqlParameter( "@FechaCierre", SqlDbType.DateTime ) );
				if (fechaCierre.Equals( DateTime.MinValue ))
				{
					cmd.Parameters["@FechaCierre"].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters["@FechaCierre"].Value = fechaCierre;
				}

				cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar));
				cmd.Parameters["@IdResponsable"].Value = IdResponsable;

				cmd.Parameters.Add( new SqlParameter( "@IdTipoDeMovimiento", SqlDbType.VarChar));
				cmd.Parameters["@IdTipoDeMovimiento"].Value = IdTipo;

				cmd.Parameters.Add( new SqlParameter( "@EstadoCajas", SqlDbType.VarChar));
				cmd.Parameters["@EstadoCajas"].Value = EstadoCajas;

				adapter.SelectCommand = cmd;
				adapter.Fill( data, "Result" );
			}
			catch (	Exception e){System.Console.WriteLine(e.ToString() );}
			return data;
		}
		
		public static System.Data.DataSet GetConsultasCobranzasYPagosAbiertas( string IdCaja, System.DateTime fechaApertura, System.DateTime fechaCierre, string IdResponsable, string IdTipo, string EstadoCajas)
		{
			System.Data.DataSet data = new DataSet();
			try
			{
				SqlDataAdapter adapter = new SqlDataAdapter();

				SqlCommand cmd = new SqlCommand( "Pr_tfi_Cajas_CobranzasYPagosAbierta", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);
			
				cmd.Parameters.Add( new SqlParameter( "@IdCaja", SqlDbType.VarChar));
				cmd.Parameters["@IdCaja"].Value = IdCaja;

				cmd.Parameters.Add( new SqlParameter( "@fechaApertura", SqlDbType.DateTime ) );
				if (fechaApertura.Equals( DateTime.MinValue ) )
				{
					cmd.Parameters["@FechaApertura"].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters["@FechaApertura"].Value = fechaApertura;
				}
				cmd.Parameters.Add( new SqlParameter( "@FechaCierre", SqlDbType.DateTime ) );
				if (fechaCierre.Equals( DateTime.MinValue ))
				{
					cmd.Parameters["@FechaCierre"].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters["@FechaCierre"].Value = fechaCierre;
				}

				cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar));
				cmd.Parameters["@IdResponsable"].Value = IdResponsable;

				cmd.Parameters.Add( new SqlParameter( "@IdTipoDeMovimiento", SqlDbType.VarChar));
				cmd.Parameters["@IdTipoDeMovimiento"].Value = IdTipo;

				cmd.Parameters.Add( new SqlParameter( "@EstadoCajas", SqlDbType.VarChar));
				cmd.Parameters["@EstadoCajas"].Value = EstadoCajas;

				adapter.SelectCommand = cmd;
				adapter.Fill( data, "Result" );
			}
			catch (	Exception e){System.Console.WriteLine(e.ToString() );}
			return data;
		}
		
		public static System.Data.DataSet GetConsultasCobranzasYPagosCerradas( string IdCaja, System.DateTime fechaApertura, System.DateTime fechaCierre, string IdResponsable, string IdTipo, string EstadoCajas)
		{
			System.Data.DataSet data = new DataSet();
			try
			{
				SqlDataAdapter adapter = new SqlDataAdapter();

				SqlCommand cmd = new SqlCommand( "Pr_tfi_Cajas_CobranzasYPagosCerrada", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);
			
				cmd.Parameters.Add( new SqlParameter( "@IdCaja", SqlDbType.VarChar));
				cmd.Parameters["@IdCaja"].Value = IdCaja;

				cmd.Parameters.Add( new SqlParameter( "@fechaApertura", SqlDbType.DateTime ) );
				if (fechaApertura.Equals( DateTime.MinValue ) )
				{
					cmd.Parameters["@FechaApertura"].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters["@FechaApertura"].Value = fechaApertura;
				}
				cmd.Parameters.Add( new SqlParameter( "@FechaCierre", SqlDbType.DateTime ) );
				if (fechaCierre.Equals( DateTime.MinValue ))
				{
					cmd.Parameters["@FechaCierre"].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters["@FechaCierre"].Value = fechaCierre;
				}

				cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar));
				cmd.Parameters["@IdResponsable"].Value = IdResponsable;

				cmd.Parameters.Add( new SqlParameter( "@IdTipoDeMovimiento", SqlDbType.VarChar));
				cmd.Parameters["@IdTipoDeMovimiento"].Value = IdTipo;

				cmd.Parameters.Add( new SqlParameter( "@EstadoCajas", SqlDbType.VarChar));
				cmd.Parameters["@EstadoCajas"].Value = EstadoCajas;

				adapter.SelectCommand = cmd;
				adapter.Fill( data, "Result" );
			}
			catch (	Exception e){System.Console.WriteLine(e.ToString() );}
			return data;
		}
		
		public static System.Data.DataSet GetConsultasCobranzasYPagosAbiertasCerradas( string IdCaja, System.DateTime fechaApertura, System.DateTime fechaCierre, string IdResponsable, string IdTipo, string EstadoCajas)
		{
			System.Data.DataSet data = new DataSet();
			try
			{
				SqlDataAdapter adapter = new SqlDataAdapter();

				SqlCommand cmd = new SqlCommand( "Pr_tfi_Cajas_CobranzasYPagosAbiertaCerrada", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);
			
				cmd.Parameters.Add( new SqlParameter( "@IdCaja", SqlDbType.VarChar));
				cmd.Parameters["@IdCaja"].Value = IdCaja;

				cmd.Parameters.Add( new SqlParameter( "@fechaApertura", SqlDbType.DateTime ) );
				if (fechaApertura.Equals( DateTime.MinValue ) )
				{
					cmd.Parameters["@FechaApertura"].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters["@FechaApertura"].Value = fechaApertura;
				}
				cmd.Parameters.Add( new SqlParameter( "@FechaCierre", SqlDbType.DateTime ) );
				if (fechaCierre.Equals( DateTime.MinValue ))
				{
					cmd.Parameters["@FechaCierre"].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters["@FechaCierre"].Value = fechaCierre;
				}

				cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar));
				cmd.Parameters["@IdResponsable"].Value = IdResponsable;

				cmd.Parameters.Add( new SqlParameter( "@IdTipoDeMovimiento", SqlDbType.VarChar));
				cmd.Parameters["@IdTipoDeMovimiento"].Value = IdTipo;

				cmd.Parameters.Add( new SqlParameter( "@EstadoCajas", SqlDbType.VarChar));
				cmd.Parameters["@EstadoCajas"].Value = EstadoCajas;

				adapter.SelectCommand = cmd;
				adapter.Fill( data, "Result" );
			}
			catch (	Exception e){System.Console.WriteLine(e.ToString() );}
			return data;
		}
		
		public static System.Data.DataSet GetConsultasCobranzasYPagosFechaMovimiento( string IdCaja, System.DateTime fechaApertura, System.DateTime fechaCierre, string IdResponsable, string IdTipo, string EstadoCajas)
		{
			System.Data.DataSet data = new DataSet();
			try
			{
				SqlDataAdapter adapter = new SqlDataAdapter();

				SqlCommand cmd = new SqlCommand( "Pr_tfi_Cajas_CobranzasYPagosPorFechaMovimiento", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);
			
				cmd.Parameters.Add( new SqlParameter( "@IdCaja", SqlDbType.VarChar));
				cmd.Parameters["@IdCaja"].Value = IdCaja;

				cmd.Parameters.Add( new SqlParameter( "@fechaApertura", SqlDbType.DateTime ) );
				if (fechaApertura.Equals( DateTime.MinValue ) )
				{
					cmd.Parameters["@FechaApertura"].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters["@FechaApertura"].Value = fechaApertura;
				}
				cmd.Parameters.Add( new SqlParameter( "@FechaCierre", SqlDbType.DateTime ) );
				if (fechaCierre.Equals( DateTime.MinValue ))
				{
					cmd.Parameters["@FechaCierre"].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters["@FechaCierre"].Value = fechaCierre;
				}

				cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar));
				cmd.Parameters["@IdResponsable"].Value = IdResponsable;

				cmd.Parameters.Add( new SqlParameter( "@IdTipoDeMovimiento", SqlDbType.VarChar));
				cmd.Parameters["@IdTipoDeMovimiento"].Value = IdTipo;

				//cmd.Parameters.Add( new SqlParameter( "@EstadoCajas", SqlDbType.VarChar));
				//cmd.Parameters["@EstadoCajas"].Value = EstadoCajas;

				adapter.SelectCommand = cmd;
				adapter.Fill( data, "Result" );
			}
			catch (	Exception e){System.Console.WriteLine(e.ToString() );}
			return data;
		}
		
		public static System.Data.DataSet GetMovimientosDeCajaPosterioresA(System.DateTime fechaUltimoControlDeCaja, string IdInstanciaCaja)
		{
			System.Data.DataSet data = new DataSet();
			try
			{
				SqlDataAdapter adapter = new SqlDataAdapter();

				SqlCommand cmd = new SqlCommand( "Pr_tfi_Cajas_MovimientosDeCajaPosterioresA", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
		
				cmd.Parameters.Add( new SqlParameter( "@Fecha", SqlDbType.DateTime ) );
				if (fechaUltimoControlDeCaja.Equals( DateTime.MinValue ) )
				{
					cmd.Parameters["@Fecha"].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters["@Fecha"].Value = fechaUltimoControlDeCaja;
				}

				cmd.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar));
				cmd.Parameters["@IdInstanciaCaja"].Value = IdInstanciaCaja;
				
				adapter.SelectCommand = cmd;
				adapter.Fill( data, "Result" );
			}
			catch (	Exception e){System.Console.WriteLine(e.ToString() );}
			return data;
		}

		
		public static System.Data.DataSet GetConsultasMovimientosDeCaja( string IdCaja, System.DateTime fechaApertura, System.DateTime fechaCierre, string IdResponsable, string IdTipo, string EstadoCajas)
		{
			System.Data.DataSet data = new DataSet();
			try
			{
			SqlDataAdapter adapter = new SqlDataAdapter();

			SqlCommand cmd = new SqlCommand( "Pr_tfi_Cajas_MovimientosDeCaja", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
		
			cmd.Parameters.Add( new SqlParameter( "@IdCaja", SqlDbType.VarChar));
			cmd.Parameters["@IdCaja"].Value = IdCaja;

			cmd.Parameters.Add( new SqlParameter( "@fechaApertura", SqlDbType.DateTime ) );
			if (fechaApertura.Equals( DateTime.MinValue ) )
			{
				cmd.Parameters["@FechaApertura"].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters["@FechaApertura"].Value = fechaApertura;
			}
			cmd.Parameters.Add( new SqlParameter( "@FechaCierre", SqlDbType.DateTime ) );
			if (fechaCierre.Equals( DateTime.MinValue ))
			{
				cmd.Parameters["@FechaCierre"].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters["@FechaCierre"].Value = fechaCierre;
			}

			cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar));
			cmd.Parameters["@IdResponsable"].Value = IdResponsable;

			cmd.Parameters.Add( new SqlParameter( "@IdTipoDeMovimiento", SqlDbType.VarChar));
			cmd.Parameters["@IdTipoDeMovimiento"].Value = IdTipo;

			cmd.Parameters.Add( new SqlParameter( "@EstadoCajas", SqlDbType.VarChar));
			cmd.Parameters["@EstadoCajas"].Value = EstadoCajas;

			adapter.SelectCommand = cmd;
			adapter.Fill( data, "Result" );
			}
			catch (	Exception e){System.Console.WriteLine(e.ToString() );}
			return data;
		}

		public static decimal GetTotalPorComprobanteTesoreria(string IdMonedaReferencia,string IdTDCompTesoreria,string IdMoneda ,string IdInstanciaCaja)
		{
			System.Data.DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();

			SqlCommand cmd = new SqlCommand( "Pr_tfi_Cajas_GetTotalComprobanteTesoreria", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);
		
			cmd.Parameters.Add( new SqlParameter( "@IdMonedaReferencia", SqlDbType.VarChar));
			cmd.Parameters["@IdMonedaReferencia"].Value = IdMonedaReferencia;

			cmd.Parameters.Add( new SqlParameter( "@IdTDCompTesoreria", SqlDbType.VarChar));
			cmd.Parameters["@IdTDCompTesoreria"].Value = IdTDCompTesoreria;

			cmd.Parameters.Add( new SqlParameter( "@IdMoneda", SqlDbType.VarChar));
			cmd.Parameters["@IdMoneda"].Value = IdMoneda;

			
			cmd.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar));
			cmd.Parameters["@IdInstanciaCaja"].Value = IdInstanciaCaja;

			adapter.SelectCommand = cmd;
			adapter.Fill(data, "Result");

			return Convert.ToDecimal(data.Tables[0].Rows[0][0]);
		}

		public static System.Data.DataSet GetConsultaDeCajaDetallado(string IdMonedaReferencia, string IdEntidades, string IdTDCompTesoreria, System.DateTime FechaDesde, System.DateTime FechaHasta,string IdPersona, string Estado, string IdCajas, string EstadoCajas)
		{

			System.Data.DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();

			SqlCommand cmd = new SqlCommand( "Pr_tfi_Cajas_ConsultaTDCompTesoreria", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);
		
			cmd.Parameters.Add( new SqlParameter( "@IdMonedaReferencia", SqlDbType.VarChar));
			cmd.Parameters["@IdMonedaReferencia"].Value = IdMonedaReferencia;

			cmd.Parameters.Add( new SqlParameter( "@IdEntidades", SqlDbType.VarChar));
			cmd.Parameters["@IdEntidades"].Value = IdEntidades;

			cmd.Parameters.Add( new SqlParameter( "@IdTDCompTesoreria", SqlDbType.VarChar));
			cmd.Parameters["@IdTDCompTesoreria"].Value = IdTDCompTesoreria;

			cmd.Parameters.Add( new SqlParameter( "@FechaDesde", SqlDbType.DateTime));
			if (FechaDesde.Equals( DateTime.MinValue ) )
			{
				cmd.Parameters["@FechaDesde"].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters["@FechaDesde"].Value = FechaDesde;
			}

			cmd.Parameters.Add( new SqlParameter( "@FechaHasta", SqlDbType.DateTime));
			if (FechaHasta.Equals( DateTime.MinValue ) )
			{
				cmd.Parameters["@FechaHasta"].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters["@FechaHasta"].Value = FechaHasta;
			}

			cmd.Parameters.Add( new SqlParameter( "@IdPersona", SqlDbType.VarChar));
			cmd.Parameters["@IdPersona"].Value = IdPersona;

			cmd.Parameters.Add( new SqlParameter( "@Estado", SqlDbType.VarChar));
			cmd.Parameters["@Estado"].Value = Estado;

			cmd.Parameters.Add( new SqlParameter( "@IdCajas", SqlDbType.VarChar));
			cmd.Parameters["@IdCajas"].Value = IdCajas;

			cmd.Parameters.Add( new SqlParameter( "@EstadoCajas", SqlDbType.VarChar));
			cmd.Parameters["@EstadoCajas"].Value = EstadoCajas;

            adapter.SelectCommand = cmd;
			adapter.Fill( data, "Result" );

			return data;
		}
		
		
		public static System.Data.DataSet GetConsultaDeCajaDetalladoAnterior(string IdMonedaReferencia, string IdEntidades, string IdTDCompTesoreria, System.DateTime FechaDesde, System.DateTime FechaHasta,string IdPersona, string Estado, string IdCajas, string EstadoCajas)
		{

			System.Data.DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();

			SqlCommand cmd = new SqlCommand( "Pr_tfi_Cajas_ConsultaTDCompTesoreriaAnterior", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);
		
			cmd.Parameters.Add( new SqlParameter( "@IdMonedaReferencia", SqlDbType.VarChar));
			cmd.Parameters["@IdMonedaReferencia"].Value = IdMonedaReferencia;

			cmd.Parameters.Add( new SqlParameter( "@IdEntidades", SqlDbType.VarChar));
			cmd.Parameters["@IdEntidades"].Value = IdEntidades;

			cmd.Parameters.Add( new SqlParameter( "@IdTDCompTesoreria", SqlDbType.VarChar));
			cmd.Parameters["@IdTDCompTesoreria"].Value = IdTDCompTesoreria;

			cmd.Parameters.Add( new SqlParameter( "@FechaDesde", SqlDbType.DateTime));
			if (FechaDesde.Equals( DateTime.MinValue ) )
			{
				cmd.Parameters["@FechaDesde"].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters["@FechaDesde"].Value = FechaDesde;
			}

			cmd.Parameters.Add( new SqlParameter( "@FechaHasta", SqlDbType.DateTime));
			if (FechaHasta.Equals( DateTime.MinValue ) )
			{
				cmd.Parameters["@FechaHasta"].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters["@FechaHasta"].Value = FechaHasta;
			}

			cmd.Parameters.Add( new SqlParameter( "@IdPersona", SqlDbType.VarChar));
			cmd.Parameters["@IdPersona"].Value = IdPersona;

			cmd.Parameters.Add( new SqlParameter( "@Estado", SqlDbType.VarChar));
			cmd.Parameters["@Estado"].Value = Estado;

			cmd.Parameters.Add( new SqlParameter( "@IdCajas", SqlDbType.VarChar));
			cmd.Parameters["@IdCajas"].Value = IdCajas;

			cmd.Parameters.Add( new SqlParameter( "@EstadoCajas", SqlDbType.VarChar));
			cmd.Parameters["@EstadoCajas"].Value = EstadoCajas;

			adapter.SelectCommand = cmd;
			adapter.Fill( data, "Result" );

			return data;
		}
		
		
		public static System.Data.DataSet GetConsultaDeCajaDetallado(string IdMonedaReferencia, string IdEntidades, string IdTDCompTesoreria, System.DateTime FechaDesde, System.DateTime FechaHasta,string IdPersona, string Estado, string IdCajas, string Moneda, string EstadoCajas)
		{

			System.Data.DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();

			SqlCommand cmd = new SqlCommand( "Pr_tfi_Cajas_ConsultaTDCompTesoreria", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);
		
			cmd.Parameters.Add( new SqlParameter( "@IdMonedaReferencia", SqlDbType.VarChar));
			cmd.Parameters["@IdMonedaReferencia"].Value = IdMonedaReferencia;

			cmd.Parameters.Add( new SqlParameter( "@IdEntidades", SqlDbType.VarChar));
			cmd.Parameters["@IdEntidades"].Value = IdEntidades;

			cmd.Parameters.Add( new SqlParameter( "@IdTDCompTesoreria", SqlDbType.VarChar));
			cmd.Parameters["@IdTDCompTesoreria"].Value = IdTDCompTesoreria;

			cmd.Parameters.Add( new SqlParameter( "@FechaDesde", SqlDbType.DateTime));
			if (FechaDesde.Equals( DateTime.MinValue ) )
			{
				cmd.Parameters["@FechaDesde"].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters["@FechaDesde"].Value = FechaDesde;
			}

			cmd.Parameters.Add( new SqlParameter( "@FechaHasta", SqlDbType.DateTime));
			if (FechaHasta.Equals( DateTime.MinValue ) )
			{
				cmd.Parameters["@FechaHasta"].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters["@FechaHasta"].Value = FechaHasta;
			}

			cmd.Parameters.Add( new SqlParameter( "@IdPersona", SqlDbType.VarChar));
			cmd.Parameters["@IdPersona"].Value = IdPersona;

			cmd.Parameters.Add( new SqlParameter( "@Estado", SqlDbType.VarChar));
			cmd.Parameters["@Estado"].Value = Estado;

			cmd.Parameters.Add( new SqlParameter( "@IdCajas", SqlDbType.VarChar));
			cmd.Parameters["@IdCajas"].Value = IdCajas;
	
			cmd.Parameters.Add( new SqlParameter( "@Moneda", SqlDbType.VarChar));
			cmd.Parameters["@Moneda"].Value = Moneda;

			cmd.Parameters.Add( new SqlParameter( "@EstadoCajas", SqlDbType.VarChar));
			cmd.Parameters["@EstadoCajas"].Value = EstadoCajas;

			adapter.SelectCommand = cmd;
			adapter.Fill( data, "Result" );

			return data;
		}

		public static System.Data.DataSet GetConsultaDeCajaAnterior( string IdCaja, System.DateTime fechaApertura, System.DateTime fechaCierre, string IdResponsable, string IdTipo, string EstadoCajas)
		{
			System.Data.DataSet data = new DataSet();
			try
			{
				SqlDataAdapter adapter = new SqlDataAdapter();

				SqlCommand cmd = new SqlCommand( "pr_tfi_Cajas_PosicionDeCajaAnterior", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
			
				cmd.Parameters.Add( new SqlParameter( "@IdCaja", SqlDbType.VarChar));
				cmd.Parameters["@IdCaja"].Value = IdCaja;

				cmd.Parameters.Add( new SqlParameter( "@fechaApertura", SqlDbType.DateTime ) );
				if (fechaApertura.Equals( DateTime.MinValue ) )
				{
					cmd.Parameters["@FechaApertura"].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters["@FechaApertura"].Value = fechaApertura;
				}
				cmd.Parameters.Add( new SqlParameter( "@FechaCierre", SqlDbType.DateTime ) );
				if (fechaCierre.Equals( DateTime.MinValue ))
				{
					cmd.Parameters["@FechaCierre"].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters["@FechaCierre"].Value = fechaCierre;
				}

				cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar));
				cmd.Parameters["@IdResponsable"].Value = IdResponsable;

				cmd.Parameters.Add( new SqlParameter( "@IdTipoDeMovimiento", SqlDbType.VarChar));
				cmd.Parameters["@IdTipoDeMovimiento"].Value = IdTipo;

				cmd.Parameters.Add( new SqlParameter( "@EstadoCajas", SqlDbType.VarChar));
				cmd.Parameters["@EstadoCajas"].Value = EstadoCajas;

				adapter.SelectCommand = cmd;
				adapter.Fill( data, "Result" );
			}
			catch (	Exception e){System.Console.WriteLine(e.ToString() );}
			return data;
		}


		
		public static System.Data.DataSet GetConsultaDeCaja( string IdCaja, System.DateTime fechaApertura, System.DateTime fechaCierre, string IdResponsable, string IdTipo, string EstadoCajas)
		{
			System.Data.DataSet data = new DataSet();
			try
			{
				SqlDataAdapter adapter = new SqlDataAdapter();

				SqlCommand cmd = new SqlCommand( "pr_tfi_Cajas_PosicionDeCaja", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
			
				cmd.Parameters.Add( new SqlParameter( "@IdCaja", SqlDbType.VarChar));
				cmd.Parameters["@IdCaja"].Value = IdCaja;

				cmd.Parameters.Add( new SqlParameter( "@fechaApertura", SqlDbType.DateTime ) );
				if (fechaApertura.Equals( DateTime.MinValue ) )
				{
					cmd.Parameters["@FechaApertura"].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters["@FechaApertura"].Value = fechaApertura;
				}
				cmd.Parameters.Add( new SqlParameter( "@FechaCierre", SqlDbType.DateTime ) );
				if (fechaCierre.Equals( DateTime.MinValue ))
				{
					cmd.Parameters["@FechaCierre"].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters["@FechaCierre"].Value = fechaCierre;
				}

				cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar));
				cmd.Parameters["@IdResponsable"].Value = IdResponsable;

				cmd.Parameters.Add( new SqlParameter( "@IdTipoDeMovimiento", SqlDbType.VarChar));
				cmd.Parameters["@IdTipoDeMovimiento"].Value = IdTipo;

				cmd.Parameters.Add( new SqlParameter( "@EstadoCajas", SqlDbType.VarChar));
				cmd.Parameters["@EstadoCajas"].Value = EstadoCajas;

				adapter.SelectCommand = cmd;
				adapter.Fill( data, "Result" );
			}
			catch (	Exception e){System.Console.WriteLine(e.ToString() );}
			return data;
		}

		public static System.Data.DataSet GetConsultaDeValoresCajasAnterior(string IdTDCompTesoreria, string IdInstanciaCaja)
		{
			System.Data.DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();

			SqlCommand cmd = new SqlCommand( "Pr_tfi_Cajas_ConsultarValoresCajasAnterior", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);

			cmd.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar));
			cmd.Parameters["@IdInstanciaCaja"].Value = IdInstanciaCaja;
			cmd.Parameters.Add( new SqlParameter( "@IdTDCompTesoreria", SqlDbType.VarChar));
			if(IdTDCompTesoreria != null && !IdTDCompTesoreria.Equals(string.Empty))
				cmd.Parameters["@IdTDCompTesoreria"].Value = IdTDCompTesoreria;
			else cmd.Parameters["@IdTDCompTesoreria"].Value = System.DBNull.Value;
			cmd.CommandTimeout = 120;
			adapter.SelectCommand = cmd;
			adapter.Fill( data, "Result" );

			return data;
		}

		public static System.Data.DataSet GetConsultaDeValoresCajas(string IdTDCompTesoreria, string IdInstanciaCaja)
		{
			System.Data.DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();

			SqlCommand cmd = new SqlCommand( "Pr_tfi_Cajas_ConsultarValoresCajas", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);

			cmd.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar));
			if(IdInstanciaCaja != null && !IdInstanciaCaja.Equals(string.Empty))
				cmd.Parameters["@IdInstanciaCaja"].Value = IdInstanciaCaja;
			else cmd.Parameters["@IdInstanciaCaja"].Value = System.DBNull.Value;
			
			cmd.Parameters.Add( new SqlParameter( "@IdTDCompTesoreria", SqlDbType.VarChar));
			if(IdTDCompTesoreria != null && !IdTDCompTesoreria.Equals(string.Empty))
				cmd.Parameters["@IdTDCompTesoreria"].Value = IdTDCompTesoreria;
			else cmd.Parameters["@IdTDCompTesoreria"].Value = System.DBNull.Value;
			
			cmd.CommandTimeout = 120;
			adapter.SelectCommand = cmd;
			adapter.Fill( data, "Result" );

			return data;
		}

		public static System.Data.DataSet GetConsultaDeGastos( string IdCaja, System.DateTime fechaApertura, System.DateTime fechaCierre, string IdTipo)
		{
			System.Data.DataSet data = new DataSet();
			try
			{
				SqlDataAdapter adapter = new SqlDataAdapter();

				SqlCommand cmd = new SqlCommand( "Pr_tfi_MovimientosDeCaja_ListadoDeMovimientos", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);
			
				cmd.Parameters.Add( new SqlParameter( "@IdCaja", SqlDbType.VarChar));
				cmd.Parameters["@IdCaja"].Value = IdCaja;

				cmd.Parameters.Add( new SqlParameter( "@fechaDesde", SqlDbType.DateTime ) );
				if (fechaApertura.Equals( DateTime.MinValue ) )
				{
					cmd.Parameters["@FechaDesde"].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters["@FechaDesde"].Value =mz.erp.systemframework.Util.GetStartDay(fechaApertura);
				}
				cmd.Parameters.Add( new SqlParameter( "@FechaHasta", SqlDbType.DateTime ) );
				if (fechaCierre.Equals( DateTime.MinValue ))
				{
					cmd.Parameters["@FechaHasta"].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters["@FechaHasta"].Value = mz.erp.systemframework.Util.GetEndDay(fechaCierre);
				}

				

				cmd.Parameters.Add( new SqlParameter( "@IdTipoDeMovimiento", SqlDbType.VarChar));
				cmd.Parameters["@IdTipoDeMovimiento"].Value = IdTipo;

				

				adapter.SelectCommand = cmd;
				adapter.Fill( data, "Result" );
			}
			catch (	Exception e){System.Console.WriteLine(e.ToString() );}
			return data;
		}


		/*-------------------------------------------------------------------------------------------*/
	}
}
