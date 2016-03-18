using System;
using System.Data;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.systemframework;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de StockNDias.
	/// </summary>
	public class StockNDias : ITask
	{
		
		#region Constructores

		public StockNDias()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		#endregion

		#region Variables Privadas
		
			private string _idProducto = string.Empty;
			private string _codigo = string.Empty;
			private ArrayList _idjerarquia5 = new ArrayList();
			private ArrayList _idjerarquia1 = new ArrayList();
			private ArrayList _idjerarquia2 = new ArrayList();
			private ArrayList _idjerarquia3 = new ArrayList();
			private ArrayList _idjerarquia4 = new ArrayList();
			private ArrayList _idjerarquia6 = new ArrayList();
			private ArrayList _idjerarquia7 = new ArrayList();
			private ArrayList _idjerarquia8 = new ArrayList();
			private string _idProveedor = string.Empty;
		    private string _codigoProveedor = string.Empty;
			private DateTime _fechaDesde = DateTime.Now.AddDays(-30);
			private DateTime _fechaHasta = DateTime.Now;
			private int _dias = 1;
		    private bool _precioUltimaCompra = true;
		    private bool _precioUltimaCompraProveedor = false;
		    private bool _precioDeListaProveedor = false;
		    private DataTable _result = new DataTable();
			private bool _byHierarchy = false;
			private bool _byJerarquia1 = false;
			private bool _byJerarquia2 = false;
			private bool _byJerarquia3 = false;
			private bool _byJerarquia4 = false;
			private bool _byJerarquia5 = false;
			private bool _byJerarquia6 = false;
			private bool _byJerarquia7 = false;
			private bool _byJerarquia8 = false;
			private bool _allowMultipleSelect = false;
			private bool _validaProveedor = false;

		//German 20090413
		private bool _seleccionPorCantidad = true;
		//Fin German 20090413


		#endregion

		#region Propiedades

		//German 20090413
		public bool SeleccionPorCantidad 
		{
			get
			{
				return _seleccionPorCantidad;
			}
		}
		//Fin German 20090413

		public bool AllowMultipleSelect
		{
			get{return _allowMultipleSelect;}
		}


		public bool ByJerarquia1
		{
			get{return _byJerarquia1;}
			set
			{
				if(value != _byJerarquia1)
				{
					_byJerarquia1 = value;
					
				}
			}
		}

		public bool ByJerarquia2
		{
			get{return _byJerarquia2;}
			set
			{
				if(value != _byJerarquia2)
				{
					_byJerarquia2 = value;
					
				}
			}
		}

		public bool ByJerarquia3
		{
			get{return _byJerarquia3;}
			set
			{
				if(value != _byJerarquia3)
				{
					_byJerarquia3 = value;
					
				}
			}
		}

		public bool ByJerarquia4
		{
			get{return _byJerarquia4;}
			set
			{
				if(value != _byJerarquia4)
				{
					_byJerarquia4= value;
					
				}
			}
		}

		public bool ByJerarquia5
		{
			get{return _byJerarquia5;}
			set
			{
				if(value != _byJerarquia5)
				{
					_byJerarquia5 = value;
					
				}
			}
		}

		public bool ByJerarquia6
		{
			get{return _byJerarquia6;}
			set
			{
				if(value != _byJerarquia6)
				{
					_byJerarquia6 = value;
					
				}
			}
		}

		public bool ByJerarquia7
		{
			get{return _byJerarquia7;}
			set
			{
				if(value != _byJerarquia7)
				{
					_byJerarquia7= value;
					
				}
			}
		}

		public bool ByJerarquia8
		{
			get{return _byJerarquia8;}
			set
			{
				if(value != _byJerarquia8)
				{
					_byJerarquia8 = value;
					
				}
			}
		}

		

		public bool ByHierarchy
		{
			set{_byHierarchy = value;}
		}

		public string IdProducto
		{
			get{return _idProducto;}
			set{_idProducto = value;}
		}

		public string Codigo
		{
			get{return _codigo;}
			set{
				if(value !=  null && !value.Equals(string.Empty))
				{
					if(_codigo != value)
					{
						_codigo = value;
						_idProducto = mz.erp.businessrules.tsh_Productos.GetPkByCodigo(_codigo);
					}
				}
				else
				{
					_codigo = string.Empty;
					_idProducto = string.Empty;
				}
			
			}
		}

		
		public ArrayList IdJerarquia1
		{
			get{return _idjerarquia1;}
			set{_idjerarquia1 = value;}
		}

		public ArrayList IdJerarquia2
		{
			get{return _idjerarquia2;}
			set{_idjerarquia2 = value;}
		}

		public ArrayList IdJerarquia3
		{
			get{return _idjerarquia3;}
			set{_idjerarquia3 = value;}
		}

		public ArrayList IdJerarquia4
		{
			get{return _idjerarquia4;}
			set{_idjerarquia4 = value;}
		}

		public ArrayList IdJerarquia5
		{
			get{return _idjerarquia5;}
			set{_idjerarquia5 = value;}
		}


		public ArrayList IdJerarquia6
		{
			get{return _idjerarquia6;}
			set{_idjerarquia6 = value;}
		}

		public ArrayList IdJerarquia7
		{
			get{return _idjerarquia7;}
			set{_idjerarquia7 = value;}
		}

		public ArrayList IdJerarquia8
		{
			get{return _idjerarquia8;}
			set{_idjerarquia8 = value;}
		}

		public ArrayList Jerarquias
		{
			get
			{
				ArrayList jerarquias = new ArrayList();
				jerarquias.AddRange(_idjerarquia1);
				jerarquias.AddRange(_idjerarquia2);
				jerarquias.AddRange(_idjerarquia3);
				jerarquias.AddRange(_idjerarquia4);
				jerarquias.AddRange(_idjerarquia5);
				jerarquias.AddRange(_idjerarquia6);
				jerarquias.AddRange(_idjerarquia7);
				jerarquias.AddRange(_idjerarquia8);
				return jerarquias;
			}
		}

		public string IdProveedor
		{
			get{return _idProveedor;}
			/*set{_idProveedor = value;}*/
		}

		public string CodigoProveedor
		{
			get{return _codigoProveedor;}
			set
			{
				_codigoProveedor = value;
				Proveedor proveedor = new Proveedor();
				proveedor.GetCuenta_CodigoProveedor(_codigoProveedor);
				_idProveedor = proveedor.IdProveedor;
			}		
		}

		public DateTime FechaDesde
		{
			get{return _fechaDesde;}
			set{_fechaDesde = value;}
		}

		public DateTime FechaHasta
		{
			get{return _fechaHasta;}
			set{_fechaHasta = value;}
		}

		public int Dias
		{
			get{return _dias;}
			set{_dias = value;}
		}

		public bool PrecioUltimaCompra
		{
			get{return _precioUltimaCompra;}
			set{_precioUltimaCompra = value;}
		}

		public bool PrecioUltimaCompraProveedor
		{
			get{return _precioUltimaCompraProveedor;}
			set{_precioUltimaCompraProveedor = value;}
		}

		public bool PrecioDeListaProveedor
		{
			get{return _precioDeListaProveedor;}
			set{_precioDeListaProveedor = value;}
		}


		public DataTable Result
		{
			get{return _result;}
		}


		#endregion

		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;

		public event System.EventHandler OnTaskAfterPrevious;


		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent = null;

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
			_allowMultipleSelect = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "AllowMultipleSelect");
			_validaProveedor = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "Validar.Proveedor");
			//German 20090413
			_seleccionPorCantidad = Variables.GetValueBool(this._processParent.Process.ProcessName, this.GetTaskName(), "SeleccionPorCantidad", _seleccionPorCantidad);
			//Fin German 20090413
			
		}

		public bool IsValid()
		{			
			ValidarDatos();
			if (_errores.Count > 0)
				return false;
			else
				return true;
		}

		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
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
			
			return null;
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
			return _taskName;
		}

		public void SetTaskName(string taskName)
		{
			_taskName = taskName;
		}

		public void Execute()
		{
			if(OnTaskBeforeExecute != null)
				OnTaskBeforeExecute(this, new EventArgs());			

			this.IsValid();

			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}

		public bool AllowPrevious()
		{
			return true;
		}

		public void Previous()
		{
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
		}

		public void ListenerAfterPreviousDependentTask(object sender)
		{
			// TODO: agregar la implementación StockNDias.ListenerAfterPreviousDependentTask
		}

		public void ListenerBeforePreviousDependentTask(object sender)
		{
			// TODO: agregar la implementación StockNDias.ListenerBeforePreviousDependentTask
		}

		#endregion

		#region Metodos publicos

        //Cristian Tsrea 0000050 20110310
        public void updateFechas(DateTime fecha, bool ordenInverso)
        {
            long dias = Variables.GetValueLong(this._processParent.Process.ProcessName, this._taskName, "RangoFechas.DiasAnteriores");
            if (!ordenInverso)
            { this._fechaDesde = fecha; }
            else { this._fechaHasta = fecha; };

            if (!ordenInverso)
            {
                if (this.FechaHasta < fecha)
                {
                    _fechaHasta = Util.GenerateFechaHasta(fecha, dias);
                }
            }
            else
            {
                if (this.FechaDesde > fecha)
                {
                    _fechaDesde = Util.GenerateFechaHasta(fecha, dias);
                }

            }//End ELSE
        }
        //Fin Cristian
		public void RefreshData()
		{
			if(_byHierarchy)
			{
				string j1 = BuildJerarquia(_idjerarquia1);
				string j2 = BuildJerarquia(_idjerarquia2);
				string j3 = BuildJerarquia(_idjerarquia3);
				string j4 = BuildJerarquia(_idjerarquia4);
				string j5 = BuildJerarquia(_idjerarquia5);
				string j6 = BuildJerarquia(_idjerarquia6);
				string j7 = BuildJerarquia(_idjerarquia7);
				string j8 = BuildJerarquia(_idjerarquia8);

				//bool[] aux = new bool[8]{_byJerarquia1, _byJerarquia2, _byJerarquia3, _byJerarquia4, _byJerarquia5, _byJerarquia6, _byJerarquia7, _byJerarquia8};
				string[] jerarquias = new string[8]{_byJerarquia1?j1:string.Empty,_byJerarquia2?j2:string.Empty,_byJerarquia3?j3:string.Empty,_byJerarquia4?j4:string.Empty,_byJerarquia5?j5:string.Empty,_byJerarquia6?j6:string.Empty,_byJerarquia7?j7:string.Empty,_byJerarquia8?j8:string.Empty };
				/*
				string[] jers = new string[8]{string.Empty,string.Empty,string.Empty,string.Empty,string.Empty,string.Empty,string.Empty,string.Empty};
				for(int i = 0; i<8;i++)
				{
					if(aux[i])
					{
						for(int j = 0; j<8; j++)
						{
							if(jers[j] == string.Empty)
							{
								jers[j] = jerarquias[i];
								break;
							}
						}
					}
				}
				*/
				j1 = jerarquias[0];
				j2 = jerarquias[1];
				j3 = jerarquias[2];
				j4 = jerarquias[3];
				j5 = jerarquias[4];
				j6 = jerarquias[5];
				j7 = jerarquias[6];
				j8 = jerarquias[7];
				_result = mz.erp.dataaccess.reportes.rep_ListadoStockNDias.GetList(string.Empty, j1, j2 ,j3, j4, j5,j6,j7,j8, this.FechaDesde, this.FechaHasta, this.Dias, this.IdProveedor, this.PrecioUltimaCompra, this.PrecioUltimaCompraProveedor, this.PrecioDeListaProveedor);
				if (this._processParent.Process.ProcessName.Equals("ProcesoConsultarStockNDiasIngresarPreOrdenDeCompra"))
					_result = AddColumn.AddColumnToTable(_result, "Ordenar", false);

			}
			else
			{
				_result = mz.erp.dataaccess.reportes.rep_ListadoStockNDias.GetList(this.IdProducto, null,null,null,null,null, null,null,null,this.FechaDesde, this.FechaHasta, this.Dias, this.IdProveedor, this.PrecioUltimaCompra, this.PrecioUltimaCompraProveedor, this.PrecioDeListaProveedor);
				if (this._processParent.Process.ProcessName.Equals("ProcesoConsultarStockNDiasIngresarPreOrdenDeCompra"))
					_result = AddColumn.AddColumnToTable(_result, "Ordenar", false);

			}
			if(ObjectHasChanged != null)
				ObjectHasChanged(this, new EventArgs());
		}


		private string BuildJerarquia(ArrayList je)
		{
				
			ArrayList narray = new ArrayList();
			foreach (object item in je) 
			{
				ItemJerarquia it = (ItemJerarquia) item;
				narray.Add(it.NodeKey);				
			}
			return mz.erp.systemframework.Util.PackString(narray);
		}


		public string GetIdProveedor()
		{
			if(this.IdProveedor == null || this.IdProveedor.Equals(string.Empty))
			{
				string proveedor = string.Empty;
				bool igualProv = true;
				int i = 0;
				while(igualProv && i < _result.Rows.Count)
				{
					DataRow row = _result.Rows[i];
					if((bool)row["Ordenar"])
					{
						if(proveedor.Equals(string.Empty))
							proveedor = _result.Rows[i]["Proveedor"].ToString();
						string proveedorRow = row["Proveedor"].ToString();
						igualProv = proveedor.Equals(proveedorRow);
					}
					i++;
				}
				if(igualProv && !proveedor.Equals(string.Empty))
                    return tpu_Proveedores.GetPKByNombre(proveedor);
				else
					return string.Empty;

			}
			else
				return this.IdProveedor;
		}

		public string GetIdMonedaPrecioDeCosto()
		{
            string idMoneda = string.Empty;
			bool igualMoneda = true;
			int i = 0;
			while(igualMoneda && i < _result.Rows.Count)
			{
				DataRow row = _result.Rows[i];
				if((bool)row["Ordenar"])
				{
					if(idMoneda.Equals(string.Empty))
						idMoneda = _result.Rows[i]["IdMonedaPrecioDeCosto"].ToString();
					string idMonedaRow = row["IdMonedaPrecioDeCosto"].ToString();
					igualMoneda = idMoneda.Equals(idMonedaRow);
				}
				i++;
			}
			if(igualMoneda && !idMoneda.Equals(string.Empty))
				return idMoneda;
			else
				return string.Empty;

		}

		public string GetIdFuenteDeCambioPrecioDeCosto()
		{
			string idFuenteC = string.Empty;
			bool igualFuenteC = true;
			int i = 0;
			while(igualFuenteC && i < _result.Rows.Count)
			{
				DataRow row = _result.Rows[i];
				if((bool)row["Ordenar"])
				{
					if(idFuenteC.Equals(string.Empty))
						idFuenteC = _result.Rows[i]["IdFuenteDeCambio"].ToString();
					string idFuenteCRow = row["IdFuenteDeCambio"].ToString();
					igualFuenteC = idFuenteC.Equals(idFuenteCRow);
				}
				i++;
			}
			if(igualFuenteC && !idFuenteC.Equals(string.Empty))
				return idFuenteC;
			else
				return string.Empty;

		}

		public decimal GetValorCotizacionPrecioDeCosto()
		{
			decimal valorCot = 0;
			bool igualValorCot = true;
			int i = 0;
			while(igualValorCot && i < _result.Rows.Count)
			{
				DataRow row = _result.Rows[i];
				if((bool)row["Ordenar"])
				{
					//German 20090421
					if(valorCot == 0)
						if(!_result.Rows[i].IsNull("ValorCotizacionPrecioDeCosto"))
							valorCot = (decimal)_result.Rows[i]["ValorCotizacionPrecioDeCosto"];
					decimal valorCotRow = 0;
					if(!row.IsNull("ValorCotizacionPrecioDeCosto"))
						valorCotRow = (decimal) row["ValorCotizacionPrecioDeCosto"];
					igualValorCot = valorCot == valorCotRow;
					//Fin German 20090421
				}
				i++;
			}
			if(igualValorCot && valorCot != 0)
				return valorCot;
			else
				return 0;

		}
		#endregion

		#region Metodos privados

		private void ValidarDatos()
		{
			_errores.Clear();
			if(this._processParent.Process.ProcessName.Equals("ProcesoConsultarStockNDiasIngresarPreOrdenDeCompra"))
			{
				string idProv = this.GetIdProveedor();
				if(idProv.Equals(string.Empty))
				{
					Hashtable ht = new Hashtable();
					ArrayList codProdConErrores = new ArrayList();
					foreach(DataRow row in _result.Rows)
					{
						if(/*(bool)row["Ordenar"]*/ Convert.ToDecimal(row["CantidadAComprar"]) > 0)
						{
							string idProd = row["IdProducto"].ToString();
							string proveedor = row["Proveedor"].ToString();
							if(!ht.ContainsKey(idProd))
								ht.Add(idProd, proveedor);
							else
							{
								string provEx = ht[idProd].ToString();
								if(!proveedor.Equals(provEx))
								{
									string cod = row["Codigo"].ToString();
									if(!codProdConErrores.Contains(cod))
									{
										codProdConErrores.Add(cod);
										_errores.Add( new ItemDatasetError( "Stock N Dias","Proveedor","El producto " + cod + "  tiene proveedores distintos") );
									}
								}
							}
						}
					}
					if(_validaProveedor && idProv.Equals(string.Empty))
						_errores.Add( new ItemDatasetError( "Stock N Dias","Proveedor","Todos los productos seleccionados deben tener el mismo proveedor") );
				}
			}

		}
		#endregion

		public bool PreguntarAlCancelar
		{
			get 
			{
				bool _preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar",false);
				return _preguntarAlCancelar ;}
		}

	}
}
