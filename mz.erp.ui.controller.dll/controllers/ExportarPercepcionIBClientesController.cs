//German 20120412 - Tarea 0000286
using System;
using mz.erp.businessrules;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ExportarImpuestosController.
	/// </summary>
	public class ExportarImpuestosController
	{
		public ExportarImpuestosController()
		{
			_brClass = new ExportarImpuestos();
			Init();
		}

		public ExportarImpuestosController(string key)
		{
			_brClass = new ExportarImpuestos(key);
			Init();
		}

		#region Variables Privadas
		private ExportarImpuestos _brClass;
		private string _leyendaFormulario = string.Empty;
		#endregion

		#region Propiedades
		public DateTime FechaDesde
		{
			get{return this._brClass.FechaDesde;}
			set{this._brClass.FechaDesde = value;}
		}

		public DateTime FechaHasta
		{
			get{return this._brClass.FechaHasta;}
			set{this._brClass.FechaHasta = value;}
		}

		public string FilePath
		{
			get{return _brClass.FilePath;}
			set{_brClass.FilePath = value;}
		}
		
		#endregion

		#region Metodos Privados
		private void Init()
		{
			SetLeyendaFormulario();			
		}

		private void SetLeyendaFormulario()
		{
//			string leyenda = Variables.GetValueString("Momentos.ExportarListado.ExportarListadoPercepcionesIIBBClientes.LeyendaFormulario");
//			if (leyenda.Equals(string.Empty))
//			{
//				leyenda = "Exportar Percepciones de IIBB de Clientes";
//			}

			this._leyendaFormulario = _brClass.Leyenda;
		}

		#endregion

		public string LeyendaFormulario
		{
			get {return this._leyendaFormulario;}
		}

		public bool ExportarDatos()
		{
			return _brClass.ExportarDatos();
		}

		public bool PreguntarAlCancelar
		{
			get {return _brClass.PreguntarAlCancelar;}
		}
	}
}
//Fin German 20120412 - Tarea 0000286