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

	public class tsy_TiposDeComprobantes : IDisposable
	{
	
		#region Custom Members

		public static tsy_TiposDeComprobantesDataset.tsy_TiposDeComprobantesRow GetByDescripcion(string Descripcion)
		{
			return mz.erp.dataaccess.tsy_TiposDeComprobantes.GetByDescripcion(Descripcion);
		}

		public static TiposDeComprobantes GetTiposDeComprobanteRequiereCondicionDeVenta()
		{
			TiposDeComprobantes result = new TiposDeComprobantes();
			DataTable table = mz.erp.businessrules.tsy_TiposDeComprobantes.GetList().Tables[0];
			foreach(DataRow row in table.Rows)
			{
				bool ReqCondVenta = Convert.ToBoolean(row["RequiereCondicionDeVenta"]);
				if(ReqCondVenta)
				{
					string IdTipoDeComprobante = Convert.ToString(row["IdTipoDeComprobante"]);
					string Descripcion = Convert.ToString(row["Descripcion"]);
					string Familia = Convert.ToString(row["Familia"]);
					TipoDeComprobante tc = new TipoDeComprobante();
					tc.IdTipoComprobante = IdTipoDeComprobante;
					tc.Descripcion = Descripcion;
					tc.Familia = Familia;
					tc.RequiereCondicionDeVenta = true;
					result.Add(tc);
				}
			}
			result.Sort();
			return result;
		}

		public static TiposDeComprobantes GetTiposDeComprobantes()
		{
			TiposDeComprobantes result = new TiposDeComprobantes();
			DataTable table = mz.erp.businessrules.tsy_TiposDeComprobantes.GetList().Tables[0];
			foreach(DataRow row in table.Rows)
			{
				string IdTipoDeComprobante = Convert.ToString(row["IdTipoDeComprobante"]);
				string Descripcion = Convert.ToString(row["Descripcion"]);
				string Familia = Convert.ToString(row["Familia"]);
				string Mascara = Convert.ToString(row["Mascara"]);
				bool Activo = Convert.ToBoolean(row["Activo"]);
				bool RequiereCondicionDeVenta = Convert.ToBoolean(row["RequiereCondicionDeVenta"]);
				int Signo = Convert.ToInt16(row["Signo"]);
				int SignoCuentaCorriente = Convert.ToInt16(row["SignoCtaCte"]);
				int TipoCuentaCorriente = Convert.ToInt16(row["TipoCtaCte"]);

				TipoDeComprobante tc = new TipoDeComprobante();
				tc.IdTipoComprobante = IdTipoDeComprobante;
				tc.Descripcion = Descripcion;
				tc.Familia = Familia;
				tc.Mascara = Mascara;
				tc.Activo = Activo;
				tc.RequiereCondicionDeVenta = RequiereCondicionDeVenta;
				tc.Signo = Signo;
				tc.SignoCuentaCorriente = SignoCuentaCorriente;
				tc.TipoCuentaCorriente = TipoCuentaCorriente;
				result.Add(tc);
				
			}
			result.Sort();
			return result;
		}

		public static ArrayList GetTiposDeComprobantesTodos()
		{
			ArrayList result = new ArrayList();
			DataTable table = mz.erp.businessrules.tsy_TiposDeComprobantes.GetList().Tables[0];
			foreach(DataRow row in table.Rows)
			{		string IdTipoDeComprobante = Convert.ToString(row["IdTipoDeComprobante"]);
					string Descripcion = Convert.ToString(row["Descripcion"]);
					string Familia = Convert.ToString(row["Familia"]);
					TiposDeComprobantesView tcv = new TiposDeComprobantesView();
					tcv.IdTipoDeComprobante = IdTipoDeComprobante;
					tcv.Descripcion = Descripcion;
					tcv.Familia = Familia;
					result.Add(tcv);
				
			}
			result.Sort();
			return result;
		}

		public static Hashtable GetListHashTable()
		{
			Hashtable table = new Hashtable();
			tsy_TiposDeComprobantesDataset data = GetList();
			foreach ( tsy_TiposDeComprobantesDataset.tsy_TiposDeComprobantesRow row in data.tsy_TiposDeComprobantes.Rows )
			{
				table.Add( row.IdTipoDeComprobante, row.Descripcion );
			}
			return table;

		}
		public static ArrayList ObtenerNombres( IList lista )
		{
			ArrayList myArray = new ArrayList();
			foreach( string id in lista )
			{
				tsy_TiposDeComprobantesDataset.tsy_TiposDeComprobantesRow row = tsy_TiposDeComprobantes.GetByPk( id );
				if (row.IdTipoDeComprobante != null)
				{
					myArray.Add( row.Descripcion );
				}
			}
			return myArray;
		}
		public static string ObtenerClave( string unNombre )
		{
			string nombre = null;
			tsy_TiposDeComprobantesDataset data = tsy_TiposDeComprobantes.GetList( null, unNombre, false, int.MinValue,null );
			if (data.tsy_TiposDeComprobantes.Rows.Count > 0)
			{
				nombre =  ((tsy_TiposDeComprobantesDataset.tsy_TiposDeComprobantesRow )data.tsy_TiposDeComprobantes.Rows[0]).IdTipoDeComprobante ;
			}
			return nombre;
		}
		public static string MomentoAsociado( string unTipoDeComprobante )
		{
			tsy_TiposDeComprobantesDataset data = mz.erp.dataaccess.tsy_TiposDeComprobantes.GetList( unTipoDeComprobante, null, false, int.MinValue,null, null);
			tsy_TiposDeComprobantesDataset.tsy_TiposDeComprobantesRow row = (tsy_TiposDeComprobantesDataset.tsy_TiposDeComprobantesRow)data.tsy_TiposDeComprobantes.Rows[0];
			if (!(row.IsMomentoNull()))
			{
				return row.Momento;
			}
			else
			{
				return null;
			}
		}
		public static string Mascara( string unTipoDeComprobante )
		{
			tsy_TiposDeComprobantesDataset data = mz.erp.dataaccess.tsy_TiposDeComprobantes.GetList( unTipoDeComprobante, null, false, int.MinValue,null, null);
			if (data.tsy_TiposDeComprobantes.Rows.Count > 0)
			{
				tsy_TiposDeComprobantesDataset.tsy_TiposDeComprobantesRow row = (tsy_TiposDeComprobantesDataset.tsy_TiposDeComprobantesRow)data.tsy_TiposDeComprobantes.Rows[0];
				if (!(row.IsMascaraNull()))
				{
					return row.Mascara;
				}
				else
				{
					return null;
				}
			}
			else
			{
				return null;
			}
		}

		#endregion
		
		public tsy_TiposDeComprobantes()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsy_TiposDeComprobantes
		/// </summary>
		public static tsy_TiposDeComprobantesDataset GetList()
		{
			return mz.erp.dataaccess.tsy_TiposDeComprobantes.GetList();
		}


		
		
		/// <summary>
		/// Obtiene tabla tsy_TiposDeComprobantes filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsy_TiposDeComprobantesDataset GetList( string IdTipoDeComprobante, string Descripcion, bool Activo, int Signo, string TipoCompMomento )
		{
			return mz.erp.dataaccess.tsy_TiposDeComprobantes.GetList( IdTipoDeComprobante, Descripcion, Activo, Signo ,TipoCompMomento, null);
		}

		/// <summary>
		/// Crea un tsy_TiposDeComprobantesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsy_TiposDeComprobantesDataset.tsy_TiposDeComprobantesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsy_TiposDeComprobantes.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsy_TiposDeComprobantes que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsy_TiposDeComprobantesDataset.tsy_TiposDeComprobantesRow GetByPk( string IdTipoDeComprobante )
		{
			tsy_TiposDeComprobantesDataset.tsy_TiposDeComprobantesRow row = mz.erp.dataaccess.tsy_TiposDeComprobantes.GetByPk( IdTipoDeComprobante  );
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
		/// Obtiene un registro de la tabla tsy_TiposDeComprobantes que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsy_TiposDeComprobantesDataset.tsy_TiposDeComprobantesRow GetByPk( object IdTipoDeComprobante )
		{
			return GetByPk( ( string )IdTipoDeComprobante );
		}

		/// <summary>
		/// Establece los valores por defecto de tsy_TiposDeComprobantesRow.
		/// </summary>
		public static tsy_TiposDeComprobantesDataset.tsy_TiposDeComprobantesRow SetRowDefaultValues( tsy_TiposDeComprobantesDataset.tsy_TiposDeComprobantesRow row )
		{
			row.IdTipoDeComprobante = Util.NewStringId(); 
			row.Descripcion = string.Empty;
			row.Mascara = string.Empty;
			row.Activo = false;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			row.RequiereCondicionDeVenta = false;
			row.Familia = string.Empty;


			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsy_TiposDeComprobantesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsy_TiposDeComprobantesDataset.tsy_TiposDeComprobantesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsy_TiposDeComprobantesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsy_TiposDeComprobantesDataset.tsy_TiposDeComprobantesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_TiposDeComprobantesRow a la base de datos.
		/// </summary>
		public static void Update( tsy_TiposDeComprobantesDataset.tsy_TiposDeComprobantesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_TiposDeComprobantes.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsy_TiposDeComprobantesDataset a la base de datos.
		/// </summary>
		public static void Update( tsy_TiposDeComprobantesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsy_TiposDeComprobantes.Rows.Count > 0, "La tabla dataSet.tsy_TiposDeComprobantesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_TiposDeComprobantes.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_TiposDeComprobantesDataset.tsy_TiposDeComprobantesDataTable a la base de datos.
		/// </summary>
		public static void Update( tsy_TiposDeComprobantesDataset.tsy_TiposDeComprobantesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_TiposDeComprobantes.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsy_TiposDeComprobantesRow.
		/// </summary>
		public static bool RowIsValid( tsy_TiposDeComprobantesDataset.tsy_TiposDeComprobantesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdTipoDeComprobanteIsValid( row.IdTipoDeComprobante, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoDeComprobante" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
				isValid=false;
			
			}
						
			if ( !MascaraIsValid( row.Mascara, out mensaje) )
			{ 
				row.SetColumnError( "Mascara" , mensaje);
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
		/// Valida el campo IdTipoDeComprobante.
		/// </summary>
		public static bool IdTipoDeComprobanteIsValid( string IdTipoDeComprobante , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoDeComprobante. Metodo Sobrecargado
		/// </summary>
		public static bool IdTipoDeComprobanteIsValid( string IdTipoDeComprobante)
		{
			string mensaje;
			return IdTipoDeComprobanteIsValid( IdTipoDeComprobante, out mensaje );
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
		/// Valida el campo Mascara.
		/// </summary>
		public static bool MascaraIsValid( string Mascara , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Mascara. Metodo Sobrecargado
		/// </summary>
		public static bool MascaraIsValid( string Mascara)
		{
			string mensaje;
			return MascaraIsValid( Mascara, out mensaje );
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


	public sealed class TiposDeComprobantesView: IComparable, IToolTip
	{

		private string _idTipoDeComprobante;
		private string _descripcion;
		private string _familia = string.Empty;
		private bool _sourceBD = false;				
		private bool _agregado = false;

		public bool SourceBD
		{
			get{return _sourceBD;}
			set{_sourceBD = value;}
		}

		public bool Agregado
		{
			get{return _agregado;}
			set{_agregado = value;}
		}

		public string Familia
		{
			get{return _familia;}
			set{_familia = value;}
		}

		public string IdTipoDeComprobante
		{
			get{return _idTipoDeComprobante;}
			set{_idTipoDeComprobante = value;}
		}

		public string Descripcion
		{
			get{return _descripcion;}
			set{_descripcion = value;}
		}

		public override string ToString()
		{
			return _idTipoDeComprobante;
		}
		#region Miembros de IComparable

		public int CompareTo(object obj)
		{
			return this._idTipoDeComprobante.CompareTo(((TiposDeComprobantesView)obj).IdTipoDeComprobante);
		}

		#endregion

		#region Miembros de IToolTip

		public string ToStringToolTip()
		{
			return _descripcion;
		}

		#endregion
	}
}


