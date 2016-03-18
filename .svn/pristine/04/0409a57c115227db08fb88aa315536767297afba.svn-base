using System;
using System.Collections;
using System.Data;

namespace mz.erp.businessrules
{
	public class ItemDatasetError
	{
		string _tabla = string.Empty;
		string _campo = string.Empty;
		string _mensaje = string.Empty;
		public ItemDatasetError( string tabla, string campo, string mensaje)
		{
			this._tabla = tabla;
			this._campo = campo;
			this._mensaje = mensaje;
		}
		public string Tabla
		{
			get 
			{
				return _tabla;
			}
		}
		public string Campo
		{
			get
			{
				return _campo;
			}
		}
		public string Mensaje
		{
			get
			{
				return _mensaje;
			}
		}
	}
	public class ItemsDatasetErrors: CollectionBase
	{
		/// <summary>
		/// Constructor. Crea una nueva instancia de la clase ItemsDatasetErrors
		/// </summary>
		public ItemsDatasetErrors()
		{
		}
		/// <summary>
		/// Agrega un nuevo mensaje de error en la colección de errores del dataset.
		/// </summary>
		/// <param name="item"></param>
		public virtual void Add( ItemDatasetError item )
		{
			List.Add( item );
		}

		public ItemDatasetError[] GetArray()
		{
			return null;
		}

		public void AddAll(ItemsDatasetErrors items)
		{
			foreach(ItemDatasetError item in items)
			{
				this.Add(item);
			}

		}


	}
	/// <summary>
	/// Formatea los mensajes a visualizarse en caso de que se presenten errores en una
	/// acción de update en una tabla. Traduce los mensajes que levanta la descripción
	/// de errores del dataset obtenidos cuando rebota una instrucción en el motor de
	/// base de datos.
	/// Genera dos colecciones del tipo cabecera detalle para ser visualizados por la
	/// interface de usuario.
	/// </summary>
	public class DatasetErrors
	{
		private ArrayList _detailsErrors;
		private ArrayList _globalErrors;
		public DatasetErrors( ItemsDatasetErrors errores )
		{
			_Init();
			_ProcesarErrores( errores );
		}

		/// <summary>
		/// Constructor. Crea una nueva instancia de las colecciones DetailErrors y GlobalErrors
		/// formateando los mensajes de error de la variable row si es que posee
		/// </summary>
		/// <param name="row"></param>
		public DatasetErrors(System.Data.DataRow row)
		{
			_Init();
			_ProcesarErrores( row );
		}
		/// <summary>
		/// Constructor Sobrecargado. Procesa cada row del objeto table y genera los mensajes para las mismas
		/// </summary>
		/// <param name="table"></param>
		public DatasetErrors(System.Data.DataTable table)
		{
			_Init();
			_ProcesarErrores( table );
		}
		/// <summary>
		/// Constructor Sobrecargado. Procesa cada table del objeco dataset y envia al procesamiento de cada table para que procese cada row.
		/// </summary>
		/// <param name="dataset"></param>
		public DatasetErrors(System.Data.DataSet dataset)
		{
			_Init();
			_ProcesarErrores( dataset );
		}
		/// <summary>
		/// Inicializa las variables privadas de la clase con valores por default. Se invoca como primera instruccion del constructor
		/// </summary>
		private void _Init()
		{
			this._detailsErrors = new ArrayList();
			this._globalErrors = new ArrayList();
		}

		/// <summary>
		/// Procesa los mensajes de error en cada columna.
		/// </summary>
		/// <param name="errores"></param>
		private void _ProcesarErrores(ItemsDatasetErrors errores)
		{
			foreach (ItemDatasetError er in errores)
			{
				_detailsErrors.Add( er );
			}
			//_globalErrors.Add( new ItemDatasetError( "Comprobante","N/A","Errores al intentar guardar el comprobante"));
		}

		/// <summary>
		/// Procesa los mensajes de error en cada columna de la row y los carga en las colecciones
		/// </summary>
		/// <param name="row"></param>
		private void _ProcesarErrores(System.Data.DataRow row)
		{
			if (row.HasErrors)
			{
				foreach (DataColumn dc in row.GetColumnsInError())
				{
					string tabla = row.Table.TableName;
					string campo = dc.ColumnName;
					string mensaje = row.GetColumnError( dc );
					_detailsErrors.Add( new ItemDatasetError( tabla, campo, mensaje) );
				}
				string tablarow = row.Table.TableName;
				string camporow = "N/A";
				string mensajerow = row.RowError;
				_globalErrors.Add( new ItemDatasetError( tablarow, camporow, mensajerow ) );
			}
		}
		/// <summary>
		/// Metodo sobrecargado. Recorre el objeto table y envia a procesarlo al metodo que recibe una row
		/// </summary>
		/// <param name="table"></param>
		private void _ProcesarErrores(System.Data.DataTable table)
		{
			if (table.HasErrors)
			{
				foreach (DataRow row in table.Rows)
				{
					_ProcesarErrores( row );
				}
			}
		}
		/// <summary>
		/// Metodo sobrecargado. Recorre el objeto table y envia a procesarlo al metodo que recibe una table
		/// </summary>
		/// <param name="dataset"></param>
		private void _ProcesarErrores(System.Data.DataSet dataset)
		{
			if (dataset.HasErrors)
			{
				foreach (DataTable table in dataset.Tables)
				{
					_ProcesarErrores( table );
				}
			}
		}

		public ItemDatasetError[] DetailErrors
		{
			get
			{
				return ( ItemDatasetError[] )_detailsErrors.ToArray( typeof( ItemDatasetError ) );
			}
		}

		public ItemDatasetError[] GlobalErrors
		{
			get
			{
				return ( ItemDatasetError[] )_globalErrors.ToArray( typeof( ItemDatasetError ) );
			}
		}


	}
}