using System;
using System.Collections.Generic;
using System.Text;
using mz.erp.businessrules;

namespace mz.erp.ui.controller.dll.controllers
{
	/// <summary>
	/// Descripción breve de ExportarPercepcionIBClientesController.
	/// </summary>
	public class ExportarCitiVentasController
	{
        public ExportarCitiVentasController()
        {		_brClass = new ExportarCitiVentas();
			    Init();
        }

	    #region Variables Privadas
	    private ExportarCitiVentas _brClass;
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
		    string leyenda = Variables.GetValueString("Momentos.ExportarListado.ExportarCitiVentas.LeyendaFormulario");
		    if (leyenda.Equals(string.Empty))
		    {
			    leyenda = "Exportar CITI VENTAS";
		    }
		    this._leyendaFormulario = leyenda;

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
