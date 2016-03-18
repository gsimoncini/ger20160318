using System;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using System.Data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de IngresarMercParaReposicion.
	/// </summary>
	public class IngresarMercParaReposicion
	{
		private string _idProducto = string.Empty;
		private string _idTipoDeAjuste = string.Empty;
		private string _idDeposito = string.Empty;
		private string _idSeccion = string.Empty;
		private decimal _cantidad = 0;
		

		private DataTable _listaTipoDeAjuste = businessrules.tlg_TiposDeAjuste.GetList().tlg_TiposDeAjuste;
		private DataTable _listaDeposito = (DataTable) businessrules.tlg_Depositos.GetList().tlg_Depositos;
		private DataTable _listaSeccion = (DataTable) businessrules.tlg_Secciones.GetList().tlg_Secciones;		
		private DataRow _row;
		private string _view = "Sistema = true";
		private int _widthSearchForm = Convert.ToInt16(Variables.GetValue("Productos.Busquedas.Ancho"));

		public int WidthSearchForm
		{
			get { return _widthSearchForm ; }			
		}		

		public DataTable ListaTipoDeAjuste
		{
			get { return _listaTipoDeAjuste ; }
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
		}		

		public DataRow Row
		{
			get {return _row;}		
			set {_row = value;}
		}

		public string View
		{
			get {return _view;}
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

		public decimal Cantidad
		{
			get { return _cantidad ; }
			set { _cantidad = value ; }
		}


		public IngresarMercParaReposicion()
		{
		}
		
		
		public void Execute() 
		{						
			//businessrules.Stock.AjusteStock(ref _row, _idDeposito, _idSeccion, _idTipoDeAjuste, _idProducto, _cantidad);						
		}
	}
}
