using System;
using mz.erp.businessrules;
using System.Collections;
using System.Data;
using mz.erp.businessrules.comprobantes;
using System.Text;

using mz.erp.commontypes;

namespace mz.erp.ui.controllers	
{
	/// <summary>
	/// Descripción breve de AjusteDeStock.
	/// </summary>
	public class AjusteDeStockController: IObserver, ITaskController
	{
		
		#region Variables Privadas
		
		AjustarStock ajustar = new AjustarStock();
		private string _ordenReparacion = String.Empty;
		//private string _idProducto = string.Empty;
		private string _idTipoDeAjuste = string.Empty;		
		private string _idDeposito = string.Empty;
		private string _idSeccion = string.Empty;
		//private decimal _cantidad = 1;
		private string _leyendaFormulario = string.Empty;
		private Type _listaProductos = typeof (mz.erp.ui.controllers.tsh_Productos);
		private DataTable _listaTipoDeAjuste = null;
		private DataTable _listaDeposito = null;
		private DataTable _listaSeccion = null;		
		private DataRow _row;
		private string _tipoAjusteValueMember = "IdTipoAjuste";
		private string _depositoValueMember = "IdDeposito";
		private string _seccionValueMember = "IdSeccion";
		private string _tipoAjusteDisplayMember = "Descripcion";
		private string _depositoDisplayMember = "Descripcion";
		private string _seccionDisplayMember = "Descripcion";
		private string _view = "";
		private string _signo = string.Empty;
		private string _layout = string.Empty;
		private ArrayList _items = new ArrayList();
		private DataTable _tabla = null;
		public event EventHandler OnModelChanged;
		
		#endregion

		#region Eventos

		public event EventHandler IdTipoDeAjusteChanged;
		public event EventHandler ObservacionesChanged;
		
		#endregion

		#region Propiedades

		public bool AllowEditItems
		{
			get{return ajustar.AllowEditItems;}
		}

		public bool AllowAddItems
		{
			get{return ajustar.AllowAddItems;}
		}

		public bool AllowEditAjusteDeStock
		{
			get{return ajustar.AllowEditAjusteDeStock;}
		}

		public bool AllowEditSeccion
		{
			get{return ajustar.AllowEditSeccion;}
		}

		public bool AllowEditDeposito
		{
			get{return ajustar.AllowEditDeposito;}
		}

		public string Layout
		{
			get{return _layout;}
		}
		
		public string Signo
		{
			get{return _signo;}
		}

		public string LeyendaFormulario
		{
			get { return this._leyendaFormulario + ' ' + ajustar.OrdenReparacion; }
		}

		public bool PreguntarAlCancelar
		{
			get {return ajustar.PreguntarAlCancelar;}
		}

		public string TextoBotonSiguiente
		{
			get { return ajustar.TextoBotonSiguiente ; }
		}
		
		public string TextoBotonAnterior
		{
			get { return ajustar.TextoBotonAnterior; }
		}

		public string IdTipoDeAjuste
		{
			get { return _idTipoDeAjuste; }
			set 
			{
				if(_idTipoDeAjuste != value)
				{
					_idTipoDeAjuste = value ; 
					ajustar.IdTipoDeAjuste = value;
				}
			}
		}
		public string Observaciones
		{
			get { return ajustar.Observaciones; }
			set { ajustar.Observaciones = value;}
		}

		public string IdDeposito
		{
			get { return _idDeposito; }
			set { _idDeposito = value ; }
		}

		public string IdSeccion
		{
			get { return _idSeccion; }
			set { _idSeccion = value ; }
		}
		public string OrdenReparacion
		{
			get { return ajustar.OrdenReparacion; }
			set { ajustar.OrdenReparacion = value ; }
		}

		
		public int CantidadSecciones 
		{
			get {return _listaSeccion.Rows.Count; }			
		}

		public Type ListaProductos
		{
			get { return _listaProductos ; }		
		}

		public DataTable ListaTipoDeAjuste
		{			
			get { return ajustar.ListaTipoDeAjuste ; }					
		}		

		public DataTable ListaDeposito
		{
			get {return _listaDeposito ; }
			set { _listaDeposito = value ; }
		}		

		public DataTable ListaSeccion
		{
			get { return _listaSeccion ; }
			set { _listaSeccion = value ; }			
		}		

		public DataRow Row 
		{
			get {return _row;}
		}

		public string TipoAjusteValueMember
		{
			get { return _tipoAjusteValueMember; }
		}

