using System;
using mz.erp.businessrules;
using System.Data;
using mz.erp.commontypes.CommonInterfaces;
using mz.erp.commontypes;
using System.Collections;
using System.Text;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ModificarPreciosMasivoDesdeExcelController.
	/// </summary>
	public class ModificarPreciosMasivoDesdeExcelController: ITaskController
	{
		#region Constructores

		public ModificarPreciosMasivoDesdeExcelController(ModificarPreciosMasivoDesdeExcel brClass)
		{
			_brClass = brClass;
			Init();
		}

		#endregion

		#region Variables Privadas

		private ModificarPreciosMasivoDesdeExcel _brClass;

		#endregion

		#region Propiedades

		public string TextoBotonSiguiente
		{
			get { return _brClass.TextoBotonSiguiente ; }
		}
		
		public string TextoBotonAnterior
		{
			get { return _brClass.TextoBotonAnterior; }
		}

		public string LeyendaFormulario
		{
			get{ return _brClass.LeyendaFormulario; }
		}

		public bool PreguntarAlCancelar
		{
			get {return _brClass.PreguntarAlCancelar;}
		}

		public string CodigoProveedor
		{
			get {return _brClass.CodigoProveedor;}
			set{_brClass.CodigoProveedor = value;}				
		}			
		
		public bool PorCodigo
		{
			get {return _brClass.PorCodigo;}
			set{_brClass.PorCodigo = value;}				
		}			

		public bool PorCodigoSecundario
		{
			get {return _brClass.PorCodigoSecundario;}
			set{_brClass.PorCodigoSecundario = value;}				
		}			
		
		public bool PorCodigoProveedor
		{
			get {return _brClass.PorCodigoProveedor;}
			set{_brClass.PorCodigoProveedor = value;}				
		}			

		public bool AgregaProductosNuevos
		{
			get {return _brClass.AgregaProductosNuevos;}
			set{_brClass.AgregaProductosNuevos = value;}				
		}			

		public bool PercibeIB
		{
			get {return _brClass.PercibeIB;}
			set{_brClass.PercibeIB = value;}				
		}			

		public bool IVA
		{
			get {return _brClass.IVA;}
			set{_brClass.IVA = value;}				
		}			

		public bool IVADIF
		{
			get {return _brClass.IVADIF;}
			set{_brClass.IVADIF = value;}				
		}			
		
		public bool EX
		{
			get {return _brClass.EX;}
			set{_brClass.EX = value;}				
		}			
		
		public System.Data.DataTable Result
		{
			get { return _brClass.Result; }
		}

		public bool ModificaBonificaciones
		{
			get {return _brClass.ModificaBonificaciones;}
			set{_brClass.ModificaBonificaciones = value;}				
		}			

		public bool ModificaPrecioDeCosto
		{
			get {return _brClass.ModificaPrecioDeCosto;}
			set{_brClass.ModificaPrecioDeCosto = value;}				
		}			

		public bool ModificaProductosInactivos
		{
			get {return _brClass.ModificaProductosInactivos;}
			set{_brClass.ModificaProductosInactivos = value;}				
		}			

		public string ArchivoExcel
		{
			get {return _brClass.ArchivoExcel;}
			set{_brClass.ArchivoExcel = value;}
		}

		public bool ByJerarquia1
		{
			get{return _brClass.ByJerarquia1;}
			set{_brClass.ByJerarquia1 = value;}
		}

		public bool ByJerarquia2
		{
			get{return _brClass.ByJerarquia2;}
			set{_brClass.ByJerarquia2 = value;}
		}
		public bool ByJerarquia3
		{
			get{return _brClass.ByJerarquia3;}
			set{_brClass.ByJerarquia3 = value;}
		}
		public bool ByJerarquia4
		{
			get{return _brClass.ByJerarquia4;}
			set{_brClass.ByJerarquia4 = value;}
		}
		public bool ByJerarquia5
		{
			get{return _brClass.ByJerarquia5;}
			set{_brClass.ByJerarquia5 = value;}
		}
		public bool ByJerarquia6
		{
			get{return _brClass.ByJerarquia6;}
			set{_brClass.ByJerarquia6 = value;}
		}
		public bool ByJerarquia7
		{
			get{return _brClass.ByJerarquia7;}
			set{_brClass.ByJerarquia7 = value;}
		}
		public bool ByJerarquia8
		{
			get{return _brClass.ByJerarquia8;}
			set{_brClass.ByJerarquia8 = value;}
		}

		public ArrayList Jerarquia1
		{
			get{return _brClass.Jerarquia1;}
			set{_brClass.Jerarquia1 = value;}
		}
		public ArrayList Jerarquia2
		{
			get{return _brClass.Jerarquia2;}
			set{_brClass.Jerarquia2 = value;}
		}
		public ArrayList Jerarquia3
		{
			get{return _brClass.Jerarquia3;}
			set{_brClass.Jerarquia3 = value;}
		}
		public ArrayList Jerarquia4
		{
			get{return _brClass.Jerarquia4;}
			set{_brClass.Jerarquia4 = value;}
		}
		public ArrayList Jerarquia5
		{
			get{return _brClass.Jerarquia5;}
			set{_brClass.Jerarquia5 = value;}
		}
		public ArrayList Jerarquia6
		{
			get{return _brClass.Jerarquia6;}
			set{_brClass.Jerarquia6 = value;}
		}
		public ArrayList Jerarquia7
		{
			get{return _brClass.Jerarquia7;}
			set{_brClass.Jerarquia7 = value;}
		}
		public ArrayList Jerarquia8
		{
			get{return _brClass.Jerarquia8;}
			set{_brClass.Jerarquia8 = value;}
		}

		public string ContenedoresVisibles
		{
			get{return _brClass.ContenedoresVisibles;}
		}


        //German 20120202 - Tarea 0000273
        public bool PrecioDeVentaTieneImpuestos
        {
            get { return _brClass.PrecioDeVentaTieneImpuestos; }
            set { _brClass.PrecioDeVentaTieneImpuestos = value; }
        }

        //German 20120202 - Tarea 0000273

		public bool PcioDeVtaContieneImpuestos
		{
			get {return _brClass.PcioDeVtaContieneImpuestos;}
			set{_brClass.PcioDeVtaContieneImpuestos = value;}				
		}			

		public bool ModificaCodigoSecundario
		{
			get {return _brClass.ModificaCodigoSecundario;}
			set{_brClass.ModificaCodigoSecundario = value;}				
		}			

		public bool ModificaCodigoProveedor
		{
			get {return _brClass.ModificaCodigoProveedor;}
			set{_brClass.ModificaCodigoProveedor = value;}				
		}			

		public bool ModificaCamposAuxiliares
		{
			get {return _brClass.ModificaCamposAuxiliares;}
			set{_brClass.ModificaCamposAuxiliares = value;}				
		}			

		public bool ModificaDescripcion
		{
			get {return _brClass.ModificaDescripcion;}
			set{_brClass.ModificaDescripcion = value;}				
		}		

		public bool ModificaJerarquia1
		{
			get {return _brClass.ModificaJerarquia1;}
			set{_brClass.ModificaJerarquia1 = value;}				
		}			

		public bool ModificaJerarquia2
		{
			get {return _brClass.ModificaJerarquia2;}
			set{_brClass.ModificaJerarquia2 = value;}				
		}			
		
		public bool ModificaJerarquia3
		{
			get {return _brClass.ModificaJerarquia3;}
			set{_brClass.ModificaJerarquia3 = value;}				
		}			
		
		public bool ModificaJerarquia4
		{
			get {return _brClass.ModificaJerarquia4;}
			set{_brClass.ModificaJerarquia4 = value;}				
		}			
		
		public bool ModificaJerarquia5
		{
			get {return _brClass.ModificaJerarquia5;}
			set{_brClass.ModificaJerarquia5 = value;}				
		}			
		
		public bool ModificaJerarquia6
		{
			get {return _brClass.ModificaJerarquia6;}
			set{_brClass.ModificaJerarquia6 = value;}				
		}			
		
		public bool ModificaJerarquia7
		{
			get {return _brClass.ModificaJerarquia7;}
			set{_brClass.ModificaJerarquia7 = value;}				
		}			
		
		public bool ModificaJerarquia8
		{
			get {return _brClass.ModificaJerarquia8;}
			set{_brClass.ModificaJerarquia8 = value;}				
		}			
		
		public bool HabilitaJerarquia1
		{
			get {return _brClass.HabilitaJerarquia1;}
		}			

		public bool HabilitaJerarquia2
		{
			get {return _brClass.HabilitaJerarquia2;}
		}			
		
		public bool HabilitaJerarquia3
		{
			get {return _brClass.HabilitaJerarquia3;}
		}			
		
		public bool HabilitaJerarquia4
		{
			get {return _brClass.HabilitaJerarquia4;}
		}			
		
		public bool HabilitaJerarquia5
		{
			get {return _brClass.HabilitaJerarquia5;}
		}			
		
		public bool HabilitaJerarquia6
		{
			get {return _brClass.HabilitaJerarquia6;}
		}			
		
		public bool HabilitaJerarquia7
		{
			get {return _brClass.HabilitaJerarquia7;}
		}			
		
		public bool HabilitaJerarquia8
		{
			get {return _brClass.HabilitaJerarquia8;}
		}

		public bool AgregaListaDePreciosNuevas
		{
			get {return _brClass.AgregaListaDePreciosNuevas;}
			set{_brClass.AgregaListaDePreciosNuevas = value;}				
		}	
		
		//German 20091023 - Tarea 477
		public ArrayList ProductosRepetidos
		{
			get
			{
				return _brClass.ProductosRepetidos;
			}
		}
		//Fin German 20091023 - Tarea 477

		//Sabrina 20100615 - Tarea 764
		public bool HabilitaListasDePrecios
		{
			get{return _brClass.HabilitaListasDePrecios;}
		}

		public ArrayList ListasDePrecios
		{
			get 
			{
				return _brClass.ListasDePrecios;
			}
		}
		
		public ArrayList ListasDePreciosSeleccionadas
		{
			set 
			{
				_brClass.ListasDePreciosSeleccionadas = value;
			}
		}
		//Fin Sabrina 20100615 - Tarea 764

        //Sabrina: Tarea 1068. 20110317
        public bool ActualizaPreciosProductosCombo
        {
            get { return _brClass.ActualizaPreciosProductosCombo; }
            set { _brClass.ActualizaPreciosProductosCombo = value; }
        }
        //Fin Sabrina: Tarea 1068. 20110317

        //German 20120202 - Tarea 0000273
        
        public bool ActualizaListasDePreciosDeVentaDesdeExcel
        {
            get { return _brClass.ActualizaListasDePreciosDeVentaDesdeExcel; }
        }

        public ArrayList ListasDePreciosSeleccionadas2
        {
            set
            {
                _brClass.ListasDePreciosSeleccionadas2 = value;
            }
        }
        //Fin German 20120202 - Tarea 0000273
        
        #endregion

		#region Eventos
		public event EventHandler DataChanged;
		public event EventHandler PorCodigoChanged;
		public event EventHandler PorCodigoSecundarioChanged;
		public event EventHandler PorCodigoProveedorChanged;
		public event EventHandler IVAChanged;
		public event EventHandler IVADIFChanged;
		public event EventHandler EXChanged;
		#endregion

		#region Metodos Privados

		private void Init()
		{
			InitEventHandlers();
			InitData();
		}

		private void InitData()
		{
		}

		private void InitEventHandlers()
		{
			_brClass.DataChanged +=new EventHandler(RefreshData);
		}

		private void RefreshData(object sender, EventArgs e)
		{
			if(DataChanged != null)
				DataChanged(this, new EventArgs());
		}

		#endregion

		#region Miembros de ITaskController

		public bool IsFlushedState()
		{
			return this._processManager.ProcessFlushed;
		}

		public bool IsNextState()
		{
			return this._processManager.IsNextState();	
		}

		public bool IsBackState()
		{	
			return this._processManager.IsBackState();
		}

		public bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_brClass.GetTaskName());
		}

		public bool IsLastTask()
		{					
			return this._processManager.IsLastTask(_brClass.GetTaskName());
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

		public bool AllowPrevious()
		{
			return _brClass.AllowPrevious();
		}

		public void Previous()
		{
			_brClass.Previous();
		}

		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}



		public ITask GetTask()
		{
			return _brClass;
		}

		public void Execute()
		{
			_brClass.Execute();
		}

		public bool AllowShow()
		{
			return _brClass.AllowShow();
		}
		
		
		public ItemsDatasetErrors GetErrors()
		{
			return 	_brClass.GetErrors();
		}
		public string GetWarnings()
		{
			return 	_brClass.GetWarnings();
		}
		public void Continue()
		{
			_brClass.Execute();
		}

		#endregion

		#region Metodos Publicos
        
        //Sabrina: Tarea 1068. 20110317
        public bool CambioCostoProductosCombo()
        {
            return _brClass.CambioCostoProductosCombo();
        }

        public bool CambioPrecioVentaProductosCombo()
        {
            return _brClass.CambioPrecioVentaProductosCombo();
        }
        //Fin Sabrina: Tarea 1068. 20110317

		public void RefreshData()
		{
			_brClass.RefreshData();
			//German 20091023 - Tarea 477
			//if(DataChanged != null)
			//	DataChanged(this, new EventArgs());
			//Fin German 20091023 - Tarea 477
		}

		//German 20091023 - Tarea 477
		public void ClearProductosRepetidos()
		{
			_brClass.ClearProductosRepetidos();
		}
		//Fin German 20091023 - Tarea 477

		#endregion


	}
}
