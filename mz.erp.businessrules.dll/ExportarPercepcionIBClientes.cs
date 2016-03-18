//German 20120412 - Tarea 0000286
using System;
using System.Collections;
using System.Data;
using mz.erp.businessrules.reportes;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using System.IO;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ExportarImpuestos.
	/// </summary>
	public class ExportarImpuestos
	{
		public ExportarImpuestos()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public ExportarImpuestos(string key)
		{
			this.Key=key;
		}

		#region Variables Privadas
		private DateTime _fechaDesde = System.DateTime.Now.AddDays(-30);
		private DateTime _fechaHasta = System.DateTime.Now;
		private string _filePath = string.Empty;
		private string _key = string.Empty;
		#endregion

		#region Propiedades
		public DateTime FechaDesde
		{
			get{return this._fechaDesde;}
			set{this._fechaDesde=value;}
		}

		public DateTime FechaHasta
		{
			get{return this._fechaHasta;}
			set{this._fechaHasta=value;}
		}

		public string FilePath
		{
			get{return _filePath;}
			set{_filePath=value;}
		}

		public string Key
		{
			get{return _key;}
			set{_key=value;}
		}

		public string Leyenda
		{
			get
			{
				if (_key.Equals("ProcesoExportarListadoPercepcionIIBBClientes") )
					return "Exportar Percepciones de IIBB de Clientes";
				else
				{
					if (_key.Equals("ProcesoExportarListadoRetencionIIBBProveedores") )
						return "Exportar Retenciones de IIBB a Proveedores";
				}
				return "Exportar impuestos";
			}
		}

		#endregion

		#region Metodos Publicos
		public bool ValidarDatos()
		{
			return true;
		}

		public bool ExportarDatos()
		{
			if ( (_filePath != null) && (!_filePath.Equals(string.Empty)) )
			{
				// Armar el archivo
				FileInfo file = new FileInfo(this._filePath);
                
				System.IO.FileStream fs;
				try
				{
					if (System.IO.File.Exists(_filePath)) //Valida que el archivo no se encuentre abierto!
					{
						fs = System.IO.File.Open(_filePath, FileMode.Open, FileAccess.Read, FileShare.None);
						fs.Close();
					}

					StreamWriter debugWriter = new StreamWriter( file.Open( FileMode.Append, FileAccess.Write, FileShare.ReadWrite ), System.Text.Encoding.ASCII );
					
					DataTable result = new DataTable();
					if (_key.Equals("ProcesoExportarListadoPercepcionIIBBClientes"))
						result = rep_ListadoDePercepcionDeIngresosBrutos.GetList(this._fechaDesde, this._fechaHasta);
					else
					{
						if (_key.Equals("ProcesoExportarListadoRetencionIIBBProveedores"))
							result = rep_ListadoDeRetencionDeIngresosBrutos.GetList(this._fechaDesde, this._fechaHasta);
					}
					
					foreach(DataRow row in result.Rows)
						debugWriter.WriteLine( Convert.ToString(row["IIBB"]) );
					debugWriter.Flush();
					return true;

				}
				catch (Exception exp)
				{
					return false;
				}
			}
			return false;
		}

		public void Commit()
		{
						
		}

		public void Flush()
		{
						
		}


		#endregion

		public bool PreguntarAlCancelar
		{
			get 
			{
				bool _preguntarAlCancelar = Variables.GetValueBool("ExportarPercepcionIB.PreguntarAlCancelar",false);
				return _preguntarAlCancelar ;
			}
		}

	}
}

//German 20120412 - Tarea 0000286