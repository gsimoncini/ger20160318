using System;
using mz.erp.businessrules;
using System.Collections;
using System.Data;
using System.Text.RegularExpressions;
using System.Text;


namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de RegistrarNumerosDeSerieController.
	/// </summary>
	public class RegistrarNumerosDeSerieController: ITaskController
	{

		#region variables
		
		mz.erp.businessrules.RegistrarNumerosDeSerie _brClass;

		private IList _detalle = null;
		private string _leyendaFormulario = string.Empty;
		private string _layoutDetalle = string.Empty;
		private string _textoBotonSiguiente =string.Empty;
		private string _textoBotonPrevio = string.Empty;
		private bool _allowGroup = false;
		
		public bool AllowGroup
		{
			get{return _allowGroup;}
		}

		public IList Detalle
		{
			set
			{ 
				_brClass.Detalle = value;
			}
			get 
			{ 
				return _brClass.Detalle;
			}
		}

		public string LeyendaFormulario
		{
			
			get 
			{ 
				
				if(_brClass.NombreClienteComprobanteEntregaAsociado != string.Empty)
					return _leyendaFormulario + ". Cliente: " + _brClass.NombreClienteComprobanteEntregaAsociado;
				return _leyendaFormulario;
			}
		}
		
		public string LayoutDetalle
		{
			get { return _layoutDetalle; }
		}

		public string TextoBotonSiguiente
		{
			get { return _brClass.TextoBotonSiguiente ; }
		}
		
		public string TextoBotonPrevio
		{
			get { return _brClass.TextoBotonAnterior; }
		}

		#endregion
		
		#region constructores
		public RegistrarNumerosDeSerieController()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public RegistrarNumerosDeSerieController(mz.erp.businessrules.RegistrarNumerosDeSerie brClass)
		{
			_brClass= brClass;
			_brClass.ObjectHasChanged+= new System.EventHandler( this.ListenerObjectHasChanged );
			Init();
		}
		#endregion
		
		#region Miembros de ITaskController

		private ProcessControllerManager _processManager;

		public string GetWarnings()
		{
			return _brClass.GetWarnings();
		}

		public void Continue()
		{//este metodo no tenia comportamiento
			_brClass.Continue();
		}

		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}


		public ItemsDatasetErrors GetErrors()
		{
			return this._brClass.GetErrors();
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

		public void SetProcessManager(ProcessControllerManager processManager)
		{
			_processManager = processManager;
		}

		public ProcessControllerManager GetProcessManager()
		{
			return _processManager;
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


		#region Metodos Publicos

		public bool IsEditable(object SelectedItem)
		{
			return _brClass.PermiteModificarNroSerieSugerido((RegistrarNumerosDeSerie.ItemNumeroDeSerie)SelectedItem);
		}

		public bool AllowSeleccion()
		{
			return   _brClass.AllowSeleccion;
		}


		#endregion



		#region Metodos Privados

		private void Init()
		{
			this._layoutDetalle = Build_LayoutDetalle();
			if (_brClass.TextoBotonAnterior.CompareTo( string.Empty ) != 0)
			{
				this._textoBotonPrevio = _brClass.TextoBotonAnterior;
			}
			if (_brClass.TextoBotonSiguiente.CompareTo( string.Empty) != 0)
			{
				this._textoBotonSiguiente = _brClass.TextoBotonSiguiente;
			}
			_allowGroup = Variables.GetValueBool(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(),"PermiteAgrupar");

			SetLeyendaFormulario();

		}

		private void SetLeyendaFormulario()
		{
			string leyenda = Variables.GetValueString( "Momentos." + this._brClass.GetTaskName()+"." + this._brClass.GetProcessManagerParent().Process.ProcessName +".LeyendaFormulario" );
			if (leyenda.Equals(string.Empty))
			{
				leyenda = Variables.GetValueString( "Momentos." + this._brClass.GetTaskName()+".LeyendaFormulario" );
			}
			if (leyenda.Equals(string.Empty))
			{
				leyenda = this._brClass.GetTaskName();
			}
			
			this._leyendaFormulario = leyenda;
		}


		private string Build_LayoutDetalle()
		{
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );


			sb.Append( LayoutBuilder.GetRow( i++, "Item", "Item",35 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Codigo",50 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion",650 ) );
			
			if (_brClass.AllowSeleccion) 
			{
				sb.Append( LayoutBuilder.GetRow( i++, "NumeroDeSerie", "Número de Serie",150, Types.EditType.NoEdit ) );
				sb.Append( LayoutBuilder.GetRow(i++, "Seleccion", "Selección",60,Types.ColumnTypes.CheckBox,Types.EditType.CheckBox ) );				
				
			}	
			else 
			{
				sb.Append( LayoutBuilder.GetRow( i++, "NumeroDeSerie", "Número de Serie",150) );
			}

			sb.Append( LayoutBuilder.GetFooter() );
			return sb.ToString();		
		}
		
		public event System.EventHandler OnControllerChanged;
		private void ListenerObjectHasChanged(object sender, System.EventArgs e)
		{
			if (this.OnControllerChanged != null)
				this.OnControllerChanged(this,new System.EventArgs() );
		}

		

		#endregion
	}
}
