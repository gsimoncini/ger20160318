using System;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using System.Data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de AjustarStockACero.
	/// </summary>
	public class AjustarStockACero
	{
		private string _idProducto = string.Empty;
		private string _idTipoDeAjuste = string.Empty;
		private string _idDeposito = string.Empty;
		private string _idSeccion = string.Empty;

		private DataTable _listaTipoDeAjuste = businessrules.tlg_TiposDeAjuste.GetList().tlg_TiposDeAjuste;
		private DataTable _listaDeposito = (DataTable) businessrules.tlg_Depositos.GetList().tlg_Depositos;
		private DataTable _listaSeccion = (DataTable) businessrules.tlg_Secciones.GetList().tlg_Secciones;		
		private DataRow _row;
		
		private string _view = "Sistema = true";

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

		public AjustarStockACero()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public void Execute() 
		{						
			businessrules.Stock.AjusteStock(ref _row, _idDeposito, _idSeccion, _idTipoDeAjuste, _idProducto);						
		
			
		}
	}
}
