using System;
using System.Data;
using System.Collections;
using mz.erp.businessrules;
using mz.erp.commontypes;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de JerarquiaConfigurarVariableController.
	/// </summary>
	public class JerarquiaConfigurarVariableController: ITaskController//, IObserver //ISearchObjectListener
	{
		#region Constructores
		public JerarquiaConfigurarVariableController()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public JerarquiaConfigurarVariableController(JerarquiaConfigurarVariable brClass)
		{
			_brClass = brClass;
			Init();
		}
//		public JerarquiaConfigurarVariableController(ITaskController parentTaskController)
//		{
//            _brClass=new JerarquiaConfigurarVariable(parentTaskController.GetProcessManager().GetProcessName(), parentTaskController.GetTaskName());
//		}
		#endregion

		#region Miembros de ITaskController

		public string GetWarnings()
		{
			return _brClass.GetWarnings();
		}

		public void Continue()
		{
			_brClass.Execute();
		}

		public mz.erp.businessrules.ItemsDatasetErrors GetErrors()
		{
			return _brClass.GetErrors();
		}

		public void Execute()
		{
			_brClass.Execute();
		}

		public bool AllowShow()
		{
			return _brClass.AllowShow();
		}

		public bool AllowPrevious()
		{
			return _brClass.AllowPrevious();
		}

		public void Previous()
		{
			_brClass.Previous();
		}

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


		
		#endregion

		#region Variables Privadas
		private JerarquiaConfigurarVariable _brClass;
		private ProcessControllerManager _processManager;
		private string _leyendaFormulario = string.Empty;
		
		private Node _currentNode;

		#endregion

		#region Metodos Privados
		private void Init()
		{
			SetLeyendaFormulario();
		}

		private void SetLeyendaFormulario()
		{
			string leyenda = Variables.GetValueString(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(), "LeyendaFormulario" );
			if (leyenda.Equals(string.Empty))
			{
				leyenda = this._brClass.GetTaskName();
			}
			this._leyendaFormulario = leyenda;
		}

		private void ListenerObjectHasChanged(object sender, System.EventArgs e)
		{
		}
		

		#endregion



		#region Metodos Publicos
		public string LeyendaFormulario()
		{
			return this._leyendaFormulario;
		}
		public void UpdateTree(string key)
		{
			_currentNode = _brClass.getChildsNode(key);
		}

		public bool HasNext()
		{
			if(_currentNode != null)
				return _currentNode.HasNext();
			else return false;
		}

		public ArrayList Next()
		{
			Node node = _currentNode.Next();
			ArrayList result = new ArrayList();
			result.Add(node.Key);
			result.Add(node.Description);
			return result;
		}

		public void UpdateElementos(ArrayList rows)
		{
			this._brClass.UpdateElementos(rows);
		}

//		public DataTable BuscarJerarquias(object SelectedItem)
//		{
//			return _brClass.SearchAgrupamientos(SelectedItem);
//			
//		}

		public bool ValidarNodoNivel0(string _idNom)
		{
			return _brClass.ValidarNodoNivel0(_idNom);
		}
		public bool JerarquiaEditable(string nro, string key)
		{
			return _brClass.JerarquiaEditable(nro, key);
		}

		#region CCtoDelete
//		public bool Jerarquia1Editable(string key)
//		{
//			return _brClass.Jerarquia1Editable(key);
//		}
//		public bool Jerarquia2Editable(string key)
//		{
//			return _brClass.Jerarquia2Editable(key);
//		}
//		public bool Jerarquia3Editable(string key)
//		{
//			return _brClass.Jerarquia3Editable(key);
//		}
//		public bool Jerarquia4Editable(string key)
//		{
//			return _brClass.Jerarquia4Editable(key);
//		}
//		public bool Jerarquia5Editable(string key)
//		{
//			return _brClass.Jerarquia5Editable(key);
//		}
//		public bool Jerarquia6Editable(string key)
//		{
//			return _brClass.Jerarquia6Editable(key);
//		}
//		public bool Jerarquia7Editable(string key)
//		{
//			return _brClass.Jerarquia7Editable(key);
//		}
//		public bool Jerarquia8Editable(string key)
//		{
//			return _brClass.Jerarquia8Editable(key);
//		}
		#endregion

		#endregion

		#region Propiedades
		public string Jerarquia1
		{
			get{return _brClass.Jerarquia1;}
		}
		public string Jerarquia2
		{
			get{return _brClass.Jerarquia2;}
		}
		public string Jerarquia3
		{
			get{return _brClass.Jerarquia3;}
		}
		public string Jerarquia4
		{
			get{return _brClass.Jerarquia4;}
		}
		public string Jerarquia5
		{
			get{return _brClass.Jerarquia5;}
		}
		public string Jerarquia6
		{
			get{return _brClass.Jerarquia6;}
		}
		public string Jerarquia7
		{
			get{return _brClass.Jerarquia7;}
		}
		public string Jerarquia8
		{
			get{return _brClass.Jerarquia8;}
		}

		public string SetNomenclaturaJerarquia1
		{
			set{_brClass.SetNomenclaturaJerarquia1=value;}
            /* Silvina 20111104 - Tarea 0000222 */
            get{ return _brClass.SetNomenclaturaJerarquia1;}
            /* Silvina 20111104 - Tarea 0000222 */
		}
		public string SetNomenclaturaJerarquia2
		{
			set{_brClass.SetNomenclaturaJerarquia2=value;}
            /* Silvina 20111104 - Tarea 0000222 */
            get { return _brClass.SetNomenclaturaJerarquia2; }
            /* Silvina 20111104 - Tarea 0000222 */
		}
		public string SetNomenclaturaJerarquia3
		{
			set{_brClass.SetNomenclaturaJerarquia3=value;}
            /* Silvina 20111104 - Tarea 0000222 */
            get { return _brClass.SetNomenclaturaJerarquia3; }
            /* Silvina 20111104 - Tarea 0000222 */
		}
		public string SetNomenclaturaJerarquia4
		{
			set{_brClass.SetNomenclaturaJerarquia4=value;}
            /* Silvina 20111104 - Tarea 0000222 */
            get { return _brClass.SetNomenclaturaJerarquia4; }
            /* Silvina 20111104 - Tarea 0000222 */
		}
		public string SetNomenclaturaJerarquia5
		{
			set{_brClass.SetNomenclaturaJerarquia5=value;}
            /* Silvina 20111104 - Tarea 0000222 */
            get { return _brClass.SetNomenclaturaJerarquia5; }
            /* Silvina 20111104 - Tarea 0000222 */
		}
		public string SetNomenclaturaJerarquia6
		{
			set{_brClass.SetNomenclaturaJerarquia6=value;}
            /* Silvina 20111104 - Tarea 0000222 */
            get { return _brClass.SetNomenclaturaJerarquia6; }
            /* Silvina 20111104 - Tarea 0000222 */
		}
		public string SetNomenclaturaJerarquia7
		{
			set{_brClass.SetNomenclaturaJerarquia7=value;}
            /* Silvina 20111104 - Tarea 0000222 */
            get { return _brClass.SetNomenclaturaJerarquia7; }
            /* Silvina 20111104 - Tarea 0000222 */
		}
		public string SetNomenclaturaJerarquia8
		{
			set{_brClass.SetNomenclaturaJerarquia8=value;}
            /* Silvina 20111104 - Tarea 0000222 */
            get { return _brClass.SetNomenclaturaJerarquia8; }
            /* Silvina 20111104 - Tarea 0000222 */
		}

         /* Silvina 20111104 - Tarea 0000222 */

        public bool UsaCategorias
        {
            get { return _brClass.UsaCategorias; }
        }

        public string Categoria
        {
            get { return _brClass.Categoria; }
        }

        public void SetCategoria(int indice)
        {
            _brClass.SetCategoria(indice);
        }

        /* Fin Silvina 20111104 - Tarea 0000222 */
		#endregion

	}
}
