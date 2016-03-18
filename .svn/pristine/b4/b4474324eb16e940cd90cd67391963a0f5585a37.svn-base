using System;
using System.Data;
using mz.erp.businessrules.comprobantes;
using mz.erp.commontypes.data;
using System.Collections;
using mz.erp.commontypes;
using System.Data.OleDb;
using mz.erp.systemframework;

namespace mz.erp.businessrules
{
    /// <summary>
    /// Descripción breve de ModificarPreciosMasivoDesdeExcel.
    /// </summary>
    public class ModificarPreciosMasivoDesdeExcel : ITask, IPersistentTask
    {
        #region Constructores

        public ModificarPreciosMasivoDesdeExcel()
        {
        }
        #endregion

        #region Variables Privadas
        private DataTable _result = new DataTable();
        private tpu_ProveedoresProductosDataset _dataProveedoresProductos = new tpu_ProveedoresProductosDataset();
        tsh_ProductosExDataset _dataProductosNuevos = new tsh_ProductosExDataset();
        private bool _bonificacionesAcumulativas = true;
        private ArrayList _productos = new ArrayList();
        private bool _usaCotizacionDefault = true;
        private static ArrayList dependenciasImpuestos = new ArrayList();

        //Sabrina Tarea 77
        private bool _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista = false;
        string _idVisualizacionDeStock;
        private bool _calculaPPP = true;
        private Producto _productoSeleccionado;
        private ListaDePreciosProveedoresItem _itemSeleccionado;
        private bool _codigoAutomatico = false;
        private bool _usaPrecioDeCostoReposicion = false;
        private ArrayList _impuestosPermitidos = new ArrayList();

        //German 20091023 - Tarea 477
        private ArrayList _productosRepetidos = new ArrayList();
        //Fin German 20091023 - Tarea 477

        //Sabrina 20100706 - Tarea 790
        private bool _precioDeVentaAfectaMac = Variables.GetValueBool("Productos.Precio.PrecioDeVentaAfectaMac", false);
        //Fin Sabrina 20100706 - Tarea 790
        #endregion

        #region Eventos
        public event System.EventHandler DataChanged;
        #endregion

        #region Propiedades
        private string _textoBotonAnterior = "Anterior";
        public string TextoBotonAnterior
        {
            get
            {
                string valor = String.Empty;
                string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonAnterior";
                valor = Variables.GetValueString(variable);
                if (valor == String.Empty)
                {
                    variable = "Sistema.Interfaz.TextoBotonAnterior";
                    valor = Variables.GetValueString(variable);
                }
                if (valor == String.Empty)
                {
                    return _textoBotonAnterior;
                }
                else
                {
                    return valor;
                }
            }
        }
        private string _textoBotonSiguiente = "Siguiente";
        public string TextoBotonSiguiente
        {
            get
            {
                string valor = String.Empty;
                string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonSiguiente";
                valor = Variables.GetValueString(variable);
                if (valor == String.Empty)
                {
                    variable = "Sistema.Interfaz.TextoBotonSiguiente";
                    valor = Variables.GetValueString(variable);
                }
                if (valor == String.Empty)
                {
                    return _textoBotonSiguiente;
                }
                else
                {
                    return valor;
                }
            }
        }

        private string _leyendaFormulario = "";
        public string LeyendaFormulario
        {
            get
            {
                string valor = String.Empty;
                string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "LeyendaFormulario";
                valor = Variables.GetValueString(variable);

                if (valor == String.Empty)
                {
                    return _leyendaFormulario;
                }
                else
                {
                    return valor;
                }
            }
        }

        public bool PreguntarAlCancelar
        {
            get
            {
                bool _preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName, _taskName, "PreguntarAlCancelar", false);
                return _preguntarAlCancelar;
            }
        }

        private string _pathArchivoExcel = Variables.GetValueString("Productos.Precios.ActualizacionAutomatica.Path");
        public string PathArchivoExcel
        {
            get
            {
                return _pathArchivoExcel;
            }

        }

        private string _nombreArchivoExcel = Variables.GetValueString("Productos.Precios.ActualizacionAutomatica.NombreArchivo");
        public string NombreArchivoExcel
        {
            get
            {
                return _nombreArchivoExcel;
            }
        }

        private string _nombreHojaArchivoExcel = Variables.GetValueString("Productos.Precios.ActualizacionAutomatica.NombreHoja");
        public string NombreHojaArchivoExcel
        {
            get
            {
                return _nombreHojaArchivoExcel;
            }
        }

        private string _archivoExcel = string.Empty;
        public string ArchivoExcel
        {
            get
            {
                return _archivoExcel;
            }
            set { _archivoExcel = value; }

        }

        private string _codigoProveedor = string.Empty;
        public string CodigoProveedor
        {
            get { return _codigoProveedor; }
            set
            {
                if (_codigoProveedor != value)
                {
                    _codigoProveedor = value;
                }
            }
        }

        private bool _porCodigo = true;
        public bool PorCodigo
        {
            get { return _porCodigo; }
            set
            {
                if (_porCodigo != value)
                {
                    _porCodigo = value;
                }
            }
        }


        private bool _porCodigoSecundario = false;
        public bool PorCodigoSecundario
        {
            get { return _porCodigoSecundario; }
            set
            {
                if (_porCodigoSecundario != value)
                {
                    _porCodigoSecundario = value;
                }
            }
        }

        private bool _porCodigoProveedor = false;
        public bool PorCodigoProveedor
        {
            get { return _porCodigoProveedor; }
            set
            {
                if (_porCodigoProveedor != value)
                {
                    _porCodigoProveedor = value;
                }
            }
        }


        private bool _agregaProductosNuevos = false;
        public bool AgregaProductosNuevos
        {
            get { return _agregaProductosNuevos; }
            set
            {
                if (_agregaProductosNuevos != value)
                {
                    _agregaProductosNuevos = value;
                }
            }
        }

        private bool _percibeIB = true;
        public bool PercibeIB
        {
            get { return _percibeIB; }
            set
            {
                if (_percibeIB != value)
                {
                    _percibeIB = value;
                }
            }
        }

        private ArrayList _impuestosDirectosAAgregar = new ArrayList();
        public ArrayList ImpuestosDirectosAAgregar
        {
            get { return _impuestosDirectosAAgregar; }
        }

        private Hashtable _impuestosDirectosAAgregarPorProducto = new Hashtable();
        public Hashtable ImpuestosDirectosAAgregarPorProducto
        {
            get { return _impuestosDirectosAAgregarPorProducto; }
        }


        private bool _IVA = false;
        public bool IVA
        {
            get { return _IVA; }
            set
            {
                if (_IVA != value)
                {
                    _IVA = value;
                }
            }
        }

        private bool _IVADIF = false;
        public bool IVADIF
        {
            get { return _IVADIF; }
            set
            {
                if (_IVADIF != value)
                {
                    _IVADIF = value;
                }
            }
        }

        private bool _EX = false;
        public bool EX
        {
            get { return _EX; }
            set
            {
                if (_EX != value)
                {
                    _EX = value;
                }
            }
        }

        public DataTable Result
        {
            get { return _result; }
        }

        private bool _modificaBonificaciones = true;
        public bool ModificaBonificaciones
        {
            get { return _modificaBonificaciones; }
            set
            {
                if (_modificaBonificaciones != value)
                {
                    _modificaBonificaciones = value;
                }
            }
        }

        private bool _modificaPrecioDeCosto = true;
        public bool ModificaPrecioDeCosto
        {
            get { return _modificaPrecioDeCosto; }
            set
            {
                if (_modificaPrecioDeCosto != value)
                {
                    _modificaPrecioDeCosto = value;
                }
            }
        }

        private bool _modificaProductosInactivos = true;
        public bool ModificaProductosInactivos
        {
            get { return _modificaProductosInactivos; }
            set
            {
                if (_modificaProductosInactivos != value)
                {
                    _modificaProductosInactivos = value;
                }
            }
        }

        private bool _byJerarquia1 = false;
        public bool ByJerarquia1
        {
            get { return _byJerarquia1; }
            set { _byJerarquia1 = value; }
        }

        private bool _byJerarquia2 = false;
        public bool ByJerarquia2
        {
            get { return _byJerarquia2; }
            set { _byJerarquia2 = value; }
        }

        private bool _byJerarquia3 = false;
        public bool ByJerarquia3
        {
            get { return _byJerarquia3; }
            set { _byJerarquia3 = value; }
        }

        private bool _byJerarquia4 = false;
        public bool ByJerarquia4
        {
            get { return _byJerarquia4; }
            set { _byJerarquia4 = value; }
        }

        private bool _byJerarquia5 = false;
        public bool ByJerarquia5
        {
            get { return _byJerarquia5; }
            set { _byJerarquia5 = value; }
        }

        private bool _byJerarquia6 = false;
        public bool ByJerarquia6
        {
            get { return _byJerarquia6; }
            set { _byJerarquia6 = value; }
        }

        private bool _byJerarquia7 = false;
        public bool ByJerarquia7
        {
            get { return _byJerarquia7; }
            set { _byJerarquia7 = value; }
        }

        private bool _byJerarquia8 = false;
        public bool ByJerarquia8
        {
            get { return _byJerarquia8; }
            set { _byJerarquia8 = value; }
        }

        private ArrayList _jerarquia1 = new ArrayList();
        public ArrayList Jerarquia1
        {
            get { return _jerarquia1; }
            set { _jerarquia1 = value; }
        }

        private ArrayList _jerarquia2 = new ArrayList();
        public ArrayList Jerarquia2
        {
            get { return _jerarquia2; }
            set { _jerarquia2 = value; }
        }

        private ArrayList _jerarquia3 = new ArrayList();
        public ArrayList Jerarquia3
        {
            get { return _jerarquia3; }
            set { _jerarquia3 = value; }
        }

        private ArrayList _jerarquia4 = new ArrayList();
        public ArrayList Jerarquia4
        {
            get { return _jerarquia4; }
            set { _jerarquia4 = value; }
        }

        private ArrayList _jerarquia5 = new ArrayList();
        public ArrayList Jerarquia5
        {
            get { return _jerarquia5; }
            set { _jerarquia5 = value; }

        }

        private ArrayList _jerarquia6 = new ArrayList();
        public ArrayList Jerarquia6
        {
            get { return _jerarquia6; }
            set { _jerarquia6 = value; }
        }

        private ArrayList _jerarquia7 = new ArrayList();
        public ArrayList Jerarquia7
        {
            get { return _jerarquia7; }
            set { _jerarquia7 = value; }
        }

        private ArrayList _jerarquia8 = new ArrayList();
        public ArrayList Jerarquia8
        {
            get { return _jerarquia8; }
            set { _jerarquia8 = value; }
        }

        private string _contenedoresVisibles = string.Empty;
        public string ContenedoresVisibles
        {
            get { return _contenedoresVisibles; }
        }

        private bool _pcioDeVtaContieneImpuestos = false;
        public bool PcioDeVtaContieneImpuestos
        {
            get { return _pcioDeVtaContieneImpuestos; }
            set
            {
                if (_pcioDeVtaContieneImpuestos != value)
                {
                    _pcioDeVtaContieneImpuestos = value;
                }
            }
        }

        //German 20120202 - Tarea 0000273
        private bool _precioDeVentaTieneImpuestos = false;
        public bool PrecioDeVentaTieneImpuestos
        {
            get { return _precioDeVentaTieneImpuestos; }
            set { _precioDeVentaTieneImpuestos = value; }
        }

        //German 20120202 - Tarea 0000273

        private bool _modificaCodigoSecundario = false;
        public bool ModificaCodigoSecundario
        {
            get { return _modificaCodigoSecundario; }
            set
            {
                if (_modificaCodigoSecundario != value)
                {
                    _modificaCodigoSecundario = value;
                }
            }
        }

        private bool _modificaCodigoProveedor = false;
        public bool ModificaCodigoProveedor
        {
            get { return _modificaCodigoProveedor; }
            set
            {
                if (_modificaCodigoProveedor != value)
                {
                    _modificaCodigoProveedor = value;
                }
            }
        }

        private bool _modificaCamposAuxiliares = false;
        public bool ModificaCamposAuxiliares
        {
            get { return _modificaCamposAuxiliares; }
            set
            {
                if (_modificaCamposAuxiliares != value)
                {
                    _modificaCamposAuxiliares = value;
                }
            }
        }

        private bool _modificaDescripcion = false;
        public bool ModificaDescripcion
        {
            get { return _modificaDescripcion; }
            set
            {
                if (_modificaDescripcion != value)
                {
                    _modificaDescripcion = value;
                }
            }
        }

        private bool _modificaJerarquia1 = false;
        public bool ModificaJerarquia1
        {
            get { return _modificaJerarquia1; }
            set
            {
                if (_modificaJerarquia1 != value)
                {
                    _modificaJerarquia1 = value;
                }
            }
        }

        private bool _modificaJerarquia2 = false;
        public bool ModificaJerarquia2
        {
            get { return _modificaJerarquia2; }
            set
            {
                if (_modificaJerarquia2 != value)
                {
                    _modificaJerarquia2 = value;
                }
            }
        }
        private bool _modificaJerarquia3 = false;
        public bool ModificaJerarquia3
        {
            get { return _modificaJerarquia3; }
            set
            {
                if (_modificaJerarquia3 != value)
                {
                    _modificaJerarquia3 = value;
                }
            }
        }
        private bool _modificaJerarquia4 = false;
        public bool ModificaJerarquia4
        {
            get { return _modificaJerarquia4; }
            set
            {
                if (_modificaJerarquia4 != value)
                {
                    _modificaJerarquia4 = value;
                }
            }
        }
        private bool _modificaJerarquia5 = false;
        public bool ModificaJerarquia5
        {
            get { return _modificaJerarquia5; }
            set
            {
                if (_modificaJerarquia5 != value)
                {
                    _modificaJerarquia5 = value;
                }
            }
        }
        private bool _modificaJerarquia6 = false;
        public bool ModificaJerarquia6
        {
            get { return _modificaJerarquia6; }
            set
            {
                if (_modificaJerarquia6 != value)
                {
                    _modificaJerarquia6 = value;
                }
            }
        }
        private bool _modificaJerarquia7 = false;
        public bool ModificaJerarquia7
        {
            get { return _modificaJerarquia7; }
            set
            {
                if (_modificaJerarquia7 != value)
                {
                    _modificaJerarquia7 = value;
                }
            }
        }
        private bool _modificaJerarquia8 = false;
        public bool ModificaJerarquia8
        {
            get { return _modificaJerarquia8; }
            set
            {
                if (_modificaJerarquia8 != value)
                {
                    _modificaJerarquia8 = value;
                }
            }
        }

        private bool _habilitaJerarquia1 = !Variables.GetValueString("Productos.BusquedaJerarquica.Jerarquia1").Equals(string.Empty);
        public bool HabilitaJerarquia1
        {
            get { return _habilitaJerarquia1; }
        }

        private bool _habilitaJerarquia2 = !Variables.GetValueString("Productos.BusquedaJerarquica.Jerarquia2").Equals(string.Empty);
        public bool HabilitaJerarquia2
        {
            get { return _habilitaJerarquia2; }
        }

        private bool _habilitaJerarquia3 = !Variables.GetValueString("Productos.BusquedaJerarquica.Jerarquia3").Equals(string.Empty);
        public bool HabilitaJerarquia3
        {
            get { return _habilitaJerarquia3; }
        }

        private bool _habilitaJerarquia4 = !Variables.GetValueString("Productos.BusquedaJerarquica.Jerarquia4").Equals(string.Empty);
        public bool HabilitaJerarquia4
        {
            get { return _habilitaJerarquia4; }
        }

        private bool _habilitaJerarquia5 = !Variables.GetValueString("Productos.BusquedaJerarquica.Jerarquia5").Equals(string.Empty);
        public bool HabilitaJerarquia5
        {
            get { return _habilitaJerarquia5; }
        }

        private bool _habilitaJerarquia6 = !Variables.GetValueString("Productos.BusquedaJerarquica.Jerarquia6").Equals(string.Empty);
        public bool HabilitaJerarquia6
        {
            get { return _habilitaJerarquia6; }
        }

        private bool _habilitaJerarquia7 = !Variables.GetValueString("Productos.BusquedaJerarquica.Jerarquia7").Equals(string.Empty);
        public bool HabilitaJerarquia7
        {
            get { return _habilitaJerarquia7; }
        }

        private bool _habilitaJerarquia8 = !Variables.GetValueString("Productos.BusquedaJerarquica.Jerarquia8").Equals(string.Empty);
        public bool HabilitaJerarquia8
        {
            get { return _habilitaJerarquia8; }
        }

        private bool _agregaListaDePreciosNuevas = false;
        public bool AgregaListaDePreciosNuevas
        {
            get { return _agregaListaDePreciosNuevas; }
            set
            {
                if (_agregaListaDePreciosNuevas != value)
                {
                    _agregaListaDePreciosNuevas = value;
                }
            }
        }


        //German 20091023 - Tarea 477
        public ArrayList ProductosRepetidos
        {
            get
            {
                return _productosRepetidos;
            }
        }
        //Fin German 20091023 - Tarea 477

        //Sabrina 20100615 - Tarea 764
        private bool _habilitaListasDePrecios = Variables.GetValueBool("Productos.ListasDePrecios");
        public bool HabilitaListasDePrecios
        {
            get { return _habilitaListasDePrecios; }
        }

        ArrayList _listasDePrecios = new ArrayList();
        public ArrayList ListasDePrecios
        {
            get
            {
                return _listasDePrecios;
            }
        }

        ArrayList _listasDePreciosSeleccionadas = new ArrayList();
        public ArrayList ListasDePreciosSeleccionadas
        {
            set
            {
                _listasDePreciosSeleccionadas = value;
            }
        }
        //Fin Sabrina 20100615 - Tarea 764

        //Sabrina: Tarea 1068. 20110317
        private bool _actualizaPreciosProductosCombo = false;
        public bool ActualizaPreciosProductosCombo
        {
            get { return _actualizaPreciosProductosCombo; }
            set { _actualizaPreciosProductosCombo = value; }
        }
        //Fin Sabrina: Tarea 1068. 20110317

        //German 20120202 - Tarea 0000273
        private bool _actualizaListasDePreciosDeVentaDesdeExcel = false;
        public bool ActualizaListasDePreciosDeVentaDesdeExcel
        {
            get { return _actualizaListasDePreciosDeVentaDesdeExcel; }
        }

        ArrayList _listasDePreciosSeleccionadas2 = new ArrayList();
        public ArrayList ListasDePreciosSeleccionadas2
        {
            set
            {
                _listasDePreciosSeleccionadas2 = value;
            }
        }
        //Fin German 20120202 - Tarea 0000273

        #endregion

        #region Miembros de ITask

        private string _taskName = string.Empty;
        private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
        private ProcessManager _processParent;

        public event System.EventHandler ObjectHasChanged;

        public event System.EventHandler OnTaskBeforeExecute;

        public event System.EventHandler OnTaskAfterExecute;

        public event System.EventHandler OnTaskBeforePrevious;

        public event System.EventHandler OnTaskAfterPrevious;

        public void ListenerTaskDependentChanged(object sender)
        {

        }

        public void ListenerAfterExecuteDependentTask(object sender)
        {

        }




        public void ListenerBeforeExecuteDependentTask(object sender)
        {

        }

