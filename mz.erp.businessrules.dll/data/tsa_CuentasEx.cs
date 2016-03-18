namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;
	using System.Collections;

	public class tsa_CuentasEx : IDisposable
	{
	
		#region Custom Members

        public static tsa_CuentasExDataset GetByPk(string IdCuenta)
        {
            tsa_CuentasExDataset data = new tsa_CuentasExDataset();

            tcs_DomiciliosCuentasDataset dataDomCuentas = mz.erp.businessrules.tcs_DomiciliosCuentas.GetList(null, IdCuenta);
            foreach (System.Data.DataRow row in dataDomCuentas.tcs_DomiciliosCuentas.Rows)
            {
                //data.Merge(new System.Data.DataRow[] { mz.erp.dataaccess.tcs_Domicilios.GetByPk((string)row["IdDomicilio"]) });
                data.tcs_Domicilios.ImportRow(mz.erp.dataaccess.tcs_Domicilios.GetByPk((string)row["IdDomicilio"]));
            }
            //data.Merge(new System.Data.DataRow[] { mz.erp.dataaccess.tsa_Cuentas.GetByPk(IdCuenta) });
            data.tsa_Cuentas.ImportRow(mz.erp.dataaccess.tsa_Cuentas.GetByPk(IdCuenta));

            //data.Merge(dataDomCuentas);
            foreach (System.Data.DataRow row in dataDomCuentas.tcs_DomiciliosCuentas.Rows)
            {
                data.tcs_DomiciliosCuentas.ImportRow(row);
            }

            //data.Merge(mz.erp.businessrules.tsy_ImpuestosCuentas.GetList(null, IdCuenta, null).tsy_ImpuestosCuentas);
            tsy_ImpuestosCuentasDataset dataIC = mz.erp.businessrules.tsy_ImpuestosCuentas.GetList(null, IdCuenta, null);
            foreach (System.Data.DataRow row in dataIC.tsy_ImpuestosCuentas.Rows)
            {
                data.tsy_ImpuestosCuentas.ImportRow(row);
            }
            
            try
            {
                foreach (DataTable table in data.Tables)
                {
                    foreach (DataRow row1 in table.Rows)
                    {
                        foreach (DataColumn dc in row1.Table.Columns)
                        {
                            if (!dc.Caption.ToUpper().Equals("ROWID"))
                            {
                                if (row1[dc] == System.DBNull.Value)
                                {
                                    row1[dc] = Util.DefaultValue(dc.DataType);
                                }
                            }
                        }
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return data;

        }

        //Deprecated - No funciona en 2008 - German 20100202

        //public static tsa_CuentasExDataset GetByPk( string IdCuenta )
        //{
        //    tsa_CuentasExDataset data= new tsa_CuentasExDataset();

        //    tcs_DomiciliosCuentasDataset dataDomCuentas = mz.erp.businessrules.tcs_DomiciliosCuentas.GetList(null, IdCuenta);
        //    foreach(System.Data.DataRow row in dataDomCuentas.tcs_DomiciliosCuentas.Rows)
        //    {		
        //        data.Merge(new System.Data.DataRow [] {mz.erp.dataaccess.tcs_Domicilios.GetByPk((string)row["IdDomicilio"])});
        //    }
        //    data.Merge(new System.Data.DataRow [] {mz.erp.dataaccess.tsa_Cuentas.GetByPk(IdCuenta)});

        //    data.Merge(dataDomCuentas);

        //    data.Merge(mz.erp.businessrules.tsy_ImpuestosCuentas.GetList(null, IdCuenta, null).tsy_ImpuestosCuentas);
        //    try
        //    {
        //        foreach ( DataTable table in data.Tables) 
        //        {
        //            foreach ( DataRow row1 in table.Rows )
        //            {
        //                foreach ( DataColumn dc in row1.Table.Columns )
        //                {
        //                    if(!dc.Caption.ToUpper().Equals("ROWID"))
        //                    {
        //                        if (row1[dc] == System.DBNull.Value)
        //                        {
        //                            row1[dc] = Util.DefaultValue( dc.DataType );
        //                        }
        //                    }
        //                }
        //            }
				
        //        }
        //    }
        //    catch(Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    return data;

        //}


		public static tsa_CuentasExDataset GetListEx( string Codigo, string Nombre, string Domicilio, string idTipoDocumento, string Documento, string IdTitular )
		{
			long IdTipoDomicilio = Variables.GetValueLong("Cuentas.Domicilios.TipoDomicilioDefault");
			decimal LimiteDeCredito = decimal.MinValue;
			return mz.erp.dataaccess.tsa_CuentasEx.GetListEx( Codigo, Nombre, Domicilio, idTipoDocumento, Documento, IdTitular, IdTipoDomicilio, LimiteDeCredito );
		}

		private static string _state = string.Empty;

		public static string State
		{
			set{_state = value;}
		}

		#endregion
		
		public tsa_CuentasEx()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_Cuentas
		/// </summary>
		public static tsa_CuentasExDataset GetList()
		{
			return mz.erp.dataaccess.tsa_CuentasEx.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsa_Cuentas filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_CuentasExDataset GetList( string Codigo, string Nombre, string Domicilio, string idTipoDocumento, string Documento, string IdTitular )
		{
			decimal LimiteDeCredito = decimal.MinValue;
			long IdTipoDomicilio = Variables.GetValueLong("Cuentas.Domicilios.TipoDomicilioDefault");
			return mz.erp.dataaccess.tsa_CuentasEx.GetList( Codigo, Nombre, Domicilio, idTipoDocumento, Documento, IdTitular, IdTipoDomicilio, LimiteDeCredito );
		}

		/// <summary>
		/// Crea un tsa_CuentasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsa_CuentasExDataset NewRow()
		{
			
			tsa_CuentasExDataset data= new tsa_CuentasExDataset();
			
			tsa_CuentasExDataset.tsa_CuentasRow row = data.tsa_Cuentas.Newtsa_CuentasRow();
			SetRowDefaultValues(row);
			data.tsa_Cuentas.Rows.Add(row);
			/*
			tsa_CuentasExDataset.tsy_ImpuestosCuentasRow rowIC = data.tsy_ImpuestosCuentas.NewRow();
			rowIC.IdImpuesto = Util.NewStringId(); 
			rowIC.IdCuenta = Util.NewStringId(); 
			rowIC.MetodoDeAsignacion = "E";
			rowIC.FechaCreacion = DateTime.Now;
			rowIC.IdConexionCreacion = Security.IdConexion;
			rowIC.IdConexionUltimaModificacion = Security.IdConexion;
			rowIC.IdReservado = 0;
			rowIC.RowId = Guid.Empty;
			rowIC.IdEmpresa = Security.IdEmpresa;
			rowIC.IdSucursal = Security.IdSucursal;
			data.tsy_ImpuestosCuentas.Addtsy_ImpuestosCuentasRow(rowIC);
			*/
			

		//	tcs_DomiciliosDataset.tcs_DomiciliosRow rowDomicilios = mz.erp.businessrules.tcs_Domicilios.NewRow();

		//	data.tcs_Domicilios.LoadDataRow(rowDomicilios.ItemArray, false);

			return data;
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_Cuentas que luego puede ser persistido en la base de datos.
		/// </summary>
		

		/// <summary>
		/// Obtiene un registro de la tabla tsa_Cuentas que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsa_CuentasExDataset GetByPk( object IdCuenta )
		{
			return GetByPk( ( string )IdCuenta );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_CuentasRow.
		/// </summary>
		public static tsa_CuentasExDataset.tsa_CuentasRow SetRowDefaultValues( tsa_CuentasExDataset.tsa_CuentasRow row )
		{
			row.IdCuenta = Util.NewStringId(); 
			row.Codigo = string.Empty;
			row.Nombre = string.Empty;
			row.Domicilio = string.Empty;
			row.HorarioComercial = string.Empty;
			row.idTipoDocumento = string.Empty;
			row.Documento = string.Empty;
			row.IdCategoriaIva = string.Empty;
			row.CampoAuxiliar1 = string.Empty;
			row.CampoAuxiliar2 = string.Empty;
			row.CampoAuxiliar3 = string.Empty;
			row.IdTitular = string.Empty;
			row.Observaciones = string.Empty;
			row.Activo = true;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = Security.IdSucursal;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdBonificacion ="1";
			row.ExcluyePercepcionIB = false;
			row.IdDomicilioDefault = null;
			row.AlicuotaPercepcionIngresosBrutos = 0;

			row.SaldoCtaCte = 0;
			row.SaldoCtaCteDV = 0;
			row.IdResponsableCreacion = string.Empty;
			row.DiasLimiteDeCredito = Variables.GetValueDecimal("Momentos.ABMCuentas.DiasLimiteDeCredito.Default");
            /* Silvina 20111104 - Tarea 0000222 */
            row.CampoAuxiliar6 = string.Empty;
            /* Fin Silvina 20111104 - Tarea 0000222 */
			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CuentasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsa_CuentasExDataset data )
		{
			ApplicationAssert.Check( data != null, "El argumento data no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( DatasetIsValid( data ) )
			{
				Update( data );

			}
		}


		
		/// <summary>
		/// Envia los cambios del tsa_CuentasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsa_CuentasExDataset.tsa_CuentasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CuentasRow a la base de datos.
		/// </summary>
		public static void Update( tsa_CuentasExDataset.tsa_CuentasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_CuentasEx.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_CuentasDataset a la base de datos.
		/// </summary>
		/// 


		private static SentenciasReplicacion GenerateReplication()
		{
			//Nuevo
			SentenciasReplicacion replication = new SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tsa_Cuentas";
			return replication;
		}
		public static void Update( tsa_CuentasExDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_Cuentas.Rows.Count > 0, "La tabla dataSet.tsa_CuentasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			
			SentenciasReplicacion replicacion = GenerateReplication();
			mz.erp.dataaccess.tsa_CuentasEx.Update( dataSet , replicacion);
		}

		
		
		/// <summary>
		/// Envia los cambios del tsa_CuentasDataset.tsa_CuentasDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_CuentasExDataset.tsa_CuentasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			//mz.erp.dataaccess.tsa_CuentasEx.Update( dataTable );
		}
		
		#region delete
		[ atMethodDeleteRow]
		public static void Delete(tsa_CuentasExDataset data)
		{
			
			tsa_CuentasExDataset.tsa_CuentasRow row = (tsa_CuentasExDataset.tsa_CuentasRow)data.tsa_Cuentas.Rows[0];
			row.Delete();
			Update(row);
		
			if	(row.Table.HasErrors)
			{
				row.RejectChanges();
				row["Activo"] = false;
				Update(row);
				if (row.Table.HasErrors)
				{
					row.SetColumnError("IdValor","No se ha podido eliminar el item");
				}
				else
				{
					row.SetColumnError("IdValor","No se ha podido eliminar el item porque existen tablas relacionadas. Se procede a desactivar");
				}
			}
		

		}
		
		#endregion




		#region validaciones

		public static bool DatasetIsValid(tsa_CuentasExDataset data)
		{	
			tsa_CuentasExDataset.tsa_CuentasDataTable tableCuentas=data.tsa_Cuentas;
			tsa_CuentasExDataset.tsa_CuentasRow row=(tsa_CuentasExDataset.tsa_CuentasRow)tableCuentas.Rows[0];
			bool ok  = true;
			ok = ok && RowIsValid(row);
			ok = ok && CodigoIsValid(row);
			ok = ok && CategoriaIVAIsValid(row);
			ok = ok && CategoriaDomiciliosIsValid(row, data);
			foreach(System.Data.DataRow rowDomicilio in data.tcs_Domicilios.Rows)
			{
				if(rowDomicilio.RowState.Equals(System.Data.DataRowState.Added) ||rowDomicilio.RowState.Equals(System.Data.DataRowState.Modified))
					ok = ok && mz.erp.businessrules.tcs_Domicilios.RowIsValid(rowDomicilio);
			}
			ok = ok && DomicilioDefaultIsValid(row, data);
			return ok;
		}

		private static bool CategoriaDomiciliosIsValid(tsa_CuentasExDataset.tsa_CuentasRow row, tsa_CuentasExDataset data)
		{
			
			string IdTipoDocumento = row.idTipoDocumento;
			bool ValidarCategoriaImpositivaConDirecciones = Variables.GetValueBool("Cuentas.Validaciones.CategoriaImpositivaConDireccion");
			string CategoriasAValidar = Variables.GetValueString("Cuentas.Validaciones.CategoriaImpositivaConDireccion.ListaCategoriasImpositivaAValidar");
			ArrayList ListaCategoriasAValidar = mz.erp.systemframework.Util.Parse( CategoriasAValidar, ",");
			if(ValidarCategoriaImpositivaConDirecciones)
			{
				if(ListaCategoriasAValidar.Contains(IdTipoDocumento.ToUpper()))
				{
					foreach(System.Data.DataRow rowDomicilioCuenta in data.tcs_DomiciliosCuentas.Rows)
					{
						if(rowDomicilioCuenta.RowState.Equals(System.Data.DataRowState.Added) ||rowDomicilioCuenta.RowState.Equals(System.Data.DataRowState.Modified)
							||rowDomicilioCuenta.RowState.Equals(System.Data.DataRowState.Unchanged))
							return true;
					}
					row.SetColumnError( "IdTipoDocumento" , "Debe Ingresar al menos un domicilio");
					return false;
				}
			}
			return true;
		}

		

		private static bool DomicilioDefaultIsValid(tsa_CuentasExDataset.tsa_CuentasRow row, tsa_CuentasExDataset data)
		{
			string IdDomcilioDefault = Convert.ToString(row["IdDomicilioDefault"]);
            /* Silvina 20110823 - Tarea 0000178 */
            bool ok = true;
			if(data.tcs_Domicilios.Rows.Count == 0) return true;
            foreach(System.Data.DataRow rowDC in data.tcs_DomiciliosCuentas.Rows)
			{
                if (!rowDC.RowState.Equals(System.Data.DataRowState.Deleted))
                    ok = false;
            }
            /* Fin Silvina 20110823 - Tarea 0000178 */
			foreach(System.Data.DataRow rowDomicilio in data.tcs_Domicilios.Rows)
			{
				//German 20100518
                if(!rowDomicilio.RowState.Equals(System.Data.DataRowState.Deleted))
                //Fin German 20100518
				{
					string IdDomicilio = Convert.ToString(rowDomicilio["IdDomicilio"]);
					if(IdDomicilio.Equals(IdDomcilioDefault))
							return true;
				}

			}
            /* Silvina 20110823 - Tarea 0000178 */
            if (!ok)
            /* Fin Silvina 20110823 - Tarea 0000178 */
			    row.SetColumnError( "IdDomicilioDefault" , "Debe seleccionar el Domicilio por defecto");
			return ok;

		}

		private static bool CategoriaIVAIsValid(tsa_CuentasExDataset.tsa_CuentasRow row)
		{
			/*
			string IdCategoriaIVA = row.IdCategoriaIva;
			string IdTipoDocumento = row.idTipoDocumento;
			if(IdTipoDocumento.ToUpper().Equals("CUIT"))
				if(!IdCategoriaIVA.ToUpper().Equals("RI"))
				{
					row.SetColumnError( "IdCategoriaIva" , "La Categoría de IVA no es válida. Debería ser Responsable Inscripto");
					return false;
				}
			*/
			return true;
		}

		public static bool CodigoIsValid(tsa_CuentasExDataset.tsa_CuentasRow row)
		{
			bool codigoAutomatico = Variables.GetValueBool("Cuentas.CodigoAutomatico");
			if(!codigoAutomatico)
			{	
				
				
				string cod = Convert.ToString(row["Codigo"]);
				if(cod.Equals(string.Empty))
				{
					row.SetColumnError( "Codigo" , "El Código NO puede ser vacío");
					return false;
				}
				string IdCuenta = Convert.ToString(row["IdCuenta"]);
				DataSet data = mz.erp.businessrules.tsa_Cuentas.GetList(cod, null, null, null,null, null, false);
				if(data != null)
				{
					foreach(DataRow rowAux in data.Tables[0].Rows)
					{
						string codBD = Convert.ToString(rowAux["codigo"]);
						string IdCuentaBD = Convert.ToString(rowAux["IdCuenta"]);
						if(cod.Equals(codBD) && !IdCuenta.Equals(IdCuentaBD))
						{
							row.SetColumnError( "Codigo" , "El Código YA EXISTE");
							return false;
						}
					}
				}

			}
		
			return true;
		}
			
			#endregion
		/// <summary>
		/// Valida un tsa_CuentasRow.
		/// </summary>
		public static bool RowIsValid( tsa_CuentasExDataset.tsa_CuentasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdCuentaIsValid( row.IdCuenta, out mensaje) )
			{ 
				row.SetColumnError( "IdCuenta" , mensaje);
				isValid=false;
			
			}
						
			if ( !CodigoIsValid( row.Codigo, out mensaje) )
			{ 
				row.SetColumnError( "Codigo" , mensaje);
				isValid=false;
			
			}
						
			if ( !NombreIsValid( row.Nombre, out mensaje) )
			{ 
				row.SetColumnError( "Nombre" , mensaje);
				isValid=false;
			
			}
						
			if ( !DomicilioIsValid( row.Domicilio, out mensaje) )
			{ 
				row.SetColumnError( "Domicilio" , mensaje);
				isValid=false;
			
			}
						
			if ( !HorarioComercialIsValid( row.HorarioComercial, out mensaje) )
			{ 
				row.SetColumnError( "HorarioComercial" , mensaje);
				isValid=false;
			
			}
						
			if (row.IsidTipoDocumentoNull())
			{
				row.SetColumnError("idTipoDocumento", "El tipo de documento no puede ser nulo");
				isValid= false;
			}
			else
			{
				
				if ( !idTipoDocumentoIsValid( row.idTipoDocumento, out mensaje) )
				{ 
					row.SetColumnError( "idTipoDocumento" , mensaje);
					isValid=false;				
				}
				else			
				{
					if ( !DocumentoIsValid( row.Documento, out mensaje) )
					{ 
						row.SetColumnError( "Documento" , mensaje);
						isValid=false;
					
					}
				}
			}

			if ( !DocumentoIsValid (row, out mensaje) )
			{
				row.SetColumnError( "Documento" , mensaje);
				isValid=false;	
			}
		
			if ( !IdCategoriaIvaIsValid( row.IdCategoriaIva, out mensaje) )
			{ 
				row.SetColumnError( "IdCategoriaIva" , mensaje);
				isValid=false;			
			}

			if ((row.IdCategoriaIva == "RI" || row.IdCategoriaIva == "MO") && row.idTipoDocumento != "CUIT")
			{ 
				row.SetColumnError( "idCategoriaIva" , "Tipo de documento no válido para categoría de IVA");
				isValid=false;				
			}
						
			if ( !CampoAuxiliar1IsValid( row.CampoAuxiliar1, out mensaje) )
			{ 
				row.SetColumnError( "CampoAuxiliar1" , mensaje);
				isValid=false;
			
			}
						
			if ( !CampoAuxiliar2IsValid( row.CampoAuxiliar2, out mensaje) )
			{ 
				row.SetColumnError( "CampoAuxiliar2" , mensaje);
				isValid=false;
			
			}
						
			if ( !CampoAuxiliar3IsValid( row.CampoAuxiliar3, out mensaje) )
			{ 
				row.SetColumnError( "CampoAuxiliar3" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTitularIsValid( row.IdTitular, out mensaje) )
			{ 
				row.SetColumnError( "IdTitular" , mensaje);
				isValid=false;
			
			}
						
			if ( !ObservacionesIsValid( row.Observaciones, out mensaje) )
			{ 
				row.SetColumnError( "Observaciones" , mensaje);
				isValid=false;
			
			}
						
			if ( !ActivoIsValid( row.Activo, out mensaje) )
			{ 
				row.SetColumnError( "Activo" , mensaje);
				isValid=false;
			
			}

            /* Silvina 20110614 - Tarea 0000155 */
			if ( row.IsIdResponsableCreacionNull() || ( !IdResponsableCreacionIsValid( row.IdResponsableCreacion, out mensaje) ))
			{
                row.SetColumnError("IdResponsableCreacion", "No seleccionó el Responsable del alta");
				isValid=false;
			
			}
            /* Fin Silvina 20110614 - Tarea 0000155 */
		
	/*		if ( !FechaCreacionIsValid( row.FechaCreacion, out mensaje) )
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
						
			if ( !IdSucursalIsValid( row.IdSucursal, out mensaje) )
			{ 
				row.SetColumnError( "IdSucursal" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdEmpresaIsValid( row.IdEmpresa, out mensaje) )
			{ 
				row.SetColumnError( "IdEmpresa" , mensaje);
				isValid=false;
			
			}*/
			;
			
			return isValid;
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
		/// Valida el campo Codigo.
		/// </summary>
		public static bool CodigoIsValid( string Codigo , out string mensaje )
		{
			/*if (Codigo =="")
			{
				mensaje="El Codigo no puede ser vacio ";
				return false;
			}*/
			mensaje ="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Codigo. Metodo Sobrecargado
		/// </summary>
		public static bool CodigoIsValid( string Codigo)
		{
			string mensaje;
			return CodigoIsValid( Codigo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Nombre.
		/// </summary>
		public static bool NombreIsValid( string Nombre , out string mensaje )
		{
			if (Nombre =="")
			{
				mensaje="Debe Ingresar el Nombre del Cliente";
				return false;
			}
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Nombre. Metodo Sobrecargado
		/// </summary>
		public static bool NombreIsValid( string Nombre)
		{
			string mensaje;
			return NombreIsValid( Nombre, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Domicilio.
		/// </summary>
		public static bool DomicilioIsValid( string Domicilio , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Domicilio. Metodo Sobrecargado
		/// </summary>
		public static bool DomicilioIsValid( string Domicilio)
		{
			string mensaje;
			return DomicilioIsValid( Domicilio, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo HorarioComercial.
		/// </summary>
		public static bool HorarioComercialIsValid( string HorarioComercial , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo HorarioComercial. Metodo Sobrecargado
		/// </summary>
		public static bool HorarioComercialIsValid( string HorarioComercial)
		{
			string mensaje;
			return HorarioComercialIsValid( HorarioComercial, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo idTipoDocumento.
		/// </summary>
		public static bool idTipoDocumentoIsValid( string idTipoDocumento , out string mensaje )
		{
			if (idTipoDocumento == null)
			{	
				mensaje="Debe Seleccionar el Tipo de Documento de Producto";
				return false;
			}
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo idTipoDocumento. Metodo Sobrecargado
		/// </summary>
		public static bool idTipoDocumentoIsValid( string idTipoDocumento)
		{
			string mensaje;
			return idTipoDocumentoIsValid( idTipoDocumento, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Documento.
		/// </summary>
		public static bool DocumentoIsValid( tsa_CuentasExDataset.tsa_CuentasRow row, out string mensaje )
		{
			mensaje = "";
			bool CUITok = systemframework.Cuit.Control(row.Documento);
			ArrayList array = new ArrayList();
			array.Add("CUIT");
			array.Add("CUIL");			

			if (array.Contains(row.idTipoDocumento) && !CUITok) 
			{
				mensaje = "El numero indicado es invalido para el tipo de documento seleccionado";
				return false;
			}
            /* Silvina 20110405 - Tarea 0000047 */
            if (!row.idTipoDocumento.Equals("CUIT"))
            {
                tsa_CuentasDataset.tsa_CuentasRow rowDoc = tsa_Cuentas.GetByDocumento(row.idTipoDocumento, row.Documento);
                if ((rowDoc != null) && !(rowDoc.IdCuenta.Equals(row.IdCuenta)))
                {
                    mensaje = "El numero indicado ya existe para el tipo de documento seleccionado";
                    return false;
                }
            }
            /* Fin Silvina 20110405 - Tarea 0000047 */
			return true;
		}
		
		/// <summary>
		/// Valida el campo Documento. Metodo Sobrecargado
		/// </summary>

		public static bool DocumentoIsValid( string Documento, out string mensaje)
		{			
  			mensaje = "";
			return true;
		}		

		
		/// <summary>
		/// Valida el campo IdCategoriaIva.
		/// </summary>
		public static bool IdCategoriaIvaIsValid( string IdCategoriaIva , out string mensaje )
		{
			if (IdCategoriaIva=="")
			{	
				mensaje ="Debe Selecciones la Categoria Impositiva del Cliente";
				return false;
			}
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCategoriaIva. Metodo Sobrecargado
		/// </summary>
		public static bool IdCategoriaIvaIsValid( string IdCategoriaIva)
		{
			string mensaje;
			return IdCategoriaIvaIsValid( IdCategoriaIva, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CampoAuxiliar1.
		/// </summary>
		public static bool CampoAuxiliar1IsValid( string CampoAuxiliar1 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CampoAuxiliar1. Metodo Sobrecargado
		/// </summary>
		public static bool CampoAuxiliar1IsValid( string CampoAuxiliar1)
		{
			string mensaje;
			return CampoAuxiliar1IsValid( CampoAuxiliar1, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CampoAuxiliar2.
		/// </summary>
		public static bool CampoAuxiliar2IsValid( string CampoAuxiliar2 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CampoAuxiliar2. Metodo Sobrecargado
		/// </summary>
		public static bool CampoAuxiliar2IsValid( string CampoAuxiliar2)
		{
			string mensaje;
			return CampoAuxiliar2IsValid( CampoAuxiliar2, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CampoAuxiliar3.
		/// </summary>
		public static bool CampoAuxiliar3IsValid( string CampoAuxiliar3 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CampoAuxiliar3. Metodo Sobrecargado
		/// </summary>
		public static bool CampoAuxiliar3IsValid( string CampoAuxiliar3)
		{
			string mensaje;
			return CampoAuxiliar3IsValid( CampoAuxiliar3, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTitular.
		/// </summary>
		public static bool IdTitularIsValid( string IdTitular , out string mensaje )
		{
			/*if (IdTitular == string.Empty)
			{
				mensaje = "El titular no puede ser nulo";
				return false;
			}*/
					
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTitular. Metodo Sobrecargado
		/// </summary>
		public static bool IdTitularIsValid( string IdTitular)
		{
			string mensaje;
			return IdTitularIsValid( IdTitular, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Observaciones.
		/// </summary>
		public static bool ObservacionesIsValid( string Observaciones , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Observaciones. Metodo Sobrecargado
		/// </summary>
		public static bool ObservacionesIsValid( string Observaciones)
		{
			string mensaje;
			return ObservacionesIsValid( Observaciones, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Activo.
		/// </summary>
		public static bool ActivoIsValid( bool Activo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}

		/// <summary>
		/// Valida el campo IdResponsableCreacion.
		/// </summary>
		public static bool IdResponsableCreacionIsValid( string IdResponsableCreacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			if ( IdResponsableCreacion.Equals(string.Empty) )
			{
				mensaje="No seleccionó el Responsable del alta";
				return false;
			}
			else
			{
				mensaje="";
				return true;
			}
		}
		
		/// <summary>
		/// Valida el campo Activo. Metodo Sobrecargado
		/// </summary>
		public static bool ActivoIsValid( bool Activo)
		{
			string mensaje;
			return ActivoIsValid( Activo, out mensaje );
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
