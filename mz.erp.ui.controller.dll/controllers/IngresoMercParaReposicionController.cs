using System;
using System.Data;
using mz.erp.businessrules;


namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de IngresoMercParaReposicionController.
	/// </summary>
	public class IngresoMercParaReposicionController
	{

		IngresarMercParaReposicion ajustar = new IngresarMercParaReposicion();

		private string _idProducto = string.Empty;
		private string _idTipoDeAjuste = string.Empty;
		private string _idDeposito = string.Empty;
		private string _idSeccion = string.Empty;
		private decimal _cantidad = 1;

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

		public int WidthSearchForm
		{
			get { return ajustar.WidthSearchForm ; }			
		}	

		public string IdProducto
		{
			get { return _idProducto; }
			set { _idProducto = value ; }
		}

		public string IdTipoDeAjuste
		{
			get { return _idTipoDeAjuste; }
			set { _idTipoDeAjuste = value ; }
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

		public int CantidadSecciones 
		{
			get {return _listaSeccion.Rows.Count; }					
		}

		
		public decimal Cantidad
		{
			get { return _cantidad ; }
			set { _cantidad = value ; }
		}
        
		public Type ListaProductos
		{
			get { return _listaProductos ; }
			//set { _listaProductos = value ; }
		}

		public DataTable ListaTipoDeAjuste
		{
			get { return _listaTipoDeAjuste ; }
			//set { _listaTipoDeAjuste = value ; }
		}		

		public DataTable ListaDeposito
		{
			get 
			{
				if (_listaDeposito.Rows.Count == 1) 
				{
					_idDeposito = _listaDeposito.Rows[0]["IdDeposito"].ToString();
				}
				else 
				{
					_idDeposito = string.Empty;
				}
				return _listaDeposito ; 
			}
			//set { _listaDeposito = value ; }
		}		

		public DataTable ListaSeccion
		{
			get 
			{ 				
				if (_listaSeccion.Rows.Count == 1) 
				{
					_idSeccion = _listaSeccion.Rows[0]["IdSeccion"].ToString();
				}
				else 
				{
					_idSeccion = string.Empty;
				}
				return _listaSeccion ; 
			}
			//set { _listaSeccion = value ; }
		}		

		public DataRow Row
		{
			get {return _row;}
		}

		public string TipoAjusteValueMember
		{
			get { return _tipoAjusteValueMember; }
			//set { _tipoAjusteValueMember = value ; }
		}

		public string DepositoValueMember
		{
			get { return _depositoValueMember; }
			//set { _depositoValueMember = value ; }
		}

		public string SeccionValueMember
		{
			get { return _seccionValueMember; }
			//set { _seccionValueMember = value ; }
		}

		public string TipoAjusteDisplayMember
		{
			get { return _tipoAjusteDisplayMember; }
			//set { _tipoAjusteDisplayMember = value ; }
		}

		public string DepositoDisplayMember
		{
			get { return _depositoDisplayMember; }
			//set { _depositoDisplayMember = value ; }
		}

		public string SeccionDisplayMember
		{
			get { return _seccionDisplayMember; }
			//set { _seccionDisplayMember = value ; }
		}

		public string View
		{
			get { return _view; }
			//set { _seccionDisplayMember = value ; }
		}



		public IngresoMercParaReposicionController()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			Init();
		}

		public DataTable ListaTipoDeAjusteByDescripcion()
		{ 
			DataTable _listaAjustes = (DataTable) businessrules.tlg_TiposDeAjuste.GetByDescripcion().tlg_TiposDeAjuste;
							
			return _listaAjustes;
		}


		public void FiltroListaSecciones() 
		{			
			_listaSeccion = (DataTable) businessrules.tlg_Secciones.GetList(_idDeposito, true).tlg_Secciones;					
			_idSeccion = _listaSeccion.Rows[0]["IdSeccion"].ToString();
		}

		public bool HasErrors() 
		{
			if (_row.HasErrors){return true;}
			else {return false;}						
		}

		public void Execute() 
		{									
			ajustar.Row = _row;
			ajustar.IdDeposito = _idDeposito;
			ajustar.IdSeccion = _idSeccion;
			ajustar.IdTipoDeAjuste = _idTipoDeAjuste;
			ajustar.IdProducto = _idProducto;	
			ajustar.Cantidad = _cantidad;
			ajustar.Execute();			
			_row = ajustar.Row;			
		}

		private void Init() 
		{			
			_listaTipoDeAjuste = ajustar.ListaTipoDeAjuste;
			_listaDeposito = ajustar.ListaDeposito;
			_listaSeccion = ajustar.ListaSeccion;
			_view = ajustar.View;			
		}
	}
}