        public void Init()
        {
            _bonificacionesAcumulativas = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "BonificacionAcumulativa");
            string _impuestosPorDefecto = Variables.GetValueString("Productos.Impuestos.Default");
            ArrayList ArrImpuestosDefault = systemframework.Util.Parse(_impuestosPorDefecto, ",");
            foreach (string Impuesto in ArrImpuestosDefault)
            {
                if (Impuesto.Equals("IVA"))
                    IVA = true;
                if (Impuesto.Equals("IVADIF"))
                    IVADIF = true;
                if (Impuesto.Equals("EX"))
                    EX = true;
            }
            _usaCotizacionDefault = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "UsaCotizacionDefault");
            string ImpuestosDependientes = Variables.GetValueString("Productos.Validaciones.ImpuestosDependientes");
            string[] ListaImpuestosDependientes = ImpuestosDependientes.Split(',');
            if (ListaImpuestosDependientes.Length > 0)
            {
                dependenciasImpuestos = new ArrayList();
                for (int i = 0; i < ListaImpuestosDependientes.Length; i++)
                {
                    string[] atupla = ListaImpuestosDependientes[i].Split(':');
                    if (atupla.Length == 2)
                    {
                        ArrayList aux = new ArrayList();
                        aux.Add(atupla[0]);
                        aux.Add(atupla[1]);
                        dependenciasImpuestos.Add(aux);
                    }
                }
            }


            //Sabrina Tarea 77
            _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "ModificaPrecioDeCostoListaProveedorTrasladaPrecioDeVentaBruto", "Productos.Precio.ModificaPrecioDeCostoListaProveedorTrasladaPrecioDeVentaBruto");
            _idVisualizacionDeStock = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "VisualizacionDeStock");
            _calculaPPP = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "PrecioDeCosto.CalculaPPP", "Productos.PrecioDeCosto.CalculaPPP", _calculaPPP);

            _codigoAutomatico = Variables.GetValueBool("Productos.CodigoAutomatico");

            _pathArchivoExcel = Variables.GetValueStringDefault(this._processParent.Process.ProcessName, this._taskName, "ActualizacionAutomatica.Path", _pathArchivoExcel);
            _nombreArchivoExcel = Variables.GetValueStringDefault(this._processParent.Process.ProcessName, this._taskName, "ActualizacionAutomatica.NombreArchivo", _nombreArchivoExcel);
            _nombreHojaArchivoExcel = Variables.GetValueStringDefault(this._processParent.Process.ProcessName, this._taskName, "ActualizacionAutomatica.NombreHoja", _nombreHojaArchivoExcel);

            _archivoExcel = this.PathArchivoExcel + @"\" + this.NombreArchivoExcel;

            _usaPrecioDeCostoReposicion = Variables.GetValueBool("Productos.PrecioDeCosto.UsaPrecioDeCostoReposicion");

            _contenedoresVisibles = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "ContenedoresVisibles");

            string imp = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "ImpuestosValidos");
            if (!imp.Equals(string.Empty))
                _impuestosPermitidos = mz.erp.systemframework.Util.Parse(imp, ",");

            //Sabrina 20100615 - Tarea 764
            //Cargo las listas de precios
            _listasDePrecios.Clear();
            DataTable listaDePreciosDT = tsh_ListasDePrecios.GetList().tsh_ListasDePrecios;
            foreach (System.Data.DataRow row in listaDePreciosDT.Rows)
            {
                string id = row["IdListaDePrecio"].ToString();
                string descripcion = row["Descripcion"].ToString();
                ListaDePreciosView lista = new ListaDePreciosView(id, descripcion);
                _listasDePrecios.Add(lista);
            }
            //Fin Sabrina 20100615 - Tarea 764

            //German 20120202 - Tarea 0000273
            _actualizaListasDePreciosDeVentaDesdeExcel = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName,"ActualizacionAutomatica.ActualizaListasPreciosDeVenta", false);
            //Fin German 20120202 - Tarea 0000273
            
        }



        public bool IsValidForStartProcess()
        {
            _errores.Clear();
            WorkflowValidator validator = new WorkflowValidator();
            long IdTarea = Workflow.GetIdTakByName(_taskName);
            bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess, IdTarea, this);
            _errores.AddAll(validator.GetErrors());
            return IsValid;
        }

        public bool IsValid()
        {

            _errores.Clear();
            bool isvalid = true;
            if (this._processParent.Process.ProcessName.Equals("ProcesoModificarPreciosMasivoDesdeExcel") && !IsValidProveedor())
            {
                isvalid = false;
                _errores.Add(new ItemDatasetError("Modificar Precios Masivo desde Excel", "Proveedor", "Debe seleccionar un proveedor."));
            }
            if (this._processParent.Process.ProcessName.Equals("ProcesoModificarPreciosVentaMasivoDesdeExcel"))
            {
                if (AgregaProductosNuevos)
                {
                    foreach (DataRow row in _result.Rows)
                    {
                        string IdProducto = Convert.ToString(row["IdProducto"]);
                        string CodigoIngresado = Convert.ToString(row["Codigo"]);
                        if ((IdProducto == null || IdProducto.Equals(string.Empty)))//No existe el producto en tsh_Productos
                        {
                            if (row["IVA"] == System.DBNull.Value || row["IVA"].ToString().Equals(string.Empty)) //No ingreso el impuesto a aplicar
                            {
                                _errores.Add(new ItemDatasetError("Modificar Precios Masivo desde Excel", "IVA", "Debe ingresar el IVA para el producto " + CodigoIngresado + " o en su defecto no agregar los mismos."));
                                isvalid = false;
                            }
                            else //Valido q el iva ingresado sea correcto
                            {
                                string IVA = Convert.ToString(row["IVA"]);
                                if (!_impuestosPermitidos.Contains(IVA))
                                {
                                    _errores.Add(new ItemDatasetError("Modificar Precios Masivo desde Excel", "IVA", "El IVA ingresado para el producto " + CodigoIngresado + " no es valido."));
                                    isvalid = false;

                                }
                            }
                            if (row["Descripcion"] == System.DBNull.Value || row["Descripcion"].ToString().Equals(string.Empty)) //No ingreso la descripcion del producto
                            {
                                _errores.Add(new ItemDatasetError("Modificar Precios Masivo desde Excel", "Descripción", "Debe ingresar la descripción para el producto " + CodigoIngresado + " o en su defecto no agregar los mismos."));
                                isvalid = false;
                            }
                        }
                    }
                }
            }
            if (!IsDatosObigatorios())
            {
                isvalid = false;
            }
            if (isvalid)
                isvalid = Validar();
            return isvalid;

        }

        private bool IsValidProveedor()
        {
            return !CodigoProveedor.Equals(string.Empty);
        }

        private bool IsDatosObigatorios()
        {
            bool okBonif = true;
            bool okPcioCto = true;
            bool okCodigo = true;
            bool okCodigoSecundario = true;
            bool okCodigoProveedor = true;
            bool okDescripcion = true;
            if (this._processParent.Process.ProcessName.Equals("ProcesoModificarPreciosMasivoDesdeExcel"))
            {
                if (ModificaBonificaciones) //Si seteo q modifica las bonificaciones se valida q haya ingresado todas ellas.
                {
                    int i = 0;
                    while (okBonif && i < _result.Rows.Count)
                    {
                        DataRow row = _result.Rows[i];
                        bool ok1 = (row["Coeficiente1"] != System.DBNull.Value && row["Coeficiente1"].ToString() != string.Empty);
                        bool ok2 = (row["Coeficiente2"] != System.DBNull.Value && row["Coeficiente2"].ToString() != string.Empty);
                        bool ok3 = (row["Coeficiente3"] != System.DBNull.Value && row["Coeficiente3"].ToString() != string.Empty);
                        bool ok4 = (row["Coeficiente4"] != System.DBNull.Value && row["Coeficiente4"].ToString() != string.Empty);
                        bool ok5 = (row["Coeficiente5"] != System.DBNull.Value && row["Coeficiente5"].ToString() != string.Empty);
                        okBonif = ok1 && ok2 && ok3 && ok4 && ok5;
                        i++;
                    }
                    if (!okBonif)
                        _errores.Add(new ItemDatasetError("Modificar Precios Masivo desde Excel", "Bonificaciones", "Debe ingresar todas los valores de las bonificaciones para todos los productos o en su defecto no modificar las mismas."));
                }
                if (ModificaPrecioDeCosto) //Si seteo q modifica el precio de costo se valida q haya ingresado el mismo para todos los productos.
                {
                    int j = 0;
                    while (okPcioCto && j < _result.Rows.Count)
                    {
                        DataRow row = _result.Rows[j];
                        okPcioCto = (row["PrecioDeCosto"] != System.DBNull.Value && row["PrecioDeCosto"].ToString() != string.Empty);
                        j++;
                    }
                    if (!okPcioCto)
                        _errores.Add(new ItemDatasetError("Modificar Precios Masivo desde Excel", "Precio de Costo", "Debe ingresar el precio de costo para todos los productos o en su defecto no modificar el mismo."));
                }
            }

            if (this._processParent.Process.ProcessName.Equals("ProcesoModificarPreciosVentaMasivoDesdeExcel"))
            {
                if (ModificaCodigoSecundario)
                {
                    int i = 0;
                    while (okCodigoSecundario && i < _result.Rows.Count)
                    {
                        DataRow row = _result.Rows[i];
                        string IdProducto = Convert.ToString(row["IdProducto"]);
                        if ((row["CodigoSecundario"] == System.DBNull.Value || row["CodigoSecundario"].ToString().Equals(string.Empty))) //No ingreso codigo secundario
                        {
                            okCodigoSecundario = false;
                        }

                        i++;
                    }
                    if (!okCodigoSecundario)
                        _errores.Add(new ItemDatasetError("Modificar Precios Masivo desde Excel", "Código Secundario", "Debe ingresar el Codigo Secundario para todos los productos o en su defecto no modificar los mismos."));
                }
                if (ModificaCodigoProveedor)
                {
                    int j = 0;
                    while (okCodigoProveedor && j < _result.Rows.Count)
                    {
                        DataRow row = _result.Rows[j];
                        string IdProducto = Convert.ToString(row["IdProducto"]);
                        if ((row["CodigoProveedor"] == System.DBNull.Value || row["CodigoProveedor"].ToString().Equals(string.Empty))) //No ingreso codigo de proveedor
                        {
                            okCodigoProveedor = false;
                        }

                        j++;
                    }
                    if (!okCodigoProveedor)
                        _errores.Add(new ItemDatasetError("Modificar Precios Masivo desde Excel", "Código Proveedor", "Debe ingresar el Codigo Proveedor para todos los productos o en su defecto no modificar los mismos."));
                }
                if (ModificaDescripcion)
                {
                    int k = 0;
                    while (okDescripcion && k < _result.Rows.Count)
                    {
                        DataRow row = _result.Rows[k];
                        string IdProducto = Convert.ToString(row["IdProducto"]);
                        if ((row["Descripcion"] == System.DBNull.Value || row["Descripcion"].ToString().Equals(string.Empty))) //No ingreso descripcion
                        {
                            okDescripcion = false;
                        }

                        k++;
                    }
                    if (!okDescripcion)
                        _errores.Add(new ItemDatasetError("Modificar Precios Masivo desde Excel", "Descripción", "Debe ingresar la descripción para todos los productos o en su defecto no modificar las mismas."));
                }
            }
            if (!_codigoAutomatico && AgregaProductosNuevos && !PorCodigo)
            {
                int k = 0;
                while (okCodigo && k < _result.Rows.Count)
                {
                    DataRow row = _result.Rows[k];
                    string CodigoIngresado = Convert.ToString(row["Codigo"]);
                    string IdProducto = string.Empty;
                    IdProducto = Convert.ToString(row["IdProducto"]);
                    if ((IdProducto == null || IdProducto.Equals(string.Empty)) && (row["CodigoAuxiliar"] == System.DBNull.Value || row["CodigoAuxiliar"].ToString().Equals(string.Empty))) //No existe el producto en tsh_Productos ingreso el codigo del mismo
                    {
                        okCodigo = false;
                    }

                    k++;
                }
                if (!okCodigo)
                    _errores.Add(new ItemDatasetError("Modificar Precios Masivo desde Excel", "Código Producto", "Debe ingresar el Codigo Auxiliar (código de producto) para todos aquellos productos que se van a crear o en su defecto no agregar los mismos."));
            }
            return okBonif && okPcioCto && okCodigo && okCodigoSecundario && okCodigoProveedor && okDescripcion;

        }


        private bool Validar()
        {

            if (this._processParent.Process.ProcessName.Equals("ProcesoModificarPreciosMasivoDesdeExcel"))
            {
                string IdProveedor = tpu_Proveedores.GetPKByCodigo(this.CodigoProveedor);
                /**
                 * Si agrega productos nuevos busco en las tablas correspondientes para luego crearlos. 
                 * Si no ignoro los productos que no existen o que no tienen al proveedor seleccionado en la lista de precios.
                 * Esta distincion es para mejorar la eficiencia. 
                 * */


                //Sabrina Tarea 77
                if (AgregaProductosNuevos)
                {
                    _productos = new ArrayList();
                    string _idMonedaReferencia = Variables.GetValueString("Contabilidad.MonedaReferencia");
                    string _idFuenteDeCambioProveedor = Variables.GetValueString("Contabilidad.FuenteDeCambioReferencia");
                    foreach (DataRow row in _result.Rows)
                    {
                        string CodigoIngresado = Convert.ToString(row["Codigo"]);
                        string IdProducto = string.Empty;
                        string Codigo = string.Empty;
                        string CodigoSecundario = string.Empty;
                        string CodigoProv = string.Empty;
                        if (PorCodigo)
                        {
                            IdProducto = Convert.ToString(row["IdProducto"]);
                            Codigo = CodigoIngresado;
                        }
                        else if (PorCodigoSecundario)
                        {
                            IdProducto = Convert.ToString(row["IdProducto"]);
                            CodigoSecundario = CodigoIngresado;
                            Codigo = Convert.ToString(row["CodigoAuxiliar"]);
                        }
                        else if (PorCodigoProveedor)
                        {
                            IdProducto = Convert.ToString(row["IdProducto"]);
                            CodigoProv = CodigoIngresado;
                            Codigo = Convert.ToString(row["CodigoAuxiliar"]);
                        }

                        Producto prod = null;
                        if (IdProducto == null || IdProducto.Equals(string.Empty)) //No existe el producto en tsh_Productos
                        {
                            string Descripcion = Convert.ToString(row["Descripcion"]);
                            prod = new Producto(Codigo, CodigoSecundario, CodigoProv, Descripcion, _idVisualizacionDeStock, _calculaPPP, _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista, _usaPrecioDeCostoReposicion);
                            prod.IdProveedorDefault = IdProveedor;
                            //Sabrina 20100615 - Tarea 764
                            prod.CargarListasDePrecios("NEW");
                            //Fin Sabrina 20100615 - Tarea 764
                            //Sabrina 20100706 - Tarea 790
                            prod.PrecioDeVentaAfectaMac = _precioDeVentaAfectaMac;
                            //Sabrina 20100706 - Tarea 790
                        }
                        else
                        {
                            prod = new Producto(IdProducto, _idVisualizacionDeStock, _calculaPPP, _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista);
                            //Sabrina 20100615 - Tarea 764
                            prod.CargarListasDePrecios("EDIT");
                            //Fin Sabrina 20100615 - Tarea 764
                            //Sabrina 20100706 - Tarea 790
                            prod.PrecioDeVentaAfectaMac = _precioDeVentaAfectaMac;
                            //Sabrina 20100706 - Tarea 790
                        }

                        ListaDePreciosProveedoresItem item = null;
                        tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow rowPP = tpu_ProveedoresProductos.GetByPk(IdProveedor, IdProducto);
                        if (rowPP == null) //No existe el producto en tpu_ProveedoresProductos
                        {
                            string IdMonedaPrecioDeCostoProveedor = prod.IdMonedaPrecioDeCosto;
                            string IdFuenteDeCambioListaProveedor = prod.IdFuenteDeCambioProductoPrecioDeCosto;
                            string IdCotizacionPrecioDeCostoProveedor = prod.IdCotizacionMonedaPrecioDeCosto;
                            string IdMonedaProveedor = prod.IdMonedaPrecioDeCosto;
                            string IdFuenteDeCambioProveedor = prod.IdFuenteDeCambioProductoPrecioDeCosto;
                            string IdCotizacionProveedor = prod.IdCotizacionMonedaPrecioDeCosto;
                            if (_usaCotizacionDefault)
                            {
                                IdMonedaProveedor = _idMonedaReferencia;
                                IdFuenteDeCambioProveedor = _idFuenteDeCambioProveedor;
                                IdCotizacionProveedor = Variables.GetValueString("Contabilidad.CotizacionReferencia");
                            }
                            //Sabrina: Tarea 1113. 20110808
                            item = new ListaDePreciosProveedoresItem(prod.IdProducto, IdProveedor, IdMonedaPrecioDeCostoProveedor, IdFuenteDeCambioListaProveedor, IdCotizacionPrecioDeCostoProveedor, IdCotizacionProveedor, IdFuenteDeCambioProveedor, IdMonedaProveedor, _bonificacionesAcumulativas, CodigoProv);

                            //German 20120202 - Tarea 0000273 //Para agregar el proveedor default si es que estan habilitadas las listas de precios de proveedores verrrrrrrrrrrrrrrrr!!!
                            if (prod.IdProveedorDefault == null || prod.IdProveedorDefault == string.Empty)
                            {
                                item.EsProveedorPorDefault = true;
                                prod.IdProveedorDefault = IdProveedor;
                            }
                            //German 20120202 - Tarea 0000273
                            //Fin Sabrina: Tarea 1113. 20110808
                        }
                        else
                            item = new ListaDePreciosProveedoresItem(rowPP);

                        prod.ListaDePreciosProveedores.AddItem(item);
                        this.SetearDatosListaDePreciosProveedoresItemExcelFromExcelRow(prod, item, row);


                        //German 20120202 - Tarea 0000273


                        if (_actualizaListasDePreciosDeVentaDesdeExcel)
                            this.SetearDatosListaDePreciosVentasFromExcelRow(prod, row);


                        //Fin German 20120202 - Tarea 0000273


                        if (row["PrecioDeCostoFinal"] != System.DBNull.Value && row["PrecioDeCostoFinal"].ToString() != string.Empty)
                        {
                            decimal precioDeCostoFinalIngresado = Decimal.Round(Convert.ToDecimal(row["PrecioDeCostoFinal"]), 1);
                            decimal diferencia = Convert.ToDecimal(0.1);
                            decimal minPrecioDeCostoFinalIngresado = precioDeCostoFinalIngresado - diferencia;
                            decimal maxPrecioDeCostoFinalIngresado = precioDeCostoFinalIngresado + diferencia;
                            decimal pcioCtoFinal = Decimal.Round(item.PrecioDeCostoFinal, 1);
                            bool cond1 = minPrecioDeCostoFinalIngresado <= pcioCtoFinal;
                            bool cond2 = maxPrecioDeCostoFinalIngresado >= pcioCtoFinal;
                            if (!(cond1 && cond2))
                                _errores.Add(new ItemDatasetError("Modificar Precios Masivo desde Excel", "Precio de Costo Final", "El precio de costo del producto " + CodigoIngresado + " no coincide con el resultante del precio de costo mas las bonificaciones."));
                        }

                        this._productos.Add(prod);
                    }
                }
                else if (AgregaListaDePreciosNuevas)
                {
                    _productos = new ArrayList();
                    string _idMonedaReferencia = Variables.GetValueString("Contabilidad.MonedaReferencia");
                    string _idFuenteDeCambioProveedor = Variables.GetValueString("Contabilidad.FuenteDeCambioReferencia");
                    foreach (DataRow row in _result.Rows)
                    {

                        string Codigo = Convert.ToString(row["Codigo"]);
                        string IdProducto = Convert.ToString(row["IdProducto"]);
                        
                        //Sabrina: Tarea 1113. 20110808
                        string CodigoProv = string.Empty;
                        if (PorCodigoProveedor)
                            CodigoProv = Codigo;
                        //Fin Sabrina: Tarea 1113. 20110808

                        if (IdProducto != null && !IdProducto.Equals(string.Empty)) //Existe el producto en tsh_Productos
                        {

                            Producto prod = new Producto(IdProducto, _idVisualizacionDeStock, _calculaPPP, _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista);
                            //Sabrina 20100615 - Tarea 764
                            prod.CargarListasDePrecios("EDIT");
                            //Fin Sabrina 20100615 - Tarea 764
                            //Sabrina 20100706 - Tarea 790
                            prod.PrecioDeVentaAfectaMac = _precioDeVentaAfectaMac;
                            //Sabrina 20100706 - Tarea 790
                            ListaDePreciosProveedoresItem item = null;
                            tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow rowPP = tpu_ProveedoresProductos.GetByPk(IdProveedor, IdProducto);
                            if (rowPP == null) //No existe el producto en tpu_ProveedoresProductos
                            {
                                string IdMonedaPrecioDeCostoProveedor = prod.IdMonedaPrecioDeCosto;
                                string IdFuenteDeCambioListaProveedor = prod.IdFuenteDeCambioProductoPrecioDeCosto;
                                string IdCotizacionPrecioDeCostoProveedor = prod.IdCotizacionMonedaPrecioDeCosto;
                                string IdMonedaProveedor = prod.IdMonedaPrecioDeCosto;
                                string IdFuenteDeCambioProveedor = prod.IdFuenteDeCambioProductoPrecioDeCosto;
                                string IdCotizacionProveedor = prod.IdCotizacionMonedaPrecioDeCosto;
                                if (_usaCotizacionDefault)
                                {
                                    IdMonedaProveedor = _idMonedaReferencia;
                                    IdFuenteDeCambioProveedor = _idFuenteDeCambioProveedor;
                                    IdCotizacionProveedor = Variables.GetValueString("Contabilidad.CotizacionReferencia");
                                }
                                //Sabrina: Tarea 1113. 20110808
                                item = new ListaDePreciosProveedoresItem(prod.IdProducto, IdProveedor, IdMonedaPrecioDeCostoProveedor, IdFuenteDeCambioListaProveedor, IdCotizacionPrecioDeCostoProveedor, IdCotizacionProveedor, IdFuenteDeCambioProveedor, IdMonedaProveedor, _bonificacionesAcumulativas, CodigoProv);
                                //Fin Sabrina: Tarea 1113. 20110808
                            }
                            else
                                item = new ListaDePreciosProveedoresItem(rowPP);

                            //German 20120202 - Tarea 0000273 //Para agregar el proveedor default si es que estan habilitadas las listas de precios de proveedores verrrrrrrrrrrrrrrrr!!!
                            if (prod.IdProveedorDefault == null || prod.IdProveedorDefault == string.Empty)
                            {
                                item.EsProveedorPorDefault = true;
                                prod.IdProveedorDefault = IdProveedor;
                            }
                            //German 20120202 - Tarea 0000273

                            prod.ListaDePreciosProveedores.AddItem(item);
                            this.SetearDatosListaDePreciosProveedoresItemExcelFromExcelRow(prod, item, row);


                            //German 20120202 - Tarea 0000273


                            if (_actualizaListasDePreciosDeVentaDesdeExcel)
                                this.SetearDatosListaDePreciosVentasFromExcelRow(prod, row);


                            //Fin German 20120202 - Tarea 0000273

                            if (row["PrecioDeCostoFinal"] != System.DBNull.Value && row["PrecioDeCostoFinal"].ToString() != string.Empty)
                            {
                                decimal precioDeCostoFinalIngresado = Decimal.Round(Convert.ToDecimal(row["PrecioDeCostoFinal"]), 1);
                                decimal diferencia = Convert.ToDecimal(0.1);
                                decimal minPrecioDeCostoFinalIngresado = precioDeCostoFinalIngresado - diferencia;
                                decimal maxPrecioDeCostoFinalIngresado = precioDeCostoFinalIngresado + diferencia;
                                decimal pcioCtoFinal = Decimal.Round(item.PrecioDeCostoFinal, 1);
                                bool cond1 = minPrecioDeCostoFinalIngresado <= pcioCtoFinal;
                                bool cond2 = maxPrecioDeCostoFinalIngresado >= pcioCtoFinal;
                                if (!(cond1 && cond2))
                                    _errores.Add(new ItemDatasetError("Modificar Precios Masivo desde Excel", "Precio de Costo Final", "El precio de costo del producto " + Codigo + " no coincide con el resultante del precio de costo mas las bonificaciones."));
                            }

                            this._productos.Add(prod);
                        }
                    }
                }
                else //No agrega nada nuevo
                {

                    _productos = new ArrayList();
                    foreach (DataRow row in _result.Rows)
                    {
                        string Codigo = Convert.ToString(row["Codigo"]);
                        string IdProducto = string.Empty;
                        if (PorCodigo)
                        {
                            IdProducto = Convert.ToString(row["IdProducto"]);
                        }
                        else if (PorCodigoSecundario)
                        {
                            IdProducto = Convert.ToString(row["IdProducto"]);
                        }
                        else if (PorCodigoProveedor)
                        {
                            IdProducto = Convert.ToString(row["IdProducto"]);
                        }

                        if (IdProducto != null && !IdProducto.Equals(string.Empty)) //Existe el producto en tsh_Productos
                        {

                            tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow rowPP = tpu_ProveedoresProductos.GetByPk(IdProveedor, IdProducto);
                            if (rowPP != null) //Existe el producto en tpu_ProveedoresProductos
                            {
                                Producto prod = new Producto(IdProducto, _idVisualizacionDeStock, _calculaPPP, _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista);
                                //Sabrina 20100615 - Tarea 764
                                prod.CargarListasDePrecios("EDIT");
                                //Fin Sabrina 20100615 - Tarea 764
                                //Sabrina 20100706 - Tarea 790
                                prod.PrecioDeVentaAfectaMac = _precioDeVentaAfectaMac;
                                //Sabrina 20100706 - Tarea 790
                                ListaDePreciosProveedoresItem item = new ListaDePreciosProveedoresItem(rowPP);

                                //German 20120202 - Tarea 0000273 //Para agregar el proveedor default si es que estan habilitadas las listas de precios de proveedores verrrrrrrrrrrrrrrrr!!!
                                if (prod.IdProveedorDefault == null || prod.IdProveedorDefault == string.Empty)
                                {
                                    item.EsProveedorPorDefault = true;
                                    prod.IdProveedorDefault = IdProveedor;
                                }
                                //German 20120202 - Tarea 0000273

                                prod.ListaDePreciosProveedores.AddItem(item);
                                this.SetearDatosListaDePreciosProveedoresItemExcelFromExcelRow(prod, item, row);


                                //German 20120202 - Tarea 0000273


                                if (_actualizaListasDePreciosDeVentaDesdeExcel)
                                    this.SetearDatosListaDePreciosVentasFromExcelRow(prod, row);


                                //Fin German 20120202 - Tarea 0000273

                                _productos.Add(prod);
                                if (row["PrecioDeCostoFinal"] != System.DBNull.Value && row["PrecioDeCostoFinal"].ToString() != string.Empty)
                                {
                                    decimal precioDeCostoFinalIngresado = Decimal.Round(Convert.ToDecimal(row["PrecioDeCostoFinal"]), 1);
                                    decimal diferencia = Convert.ToDecimal(0.1);
                                    decimal minPrecioDeCostoFinalIngresado = precioDeCostoFinalIngresado - diferencia;
                                    decimal maxPrecioDeCostoFinalIngresado = precioDeCostoFinalIngresado + diferencia;
                                    decimal pcioCtoFinal = Decimal.Round(item.PrecioDeCostoFinal, 1);
                                    if (!((minPrecioDeCostoFinalIngresado <= pcioCtoFinal) && (maxPrecioDeCostoFinalIngresado >= pcioCtoFinal)))
                                        _errores.Add(new ItemDatasetError("Modificar Precios Masivo desde Excel", "Precio de Costo Final", "El precio de costo del producto " + Codigo + " no coincide con el resultante del precio de costo mas las bonificaciones."));
                                }

                            }
                            else

                                //German 20120202 - Tarea 0000273


                                if (_actualizaListasDePreciosDeVentaDesdeExcel)
                                {
                                    Producto prod = new Producto(IdProducto, _idVisualizacionDeStock, _calculaPPP, _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista);
                                    prod.CargarListasDePrecios("EDIT");
                                    prod.PrecioDeVentaAfectaMac = _precioDeVentaAfectaMac;
                                    this.SetearDatosListaDePreciosVentasFromExcelRow(prod, row);
                                    _productos.Add(prod);
                                }

                            //Fin German 20120202 - Tarea 0000273

                        }
                    }

                }
            }
            else if (this._processParent.Process.ProcessName.Equals("ProcesoModificarPreciosVentaMasivoDesdeExcel"))
            {

                if (AgregaProductosNuevos)
                {
                    _impuestosDirectosAAgregarPorProducto = new Hashtable();
                    _productos = new ArrayList();
                    string _idMonedaReferencia = Variables.GetValueString("Contabilidad.MonedaReferencia");
                    string _idFuenteDeCambioProveedor = Variables.GetValueString("Contabilidad.FuenteDeCambioReferencia");
                    foreach (DataRow row in _result.Rows)
                    {
                        string CodigoIngresado = Convert.ToString(row["Codigo"]);
                        string IdProducto = string.Empty;
                        string Codigo = string.Empty;
                        string CodigoSecundario = string.Empty;
                        string CodigoProveedor = string.Empty;
                        if (PorCodigo)
                        {
                            IdProducto = Convert.ToString(row["IdProducto"]);
                            Codigo = CodigoIngresado;
                            CodigoSecundario = Convert.ToString(row["CodigoSecundario"]);
                            CodigoProveedor = Convert.ToString(row["CodigoProveedor"]);
                        }
                        else if (PorCodigoSecundario)
                        {
                            IdProducto = Convert.ToString(row["IdProducto"]);
                            CodigoSecundario = CodigoIngresado;
                            Codigo = Convert.ToString(row["CodigoAuxiliar"]);
                            CodigoProveedor = Convert.ToString(row["CodigoProveedor"]);
                        }
                        string CampoAuxiliar1 = Convert.ToString(row["CampoAuxiliar1"]);
                        string CampoAuxiliar2 = Convert.ToString(row["CampoAuxiliar2"]);
                        string CampoAuxiliar3 = Convert.ToString(row["CampoAuxiliar3"]);
                        string CampoAuxiliar4 = Convert.ToString(row["CampoAuxiliar4"]);
                        string CampoAuxiliar5 = Convert.ToString(row["CampoAuxiliar5"]);

                        Producto prod = null;
                        if (IdProducto == null || IdProducto.Equals(string.Empty)) //No existe el producto en tsh_Productos
                        {
                            string Descripcion = Convert.ToString(row["Descripcion"]);
                            string IVA = Convert.ToString(row["IVA"]);
                            _impuestosDirectosAAgregarPorProducto.Add(Codigo, IVA);
                            prod = new Producto(Codigo, CodigoSecundario, CodigoProveedor, Descripcion, CampoAuxiliar1, CampoAuxiliar2, CampoAuxiliar3, CampoAuxiliar4, CampoAuxiliar5, _idVisualizacionDeStock, _calculaPPP, _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista, _usaPrecioDeCostoReposicion);
                        }
                        else
                        {
                            prod = new Producto(IdProducto, _idVisualizacionDeStock, _calculaPPP, _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista);
                            if (ModificaCamposAuxiliares)
                            {
                                prod.CampoAuxiliar1 = CampoAuxiliar1;
                                prod.CampoAuxiliar2 = CampoAuxiliar2;
                                prod.CampoAuxiliar3 = CampoAuxiliar3;
                                prod.CampoAuxiliar4 = CampoAuxiliar4;
                                prod.CampoAuxiliar5 = CampoAuxiliar5;
                                if (!prod.Estado.Equals("NEW"))
                                    prod.Estado = "MODIF";
                            }
                        }

                        this.SetearPrecioDeVentaFromExcelRow(prod, row);
                        if (ModificaAlgunaJerarquia()) //No existe el producto en tsh_Productos o selecciono q modifica jerarquias
                        {
                            ProductosJerarquias jerarquias = this.ValidarJerarquias(row);
                            prod.Jerarquias = jerarquias;
                            if (!prod.Estado.Equals("NEW"))
                                prod.Estado = "MODIF";
                        }
                        if (ModificaCodigoSecundario)
                        {
                            prod.CodigoSecundario = Convert.ToString(row["CodigoSecundario"]);
                            if (!prod.Estado.Equals("NEW"))
                                prod.Estado = "MODIF";
                        }
                        if (ModificaCodigoProveedor)
                        {
                            prod.CodigoProveedor = Convert.ToString(row["CodigoProveedor"]);
                            if (!prod.Estado.Equals("NEW"))
                                prod.Estado = "MODIF";
                        }
                        if (ModificaDescripcion)
                        {
                            prod.Descripcion = Convert.ToString(row["Descripcion"]);
                            if (!prod.Estado.Equals("NEW"))
                                prod.Estado = "MODIF";
                        }
                        this._productos.Add(prod);
                    }
                }
                else
                {
                    _productos = new ArrayList();
                    foreach (DataRow row in _result.Rows)
                    {
                        string Codigo = Convert.ToString(row["Codigo"]);
                        string CodigoSecundario = Convert.ToString(row["CodigoSecundario"]);
                        string CodigoProveedor = Convert.ToString(row["CodigoProveedor"]);
                        string IdProducto = string.Empty;
                        if (PorCodigo)
                        {
                            IdProducto = Convert.ToString(row["IdProducto"]);
                        }
                        else if (PorCodigoSecundario)
                        {
                            IdProducto = Convert.ToString(row["IdProducto"]);
                        }
                        if (IdProducto != null && !IdProducto.Equals(string.Empty)) //Existe el producto en tsh_Productos
                        {
                            Producto prod = new Producto(IdProducto, _idVisualizacionDeStock, _calculaPPP, _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista);
                            this.SetearPrecioDeVentaFromExcelRow(prod, row);
                            if (ModificaCamposAuxiliares)
                            {
                                string CampoAuxiliar1 = Convert.ToString(row["CampoAuxiliar1"]);
                                string CampoAuxiliar2 = Convert.ToString(row["CampoAuxiliar2"]);
                                string CampoAuxiliar3 = Convert.ToString(row["CampoAuxiliar3"]);
                                string CampoAuxiliar4 = Convert.ToString(row["CampoAuxiliar4"]);
                                string CampoAuxiliar5 = Convert.ToString(row["CampoAuxiliar5"]);
                                prod.CampoAuxiliar1 = CampoAuxiliar1;
                                prod.CampoAuxiliar2 = CampoAuxiliar2;
                                prod.CampoAuxiliar3 = CampoAuxiliar3;
                                prod.CampoAuxiliar4 = CampoAuxiliar4;
                                prod.CampoAuxiliar5 = CampoAuxiliar5;
                            }
                            if (ModificaAlgunaJerarquia()) //Selecciono q modifica jerarquias
                            {
                                ProductosJerarquias jerarquias = this.ValidarJerarquias(row);
                                prod.Jerarquias = jerarquias;
                                if (!prod.Estado.Equals("NEW"))
                                    prod.Estado = "MODIF";
                            }
                            if (ModificaCodigoSecundario)
                            {
                                prod.CodigoSecundario = CodigoSecundario;
                                if (!prod.Estado.Equals("NEW"))
                                    prod.Estado = "MODIF";
                            }
                            if (ModificaCodigoProveedor)
                            {
                                prod.CodigoProveedor = CodigoProveedor;
                                if (!prod.Estado.Equals("NEW"))
                                    prod.Estado = "MODIF";
                            }
                            if (ModificaDescripcion)
                            {
                                prod.Descripcion = Convert.ToString(row["Descripcion"]); ;
                                if (!prod.Estado.Equals("NEW"))
                                    prod.Estado = "MODIF";
                            }
                            _productos.Add(prod);
                        }
                    }

                }
            }

            return _errores.Count == 0;

        }


        public bool AllowShow()
        {
            return true;
        }
        public void FormHasClosed()
        {
        }
        public ItemsDatasetErrors GetErrors()
        {
            return _errores;
        }

        public string GetWarnings()
        {

            string res = string.Empty;
            return res;
        }

        public ProcessManager GetProcessManagerParent()
        {
            return _processParent;
        }

        public void SetProcessManagerParent(ProcessManager processManager)
        {
            _processParent = processManager;
        }

        public string GetTaskName()
        {
            return this._taskName;
        }

        public void SetTaskName(string taskName)
        {
            _taskName = taskName;
        }

        public void Execute()
        {
            if (OnTaskBeforeExecute != null)
                OnTaskBeforeExecute(this, new EventArgs());

            this.IsValid();

            if (OnTaskAfterExecute != null)
                OnTaskAfterExecute(this, new EventArgs());
        }

        public bool AllowPrevious()
        {
            return true;
        }

        public void Previous()
        {
            if (OnTaskBeforePrevious != null)
                OnTaskBeforePrevious(this, new EventArgs());
            if (OnTaskAfterPrevious != null)
                OnTaskAfterPrevious(this, new EventArgs());
        }

        public void ListenerAfterPreviousDependentTask(object sender)
        {

        }

        public void ListenerBeforePreviousDependentTask(object sender)
        {

        }

        #endregion

        #region Miembros de IPersistentTask

        public event System.EventHandler OnTaskBeforeFlush;

        public event System.EventHandler OnTaskAfterFlush;

        public TaskCollectionData GetData()
        {
            TaskCollectionData data = new TaskCollectionData();
            data.TaskName = this.GetTaskName();
            return data;
        }

        public void Commit()
        {
            if (this._processParent.Process.ProcessName.Equals("ProcesoModificarPreciosMasivoDesdeExcel"))
            {
                if (AgregaProductosNuevos)
                {
                    this.ObtenerImpuestosDirectosAAgregar();
                    //German 20110605 - Tarea 0000149
                    string _impuestosDirectos = Variables.GetValueString("Productos.Impuestos.ImpuestosDirectos") + "," + mz.erp.businessrules.tsy_Impuestos.GetListImpuestosInternosString();
                    //Fin German 20110605 - Tarea 0000149
                    ArrayList imps = mz.erp.systemframework.Util.Parse(_impuestosDirectos, ",");
                    bool _agentePercepcionIB = Variables.GetValueBool("Sistema.PercibeIB");
                    foreach (Producto prod in this._productos)
                    {
                        if (prod.Estado.Equals("NEW"))
                        {
                            //Agrego en tsh_productos
                            tsh_ProductosExDataset.tsh_ProductosRow _rowP = _dataProductosNuevos.tsh_Productos.Newtsh_ProductosRow();
                            tsh_ProductosEx.SetRowProductosDefaultValues(_rowP);
                            //German 20120126 - Tarea 0000233
                            if(_codigoAutomatico)
                                _rowP["Codigo"] = null;
                            else
                                _rowP["Codigo"] = prod.Codigo;
                            //Fin German 20120126 - Tarea 0000233
                            _rowP["CodigoSecundario"] = prod.CodigoSecundario;
                            _rowP["CodigoProveedor"] = prod.CodigoProveedor;
                            _rowP["Descripcion"] = prod.Descripcion;
                            _rowP["DescripcionCorta"] = prod.Descripcion;
                            _rowP["DescripcionLarga"] = prod.Descripcion;
                            _rowP["IdMonedaCierrePrecioDeCostoRef"] = prod.IdMonedaPrecioDeCosto;
                            _rowP["IdMonedaCierrePrecioDeVentaNeto"] = prod.IdMonedaPrecioDeVentaNeto;
                            _rowP["IdMonedaCierreMaxDescuento"] = prod.IdMonedaPrecioDeVentaNeto;
                            _rowP["IdMonedaCierrePrecioDeVentaBruto"] = prod.IdMonedaPrecioDeVentaNeto;
                            _rowP["IdCotizacionCierrePrecioDeCostoRef"] = prod.IdCotizacionMonedaPrecioDeCosto;
                            _rowP["IdCotizacionCierrePrecioDeVentaNeto"] = prod.IdCotizacionMonedaPrecioDeVentaNeto;
                            _rowP["IdCotizacionCierreMaxDescuento"] = prod.IdCotizacionMonedaPrecioDeVentaNeto;
                            _rowP["IdCotizacionCierrePrecioDeVentaBruto"] = prod.IdCotizacionMonedaPrecioDeVentaNeto;

                            _rowP["MAC"] = prod.MAC;
                            _rowP["PrecioDeCostoRef"] = prod.PrecioDeCosto;
                            if (prod.PrecioDeCosto != prod.PrecioDeCostoEnBD)
                                _rowP["FechaUltimaModificacionPrecioDeCosto"] = DateTime.Now;
                            _rowP["PrecioDeCostoDirecto"] = prod.PrecioDeCostoDirecto;
                            _rowP["PrecioDeCostoIndirecto"] = prod.PrecioDeCostoIndirecto;
                            _rowP["UsaPrecioDeCostoReposicion"] = prod.UsaPrecioDeCostoReposicion;
                            _rowP["PrecioDeCostoReposicion"] = prod.PrecioDeCostoReposicion;
                            _rowP["PrecioDeCostoPromedioPonderado"] = prod.PrecioDeCostoPromedioPonderado;
                            _rowP["PrecioDeVentaNeto"] = prod.PrecioDeVentaNeto;
                            _rowP["MaxDescuentoPorcentual"] = prod.PorcentajeMaximoDescuento;
                            _rowP["MaxDescuento"] = prod.MaximoDescuento;
                            _rowP["PrecioDeVentaBruto"] = prod.PrecioLista;
                            if (prod.PrecioLista != prod.PrecioDeListaEnBD)
                                _rowP["FechaUltimaModificacionPrecioDeVenta"] = DateTime.Now;
                            _rowP["IdProveedorDefault"] = prod.IdProveedorDefault;

                            //German 20091005
                            _rowP["IdResponsableCreacion"] = Security.IdPersona;
                            //Fin German 20091005


                            _dataProductosNuevos.tsh_Productos.Addtsh_ProductosRow(_rowP);
                            prod.IdProducto = Convert.ToString(_rowP["IdProducto"]);

                            //Agrego en tsh_ProductosSucursales
                            tsh_ProductosExDataset.tsh_ProductosSucursalesRow rowSucursales = _dataProductosNuevos.tsh_ProductosSucursales.Newtsh_ProductosSucursalesRow();
                            rowSucursales = tsh_ProductosEx.SetRowProductosSucursalesDefaultValues(rowSucursales, prod.IdProducto, Security.IdEmpresa, Security.IdSucursal);
                            rowSucursales.Activo = true;
                            string IVA = this.ImpuestoSeleccionado();
                            tsy_ImpuestosDataset.tsy_ImpuestosRow rowIm = tsy_Impuestos.GetByImpuesto(IVA);
                            decimal Alicuota = rowIm.Alicuota1;
                            rowSucursales.PrecioFinalEstimado = prod.GetPrecioDeListaConImpuestos(Alicuota);
                            _dataProductosNuevos.tsh_ProductosSucursales.Addtsh_ProductosSucursalesRow(rowSucursales);

                            //Agrego en tsh_productosAuxiliares
                            tsh_ProductosExDataset.tsh_ProductosAuxiliaresRow rowPA = _dataProductosNuevos.tsh_ProductosAuxiliares.Newtsh_ProductosAuxiliaresRow();
                            tsh_ProductosEx.SetRowProductosDefaultValues(rowPA);
                            rowPA.IdProducto = prod.IdProducto;
                            rowPA["Activo"] = true;
                            rowPA["IdEmpresa"] = Security.IdEmpresa;
                            rowPA["IdSucursal"] = Security.IdSucursal;
                            rowPA.Coeficiente1 = prod.Coeficiente1;
                            rowPA.Coeficiente2 = prod.Coeficiente2;
                            rowPA.Coeficiente3 = prod.Coeficiente3;
                            rowPA.Coeficiente4 = prod.Coeficiente4;
                            rowPA.Coeficiente5 = prod.Coeficiente5;
                            rowPA.Coeficiente6 = prod.Coeficiente6;
                            rowPA.Coeficiente7 = prod.Coeficiente7;
                            rowPA.Coeficiente8 = prod.Coeficiente8;
                            rowPA.Coeficiente9 = prod.Coeficiente9;
                            rowPA.Coeficiente10 = prod.Coeficiente10;
                            _dataProductosNuevos.tsh_ProductosAuxiliares.Addtsh_ProductosAuxiliaresRow(rowPA);

                            //Agrego en tsh_ProductosCoeficientesAplicados
                            CostosIndirectos CoeficientesIndirectos = new CostosIndirectos(prod.IdProducto, "NEW");
                            tsh_ProductosExDataset.tsh_ProductosCoeficientesAplicadosRow rowPCA = _dataProductosNuevos.tsh_ProductosCoeficientesAplicados.Newtsh_ProductosCoeficientesAplicadosRow();
                            foreach (CostosIndirectosItem item in CoeficientesIndirectos)
                            {
                                item.Commit(item.Orden, rowPCA);
                            }
                            rowPCA.IdProducto = prod.IdProducto;
                            _dataProductosNuevos.tsh_ProductosCoeficientesAplicados.Addtsh_ProductosCoeficientesAplicadosRow(rowPCA);

                            //Agrego en tsy_ImpuestosProductos
                            tsh_ProductosEx.ProductosImpuestos impuestos = new tsh_ProductosEx.ProductosImpuestos();
                            DataSet dataImp = tsy_ImpuestosEx.GetList();
                            foreach (DataRow rowI in dataImp.Tables[0].Rows)
                            {
                                if (imps.Contains(Convert.ToString(rowI["Impuesto"])))
                                {
                                    tsh_ProductosEx.ProductoImpuesto pi = new tsh_ProductosEx.ProductoImpuesto();
                                    pi.IdImpuesto = rowI["IdImpuesto"].ToString();
                                    pi.Descripcion = rowI["Descripcion"].ToString();
                                    pi.Formula = rowI["FormulaDeCalculo"].ToString();
                                    pi.Key = Convert.ToString(rowI["Impuesto"]);
                                    pi.DescripcionCorta = Convert.ToString(rowI["DescripcionCorta"]);
                                    pi.Activo = this.ImpuestosDirectosAAgregar.Contains(pi.Key);
                                    impuestos.Add(pi);
                                }
                            }
                            CollectionBase aux = impuestos;
                            tsy_ImpuestosProductosDataset ip = new tsy_ImpuestosProductosDataset();
                            string listaIBstr = Variables.GetValueString("Impuestos.Lista.IB");
                            ArrayList listaIB = Util.Parse(listaIBstr, ",");
                            ArrayList listaIBIds = new ArrayList();
                            foreach (string ib in listaIB)
                            {
                                string IdImp = mz.erp.businessrules.tsy_Impuestos.GetIdImpuesto(ib);
                                if (IdImp != null && IdImp != string.Empty)
                                    listaIBIds.Add(IdImp);
                            }

                            //Agrega impuestos indirectos
                            if (_agentePercepcionIB)
                            {
                                if (!PercibeIB)
                                {
                                    foreach (string IdImp in listaIBIds)
                                    {
                                        tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosRow rowImp = ip.tsy_ImpuestosProductos.Newtsy_ImpuestosProductosRow();
                                        businessrules.tsy_ImpuestosProductos.SetRowDefaultValues(rowImp);
                                        rowImp.IdProducto = prod.IdProducto;
                                        rowImp.MetodoDeAsignacion = "E";
                                        rowImp.IdImpuesto = IdImp;
                                        ip.tsy_ImpuestosProductos.Addtsy_ImpuestosProductosRow(rowImp);
                                    }

                                }
                            }

                            //Agrega impuestos directos
                            foreach (tsh_ProductosEx.ProductoImpuesto ps in aux)
                            {
                                if (ps.Activo)
                                {
                                    tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosRow rowImp = ip.tsy_ImpuestosProductos.Newtsy_ImpuestosProductosRow();
                                    businessrules.tsy_ImpuestosProductos.SetRowDefaultValues(rowImp);
                                    rowImp.IdProducto = prod.IdProducto;
                                    rowImp.MetodoDeAsignacion = "I";
                                    rowImp.IdImpuesto = ps.IdImpuesto;
                                    ip.tsy_ImpuestosProductos.Addtsy_ImpuestosProductosRow(rowImp);
                                }
                            }
                            if (ip.tsy_ImpuestosProductos.Rows.Count > 0)
                                _dataProductosNuevos.Merge((DataSet)ip);

                            //Sabrina 20100615 - Tarea 764
                            //Agrego en tsh_ProductosListasDePrecios
                            /*tsh_ListasDePreciosDataset.tsh_ListasDePreciosRow rowLPDefault = tsh_ListasDePrecios.GetDefault();
                            if(rowLPDefault != null)
                            {
                                tsh_ProductosExDataset.tsh_ProductosListasDePreciosRow rowPLP = _dataProductosNuevos.tsh_ProductosListasDePrecios.Newtsh_ProductosListasDePreciosRow();
                                rowPLP.IdProducto = prod.IdProducto;
                                rowPLP.IdListaDePrecio = rowLPDefault.IdListaDePrecio;
                                rowPLP.ModoDeAplicacion = "P";
                                rowPLP.Coeficiente = 0;
                                rowPLP.MaxDescuento = 0;
                                rowPLP.MaxDescuentoPorcentual = 0;
                                rowPLP.PrecioDeVentaBruto = prod.PrecioLista;
                                rowPLP.PrecioDeVentaBrutoConImpuesto = prod.GetPrecioDeListaConImpuestos(Alicuota);
                                if(prod.PrecioLista != prod.PrecioDeListaEnBD)
                                    rowPLP["FechaUltimaModificacionPrecioDeVenta"] = DateTime.Now;
                                rowPLP.FechaCreacion = DateTime.Now;
                                rowPLP.IdConexionCreacion = Security.IdConexion;
                                rowPLP.IdConexionUltimaModificacion = Security.IdConexion;
                                rowPLP.IdReservado = 0;
                                rowPLP.RowId = Guid.Empty;
                                rowPLP.IdEmpresa = Security.IdEmpresa;			
                                rowPLP.IdSucursal = Security.IdSucursal;
                                _dataProductosNuevos.tsh_ProductosListasDePrecios.Addtsh_ProductosListasDePreciosRow(rowPLP);
						

                                //Agrego en tsh_ProductosListasDePreciosAplicadas
                                tsh_ProductosExDataset.tsh_ProductosListasDePreciosAplicadasRow rowPLPA = _dataProductosNuevos.tsh_ProductosListasDePreciosAplicadas.Newtsh_ProductosListasDePreciosAplicadasRow();
                                rowPLPA.IdProducto = prod.IdProducto;
                                rowPLPA.IdListaDePrecio = rowLPDefault.IdListaDePrecio;
                                rowPLPA.Coeficiente = 0;
                                rowPLPA.FechaCreacion = DateTime.Now;
                                rowPLPA.IdConexionCreacion = Security.IdConexion;
                                rowPLPA.IdConexionUltimaModificacion = Security.IdConexion;
                                rowPLPA.IdReservado = 0;
                                rowPLPA.RowId = Guid.Empty;
                                rowPLPA.IdEmpresa = Security.IdEmpresa;			
                                rowPLPA.IdSucursal = Security.IdSucursal;
                                _dataProductosNuevos.tsh_ProductosListasDePreciosAplicadas.Addtsh_ProductosListasDePreciosAplicadasRow(rowPLPA);
                            }*/

                            if (_habilitaListasDePrecios)//Depende de la variable Productos.ListasDePrecios
                            {
                                    foreach (ListaDePreciosItem item in prod.ListaDePrecios.Items)
                                    {
                                        //Sabrina: Tarea 1113. 20110808
                                        item.IdProducto = prod.IdProducto;
                                        //Fin Sabrina: Tarea 1113. 20110808
                                        //German 20110825 - Tarea 0000188
                                        //Cuando se crea un producto autoamticamente se crean todas las listas de precios de ventas sin importar las que esten seleccionadas
                                        
                                        //if (_listasDePreciosSeleccionadas.Contains(new ListaDePreciosView(item.IdListaDePrecios, item.Descripcion)))
                                        //Fin German 20110825 - Tarea 0000188
                                            _dataProductosNuevos = prod.ListaDePrecios.Commit(_dataProductosNuevos, item);
                                    }
                            
                               


                            }
                            else
                            {
                                ListaDePreciosItem item = prod.ListaDePrecios.GetDefaultItem();
                                /* Silvina 20110704 - Tarea 0000163 */
                                item.IdProducto = prod.IdProducto;
                                /* Fin Silvina 20110704 - Tarea 0000163 */
                                item.ModoDeAplicacion = "P";
                                item.PrecioDeCosto = prod.PrecioDeCosto;
                                item.Mac = prod.MAC;
                                item.PrecioDeVentaNeto = prod.PrecioDeVentaNeto;
                                decimal coeficienteNew = item.GetCoeficienteFromPrecioVentaBruto(prod.PrecioLista);
                                item.CoeficienteProducto = coeficienteNew;
                                item.PrecioDeVentaBruto = prod.PrecioLista;
                                item.PrecioDeVentaBrutoConImpuestos = prod.PrecioDeListaConImpuestos;
                                _dataProductosNuevos = prod.ListaDePrecios.Commit(_dataProductosNuevos, item);
                            }
                            //Fin Sabrina 20100615 - Tarea 764

                            //Agrego las jerarquias
                            if (this._byJerarquia1)
                            {
                                foreach (ItemJerarquia item in this._jerarquia1)
                                {
                                    AddTsh_AgrupProductos(item.NodeKeyPath, prod.IdProducto);
                                }
                            }
                            if (this._byJerarquia2)
                            {
                                foreach (ItemJerarquia item in this._jerarquia2)
                                {
                                    AddTsh_AgrupProductos(item.NodeKeyPath, prod.IdProducto);
                                }
                            }
                            if (this._byJerarquia3)
                            {
                                foreach (ItemJerarquia item in this._jerarquia3)
                                {
                                    AddTsh_AgrupProductos(item.NodeKeyPath, prod.IdProducto);
                                }
                            }
                            if (this._byJerarquia4)
                            {
                                foreach (ItemJerarquia item in this._jerarquia4)
                                {
                                    AddTsh_AgrupProductos(item.NodeKeyPath, prod.IdProducto);
                                }
                            }
                            if (this._byJerarquia5)
                            {
                                foreach (ItemJerarquia item in this._jerarquia5)
                                {
                                    AddTsh_AgrupProductos(item.NodeKeyPath, prod.IdProducto);
                                }
                            }
                            if (this._byJerarquia6)
                            {
                                foreach (ItemJerarquia item in this._jerarquia6)
                                {
                                    AddTsh_AgrupProductos(item.NodeKeyPath, prod.IdProducto);
                                }
                            }
                            if (this._byJerarquia7)
                            {
                                foreach (ItemJerarquia item in this._jerarquia7)
                                {
                                    AddTsh_AgrupProductos(item.NodeKeyPath, prod.IdProducto);
                                }
                            }
                            if (this._byJerarquia8)
                            {
                                foreach (ItemJerarquia item in this._jerarquia8)
                                {
                                    AddTsh_AgrupProductos(item.NodeKeyPath, prod.IdProducto);
                                }
                            }


                        }
                        else
                            commitProductoModificado(prod);

                        if (!prod.Estado.Equals("MODIF") || (prod.Estado.Equals("MODIF") && (prod.Activo || (!prod.Activo && _modificaProductosInactivos))))
                            commitProveedoresProductos(prod);
                    }
                    ProductosJerarquiaAuxiliar p = new ProductosJerarquiaAuxiliar();
                    p.cargarJerarquias(_dataProductosNuevos.tsh_AgrupProductos);
                    Hashtable auxtable = p.ProductoJerarquia;
                    mz.erp.businessrules.tsh_ProductosEx prodEx = new tsh_ProductosEx();
                    foreach (Producto prod in this._productos)
                    {
                        if (prod.Estado.Equals("NEW"))
                        {
                            object valor = auxtable[prod.IdProducto];
                            if (valor != null)
                                this.AddTsh_ProductosJerarquias(prod.IdProducto, (ArrayList)valor);
                        }
                    }
                }
                else if (AgregaListaDePreciosNuevas)
                {
                    foreach (Producto prod in this._productos)
                    {
                        commitProductoModificado(prod);
                        if (!prod.Estado.Equals("MODIF") || (prod.Estado.Equals("MODIF") && (prod.Activo || (!prod.Activo && _modificaProductosInactivos))))
                            commitProveedoresProductos(prod);
                    }
                }
                else //No agrega nada
                {

                    foreach (Producto prod in this._productos)
                    {
                        commitProductoModificado(prod);
                        foreach (ListaDePreciosProveedoresItem item in prod.ListaDePreciosProveedores.Items)
                        {
                            if (item.Estado.Equals("MODIF") && (prod.Activo || (!prod.Activo && _modificaProductosInactivos)))
                            {

                                DataRow _rowP = _dataProductosNuevos.tsh_Productos.FindByIdProducto(prod.IdProducto);
                                if (_rowP == null)
                                {
                                    _rowP = mz.erp.businessrules.tsh_Productos.GetByPk(prod.IdProducto);
                                    _dataProductosNuevos.tsh_Productos.ImportRow(_rowP);
                                }
                                tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow rowPP = tpu_ProveedoresProductos.GetByPk(item.IdProveedor, item.IdProducto);
                                rowPP.PrecioDeCosto = item.PrecioDeCosto;
                                if (rowPP.PrecioDeCostoFinal != item.PrecioDeCostoFinal)
                                    rowPP.FechaUltimaModificacionPrecioDeCosto = mz.erp.businessrules.Sistema.DateTime.Now;
                                rowPP.PrecioDeCostoFinal = item.PrecioDeCostoFinal;
                                rowPP.BonificacionAcumulativa = item.BonificacionAcumulativa;
                                rowPP.Bonificacion1 = item.Bonificacion1;
                                rowPP.Bonificacion2 = item.Bonificacion2;
                                rowPP.Bonificacion3 = item.Bonificacion3;
                                rowPP.Bonificacion4 = item.Bonificacion4;
                                rowPP.Bonificacion5 = item.Bonificacion5;
                                rowPP.PorcentajeBonificacion1 = item.PorcentajeBonificacion1;
                                rowPP.PorcentajeBonificacion2 = item.PorcentajeBonificacion2;
                                rowPP.PorcentajeBonificacion3 = item.PorcentajeBonificacion3;
                                rowPP.PorcentajeBonificacion4 = item.PorcentajeBonificacion4;
                                rowPP.PorcentajeBonificacion5 = item.PorcentajeBonificacion5;
                                rowPP.IdCotizacionProveedor = item.IdCotizacionProveedor;
                                rowPP.IdFuenteDeCambioProveedor = item.IdFuenteDeCambioProveedor;
                                rowPP.IdMonedaProveedor = item.IdMonedaProveedor;
                                rowPP.ValorCotizacionProveedor = item.ValorCotizacionProveedor;
                                _dataProductosNuevos.tpu_ProveedoresProductos.ImportRow(rowPP);

                            }
                        }
                    }
                }
            }
            else if (this._processParent.Process.ProcessName.Equals("ProcesoModificarPreciosVentaMasivoDesdeExcel"))
            {

                if (AgregaProductosNuevos)
                {
                    //German 20110605 - Tarea 0000149
                    string _impuestosDirectos = Variables.GetValueString("Productos.Impuestos.ImpuestosDirectos") + "," + mz.erp.businessrules.tsy_Impuestos.GetListImpuestosInternosString();
                    //Fin German 20110605 - Tarea 0000149
                    ArrayList imps = mz.erp.systemframework.Util.Parse(_impuestosDirectos, ",");
                    bool _agentePercepcionIB = Variables.GetValueBool("Sistema.PercibeIB");
                    foreach (Producto prod in this._productos)
                    {
                        if (prod.Estado.Equals("NEW"))
                        {
                            //Agrego en tsh_productos
                            tsh_ProductosExDataset.tsh_ProductosRow _rowP = _dataProductosNuevos.tsh_Productos.Newtsh_ProductosRow();
                            tsh_ProductosEx.SetRowProductosDefaultValues(_rowP);
                            //German 20120126 - Tarea 0000233
                            if (_codigoAutomatico)
                                _rowP["Codigo"] = null;
                            else
                                _rowP["Codigo"] = prod.Codigo;
                            //Fin German 20120126 - Tarea 0000233
                            _rowP["CodigoSecundario"] = prod.CodigoSecundario;
                            _rowP["CodigoProveedor"] = prod.CodigoProveedor;
                            _rowP["Descripcion"] = prod.Descripcion;
                            _rowP["DescripcionCorta"] = prod.Descripcion;
                            _rowP["DescripcionLarga"] = prod.Descripcion;
                            _rowP["IdMonedaCierrePrecioDeCostoRef"] = prod.IdMonedaPrecioDeCosto;
                            _rowP["IdMonedaCierrePrecioDeVentaNeto"] = prod.IdMonedaPrecioDeVentaNeto;
                            _rowP["IdMonedaCierreMaxDescuento"] = prod.IdMonedaPrecioDeVentaNeto;
                            _rowP["IdMonedaCierrePrecioDeVentaBruto"] = prod.IdMonedaPrecioDeVentaNeto;
                            _rowP["IdCotizacionCierrePrecioDeCostoRef"] = prod.IdCotizacionMonedaPrecioDeCosto;
                            _rowP["IdCotizacionCierrePrecioDeVentaNeto"] = prod.IdCotizacionMonedaPrecioDeVentaNeto;
                            _rowP["IdCotizacionCierreMaxDescuento"] = prod.IdCotizacionMonedaPrecioDeVentaNeto;
                            _rowP["IdCotizacionCierrePrecioDeVentaBruto"] = prod.IdCotizacionMonedaPrecioDeVentaNeto;

                            _rowP["MAC"] = prod.MAC;
                            _rowP["PrecioDeCostoRef"] = prod.PrecioDeCosto;
                            if (prod.PrecioDeCosto != prod.PrecioDeCostoEnBD)
                                _rowP["FechaUltimaModificacionPrecioDeCosto"] = DateTime.Now;
                            _rowP["PrecioDeCostoDirecto"] = prod.PrecioDeCostoDirecto;
                            _rowP["PrecioDeCostoIndirecto"] = prod.PrecioDeCostoIndirecto;
                            _rowP["UsaPrecioDeCostoReposicion"] = prod.UsaPrecioDeCostoReposicion;
                            _rowP["PrecioDeCostoReposicion"] = prod.PrecioDeCostoReposicion;
                            _rowP["PrecioDeCostoPromedioPonderado"] = prod.PrecioDeCostoPromedioPonderado;
                            _rowP["PrecioDeVentaNeto"] = prod.PrecioDeVentaNeto;
                            _rowP["MaxDescuentoPorcentual"] = prod.PorcentajeMaximoDescuento;
                            _rowP["MaxDescuento"] = prod.MaximoDescuento;
                            _rowP["PrecioDeVentaBruto"] = prod.PrecioLista;
                            if (prod.PrecioLista != prod.PrecioDeListaEnBD)
                                _rowP["FechaUltimaModificacionPrecioDeVenta"] = DateTime.Now;
                            _rowP["IdProveedorDefault"] = prod.IdProveedorDefault;
                            _rowP["CampoAuxiliar1"] = prod.CampoAuxiliar1;
                            _rowP["CampoAuxiliar2"] = prod.CampoAuxiliar2;
                            _rowP["CampoAuxiliar3"] = prod.CampoAuxiliar3;
                            _rowP["CampoAuxiliar4"] = prod.CampoAuxiliar4;
                            _rowP["CampoAuxiliar5"] = prod.CampoAuxiliar5;


                            //German 20091005
                            _rowP["IdResponsableCreacion"] = Security.IdPersona;
                            //Fin German 20091005

                            _dataProductosNuevos.tsh_Productos.Addtsh_ProductosRow(_rowP);
                            prod.IdProducto = Convert.ToString(_rowP["IdProducto"]);

                            //Agrego en tsh_ProductosSucursales
                            tsh_ProductosExDataset.tsh_ProductosSucursalesRow rowSucursales = _dataProductosNuevos.tsh_ProductosSucursales.Newtsh_ProductosSucursalesRow();
                            rowSucursales = tsh_ProductosEx.SetRowProductosSucursalesDefaultValues(rowSucursales, prod.IdProducto, Security.IdEmpresa, Security.IdSucursal);
                            rowSucursales.Activo = true;
                            string IVA = (string)_impuestosDirectosAAgregarPorProducto[prod.Codigo];
                            tsy_ImpuestosDataset.tsy_ImpuestosRow rowIm = tsy_Impuestos.GetByImpuesto(IVA);
                            decimal Alicuota = rowIm.Alicuota1;
                            rowSucursales.PrecioFinalEstimado = prod.GetPrecioDeListaConImpuestos(Alicuota);
                            _dataProductosNuevos.tsh_ProductosSucursales.Addtsh_ProductosSucursalesRow(rowSucursales);

                            //Agrego en tsh_productosAuxiliares
                            tsh_ProductosExDataset.tsh_ProductosAuxiliaresRow rowPA = _dataProductosNuevos.tsh_ProductosAuxiliares.Newtsh_ProductosAuxiliaresRow();
                            tsh_ProductosEx.SetRowProductosDefaultValues(rowPA);
                            rowPA.IdProducto = prod.IdProducto;
                            rowPA["Activo"] = true;
                            rowPA["IdEmpresa"] = Security.IdEmpresa;
                            rowPA["IdSucursal"] = Security.IdSucursal;
                            rowPA.Coeficiente1 = prod.Coeficiente1;
                            rowPA.Coeficiente2 = prod.Coeficiente2;
                            rowPA.Coeficiente3 = prod.Coeficiente3;
                            rowPA.Coeficiente4 = prod.Coeficiente4;
                            rowPA.Coeficiente5 = prod.Coeficiente5;
                            rowPA.Coeficiente6 = prod.Coeficiente6;
                            rowPA.Coeficiente7 = prod.Coeficiente7;
                            rowPA.Coeficiente8 = prod.Coeficiente8;
                            rowPA.Coeficiente9 = prod.Coeficiente9;
                            rowPA.Coeficiente10 = prod.Coeficiente10;
                            _dataProductosNuevos.tsh_ProductosAuxiliares.Addtsh_ProductosAuxiliaresRow(rowPA);

                            //Agrego en tsh_ProductosCoeficientesAplicados
                            CostosIndirectos CoeficientesIndirectos = new CostosIndirectos(prod.IdProducto, "NEW");
                            tsh_ProductosExDataset.tsh_ProductosCoeficientesAplicadosRow rowPCA = _dataProductosNuevos.tsh_ProductosCoeficientesAplicados.Newtsh_ProductosCoeficientesAplicadosRow();
                            foreach (CostosIndirectosItem item in CoeficientesIndirectos)
                            {
                                item.Commit(item.Orden, rowPCA);
                            }
                            rowPCA.IdProducto = prod.IdProducto;
                            _dataProductosNuevos.tsh_ProductosCoeficientesAplicados.Addtsh_ProductosCoeficientesAplicadosRow(rowPCA);

                            //Agrego en tsy_ImpuestosProductos
                            ArrayList impuestosIngresados = this.ObtenerImpuestosDirectosAAgregar(IVA);
                            tsh_ProductosEx.ProductosImpuestos impuestos = new tsh_ProductosEx.ProductosImpuestos();
                            DataSet dataImp = tsy_ImpuestosEx.GetList();
                            foreach (DataRow rowI in dataImp.Tables[0].Rows)
                            {
                                if (imps.Contains(Convert.ToString(rowI["Impuesto"])))
                                {
                                    tsh_ProductosEx.ProductoImpuesto pi = new tsh_ProductosEx.ProductoImpuesto();
                                    pi.IdImpuesto = rowI["IdImpuesto"].ToString();
                                    pi.Descripcion = rowI["Descripcion"].ToString();
                                    pi.Formula = rowI["FormulaDeCalculo"].ToString();
                                    pi.Key = Convert.ToString(rowI["Impuesto"]);
                                    pi.DescripcionCorta = Convert.ToString(rowI["DescripcionCorta"]);
                                    pi.Activo = impuestosIngresados.Contains(pi.Key);
                                    impuestos.Add(pi);
                                }
                            }
                            CollectionBase aux = impuestos;
                            tsy_ImpuestosProductosDataset ip = new tsy_ImpuestosProductosDataset();
                            string listaIBstr = Variables.GetValueString("Impuestos.Lista.IB");
                            ArrayList listaIB = Util.Parse(listaIBstr, ",");
                            ArrayList listaIBIds = new ArrayList();
                            foreach (string ib in listaIB)
                            {
                                string IdImp = mz.erp.businessrules.tsy_Impuestos.GetIdImpuesto(ib);
                                if (IdImp != null && IdImp != string.Empty)
                                    listaIBIds.Add(IdImp);
                            }

                            //Agrega impuestos indirectos
                            if (_agentePercepcionIB)
                            {
                                if (!PercibeIB)
                                {
                                    foreach (string IdImp in listaIBIds)
                                    {
                                        tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosRow rowImp = ip.tsy_ImpuestosProductos.Newtsy_ImpuestosProductosRow();
                                        businessrules.tsy_ImpuestosProductos.SetRowDefaultValues(rowImp);
                                        rowImp.IdProducto = prod.IdProducto;
                                        rowImp.MetodoDeAsignacion = "E";
                                        rowImp.IdImpuesto = IdImp;
                                        ip.tsy_ImpuestosProductos.Addtsy_ImpuestosProductosRow(rowImp);
                                    }

                                }
                            }

                            //Agrega impuestos directos
                            foreach (tsh_ProductosEx.ProductoImpuesto ps in aux)
                            {
                                if (ps.Activo)
                                {
                                    tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosRow rowImp = ip.tsy_ImpuestosProductos.Newtsy_ImpuestosProductosRow();
                                    businessrules.tsy_ImpuestosProductos.SetRowDefaultValues(rowImp);
                                    rowImp.IdProducto = prod.IdProducto;
                                    rowImp.MetodoDeAsignacion = "I";
                                    rowImp.IdImpuesto = ps.IdImpuesto;
                                    ip.tsy_ImpuestosProductos.Addtsy_ImpuestosProductosRow(rowImp);
                                }
                            }
                            if (ip.tsy_ImpuestosProductos.Rows.Count > 0)
                                _dataProductosNuevos.Merge((DataSet)ip);



                            //Agrego en tsh_ProductosListasDePrecios
                            tsh_ListasDePreciosDataset.tsh_ListasDePreciosRow rowLPDefault = tsh_ListasDePrecios.GetDefault();
                            if (rowLPDefault != null)
                            {
                                tsh_ProductosExDataset.tsh_ProductosListasDePreciosRow rowPLP = _dataProductosNuevos.tsh_ProductosListasDePrecios.Newtsh_ProductosListasDePreciosRow();
                                rowPLP.IdProducto = prod.IdProducto;
                                rowPLP.IdListaDePrecio = rowLPDefault.IdListaDePrecio;
                                rowPLP.ModoDeAplicacion = "P";
                                rowPLP.Coeficiente = 0;
                                rowPLP.MaxDescuento = 0;
                                rowPLP.MaxDescuentoPorcentual = 0;
                                rowPLP.PrecioDeVentaBruto = prod.PrecioLista;
                                rowPLP.PrecioDeVentaBrutoConImpuesto = prod.GetPrecioDeListaConImpuestos(Alicuota);
                                if (prod.PrecioLista != prod.PrecioDeListaEnBD)
                                    rowPLP["FechaUltimaModificacionPrecioDeVenta"] = DateTime.Now;
                                rowPLP.FechaCreacion = DateTime.Now;
                                rowPLP.IdConexionCreacion = Security.IdConexion;
                                rowPLP.IdConexionUltimaModificacion = Security.IdConexion;
                                rowPLP.IdReservado = 0;
                                rowPLP.RowId = Guid.Empty;
                                rowPLP.IdEmpresa = Security.IdEmpresa;
                                rowPLP.IdSucursal = Security.IdSucursal;
                                _dataProductosNuevos.tsh_ProductosListasDePrecios.Addtsh_ProductosListasDePreciosRow(rowPLP);


                                //Agrego en tsh_ProductosListasDePreciosAplicadas
                                tsh_ProductosExDataset.tsh_ProductosListasDePreciosAplicadasRow rowPLPA = _dataProductosNuevos.tsh_ProductosListasDePreciosAplicadas.Newtsh_ProductosListasDePreciosAplicadasRow();
                                rowPLPA.IdProducto = prod.IdProducto;
                                rowPLPA.IdListaDePrecio = rowLPDefault.IdListaDePrecio;
                                rowPLPA.Coeficiente = 0;
                                rowPLPA.FechaCreacion = DateTime.Now;
                                rowPLPA.IdConexionCreacion = Security.IdConexion;
                                rowPLPA.IdConexionUltimaModificacion = Security.IdConexion;
                                rowPLPA.IdReservado = 0;
                                rowPLPA.RowId = Guid.Empty;
                                rowPLPA.IdEmpresa = Security.IdEmpresa;
                                rowPLPA.IdSucursal = Security.IdSucursal;
                                _dataProductosNuevos.tsh_ProductosListasDePreciosAplicadas.Addtsh_ProductosListasDePreciosAplicadasRow(rowPLPA);
                            }

                            //Agrego las jerarquias
                            if (ModificaAlgunaJerarquia())
                                this.commitJerarquiasProducto(prod);
                        }
                        else if (prod.Estado.Equals("MODIF") && (prod.Activo || (!prod.Activo && _modificaProductosInactivos)))
                        {
                            DataRow _rowP = mz.erp.businessrules.tsh_Productos.GetByPk(prod.IdProducto);
                            _rowP["MAC"] = prod.MAC;
                            _rowP["PrecioDeCostoRef"] = prod.PrecioDeCosto;
                            if (prod.PrecioDeCosto != prod.PrecioDeCostoEnBD)
                                _rowP["FechaUltimaModificacionPrecioDeCosto"] = DateTime.Now;
                            _rowP["PrecioDeCostoDirecto"] = prod.PrecioDeCostoDirecto;
                            _rowP["PrecioDeCostoIndirecto"] = prod.PrecioDeCostoIndirecto;
                            _rowP["UsaPrecioDeCostoReposicion"] = prod.UsaPrecioDeCostoReposicion;
                            _rowP["PrecioDeCostoReposicion"] = prod.PrecioDeCostoReposicion;
                            _rowP["PrecioDeCostoPromedioPonderado"] = prod.PrecioDeCostoPromedioPonderado;
                            _rowP["PrecioDeVentaNeto"] = prod.PrecioDeVentaNeto;
                            _rowP["MaxDescuentoPorcentual"] = prod.PorcentajeMaximoDescuento;
                            _rowP["MaxDescuento"] = prod.MaximoDescuento;
                            _rowP["PrecioDeVentaBruto"] = prod.PrecioLista;
                            if (prod.PrecioLista != prod.PrecioDeListaEnBD)
                                _rowP["FechaUltimaModificacionPrecioDeVenta"] = DateTime.Now;
                            _rowP["IdMonedaCierrePrecioDeCostoRef"] = prod.IdMonedaPrecioDeCosto;
                            _rowP["IdMonedaCierrePrecioDeVentaNeto"] = prod.IdMonedaPrecioDeVentaNeto;
                            _rowP["IdMonedaCierreMaxDescuento"] = prod.IdMonedaPrecioDeVentaNeto;
                            _rowP["IdMonedaCierrePrecioDeVentaBruto"] = prod.IdMonedaPrecioDeVentaNeto;

                            _rowP["IdCotizacionCierrePrecioDeCostoRef"] = prod.IdCotizacionMonedaPrecioDeCosto;
                            _rowP["IdCotizacionCierrePrecioDeVentaNeto"] = prod.IdCotizacionMonedaPrecioDeVentaNeto;
                            _rowP["IdCotizacionCierreMaxDescuento"] = prod.IdCotizacionMonedaPrecioDeVentaNeto;
                            _rowP["IdCotizacionCierrePrecioDeVentaBruto"] = prod.IdCotizacionMonedaPrecioDeVentaNeto;
                            _rowP["IdProveedorDefault"] = prod.IdProveedorDefault;
                            _rowP["IdResponsableCreacion"] = Security.IdPersona;

                            if (ModificaCodigoSecundario)
                                _rowP["CodigoSecundario"] = prod.CodigoSecundario;
                            if (ModificaCodigoProveedor)
                                _rowP["CodigoProveedor"] = prod.CodigoProveedor;
                            if (ModificaDescripcion)
                                _rowP["Descripcion"] = prod.Descripcion;
                            if (ModificaCamposAuxiliares)
                            {
                                _rowP["CampoAuxiliar1"] = prod.CampoAuxiliar1;
                                _rowP["CampoAuxiliar2"] = prod.CampoAuxiliar2;
                                _rowP["CampoAuxiliar3"] = prod.CampoAuxiliar3;
                                _rowP["CampoAuxiliar4"] = prod.CampoAuxiliar4;
                                _rowP["CampoAuxiliar5"] = prod.CampoAuxiliar5;
                            }
                            _dataProductosNuevos.tsh_Productos.ImportRow(_rowP);
                            if (ModificaAlgunaJerarquia())
                                //Agrego las jerarquias
                                this.commitJerarquiasProducto(prod);

                            //Modifico el campo PrecioFinalEstimado de la table tsh_ProductosSucursales
                            tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesRow rowSucursales = tsh_ProductosSucursales.GetByPk(prod.IdProducto, Security.IdEmpresa, Security.IdSucursal);
                            rowSucursales.PrecioFinalEstimado = prod.PrecioDeListaConImpuestos;
                            _dataProductosNuevos.tsh_ProductosSucursales.ImportRow(rowSucursales);

                            //Modifico los campos PrecioDeVentaBruto y PrecioDeVentaBrutoConImpuesto de la lista default en tsh_ProductosListasDePrecios
                            tsh_ListasDePreciosDataset.tsh_ListasDePreciosRow rowLPDefault = tsh_ListasDePrecios.GetDefault();
                            if (rowLPDefault != null)
                            {
                                tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow rowPLP = tsh_ProductosListasDePrecios.GetByPk(prod.IdProducto, rowLPDefault.IdListaDePrecio);
                                rowPLP.PrecioDeVentaBruto = prod.PrecioLista;
                                rowPLP.PrecioDeVentaBrutoConImpuesto = prod.PrecioDeListaConImpuestos;
                                if (prod.PrecioLista != prod.PrecioDeListaEnBD)
                                    rowPLP["FechaUltimaModificacionPrecioDeVenta"] = DateTime.Now;
                                _dataProductosNuevos.tsh_ProductosListasDePrecios.ImportRow(rowPLP);
                            }

                        }
                    }
                }
                else
                {

                    foreach (Producto prod in this._productos)
                    {

                        if (prod.Estado.Equals("MODIF") && (prod.Activo || (!prod.Activo && _modificaProductosInactivos)))
                        {
                            DataRow _rowP = mz.erp.businessrules.tsh_Productos.GetByPk(prod.IdProducto);
                            _rowP["MAC"] = prod.MAC;
                            _rowP["PrecioDeCostoRef"] = prod.PrecioDeCosto;
                            if (prod.PrecioDeCosto != prod.PrecioDeCostoEnBD)
                                _rowP["FechaUltimaModificacionPrecioDeCosto"] = DateTime.Now;
                            _rowP["PrecioDeCostoDirecto"] = prod.PrecioDeCostoDirecto;
                            _rowP["PrecioDeCostoIndirecto"] = prod.PrecioDeCostoIndirecto;
                            _rowP["UsaPrecioDeCostoReposicion"] = prod.UsaPrecioDeCostoReposicion;
                            _rowP["PrecioDeCostoReposicion"] = prod.PrecioDeCostoReposicion;
                            _rowP["PrecioDeCostoPromedioPonderado"] = prod.PrecioDeCostoPromedioPonderado;
                            _rowP["PrecioDeVentaNeto"] = prod.PrecioDeVentaNeto;
                            _rowP["MaxDescuentoPorcentual"] = prod.PorcentajeMaximoDescuento;
                            _rowP["MaxDescuento"] = prod.MaximoDescuento;
                            _rowP["PrecioDeVentaBruto"] = prod.PrecioLista;
                            if (prod.PrecioLista != prod.PrecioDeListaEnBD)
                                _rowP["FechaUltimaModificacionPrecioDeVenta"] = DateTime.Now;
                            _rowP["IdMonedaCierrePrecioDeCostoRef"] = prod.IdMonedaPrecioDeCosto;
                            _rowP["IdMonedaCierrePrecioDeVentaNeto"] = prod.IdMonedaPrecioDeVentaNeto;
                            _rowP["IdMonedaCierreMaxDescuento"] = prod.IdMonedaPrecioDeVentaNeto;
                            _rowP["IdMonedaCierrePrecioDeVentaBruto"] = prod.IdMonedaPrecioDeVentaNeto;

                            _rowP["IdCotizacionCierrePrecioDeCostoRef"] = prod.IdCotizacionMonedaPrecioDeCosto;
                            _rowP["IdCotizacionCierrePrecioDeVentaNeto"] = prod.IdCotizacionMonedaPrecioDeVentaNeto;
                            _rowP["IdCotizacionCierreMaxDescuento"] = prod.IdCotizacionMonedaPrecioDeVentaNeto;
                            _rowP["IdCotizacionCierrePrecioDeVentaBruto"] = prod.IdCotizacionMonedaPrecioDeVentaNeto;
                            _rowP["IdProveedorDefault"] = prod.IdProveedorDefault;
                            _rowP["IdResponsableCreacion"] = Security.IdPersona;

                            if (ModificaCamposAuxiliares)
                            {
                                _rowP["CampoAuxiliar1"] = prod.CampoAuxiliar1;
                                _rowP["CampoAuxiliar2"] = prod.CampoAuxiliar2;
                                _rowP["CampoAuxiliar3"] = prod.CampoAuxiliar3;
                                _rowP["CampoAuxiliar4"] = prod.CampoAuxiliar4;
                                _rowP["CampoAuxiliar5"] = prod.CampoAuxiliar5;
                            }
                            if (ModificaCodigoSecundario)
                                _rowP["CodigoSecundario"] = prod.CodigoSecundario;
                            if (ModificaCodigoProveedor)
                                _rowP["CodigoProveedor"] = prod.CodigoProveedor;
                            if (ModificaDescripcion)
                                _rowP["Descripcion"] = prod.Descripcion;

                            _dataProductosNuevos.tsh_Productos.ImportRow(_rowP);

                            if (ModificaAlgunaJerarquia())
                                //Agrego las jerarquias
                                this.commitJerarquiasProducto(prod);

                            //Modifico el campo PrecioFinalEstimado de la table tsh_ProductosSucursales
                            tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesRow rowSucursales = tsh_ProductosSucursales.GetByPk(prod.IdProducto, Security.IdEmpresa, Security.IdSucursal);
                            rowSucursales.PrecioFinalEstimado = prod.PrecioDeListaConImpuestos;
                            _dataProductosNuevos.tsh_ProductosSucursales.ImportRow(rowSucursales);

                            //Modifico los campos PrecioDeVentaBruto y PrecioDeVentaBrutoConImpuesto de la lista default en tsh_ProductosListasDePrecios
                            tsh_ListasDePreciosDataset.tsh_ListasDePreciosRow rowLPDefault = tsh_ListasDePrecios.GetDefault();
                            if (rowLPDefault != null)
                            {
                                tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow rowPLP = tsh_ProductosListasDePrecios.GetByPk(prod.IdProducto, rowLPDefault.IdListaDePrecio);
                                rowPLP.PrecioDeVentaBruto = prod.PrecioLista;
                                rowPLP.PrecioDeVentaBrutoConImpuesto = prod.PrecioDeListaConImpuestos;
                                if (prod.PrecioLista != prod.PrecioDeListaEnBD)
                                    rowPLP["FechaUltimaModificacionPrecioDeVenta"] = DateTime.Now;
                                _dataProductosNuevos.tsh_ProductosListasDePrecios.ImportRow(rowPLP);
                            }
                        }

                    }
                }
            }


        }


        private void commitProductoModificado(Producto prod)
        {
            if (prod.Estado.Equals("MODIF") && (prod.Activo || (!prod.Activo && _modificaProductosInactivos)))
            {
                DataRow _rowP = mz.erp.businessrules.tsh_Productos.GetByPk(prod.IdProducto);
                _rowP["MAC"] = prod.MAC;
                _rowP["PrecioDeCostoRef"] = prod.PrecioDeCosto;
                if (prod.PrecioDeCosto != prod.PrecioDeCostoEnBD)
                    _rowP["FechaUltimaModificacionPrecioDeCosto"] = DateTime.Now;
                _rowP["PrecioDeCostoDirecto"] = prod.PrecioDeCostoDirecto;
                _rowP["PrecioDeCostoIndirecto"] = prod.PrecioDeCostoIndirecto;
                _rowP["UsaPrecioDeCostoReposicion"] = prod.UsaPrecioDeCostoReposicion;
                _rowP["PrecioDeCostoReposicion"] = prod.PrecioDeCostoReposicion;
                _rowP["PrecioDeCostoPromedioPonderado"] = prod.PrecioDeCostoPromedioPonderado;
                _rowP["PrecioDeVentaNeto"] = prod.PrecioDeVentaNeto;
                _rowP["MaxDescuentoPorcentual"] = prod.PorcentajeMaximoDescuento;
                _rowP["MaxDescuento"] = prod.MaximoDescuento;
                _rowP["PrecioDeVentaBruto"] = prod.PrecioLista;
                if (prod.PrecioLista != prod.PrecioDeListaEnBD)
                    _rowP["FechaUltimaModificacionPrecioDeVenta"] = DateTime.Now;
                _rowP["IdMonedaCierrePrecioDeCostoRef"] = prod.IdMonedaPrecioDeCosto;
                _rowP["IdMonedaCierrePrecioDeVentaNeto"] = prod.IdMonedaPrecioDeVentaNeto;
                _rowP["IdMonedaCierreMaxDescuento"] = prod.IdMonedaPrecioDeVentaNeto;
                _rowP["IdMonedaCierrePrecioDeVentaBruto"] = prod.IdMonedaPrecioDeVentaNeto;

                _rowP["IdCotizacionCierrePrecioDeCostoRef"] = prod.IdCotizacionMonedaPrecioDeCosto;
                _rowP["IdCotizacionCierrePrecioDeVentaNeto"] = prod.IdCotizacionMonedaPrecioDeVentaNeto;
                _rowP["IdCotizacionCierreMaxDescuento"] = prod.IdCotizacionMonedaPrecioDeVentaNeto;
                _rowP["IdCotizacionCierrePrecioDeVentaBruto"] = prod.IdCotizacionMonedaPrecioDeVentaNeto;
                _rowP["IdProveedorDefault"] = prod.IdProveedorDefault;

                _dataProductosNuevos.tsh_Productos.ImportRow(_rowP);

                //Modifico el campo PrecioFinalEstimado de la table tsh_ProductosSucursales
                tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesRow rowSucursales = tsh_ProductosSucursales.GetByPk(prod.IdProducto, Security.IdEmpresa, Security.IdSucursal);
                rowSucursales.PrecioFinalEstimado = prod.PrecioDeListaConImpuestos;
                _dataProductosNuevos.tsh_ProductosSucursales.ImportRow(rowSucursales);

                //Sabrina 20100615 - Tarea 764
                if (_habilitaListasDePrecios)//Depende de la variable Productos.ListasDePrecios
                {
                    foreach (ListaDePreciosItem item in prod.ListaDePrecios.Items)
                    {
                        if (_listasDePreciosSeleccionadas.Contains(new ListaDePreciosView(item.IdListaDePrecios, item.Descripcion)))
                            _dataProductosNuevos = prod.ListaDePrecios.Commit(_dataProductosNuevos, item);
                    }
                }
                else
                {
                    ListaDePreciosItem item = prod.ListaDePrecios.GetDefaultItem();
                    item.ModoDeAplicacion = "P";
                    item.PrecioDeCosto = prod.PrecioDeCosto;
                    item.Mac = prod.MAC;
                    item.PrecioDeVentaNeto = prod.PrecioDeVentaNeto;
                    decimal coeficienteNew = item.GetCoeficienteFromPrecioVentaBruto(prod.PrecioLista);
                    item.CoeficienteProducto = coeficienteNew;
                    item.PrecioDeVentaBruto = prod.PrecioLista;
                    item.PrecioDeVentaBrutoConImpuestos = prod.PrecioDeListaConImpuestos;
                    _dataProductosNuevos = prod.ListaDePrecios.Commit(_dataProductosNuevos, item);
                }
                //Modifico los campos PrecioDeVentaBruto y PrecioDeVentaBrutoConImpuesto de la lista default en tsh_ProductosListasDePrecios
                /*tsh_ListasDePreciosDataset.tsh_ListasDePreciosRow rowLPDefault = tsh_ListasDePrecios.GetDefault();
                if(rowLPDefault != null)
                {
                    tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow rowPLP = tsh_ProductosListasDePrecios.GetByPk(prod.IdProducto, rowLPDefault.IdListaDePrecio);
                    rowPLP.PrecioDeVentaBruto = prod.PrecioLista;
                    rowPLP.PrecioDeVentaBrutoConImpuesto = prod.PrecioDeListaConImpuestos;
                    if(prod.PrecioLista != prod.PrecioDeListaEnBD)
                        rowPLP["FechaUltimaModificacionPrecioDeVenta"] = DateTime.Now;
                    _dataProductosNuevos.tsh_ProductosListasDePrecios.ImportRow(rowPLP);
                }*/
                //Fin Sabrina 20100615 - Tarea 764
            }

        }

        private static SentenciasReplicacion GenerateReplicaction()
        {
            SentenciasReplicacion replication = new SentenciasReplicacion();
            replication.IdConexion = Security.IdConexion;
            replication.SucGeneradora = Security.IdSucursal;
            //Para todas las sucursales
            replication.Destino = null;
            replication.VersionBD = null;
            replication.NombreTabla = "dataaccess.tsh_Productos";
            return replication;

        }

        public void Flush(string IdTransaction)
        {
            if (OnTaskBeforeFlush != null)
                OnTaskBeforeFlush(this, new EventArgs());
            SentenciasReplicacion _replicacion = GenerateReplicaction();
            if (AgregaProductosNuevos || _dataProductosNuevos.tsh_Productos.Rows.Count > 0)
                mz.erp.dataaccess.tsh_ProductosEx.Update(_dataProductosNuevos, _replicacion);
            if (this._processParent.Process.ProcessName.Equals("ProcesoModificarPreciosMasivoDesdeExcel"))
                mz.erp.dataaccess.tpu_ProveedoresProductos.Update(this._dataProveedoresProductos.Tables[0], IdTransaction);

            //Sabrina: Tarea 1068. 20110317
            foreach (Producto prod in this._productos)
            {
                if (ActualizaPreciosProductosCombo)
                    tsh_CombosDet.ActualizarPreciosProductosCombo(IdTransaction, prod.IdProducto, prod.PrecioDeCosto, prod.PrecioLista, prod.IdMonedaPrecioDeCosto, prod.IdMonedaPrecioDeVentaNeto, prod.IdCotizacionMonedaPrecioDeCosto, prod.IdCotizacionMonedaPrecioDeVentaNeto);
            }
            //Fin Sabrina: Tarea 1068. 20110317

            if (OnTaskAfterFlush != null)
                OnTaskAfterFlush(this, new EventArgs());
        }

        public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
        {

        }

        public void PutExtraData(ProcessCollectionData _processCollectionData)
        {

        }

        public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
        {

            return GenerateReplicaction();
        }

        public bool GetHasSaved()
        {

            return false;
        }

        #endregion

        #region Comentada post Merge

        //		#region Metodos Publicos
        //		public void RefreshData()
        //		{		
        //			try
        //			{
        //
        //				string CadenaConexion=@"Provider=Microsoft.Jet.OLEDB.4.0;" + 
        //					@"Data Source=" + this.ArchivoExcel + ";" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"'; 
        //
        //				OleDbConnection con=new OleDbConnection(CadenaConexion); 
        //
        //
        //				string strSQL="SELECT Codigo,CodigoAuxiliar,Descripcion,PrecioDeCosto,Coeficiente1,Coeficiente2,Coeficiente3,Coeficiente4,Coeficiente5,PrecioDeCostoFinal FROM [" + this.NombreHojaArchivoExcel +"$]"; 
        //
        //				OleDbDataAdapter da=new OleDbDataAdapter(strSQL,con); 
        //
        //				DataSet ds=new DataSet(); 
        //
        //				da.Fill(ds); 
        //
        //				DataTable table = new DataTable(""); 
        //				DataColumn columna1=new DataColumn("Estado");
        //				DataColumn columna2=new DataColumn("Codigo");
        //				DataColumn columna3=new DataColumn("CodigoAuxiliar");
        //				DataColumn columna4=new DataColumn("Descripcion");
        //				DataColumn columna5=new DataColumn("PrecioDeCosto");
        //				DataColumn columna6=new DataColumn("Coeficiente1");
        //				DataColumn columna7=new DataColumn("Coeficiente2");
        //				DataColumn columna8=new DataColumn("Coeficiente3");
        //				DataColumn columna9=new DataColumn("Coeficiente4");
        //				DataColumn columna10=new DataColumn("Coeficiente5");
        //				DataColumn columna11=new DataColumn("PrecioDeCostoFinal");
        //				DataColumn columna12=new DataColumn("IdProducto");
        //				columna1.DataType =typeof (string); 
        //				columna2.DataType =typeof (string); 
        //				columna3.DataType =typeof (string); 
        //				columna4.DataType =typeof (string); 
        //				columna5.DataType =typeof (decimal); 
        //				columna6.DataType =typeof (decimal); 
        //				columna7.DataType =typeof (decimal); 
        //				columna8.DataType =typeof (decimal); 
        //				columna9.DataType =typeof (decimal); 
        //				columna10.DataType =typeof (decimal); 
        //				columna11.DataType =typeof (decimal); 
        //				columna12.DataType =typeof (string); 
        //				table.Columns.Add(columna1);
        //				table.Columns.Add(columna2);
        //				table.Columns.Add(columna3);
        //				table.Columns.Add(columna4);
        //				table.Columns.Add(columna5);
        //				table.Columns.Add(columna6);
        //				table.Columns.Add(columna7);
        //				table.Columns.Add(columna8);
        //				table.Columns.Add(columna9);
        //				table.Columns.Add(columna10);
        //				table.Columns.Add(columna11);
        //				table.Columns.Add(columna12);
        //				
        //				foreach(DataRow row in ds.Tables[0].Rows)
        //				{
        //					if(!(Convert.ToString(row["Codigo"])).Equals(string.Empty))
        //					{
        //						string Estado = string.Empty;
        //						string CodigoIngresado = Convert.ToString(row["Codigo"]);
        //						string IdProducto = string.Empty;
        //						if(PorCodigo)
        //						{
        //
        //							//IdProducto = tsh_Productos.GetPkByCodigo(CodigoIngresado);
        //							IdProducto = tsh_Productos.GetIdProductoByCodigo(CodigoIngresado);
        //						}
        //						else if(PorCodigoSecundario)
        //						{
        //							//IdProducto = tsh_Productos.GetPkByCodigoSecundario(CodigoIngresado);
        //							IdProducto = tsh_Productos.GetIdProductoByCodigoSecundario(CodigoIngresado);
        //						}
        //						else if(PorCodigoProveedor)
        //						{
        //
        //							//IdProducto = tsh_Productos.GetPkByCodigoProveedor(CodigoIngresado);
        //							IdProducto = tsh_Productos.GetIdProductoByCodigoProveedor(CodigoIngresado);
        //						}
        //						Producto prod = null;
        //						if(IdProducto == null || IdProducto.Equals(string.Empty)) //No existe el producto en tsh_Productos
        //						{
        //							Estado = "NEW";
        //						}
        //						else
        //						{
        //							string IdProveedor = tpu_Proveedores.GetPKByCodigo(this.CodigoProveedor);
        //							tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow rowPP = tpu_ProveedoresProductos.GetByPk(IdProveedor, IdProducto);
        //							if(rowPP == null) //No existe el producto en tpu_ProveedoresProductos
        //							{
        //								Estado = "NEW";
        //							}
        //							else
        //								Estado = "MODIF";
        //						}
        //
        //						DataRow rowC = table.NewRow();
        //						rowC["Estado"] = Estado;
        //						rowC["Codigo"] = CodigoIngresado;
        //						rowC["CodigoAuxiliar"] = Convert.ToString(row["CodigoAuxiliar"]);
        //						rowC["Descripcion"] = Convert.ToString(row["Descripcion"]);
        //						rowC["PrecioDeCosto"] = row["PrecioDeCosto"];
        //						rowC["Coeficiente1"] = row["Coeficiente1"];
        //						rowC["Coeficiente2"] = row["Coeficiente2"];
        //						rowC["Coeficiente3"] = row["Coeficiente3"];
        //						rowC["Coeficiente4"] = row["Coeficiente4"];
        //						rowC["Coeficiente5"] = row["Coeficiente5"];
        //						rowC["PrecioDeCostoFinal"] = row["PrecioDeCostoFinal"];
        //						rowC["IdProducto"] = IdProducto;
        //						table.Rows.Add(rowC);
        //					}
        //				}
        //				_result = table;
        //
        //				if(this.DataChanged != null)
        //				{
        //					this.DataChanged(this, new System.EventArgs() );
        //				}
        //			}
        //			catch(Exception e)
        //			{
        //				string message = e.Message;
        //				System.Console.WriteLine(message);
        //			}
        //			
        //		}
        //
        //
        //
        //		#endregion
        //
        //		#region Metodos Privados
        //
        //
        //		public void AddTsh_ProductosJerarquias(string idProducto,ArrayList TodaJerarquia)
        //		{
        //			tsh_ProductosExDataset.tsh_ProductosJerarquiasRow _row = this._dataProductosNuevos.tsh_ProductosJerarquias.Newtsh_ProductosJerarquiasRow();
        //			_row.IdProducto=idProducto;
        //			_row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
        //			_row.IdConexionCreacion = Security.IdConexion;
        //			_row.IdConexionUltimaModificacion = Security.IdConexion;
        //			_row.IdReservado = 0;
        //			_row.RowId = Guid.Empty;
        //			_row.IdEmpresa = Security.IdEmpresa;
        //			_row.IdSucursal=Security.IdSucursal;
        //			_row=this.MetodoAuxiliarAddTsh_ProductosJerarquias(TodaJerarquia,_row);
        //			_dataProductosNuevos.tsh_ProductosJerarquias.Addtsh_ProductosJerarquiasRow(_row);
        //				
        //		}
        //		private tsh_ProductosExDataset.tsh_ProductosJerarquiasRow MetodoAuxiliarAddTsh_ProductosJerarquias(ArrayList TodaJerarquia,tsh_ProductosExDataset.tsh_ProductosJerarquiasRow _row)
        //		{
        //			 
        //			ArrayList ArrayNiveles1 = (TodaJerarquia.Count >0 && TodaJerarquia[0] != null)? (ArrayList)TodaJerarquia[0] : new ArrayList();
        //			ArrayList ArrayNiveles2 = (TodaJerarquia.Count >1 && TodaJerarquia[1] != null)? (ArrayList)TodaJerarquia[1] : new ArrayList();
        //			ArrayList ArrayNiveles3 = (TodaJerarquia.Count >2 && TodaJerarquia[2] != null)? (ArrayList)TodaJerarquia[2] : new ArrayList();
        //			ArrayList ArrayNiveles4 = (TodaJerarquia.Count >3 && TodaJerarquia[3] != null)? (ArrayList)TodaJerarquia[3] : new ArrayList();
        //			ArrayList ArrayNiveles5 = (TodaJerarquia.Count >4 && TodaJerarquia[4] != null)? (ArrayList)TodaJerarquia[4] : new ArrayList();
        //			ArrayList ArrayNiveles6 = (TodaJerarquia.Count >5 && TodaJerarquia[5] != null)? (ArrayList)TodaJerarquia[5] : new ArrayList();
        //			ArrayList ArrayNiveles7 = (TodaJerarquia.Count >6 && TodaJerarquia[6] != null)? (ArrayList)TodaJerarquia[6] : new ArrayList();
        //			ArrayList ArrayNiveles8 = (TodaJerarquia.Count >7 && TodaJerarquia[7] != null)? (ArrayList)TodaJerarquia[7] : new ArrayList();
        //				
        //									
        //			int i= ArrayNiveles1.Count;
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura1a= Convert.ToString(ArrayNiveles1[0]);
        //				i--;
        //			}
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura1b=Convert.ToString( ArrayNiveles1[1]);
        //				i--;
        //			}
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura1c=Convert.ToString( ArrayNiveles1[2]);
        //				i--;
        //			}
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura1d= Convert.ToString(ArrayNiveles1[3]);
        //				i--;
        //			}
        //				
        //			//ArrayNiveles 2
        //			i= ArrayNiveles2.Count;
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura2a= Convert.ToString(ArrayNiveles2[0]);
        //				i--;
        //			}
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura2b= Convert.ToString(ArrayNiveles2[1]);
        //				i--;
        //			}
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura2c= Convert.ToString(ArrayNiveles2[2]);
        //				i--;
        //			}
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura2d=Convert.ToString( ArrayNiveles2[3]);
        //				i--;
        //			}
        //			//ArrayNiveles3
        //			i= ArrayNiveles3.Count;
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura3a=Convert.ToString( ArrayNiveles3[0]);
        //				i--;
        //			}
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura3b= Convert.ToString(ArrayNiveles3[1]);
        //				i--;
        //			}
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura3c= Convert.ToString(ArrayNiveles3[2]);
        //				i--;
        //			}
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura3d= Convert.ToString(ArrayNiveles3[3]);
        //				i--;
        //			}
        //			//Array Niveles 4
        //			i= ArrayNiveles4.Count;
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura4a= Convert.ToString(ArrayNiveles4[0]);
        //				i--;
        //			}
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura4b= Convert.ToString(ArrayNiveles4[1]);
        //				i--;
        //			}
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura4c= Convert.ToString(ArrayNiveles4[2]);
        //				i--;
        //			}
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura4d= Convert.ToString(ArrayNiveles4[3]);
        //				i--;
        //			}
        //
        //			//Array Niveles 5
        //			i= ArrayNiveles5.Count;
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura5a= Convert.ToString(ArrayNiveles5[0]);
        //				i--;
        //			}
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura5b= Convert.ToString(ArrayNiveles5[1]);
        //				i--;
        //			}
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura5c= Convert.ToString(ArrayNiveles5[2]);
        //				i--;
        //			}
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura5d= Convert.ToString(ArrayNiveles5[3]);
        //				i--;
        //			}
        //			//Array Niveles 6
        //			i= ArrayNiveles6.Count;
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura6a=Convert.ToString( ArrayNiveles6[0]);
        //				i--;
        //			}
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura6b= Convert.ToString(ArrayNiveles6[1]);
        //				i--;
        //			}
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura6c= Convert.ToString(ArrayNiveles6[2]);
        //				i--;
        //			}
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura6d= Convert.ToString(ArrayNiveles6[3]);
        //				i--;
        //			}
        //			//Array Niveles 7
        //			i= ArrayNiveles7.Count;
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura7a= Convert.ToString(ArrayNiveles7[0]);
        //				i--;
        //			}
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura7b= Convert.ToString(ArrayNiveles7[1]);
        //				i--;
        //			}
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura7c= Convert.ToString(ArrayNiveles7[2]);
        //				i--;
        //			}
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura7d= Convert.ToString(ArrayNiveles7[3]);
        //				i--;
        //			}
        //			//Array Niveles 8
        //			i= ArrayNiveles8.Count;
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura8a= Convert.ToString(ArrayNiveles8[0]);
        //				i--;
        //			}
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura8b= Convert.ToString(ArrayNiveles8[1]);
        //				i--;
        //			}
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura8c= Convert.ToString(ArrayNiveles8[2]);
        //				i--;
        //			}
        //			if (i>0)
        //			{
        //				_row.IdNomenclatura8d= Convert.ToString(ArrayNiveles8[3]);
        //				i--;
        //			}
        //			return _row;
        //			
        //		}
        //
        //
        //
        //		#endregion

        #endregion

        #region Metodos Publicos

        //Sabrina: Tarea 1068. 20110317
        public bool CambioCostoProductosCombo()
        {
            bool cambio = false;
            foreach (Producto prod in this._productos)
            {
                if (prod.Estado.Equals("MODIF"))
                {
                    if (prod.PrecioDeCosto != prod.PrecioDeCostoEnBD)
                    {
                        tsh_CombosDetDataset.tsh_CombosDetDataTable tableProdCombo = tsh_CombosDet.GetByIdProductoReferencia(prod.IdProducto).tsh_CombosDet;
                        if (tableProdCombo.Rows.Count > 0)
                            cambio = true;
                    }
                }
            }
            return cambio;
        }

        public bool CambioPrecioVentaProductosCombo()
        {
            bool cambio = false;
            foreach (Producto prod in this._productos)
            {
                if (prod.Estado.Equals("MODIF"))
                {
                    if (prod.PrecioLista != prod.PrecioDeListaEnBD)
                    {
                        tsh_CombosDetDataset.tsh_CombosDetDataTable tableProdCombo = tsh_CombosDet.GetByIdProductoReferencia(prod.IdProducto).tsh_CombosDet;
                        if (tableProdCombo.Rows.Count > 0)
                            cambio = true;
                    }
                }
            }
            return cambio;
        }
        //Fin Sabrina: Tarea 1068. 20110317

        public void RefreshData()
        {
            try
            {

                string CadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                    @"Data Source=" + this.ArchivoExcel + ";" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES;IMEX=1" + '"';

                OleDbConnection con = new OleDbConnection(CadenaConexion);

                string strSQL = string.Empty;
                //German 20120202 - Tarea 0000273
                if (this._processParent.Process.ProcessName.Equals("ProcesoModificarPreciosMasivoDesdeExcel") && ! _actualizaListasDePreciosDeVentaDesdeExcel)
                    strSQL = "SELECT Codigo,CodigoAuxiliar,Descripcion,PrecioDeCosto,Coeficiente1,Coeficiente2,Coeficiente3,Coeficiente4,Coeficiente5,PrecioDeCostoFinal FROM [" + this.NombreHojaArchivoExcel + "$]";
                else 
                    if (this._processParent.Process.ProcessName.Equals("ProcesoModificarPreciosMasivoDesdeExcel") && _actualizaListasDePreciosDeVentaDesdeExcel)
                        strSQL = "SELECT Codigo,CodigoAuxiliar,Descripcion,PrecioDeCosto,Coeficiente1,Coeficiente2,Coeficiente3,Coeficiente4,Coeficiente5,PrecioDeCostoFinal,PrecioDeVentaLista1,PrecioDeVentaLista2,PrecioDeVentaLista3,PrecioDeVentaLista4,PrecioDeVentaLista5,PrecioDeVentaLista6,PrecioDeVentaLista7,PrecioDeVentaLista8,PrecioDeVentaLista9,PrecioDeVentaLista10 FROM [" + this.NombreHojaArchivoExcel + "$]";
               
                    else if (this._processParent.Process.ProcessName.Equals("ProcesoModificarPreciosVentaMasivoDesdeExcel"))
                        strSQL = "SELECT Codigo,CodigoAuxiliar,CodigoSecundario,CodigoProveedor,Descripcion,IVA,PrecioDeVenta,CampoAuxiliar1,CampoAuxiliar2,CampoAuxiliar3,CampoAuxiliar4,CampoAuxiliar5,Jerarquia1,Subjerarquia1,Jerarquia2,Subjerarquia2,Jerarquia3,Subjerarquia3,Jerarquia4,Subjerarquia4,Jerarquia5,Subjerarquia5,Jerarquia6,Subjerarquia6,Jerarquia7,Subjerarquia7,Jerarquia8,Subjerarquia8 FROM [" + this.NombreHojaArchivoExcel + "$]";
                //Fin German 20120202 - Tarea 0000273
                OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);

                DataSet ds = new DataSet();

                da.Fill(ds);
                DataTable table = new DataTable("");

                //German 20091023 - Tarea 477
                _productosRepetidos = new ArrayList();
                ArrayList aux = new ArrayList();
                //Fin German 20091023 - Tarea 477




                if (this._processParent.Process.ProcessName.Equals("ProcesoModificarPreciosMasivoDesdeExcel"))
                {
                    DataColumn columna1 = new DataColumn("Estado");
                    DataColumn columna2 = new DataColumn("Codigo");
                    DataColumn columna3 = new DataColumn("CodigoAuxiliar");
                    DataColumn columna4 = new DataColumn("Descripcion");
                    DataColumn columna5 = new DataColumn("PrecioDeCosto");
                    DataColumn columna6 = new DataColumn("Coeficiente1");
                    DataColumn columna7 = new DataColumn("Coeficiente2");
                    DataColumn columna8 = new DataColumn("Coeficiente3");
                    DataColumn columna9 = new DataColumn("Coeficiente4");
                    DataColumn columna10 = new DataColumn("Coeficiente5");
                    DataColumn columna11 = new DataColumn("PrecioDeCostoFinal");
                    DataColumn columna12 = new DataColumn("IdProducto");
                    columna1.DataType = typeof(string);
                    columna2.DataType = typeof(string);
                    columna3.DataType = typeof(string);
                    columna4.DataType = typeof(string);
                    columna5.DataType = typeof(decimal);
                    columna6.DataType = typeof(decimal);
                    columna7.DataType = typeof(decimal);
                    columna8.DataType = typeof(decimal);
                    columna9.DataType = typeof(decimal);
                    columna10.DataType = typeof(decimal);
                    columna11.DataType = typeof(decimal);
                    columna12.DataType = typeof(string);
                    table.Columns.Add(columna1);
                    table.Columns.Add(columna2);
                    table.Columns.Add(columna3);
                    table.Columns.Add(columna4);
                    table.Columns.Add(columna5);
                    table.Columns.Add(columna6);
                    table.Columns.Add(columna7);
                    table.Columns.Add(columna8);
                    table.Columns.Add(columna9);
                    table.Columns.Add(columna10);
                    table.Columns.Add(columna11);
                    table.Columns.Add(columna12);
                    //German 20120202 - Tarea 0000273
                    if (_actualizaListasDePreciosDeVentaDesdeExcel)
                    {

                        DataColumn columna13 = new DataColumn("PrecioDeVentaLista1");
                        DataColumn columna14 = new DataColumn("PrecioDeVentaLista2");
                        DataColumn columna15 = new DataColumn("PrecioDeVentaLista3");
                        DataColumn columna16 = new DataColumn("PrecioDeVentaLista4");
                        DataColumn columna17 = new DataColumn("PrecioDeVentaLista5");
                        DataColumn columna18 = new DataColumn("PrecioDeVentaLista6");
                        DataColumn columna19 = new DataColumn("PrecioDeVentaLista7");
                        DataColumn columna20 = new DataColumn("PrecioDeVentaLista8");
                        DataColumn columna21 = new DataColumn("PrecioDeVentaLista9");
                        DataColumn columna22 = new DataColumn("PrecioDeVentaLista10");
                        columna13.DataType = typeof(decimal);
                        columna14.DataType = typeof(decimal);
                        columna15.DataType = typeof(decimal);
                        columna16.DataType = typeof(decimal);
                        columna17.DataType = typeof(decimal);
                        columna18.DataType = typeof(decimal);
                        columna19.DataType = typeof(decimal);
                        columna20.DataType = typeof(decimal);
                        columna21.DataType = typeof(decimal);
                        columna22.DataType = typeof(decimal);
                        table.Columns.Add(columna13);
                        table.Columns.Add(columna14);
                        table.Columns.Add(columna15);
                        table.Columns.Add(columna16);
                        table.Columns.Add(columna17);
                        table.Columns.Add(columna18);
                        table.Columns.Add(columna19);
                        table.Columns.Add(columna20);
                        table.Columns.Add(columna21);
                        table.Columns.Add(columna22);
                    }


                    //Fin German 20120202 - Tarea 0000273

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        if (!(Convert.ToString(row["Codigo"])).Equals(string.Empty))
                        {
                            string Estado = string.Empty;
                            string CodigoIngresado = Convert.ToString(row["Codigo"]);
                            string IdProducto = string.Empty;
                            if (PorCodigo)
                            {

                                IdProducto = tsh_Productos.GetIdProductoByCodigo(CodigoIngresado);
                            }
                            else if (PorCodigoSecundario)
                            {
                                IdProducto = tsh_Productos.GetIdProductoByCodigoSecundario(CodigoIngresado);
                            }
                            else if (PorCodigoProveedor)
                            {

                                string IdProveedor = tpu_Proveedores.GetPKByCodigo(this.CodigoProveedor);
                                IdProducto = tsh_Productos.GetIdProductoByCodigoProveedorIdProveedor(CodigoIngresado, IdProveedor);
                            }
                            Producto prod = null;
                            if (IdProducto == null || IdProducto.Equals(string.Empty)) //No existe el producto en tsh_Productos
                            {
                                Estado = "NEW";
                            }
                            else
                            {
                                string IdProveedor = tpu_Proveedores.GetPKByCodigo(this.CodigoProveedor);
                                tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow rowPP = tpu_ProveedoresProductos.GetByPk(IdProveedor, IdProducto);
                                if (rowPP == null) //No existe el producto en tpu_ProveedoresProductos
                                {
                                    Estado = "NEW_LP";
                                }
                                else
                                    Estado = "MODIF";
                            }
                            //German 20091023 - Tarea 477
                            if (!aux.Contains(CodigoIngresado))
                            {
                                //Fin German 20091023 - Tarea 477
                                aux.Add(CodigoIngresado);
                                DataRow rowC = table.NewRow();
                                rowC["Estado"] = Estado;
                                rowC["Codigo"] = CodigoIngresado;
                                rowC["CodigoAuxiliar"] = Convert.ToString(row["CodigoAuxiliar"]);
                                rowC["Descripcion"] = Convert.ToString(row["Descripcion"]);
                                rowC["PrecioDeCosto"] = row["PrecioDeCosto"];
                                rowC["Coeficiente1"] = row["Coeficiente1"];
                                rowC["Coeficiente2"] = row["Coeficiente2"];
                                rowC["Coeficiente3"] = row["Coeficiente3"];
                                rowC["Coeficiente4"] = row["Coeficiente4"];
                                rowC["Coeficiente5"] = row["Coeficiente5"];
                                rowC["PrecioDeCostoFinal"] = row["PrecioDeCostoFinal"];
                                rowC["IdProducto"] = IdProducto;
                                //German 20120202 - Tarea 0000273
                                //German 20120808 - Tarea 0000367
                                if (_actualizaListasDePreciosDeVentaDesdeExcel)
                                {
                                //Fin German 20120808 - Tarea 0000367
                                    rowC["PrecioDeVentaLista1"] = row["PrecioDeVentaLista1"];
                                    rowC["PrecioDeVentaLista2"] = row["PrecioDeVentaLista2"];
                                    rowC["PrecioDeVentaLista3"] = row["PrecioDeVentaLista3"];
                                    rowC["PrecioDeVentaLista4"] = row["PrecioDeVentaLista4"];
                                    rowC["PrecioDeVentaLista5"] = row["PrecioDeVentaLista5"];
                                    rowC["PrecioDeVentaLista6"] = row["PrecioDeVentaLista6"];
                                    rowC["PrecioDeVentaLista7"] = row["PrecioDeVentaLista7"];
                                    rowC["PrecioDeVentaLista8"] = row["PrecioDeVentaLista8"];
                                    rowC["PrecioDeVentaLista9"] = row["PrecioDeVentaLista9"];
                                    rowC["PrecioDeVentaLista10"] = row["PrecioDeVentaLista10"];
                                //German 20120808 - Tarea 0000367
                                }
                                //Fin German 20120808 - Tarea 0000367
                                //Fin German 20120202 - Tarea 0000273
                                table.Rows.Add(rowC);
                                //German 20091023 - Tarea 477

                            }
                            else
                                if (!_productosRepetidos.Contains(CodigoIngresado))
                                    _productosRepetidos.Add(CodigoIngresado);
                            //Fin German 20091023 - Tarea 477
                        }
                    }

                }
                else if (this._processParent.Process.ProcessName.Equals("ProcesoModificarPreciosVentaMasivoDesdeExcel"))
                {
                    DataColumn columna1 = new DataColumn("Estado");
                    DataColumn columna2 = new DataColumn("Codigo");
                    DataColumn columna3 = new DataColumn("CodigoAuxiliar");
                    DataColumn columna4 = new DataColumn("CodigoSecundario");
                    DataColumn columna5 = new DataColumn("CodigoProveedor");
                    DataColumn columna6 = new DataColumn("Descripcion");
                    DataColumn columna7 = new DataColumn("IVA");
                    DataColumn columna8 = new DataColumn("PrecioDeVenta");
                    DataColumn columna9 = new DataColumn("CampoAuxiliar1");
                    DataColumn columna10 = new DataColumn("CampoAuxiliar2");
                    DataColumn columna11 = new DataColumn("CampoAuxiliar3");
                    DataColumn columna12 = new DataColumn("CampoAuxiliar4");
                    DataColumn columna13 = new DataColumn("CampoAuxiliar5");
                    DataColumn columna14 = new DataColumn("Jerarquia1");
                    DataColumn columna15 = new DataColumn("Subjerarquia1");
                    DataColumn columna16 = new DataColumn("Jerarquia2");
                    DataColumn columna17 = new DataColumn("Subjerarquia2");
                    DataColumn columna18 = new DataColumn("Jerarquia3");
                    DataColumn columna19 = new DataColumn("Subjerarquia3");
                    DataColumn columna20 = new DataColumn("Jerarquia4");
                    DataColumn columna21 = new DataColumn("Subjerarquia4");
                    DataColumn columna22 = new DataColumn("Jerarquia5");
                    DataColumn columna23 = new DataColumn("Subjerarquia5");
                    DataColumn columna24 = new DataColumn("Jerarquia6");
                    DataColumn columna25 = new DataColumn("Subjerarquia6");
                    DataColumn columna26 = new DataColumn("Jerarquia7");
                    DataColumn columna27 = new DataColumn("Subjerarquia7");
                    DataColumn columna28 = new DataColumn("Jerarquia8");
                    DataColumn columna29 = new DataColumn("Subjerarquia8");
                    DataColumn columna30 = new DataColumn("IdProducto");
                    columna1.DataType = typeof(string);
                    columna2.DataType = typeof(string);
                    columna3.DataType = typeof(string);
                    columna4.DataType = typeof(string);
                    columna5.DataType = typeof(string);
                    columna6.DataType = typeof(string);
                    columna7.DataType = typeof(string);
                    columna8.DataType = typeof(decimal);
                    columna9.DataType = typeof(string);
                    columna10.DataType = typeof(string);
                    columna11.DataType = typeof(string);
                    columna12.DataType = typeof(string);
                    columna13.DataType = typeof(string);
                    columna14.DataType = typeof(string);
                    columna15.DataType = typeof(string);
                    columna16.DataType = typeof(string);
                    columna17.DataType = typeof(string);
                    columna18.DataType = typeof(string);
                    columna19.DataType = typeof(string);
                    columna20.DataType = typeof(string);
                    columna21.DataType = typeof(string);
                    columna22.DataType = typeof(string);
                    columna23.DataType = typeof(string);
                    columna24.DataType = typeof(string);
                    columna25.DataType = typeof(string);
                    columna26.DataType = typeof(string);
                    columna27.DataType = typeof(string);
                    columna28.DataType = typeof(string);
                    columna29.DataType = typeof(string);
                    columna30.DataType = typeof(string);
                    table.Columns.Add(columna1);
                    table.Columns.Add(columna2);
                    table.Columns.Add(columna3);
                    table.Columns.Add(columna4);
                    table.Columns.Add(columna5);
                    table.Columns.Add(columna6);
                    table.Columns.Add(columna7);
                    table.Columns.Add(columna8);
                    table.Columns.Add(columna9);
                    table.Columns.Add(columna10);
                    table.Columns.Add(columna11);
                    table.Columns.Add(columna12);
                    table.Columns.Add(columna13);
                    table.Columns.Add(columna14);
                    table.Columns.Add(columna15);
                    table.Columns.Add(columna16);
                    table.Columns.Add(columna17);
                    table.Columns.Add(columna18);
                    table.Columns.Add(columna19);
                    table.Columns.Add(columna20);
                    table.Columns.Add(columna21);
                    table.Columns.Add(columna22);
                    table.Columns.Add(columna23);
                    table.Columns.Add(columna24);
                    table.Columns.Add(columna25);
                    table.Columns.Add(columna26);
                    table.Columns.Add(columna27);
                    table.Columns.Add(columna28);
                    table.Columns.Add(columna29);
                    table.Columns.Add(columna30);

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        if (!(Convert.ToString(row["Codigo"])).Equals(string.Empty))
                        {
                            string Estado = string.Empty;
                            string CodigoIngresado = Convert.ToString(row["Codigo"]).TrimStart(null).TrimEnd(null);
                            string IdProducto = string.Empty;
                            if (PorCodigo)
                            {
                                IdProducto = tsh_Productos.GetIdProductoByCodigo(CodigoIngresado);
                            }
                            else if (PorCodigoSecundario)
                            {
                                IdProducto = tsh_Productos.GetIdProductoByCodigoSecundario(CodigoIngresado);
                            }
                            Producto prod = null;
                            if (IdProducto == null || IdProducto.Equals(string.Empty)) //No existe el producto en tsh_Productos
                            {
                                Estado = "NEW";
                            }
                            else
                                Estado = "MODIF";
                            //German 20091023 - Tarea 477
                            if (!aux.Contains(CodigoIngresado))
                            {
                                //Fin German 20091023 - Tarea 477
                                aux.Add(CodigoIngresado);

                                DataRow rowC = table.NewRow();
                                rowC["Estado"] = Estado;
                                rowC["Codigo"] = CodigoIngresado;
                                rowC["CodigoAuxiliar"] = Convert.ToString(row["CodigoAuxiliar"]).TrimStart(null).TrimEnd(null);
                                rowC["CodigoSecundario"] = Convert.ToString(row["CodigoSecundario"]).TrimStart(null).TrimEnd(null);
                                rowC["CodigoProveedor"] = Convert.ToString(row["CodigoProveedor"]).TrimStart(null).TrimEnd(null);
                                rowC["Descripcion"] = Convert.ToString(row["Descripcion"]).TrimStart(null).TrimEnd(null);
                                rowC["IVA"] = Convert.ToString(row["IVA"]).TrimStart(null).TrimEnd(null);
                                rowC["PrecioDeVenta"] = row["PrecioDeVenta"];
                                rowC["CampoAuxiliar1"] = Convert.ToString(row["CampoAuxiliar1"]).TrimStart(null).TrimEnd(null);
                                rowC["CampoAuxiliar2"] = Convert.ToString(row["CampoAuxiliar2"]).TrimStart(null).TrimEnd(null);
                                rowC["CampoAuxiliar3"] = Convert.ToString(row["CampoAuxiliar3"]).TrimStart(null).TrimEnd(null);
                                rowC["CampoAuxiliar4"] = Convert.ToString(row["CampoAuxiliar4"]).TrimStart(null).TrimEnd(null);
                                rowC["CampoAuxiliar5"] = Convert.ToString(row["CampoAuxiliar5"]).TrimStart(null).TrimEnd(null);
                                rowC["Jerarquia1"] = Convert.ToString(row["Jerarquia1"]).TrimStart(null).TrimEnd(null);
                                rowC["Subjerarquia1"] = Convert.ToString(row["Subjerarquia1"]).TrimStart(null).TrimEnd(null);
                                rowC["Jerarquia2"] = Convert.ToString(row["Jerarquia2"]).TrimStart(null).TrimEnd(null);
                                rowC["Subjerarquia2"] = Convert.ToString(row["Subjerarquia2"]).TrimStart(null).TrimEnd(null);
                                rowC["Jerarquia3"] = Convert.ToString(row["Jerarquia3"]).TrimStart(null).TrimEnd(null);
                                rowC["Subjerarquia3"] = Convert.ToString(row["Subjerarquia3"]).TrimStart(null).TrimEnd(null);
                                rowC["Jerarquia4"] = Convert.ToString(row["Jerarquia4"]).TrimStart(null).TrimEnd(null);
                                rowC["Subjerarquia4"] = Convert.ToString(row["Subjerarquia4"]).TrimStart(null).TrimEnd(null);
                                rowC["Jerarquia5"] = Convert.ToString(row["Jerarquia5"]).TrimStart(null).TrimEnd(null);
                                rowC["Subjerarquia5"] = Convert.ToString(row["Subjerarquia5"]).TrimStart(null).TrimEnd(null);
                                rowC["Jerarquia6"] = Convert.ToString(row["Jerarquia6"]).TrimStart(null).TrimEnd(null);
                                rowC["Subjerarquia6"] = Convert.ToString(row["Subjerarquia6"]).TrimStart(null).TrimEnd(null);
                                rowC["Jerarquia7"] = Convert.ToString(row["Jerarquia7"]).TrimStart(null).TrimEnd(null);
                                rowC["Subjerarquia7"] = Convert.ToString(row["Subjerarquia7"]).TrimStart(null).TrimEnd(null);
                                rowC["Jerarquia8"] = Convert.ToString(row["Jerarquia8"]).TrimStart(null).TrimEnd(null);
                                rowC["Subjerarquia8"] = Convert.ToString(row["Subjerarquia8"]).TrimStart(null).TrimEnd(null);
                                rowC["IdProducto"] = IdProducto;
                                table.Rows.Add(rowC);
                                //German 20091023 - Tarea 477

                            }
                            else
                                if (!_productosRepetidos.Contains(CodigoIngresado))
                                    _productosRepetidos.Add(CodigoIngresado);
                            //Fin German 20091023 - Tarea 477

                        }
                    }
                }

                _result = table;

                if (this.DataChanged != null)
                {
                    this.DataChanged(this, new System.EventArgs());
                }
            }
            catch (Exception e)
            {
                string message = e.Message;
                System.Console.WriteLine(message);
            }

        }

        //German 20091023 - Tarea 477
        public void ClearProductosRepetidos()
        {
            _productosRepetidos.Clear();
        }
        //Fin German 20091023 - Tarea 477


        #endregion

        #region Metodos Privados

        private bool ModificaAlgunaJerarquia()
        {
            return ModificaJerarquia1 || ModificaJerarquia2 || ModificaJerarquia3 || ModificaJerarquia4 || ModificaJerarquia5 || ModificaJerarquia6 || ModificaJerarquia7 || ModificaJerarquia8;
        }
        private ProductosJerarquias ValidarJerarquias(DataRow row)
        {
            string Codigo = Convert.ToString(row["Codigo"]);
            ProductosJerarquias jerarquias = new ProductosJerarquias();
            if (ModificaJerarquia1)
            {
                string Jerarquia1 = Convert.ToString(row["Jerarquia1"]);
                string Subjerarquia1 = Convert.ToString(row["Subjerarquia1"]);
                if (!Jerarquia1.Equals(string.Empty)) //Si ingreso jerarquia debe ingresar subjerarquia
                {
                    if (Subjerarquia1.Equals(string.Empty))
                        _errores.Add(new ItemDatasetError("Modificar Precios de Venta Masivo desde Excel", "Subjerarquia 1", "Debe ingresar la subjerarquia 1 para el producto " + Codigo + " o en su defecto no ingresar Jerarquia 1."));
                    else
                    {
                        string IdNomenclatura1a = tsh_JerarquiaAgrupProd.GetIdNomenclaturaByDescripcion(Jerarquia1);
                        if (IdNomenclatura1a.Equals(string.Empty))
                            _errores.Add(new ItemDatasetError("Modificar Precios de Venta Masivo desde Excel", "Jerarquia 1", "La Jerarquia 1 ingresada para el producto " + Codigo + " no existe o ha sido desactivada."));
                        else
                        {
                            string IdNomenclatura1b = tsh_JerarquiaAgrupProd.GetIdNomenclaturaByDescripcion(Subjerarquia1);
                            if (IdNomenclatura1b.Equals(string.Empty))
                                _errores.Add(new ItemDatasetError("Modificar Precios de Venta Masivo desde Excel", "Subjerarquia 1", "La Subjerarquia 1 ingresada para el producto " + Codigo + " no existe o ha sido desactivada."));
                            else
                            {
                                jerarquias.IdNomenclatura1a = IdNomenclatura1a;
                                jerarquias.IdNomenclatura1b = IdNomenclatura1b;
                            }
                        }
                    }
                }
            }

            if (ModificaJerarquia2)
            {
                string Jerarquia2 = Convert.ToString(row["Jerarquia2"]);
                string Subjerarquia2 = Convert.ToString(row["Subjerarquia2"]);
                if (!Jerarquia2.Equals(string.Empty)) //Si ingreso jerarquia debe ingresar subjerarquia
                {
                    if (Subjerarquia2.Equals(string.Empty))
                        _errores.Add(new ItemDatasetError("Modificar Precios de Venta Masivo desde Excel", "Subjerarquia 2", "Debe ingresar la subjerarquia 2 para el producto " + Codigo + " o en su defecto no ingresar Jerarquia 2."));
                    else
                    {
                        string IdNomenclatura2a = tsh_JerarquiaAgrupProd.GetIdNomenclaturaByDescripcion(Jerarquia2);
                        if (IdNomenclatura2a.Equals(string.Empty))
                            _errores.Add(new ItemDatasetError("Modificar Precios de Venta Masivo desde Excel", "Jerarquia 2", "La Jerarquia 2 ingresada para el producto " + Codigo + " no existe o ha sido desactivada."));
                        else
                        {
                            string IdNomenclatura2b = tsh_JerarquiaAgrupProd.GetIdNomenclaturaByDescripcion(Subjerarquia2);
                            if (IdNomenclatura2b.Equals(string.Empty))
                                _errores.Add(new ItemDatasetError("Modificar Precios de Venta Masivo desde Excel", "Subjerarquia 2", "La Subjerarquia 2 ingresada para el producto " + Codigo + " no existe o ha sido desactivada."));
                            else
                            {
                                jerarquias.IdNomenclatura2a = IdNomenclatura2a;
                                jerarquias.IdNomenclatura2b = IdNomenclatura2b;
                            }
                        }
                    }
                }
            }

            if (ModificaJerarquia3)
            {
                string Jerarquia3 = Convert.ToString(row["Jerarquia3"]);
                string Subjerarquia3 = Convert.ToString(row["Subjerarquia3"]);
                if (!Jerarquia3.Equals(string.Empty)) //Si ingreso jerarquia debe ingresar subjerarquia
                {
                    if (Subjerarquia3.Equals(string.Empty))
                        _errores.Add(new ItemDatasetError("Modificar Precios de Venta Masivo desde Excel", "Subjerarquia 3", "Debe ingresar la subjerarquia 3 para el producto " + Codigo + " o en su defecto no ingresar Jerarquia 3."));
                    else
                    {
                        string IdNomenclatura3a = tsh_JerarquiaAgrupProd.GetIdNomenclaturaByDescripcion(Jerarquia3);
                        if (IdNomenclatura3a.Equals(string.Empty))
                            _errores.Add(new ItemDatasetError("Modificar Precios de Venta Masivo desde Excel", "Jerarquia 3", "La Jerarquia 3 ingresada para el producto " + Codigo + " no existe o ha sido desactivada."));
                        else
                        {
                            string IdNomenclatura3b = tsh_JerarquiaAgrupProd.GetIdNomenclaturaByDescripcion(Subjerarquia3);
                            if (IdNomenclatura3b.Equals(string.Empty))
                                _errores.Add(new ItemDatasetError("Modificar Precios de Venta Masivo desde Excel", "Subjerarquia 3", "La Subjerarquia 3 ingresada para el producto " + Codigo + " no existe o ha sido desactivada."));
                            else
                            {
                                jerarquias.IdNomenclatura3a = IdNomenclatura3a;
                                jerarquias.IdNomenclatura3b = IdNomenclatura3b;
                            }
                        }
                    }
                }
            }

            if (ModificaJerarquia4)
            {
                string Jerarquia4 = Convert.ToString(row["Jerarquia4"]);
                string Subjerarquia4 = Convert.ToString(row["Subjerarquia4"]);
                if (!Jerarquia4.Equals(string.Empty)) //Si ingreso jerarquia debe ingresar subjerarquia
                {
                    if (Subjerarquia4.Equals(string.Empty))
                        _errores.Add(new ItemDatasetError("Modificar Precios de Venta Masivo desde Excel", "Subjerarquia 4", "Debe ingresar la subjerarquia 4 para el producto " + Codigo + " o en su defecto no ingresar Jerarquia 4."));
                    else
                    {
                        string IdNomenclatura4a = tsh_JerarquiaAgrupProd.GetIdNomenclaturaByDescripcion(Jerarquia4);
                        if (IdNomenclatura4a.Equals(string.Empty))
                            _errores.Add(new ItemDatasetError("Modificar Precios de Venta Masivo desde Excel", "Jerarquia 4", "La Jerarquia 4 ingresada para el producto " + Codigo + " no existe o ha sido desactivada."));
                        else
                        {
                            string IdNomenclatura4b = tsh_JerarquiaAgrupProd.GetIdNomenclaturaByDescripcion(Subjerarquia4);
                            if (IdNomenclatura4b.Equals(string.Empty))
                                _errores.Add(new ItemDatasetError("Modificar Precios de Venta Masivo desde Excel", "Subjerarquia 4", "La Subjerarquia 4 ingresada para el producto " + Codigo + " no existe o ha sido desactivada."));
                            else
                            {
                                jerarquias.IdNomenclatura4a = IdNomenclatura4a;
                                jerarquias.IdNomenclatura4b = IdNomenclatura4b;
                            }
                        }
                    }
                }
            }


            if (ModificaJerarquia5)
            {
                string Jerarquia5 = Convert.ToString(row["Jerarquia5"]);
                string Subjerarquia5 = Convert.ToString(row["Subjerarquia5"]);
                if (!Jerarquia5.Equals(string.Empty)) //Si ingreso jerarquia debe ingresar subjerarquia
                {
                    if (Subjerarquia5.Equals(string.Empty))
                        _errores.Add(new ItemDatasetError("Modificar Precios de Venta Masivo desde Excel", "Subjerarquia 5", "Debe ingresar la subjerarquia 5 para el producto " + Codigo + " o en su defecto no ingresar Jerarquia 5."));
                    else
                    {
                        string IdNomenclatura5a = tsh_JerarquiaAgrupProd.GetIdNomenclaturaByDescripcion(Jerarquia5);
                        if (IdNomenclatura5a.Equals(string.Empty))
                            _errores.Add(new ItemDatasetError("Modificar Precios de Venta Masivo desde Excel", "Jerarquia 5", "La Jerarquia 5 ingresada para el producto " + Codigo + " no existe o ha sido desactivada."));
                        else
                        {
                            string IdNomenclatura5b = tsh_JerarquiaAgrupProd.GetIdNomenclaturaByDescripcion(Subjerarquia5);
                            if (IdNomenclatura5b.Equals(string.Empty))
                                _errores.Add(new ItemDatasetError("Modificar Precios de Venta Masivo desde Excel", "Subjerarquia 5", "La Subjerarquia 5 ingresada para el producto " + Codigo + " no existe o ha sido desactivada."));
                            else
                            {
                                jerarquias.IdNomenclatura5a = IdNomenclatura5a;
                                jerarquias.IdNomenclatura5b = IdNomenclatura5b;
                            }
                        }
                    }
                }
            }

            if (ModificaJerarquia6)
            {
                string Jerarquia6 = Convert.ToString(row["Jerarquia6"]);
                string Subjerarquia6 = Convert.ToString(row["Subjerarquia6"]);
                if (!Jerarquia6.Equals(string.Empty)) //Si ingreso jerarquia debe ingresar subjerarquia
                {
                    if (Subjerarquia6.Equals(string.Empty))
                        _errores.Add(new ItemDatasetError("Modificar Precios de Venta Masivo desde Excel", "Subjerarquia 6", "Debe ingresar la subjerarquia 6 para el producto " + Codigo + " o en su defecto no ingresar Jerarquia 6."));
                    else
                    {
                        string IdNomenclatura6a = tsh_JerarquiaAgrupProd.GetIdNomenclaturaByDescripcion(Jerarquia6);
                        if (IdNomenclatura6a.Equals(string.Empty))
                            _errores.Add(new ItemDatasetError("Modificar Precios de Venta Masivo desde Excel", "Jerarquia 6", "La Jerarquia 6 ingresada para el producto " + Codigo + " no existe o ha sido desactivada."));
                        else
                        {
                            string IdNomenclatura6b = tsh_JerarquiaAgrupProd.GetIdNomenclaturaByDescripcion(Subjerarquia6);
                            if (IdNomenclatura6b.Equals(string.Empty))
                                _errores.Add(new ItemDatasetError("Modificar Precios de Venta Masivo desde Excel", "Subjerarquia 6", "La Subjerarquia 6 ingresada para el producto " + Codigo + " no existe o ha sido desactivada."));
                            else
                            {
                                jerarquias.IdNomenclatura6a = IdNomenclatura6a;
                                jerarquias.IdNomenclatura6b = IdNomenclatura6b;
                            }
                        }
                    }
                }
            }

            if (ModificaJerarquia7)
            {
                string Jerarquia7 = Convert.ToString(row["Jerarquia7"]);
                string Subjerarquia7 = Convert.ToString(row["Subjerarquia7"]);
                if (!Jerarquia7.Equals(string.Empty)) //Si ingreso jerarquia debe ingresar subjerarquia
                {
                    if (Subjerarquia7.Equals(string.Empty))
                        _errores.Add(new ItemDatasetError("Modificar Precios de Venta Masivo desde Excel", "Subjerarquia 7", "Debe ingresar la subjerarquia 7 para el producto " + Codigo + " o en su defecto no ingresar Jerarquia 7."));
                    else
                    {
                        string IdNomenclatura7a = tsh_JerarquiaAgrupProd.GetIdNomenclaturaByDescripcion(Jerarquia7);
                        if (IdNomenclatura7a.Equals(string.Empty))
                            _errores.Add(new ItemDatasetError("Modificar Precios de Venta Masivo desde Excel", "Jerarquia 7", "La Jerarquia 7 ingresada para el producto " + Codigo + " no existe o ha sido desactivada."));
                        else
                        {
                            string IdNomenclatura7b = tsh_JerarquiaAgrupProd.GetIdNomenclaturaByDescripcion(Subjerarquia7);
                            if (IdNomenclatura7b.Equals(string.Empty))
                                _errores.Add(new ItemDatasetError("Modificar Precios de Venta Masivo desde Excel", "Subjerarquia 7", "La Subjerarquia 7 ingresada para el producto " + Codigo + " no existe o ha sido desactivada."));
                            else
                            {
                                jerarquias.IdNomenclatura7a = IdNomenclatura7a;
                                jerarquias.IdNomenclatura7b = IdNomenclatura7b;
                            }
                        }
                    }
                }
            }

            if (ModificaJerarquia8)
            {
                string Jerarquia8 = Convert.ToString(row["Jerarquia8"]);
                string Subjerarquia8 = Convert.ToString(row["Subjerarquia8"]);
                if (!Jerarquia8.Equals(string.Empty)) //Si ingreso jerarquia debe ingresar subjerarquia
                {
                    if (Subjerarquia8.Equals(string.Empty))
                        _errores.Add(new ItemDatasetError("Modificar Precios de Venta Masivo desde Excel", "Subjerarquia 8", "Debe ingresar la subjerarquia 8 para el producto " + Codigo + " o en su defecto no ingresar Jerarquia 8."));
                    else
                    {
                        string IdNomenclatura8a = tsh_JerarquiaAgrupProd.GetIdNomenclaturaByDescripcion(Jerarquia8);
                        if (IdNomenclatura8a.Equals(string.Empty))
                            _errores.Add(new ItemDatasetError("Modificar Precios de Venta Masivo desde Excel", "Jerarquia 8", "La Jerarquia 8 ingresada para el producto " + Codigo + " no existe o ha sido desactivada."));
                        else
                        {
                            string IdNomenclatura8b = tsh_JerarquiaAgrupProd.GetIdNomenclaturaByDescripcion(Subjerarquia8);
                            if (IdNomenclatura8b.Equals(string.Empty))
                                _errores.Add(new ItemDatasetError("Modificar Precios de Venta Masivo desde Excel", "Subjerarquia 8", "La Subjerarquia 8 ingresada para el producto " + Codigo + " no existe o ha sido desactivada."));
                            else
                            {
                                jerarquias.IdNomenclatura8a = IdNomenclatura8a;
                                jerarquias.IdNomenclatura8b = IdNomenclatura8b;
                            }
                        }
                    }
                }
            }

            return jerarquias;
        }


        public void AddTsh_ProductosJerarquias(string idProducto, ArrayList TodaJerarquia)
        {
            tsh_ProductosExDataset.tsh_ProductosJerarquiasRow _row = this._dataProductosNuevos.tsh_ProductosJerarquias.Newtsh_ProductosJerarquiasRow();
            _row.IdProducto = idProducto;
            _row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
            _row.IdConexionCreacion = Security.IdConexion;
            _row.IdConexionUltimaModificacion = Security.IdConexion;
            _row.IdReservado = 0;
            _row.RowId = Guid.Empty;
            _row.IdEmpresa = Security.IdEmpresa;
            _row.IdSucursal = Security.IdSucursal;
            _row = this.MetodoAuxiliarAddTsh_ProductosJerarquias(TodaJerarquia, _row);
            _dataProductosNuevos.tsh_ProductosJerarquias.Addtsh_ProductosJerarquiasRow(_row);

        }
        private tsh_ProductosExDataset.tsh_ProductosJerarquiasRow MetodoAuxiliarAddTsh_ProductosJerarquias(ArrayList TodaJerarquia, tsh_ProductosExDataset.tsh_ProductosJerarquiasRow _row)
        {

            ArrayList ArrayNiveles1 = (TodaJerarquia.Count > 0 && TodaJerarquia[0] != null) ? (ArrayList)TodaJerarquia[0] : new ArrayList();
            ArrayList ArrayNiveles2 = (TodaJerarquia.Count > 1 && TodaJerarquia[1] != null) ? (ArrayList)TodaJerarquia[1] : new ArrayList();
            ArrayList ArrayNiveles3 = (TodaJerarquia.Count > 2 && TodaJerarquia[2] != null) ? (ArrayList)TodaJerarquia[2] : new ArrayList();
            ArrayList ArrayNiveles4 = (TodaJerarquia.Count > 3 && TodaJerarquia[3] != null) ? (ArrayList)TodaJerarquia[3] : new ArrayList();
            ArrayList ArrayNiveles5 = (TodaJerarquia.Count > 4 && TodaJerarquia[4] != null) ? (ArrayList)TodaJerarquia[4] : new ArrayList();
            ArrayList ArrayNiveles6 = (TodaJerarquia.Count > 5 && TodaJerarquia[5] != null) ? (ArrayList)TodaJerarquia[5] : new ArrayList();
            ArrayList ArrayNiveles7 = (TodaJerarquia.Count > 6 && TodaJerarquia[6] != null) ? (ArrayList)TodaJerarquia[6] : new ArrayList();
            ArrayList ArrayNiveles8 = (TodaJerarquia.Count > 7 && TodaJerarquia[7] != null) ? (ArrayList)TodaJerarquia[7] : new ArrayList();


            int i = ArrayNiveles1.Count;
            if (i > 0)
            {
                _row.IdNomenclatura1a = Convert.ToString(ArrayNiveles1[0]);
                i--;
            }
            if (i > 0)
            {
                _row.IdNomenclatura1b = Convert.ToString(ArrayNiveles1[1]);
                i--;
            }
            if (i > 0)
            {
                _row.IdNomenclatura1c = Convert.ToString(ArrayNiveles1[2]);
                i--;
            }
            if (i > 0)
            {
                _row.IdNomenclatura1d = Convert.ToString(ArrayNiveles1[3]);
                i--;
            }

            //ArrayNiveles 2
            i = ArrayNiveles2.Count;
            if (i > 0)
            {
                _row.IdNomenclatura2a = Convert.ToString(ArrayNiveles2[0]);
                i--;
            }
            if (i > 0)
            {
                _row.IdNomenclatura2b = Convert.ToString(ArrayNiveles2[1]);
                i--;
            }
            if (i > 0)
            {
                _row.IdNomenclatura2c = Convert.ToString(ArrayNiveles2[2]);
                i--;
            }
            if (i > 0)
            {
                _row.IdNomenclatura2d = Convert.ToString(ArrayNiveles2[3]);
                i--;
            }
            //ArrayNiveles3
            i = ArrayNiveles3.Count;
            if (i > 0)
            {
                _row.IdNomenclatura3a = Convert.ToString(ArrayNiveles3[0]);
                i--;
            }
            if (i > 0)
            {
                _row.IdNomenclatura3b = Convert.ToString(ArrayNiveles3[1]);
                i--;
            }
            if (i > 0)
            {
                _row.IdNomenclatura3c = Convert.ToString(ArrayNiveles3[2]);
                i--;
            }
            if (i > 0)
            {
                _row.IdNomenclatura3d = Convert.ToString(ArrayNiveles3[3]);
                i--;
            }
            //Array Niveles 4
            i = ArrayNiveles4.Count;
            if (i > 0)
            {
                _row.IdNomenclatura4a = Convert.ToString(ArrayNiveles4[0]);
                i--;
            }
            if (i > 0)
            {
                _row.IdNomenclatura4b = Convert.ToString(ArrayNiveles4[1]);
                i--;
            }
            if (i > 0)
            {
                _row.IdNomenclatura4c = Convert.ToString(ArrayNiveles4[2]);
                i--;
            }
            if (i > 0)
            {
                _row.IdNomenclatura4d = Convert.ToString(ArrayNiveles4[3]);
                i--;
            }

            //Array Niveles 5
            i = ArrayNiveles5.Count;
            if (i > 0)
            {
                _row.IdNomenclatura5a = Convert.ToString(ArrayNiveles5[0]);
                i--;
            }
            if (i > 0)
            {
                _row.IdNomenclatura5b = Convert.ToString(ArrayNiveles5[1]);
                i--;
            }
            if (i > 0)
            {
                _row.IdNomenclatura5c = Convert.ToString(ArrayNiveles5[2]);
                i--;
            }
            if (i > 0)
            {
                _row.IdNomenclatura5d = Convert.ToString(ArrayNiveles5[3]);
                i--;
            }
            //Array Niveles 6
            i = ArrayNiveles6.Count;
            if (i > 0)
            {
                _row.IdNomenclatura6a = Convert.ToString(ArrayNiveles6[0]);
                i--;
            }
            if (i > 0)
            {
                _row.IdNomenclatura6b = Convert.ToString(ArrayNiveles6[1]);
                i--;
            }
            if (i > 0)
            {
                _row.IdNomenclatura6c = Convert.ToString(ArrayNiveles6[2]);
                i--;
            }
            if (i > 0)
            {
                _row.IdNomenclatura6d = Convert.ToString(ArrayNiveles6[3]);
                i--;
            }
            //Array Niveles 7
            i = ArrayNiveles7.Count;
            if (i > 0)
            {
                _row.IdNomenclatura7a = Convert.ToString(ArrayNiveles7[0]);
                i--;
            }
            if (i > 0)
            {
                _row.IdNomenclatura7b = Convert.ToString(ArrayNiveles7[1]);
                i--;
            }
            if (i > 0)
            {
                _row.IdNomenclatura7c = Convert.ToString(ArrayNiveles7[2]);
                i--;
            }
            if (i > 0)
            {
                _row.IdNomenclatura7d = Convert.ToString(ArrayNiveles7[3]);
                i--;
            }
            //Array Niveles 8
            i = ArrayNiveles8.Count;
            if (i > 0)
            {
                _row.IdNomenclatura8a = Convert.ToString(ArrayNiveles8[0]);
                i--;
            }
            if (i > 0)
            {
                _row.IdNomenclatura8b = Convert.ToString(ArrayNiveles8[1]);
                i--;
            }
            if (i > 0)
            {
                _row.IdNomenclatura8c = Convert.ToString(ArrayNiveles8[2]);
                i--;
            }
            if (i > 0)
            {
                _row.IdNomenclatura8d = Convert.ToString(ArrayNiveles8[3]);
                i--;
            }
            return _row;

        }

        private void commitJerarquiasProducto(Producto producto)
        {

            tsh_ProductosJerarquiasDataset.tsh_ProductosJerarquiasRow rowJEx = tsh_ProductosJerarquias.GetByPk(producto.IdProducto);
            if (rowJEx == null) // No hay ninguna jerarquia cargada
            {
                tsh_ProductosExDataset.tsh_ProductosJerarquiasRow _row = this._dataProductosNuevos.tsh_ProductosJerarquias.Newtsh_ProductosJerarquiasRow();
                _row.IdProducto = producto.IdProducto;
                _row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
                _row.IdConexionCreacion = Security.IdConexion;
                _row.IdConexionUltimaModificacion = Security.IdConexion;
                _row.IdReservado = 0;
                _row.RowId = Guid.Empty;
                _row.IdEmpresa = Security.IdEmpresa;
                _row.IdSucursal = Security.IdSucursal;
                if (ModificaJerarquia1)
                {
                    _row.IdNomenclatura1a = producto.Jerarquias.IdNomenclatura1a;
                    _row.IdNomenclatura1b = producto.Jerarquias.IdNomenclatura1b;
                    string Jerarquia1 = tsh_JerarquiaAgrupProd.GetJerarquiaByIdNomenclatura(producto.Jerarquias.IdNomenclatura1b);
                    this.AddTsh_AgrupProductos(Jerarquia1, producto.IdProducto);
                }
                if (ModificaJerarquia2)
                {
                    _row.IdNomenclatura2a = producto.Jerarquias.IdNomenclatura2a;
                    _row.IdNomenclatura2b = producto.Jerarquias.IdNomenclatura2b;
                    string Jerarquia2 = tsh_JerarquiaAgrupProd.GetJerarquiaByIdNomenclatura(producto.Jerarquias.IdNomenclatura2b);
                    this.AddTsh_AgrupProductos(Jerarquia2, producto.IdProducto);
                }
                if (ModificaJerarquia3)
                {
                    _row.IdNomenclatura3a = producto.Jerarquias.IdNomenclatura3a;
                    _row.IdNomenclatura3b = producto.Jerarquias.IdNomenclatura3b;
                    string Jerarquia3 = tsh_JerarquiaAgrupProd.GetJerarquiaByIdNomenclatura(producto.Jerarquias.IdNomenclatura3b);
                    this.AddTsh_AgrupProductos(Jerarquia3, producto.IdProducto);
                }
                if (ModificaJerarquia4)
                {
                    _row.IdNomenclatura4a = producto.Jerarquias.IdNomenclatura4a;
                    _row.IdNomenclatura4b = producto.Jerarquias.IdNomenclatura4b;
                    string Jerarquia4 = tsh_JerarquiaAgrupProd.GetJerarquiaByIdNomenclatura(producto.Jerarquias.IdNomenclatura4b);
                    this.AddTsh_AgrupProductos(Jerarquia4, producto.IdProducto);
                }
                if (ModificaJerarquia5)
                {
                    _row.IdNomenclatura5a = producto.Jerarquias.IdNomenclatura5a;
                    _row.IdNomenclatura5b = producto.Jerarquias.IdNomenclatura5b;
                    string Jerarquia5 = tsh_JerarquiaAgrupProd.GetJerarquiaByIdNomenclatura(producto.Jerarquias.IdNomenclatura5b);
                    this.AddTsh_AgrupProductos(Jerarquia5, producto.IdProducto);
                }
                if (ModificaJerarquia6)
                {
                    _row.IdNomenclatura6a = producto.Jerarquias.IdNomenclatura6a;
                    _row.IdNomenclatura6b = producto.Jerarquias.IdNomenclatura6b;
                    string Jerarquia6 = tsh_JerarquiaAgrupProd.GetJerarquiaByIdNomenclatura(producto.Jerarquias.IdNomenclatura6b);
                    this.AddTsh_AgrupProductos(Jerarquia6, producto.IdProducto);
                }
                if (ModificaJerarquia7)
                {
                    _row.IdNomenclatura7a = producto.Jerarquias.IdNomenclatura7a;
                    _row.IdNomenclatura7b = producto.Jerarquias.IdNomenclatura7b;
                    string Jerarquia7 = tsh_JerarquiaAgrupProd.GetJerarquiaByIdNomenclatura(producto.Jerarquias.IdNomenclatura7b);
                    this.AddTsh_AgrupProductos(Jerarquia7, producto.IdProducto);
                }
                if (ModificaJerarquia8)
                {
                    _row.IdNomenclatura8a = producto.Jerarquias.IdNomenclatura8a;
                    _row.IdNomenclatura8b = producto.Jerarquias.IdNomenclatura8b;
                    string Jerarquia8 = tsh_JerarquiaAgrupProd.GetJerarquiaByIdNomenclatura(producto.Jerarquias.IdNomenclatura8b);
                    this.AddTsh_AgrupProductos(Jerarquia8, producto.IdProducto);
                }
                _dataProductosNuevos.tsh_ProductosJerarquias.Addtsh_ProductosJerarquiasRow(_row);
            }
            else
            {
                ArrayList jerarquiasProducto = new ArrayList();
                if (ModificaJerarquia1)
                {
                    rowJEx.IdNomenclatura1a = producto.Jerarquias.IdNomenclatura1a;
                    rowJEx.IdNomenclatura1b = producto.Jerarquias.IdNomenclatura1b;
                }
                if (ModificaJerarquia2)
                {
                    rowJEx.IdNomenclatura2a = producto.Jerarquias.IdNomenclatura2a;
                    rowJEx.IdNomenclatura2b = producto.Jerarquias.IdNomenclatura2b;
                }
                if (ModificaJerarquia3)
                {
                    rowJEx.IdNomenclatura3a = producto.Jerarquias.IdNomenclatura3a;
                    rowJEx.IdNomenclatura3b = producto.Jerarquias.IdNomenclatura3b;
                }
                if (ModificaJerarquia4)
                {
                    rowJEx.IdNomenclatura4a = producto.Jerarquias.IdNomenclatura4a;
                    rowJEx.IdNomenclatura4b = producto.Jerarquias.IdNomenclatura4b;
                }
                if (ModificaJerarquia5)
                {
                    rowJEx.IdNomenclatura5a = producto.Jerarquias.IdNomenclatura5a;
                    rowJEx.IdNomenclatura5b = producto.Jerarquias.IdNomenclatura5b;
                }
                if (ModificaJerarquia6)
                {
                    rowJEx.IdNomenclatura6a = producto.Jerarquias.IdNomenclatura6a;
                    rowJEx.IdNomenclatura6b = producto.Jerarquias.IdNomenclatura6b;
                }
                if (ModificaJerarquia7)
                {
                    rowJEx.IdNomenclatura7a = producto.Jerarquias.IdNomenclatura7a;
                    rowJEx.IdNomenclatura7b = producto.Jerarquias.IdNomenclatura7b;
                }
                if (ModificaJerarquia8)
                {
                    rowJEx.IdNomenclatura8a = producto.Jerarquias.IdNomenclatura8a;
                    rowJEx.IdNomenclatura8b = producto.Jerarquias.IdNomenclatura8b;
                }
                _dataProductosNuevos.tsh_ProductosJerarquias.ImportRow(rowJEx);

                //borro todas las filas de tsh_AgrupProductos
                tsh_AgrupProductosExDataset dataAgrup = tsh_AgrupProductos.GetList(producto.IdProducto);
                foreach (DataRow rowJ in dataAgrup.tsh_AgrupProductos.Rows)
                {
                    rowJ.Delete();
                    _dataProductosNuevos.tsh_AgrupProductos.ImportRow(rowJ);
                }

                //Vuelvo a insertar en tsh_AgrupProductos con las modificaciones
                if ((rowJEx.IdNomenclatura1b != null) && (!rowJEx.IdNomenclatura1b.Equals(string.Empty)))
                {
                    string Jerarquia1 = tsh_JerarquiaAgrupProd.GetJerarquiaByIdNomenclatura(rowJEx.IdNomenclatura1b);
                    if (!Jerarquia1.Equals(string.Empty))
                        jerarquiasProducto.Add(Jerarquia1);
                }

                if ((rowJEx.IdNomenclatura2b != null) && (!rowJEx.IdNomenclatura2b.Equals(string.Empty)))
                {
                    string Jerarquia2 = tsh_JerarquiaAgrupProd.GetJerarquiaByIdNomenclatura(rowJEx.IdNomenclatura2b);
                    if (!Jerarquia2.Equals(string.Empty))
                        jerarquiasProducto.Add(Jerarquia2);
                }

                if ((rowJEx.IdNomenclatura3b != null) && (!rowJEx.IdNomenclatura3b.Equals(string.Empty)))
                {
                    string Jerarquia3 = tsh_JerarquiaAgrupProd.GetJerarquiaByIdNomenclatura(rowJEx.IdNomenclatura3b);
                    if (!Jerarquia3.Equals(string.Empty))
                        jerarquiasProducto.Add(Jerarquia3);
                }

                if ((rowJEx.IdNomenclatura4b != null) && (!rowJEx.IdNomenclatura4b.Equals(string.Empty)))
                {
                    string Jerarquia4 = tsh_JerarquiaAgrupProd.GetJerarquiaByIdNomenclatura(rowJEx.IdNomenclatura4b);
                    if (!Jerarquia4.Equals(string.Empty))
                        jerarquiasProducto.Add(Jerarquia4);
                }

                if ((rowJEx.IdNomenclatura5b != null) && (!rowJEx.IdNomenclatura5b.Equals(string.Empty)))
                {
                    string Jerarquia5 = tsh_JerarquiaAgrupProd.GetJerarquiaByIdNomenclatura(rowJEx.IdNomenclatura5b);
                    if (!Jerarquia5.Equals(string.Empty))
                        jerarquiasProducto.Add(Jerarquia5);
                }

                if ((rowJEx.IdNomenclatura6b != null) && (!rowJEx.IdNomenclatura6b.Equals(string.Empty)))
                {
                    string Jerarquia6 = tsh_JerarquiaAgrupProd.GetJerarquiaByIdNomenclatura(rowJEx.IdNomenclatura6b);
                    if (!Jerarquia6.Equals(string.Empty))
                        jerarquiasProducto.Add(Jerarquia6);
                }

                if ((rowJEx.IdNomenclatura7b != null) && (!rowJEx.IdNomenclatura7b.Equals(string.Empty)))
                {
                    string Jerarquia7 = tsh_JerarquiaAgrupProd.GetJerarquiaByIdNomenclatura(rowJEx.IdNomenclatura7b);
                    if (!Jerarquia7.Equals(string.Empty))
                        jerarquiasProducto.Add(Jerarquia7);
                }

                if ((rowJEx.IdNomenclatura8b != null) && (!rowJEx.IdNomenclatura8b.Equals(string.Empty)))
                {
                    string Jerarquia8 = tsh_JerarquiaAgrupProd.GetJerarquiaByIdNomenclatura(rowJEx.IdNomenclatura8b);
                    if (!Jerarquia8.Equals(string.Empty))
                        jerarquiasProducto.Add(Jerarquia8);
                }
                foreach (string Jerarquia in jerarquiasProducto)
                    this.AddTsh_AgrupProductos(Jerarquia, producto.IdProducto);
            }

        }

        private ArrayList ObtenerImpuestosDirectosAAgregar(string keyImpuestoSeleccionado)
        {
            ArrayList dependientes = GetImpuestosDependientes(keyImpuestoSeleccionado);
            ArrayList impuestosDirectosAAgregar = new ArrayList();
            impuestosDirectosAAgregar.Add(keyImpuestoSeleccionado);
            impuestosDirectosAAgregar.AddRange(dependientes);
            return impuestosDirectosAAgregar;
        }

        private string ImpuestoSeleccionado()
        {
            string keyImpuestoSeleccionado = string.Empty;
            if (IVA)
                keyImpuestoSeleccionado = "IVA";
            else if (IVADIF)
                keyImpuestoSeleccionado = "IVADIF";
            else if (EX)
                keyImpuestoSeleccionado = "EX";
            return keyImpuestoSeleccionado;
        }

        private void ObtenerImpuestosDirectosAAgregar()
        {
            string keyImpuestoSeleccionado = string.Empty;
            if (IVA)
                keyImpuestoSeleccionado = "IVA";
            else if (IVADIF)
                keyImpuestoSeleccionado = "IVADIF";
            else if (EX)
                keyImpuestoSeleccionado = "EX";
            ArrayList dependientes = GetImpuestosDependientes(keyImpuestoSeleccionado);
            _impuestosDirectosAAgregar = new ArrayList();
            _impuestosDirectosAAgregar.Add(keyImpuestoSeleccionado);
            _impuestosDirectosAAgregar.AddRange(dependientes);
        }

        private static ArrayList GetImpuestosDependientes(string Impuesto)
        {
            ArrayList aux = new ArrayList();
            long index = 0;
            foreach (ArrayList deps in dependenciasImpuestos)
            {
                string imp1 = Convert.ToString(deps[0]);
                string imp2 = Convert.ToString(deps[1]);
                if (imp1.Equals(Impuesto))
                {
                    aux.Add(imp2);
                }
                else
                    if (imp2.Equals(Impuesto))
                    {
                        aux.Add(imp1);
                    }
            }
            return aux;

        }

        private void recalcularBonificaciones(ListaDePreciosProveedoresItem item)
        {
            item.Bonificacion1 = Decimal.Round((item.PrecioDeCosto * item.PorcentajeBonificacion1) / 100, 4);
            if (item.BonificacionAcumulativa)
            {
                decimal precioInt = item.PrecioDeCosto + item.Bonificacion1;
                item.Bonificacion2 = Decimal.Round((precioInt * item.PorcentajeBonificacion2) / 100, 4);
                precioInt += item.Bonificacion2;
                item.Bonificacion3 = Decimal.Round((precioInt * item.PorcentajeBonificacion3) / 100, 4);
                precioInt += item.Bonificacion3;
                item.Bonificacion4 = Decimal.Round((precioInt * item.PorcentajeBonificacion4) / 100, 4);
                precioInt += item.Bonificacion4;
                item.Bonificacion5 = Decimal.Round((precioInt * item.PorcentajeBonificacion5) / 100, 4);
            }
            else
            {
                item.Bonificacion2 = Decimal.Round((item.PrecioDeCosto * item.PorcentajeBonificacion2) / 100, 4);
                item.Bonificacion3 = Decimal.Round((item.PrecioDeCosto * item.PorcentajeBonificacion3) / 100, 4);
                item.Bonificacion4 = Decimal.Round((item.PrecioDeCosto * item.PorcentajeBonificacion4) / 100, 4);
                item.Bonificacion5 = Decimal.Round((item.PrecioDeCosto * item.PorcentajeBonificacion5) / 100, 4);
            }
        }

        //Sabrina 20100615 - Tarea 764
        private void SetarPrecioDeCostoMonedaProducto(Producto producto, ListaDePreciosProveedoresItem item)
        {
            producto.PrecioDeCostoMonedaProducto = item.PrecioDeCostoFinal * item.ValorCotizacionProveedor / producto.ValorCotizacionPrecioDeCosto;
            producto.ListaDePrecios.UpdatePrecios(producto.PrecioDeCosto, producto.MAC, producto.PrecioDeVentaNeto);
            ListaDePreciosItem itemDefault = producto.ListaDePrecios.GetDefaultItem();
            producto.PrecioLista = itemDefault.PrecioDeVentaBruto;
        }
        //Fin Sabrina 20100615 - Tarea 764

        //German 20120202 - Tarea 0000273
        private void SetearDatosListaDePreciosVentasFromExcelRow(Producto producto, DataRow row)
        {
            foreach (ListaDePreciosItem it in producto.ListaDePrecios.Items)
            {
                if (_listasDePreciosSeleccionadas2.Contains(new ListaDePreciosView(it.IdListaDePrecios, it.Descripcion)))
                {
                    if (_precioDeVentaTieneImpuestos)
                    {
                        //Esta logica se saco de propiedad PrecioDeListaConImpuestoLPItem de IngresarPrecioProducto
                        decimal precioFinal = Convert.ToDecimal(row["PrecioDeVentaLista" + Convert.ToString(Convert.ToInt32(it.IdListaDePrecios) + 1)]);
                        if (it.IsDefault)
                            producto.PrecioDeListaConImpuestos = precioFinal;
                        decimal coeficienteNew = it.GetCoeficienteFromPrecioVentaBrutoConImp(precioFinal);
                        if (coeficienteNew != it.CoeficienteProducto)
                        {
                            producto.ListaDePrecios.UpdateCoeficiente(producto.IdProducto, it.IdListaDePrecios, coeficienteNew);
                            if (it.IsDefault)
                                producto.PrecioLista = it.PrecioDeVentaBruto;
                            
                        }
                    }
                    else
                    {
                         //Esta logica se saco de propiedad PrecioVentaBrutoLPItem de IngresarPrecioProducto
                        decimal precioLista = Convert.ToDecimal(row["PrecioDeVentaLista" + Convert.ToString(Convert.ToInt32(it.IdListaDePrecios) + 1)]);
                        if (it.IsDefault)
                            producto.PrecioLista = precioLista;
                        decimal coeficienteNew = it.GetCoeficienteFromPrecioVentaBruto(precioLista);
                        if (coeficienteNew != it.CoeficienteProducto)
                        {
                            producto.ListaDePrecios.UpdateCoeficiente(producto.IdProducto, it.IdListaDePrecios, coeficienteNew);
                            if (it.IsDefault)
                                producto.PrecioLista = it.PrecioDeVentaBruto;
                        }
                    }
                    if (!producto.Estado.Equals("NEW"))
                        producto.Estado = "MODIF";
                }
            }
            
        }
        //German 20120202 - Tarea 0000273

        private void SetearDatosListaDePreciosProveedoresItemExcelFromExcelRow(Producto producto, ListaDePreciosProveedoresItem item, DataRow row)
        {
            item.PrecioDeCostoFinalChanged -= new EventHandler(item_PrecioDeCostoFinalChanged);
            if (item.IdProveedor.Equals(producto.IdProveedorDefault))
            {
                _productoSeleccionado = producto;
                _itemSeleccionado = item;
                item.PrecioDeCostoFinalChanged += new EventHandler(item_PrecioDeCostoFinalChanged);
            }
            if (ModificaPrecioDeCosto)
            {
                item.PrecioDeCosto = Decimal.Round(Convert.ToDecimal(row["PrecioDeCosto"]), 4);
                recalcularBonificaciones(item);
                item.PrecioDeCostoFinal = Decimal.Round(item.PrecioDeCosto + item.Bonificacion1 + item.Bonificacion2 + item.Bonificacion3 + item.Bonificacion4 + item.Bonificacion5, 4);
                if (item.IdProveedor.Equals(producto.IdProveedorDefault))
                {
                    //Sabrina 20100615 - Tarea 764
                    this.SetarPrecioDeCostoMonedaProducto(producto, item);
                    //producto.PrecioDeCostoMonedaProducto = item.PrecioDeCostoFinal * item.ValorCotizacionProveedor / producto.ValorCotizacionPrecioDeCosto;
                    //Fin Sabrina 20100615 - Tarea 764
                    if (!producto.Estado.Equals("NEW"))
                        producto.Estado = "MODIF";
                    //German 20120202 - Tarea 0000273
                    /*
                    if (_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
                        producto.PrecioLista = producto.PrecioDeVentaNeto;
                     */
                    //Fin German 20120202 - Tarea 0000273
                }

            }
            if (ModificaBonificaciones)
            {
                item.PorcentajeBonificacion1 = Decimal.Round(Convert.ToDecimal(row["Coeficiente1"]), 4);
                if (item.IdProveedor.Equals(producto.IdProveedorDefault))
                {
                    //Sabrina 20100615 - Tarea 764
                    this.SetarPrecioDeCostoMonedaProducto(producto, item);
                    //producto.PrecioDeCostoMonedaProducto = item.PrecioDeCostoFinal * item.ValorCotizacionProveedor / producto.ValorCotizacionPrecioDeCosto;
                    //Fin Sabrina 20100615 - Tarea 764
                    if (!producto.Estado.Equals("NEW"))
                        producto.Estado = "MODIF";
                    //German 20120202 - Tarea 0000273
                    /*
                    if (_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
                        producto.PrecioLista = producto.PrecioDeVentaNeto;
                     */
                    //Fin German 20120202 - Tarea 0000273
                }

                item.PorcentajeBonificacion2 = Decimal.Round(Convert.ToDecimal(row["Coeficiente2"]), 4);
                if (item.BonificacionAcumulativa)
                {
                    decimal precioInt = item.PrecioDeCosto + item.Bonificacion1;
                    item.Bonificacion2 = Decimal.Round((Convert.ToDecimal(row["Coeficiente2"]) * precioInt) / 100, 4);
                }
                else
                    item.Bonificacion2 = Decimal.Round((Convert.ToDecimal(row["Coeficiente2"]) * item.PrecioDeCosto) / 100, 4);
                if (item.IdProveedor.Equals(producto.IdProveedorDefault))
                {
                    //Sabrina 20100615 - Tarea 764
                    this.SetarPrecioDeCostoMonedaProducto(producto, item);
                    //producto.PrecioDeCostoMonedaProducto = item.PrecioDeCostoFinal * item.ValorCotizacionProveedor / producto.ValorCotizacionPrecioDeCosto;
                    //Fin Sabrina 20100615 - Tarea 764
                    if (!producto.Estado.Equals("NEW"))
                        producto.Estado = "MODIF";
                    //German 20120202 - Tarea 0000273
                    /*
                    if (_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
                        producto.PrecioLista = producto.PrecioDeVentaNeto;
                     */
                    //Fin German 20120202 - Tarea 0000273
                }

                item.PorcentajeBonificacion3 = Decimal.Round(Convert.ToDecimal(row["Coeficiente3"]), 4);
                if (item.BonificacionAcumulativa)
                {
                    decimal precioInt = item.PrecioDeCosto + item.Bonificacion1 + item.Bonificacion2;
                    item.Bonificacion3 = Decimal.Round((Convert.ToDecimal(row["Coeficiente3"]) * precioInt) / 100, 4);
                }
                else
                    item.Bonificacion3 = Decimal.Round((Convert.ToDecimal(row["Coeficiente3"]) * item.PrecioDeCosto) / 100, 4);
                if (item.IdProveedor.Equals(producto.IdProveedorDefault))
                {
                    //Sabrina 20100615 - Tarea 764
                    this.SetarPrecioDeCostoMonedaProducto(producto, item);
                    //producto.PrecioDeCostoMonedaProducto = item.PrecioDeCostoFinal * item.ValorCotizacionProveedor / producto.ValorCotizacionPrecioDeCosto;
                    //Fin Sabrina 20100615 - Tarea 764
                    if (!producto.Estado.Equals("NEW"))
                        producto.Estado = "MODIF";
                    //German 20120202 - Tarea 0000273
                    /*
                    if (_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
                        producto.PrecioLista = producto.PrecioDeVentaNeto;
                     */
                    //Fin German 20120202 - Tarea 0000273
                }

                item.PorcentajeBonificacion4 = Decimal.Round(Convert.ToDecimal(row["Coeficiente4"]), 4);
                if (item.BonificacionAcumulativa)
                {
                    decimal precioInt = item.PrecioDeCosto + item.Bonificacion1 + item.Bonificacion2 + item.Bonificacion3;
                    item.Bonificacion4 = Decimal.Round((Convert.ToDecimal(row["Coeficiente4"]) * precioInt) / 100, 4);
                }
                else
                    item.Bonificacion4 = Decimal.Round((Convert.ToDecimal(row["Coeficiente4"]) * item.PrecioDeCosto) / 100, 4);
                if (item.IdProveedor.Equals(producto.IdProveedorDefault))
                {
                    //Sabrina 20100615 - Tarea 764
                    this.SetarPrecioDeCostoMonedaProducto(producto, item);
                    //producto.PrecioDeCostoMonedaProducto = item.PrecioDeCostoFinal * item.ValorCotizacionProveedor / producto.ValorCotizacionPrecioDeCosto;
                    //Fin Sabrina 20100615 - Tarea 764
                    if (!producto.Estado.Equals("NEW"))
                        producto.Estado = "MODIF";
                    //German 20120202 - Tarea 0000273
                    /*
                    if (_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
                        producto.PrecioLista = producto.PrecioDeVentaNeto;
                     */
                    //Fin German 20120202 - Tarea 0000273
                }

                item.PorcentajeBonificacion5 = Decimal.Round(Convert.ToDecimal(row["Coeficiente5"]), 4);
                if (item.BonificacionAcumulativa)
                {
                    decimal precioInt = item.PrecioDeCosto + item.Bonificacion1 + item.Bonificacion2 + item.Bonificacion3 + item.Bonificacion4;
                    item.Bonificacion5 = Decimal.Round((Convert.ToDecimal(row["Coeficiente5"]) * precioInt) / 100, 4);
                }
                else
                    item.Bonificacion5 = Decimal.Round((Convert.ToDecimal(row["Coeficiente5"]) * item.PrecioDeCosto) / 100, 4);
                if (item.IdProveedor.Equals(producto.IdProveedorDefault))
                {
                    //Sabrina 20100615 - Tarea 764
                    this.SetarPrecioDeCostoMonedaProducto(producto, item);
                    //producto.PrecioDeCostoMonedaProducto = item.PrecioDeCostoFinal * item.ValorCotizacionProveedor / producto.ValorCotizacionPrecioDeCosto;
                    //Fin Sabrina 20100615 - Tarea 764
                    if (!producto.Estado.Equals("NEW"))
                        producto.Estado = "MODIF";
                    //German 20120202 - Tarea 0000273
                    /*
                    if (_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
                        producto.PrecioLista = producto.PrecioDeVentaNeto;
                     */
                    //Fin German 20120202 - Tarea 0000273
                }

            }

            /*if(row["Coeficiente2"] != System.DBNull.Value && row["Coeficiente2"].ToString() != string.Empty)
            {
                item.PorcentajeBonificacion2 = Decimal.Round(Convert.ToDecimal(row["Coeficiente2"]),4);
                if(item.BonificacionAcumulativa)
                {
                    decimal precioInt = item.PrecioDeCosto + item.Bonificacion1;
                    item.Bonificacion2 = Decimal.Round((Convert.ToDecimal(row["Coeficiente2"]) * precioInt) / 100,4);
                }
                else
                    item.Bonificacion2 = Decimal.Round((Convert.ToDecimal(row["Coeficiente2"]) * item.PrecioDeCosto) / 100,4);
                if(item.IdProveedor.Equals(producto.IdProveedorDefault))
                {
                    producto.PrecioDeCostoMonedaProducto = item.PrecioDeCostoFinal * item.ValorCotizacionProveedor / producto.ValorCotizacionPrecioDeCosto;
                    if(!producto.Estado.Equals("NEW"))
                        producto.Estado = "MODIF";
                    if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
                        producto.PrecioLista = producto.PrecioDeVentaNeto;
                }
            }
            if(row["Coeficiente3"] != System.DBNull.Value && row["Coeficiente3"].ToString() != string.Empty)
            {
                item.PorcentajeBonificacion3 = Decimal.Round(Convert.ToDecimal(row["Coeficiente3"]),4);
                if(item.BonificacionAcumulativa)
                {
                    decimal precioInt = item.PrecioDeCosto + item.Bonificacion1 + item.Bonificacion2;
                    item.Bonificacion3 = Decimal.Round((Convert.ToDecimal(row["Coeficiente3"]) * precioInt) / 100,4);
                }
                else
                    item.Bonificacion3 = Decimal.Round((Convert.ToDecimal(row["Coeficiente3"]) * item.PrecioDeCosto) / 100,4);
                if(item.IdProveedor.Equals(producto.IdProveedorDefault))
                {
                    producto.PrecioDeCostoMonedaProducto = item.PrecioDeCostoFinal * item.ValorCotizacionProveedor / producto.ValorCotizacionPrecioDeCosto;
                    if(!producto.Estado.Equals("NEW"))
                        producto.Estado = "MODIF";
                    if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
                        producto.PrecioLista = producto.PrecioDeVentaNeto;
                }
            }
            if(row["Coeficiente4"] != System.DBNull.Value && row["Coeficiente4"].ToString() != string.Empty)
            {
                item.PorcentajeBonificacion4 = Decimal.Round(Convert.ToDecimal(row["Coeficiente4"]),4);
                if(item.BonificacionAcumulativa)
                {
                    decimal precioInt = item.PrecioDeCosto + item.Bonificacion1 + item.Bonificacion2 + item.Bonificacion3;
                    item.Bonificacion4 = Decimal.Round((Convert.ToDecimal(row["Coeficiente4"]) * precioInt) / 100,4);
                }
                else
                    item.Bonificacion4 = Decimal.Round((Convert.ToDecimal(row["Coeficiente4"]) * item.PrecioDeCosto) / 100,4);
                if(item.IdProveedor.Equals(producto.IdProveedorDefault))
                {
                    producto.PrecioDeCostoMonedaProducto = item.PrecioDeCostoFinal * item.ValorCotizacionProveedor / producto.ValorCotizacionPrecioDeCosto;
                    if(!producto.Estado.Equals("NEW"))
                        producto.Estado = "MODIF";
                    if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
                        producto.PrecioLista = producto.PrecioDeVentaNeto;
                }
            }
            if(row["Coeficiente5"] != System.DBNull.Value && row["Coeficiente5"].ToString() != string.Empty)
            {
                item.PorcentajeBonificacion5 = Decimal.Round(Convert.ToDecimal(row["Coeficiente5"]),4);
                if(item.BonificacionAcumulativa)
                {
                    decimal precioInt = item.PrecioDeCosto + item.Bonificacion1 + item.Bonificacion2 + item.Bonificacion3 + item.Bonificacion4;
                    item.Bonificacion5 = Decimal.Round((Convert.ToDecimal(row["Coeficiente5"]) * precioInt) / 100,4);
                }
                else
                    item.Bonificacion5 = Decimal.Round((Convert.ToDecimal(row["Coeficiente5"]) * item.PrecioDeCosto) / 100,4);
                if(item.IdProveedor.Equals(producto.IdProveedorDefault))
                {
                    producto.PrecioDeCostoMonedaProducto = item.PrecioDeCostoFinal * item.ValorCotizacionProveedor / producto.ValorCotizacionPrecioDeCosto;
                    if(!producto.Estado.Equals("NEW"))
                        producto.Estado = "MODIF";
                    if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
                        producto.PrecioLista = producto.PrecioDeVentaNeto;
                }
            }*/
        }


        private void SetearPrecioDeVentaFromExcelRow(Producto producto, DataRow row)
        {
            //Si ingreso precio de venta
            if ((row["PrecioDeVenta"] != System.DBNull.Value && row["PrecioDeVenta"].ToString() != string.Empty))
            {
                decimal precioDeVta = Decimal.Round(Convert.ToDecimal(row["PrecioDeVenta"]), 4);
                if (PcioDeVtaContieneImpuestos)
                {
                    if (!producto.Estado.Equals("NEW"))
                    {
                        producto.PrecioDeListaConImpuestos = precioDeVta;
                        producto.Estado = "MODIF";
                    }
                    else
                    {
                        string IVA = (string)_impuestosDirectosAAgregarPorProducto[producto.Codigo];
                        tsy_ImpuestosDataset.tsy_ImpuestosRow rowI = tsy_Impuestos.GetByImpuesto(IVA);
                        decimal Alicuota = rowI.Alicuota1;
                        producto.SetPrecioDeListaConImpuestos(precioDeVta, Alicuota);
                    }
                }
                else
                {
                    producto.PrecioLista = precioDeVta;
                    if (!producto.Estado.Equals("NEW"))
                        producto.Estado = "MODIF";
                }
            }
        }


        private void commitProveedoresProductos(Producto prod)
        {
            if (prod.ListaDePreciosProveedores.Items.Count > 0)
            {
                foreach (ListaDePreciosProveedoresItem item in prod.ListaDePreciosProveedores.Items)
                {
                    switch (item.Estado)
                    {
                        case "NEW": //Nueva lista de precios proveedores para el producto
                            {
                                DataRow _rowP = _dataProductosNuevos.tsh_Productos.FindByIdProducto(prod.IdProducto);
                                if (_rowP == null)
                                {
                                    _rowP = mz.erp.businessrules.tsh_Productos.GetByPk(prod.IdProducto);
                                    _dataProductosNuevos.tsh_Productos.ImportRow(_rowP);
                                }
                                tsh_ProductosExDataset.tpu_ProveedoresProductosRow rowPP = _dataProductosNuevos.tpu_ProveedoresProductos.Newtpu_ProveedoresProductosRow();
                                mz.erp.businessrules.tpu_ProveedoresProductos.SetRowDefaultValues(rowPP);
                                rowPP.IdProducto = prod.IdProducto;
                                rowPP.IdProveedor = item.IdProveedor;
                                rowPP.PrecioDeCosto = item.PrecioDeCosto;
                                rowPP.IdMonedaPrecioDeCosto = item.IdMonedaPrecioDeCosto;
                                rowPP.IdCotizacionPrecioDeCosto = item.IdCotizacionPrecioDeCosto;
                                rowPP.IdFuenteDeCambio = item.IdFuenteDeCambio;
                                rowPP.PrecioDeCostoFinal = item.PrecioDeCostoFinal;
                                rowPP.FechaUltimaModificacionPrecioDeCosto = mz.erp.businessrules.Sistema.DateTime.Now;
                                rowPP.PrecioDeCostoUltimaCompra = 0;
                                rowPP.BonificacionAcumulativa = item.BonificacionAcumulativa;
                                rowPP.Bonificacion1 = item.Bonificacion1;
                                rowPP.Bonificacion2 = item.Bonificacion2;
                                rowPP.Bonificacion3 = item.Bonificacion3;
                                rowPP.Bonificacion4 = item.Bonificacion4;
                                rowPP.Bonificacion5 = item.Bonificacion5;
                                rowPP.FechaCreacion = DateTime.Now;
                                rowPP.IdConexionCreacion = Security.IdConexion;
                                rowPP.IdConexionUltimaModificacion = Security.IdConexion;
                                rowPP.IdReservado = 0;
                                rowPP.RowId = Guid.Empty;
                                rowPP.IdSucursal = Security.IdSucursal;
                                rowPP.IdEmpresa = Security.IdEmpresa;
                                rowPP.PorcentajeBonificacion1 = item.PorcentajeBonificacion1;
                                rowPP.PorcentajeBonificacion2 = item.PorcentajeBonificacion2;
                                rowPP.PorcentajeBonificacion3 = item.PorcentajeBonificacion3;
                                rowPP.PorcentajeBonificacion4 = item.PorcentajeBonificacion4;
                                rowPP.PorcentajeBonificacion5 = item.PorcentajeBonificacion5;
                                rowPP.IdCotizacionProveedor = item.IdCotizacionProveedor;
                                rowPP.IdFuenteDeCambioProveedor = item.IdFuenteDeCambioProveedor;
                                rowPP.IdMonedaProveedor = item.IdMonedaProveedor;
                                rowPP.ValorCotizacionProveedor = item.ValorCotizacionProveedor;
                                _dataProductosNuevos.tpu_ProveedoresProductos.Addtpu_ProveedoresProductosRow(rowPP);

                                //Sabrina: Tarea 1113. 20110808
                                //Agrego en tpu_ProveedoresProductosAuxiliares
                                tsh_ProductosExDataset.tpu_ProveedoresProductosAuxiliaresRow rowPPA = _dataProductosNuevos.tpu_ProveedoresProductosAuxiliares.Newtpu_ProveedoresProductosAuxiliaresRow();
                                mz.erp.businessrules.tpu_ProveedoresProductosAuxiliares.SetRowDefaultValues(rowPPA);
                                rowPPA.IdProducto = prod.IdProducto;
                                rowPPA.IdProveedor = item.IdProveedor;
                                rowPPA.CodigoProductoProveedor = item.CodigoProductoProveedor;
                                _dataProductosNuevos.tpu_ProveedoresProductosAuxiliares.Addtpu_ProveedoresProductosAuxiliaresRow(rowPPA);
                                //Fin Sabrina: Tarea 1113. 20110808
                                break;

                            }
                        case "MODIF": //Modificacion de Lista de precios proveedores producto 
                            {
                                DataRow _rowP = _dataProductosNuevos.tsh_Productos.FindByIdProducto(prod.IdProducto);
                                if (_rowP == null)
                                {
                                    _rowP = mz.erp.businessrules.tsh_Productos.GetByPk(prod.IdProducto);
                                    _dataProductosNuevos.tsh_Productos.ImportRow(_rowP);
                                }
                                tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow rowPP = tpu_ProveedoresProductos.GetByPk(item.IdProveedor, item.IdProducto);
                                rowPP.PrecioDeCosto = item.PrecioDeCosto;
                                if (rowPP.PrecioDeCostoFinal != item.PrecioDeCostoFinal)
                                    rowPP.FechaUltimaModificacionPrecioDeCosto = mz.erp.businessrules.Sistema.DateTime.Now;
                                rowPP.PrecioDeCostoFinal = item.PrecioDeCostoFinal;
                                rowPP.BonificacionAcumulativa = item.BonificacionAcumulativa;
                                rowPP.Bonificacion1 = item.Bonificacion1;
                                rowPP.Bonificacion2 = item.Bonificacion2;
                                rowPP.Bonificacion3 = item.Bonificacion3;
                                rowPP.Bonificacion4 = item.Bonificacion4;
                                rowPP.Bonificacion5 = item.Bonificacion5;
                                rowPP.PorcentajeBonificacion1 = item.PorcentajeBonificacion1;
                                rowPP.PorcentajeBonificacion2 = item.PorcentajeBonificacion2;
                                rowPP.PorcentajeBonificacion3 = item.PorcentajeBonificacion3;
                                rowPP.PorcentajeBonificacion4 = item.PorcentajeBonificacion4;
                                rowPP.PorcentajeBonificacion5 = item.PorcentajeBonificacion5;
                                rowPP.IdCotizacionProveedor = item.IdCotizacionProveedor;
                                rowPP.IdFuenteDeCambioProveedor = item.IdFuenteDeCambioProveedor;
                                rowPP.IdMonedaProveedor = item.IdMonedaProveedor;
                                rowPP.ValorCotizacionProveedor = item.ValorCotizacionProveedor;
                                _dataProductosNuevos.tpu_ProveedoresProductos.ImportRow(rowPP);

                                break;
                            }
                    }
                }
            }
        }




        private void AddTsh_AgrupProductos(string Jerarquia, string IdProducto)
        {

            tsh_ProductosExDataset.tsh_AgrupProductosRow row = this._dataProductosNuevos.tsh_AgrupProductos.Newtsh_AgrupProductosRow();
            if (!this._dataProductosNuevos.tsh_AgrupProductos.HasErrors)
            {
                string filtro = String.Format("SUBSTRING(Jerarquia,1,20) = SUBSTRING({0},1,20) and IdProducto = {1}", "'" + Jerarquia + "'", "'" + IdProducto + "'");
                DataView dv = new DataView(_dataProductosNuevos.tsh_AgrupProductos, filtro, "", System.Data.DataViewRowState.CurrentRows);
                bool ok = dv.Count == 0;
                if (!ok)
                {
                    DataRow rowP = _dataProductosNuevos.tsh_Productos.FindByIdProducto(IdProducto);
                    string DescP = Convert.ToString(rowP["Descripcion"]);
                    string J = Convert.ToString(dv[0].Row["Jerarquia"]);
                    string IdNomenclatura = J.Substring(J.Length - 20);
                    DataRow rowJ = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetByPk(IdNomenclatura);
                    string DescJ = string.Empty;
                    string DescJ1 = string.Empty;
                    if (rowJ != null)
                    {
                        DescJ = Convert.ToString(rowJ["Descripcion"]);

                    }
                    IdNomenclatura = Jerarquia.Substring(Jerarquia.Length - 20);
                    rowJ = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetByPk(IdNomenclatura);
                    if (rowJ != null)
                    {
                        DescJ1 = Convert.ToString(rowJ["Descripcion"]);

                    }
                    row.SetColumnError("Jerarquia", "El Artículo " + DescP + " Ya Pertence a la Jerarquía " + DescJ + ". Por ende, no puede pertencer a la Jerarquía " + DescJ1 + ".");



                }
            }



            row.IdProducto = IdProducto;
            row.Jerarquia = Jerarquia;
            row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
            row.IdConexionCreacion = Security.IdConexion;
            row.IdConexionUltimaModificacion = Security.IdConexion;
            row.IdReservado = 0;
            row.RowId = Guid.Empty;
            row.IdEmpresa = Security.IdEmpresa;
            _dataProductosNuevos.tsh_AgrupProductos.Addtsh_AgrupProductosRow(row);

        }

        public decimal PrecioDeCostoReposicion
        {
            get
            {
                if (_productoSeleccionado != null)
                    return _productoSeleccionado.PrecioDeCostoReposicion;
                return 0;
            }
            set
            {
                if (_productoSeleccionado != null)
                {
                    if (value != _productoSeleccionado.PrecioDeCostoReposicion)
                    {
                        _productoSeleccionado.PrecioDeCostoReposicion = value;
                        //German 20120202 - Tarea 0000273
                        _productoSeleccionado.ListaDePrecios.UpdatePrecios(_productoSeleccionado.PrecioDeCosto, _productoSeleccionado.MAC, _productoSeleccionado.PrecioDeVentaNeto);
                        ListaDePreciosItem itemDefault = _productoSeleccionado.ListaDePrecios.GetDefaultItem();
                        _productoSeleccionado.PrecioLista = itemDefault.PrecioDeVentaBruto;
                        //Fin German 20120202 - Tarea 0000273
                        if (!_productoSeleccionado.Estado.Equals("NEW"))
                            _productoSeleccionado.Estado = "MODIF";
                       /* if (_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
                            _productoSeleccionado.PrecioLista = _productoSeleccionado.PrecioDeVentaNeto;
                       */
                    }
                }

            }

        }



        #endregion

        private void item_PrecioDeCostoFinalChanged(object sender, EventArgs e)
        {
            PrecioDeCostoReposicion = (_itemSeleccionado.PrecioDeCostoFinal * _itemSeleccionado.ValorCotizacionProveedor) / _productoSeleccionado.ValorCotizacionPrecioDeCosto;

        }
    }

    public class ProductoExcel
    {
        #region Variables privadas
        private string _idProducto = string.Empty;
        private string _codigo = string.Empty;
        private string _codigoSecundario = string.Empty;
        private string _codigoProveedor = string.Empty;
        private string _descripcion = string.Empty;
        private string _estado = string.Empty;
        private ListaDePreciosProveedoresExcel _listaDePreciosProveedores = new ListaDePreciosProveedoresExcel();
        private CotizacionWrapper _cotizacionProductoPrecioDeCosto;
        private CotizacionWrapper _cotizacionProductoPrecioDeVenta;
        #endregion

        #region Constructores
        public ProductoExcel(string Codigo, string CodigoSecundario, string CodigoProveedor, string Descripcion)
        {
            _codigo = Codigo;
            _codigoSecundario = CodigoSecundario;
            _codigoProveedor = CodigoProveedor;
            _descripcion = Descripcion;
            _estado = "NEW";
            _cotizacionProductoPrecioDeCosto = new CotizacionWrapper(Variables.GetValueString("Contabilidad.CotizacionReferencia"));
            _cotizacionProductoPrecioDeVenta = new CotizacionWrapper(Variables.GetValueString("Contabilidad.CotizacionReferencia"));
        }

        public ProductoExcel(tsh_ProductosDataset.tsh_ProductosRow row)
        {

            _idProducto = row.IdProducto;
            /*_codigoProducto = row.Codigo;
            _codigoSecundario = row.CodigoSecundario;
            _codigoProveedor = row.CodigoProveedor;
            _descripcion = row.Descripcion;*/
            _estado = "";
            if (Convert.ToString(row["IdCotizacionCierrePrecioDeCostoRef"]) != null)
                _cotizacionProductoPrecioDeCosto = new CotizacionWrapper(Convert.ToString(row["IdCotizacionCierrePrecioDeCostoRef"]));
            else
                _cotizacionProductoPrecioDeCosto = new CotizacionWrapper(Variables.GetValueString("Contabilidad.CotizacionReferencia"));

            if (Convert.ToString(row["IdCotizacionCierrePrecioDeVentaNeto"]) != null)
                _cotizacionProductoPrecioDeVenta = new CotizacionWrapper(Convert.ToString(row["IdCotizacionCierrePrecioDeVentaNeto"]));
            else
                _cotizacionProductoPrecioDeVenta = new CotizacionWrapper(Variables.GetValueString("Contabilidad.CotizacionReferencia"));
        }

        #endregion

        #region Propiedades
        public string IdProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }

        public string Codigo
        {
            get { return _codigo; }
        }

        public string CodigoSecundario
        {
            get { return _codigoSecundario; }
        }

        public string CodigoProveedor
        {
            get { return _codigoProveedor; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
        }

        public string Estado
        {
            get { return _estado; }
        }

        public ListaDePreciosProveedoresExcel ListaDePreciosProveedores
        {
            get { return _listaDePreciosProveedores; }
        }

        public string IdMonedaPrecioDeCosto
        {
            get
            {
                if (_cotizacionProductoPrecioDeCosto != null)
                {
                    return _cotizacionProductoPrecioDeCosto.IdMonedaOrigen;
                }
                return string.Empty;
            }

        }

        public string IdFuenteDeCambioProductoPrecioDeCosto
        {
            get
            {
                if (_cotizacionProductoPrecioDeCosto != null)
                    return _cotizacionProductoPrecioDeCosto.IdFuenteDeCambio;
                return string.Empty;
            }
        }

        public string IdCotizacionMonedaPrecioDeCosto
        {
            get
            {
                if (_cotizacionProductoPrecioDeCosto != null)
                    return _cotizacionProductoPrecioDeCosto.IdCotizacion;
                return string.Empty;
            }
        }

        public string IdMonedaPrecioDeVentaNeto
        {
            get
            {
                if (_cotizacionProductoPrecioDeVenta != null)
                {
                    return _cotizacionProductoPrecioDeVenta.IdMonedaOrigen;
                }
                return string.Empty;
            }
        }

        public string IdMonedaCierrePrecioDeVentaBruto
        {
            get
            {
                if (_cotizacionProductoPrecioDeVenta != null)
                {
                    return _cotizacionProductoPrecioDeVenta.IdMonedaOrigen;
                }
                return string.Empty;
            }
        }

        public string IdCotizacionMonedaPrecioDeVentaNeto
        {
            get
            {
                if (_cotizacionProductoPrecioDeVenta != null)
                    return _cotizacionProductoPrecioDeVenta.IdCotizacion;
                return string.Empty;
            }
        }

        #endregion

        #region Métodos Públicos
        #endregion

        #region Métodos Privados

        #endregion
    }

    public class ListaDePreciosProveedoresExcel
    {
        #region Variables privadas
        private ArrayList _items = new ArrayList();
        #endregion

        #region Constructores

        public ListaDePreciosProveedoresExcel()
        {
        }

        #endregion

        #region Propiedades
        public ArrayList Items
        {
            get { return _items; }
            set { _items = value; }
        }
        #endregion

        #region Métodos Públicos
        public void AddItem(ListaDePreciosProveedoresItemExcel Item)
        {
            _items.Add(Item);
        }
        #endregion

        #region Métodos Privados

        #endregion
    }

    public class ListaDePreciosProveedoresItemExcel
    {
        #region Variables privadas
        private string _idProveedor = string.Empty;
        private string _idProducto = string.Empty;
        private decimal _precioDeCosto = 0;
        private decimal _bonificacion1 = 0;
        private decimal _bonificacion2 = 0;
        private decimal _bonificacion3 = 0;
        private decimal _bonificacion4 = 0;
        private decimal _bonificacion5 = 0;
        private decimal _porcentajeBonificacion1 = 0;
        private decimal _porcentajeBonificacion2 = 0;
        private decimal _porcentajeBonificacion3 = 0;
        private decimal _porcentajeBonificacion4 = 0;
        private decimal _porcentajeBonificacion5 = 0;
        private decimal _precioDeCostoUltimaCompra = 0;
        private decimal _precioDeCostoFinal = 0;
        private string _idMonedaPrecioDeCosto = string.Empty;
        private string _idCotizacionPrecioDeCosto = string.Empty;
        private string _idFuenteDeCambio = string.Empty;
        private string _idCotizacionProveedor = string.Empty;
        private string _idFuenteDeCambioProveedor = string.Empty;
        private string _idMonedaProveedor = string.Empty;
        private decimal _valorCotizacionProveedor = 1;
        private CotizacionWrapper _cotizacionPrecioDeCosto;
        private string _estado = string.Empty;
        #endregion

        #region Constructores

        public ListaDePreciosProveedoresItemExcel(tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow row)
        {
            _idProveedor = row.IdProveedor;
            _idProducto = row.IdProducto;
            _precioDeCosto = row.PrecioDeCosto;
            _bonificacion1 = row.Bonificacion1;
            _bonificacion2 = row.Bonificacion2;
            _bonificacion3 = row.Bonificacion3;
            _bonificacion4 = row.Bonificacion4;
            _bonificacion5 = row.Bonificacion5;
            _porcentajeBonificacion1 = row.PorcentajeBonificacion1;
            _porcentajeBonificacion2 = row.PorcentajeBonificacion2;
            _porcentajeBonificacion3 = row.PorcentajeBonificacion3;
            _porcentajeBonificacion4 = row.PorcentajeBonificacion4;
            _porcentajeBonificacion5 = row.PorcentajeBonificacion5;
            _precioDeCostoFinal = row.PrecioDeCostoFinal;
            /*_idMonedaPrecioDeCosto = row.IdMonedaPrecioDeCosto;
            _idFuenteDeCambio = row.IdFuenteDeCambio;
            _idCotizacionPrecioDeCosto = row.IdCotizacionPrecioDeCosto;
            _idCotizacionProveedor = row.IdCotizacionProveedor;
            _idFuenteDeCambioProveedor = row.IdFuenteDeCambioProveedor;
            _idMonedaProveedor = row.IdMonedaProveedor;
            _valorCotizacionProveedor = row.ValorCotizacionProveedor;
            _cotizacionPrecioDeCosto = new CotizacionWrapper(_idCotizacionProveedor);
            */
            _estado = "";

        }
        public ListaDePreciosProveedoresItemExcel(string IdProducto, string IdProveedor, string IdMonedaPrecioDeCosto, string IdFuenteDeCambio, string IdCotizacionPrecioDeCosto, string IdCotizacionProveedor, string IdFuenteDeCambioProveedor, string IdMonedaProveedor)
        {
            _idProducto = IdProducto;
            _idProveedor = IdProveedor;
            _precioDeCosto = 0;
            _idMonedaPrecioDeCosto = IdMonedaPrecioDeCosto;
            _idFuenteDeCambio = IdFuenteDeCambio;
            _idCotizacionPrecioDeCosto = IdCotizacionPrecioDeCosto;
            _idCotizacionProveedor = IdCotizacionProveedor;
            _idFuenteDeCambioProveedor = IdFuenteDeCambioProveedor;
            _idMonedaProveedor = IdMonedaProveedor;
            _cotizacionPrecioDeCosto = new CotizacionWrapper(_idCotizacionProveedor);
            _valorCotizacionProveedor = _cotizacionPrecioDeCosto.Valor;
            _estado = "NEW";
        }



        #endregion

        #region Propiedades
        public string IdProveedor
        {
            get { return _idProveedor; }
        }


        public string IdProducto
        {
            get { return _idProducto; }
        }


        public decimal PrecioDeCosto
        {
            get { return _precioDeCosto; }
            set
            {
                if (_precioDeCosto != value)
                {
                    _precioDeCosto = value;
                    if (!_estado.Equals("NEW"))
                        _estado = "MODIF";

                }
            }
        }

        public decimal Bonificacion1
        {
            get { return _bonificacion1; }
            set
            {
                if (_bonificacion1 != value)
                {
                    _bonificacion1 = value;
                    PrecioDeCostoFinal = _precioDeCosto + _bonificacion1 + _bonificacion2 + _bonificacion3 + _bonificacion4 + _bonificacion5;
                    if (_precioDeCosto != 0)
                        _porcentajeBonificacion1 = (value * 100) / _precioDeCosto;
                    else
                        _porcentajeBonificacion1 = 0;
                    if (!_estado.Equals("NEW"))
                        _estado = "MODIF";
                }
            }
        }


        public decimal Bonificacion2
        {
            get { return _bonificacion2; }
            set
            {
                if (_bonificacion2 != value)
                {
                    _bonificacion2 = value;
                    PrecioDeCostoFinal = _precioDeCosto + _bonificacion1 + _bonificacion2 + _bonificacion3 + _bonificacion4 + _bonificacion5;
                    if (!_estado.Equals("NEW"))
                        _estado = "MODIF";
                }
            }
        }

        public decimal Bonificacion3
        {
            get { return _bonificacion3; }
            set
            {
                if (_bonificacion3 != value)
                {
                    _bonificacion3 = value;
                    PrecioDeCostoFinal = _precioDeCosto + _bonificacion1 + _bonificacion2 + _bonificacion3 + _bonificacion4 + _bonificacion5;
                    if (!_estado.Equals("NEW"))
                        _estado = "MODIF";
                }
            }
        }


        public decimal Bonificacion4
        {
            get { return _bonificacion4; }
            set
            {
                if (_bonificacion4 != value)
                {
                    _bonificacion4 = value;
                    PrecioDeCostoFinal = _precioDeCosto + _bonificacion1 + _bonificacion2 + _bonificacion3 + _bonificacion4 + _bonificacion5;
                    if (!_estado.Equals("NEW"))
                        _estado = "MODIF";
                }
            }
        }


        public decimal Bonificacion5
        {
            get { return _bonificacion5; }
            set
            {
                if (_bonificacion5 != value)
                {
                    _bonificacion5 = value;
                    PrecioDeCostoFinal = _precioDeCosto + _bonificacion1 + _bonificacion2 + _bonificacion3 + _bonificacion4 + _bonificacion5;
                    if (!_estado.Equals("NEW"))
                        _estado = "MODIF";
                }
            }
        }

        public decimal PorcentajeBonificacion1
        {
            get { return _porcentajeBonificacion1; }
            set
            {
                if (_porcentajeBonificacion1 != value)
                {
                    _porcentajeBonificacion1 = value;
                    _bonificacion1 = (_porcentajeBonificacion1 * _precioDeCosto) / 100;
                    PrecioDeCostoFinal = _precioDeCosto + _bonificacion1 + _bonificacion2 + _bonificacion3 + _bonificacion4 + _bonificacion5;
                    if (!_estado.Equals("NEW"))
                        _estado = "MODIF";
                }
            }
        }


        public decimal PorcentajeBonificacion2
        {
            get { return _porcentajeBonificacion2; }
            set
            {
                if (_porcentajeBonificacion2 != value)
                {
                    _porcentajeBonificacion2 = value;
                    PrecioDeCostoFinal = _precioDeCosto + _bonificacion1 + _bonificacion2 + _bonificacion3 + _bonificacion4 + _bonificacion5;
                    if (!_estado.Equals("NEW"))
                        _estado = "MODIF";
                }
            }
        }


        public decimal PorcentajeBonificacion3
        {
            get { return _porcentajeBonificacion3; }
            set
            {
                if (_porcentajeBonificacion3 != value)
                {
                    _porcentajeBonificacion3 = value;
                    PrecioDeCostoFinal = _precioDeCosto + _bonificacion1 + _bonificacion2 + _bonificacion3 + _bonificacion4 + _bonificacion5;
                    if (!_estado.Equals("NEW"))
                        _estado = "MODIF";
                }
            }
        }


        public decimal PorcentajeBonificacion4
        {
            get { return _porcentajeBonificacion4; }
            set
            {
                if (_porcentajeBonificacion4 != value)
                {
                    _porcentajeBonificacion4 = value;
                    PrecioDeCostoFinal = _precioDeCosto + _bonificacion1 + _bonificacion2 + _bonificacion3 + _bonificacion4 + _bonificacion5;
                    if (!_estado.Equals("NEW"))
                        _estado = "MODIF";
                }
            }
        }


        public decimal PorcentajeBonificacion5
        {
            get { return _porcentajeBonificacion5; }
            set
            {
                if (_porcentajeBonificacion5 != value)
                {
                    _porcentajeBonificacion5 = value;
                    PrecioDeCostoFinal = _precioDeCosto + _bonificacion1 + _bonificacion2 + _bonificacion3 + _bonificacion4 + _bonificacion5;
                    if (!_estado.Equals("NEW"))
                        _estado = "MODIF";
                }
            }
        }

        public decimal PrecioDeCostoFinal
        {
            get { return _precioDeCostoFinal; }
            set
            {
                _precioDeCostoFinal = value;
                if (!_estado.Equals("NEW"))
                    _estado = "MODIF";
            }
        }

        public string Estado
        {
            get { return _estado; }
        }

        public string IdMonedaPrecioDeCosto
        {
            get { return _idMonedaPrecioDeCosto; }
        }

        public string IdCotizacionPrecioDeCosto
        {
            get { return _idCotizacionPrecioDeCosto; }
        }

        public string IdFuenteDeCambio
        {
            get { return _idFuenteDeCambio; }
        }

        public string IdCotizacionProveedor
        {
            get { return _idCotizacionProveedor; }
        }

        public string IdFuenteDeCambioProveedor
        {
            get { return _idFuenteDeCambioProveedor; }
        }

        public string IdMonedaProveedor
        {
            get { return _idMonedaProveedor; }
        }

        public decimal ValorCotizacionProveedor
        {
            get { return _valorCotizacionProveedor; }
        }

        #endregion

        #region Métodos Públicos
        #endregion

        #region Métodos Privados

        #endregion
    }
    //Sabrina 20100615 - Tarea 764
    public class ListaDePreciosView
    {
        public ListaDePreciosView(string IdListaDePrecio, string Descripcion)
        {
            _idListaDePrecios = IdListaDePrecio;
            _descripcion = Descripcion;
        }

        private string _idListaDePrecios;
        public string IdListaDePrecio
        {
            get { return _idListaDePrecios; }
        }

        private string _descripcion;
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public override System.String ToString()
        {
            return _descripcion;
        }

        public override System.Boolean Equals(System.Object obj)
        {
            return this.IdListaDePrecio.Equals(((ListaDePreciosView)obj).IdListaDePrecio);
        }

    }

    //Fin Sabrina 20100615 - Tarea 764
}
