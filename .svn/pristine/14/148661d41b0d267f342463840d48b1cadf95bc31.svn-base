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
	using mz.erp.commontypes.CommonInterfaces;


	public class CondicionDeVentaView:IComparable, IToolTip
	{
		private string _idCondicionDeVenta = string.Empty;
		private string _descripcion = string.Empty;
		private int _orden = 0;
		private decimal _recargo = 0;

		public string IdCondicionDeVenta
		{
			get{return _idCondicionDeVenta;}
			set{_idCondicionDeVenta = value;}
		}

		public string Descripcion
		{
			get{return _descripcion;}
			set{_descripcion = value;}
		}

		public int Orden
		{
			get{return _orden;}
			set{_orden = value;}
		}

		public decimal Recargo
		{
			get{return _recargo;}
			set{_recargo = value;}
		}
		#region Miembros de IComparable

		public int CompareTo(object obj)
		{
			return this._orden.CompareTo(((CondicionDeVentaView)obj).Orden);
		}

		#endregion

		#region Miembros de IToolTip

		public string ToStringToolTip()
		{
			return _descripcion + " .Recargo "+ Convert.ToString(_recargo) +"%";
		}

		#endregion

		public override string ToString()
		{
			return _descripcion;
		}
	}

	sealed class ItemsRecargosCondicionesDeVenta
	{
		public ItemsRecargosCondicionesDeVenta()
		{
		}
		private string _idCondicionDeVenta;
		public string IdCondicionDeVenta
		{
			get { return _idCondicionDeVenta ; }
			set { _idCondicionDeVenta = value ; }
		}
		private string _descripcion;
		public string Descripcion
		{
			get { return _descripcion ; }
			set { _descripcion = value ; }
		}
		private decimal _recargo;
		public decimal Recargo
		{
			get { return _recargo; }
			set { _recargo = value ; }
		}

		private decimal _porcentajeRecargo = 0;
		public decimal PorcentajeRecargo
		{
			get{return _porcentajeRecargo;}
			set{_porcentajeRecargo = value;}
			
		}
		private decimal _importe;
		public decimal Importe
		{
			get { return _importe ;}
			set { _importe = value ; }
		}
	}


	public class tsa_CondicionesDeVentas : IDisposable
	{
	
		#region Custom Members
		/// <summary>
		/// Obtiene tabla tsa_CondicionesDeVentas filtrada por las condiciones de bsqueda
		/// </summary>
		/// 
		
		public static tsa_CondicionesDeVentasDataset GetCondicionesDeVentaByIdTDCompTesoreria(string IdTDCompTesoreria)
		{
			return mz.erp.dataaccess.tsa_CondicionesDeVentas.GetCondicionesDeVentaByIdTDCompTesoreria( IdTDCompTesoreria );
		}


		public static tsa_CondicionesDeVentasDataset GetList( string IdCondicionDeVenta, string Descripcion)
		{
			//Filtro solo los activos
			bool Activo = true;
			return mz.erp.dataaccess.tsa_CondicionesDeVentas.GetList( IdCondicionDeVenta, Descripcion, Activo );
		}
		
		public static tsa_CondicionesDeVentasDataset GetList( string IdCondicionDeVenta, string Descripcion, bool Activo)
		{
			return mz.erp.dataaccess.tsa_CondicionesDeVentas.GetList( IdCondicionDeVenta, Descripcion, Activo );
		}

		public static ArrayList RecargosPorCondicionesDeVenta( decimal valor, bool Orden )
		{
			
			tsa_CondicionesDeVentasDataset _data = GetList( null , null );
			System.Data.DataView _dataordered;
			DataTable result = VariablesListComparer.FilterDataTable("Productos.Solapas.PreciosPorCondicionDeVenta.ListaDeCondicionesDeVentas","IdCondicionDeVenta",_data.tsa_CondicionesDeVentas);
			if(Orden)
				_dataordered = new DataView( result, null, "Orden",System.Data.DataViewRowState.CurrentRows );
			else
				_dataordered = new DataView( result, null, "Descripcion",System.Data.DataViewRowState.CurrentRows );
			ArrayList array = new ArrayList();
			for(int i = 0 ; i< _dataordered.Count ; i++)
			{
				System.Data.DataRowView _row = _dataordered[i];
				ItemsRecargosCondicionesDeVenta item = new ItemsRecargosCondicionesDeVenta();
				item.IdCondicionDeVenta = Convert.ToString(_row["IdCondicionDeVenta"]);
				item.Descripcion = Convert.ToString(_row["Descripcion"]) ;
				item.PorcentajeRecargo = System.Math.Round(Convert.ToDecimal( _row["Recargo"] ),2);
				item.Recargo = System.Math.Round(Convert.ToDecimal(valor* item.PorcentajeRecargo /100 ),2) ;
				item.Importe = System.Math.Round(Convert.ToDecimal(valor+ valor*Convert.ToDecimal(_row["Recargo"] )/100 ),2) ;
				array.Add(item );
				
			}
			return array;
		}


		public static ArrayList GetCondicionesDeVentas()
		{
			ArrayList resutl = new ArrayList();
			tsa_CondicionesDeVentasDataset _data = GetList( null , null );
			foreach(DataRow row in _data.Tables["tsa_CondicionesDeVentas"].Rows)
			{
				CondicionDeVentaView cdvv = new CondicionDeVentaView();
				cdvv.IdCondicionDeVenta = Convert.ToString(row["IdCondicionDeVenta"]);
				cdvv.Descripcion = Convert.ToString(row["Descripcion"]);
				if(row.IsNull("Orden"))
					cdvv.Orden = int.MaxValue;
				else
					cdvv.Orden = Convert.ToInt32(row["Orden"]);
				cdvv.Recargo = Convert.ToDecimal(row["Recargo"]);
				resutl.Add(cdvv);
			}
			return resutl;
		}

		
		

		public static DataTable GetCondicionesDeVentaBy(string IdCuenta,string IdTipoDeComprobante,string Proceso,string Tarea,string IdPersona)
		{
			//return mz.erp.dataaccess.tsa_CondicionesDeVentas.GetCondicionesDeVentaBy(IdCuenta, IdTipoDeComprobante);
			// Silvina 20100511 - Tarea 748 
			string IdUsuario = sy_Usuarios.GetUsuario(IdPersona);
			DataTable table = mz.erp.dataaccess.tsa_CondicionesDeVentas.GetCondicionesDeVentaBy(IdCuenta, IdTipoDeComprobante);
			DataTable result = VariablesListComparer.FilterDataTable(Proceso , Tarea, "CondicionesDeVenta", "IdCondicionDeVenta", table,IdUsuario);
			return result;
		}

		#endregion
		
		public tsa_CondicionesDeVentas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_CondicionesDeVentas
		/// </summary>
		public static tsa_CondicionesDeVentasDataset GetList()
		{
			return mz.erp.dataaccess.tsa_CondicionesDeVentas.GetList();
		}
		

		/// <summary>
		/// Crea un tsa_CondicionesDeVentasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsa_CondicionesDeVentas.NewRow());
		}

		
		/// <summary>
		/// Obtiene un registro de la tabla tsa_CondicionesDeVentas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasRow GetByPk( string IdCondicionDeVenta )
		{
			tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasRow row = mz.erp.dataaccess.tsa_CondicionesDeVentas.GetByPk( IdCondicionDeVenta  );
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
		/// Obtiene un registro de la tabla tsa_CondicionesDeVentas que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasRow GetByPk( object IdCondicionDeVenta )
		{
			return GetByPk( ( string )IdCondicionDeVenta );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_CondicionesDeVentasRow.
		/// </summary>
		public static tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasRow SetRowDefaultValues( tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasRow row )
		{
			row.IdCondicionDeVenta = Util.NewStringId(); 
			row.Descripcion = string.Empty;
			row.Activo = true;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.Recargo = 0 ; 
			row.Orden = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CondicionesDeVentasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CondicionesDeVentasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CondicionesDeVentasRow a la base de datos.
		/// </summary>
		public static void Update( tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_CondicionesDeVentas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_CondicionesDeVentasDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_CondicionesDeVentasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_CondicionesDeVentas.Rows.Count > 0, "La tabla dataSet.tsa_CondicionesDeVentasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_CondicionesDeVentas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_CondicionesDeVentas.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_CondicionesDeVentasRow.
		/// </summary>
		public static bool RowIsValid( tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdCondicionDeVentaIsValid( row.IdCondicionDeVenta, out mensaje) )
			{ 
				row.SetColumnError( "IdCondicionDeVenta" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
				isValid=false;
			
			}
						
			if ( !ActivoIsValid( row.Activo, out mensaje) )
			{ 
				row.SetColumnError( "Activo" , mensaje);
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
						
			if ( !IdEmpresaIsValid( row.IdEmpresa, out mensaje) )
			{ 
				row.SetColumnError( "IdEmpresa" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdCondicionDeVenta.
		/// </summary>
		public static bool IdCondicionDeVentaIsValid( string IdCondicionDeVenta , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCondicionDeVenta. Metodo Sobrecargado
		/// </summary>
		public static bool IdCondicionDeVentaIsValid( string IdCondicionDeVenta)
		{
			string mensaje;
			return IdCondicionDeVentaIsValid( IdCondicionDeVenta, out mensaje );
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
		/// Valida el campo Activo.
		/// </summary>
		public static bool ActivoIsValid( bool Activo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
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
		/*public static bool UltimaModificacionIsValid( byte[] UltimaModificacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}*/
		
		/// <summary>
		/// Valida el campo UltimaModificacion. Metodo Sobrecargado
		/// </summary>
		/*public static bool UltimaModificacionIsValid( byte[] UltimaModificacion)
		{
			string mensaje;
			return UltimaModificacionIsValid( UltimaModificacion, out mensaje );
		}		
		*/
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

