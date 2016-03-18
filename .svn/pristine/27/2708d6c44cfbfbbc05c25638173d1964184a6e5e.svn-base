namespace mz.erp.businessrules.data
{

	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.businessrules;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;
	using mz.erp.systemframework;
	using mz.erp.businessrules.comprobantes;
	using System.Collections;



	/// <summary>
	/// Descripción breve de tfi_ValoresEx.
	/// </summary>
	public class tfi_ValoresEx
	{
		public tfi_ValoresEx()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		#region Custom Members



		public static System.Data.DataSet LoadValores(System.Data.DataSet data, tfi_ValoresExDataset dataValores)
		{
			foreach(System.Data.DataRow row in dataValores.Tables["tfi_Valores"].Rows)
			{
				data.Tables["tfi_valores"].ImportRow(row);
			}
			foreach(System.Data.DataRow row in dataValores.Tables["tfi_ValoresVariablesAuxiliares"].Rows)
			{
				data.Tables["tfi_ValoresVariablesAuxiliares"].ImportRow(row);
			}


			return data;
		}
		/*	public static Pr_tfi_VariablesAuxiliaresWithValor_By_IdValorAndIdTDCompTesoreriaDataset GetList( string IdTDCompTesoreria )
			{
				return mz.erp.dataaccess.tfi_Valores.GetList(IdTDCompTesoreria);

			}*/

		public static tfi_ValoresExDataset GetVariablesAuxiliares( tfi_ValoresExDataset data,string IdValor,string IdTDCompTesoreria )
		{
			data.Pr_tfi_VariablesAuxiliaresWithValor_By_IdValorAndIdTDCompTesoreria.Clear();
			data = mz.erp.dataaccess.tfi_ValoresEx.GetVariablesAuxiliares(data, IdValor, IdTDCompTesoreria);
			System.Data.DataTable table= data.Pr_tfi_VariablesAuxiliaresWithValor_By_IdValorAndIdTDCompTesoreria;
			
			foreach (tfi_ValoresExDataset.Pr_tfi_VariablesAuxiliaresWithValor_By_IdValorAndIdTDCompTesoreriaRow rowSP in table.Rows)
			
			{
				tfi_ValoresExDataset.tfi_ValoresDatosAuxiliaresRow rowNew = data.tfi_ValoresDatosAuxiliares.Newtfi_ValoresDatosAuxiliaresRow();
				SetRowDefaultValues(rowNew, IdValor);	
				data.tfi_ValoresDatosAuxiliares.Rows.Add(rowNew);
					
			}
			return data;
					
			

		}

		public static tfi_ValoresExDataset GetVariablesAuxiliaresAModificar( tfi_ValoresExDataset data,string IdValor,string IdTDCompTesoreria )
		{
			return null;

		}


		public static tfi_ValoresExDataset GetList( string IdValor, string IdTDCompTesoreria, string Numero, string IdEntidad, DateTime FechaVencimiento, decimal Valor, string IdMoneda, string IdCotizacionMoneda )
		{
			return mz.erp.dataaccess.tfi_ValoresEx.GetList( IdValor, IdTDCompTesoreria, Numero, IdEntidad, FechaVencimiento, Valor, IdMoneda, IdCotizacionMoneda );
		}
	





		public static tfi_ValoresExDataset.tfi_ValoresRow SetRowDefaultValues( tfi_ValoresExDataset.tfi_ValoresRow row )
		{
			row.IdValor = Util.NewStringId(); 
			
			//Este valor viene por parametro o por variable del lsistema
			row.IdTDCompTesoreria = string.Empty;
			row.Numero = string.Empty;
			row.IdEntidad = string.Empty;
			row.Fecha = mz.erp.businessrules.Sistema.DateTime.Now;
			row.FechaVencimiento = mz.erp.businessrules.Sistema.DateTime.Now;
			row.Valor = 0;
			row.IdMoneda = string.Empty;
			row.IdCotizacionMoneda = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			row.IdInstanciaCaja = string.Empty;

			return row;
		}

		public static tfi_ValoresExDataset.tfi_ValoresRow SetRowDefaultValues( tfi_ValoresExDataset.tfi_ValoresRow row , string IdTDCompTesoreria, string IdMoneda)
		{
			SetRowDefaultValues(row);
			row.IdTDCompTesoreria= IdTDCompTesoreria;
			row.IdMoneda=IdMoneda;
			return row;


		}

		public static tfi_ValoresExDataset.tfi_ValoresDatosAuxiliaresRow SetRowDefaultValues (tfi_ValoresExDataset.tfi_ValoresDatosAuxiliaresRow row, string IdValor )
		{
			row.IdValor = IdValor;
			return row;
		}

		public static System.Data.DataRow GetByPk (System.Data.DataSet data, string IdValor)
		{
				
				tfi_ValoresExDataset dataSet = (tfi_ValoresExDataset) data; 
				tfi_ValoresExDataset.tfi_ValoresDataTable tabla = dataSet.tfi_Valores;

				//System.Data.DataRow [] rows = tabla.Select("IdValor =" + IdValor);
				
				System.Data.DataRow row = tabla.Rows.Find(IdValor);
				
				return row;
		}



		public static tfi_ValoresExDataset GetByPk ( string IdValor )
		{
			tfi_ValoresExDataset data= new tfi_ValoresExDataset();
			data=(tfi_ValoresExDataset) mz.erp.dataaccess.tfi_ValoresEx.GetByPk(data,IdValor);
			System.Data.DataTable tableValores=data.Tables["tfi_Valores"];
			System.Data.DataRow row = tableValores.Rows[0];
			//data=(tfi_ValoresExDataset) mz.erp.dataaccess.tfi_ValoresEx.Get(data, IdValor,(string) row["IdTDCompTesoreria"]);
			
			
			foreach ( DataTable table in data.Tables) 
			{
				foreach ( DataRow row1 in table.Rows )
				{
					foreach ( DataColumn dc in row1.Table.Columns )
					{
						if (row1[dc] == System.DBNull.Value)
						{
							row1[dc] = Util.DefaultValue( dc.DataType );
						}
					}
				}
				
			}
			return data;
		
		
		}
		[ atMethodGetByPkRow ]
		public static tfi_ValoresExDataset GetByPk( object IdValor )
		{

			return GetByPk( (string )IdValor );
		}


		
		
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_ValoresExDataset data )
		{
			ApplicationAssert.Check( data != null, "El argumento data no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( DatasetIsValid( data ) )
			{
				Update( data );
			}

			//Update(data);
		}




		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_ValoresExDataset.tfi_ValoresRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_ValoresRow a la base de datos.
		/// </summary>
		public static void Update( tfi_ValoresExDataset.tfi_ValoresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_ValoresEx.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tfi_ValoresDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_ValoresExDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_Valores.Rows.Count > 0, "La tabla dataSet.tfi_ValoresDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_ValoresEx.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_ValoresDataset.tfi_ValoresDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_ValoresExDataset.tfi_ValoresDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_Valores.Update( dataTable );
		}

		[ atMethodNewRow ]
		public static tfi_ValoresExDataset.tfi_ValoresRow NewRow(System.Data.DataSet _data, string IdTDCompTesoreria, string IdMoneda)
		{
			
			tfi_ValoresExDataset data = (tfi_ValoresExDataset)_data;
			tfi_ValoresExDataset.tfi_ValoresRow row = data.tfi_Valores.Newtfi_ValoresRow();
			SetRowDefaultValues(row, IdTDCompTesoreria,IdMoneda);
			data.tfi_Valores.Rows.Add(row);
			//data= GetVariablesAuxiliares(data,row.IdValor,row.IdTDCompTesoreria);
			
			return row;

		}

		public static tfi_ValoresExDataset CargarValores (System.Data.DataSet _data)
		{
			tfi_ValoresExDataset data = (tfi_ValoresExDataset)_data;
			tfi_ValoresExDataset.Pr_tfi_VariablesAuxiliaresWithValor_By_IdValorAndIdTDCompTesoreriaDataTable table=data.Pr_tfi_VariablesAuxiliaresWithValor_By_IdValorAndIdTDCompTesoreria;
			for(int i=0; i< table.Rows.Count;i++)
			{
				tfi_ValoresExDataset.Pr_tfi_VariablesAuxiliaresWithValor_By_IdValorAndIdTDCompTesoreriaRow row=(tfi_ValoresExDataset.Pr_tfi_VariablesAuxiliaresWithValor_By_IdValorAndIdTDCompTesoreriaRow) table.Rows[i];	
				tfi_ValoresExDataset.tfi_ValoresDatosAuxiliaresRow rowMod=(tfi_ValoresExDataset.tfi_ValoresDatosAuxiliaresRow)data.tfi_ValoresDatosAuxiliares.Rows[i];
			}
			table.Rows.Clear();
			return data;

		}

		public static tfi_ValoresExDataset EliminarValor(tfi_ValoresExDataset data, string IdValor)
		{
			
			
			tfi_ValoresExDataset.tfi_ValoresDataTable tablaValores = data.tfi_Valores;
			System.Data.DataRow row = tablaValores.Rows.Find(IdValor);
			tablaValores.Rows.Remove(row);
			//Debug.WriteLine(row.GetType());
			return data;


		}
		//Hace el commit de la coleccion de valores, Actualiza el DataSet ValoresEx y lo agrega al Dataset que 
		// viene como tercer parametro

		public static System.Data.DataSet  Commit (ArrayList valores, System.Data.DataSet valoresEx, System.Data.DataSet data)
		{
			tfi_ValoresExDataset dataValores = (tfi_ValoresExDataset) valoresEx;
			for(int i = 0; i< valores.Count; i++)
			{
				Valor valor = (Valor)valores[i];
				tfi_ValoresExDataset.tfi_ValoresRow rowValor =(tfi_ValoresExDataset.tfi_ValoresRow) dataValores.tfi_Valores.Rows[i];
				valor.SetRowValues(rowValor);
			

			}

			foreach(System.Data.DataRow row in dataValores.Tables["tfi_Valores"].Rows)
			{
				data.Tables["tfi_valores"].ImportRow(row);
			}
			foreach(System.Data.DataRow row in dataValores.Tables["tfi_ValoresVariablesAuxiliares"].Rows)
			{
				data.Tables["tfi_ValoresVariablesAuxiliares"].ImportRow(row);
			}


			return data;
			



		}

		/*
		public static void SetRowValues(tfi_ValoresExDataset.tfi_ValoresRow  rowValor, Valor valor)
		{
			rowValor.IdEntidad= valor.IdEntidad;
			rowValor.IdMoneda= valor.IdMoneda;
			rowValor.IdTDCompTesoreria= valor.IdTDCompTesoreria;
			rowValor.Numero= valor.Numero;
			rowValor.Valor= valor.MontoCotizado;
			rowValor.Fecha= valor.Fecha;
			rowValor.FechaVencimiento= valor.FechaVencimiento;
			rowValor.IdCotizacionMoneda= valor.IdCotizacion;
		


		}
		*/

	



		#region delete
		[ atMethodDeleteRow]
		public static void Delete(tfi_ValoresExDataset data)
		{
			
			tfi_ValoresExDataset.tfi_ValoresRow row = (tfi_ValoresExDataset.tfi_ValoresRow)data.tfi_Valores.Rows[0];
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
					row.SetColumnError("IdValor","No se ha podido eliminar el item porque existen tablas relacionadas. Se ha procede a desactivar");
				}
			}
		

		}
		
		#endregion

		#region validaciones

		public static bool DatasetIsValid(tfi_ValoresExDataset data)
		{	
			tfi_ValoresExDataset.tfi_ValoresDataTable tableValores=data.tfi_Valores;
			tfi_ValoresExDataset.tfi_ValoresRow row=(tfi_ValoresExDataset.tfi_ValoresRow)tableValores.Rows[0];
			bool ok= false;
			if (RowIsValid(row))
			{
				ok=true;
				tfi_ValoresExDataset.Pr_tfi_VariablesAuxiliaresWithValor_By_IdValorAndIdTDCompTesoreriaDataTable table= data.Pr_tfi_VariablesAuxiliaresWithValor_By_IdValorAndIdTDCompTesoreria;
				foreach (tfi_ValoresExDataset.Pr_tfi_VariablesAuxiliaresWithValor_By_IdValorAndIdTDCompTesoreriaRow rowSP in table.Rows)
			
				{
					if ( !RowIsValid(rowSP)){ok=false; break;}
					
				}

			}
			return ok;
			
		}

		# region Tabla Valores
		
		public static bool RowIsValid( tfi_ValoresExDataset.tfi_ValoresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdValorIsValid( row.IdValor, out mensaje) )
			{ 
				row.SetColumnError( "IdValor" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTDCompTesoreriaIsValid( row.IdTDCompTesoreria, out mensaje) )
			{ 
				row.SetColumnError( "IdTDCompTesoreria" , mensaje);
				isValid=false;
			
			}
						
			if ( !NumeroIsValid( row.Numero, out mensaje) )
			{ 
				row.SetColumnError( "Numero" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdEntidadIsValid( row.IdEntidad, out mensaje) )
			{ 
				row.SetColumnError( "IdEntidad" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaIsValid( row.Fecha, out mensaje) )
			{ 
				row.SetColumnError( "Fecha" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaVencimientoIsValid( row.FechaVencimiento, out mensaje) )
			{ 
				row.SetColumnError( "FechaVencimiento" , mensaje);
				isValid=false;
			
			}
						
			if ( !ValorIsValid( row.Valor, out mensaje) )
			{ 
				row.SetColumnError( "Valor" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdMonedaIsValid( row.IdMoneda, out mensaje) )
			{ 
				row.SetColumnError( "IdMoneda" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCotizacionMonedaIsValid( row.IdCotizacionMoneda, out mensaje) )
			{ 
				row.SetColumnError( "IdCotizacionMoneda" , mensaje);
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
						
			if ( !IdSucursalIsValid( row.IdSucursal, out mensaje) )
			{ 
				row.SetColumnError( "IdSucursal" , mensaje);
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
		/// Valida el campo IdEntidad.
		/// </summary>
		public static bool IdEntidadIsValid( string IdEntidad , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEntidad. Metodo Sobrecargado
		/// </summary>
		public static bool IdEntidadIsValid( string IdEntidad)
		{
			string mensaje;
			return IdEntidadIsValid( IdEntidad, out mensaje );
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
		/// Valida el campo FechaVencimiento.
		/// </summary>
		public static bool FechaVencimientoIsValid( DateTime FechaVencimiento , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaVencimiento. Metodo Sobrecargado
		/// </summary>
		public static bool FechaVencimientoIsValid( DateTime FechaVencimiento)
		{
			string mensaje;
			return FechaVencimientoIsValid( FechaVencimiento, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Valor.
		/// </summary>
		public static bool ValorIsValid( decimal Valor , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Valor. Metodo Sobrecargado
		/// </summary>
		public static bool ValorIsValid( decimal Valor)
		{
			string mensaje;
			return ValorIsValid( Valor, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdMoneda.
		/// </summary>
		public static bool IdMonedaIsValid( string IdMoneda , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMoneda. Metodo Sobrecargado
		/// </summary>
		public static bool IdMonedaIsValid( string IdMoneda)
		{
			string mensaje;
			return IdMonedaIsValid( IdMoneda, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdCotizacionMoneda.
		/// </summary>
		public static bool IdCotizacionMonedaIsValid( string IdCotizacionMoneda , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCotizacionMoneda. Metodo Sobrecargado
		/// </summary>
		public static bool IdCotizacionMonedaIsValid( string IdCotizacionMoneda)
		{
			string mensaje;
			return IdCotizacionMonedaIsValid( IdCotizacionMoneda, out mensaje );
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
		
		#endregion
		
		# region Stored Procedure 


		public static bool RowIsValid( tfi_ValoresExDataset.Pr_tfi_VariablesAuxiliaresWithValor_By_IdValorAndIdTDCompTesoreriaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdVariableAuxiliarTDCompTesoreriaIsValid( row.IdVariableAuxiliarTDCompTesoreria, out mensaje) )
			{ 
				row.SetColumnError( "IdVariableAuxiliarTDCompTesoreria" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionComprobanteIsValid( row.DescripcionComprobante, out mensaje) )
			{ 
				row.SetColumnError( "IdTDCompTesoreria" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionVariableIsValid( row.DescripcionVariable, out mensaje) )
			{ 
				row.SetColumnError( "DescripcionVariable" , mensaje);
				isValid=false;
			
			}
						
						
			if ( !ValorIsValid( row.Valor, out mensaje) )
			{ 
				row.SetColumnError( "Valor" , mensaje);
				isValid=false;
			
			}
						
			
			
			return isValid;
		}


		public static bool IdVariableAuxiliarTDCompTesoreriaIsValid( string IdValor , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdValor. Metodo Sobrecargado
		/// </summary>
		public static bool IdVariableAuxiliarTDCompTesoreriaIsValid( string IdVariableAuxiliarTDCompTesoreria)
		{
			string mensaje;
			return IdVariableAuxiliarTDCompTesoreriaIsValid( IdVariableAuxiliarTDCompTesoreria, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTDCompTesoreria.
		/// </summary>
		public static bool DescripcionComprobanteIsValid( string DescripcionComprobante , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTDCompTesoreria. Metodo Sobrecargado
		/// </summary>
		public static bool DescripcionComprobanteIsValid( string DescripcionComprobante)
		{
			string mensaje;
			return DescripcionComprobanteIsValid( DescripcionComprobante, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Numero.
		/// </summary>
		public static bool DescripcionVariableIsValid( string DescripcionVariable , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Numero. Metodo Sobrecargado
		/// </summary>
		public static bool DescripcionVariableIsValid( string DescripcionVariable)
		{
			string mensaje;
			return DescripcionVariableIsValid( DescripcionVariable, out mensaje );
		}	
	
		public static bool ValorIsValid( string Valor , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Valor. Metodo Sobrecargado
		/// </summary>
		public static bool ValorIsValid( string Valor)
		{
			string mensaje;
			return ValorIsValid( Valor, out mensaje );
		}		
		
		


		#endregion
		
		



		#endregion
		#endregion
	}

}
