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

	public class tcs_DomiciliosCuentas : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tcs_DomiciliosCuentas()
		{
		}

		public static ArrayList GetDomicilios( string IdCuenta )
		{
			ArrayList arrayDomicilios = new ArrayList();
			DataSet data = new tcs_DomiciliosCuentasDataset();
			//German 20100118 SP6 647
			data = mz.erp.dataaccess.tcs_DomiciliosCuentas.GetListNuevo(IdCuenta);
			//Fin German 20100118 SP6 647

			foreach( DataRow row in data.Tables[0].Rows)
			{
				mz.erp.businessrules.Domicilio domicilio = new Domicilio();
				domicilio.IdDomicilio = Convert.ToString(row["IdDomicilio"]);
				if( row["Calle"] != null ) { domicilio.Calle = row["Calle"].ToString()+ " " ; }
				if( row["Numero"] != null )  { domicilio.Numero = row["Numero"].ToString()+ " " ; }
				if( row["Telefono"] != null )  { domicilio.Telefono = row["Telefono"].ToString()+ " " ; }
				if( row["Sector"] != null )  { domicilio.Sector = row["Sector"].ToString()+ " " ; }
				if( row["Torre"] != null )  { domicilio.Torre = row["Torre"].ToString()+ " " ; }
				if( row["Piso"] != null )  { domicilio.Piso = row["Piso"].ToString()+ " " ; }
				if( row["Departamento"] != null )  { domicilio.Departamento = row["Departamento"].ToString()+ " " ; }
				if( row["Manzana"] != null )  { domicilio.Manzana = row["Manzana"].ToString()+ " " ; }
				if( row["TipoDomicilio"] != null ) { domicilio.TipoDomicilio = row["TipoDomicilio"].ToString()+ " " ; }
				if( row["Localidad"] != null ) { domicilio.Localidad = row["Localidad"].ToString()+ " " ; }

				//German 20100118 SP6 647
				if( row["IdTipoDomicilio"] != null ) { domicilio.IdTipoDomicilio = row["IdTipoDomicilio"].ToString()+ " " ; }
				//Fin German 20100118 SP6 647

				string domicilioTexto = domicilio.DomicilioTexto.Trim();
				if (!(domicilioTexto.Equals(string.Empty)))
				{
					arrayDomicilios.Add( domicilio );
				}
			}

			return arrayDomicilios;
			/*ArrayList arrayDomicilios = new ArrayList();
			tcs_DomiciliosCuentasDataset data = new tcs_DomiciliosCuentasDataset();
			data = mz.erp.dataaccess.tcs_DomiciliosCuentas.GetList( String.Empty, IdCuenta);
			if (data.tcs_DomiciliosCuentas.Rows.Count > 0)
			{
				string _domicilio = null;
				foreach (tcs_DomiciliosCuentasDataset.tcs_DomiciliosCuentasRow row in data.tcs_DomiciliosCuentas.Rows)
				{
					string IdDomicilio = row.idDomicilio;
					tcs_DomiciliosDataset data2 = dataaccess.tcs_Domicilios.GetList(IdDomicilio,null);
					mz.erp.businessrules.Domicilio domicilio = new Domicilio();
					if (data2.tcs_Domicilios.Rows.Count > 0) 
					{
						if( !(data2.tcs_Domicilios.Rows[0].IsNull("Calle") ) ) { domicilio.Calle = data2.tcs_Domicilios.Rows[0]["Calle"].ToString()+ " " ; }
						if( !(data2.tcs_Domicilios.Rows[0].IsNull("Numero") ) ) { domicilio.Numero = data2.tcs_Domicilios.Rows[0]["Numero"].ToString()+ " " ; }
						if( !(data2.tcs_Domicilios.Rows[0].IsNull("Telefono") ) ) { domicilio.Telefono = data2.tcs_Domicilios.Rows[0]["Telefono"].ToString()+ " " ; }
						if( !(data2.tcs_Domicilios.Rows[0].IsNull("Sector") ) ) { domicilio.Sector = data2.tcs_Domicilios.Rows[0]["Sector"].ToString()+ " " ; }
						if( !(data2.tcs_Domicilios.Rows[0].IsNull("Torre") ) ) { domicilio.Torre = data2.tcs_Domicilios.Rows[0]["Torre"].ToString()+ " " ; }
						if( !(data2.tcs_Domicilios.Rows[0].IsNull("Piso") ) ) { domicilio.Piso = data2.tcs_Domicilios.Rows[0]["Piso"].ToString()+ " " ; }
						if( !(data2.tcs_Domicilios.Rows[0].IsNull("Departamento") ) ) { domicilio.Departamento = data2.tcs_Domicilios.Rows[0]["Departamento"].ToString()+ " " ; }
						if( !(data2.tcs_Domicilios.Rows[0].IsNull("Manzana") ) ) { domicilio.Manzana = data2.tcs_Domicilios.Rows[0]["Manzana"].ToString()+ " " ; }
						if( !(data2.tcs_Domicilios.Rows[0].IsNull("IdLocalidad") ) )
						{
							string IdLocalidad = data2.tcs_Domicilios.Rows[0]["IdLocalidad"].ToString();							
							tsh_LocalidadesDataset.tsh_LocalidadesRow rowL = tsh_Localidades.GetByPk(IdLocalidad);
							domicilio.Localidad = rowL.Descripcion;
						}						
						if( !(data2.tcs_Domicilios.Rows[0].IsNull("IdTipoDomicilio") ) )
						{
							long IdTipoDomicilio = Convert.ToInt64(data2.tcs_Domicilios.Rows[0]["IdTipoDomicilio"]);
							tcs_TiposDomiciliosDataset.tcs_TiposDomiciliosRow rowT = tcs_TiposDomicilios.GetByPk(IdTipoDomicilio);							
							domicilio.TipoDomicilio = rowT.Descripcion;
						}						

					}
					string domicilioTexto = domicilio.DomicilioTexto.Trim();
					if (!(domicilioTexto.Equals(string.Empty)))
					{
						arrayDomicilios.Add( domicilio );
					}
				}
			}
			return arrayDomicilios;*/
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tcs_DomiciliosCuentas
		/// </summary>
		public static string GetDomicilioPorDefault(string IdCuenta, string idTipoDomicilio)
		{			
			string Domicilio = string.Empty;			
			tcs_DomiciliosCuentasDataset data = new tcs_DomiciliosCuentasDataset();
			data = mz.erp.dataaccess.tcs_DomiciliosCuentas.GetList( String.Empty, IdCuenta);			
			if (data.tcs_DomiciliosCuentas.Rows.Count > 0)
			{				
				string IdDomicilio = data.tcs_DomiciliosCuentas.Rows[0]["IdDomicilio"].ToString();				
				tcs_DomiciliosDataset data2 = dataaccess.tcs_Domicilios.GetList(IdDomicilio, idTipoDomicilio);

				if (data2.tcs_Domicilios.Rows.Count > 0) 
				{
					string calle = string.Empty;
					string numero = string.Empty;
					string sector = string.Empty;
					string torre = string.Empty;
					string piso = string.Empty;
					string departamento = string.Empty;
					string manzana = string.Empty;
					if( !(data2.tcs_Domicilios.Rows[0].IsNull("Calle") ) ) { calle = data2.tcs_Domicilios.Rows[0]["Calle"].ToString()+ " " ; }
					if( !(data2.tcs_Domicilios.Rows[0].IsNull("Numero") ) ) { numero = data2.tcs_Domicilios.Rows[0]["Numero"].ToString()+ " " ; }
					if( !(data2.tcs_Domicilios.Rows[0].IsNull("Sector") ) ) { sector = data2.tcs_Domicilios.Rows[0]["Sector"].ToString()+ " " ; }
					if( !(data2.tcs_Domicilios.Rows[0].IsNull("Torre") ) ) { torre = data2.tcs_Domicilios.Rows[0]["Torre"].ToString()+ " " ; }
					if( !(data2.tcs_Domicilios.Rows[0].IsNull("Piso") ) ) { piso = data2.tcs_Domicilios.Rows[0]["Piso"].ToString()+ " " ; }
					if( !(data2.tcs_Domicilios.Rows[0].IsNull("Departamento") ) ) { departamento = data2.tcs_Domicilios.Rows[0]["Departamento"].ToString()+ " " ; }
					if( !(data2.tcs_Domicilios.Rows[0].IsNull("Manzana") ) ) { manzana = data2.tcs_Domicilios.Rows[0]["Manzana"].ToString()+ " " ; }
					Domicilio = calle + numero+ sector+torre+piso+departamento+manzana;
				}
			}
			return Domicilio;		
		}


		public static string GetDomicilioPorDefault(string IdDomicilio)
		{			
			tcs_DomiciliosDataset.tcs_DomiciliosRow row= dataaccess.tcs_Domicilios.GetByPk(IdDomicilio);
			string calle = string.Empty;
			string numero = string.Empty;
			string sector = string.Empty;
			string torre = string.Empty;
			string piso = string.Empty;
			string departamento = string.Empty;
			string manzana = string.Empty;
			if(row != null)
			{
				if( !(row.IsCalleNull() ) ) { calle = row.Calle.ToString()+ " " ; }
				if( !(row.IsNumeroNull() ) ) { numero = row.Numero.ToString()+ " " ; }
				if( !(row.IsSectorNull()) ) { sector = row.Sector.ToString()+ " " ; }
				if( !(row.IsTorreNull()) ) { torre = row.Torre.ToString()+ " " ; }
				if( !(row.IsPisoNull() ) ) { piso = row.Piso.ToString()+ " " ; }
				if( !(row.IsDepartamentoNull() ) ) { departamento = row.Departamento.ToString()+ " " ; }
				if( !(row.IsManzanaNull() ) ) { manzana = row.Manzana.ToString()+ " " ; }
			}
			string Domicilio = calle + numero+ sector+torre+piso+departamento+manzana;
			return Domicilio;		
		}



		public static string GetIdDomicilioDefault(string IdCuenta, long IdTipoDomicilio)
		{
				return mz.erp.dataaccess.tcs_DomiciliosCuentas.GetIdDomicilioDefault(IdCuenta, IdTipoDomicilio);

		}

		public static string GetTelefonoPorDefault(string IdCuenta, string idTipoDomicilio)
		{			
			string Telefono = string.Empty;			
			tcs_DomiciliosCuentasDataset data = new tcs_DomiciliosCuentasDataset();
			data = mz.erp.dataaccess.tcs_DomiciliosCuentas.GetList( String.Empty, IdCuenta);

			/*if (data.tcs_DomiciliosCuentas.Rows.Count > 0)
			{				
				string IdDomicilio = data.tcs_DomiciliosCuentas.Rows[0]["IdDomicilio"].ToString();				
				tcs_DomiciliosDataset data2 = dataaccess.tcs_Domicilios.GetList(IdDomicilio, idTipoDomicilio);

				if (data2.tcs_Domicilios.Rows.Count > 0) 
				{
					Telefono = data2.tcs_Domicilios.Rows[0]["Telefono"].ToString();
				}
			}*/

			for (int i=0; i < data.tcs_DomiciliosCuentas.Rows.Count;i++)
			{
				string IdDomicilio = data.tcs_DomiciliosCuentas.Rows[i]["IdDomicilio"].ToString();				
				tcs_DomiciliosDataset data2 = dataaccess.tcs_Domicilios.GetList(IdDomicilio, idTipoDomicilio);
				if (data2.tcs_Domicilios.Rows.Count > 0) 
				{
					if (Telefono == string.Empty)
					{
						Telefono = data2.tcs_Domicilios.Rows[0]["Telefono"].ToString();
					}					

				}
			}
			return Telefono;		
		}

		public static string GetTelefonoPorDefault( string idDomicilio)
		{
			if (idDomicilio != "") 
			{
				tcs_DomiciliosDataset.tcs_DomiciliosRow row = mz.erp.businessrules.tcs_Domicilios.GetByPk(idDomicilio);
				if(row != null)
					return row.Telefono;
			}			
			return "";
		}
		public static string GetLocalidadPorDefault( string idDomicilio)
		{			
			if (idDomicilio != "") 
			{
				tcs_DomiciliosDataset.tcs_DomiciliosRow row = mz.erp.businessrules.tcs_Domicilios.GetByPk(idDomicilio);
				string Localidad = "";
				if(row != null) 
				{
					string IdLocalidad = "";
					if (row.IdLocalidad != null && row.IdLocalidad != "") 
					{
						IdLocalidad = row.IdLocalidad;
						Localidad = tsh_Localidades.GetByPk(IdLocalidad).Descripcion;
					}
				}
				return Localidad;
			}
			return "";			
		}
        //Matias 20110819 - Tarea 0000131
        public static string GetCpPorDefault(string idDomicilio)
        {
            if (idDomicilio != "")
            {
                tcs_DomiciliosDataset.tcs_DomiciliosRow row = mz.erp.businessrules.tcs_Domicilios.GetByPk(idDomicilio);
                string cp = "";
                if (row != null)
                {
                    cp = row.CodigoPostal;
                }
                return cp;
            }
            return "";
        }
        public static string GetIdProvinciaPorDefault(string idDomicilio)
        {
            if (idDomicilio != "")
            {
                tcs_DomiciliosDataset.tcs_DomiciliosRow row = mz.erp.businessrules.tcs_Domicilios.GetByPk(idDomicilio);
                string idProvincia = "";
                if (row != null)
                {
                    idProvincia = Convert.ToString(row.IdProvincia);
                }
                return idProvincia;
            }
            return "";
        }
        public static string GetCodigoProvinciaPorDefault(string idDomicilio)
        {
            if (idDomicilio != "")
            {
                tcs_DomiciliosDataset.tcs_DomiciliosRow rowDomicilio = mz.erp.businessrules.tcs_Domicilios.GetByPk(idDomicilio);
                if (rowDomicilio != null)
                {
                    tsh_ProvinciasDataset.tsh_ProvinciasRow rowProv = tsh_Provincias.GetByPk(rowDomicilio.IdProvincia);
                    if (rowProv != null)
                        return rowProv.CodigoProvinciaWorkout;
                }
            }
            return "";
        }
        //FinMatias 20110819 - Tarea 0000131

		public static tcs_DomiciliosCuentasDataset GetList()
		{
			return mz.erp.dataaccess.tcs_DomiciliosCuentas.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tcs_DomiciliosCuentas filtrada por las condiciones de bsqueda
		/// </summary>
		public static tcs_DomiciliosCuentasDataset GetList( string  idDomicilio, string IdCuenta )
		{
			return mz.erp.dataaccess.tcs_DomiciliosCuentas.GetList( idDomicilio, IdCuenta);
		}

		/// <summary>
		/// Crea un tcs_DomiciliosCuentasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tcs_DomiciliosCuentasDataset.tcs_DomiciliosCuentasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tcs_DomiciliosCuentas.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tcs_DomiciliosCuentas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tcs_DomiciliosCuentasDataset.tcs_DomiciliosCuentasRow GetByPk( string  idDomicilio, string IdCuenta )
		{
			tcs_DomiciliosCuentasDataset.tcs_DomiciliosCuentasRow row = mz.erp.dataaccess.tcs_DomiciliosCuentas.GetByPk( idDomicilio, IdCuenta  );
			if(row != null)
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
		/// Obtiene un registro de la tabla tcs_DomiciliosCuentas que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tcs_DomiciliosCuentasDataset.tcs_DomiciliosCuentasRow GetByPk( object idDomicilio, object IdCuenta )
		{
			return GetByPk( ( string  )idDomicilio, ( string )IdCuenta );
		}

		/// <summary>
		/// Establece los valores por defecto de tcs_DomiciliosCuentasRow.
		/// </summary>
		public static tcs_DomiciliosCuentasDataset.tcs_DomiciliosCuentasRow SetRowDefaultValues( tcs_DomiciliosCuentasDataset.tcs_DomiciliosCuentasRow row )
		{
			row.idDomicilio = Util.NewStringId(); 
			row.IdCuenta = Util.NewStringId(); 
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tcs_DomiciliosCuentasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tcs_DomiciliosCuentasDataset.tcs_DomiciliosCuentasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tcs_DomiciliosCuentasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tcs_DomiciliosCuentasDataset.tcs_DomiciliosCuentasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tcs_DomiciliosCuentasRow a la base de datos.
		/// </summary>
		public static void Update( tcs_DomiciliosCuentasDataset.tcs_DomiciliosCuentasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tcs_DomiciliosCuentas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tcs_DomiciliosCuentasDataset a la base de datos.
		/// </summary>
		public static void Update( tcs_DomiciliosCuentasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tcs_DomiciliosCuentas.Rows.Count > 0, "La tabla dataSet.tcs_DomiciliosCuentasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tcs_DomiciliosCuentas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tcs_DomiciliosCuentasDataset.tcs_DomiciliosCuentasDataTable a la base de datos.
		/// </summary>
		public static void Update( tcs_DomiciliosCuentasDataset.tcs_DomiciliosCuentasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tcs_DomiciliosCuentas.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tcs_DomiciliosCuentasRow.
		/// </summary>
		public static bool RowIsValid( tcs_DomiciliosCuentasDataset.tcs_DomiciliosCuentasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !idDomicilioIsValid( row.idDomicilio, out mensaje) )
			{ 
				row.SetColumnError( "idDomicilio" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCuentaIsValid( row.IdCuenta, out mensaje) )
			{ 
				row.SetColumnError( "IdCuenta" , mensaje);
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
						
			if ( !IdEmpresaIsValid( row.IdEmpresa, out mensaje) )
			{ 
				row.SetColumnError( "IdEmpresa" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo idDomicilio.
		/// </summary>
		public static bool idDomicilioIsValid( string  idDomicilio , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo idDomicilio. Metodo Sobrecargado
		/// </summary>
		public static bool idDomicilioIsValid( string idDomicilio)
		{
			string mensaje;
			return idDomicilioIsValid( idDomicilio, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdCuenta.
		/// </summary>
		public static bool IdCuentaIsValid( string IdCuenta , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCuenta. Metodo Sobrecargado
		/// </summary>
		public static bool IdCuentaIsValid( string IdCuenta)
		{
			string mensaje;
			return IdCuentaIsValid( IdCuenta, out mensaje );
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
		

		public void Dispose()
		{
		}
		
	}
}