		public string DepositoValueMember
		{
			get { return _depositoValueMember; }
		}

		public string SeccionValueMember
		{
			get { return _seccionValueMember; }
		}

		public string TipoAjusteDisplayMember
		{
			get { return _tipoAjusteDisplayMember; }
		}

		public string DepositoDisplayMember
		{
			get { return _depositoDisplayMember; }
		}

		public string SeccionDisplayMember
		{
			get { return _seccionDisplayMember; }
		}

		public string View
		{
			get { return _view; }
		}

		public int WidthSearchForm
		{
			get { return ajustar.WidthSearchForm ; }			
		}	

		
		public ArrayList Items 
		{
			get {return _items;}
			set {_items = value;}
		}

		
		public DataTable Tabla 
		{
			get {return _tabla;}
		}

		public string EstadoDeStock
		{
			get{return ajustar.EstadoDeStock;}
		}

		#endregion
		
		#region Constructores
		
		public AjusteDeStockController()
		{						
			Init();
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public AjusteDeStockController(AjustarStock model)
		{						
			ajustar = model;
			Init();
		}

		#endregion

		#region Metodos
			
		public void FiltroListaSecciones() 
		{			
			_listaSeccion = (DataTable) businessrules.tlg_Secciones.GetList(_idDeposito, true).tlg_Secciones;					
			_idSeccion = _listaSeccion.Rows[0]["IdSeccion"].ToString();
		}
		


		public DataTable ListaTipoDeAjustePositivo()
		{ 
			return ajustar.ListaTipoDeAjuste;
		}

		public DataTable ListaTipoDeAjusteNegativo()
		{
			return ajustar.ListaTipoDeAjuste;
		}


		
		public bool IsValid() 
		{
			return ajustar.IsValid();
		}

		public void Execute() 
		{												
			ajustar.Items = _items;
			ajustar.IdDeposito = _idDeposito;
			ajustar.IdSeccion = _idSeccion;
			//ajustar.IdTipoDeAjuste = _idTipoDeAjuste;
			ajustar.OrdenReparacion = _ordenReparacion;
			ajustar.Execute();				
		}

		private void Init() 
		{	
			_ordenReparacion = ajustar.OrdenReparacion;					
			_listaDeposito = ajustar.ListaDeposito;
			_listaSeccion = ajustar.ListaSeccion;
			_idDeposito = ajustar.IdDeposito;
			_idSeccion = ajustar.IdSeccion;
			_idTipoDeAjuste = ajustar.IdTipoDeAjuste;			
			_signo = ajustar.Signo;
			_view = ajustar.View;		
			SetLeyendaFormulario();
			ajustar.ObjectHasChanged +=new EventHandler(ajustar_ObjectHasChanged);
			ajustar.IdTipoDeAjusteChanged +=new EventHandler(ajustar_IdTipoDeAjusteChanged);
			SetLayout();
		}


		
		private void SetLeyendaFormulario()
		{
			
			string leyenda = Variables.GetValueString( "Momentos."  +  ajustar.GetTaskName()+ "."+ ajustar.GetProcessManagerParent().Process.ProcessName + ".LeyendaFormulario" );
			if(leyenda.Equals(string.Empty))
				leyenda = Variables.GetValueString( "Momentos." + ajustar.GetTaskName()+".LeyendaFormulario" );
			if(leyenda.Equals(string.Empty))
				{
					leyenda = ajustar.GetTaskName();
				}
			this._leyendaFormulario = leyenda;
		}

		#endregion

		#region Miembros de IObserver

		public void UpdateObject(object sender, object valores)
		{			
			if ((valores.GetType()) == typeof(System.Collections.ArrayList))
			{				
				ArrayList lista = (ArrayList)valores;				
				foreach ( mz.erp.businessrules.comprobantes.Item item in lista )
				{					
					ItemAjuste itemAj = new ItemAjuste();
					itemAj.Cantidad = item.Cantidad;
					itemAj.IdProducto = item.IdProducto;		
					itemAj.Codigo = item.Codigo;
					itemAj.CodigoSecundario = item.CodigoSecundario;
					itemAj.Descripcion = item.Descripcion;
					DataRow row = mz.erp.businessrules.tsh_ProductosSucursales.GetByPk(item.IdProducto, Security.IdSucursal, Security.IdEmpresa);
					if(row != null)
						itemAj.StockDisponible = Convert.ToDecimal(row["StockDisponible"]);
					else itemAj.StockDisponible =0;
					_items.Add(itemAj);
				}
				if (OnModelChanged != null) OnModelChanged(this, new System.EventArgs());
			}
		}

		#endregion

		#region Miembros de ITaskController
		private ProcessControllerManager _processManager;

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
			return this._processManager.IsFirstTask(ajustar.GetTaskName());
		}

