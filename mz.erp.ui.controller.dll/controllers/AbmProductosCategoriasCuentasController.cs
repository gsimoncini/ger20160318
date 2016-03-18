/* Silvina 20111104 - Tarea 0000222 */
using System;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using System.Text;
using System.Collections;
using System.Data;

namespace mz.erp.ui.controllers
{
    public class AbmProductosCategoriasCuentasController: ITaskController
    {

    	#region Contructores

        public AbmProductosCategoriasCuentasController(AbmProductosCategoriasCuentas model)
		{
			_brClass = model;
			Init();
		}

		private void Init()
		{
		}
		
		#endregion

        #region Variables Privadas

        private AbmProductosCategoriasCuentas _brClass;

        #endregion

        #region Propiedades

        public string LeyendaFormulario
        {
            get { return _brClass.LeyendaFormulario; }
        }

        public bool PreguntarAlCancelar
        {
            get { return _brClass.PreguntarAlCancelar; }
        }

        public string EtiquetaCuentas
        {
            get { return _brClass.EtiquetaCuentas; }
        }

        public string EtiquetaProductos
        {
            get { return _brClass.EtiquetaProductos; }
        }

        public string JerarquiaCuentas
        {
            get { return _brClass.JerarquiaCuentas; }
        }

        public string JerarquiaProductos
        {
            get { return _brClass.JerarquiaProductos; }
        }

        public string IdListaDePrecios
        {
            get { return _brClass.IdListaDePrecios; }
            set { _brClass.IdListaDePrecios = value; }
        }

        public string ListaDePrecios
        {
            get { return _brClass.ListaDePrecios; }
            set { _brClass.ListaDePrecios = value; }
        }

        public ArrayList ItemsJerarquiasCuenta
        {
            get { return _brClass.ItemsJerarquiasCuenta; }
            set { _brClass.ItemsJerarquiasCuenta = value; }
        }

        public ArrayList ItemsJerarquiasProducto
        {
            get { return _brClass.ItemsJerarquiasProducto; }
            set { _brClass.ItemsJerarquiasProducto = value; }
        }

        public ArrayList Tabla
        {
            get { return _brClass.Tabla; }
            set { _brClass.Tabla = value; }
        }

        #endregion

        #region Miembros de ITaskController

        public string GetWarnings()
        {
            return null;
        }

        public void Continue()
        {

        }

        public mz.erp.businessrules.ItemsDatasetErrors GetErrors()
        {
            return _brClass.GetErrors();
        }

        public void Execute()
        {
            _brClass.Execute();
        }

        public void Previous()
        {
            _brClass.Previous();
        }

        public bool AllowShow()
        {
            return _brClass.AllowShow();
        }

        public bool AllowPrevious()
        {
            return false;
        }

        private ProcessControllerManager _processManager;
        public void SetProcessManager(ProcessControllerManager processManager)
        {
            _processManager = processManager;
        }

        public ProcessControllerManager GetProcessManager()
        {
            return _processManager;
        }

        public string GetTaskName()
        {
            return _brClass.GetTaskName();
        }

        public string GetProcessName()
        {
            return _processManager.GetProcessName();
        }

        public bool IsFirstTask()
        {

            return _processManager.IsFirstTask(_brClass.GetTaskName());
        }

        public bool IsNextState()
        {
            return _processManager.IsNextState();
        }

        public bool IsBackState()
        {
            return _processManager.IsBackState();
        }

        public bool IsFlushedState()
        {
            return false;
        }
        #endregion

        public string GetLayout()
        {
            string[] _fieldList = null;
            ArrayList fl = new ArrayList();
            int i = 0;
            StringBuilder sb = new StringBuilder();
            sb.Append(LayoutBuilder.GetHeader());


            if (fl.Contains("IdNomenclaturaCuenta") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "IdNomenclaturaCuenta", "IdNomenclaturaCuenta", true));
            if (fl.Contains("IdNomenclaturaProducto") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "IdNomenclaturaProducto", "IdNomenclaturaProducto", true));
            if (fl.Contains("IdListaDePrecios") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "IdListaDePrecios", "IdListaDePrecios", true));

            if (fl.Contains("CategoriaCuenta") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "CategoriaCuenta", "Categoría Cliente", 345));
            if (fl.Contains("CategoriaProducto") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "CategoriaProducto", "Categoría Producto", 345));
            if (fl.Contains("ListaDePrecios") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "ListaDePrecios", "Lista De Precios", 150));
            if (fl.Contains("Estado") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "Estado", "Estado", true));

            sb.Append(LayoutBuilder.GetFooter());

            return sb.ToString();

        }

        public void Eliminar(ProductosCategoriasCuentas row)
        {
            _brClass.Eliminar(row);
        }

        public void Agregar()
        {
            _brClass.Agregar();
        }

    }
}
