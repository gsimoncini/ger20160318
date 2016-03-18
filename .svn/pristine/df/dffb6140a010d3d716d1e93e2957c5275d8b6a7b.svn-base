using System;
using System.Data;
using mz.erp.businessrules.comprobantes;
using mz.erp.commontypes.data;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.commontypes.Collections;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ModificarProductosMasivo.
	/// </summary>
	public class ModificarProductosMasivo: ITask, IPersistentTask
	{
		#region Constructores
		public ModificarProductosMasivo()
		{
		}
		#endregion

		#region Variables Privadas
		private ProductoView _producto;
		private ArrayList _productos;
		private bool _seleccionMultilple = false;
		private DataSet _dataProductos = new tsh_ProductosDataset();
		private tpu_ProveedoresProductosDataset _dataProveedoresProductos = new tpu_ProveedoresProductosDataset();
		private bool _huboCambios = false;
		private string _state = "A";

        /* Silvina 20110630 - Tarea 0000136 */
        private tsh_ProductosAuxiliaresDataset _dataProductosAuxiliares = new tsh_ProductosAuxiliaresDataset();
        /* Fin Silvina 20110630 - Tarea 0000136 */

		#endregion

		#region Eventos
		public event EventHandler ProductosCollectionChanged;
		#endregion

		#region Variables Publicas

		
		public string State
		{
			set{_state = value;}
		}

		public bool Selected
		{
			get
			{
				if(_producto != null)
				{

					return _producto.Selected;
				}
				return false;
			}
			set
			{
				if(_producto != null)
				{

					_producto.Selected = value;
				}
				
			}
		}

		ArrayList _jerarquiasCampoAuxiliar6 = new ArrayList();
		public ArrayList JerarquiasCampoAuxiliar6
		{
			get
			{
                if(_producto != null)
				{
					return _producto.JerarquiasCampoAuxiliar6;
				}
				return new ArrayList();
			}
		}

		public ArrayList ProductosJerarquiasCampoAuxiliar6
		{
			get
			{
				
				ArrayList aux = new ArrayList();
				ArrayList result = new ArrayList();
				foreach(ProductoView prod in _productos)
				{
					foreach(ItemJerarquia ij in prod.JerarquiasCampoAuxiliar6)
					{
						if(!aux.Contains(ij.NodeKey))
						{
							aux.Add(ij.NodeKey);
							result.Add(ij);
						}
					}
				}
				return result;
			}
		}

		public ArrayList Items
		{
			get{return _productos;}
		}

		public object SelectedItem
		{
			set
			{
				if(value != null)
				{
					ProductoView prod = (ProductoView) value;
					if(prod != _producto)
					{
						_producto = prod;
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
				}
								
			}
		}

		public ArrayList Productos
		{
			get{return _productos;}
		}

		public bool SeleccionMultiple
		{
			get{return _seleccionMultilple;}
			set
			{
				_seleccionMultilple = value;
			}
		}

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

		
		public bool PreguntarAlCancelar
		{
			get 
			{
				bool _preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar",false);
				return _preguntarAlCancelar ;}
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

		public string IdProveedorDefault
		{
			get
			{
				if(_producto != null)
				{
					return _producto.IdProveedorDefault;
				}
				return string.Empty;

			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.IdProveedorDefault)
					{
						_producto.IdProveedorDefault = value;
						
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
						_huboCambios = true;
					}
					if(_seleccionMultilple)
					{
						foreach(ProductoView prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.IdProveedorDefault = value;
						}
					}
				}
				
			}
		}

		public string Observaciones
		{
			get
			{
				if(_producto != null)
				{
					return _producto.Observaciones;
				}
				return string.Empty;

			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.Observaciones)
					{
						_producto.Observaciones = value;
						
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
						_huboCambios = true;
					}
					if(_seleccionMultilple)
					{
                        foreach(ProductoView prod in _productos)
						{
                            if(prod != _producto)
								if(prod.Selected)
									prod.Observaciones = value;
						}
					}
				}
				
			}
		}


		public string CampoAuxiliar1
		{
			get
			{
				if(_producto != null)
				{
					return _producto.CampoAuxiliar1;
				}
				return string.Empty;

			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.CampoAuxiliar1)
					{
						_producto.CampoAuxiliar1 = value;
						
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
						_huboCambios = true;
					}
					if(_seleccionMultilple)
					{
						foreach(ProductoView prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.CampoAuxiliar1 = value;
						}
					}
				}
				
			}
		}

		public string CampoAuxiliar2
		{
			get
			{
				if(_producto != null)
				{
					return _producto.CampoAuxiliar2;
				}
				return string.Empty;

			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.CampoAuxiliar2)
					{
						_producto.CampoAuxiliar2 = value;
						
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
						_huboCambios = true;
					}
					if(_seleccionMultilple)
					{
						foreach(ProductoView prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.CampoAuxiliar2 = value;
						}
					}
				}
				
			}
		}

		public string CampoAuxiliar3
		{
			get
			{
				if(_producto != null)
				{
					return _producto.CampoAuxiliar3;
				}
				return string.Empty;

			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.CampoAuxiliar3)
					{
						_producto.CampoAuxiliar3 = value;
						
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
						_huboCambios = true;
					}
					if(_seleccionMultilple)
					{
						foreach(ProductoView prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.CampoAuxiliar3 = value;
						}
					}
				}
				
			}
		}

		public string CampoAuxiliar4
		{
			get
			{
				if(_producto != null)
				{
					return _producto.CampoAuxiliar4;
				}
				return string.Empty;

			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.CampoAuxiliar4)
					{
						_producto.CampoAuxiliar4 = value;
						
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
						_huboCambios = true;
					}
					if(_seleccionMultilple)
					{
						foreach(ProductoView prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.CampoAuxiliar4 = value;
						}
					}
				}
				
			}
		}

		public string CampoAuxiliar5
		{
			get
			{
				if(_producto != null)
				{
					return _producto.CampoAuxiliar5;
				}
				return string.Empty;

			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.CampoAuxiliar5)
					{
						_producto.CampoAuxiliar5 = value;
						
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
						_huboCambios = true;
					}
					if(_seleccionMultilple)
					{
						foreach(ProductoView prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.CampoAuxiliar5 = value;
						}
					}
				}
				
			}
		}

		public string CampoAuxiliar6
		{
			get
			{
				if(_producto != null)
				{
					return _producto.CampoAuxiliar6;
				}
				return string.Empty;

			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.CampoAuxiliar6)
					{
						UpdateCampoAuxiliar6(_producto, value);
						//_producto.CampoAuxiliar6 = _producto.CampoAuxiliar6.Equals(string.Empty)?value:_producto.CampoAuxiliar6 + "," + value;
						
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
						_huboCambios = true;
					}
					if(_seleccionMultilple)
					{
						foreach(ProductoView prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									//prod.CampoAuxiliar6 = prod.CampoAuxiliar6.Equals(string.Empty)?value:prod.CampoAuxiliar6 + "," + value;
									UpdateCampoAuxiliar6(prod, value);

						}
					}
				}
				
			}
		}

		private void UpdateCampoAuxiliar6(ProductoView prod, string Valor)
		{
			if(_state.Equals("A"))
			{
				if(prod.CampoAuxiliar6.Equals(string.Empty))
					prod.CampoAuxiliar6 = Valor;
				else
				{
					ArrayList campoAuxiliar6List = new ArrayList();
                    /* Silvina 20111226 - Tarea 0000241 */
                    campoAuxiliar6List = mz.erp.systemframework.Util.Parse(prod.CampoAuxiliar6, prod.Separador);
                    ArrayList ValorList = mz.erp.systemframework.Util.Parse(Valor, prod.Separador);
                    /* Fin Silvina 20111226 - Tarea 0000241 */
					foreach(string val in ValorList)
					{
						if(!campoAuxiliar6List.Contains(val))
						{
                            /* Silvina 20111226 - Tarea 0000241 */
							prod.CampoAuxiliar6 = prod.CampoAuxiliar6 + prod.Separador + val;
                            /* Fin Silvina 20111226 - Tarea 0000241 */
						}
					}
					
				}
			}
			else
			{
				if(_state.Equals("D"))
				{
					if(!prod.CampoAuxiliar6.Equals(string.Empty))
					{

                        /* Silvina 20111226 - Tarea 0000241 */
                        ArrayList campoAuxiliar6List = mz.erp.systemframework.Util.Parse(prod.CampoAuxiliar6, prod.Separador);
                        ArrayList ValorList = mz.erp.systemframework.Util.Parse(Valor, prod.Separador);
                        /* Fin Silvina 20111226 - Tarea 0000241 */
						ArrayList aux = new ArrayList();
						foreach(string val in campoAuxiliar6List)
						{
							if(!ValorList.Contains(val))
							{
								aux.Add(val);	
							}
						}
						foreach(string val in aux)
						{
							campoAuxiliar6List.Remove(val);
						}
                        /* Fin Silvina 20111226 - Tarea 0000241 */
                        prod.CampoAuxiliar6 = mz.erp.systemframework.Util.PackString(campoAuxiliar6List, prod.Separador);
                        /* Fin Silvina 20111226 - Tarea 0000241 */
					}
						
				}
			}
		}



		public bool ObligaCodigoBarra
		{
			get
			{
				if(_producto != null)
				{
					return _producto.ObligaCodigoBarra;
				}
				return false;

			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.ObligaCodigoBarra)
					{
						_producto.ObligaCodigoBarra = value;
						
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
						_huboCambios = true;
					}
					if(_seleccionMultilple)
					{
						foreach(ProductoView prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.ObligaCodigoBarra = value;
						}
					}
				}
				
			}
		}

		public bool ObligaNumeroSerie
		{
			get
			{
				if(_producto != null)
				{
					return _producto.ObligaNumeroSerie;
				}
				return false;

			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.ObligaNumeroSerie)
					{
						_producto.ObligaNumeroSerie = value;
						
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
						_huboCambios = true;
					}
					if(_seleccionMultilple)
					{
						foreach(ProductoView prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.ObligaNumeroSerie = value;
						}
					}
				}
				
			}
		}
		public bool PercibeIngresosBrutos
		{
			get
			{
				if(_producto != null)
				{
					return _producto.PercibeIngresosBrutos;
				}
				return false;

			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.PercibeIngresosBrutos)
					{
						_producto.PercibeIngresosBrutos = value;
						
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
						_huboCambios = true;
					}
					if(_seleccionMultilple)
					{
						foreach(ProductoView prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.PercibeIngresosBrutos = value;
						}
					}
				}
				
			}
		}
		public bool Activo
		{
			get
			{
				if(_producto != null)
				{
					return _producto.Activo;
				}
				return false;

			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.Activo)
					{
						_producto.Activo = value;
						
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
						_huboCambios = true;
					}
					if(_seleccionMultilple)
					{
						foreach(ProductoView prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.Activo = value;
						}
					}
				}
				
			}
		}

        /* Silvina 20110630 - Tarea 0000136 */
        public bool PermiteCambio
        {
            get {
                if (_producto != null)
                    return _producto.PermiteCambio;
                else
                    return true;
            }
            set
            {
                if (_producto != null)
                {
                    if (value != _producto.PermiteCambio)
                    {
                        _producto.PermiteCambio = value;

                        if (ObjectHasChanged != null)
                            ObjectHasChanged(this, new EventArgs());
                        _huboCambios = true;
                    }
                    if (_seleccionMultilple)
                    {
                        foreach (ProductoView prod in _productos)
                        {
                            if (prod != _producto)
                                if (prod.Selected)
                                    prod.PermiteCambio = value;
                        }
                    }
                }
            }
        }
        /* Fin Silvina 20110630 - Tarea 0000136 */

        //German 20120208 - Tarea 0000276
        public string IdBonificacion
        {
            get
            {
                if (_producto != null)
                    return _producto.IdBonificacion;
                else
                    return string.Empty;
            }
            set
            {
                if (_producto != null)
                {
                    if (value != _producto.IdBonificacion)
                    {
                        _producto.IdBonificacion = value;

                        if (ObjectHasChanged != null)
                            ObjectHasChanged(this, new EventArgs());
                        _huboCambios = true;
                    }
                    if (_seleccionMultilple)
                    {
                        foreach (ProductoView prod in _productos)
                        {
                            if (prod != _producto)
                                if (prod.Selected)
                                    prod.IdBonificacion = value;
                        }
                    }
                }
            }
        }




        //German 20120208 - Tarea 0000276

		#endregion
		
		#region Metodos Privados
		private bool ExisteProducto(ArrayList productos, string IdProducto)
		{
			bool resultado = false;
			foreach(ProductoView prod in productos) 
			{
				if (prod.IdProducto.Equals(IdProducto))
				{
					return true;
				}
			}			
			return resultado;
		}
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
			if(this.GetProcessManagerParent().Process.ProcessName.Equals("ProcesoDesactivarProductosSinMovimientos"))
			{	
				if(sender.GetType().Equals(typeof(mz.erp.businessrules.mzProductosSearchFormWorkflow)))
				{
					mzProductosSearchFormWorkflow ps = (mzProductosSearchFormWorkflow)sender;
					DataTable result = ps.Result;
					foreach ( DataRow row in result.Rows )
					{
						string idProd = row["IdProducto"].ToString();
						bool isSelected = (bool)row["Marca"];
						if(isSelected && !this.ExisteProducto(_productos, idProd))
						{
							ProductoView prod = new ProductoView(idProd);
							prod.Activo = false;
							this._productos.Add(prod);							
						}
					}					
				}	
			}
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			
		}

		public void Init()
		{
			_productos = new ArrayList();
			this._dataProductos.DataSetName = "tsh_ProductosDataset";

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
		
		public bool IsValid()
		{			
			_errores.Clear();
			bool isvalid = true;
			return isvalid;
		}


		public bool AllowShow()
		{
			return Variables.GetValueBool(this.GetProcessManagerParent().Process.ProcessName, this.GetTaskName(), "MuestraFormulario", true);
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
			string warning = string.Empty;
			if(_huboCambios)
			{
				ArrayList productosModificados = this.getProductosSeleccionados();
				if(productosModificados.Count > 1)
				{
					warning = "¿Confirma que desea aplicar las modificaciones a los sigueintes productos: ";
					int i = 1;
					foreach(ProductoView prod in productosModificados)
					{
						warning = warning + prod.Codigo;
						i++;
						if(i < productosModificados.Count)
							warning = warning + ", ";
						else if(i == productosModificados.Count)
                            warning = warning + " y ";						
					}
					warning = warning + "?";
				}else
				{
					warning = "¿Confirma que desea aplicar las modificaciones?";
					//warning = warning + ((ProductoView)productosModificados[0]).Codigo + "?";
				}
			}
			return warning;
		}

		private ArrayList getProductosSeleccionados()
		{
			ArrayList productosModificados = new ArrayList();
			foreach(ProductoView prod in _productos)
			{
				if(prod.Selected)
					productosModificados.Add(prod);

			}
			if(productosModificados.Count == 0)
                productosModificados.Add(this._producto);
			return productosModificados;
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
			data.Add( (DataSet) this._dataProductos);
			return data;
		}

		public void Commit()
		{
			foreach(ProductoView prod in this._productos)
			{
				DataRow row = mz.erp.businessrules.tsh_Productos.GetByPk(prod.IdProducto);
				_dataProductos.Tables[0].ImportRow(row);
				DataRow rowProd = ((tsh_ProductosDataset) _dataProductos).tsh_Productos.FindByIdProducto(prod.IdProducto);
				rowProd["Observaciones"] = prod.Observaciones;
				rowProd["CampoAuxiliar1"] = prod.CampoAuxiliar1;
				rowProd["CampoAuxiliar2"] = prod.CampoAuxiliar2;
				rowProd["CampoAuxiliar3"] = prod.CampoAuxiliar3;
				rowProd["CampoAuxiliar4"] = prod.CampoAuxiliar4;
				rowProd["CampoAuxiliar5"] = prod.CampoAuxiliar5;
				rowProd["CampoAuxiliar6"] = prod.CampoAuxiliar6;
				rowProd["ObligaCodigoBarra"] = prod.ObligaCodigoBarra;
				rowProd["ObligaNumeroSerie"] = prod.ObligaNumeroSerie;
				rowProd["PercibeIB"] = prod.PercibeIngresosBrutos;
				rowProd["Activo"] = prod.Activo;
				rowProd["IdProveedorDefault"] = prod.IdProveedorDefault;

                //German 20120208 - Tarea 0000276

                rowProd["IdBonificacion"] = prod.IdBonificacion;
                //German 20120208 - Tarea 0000276

				/*
				// Agregar la tupla (IdProveedores,IdProducto) en tpu_ProveedoresProductos
				// chequear q _idProveedorDefautl no sea blanco o null.
				if ( (!(prod.IdProveedorDefault == null)) && (!(prod.IdProveedorDefault.Equals(string.Empty))) )
				{
					// buscar en tpu_proveedoresproductos si existe una con fila con IdProducto e _idProveedroDefault.
					DataRow rowAux = mz.erp.businessrules.tpu_ProveedoresProductos.GetByPk(prod.IdProveedorDefault, prod.IdProducto);
					if(rowAux == null)
					{	
						// No existe, creo la fila y la agrego a la tabla tpu_ProveedoresProductos dentro del dataset en la variable _data.
						tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow newRow = _dataProveedoresProductos.tpu_ProveedoresProductos.Newtpu_ProveedoresProductosRow();

						mz.erp.businessrules.tpu_ProveedoresProductos.SetRowDefaultValues( newRow );
																
						newRow.IdProducto = prod.IdProducto; //row["IdProveedor"] = this._idProveedorDefault;
						newRow.IdProveedor = prod.IdProveedorDefault; //row["IdProducto"] = IdProducto;
						
						_dataProveedoresProductos.tpu_ProveedoresProductos.Addtpu_ProveedoresProductosRow( newRow );

					}// Si existe no hago nada.
				}*/

                /* Silvina 20110630 - Tarea 0000136 */
                DataRow rowAux = mz.erp.businessrules.tsh_ProductosAuxiliares.GetByPk(prod.IdProducto);
                _dataProductosAuxiliares.tsh_ProductosAuxiliares.ImportRow(rowAux);
                DataRow rowProdAux = _dataProductosAuxiliares.tsh_ProductosAuxiliares.FindByIdProducto(prod.IdProducto);
                rowProdAux["PermiteCambio"] = prod.PermiteCambio;
                /* Fin Silvina 20110630 - Tarea 0000136 */

			}

		}

		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());
			SentenciasReplicacion _replicacion = GenerateReplicaction();
			mz.erp.dataaccess.tsh_Productos.Update(this._dataProductos, IdTransaction, _replicacion);
			// actualiza la tabla tpu_ProveedoresProducto (si selecc un Proveedor por default)
			//mz.erp.dataaccess.tpu_ProveedoresProductos.Update(this._dataProveedoresProductos);
            /* Silvina 20110630 - Tarea 0000136 */
            mz.erp.dataaccess.tsh_ProductosAuxiliares.Update(_dataProductosAuxiliares.tsh_ProductosAuxiliares, IdTransaction);
            /* Fin Silvina 20110630 - Tarea 0000136 */
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());	

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

		private static SentenciasReplicacion  GenerateReplicaction()
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

		public bool GetHasSaved()
		{
			
			return false;
		}

		#endregion

        #region Metodos Publicos

		public void Seleccionar(bool seleccionar)
		{
			foreach(ProductoView prod in _productos)
			{
				prod.Selected = seleccionar;
			}

		}

		public void AddRange(ArrayList items)
		{
			foreach ( mz.erp.businessrules.comprobantes.Item item in items )
			{
				if(!this.ExisteProducto(_productos, item.IdProducto))
				{
					ProductoView prod = new ProductoView(item.IdProducto);
					this._productos.Add(prod);
				}
			}
			if(ProductosCollectionChanged != null)
				ProductosCollectionChanged(this, new EventArgs());
		
		}

		#endregion

		public sealed  class ProductoView
		{
		
			#region Constructores
			public ProductoView(string IdProducto)
			{
				tsh_ProductosDataset.tsh_ProductosRow row = mz.erp.businessrules.tsh_Productos.GetByPk(IdProducto);
				if(row != null)
				{
					CargarDatosPrincipales(row);
				}
                /* Silvina 20110704 - Tarea 0000163 */
                tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresRow rowAux = tsh_ProductosAuxiliares.GetByPk(IdProducto);
                if (rowAux != null)
                    _permiteCambio = rowAux.PermiteCambio;
                /* Fin Silvina 20110704 - Tarea 0000163 */

			}
			#endregion

			#region Variables Privadas

			private string _codigoProducto = string.Empty;
			private string _idProducto = string.Empty;
			private string _descripcion = string.Empty;
			private bool _selected = false;
			private string _observaciones = string.Empty;
			private string _campoAuxiliar1 = string.Empty;
			private string _campoAuxiliar2 = string.Empty;
			private string _campoAuxiliar3 = string.Empty;
			private string _campoAuxiliar4 = string.Empty;
			private string _campoAuxiliar5 = string.Empty;
			private string _campoAuxiliar6 = string.Empty;
			private bool _obligaCodigoBarra = false;
			private bool _obligaNumeroSerie = false;
			private bool _percibeIngresosBrutos = false;
			private bool _activo = false;
			private string _idProveedorDefault = string.Empty;
			ArrayList _jerarquiasCampoAuxiliar6 = new ArrayList();
            /* Silvina 20110630 - Tarea 0000136 */
            private bool _permiteCambio = true;
            /* Fin Silvina 20110630 - Tarea 0000136 */
            /* Silvina 20111226 - Tarea 0000241 */
            private string _separador = Variables.GetValueString("Productos.CampoAuxiliar6.JerarquiaAsociada.Separador");
            /* Fin Silvina 20111226 - Tarea 0000241 */
            //German 20120208 - Tarea 0000276
            private string _idBonificacion = string.Empty;
            //German 20120208 - Tarea 0000276

			#endregion
		
			#region Propiedades

			public ArrayList JerarquiasCampoAuxiliar6
			{
				get{return _jerarquiasCampoAuxiliar6;}
			}


			public bool Selected
			{
				get{return _selected;}
				set{_selected = value;}
			}

			public string Descripcion
			{
				get
				{
					return _descripcion;
				}
				set
				{
					_descripcion = value;
				}
			}


			public string Codigo
			{
				get
				{
					return _codigoProducto;
				}
				set
				{
					_codigoProducto = value;
				}
			}

			public string IdProducto
			{
				get
				{
					return _idProducto;
				}
				set
				{
					_idProducto = value;
				}
			}

			public string IdProveedorDefault
			{
				get
				{
					return _idProveedorDefault;
				}
				set
				{
					_idProveedorDefault = value;
				}
			}

			public string Observaciones
			{
				get
				{
					return _observaciones;
				}
				set
				{
					_observaciones = value;
				}
			}

			public string CampoAuxiliar1
			{
				get
				{
					return _campoAuxiliar1;
				}
				set
				{
					_campoAuxiliar1 = value;
				}
			}

			public string CampoAuxiliar2
			{
				get
				{
					return _campoAuxiliar2;
				}
				set
				{
					_campoAuxiliar2 = value;
				}
			}
			public string CampoAuxiliar3
			{
				get
				{
					return _campoAuxiliar3;
				}
				set
				{
					_campoAuxiliar3 = value;
				}
			}
			public string CampoAuxiliar4
			{
				get
				{
					return _campoAuxiliar4;
				}
				set
				{
					_campoAuxiliar4 = value;
				}
			}
			public string CampoAuxiliar5
			{
				get
				{
					return _campoAuxiliar5;
				}
				set
				{
					_campoAuxiliar5 = value;
				}
			}

			public string CampoAuxiliar6
			{
				get
				{
					return _campoAuxiliar6;
				}
				set
				{
					_campoAuxiliar6 = value;
				}
			}

			public bool ObligaCodigoBarra
			{
				get
				{
					return _obligaCodigoBarra;
				}
				set
				{
					_obligaCodigoBarra = value;
				}
			}

			public bool ObligaNumeroSerie
			{
				get
				{
					return _obligaNumeroSerie;
				}
				set
				{
					_obligaNumeroSerie = value;
				}
			}

			public bool PercibeIngresosBrutos
			{
				get
				{
					return _percibeIngresosBrutos;
				}
				set
				{
					_percibeIngresosBrutos = value;
				}
			}

            /* Silvina 20110630 - Tarea 0000136 */
            public bool PermiteCambio
            {
                get { return _permiteCambio; }
                set { _permiteCambio = value;}
            }
            /* Fin Silvina 20110630 - Tarea 0000136 */

			public bool Activo
			{
				get
				{
					return _activo;
				}
				set
				{
					_activo = value;
				}
			}

            /* Silvina 20111226 - Tarea 0000241 */
            public string Separador
            {
                get { return _separador; }
            }
            /* Fin Silvina 20111226 - Tarea 0000241 */

            //German 20120208 - Tarea 0000276
            public string IdBonificacion
            {

                get { return _idBonificacion; }
                set { _idBonificacion = value; }
            }

            //German 20120208 - Tarea 0000276

			#endregion

			#region Metodos Privados
			private void CargarDatosPrincipales(tsh_ProductosDataset.tsh_ProductosRow row)
			{
				_idProducto = row.IdProducto;
				_codigoProducto = row.Codigo;
				_descripcion = row.Descripcion;
				_observaciones = row.Observaciones;
				_campoAuxiliar1 = row.CampoAuxiliar1;
				_campoAuxiliar2 = row.CampoAuxiliar2;
				_campoAuxiliar3 = row.CampoAuxiliar3;
				_campoAuxiliar4 = row.CampoAuxiliar4;
				_campoAuxiliar5 = row.CampoAuxiliar5;
				_campoAuxiliar6 = row.CampoAuxiliar6;
				_obligaCodigoBarra = row.ObligaCodigoBarra;
				_obligaNumeroSerie = row.ObligaNumeroSerie;
				_percibeIngresosBrutos = row.PercibeIB;
				_activo = row.Activo;
				_idProveedorDefault = row.IdProveedorDefault;

				_jerarquiasCampoAuxiliar6.Clear();

                /* Silvina 20111226 - Tarea 0000241 */
                if (string.IsNullOrEmpty(_separador))
                    _separador = ",";
                ArrayList CampoAuxiliar6BDList = mz.erp.systemframework.Util.Parse(_campoAuxiliar6, _separador);
                /* Fin Silvina 20111226 - Tarea 0000241 */
				
				foreach(string aux in CampoAuxiliar6BDList)
				{
					if(aux != null && aux != string.Empty)
					{
						DataRow rowJ = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetPkByDescripcion(aux);
						if(rowJ != null)
						{
							ItemJerarquia pj = new ItemJerarquia("PRODUCTOS");
							pj.NodeKeyPath = Convert.ToString(rowJ["Jerarquia"]);
							pj.NodeKey = Convert.ToString(rowJ["IdNomenclatura"]);
							_jerarquiasCampoAuxiliar6.Add(pj);
						}

					}
				}
                //German 20120208 - Tarea 0000276
                _idBonificacion = row.IdBonificacion;
                //German 20120208 - Tarea 0000276
			}
		

			#endregion

		
		}

	}

}
