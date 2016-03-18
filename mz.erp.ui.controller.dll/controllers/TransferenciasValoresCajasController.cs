using System;
using mz.erp.businessrules;
using System.Collections;
using System.Data;
//using System.Text.RegularExpressions;
using System.Text;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de TransferenciasValoresCajasController.
	/// </summary>
	public class TransferenciasValoresCajasController : ITaskController
	{
		#region constructores
		
		public TransferenciasValoresCajasController()
		{			
			Init();
		}
		public TransferenciasValoresCajasController(businessrules.TransferirValores brClass)
		{
			_brClass= brClass;			
			Init();
		}	

		#endregion


		#region variables / set y get
		
		#region variables
		
		private mz.erp.businessrules.TransferirValores _brClass;

		private string _leyendaFormulario = string.Empty;
		private string _textoBotonSiguiente =string.Empty;
		private string _textoBotonPrevio = string.Empty;

		private string _layoutDetalleValoresATransferir = string.Empty;
		private string _layoutDetalleValoresDisponibles = string.Empty;

		#endregion

		#region set y get
		
		public string LeyendaFormulario
		{	
			get { return "Transferencia de Valores entre Cajas";}
		}

		public bool PreguntarAlCancelar
		{
			get {return _brClass.PreguntarAlCancelar;}
		}
		
		public string TextoBotonSiguiente
		{
			get { return _brClass.TextoBotonSiguiente ; }
		}
		
		public string TextoBotonAnterior
		{
			get { return _brClass.TextoBotonAnterior; }
		}

		public System.Data.DataTable CajasOrigenDisponible
		{
			get
			{
				System.Data.DataTable _table = new DataTable();
				_table.Columns.Add( new System.Data.DataColumn( "IdInstanciaCaja", typeof( System.String)));
				_table.Columns.Add( new System.Data.DataColumn( "Descripcion", typeof(System.String)) );
				if (_brClass.CajasOrigenDisponibles != null) 
				{
					foreach( string clave in _brClass.CajasOrigenDisponibles.Keys )
					{
						_table.Rows.Add( new object[] { clave,_brClass.CajasOrigenDisponibles[clave] });
					}								
					return _table;
				}
				return null;
			}
		}

		public System.Data.DataTable CajasDestinoDisponible
		{
			get
			{
				System.Data.DataTable _table = new DataTable();
				_table.Columns.Add( new System.Data.DataColumn( _cajaOrigenValueMember, typeof( System.String)));
				_table.Columns.Add( new System.Data.DataColumn( _cajaOrigenDisplayMember, typeof(System.String)) );
				foreach( string clave in _brClass.CajasDestinoDisponibles.Keys )
				{
					_table.Rows.Add( new object[] { clave,_brClass.CajasDestinoDisponibles[clave] });
				}								
				return _table;
			}			
		}
		private string _cajaOrigenValueMember = "IdInstanciaCaja";
		public string CajaOrigenValueMember
		{
			get { return _cajaOrigenValueMember; }			
		}

		private string _cajaOrigenDisplayMember = "Descripcion";
		public string CajaOrigenDisplayMember
		{
			get { return "Descripcion"; }
		}		
	

		private string _cajaDestinoValueMember = "IdInstanciaCaja";
		public string CajaDestinoValueMember
		{
			get { return _cajaDestinoValueMember; }			
		}

		private string _cajaDestinoDisplayMember = "Descripcion";
		public string CajaDestinoDisplayMember
		{
			get { return _cajaDestinoDisplayMember; }
		}		

		private object _keyValueCajaOrigen;
		public object KeyValueCajaOrigen
		{
			get
			{
				return (object)_brClass.KeyValueCajaOrigen;
			}
			set 
			{
				if (_keyValueCajaOrigen != value) 
				{
					_keyValueCajaOrigen = value;
					_brClass.KeyValueCajaOrigen = Convert.ToString(value);
					if (KeyValueCajaOrigenChanged != null) 
						KeyValueCajaOrigenChanged(this, new EventArgs());
				}				
			}
		}
		private object _keyValueCajaDestino;
		public object KeyValueCajaDestino
		{
			get
			{
				return (object)_brClass.KeyValueCajaDestino;
			}
			set 
			{
				if (_keyValueCajaDestino != value) 
				{
					_keyValueCajaDestino = value;
					_brClass.KeyValueCajaDestino = Convert.ToString(value);
					if (KeyValueCajaDestinoChanged != null) 
						KeyValueCajaDestinoChanged(this, new EventArgs());
				}				
			}
		}

		private string _responsableCajaOrigen;
		public string ResponsableCajaOrigen
		{
			get 
			{
				return _brClass.ResponsableCajaOrigen;
			}
			set 
			{
			}
		}

		private string _responsableCajaDestino;
		public string ResponsableCajaDestino 
		{
			get 
			{
				return _brClass.ResponsableCajaDestino;
			}
			set 
			{
			}
		}

		private decimal _totalATransferir;
		public decimal TotalATransferir 
		{
			get 
			{
				return _totalATransferir;
			}
			set 
			{
			}
		}
		
		public ArrayList ValoresDisponibles 
		{
			get 
			{
				return _brClass.ValoresDisponibles;
			}
						
		}

		
		public ArrayList ValoresATransferir 
		{
			get 
			{
				return _brClass.ValoresATransferir;
			}
		}

		public string LayoutDetalleValoresDisponibles 
		{
			get 
			{
				return _layoutDetalleValoresDisponibles;
			}
		}
		public string LayoutDetalleValoresATransferir 
		{
			get 
			{
				return _layoutDetalleValoresATransferir;
			}
		}

		#endregion

		#endregion

		#region Miembros de ITaskController

		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}

		public  bool IsFlushedState()
		{
			return this._processManager.ProcessFlushed;
		}

		public  bool IsNextState()
		{
			return this._processManager.IsNextState();	
		}

		public  bool IsBackState()
		{	
			return this._processManager.IsBackState();
		}
		public bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_brClass.GetTaskName());
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
		public void Continue()
		{
		}

		public ItemsDatasetErrors GetErrors()
		{
			// TODO: agregar la implementación ConceptosAdicionalesController.GetErrors
			return _brClass.GetErrors();				
		}

		public string GetWarnings()
		{
			return null;
		}

		public void RefreshData()
		{
		}

		public void Execute() 
		{													
			this._brClass.Execute();
		}

		public bool AllowShow()
		{
			return true;
		}

		public ITask GetTask()
		{
			return (ITask)this._brClass;
		}
			
		#endregion

		#region Eventos y Delegados		
		public event EventHandler KeyValueCajaOrigenChanged;		
		public event EventHandler KeyValueCajaDestinoChanged;		
		public event EventHandler ResponsableCajaOrigenChanged;		
		public event EventHandler ResponsableCajaDestinoChanged;
		public event EventHandler ValoresDisponiblesChanged;
		public event EventHandler ValoresATransferirChanged;
		public event EventHandler TotalATransferirChanged;

		#endregion

		#region Métodos privados
		private void Init()
		{
			InitializeData();
			InitEvents();
		}

		private void InitializeData() 
		{
			if (_brClass.TextoBotonAnterior.CompareTo( string.Empty ) != 0)
			{
				this._textoBotonPrevio = _brClass.TextoBotonAnterior;
			}
			if (_brClass.TextoBotonSiguiente.CompareTo( string.Empty) != 0)
			{
				this._textoBotonSiguiente = _brClass.TextoBotonSiguiente;
			}
			this._layoutDetalleValoresDisponibles = Build_LayoutDetalleDisponible();
			this._layoutDetalleValoresATransferir = Build_LayoutDetalleATransferir();			
		}

		private void InitEvents() 
		{
			_brClass.ObjectHasChanged+= new System.EventHandler( this.ListenerObjectHasChanged );			
		}

		private string Build_LayoutDetalleDisponible()
		{			
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );			
			sb.Append( LayoutBuilder.GetRow( i++, "IdValor", "IdValor",80, true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripción",100, Types.EditType.NoEdit ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Moneda", "Moneda",50, Types.EditType.NoEdit ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Número",60, Types.EditType.NoEdit ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Entidad", "Entidad",70, Types.EditType.NoEdit ) );
			sb.Append( LayoutBuilder.GetRow( i++, "ValorOrigen", "Importe",60, Types.Aligment.Near, Types.FormatDisplay.Money, Types.EditType.NoEdit) );
			sb.Append( LayoutBuilder.GetRow( i++, "ValorDestino", "Importe",60) );
			sb.Append( LayoutBuilder.GetRow( i++, "IdTDCompTesoreria", "IdTDCompTesoreria",80, true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "IdMoneda", "IdMoneda",80, true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Agrupado", "Agrupado",80, true ) );

			sb.Append( LayoutBuilder.GetFooter() );
			return sb.ToString();		
		}

		private string Build_LayoutDetalleATransferir()
		{			
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );

			sb.Append( LayoutBuilder.GetRow( i++, "IdValor", "IdValor",80, true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripción",100, Types.EditType.NoEdit ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Moneda", "Moneda",50, Types.EditType.NoEdit ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Número",60, Types.EditType.NoEdit ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Entidad", "Entidad",70, Types.EditType.NoEdit ) );			
			sb.Append( LayoutBuilder.GetRow( i++, "ValorDestino", "Importe",60, Types.Aligment.Near, Types.FormatDisplay.Money ) );

			sb.Append( LayoutBuilder.GetFooter() );
			return sb.ToString();		
		}


		private void ListenerObjectHasChanged(object sender, System.EventArgs e)
		{
			CallRefresh();
		}

		private void CallRefresh() 
		{						
			if (_keyValueCajaOrigen != _brClass.KeyValueCajaOrigen)
			{								
				_keyValueCajaOrigen = _brClass.KeyValueCajaOrigen;
				if (KeyValueCajaOrigenChanged != null) 
				{
					KeyValueCajaOrigenChanged(this, new EventArgs());	
				}
			}
			if (_keyValueCajaDestino != _brClass.KeyValueCajaDestino) 
			{								
				_keyValueCajaDestino = _brClass.KeyValueCajaDestino;
				if (KeyValueCajaDestinoChanged != null) 
				{
					KeyValueCajaDestinoChanged(this, new EventArgs());	
				}
			}
			if (_responsableCajaOrigen != _brClass.ResponsableCajaOrigen) 
			{								
				_responsableCajaOrigen = _brClass.ResponsableCajaOrigen;
				if (ResponsableCajaOrigenChanged != null) 
				{
					ResponsableCajaOrigenChanged(this, new EventArgs());	
				}
			}
			if (_responsableCajaDestino != _brClass.ResponsableCajaDestino) 
			{								
				_responsableCajaDestino = _brClass.ResponsableCajaDestino;
				if (ResponsableCajaDestinoChanged != null) 
				{
					ResponsableCajaDestinoChanged(this, new EventArgs());	
				}
			}
			
			/*if (_valoresDisponibles != _brClass.ValoresDisponibles) 
			{								
				_valoresDisponibles = _brClass.ValoresDisponibles;
				if (ValoresDisponiblesChanged != null) 
				{
					ValoresDisponiblesChanged(this, new EventArgs());	
				}
			}*/
			/*if (_valoresATransferir != _brClass.ValoresATransferir)
			{
				_valoresATransferir = _brClass.ValoresATransferir;
				if (ValoresATransferirChanged != null) 
				{
					ValoresATransferirChanged(this, new EventArgs());	
				}
			}*/
			if (_brClass.ValoresDisponibles != null)  
			{
				if (ValoresDisponiblesChanged != null) 
				{				
					ValoresDisponiblesChanged(this, new EventArgs());	
				}
			}
			if (_brClass.ValoresATransferir != null)  
			{
				if (ValoresATransferirChanged != null) 
				{				
					ValoresATransferirChanged(this, new EventArgs());	
				}
			}
			if (_totalATransferir != _brClass.TotalATransferir)				
			{								
				_totalATransferir = _brClass.TotalATransferir;
				if (TotalATransferirChanged != null) 
				{
					TotalATransferirChanged(this, new EventArgs());	
				}
			}
		}

		#endregion
			
		#region Métodos públicos

		public void Transferir(ArrayList array) 
		{
			_brClass.Transferir(array);
		}
		public void TransferirTodo() 
		{
			_brClass.TransferirTodo();
		}
		public void Remover(ArrayList array) 
		{
			_brClass.Remover(array);
		}
		public void RemoverTodo() 
		{
			_brClass.RemoverTodo();
		}
		public void RefreshDataOrigen() 
		{
			_brClass.RefreshDataOrigen();
		}
		public bool PuedoHabilitarBotonesTransferir()
		{
			bool result = false;
			if (_brClass.ValoresDisponibles != null) 
			{
				result = (_brClass.ValoresDisponibles.Count > 0 && _keyValueCajaDestino != null);
			}
			return result;			
			//return true;
		}
		public bool PuedoHabilitarBotonesRemover()
		{
			bool result = false;
			if (_brClass.ValoresATransferir != null) 
			{
				result = (_brClass.ValoresATransferir.Count > 0);
			}			
			return result;		
			//return true;
		}
		#endregion
		
		

	}
}