		public string GetTaskName()
		{
			return ajustar.GetTaskName();
		}


		public bool IsLastTask()
		{					
			return this._processManager.IsLastTask(ajustar.GetTaskName());
		}

		
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
			return ajustar.AllowPrevious();
		}

		public void Previous()
		{
			ajustar.Previous();
		}


		public ITask GetTask()
		{
			return ajustar;
		}


		public bool AllowShow()
		{
			return ajustar.AllowShow();
		}
		
		public event EventHandler OnTaskBeforeExecute;
		
		public void ListenerAfterExecute( object sender, System.EventArgs e)
		{
			_ordenReparacion = 	ajustar.OrdenReparacion;
		}
		public ItemsDatasetErrors GetErrors()
		{
			return 	ajustar.GetErrors();
		}
		public string GetWarnings()
		{
			return 	ajustar.GetWarnings();
		}
		public void Continue()
		{
			ajustar.Execute();
		}

									   
		#endregion

		private void ajustar_ObjectHasChanged(object sender, EventArgs e)
		{
			_items = ajustar.Items;
			if (OnModelChanged != null) OnModelChanged(this, new System.EventArgs());
		}


		private void SetLayout()
		{
			int i = 0;
			StringBuilder sb = new StringBuilder();
			if(ajustar.GetProcessManagerParent().Process.ProcessName.Equals("ProcesoTransferenciaMercaderiaAST"))
			{
				sb.Append( LayoutBuilder.GetHeader() );			
				sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Código", 75, Types.EditType.NoEdit) );
				sb.Append( LayoutBuilder.GetRow( i++, "CodigoSecundario", "Código secundario", 100, Types.EditType.NoEdit) );
				sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripción", 400, Types.EditType.NoEdit) );
				sb.Append( LayoutBuilder.GetRow( i++, "CantidadPedida", "Cant. Pedida",80, Types.EditType.NoEdit) );
				sb.Append( LayoutBuilder.GetRow( i++, "CantidadReservada", "Cant. Reserv.",80, Types.EditType.NoEdit) );
				sb.Append( LayoutBuilder.GetRow( i++, "CantidadPendiente", "Pendiente",80,  Types.EditType.NoEdit) );
				sb.Append( LayoutBuilder.GetRow( i++, "Cantidad", "Cantidad",60, Types.Aligment.Far, Types.FormatDisplay.Integer, Types.EditType.Custom) );
				sb.Append( LayoutBuilder.GetRow( i++, "StockDisponible", "Stock",60, Types.EditType.NoEdit) );
				sb.Append( LayoutBuilder.GetFooter() );
			}
			else
			{
				sb.Append( LayoutBuilder.GetHeader() );			
				sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Código", 100, Types.EditType.NoEdit) );
				sb.Append( LayoutBuilder.GetRow( i++, "CodigoSecundario", "Código secundario", 100, Types.EditType.NoEdit) );
				sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripción", 500, Types.EditType.NoEdit) );
				if(ajustar.GetProcessManagerParent().Process.ProcessName.Equals("ProcesoDevolucionMercaderiaAST"))
				{
					sb.Append( LayoutBuilder.GetRow( i++, "Cantidad", "Cantidad",60, Types.Aligment.Far, Types.FormatDisplay.Integer, Types.EditType.NoEdit) );
				}
				else 
				{
					sb.Append( LayoutBuilder.GetRow( i++, "Cantidad", "Cantidad",60, Types.Aligment.Far, Types.FormatDisplay.Integer, Types.EditType.Custom) );
				}
				sb.Append( LayoutBuilder.GetRow( i++, "StockDisponible", "Stock",60, Types.EditType.NoEdit) );
				
				
				sb.Append( LayoutBuilder.GetFooter() );
			}
			_layout =  sb.ToString();		
		}

		private void ajustar_IdTipoDeAjusteChanged(object sender, EventArgs e)
		{
			if(IdTipoDeAjusteChanged != null)
				IdTipoDeAjusteChanged(this, new EventArgs());
		}
	}
	
}
