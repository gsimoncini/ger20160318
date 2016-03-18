using System;
using System.Data;
using System.Collections;
using mz.erp.commontypes.data;
using mz.erp.commontypes;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de AbmProductosPrecios.
	/// </summary>
	public class AbmProductosPrecios: ITask, IPersistentTask
	{
		public class ProductosImpuestos: CollectionBase 
		{
			public ProductosImpuestos()
			{
			}
			public void Add(object sender)
			{
				base.List.Add( sender );
			}
			public void Add(ProductoImpuesto sender)
			{
				base.List.Add( sender );
			}

		}

		public class ProductoImpuesto 
		{
			private string _idImpuesto = "";
			private string _descripcion = "";
			private bool _activo = false;
			private string _formula = "";

			public string IdImpuesto 
			{
				get {return _idImpuesto;}
				set {_idImpuesto = value;}
			}
			public string Descripcion 
			{
				get {return _descripcion;}
				set {_descripcion = value;}
			}
			public bool Activo 
			{
				get {return _activo;}
				set {_activo = value;}
			}
			public string Formula
			{
				get {return _formula;}
				set {_formula = value;}
			}
		}


		/*German 20090325*/
		private bool _calculaPPP = true;

		private bool _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista = false;

		private Producto _producto;
		/*Fin German 20090325*/
		
		public AbmProductosPrecios()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		#region Miembros de IPersistentTask

		public event System.EventHandler OnTaskBeforeFlush;

		public event System.EventHandler OnTaskAfterFlush;

		public TaskCollectionData GetData()
		{
			// TODO: agregar la implementación AbmProductosPrecios.GetData
			return null;
		}

		public void Commit()
		{
			if (_state != BRTypes.ABMState.Consulta)
			{
			}

		}

		public void Flush(string IdTransaction)
		{
			/*
			if (_state != BRTypes.ABMState.Consulta)
			{
				// El procedimiento de update al detectar campos 
				foreach( System.Data.DataColumn col in _rowProductosPrecios.Table.Columns)
				{
					_rowProductosPrecios[ col ] = System.Convert.DBNull;
				}
				_rowProductosPrecios.PrecioDeCostoRef = _precioDeCostoRef;
				_rowProductosPrecios.MAC = _mac;
				_rowProductosPrecios.PrecioDeVentaNeto = _precioDeVentaNeto;
				_rowProductosPrecios.MaxDescuentoPorcentual = _maximoDescuentoPorcentual;
				_rowProductosPrecios.MaxDescuento = _maximoDescuento ;
				_rowProductosPrecios.PrecioDeVentaBruto = _precioDeVentaBruto;
				_rowProductosPrecios.IdBonificacion = _idBonificacion;
				_rowProductosPrecios.IdMonedaCierrePrecioDeCostoRef = _idMonedaCierrePrecioDeCostoRef; 
				_rowProductosPrecios.IdMonedaCierrePrecioDeVentaNeto = _idMonedaCierrePrecioDeVentaNeto;
				_rowProductosPrecios.IdMonedaCierreMaxDescuento = _idMonedaCierreMaxDescuento;
				_rowProductosPrecios.IdMonedaCierrePrecioDeVentaBruto = _idMonedaCierrePrecioDeVentaBruto;
				_rowProductosPrecios.IdCotizacionCierrePrecioDeCostoRef = _idCotizacionCierrePrecioDeCostoRef ;
				_rowProductosPrecios.IdCotizacionCierrePrecioDeVentaNeto = _idCotizacionCierrePrecioDeVentaNeto;
				_rowProductosPrecios.IdCotizacionCierreMaxDescuento = _idCotizacionCierreMaxDescuento ;
				_rowProductosPrecios.IdCotizacionCierrePrecioDeVentaBruto = _idCotizacionCierrePrecioDeVentaBruto;
				
				mz.erp.businessrules.tsh_Productos.Update( _rowProductosPrecios, IdTransaction, new SentenciasReplicacion() );
				//--_sentencia = GenerateReplication();
				//--PutErrorOnDataSet(_rowProductos);
			}
			*/

		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			// TODO: agregar la implementación AbmProductosPrecios.PutExtraDataOnCommit
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{
			foreach( TaskCollectionData taskData in _processCollectionData)
			{
				if (taskData.TaskName.CompareTo("ABMProductos") == 0 )
				{
					foreach ( DataSet data in taskData )
					{
						foreach ( System.Data.DataTable table in data.Tables )
						{
							if (table.TableName.CompareTo("tsh_Productos")==0)
							{
								if (table.Rows.Count>0)
								{
									_rowProductosPrecios = (mz.erp.commontypes.data.tsh_ProductosDataset.tsh_ProductosRow)table.Rows[0];
								}
							}
						}
					}
				}
			}
		}

		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			// TODO: agregar la implementación AbmProductosPrecios.GetSentenceReplication
			return null;
		}

		public bool GetHasSaved()
		{
			// TODO: agregar la implementación AbmProductosPrecios.GetHasSaved
			return false;
		}

		#endregion
		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;

		public event System.EventHandler OnTaskAfterPrevious;

		public void ListenerTaskDependentChanged(object sender)
		{
			// TODO: agregar la implementación AbmProductosPrecios.ListenerTaskDependentChanged
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
			if (sender.GetType() == typeof(businessrules.AbmProductos))
			{
				_state = ((AbmProductos)sender).State;
				string Codigo = ((AbmProductos)sender).Codigo;
				switch (_state)
				{
					case mz.erp.commontypes.BRTypes.ABMState.Alta: 
						NewData( );
						break;
					case mz.erp.commontypes.BRTypes.ABMState.Modificacion:
						//EditData( Codigo );
						break;
					case mz.erp.commontypes.BRTypes.ABMState.Baja:
						break;
					case mz.erp.commontypes.BRTypes.ABMState.Consulta:
						break;
				}
				
			}
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación AbmProductosPrecios.ListenerBeforeExecuteDependentTask
		}

		public void Init()
		{
			InitializeData();
			NewData();
		}

		public bool IsValidForStartProcess()
		{
			_errors.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._parentProcess.Process.IdProcess,IdTarea, this);
			_errors.AddAll(validator.GetErrors());
			return IsValid;
		}

		public bool IsValid()
		{
			if (_errors.Count > 0)
				return false;
			else
				return true;
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
			return _errors;
		}

		public string GetWarnings()
		{
			// TODO: agregar la implementación AbmProductosPrecios.GetWarnings
			return null;
		}

		public ProcessManager GetProcessManagerParent()
		{
			return _parentProcess;
			
		}

		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_parentProcess = processManager;
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
			if (OnTaskBeforeExecute != null)
			{
				this.OnTaskBeforeExecute(this,new System.EventArgs() );
			}
			ValidarDatos();
			if (OnTaskAfterExecute != null)
			{
				this.OnTaskAfterExecute(this,new System.EventArgs() );
			}

		}

		public bool AllowPrevious()
		{
			// TODO: agregar la implementación AbmProductosPrecios.AllowPrevious
			return false;
		}

		public void Previous()
		{
			// TODO: agregar la implementación AbmProductosPrecios.Previous
		}

		public void ListenerAfterPreviousDependentTask(object sender)
		{
			// TODO: agregar la implementación AbmProductosPrecios.ListenerAfterPreviousDependentTask
		}

		public void ListenerBeforePreviousDependentTask(object sender)
		{
			// TODO: agregar la implementación AbmProductosPrecios.ListenerBeforePreviousDependentTask
		}

		#endregion
		#region Custom Members
		private string _idProducto;
		public string IdProducto
		{
			set { _idProducto = value ; }
			get { return _idProducto ; }
		}
		private mz.erp.commontypes.data.tsh_ProductosDataset.tsh_ProductosRow _rowProductosPrecios;
		private mz.erp.commontypes.data.tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosDataTable _tableProductosImpuestos;

		private mz.erp.commontypes.BRTypes.ABMState _state;
		public mz.erp.commontypes.BRTypes.ABMState State
		{
			get {return _state; }
		}

		private void NewData()
		{
			_rowProductosPrecios = mz.erp.businessrules.tsh_Productos.NewRow();
			_tableProductosImpuestos = mz.erp.businessrules.tsy_ImpuestosProductos.NewTable();
			GetDataProductosPrecios();	
			_state = BRTypes.ABMState.Alta;
		}
		
		private void DeleteData( string codigo )
		{
			_idProducto = mz.erp.businessrules.tsh_Productos.GetPkByCodigo( codigo );
			_rowProductosPrecios = mz.erp.businessrules.tsh_Productos.GetByPk( IdProducto );
			GetDataProductosPrecios();	
			_state = BRTypes.ABMState.Baja;
		}
		private void ViewData( string codigo )
		{
			_idProducto = mz.erp.businessrules.tsh_Productos.GetPkByCodigo( codigo );
			_rowProductosPrecios = mz.erp.businessrules.tsh_Productos.GetByPk( IdProducto );
			GetDataProductosPrecios();	
			_state = BRTypes.ABMState.Consulta;
		}

		private void EditData( string codigo )
		{
			_idProducto = mz.erp.businessrules.tsh_Productos.GetPkByCodigo( codigo );
			_rowProductosPrecios = mz.erp.businessrules.tsh_Productos.GetByPk( IdProducto );
			GetDataProductosPrecios();	
			_state = BRTypes.ABMState.Modificacion;
		}

		
		/// <summary>
		/// Vuelca el contenido de las row de productos a las clase que mantiene los datos
		/// en memoria
		/// </summary>
		private void GetDataProductosPrecios()
		{
			switch (_state)
			{
				case BRTypes.ABMState.Alta:
				{
					GetNewDataProductosPrecios();
				}
					break;
				case BRTypes.ABMState.Baja:
				{
				}
					break;
				case BRTypes.ABMState.Modificacion:
				{
				}
					break;
				case BRTypes.ABMState.Consulta:
				{
				}
					break;
			}
		}
		private void GetNewDataProductosPrecios()
		{
			/*German 20090325*/
			_producto = new Producto(_calculaPPP, _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista);
			/*Fin German 20090325*/
			
		}
		
			/*
			_producto.Cantidad = 1;
			_producto.PrecioDeCosto = _rowProductosPrecios.PrecioDeCostoRef;
			_producto.IdMonedaPrecioDeCosto = Variables.GetValueString("Contabilidad.MonedaReferencia");
			_producto.IdCotizacionMonedaPrecioDeCosto = 1; //Cotizacion por default
			
			_producto.PrecioDeVentaNeto = _rowProductosPrecios.PrecioDeCostoRef;
			_producto.IdMonedaPrecioDeVentaNeto = Variables.GetValueString("Contabilidad.MonedaReferencia");
			_producto.IdCotizacionMonedaPrecioDeVentaNeto = 1; //Cotizacion por default

			_producto.MAC = 0;
			
			_producto.Codigo = _rowProductosPrecios.Codigo;
			_producto.Descripcion = _rowProductosPrecios.Descripcion;
			
			_producto.PorcentajeMaximoDescuento = 0;

			_producto.MaximoDescuento = 0;
			_producto.PrecioLista = _rowProductosPrecios.PrecioDeVentaBruto;
			_producto.IdSucursal = Security.IdSucursal;
			_producto.IdEmpresa = Security.IdEmpresa;
			*/

			
/*

			_precioDeCostoRef = _rowProductosPrecios.PrecioDeCostoRef;
			_mac = _rowProductosPrecios.MAC;
			_precioDeVentaNeto = _rowProductosPrecios.PrecioDeVentaNeto;
			_maximoDescuentoPorcentual = _rowProductosPrecios.MaxDescuentoPorcentual;
			_maximoDescuento = _rowProductosPrecios.MaxDescuento;
			_precioDeVentaBruto = _rowProductosPrecios.PrecioDeVentaBruto;
			_idBonificacion = _rowProductosPrecios.IdBonificacion;
			_idMonedaCierrePrecioDeCostoRef = _rowProductosPrecios.IdMonedaCierrePrecioDeCostoRef;
			_idMonedaCierrePrecioDeVentaNeto = _rowProductosPrecios.IdMonedaCierrePrecioDeVentaNeto;
			_idMonedaCierreMaxDescuento = _rowProductosPrecios.IdMonedaCierreMaxDescuento;
			_idMonedaCierrePrecioDeVentaBruto = _rowProductosPrecios.IdMonedaCierrePrecioDeVentaBruto;
			_idCotizacionCierrePrecioDeCostoRef = _rowProductosPrecios.IdCotizacionCierrePrecioDeCostoRef;
			_idCotizacionCierrePrecioDeVentaNeto = _rowProductosPrecios.IdCotizacionCierrePrecioDeVentaNeto;
			_idCotizacionCierreMaxDescuento = _rowProductosPrecios.IdCotizacionCierreMaxDescuento;
			_idCotizacionCierrePrecioDeVentaBruto = _rowProductosPrecios.IdCotizacionCierrePrecioDeVentaBruto;
*/
			/*foreach( System.Data.DataRow _rowProductosImpuestos in _tableProductosImpuestos.Rows)
			{
				mz.erp.commontypes.data.tsy_ImpuestosDataset.tsy_ImpuestosRow _rowImpuestos = mz.erp.businessrules.tsy_Impuestos.GetByPk( ((tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosRow)_rowProductosImpuestos).IdImpuesto );
				if (_rowImpuestos != null)
				{
					ProductoImpuesto pi = new ProductoImpuesto();
					pi.IdImpuesto = ((tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosRow)_rowProductosImpuestos).IdImpuesto;
					pi.Descripcion = _rowImpuestos.Descripcion;
					pi.Formula = _rowImpuestos.FormulaDeCalculo;
					pi.Activo = _rowImpuestos.Activo;
					_impuestos.Add( pi );
				}
			}*/


		
		
		#endregion
		#region Variables Publicas
		
		public decimal PrecioDeCostoRef
		{
			get { return this._producto.PrecioDeCosto ; }
			set { this._producto.PrecioDeCosto = value ; }
		}
		public decimal MAC
		{
			get { return this._producto.MAC ; }
			set { this._producto.MAC = value ; }
		}
		public decimal PrecioDeVentaNeto
		{
			get { return this._producto.PrecioDeVentaNeto ; }
			
		}
		public decimal PrecioDeVentaNetoMonedaPrecioDeCosto
		{
			get { return this._producto.PrecioDeVentaNetoMonedaPrecioDeCosto; }
		}
		public decimal MaximoDescuentoPorcentual 
		{
			get { return this._producto.PorcentajeMaximoDescuento ; }
			
		}
		public decimal MaximoDescuento
		{
			get { return this._producto.MaximoDescuento  ; }
			
		}
		public decimal PrecioDeVentaBruto
		{
			get { return this._producto.PrecioLista ; }
			set { this._producto.PrecioLista = value ;}
		}
		public decimal PrecioDeListaConImpuestos
		{
			get { return this._producto.PrecioDeListaConImpuestos ; }
			set { this._producto.PrecioDeListaConImpuestos = value ; }
		}
		public string IdMonedaCierrePrecioDeCostoRef
		{
			get { return this._producto.IdMonedaPrecioDeCosto; }
			set { this._producto.IdMonedaPrecioDeCosto = value ;}
		}
		public string IdMonedaCierrePrecioDeVentaNeto
		{
			get { return this._producto.IdMonedaPrecioDeVentaNeto; }
			set { this._producto.IdMonedaPrecioDeVentaNeto = value ; }
		}
		public string IdMonedaCierrePrecioDeVentaBruto
		{
			get { return this._producto.IdMonedaPrecioDeVentaNeto ; }
		}

		public string IdCotizacionCierrePrecioDeCostoRef
		{
			get { return this._producto.IdCotizacionMonedaPrecioDeCosto; }
			
		}

		public string IdCotizacionCierrePrecioDeVentaNeto
		{
			get { return  this._producto.IdCotizacionMonedaPrecioDeVentaNeto; }
			
		}

		public string IdCotizacionCierrePrecioDeVentaBruto
		{
			get { return this._producto.IdCotizacionMonedaPrecioDeVentaNeto; }
		}

		public string IdFuenteDeCambioPrecioDeCostoRef
		{
			get{return _producto.IdFuenteDeCambioProductoPrecioDeCosto;}
			set{_producto.IdFuenteDeCambioProductoPrecioDeCosto = value;}
		}

		public string IdFuenteDeCambioPrecioDeVentaNeto
		{
			get{return _producto.IdFuenteDeCambioProductoPrecioDeVenta;}
			set{_producto.IdFuenteDeCambioProductoPrecioDeVenta = value;}
		}
		public decimal ValorCotizacionPrecioDeCostoRef
		{
			get{return _producto.ValorCotizacionPrecioDeCosto;}

		}
		public decimal ValorCotizacionPrecioDeVentaNeto
		{
			get{return _producto.ValorCotizacionPrecioDeVenta;}

		}
		private bool _preguntarAlCancelar = false;
		public bool PreguntarAlCancelar
		{
			get {return _preguntarAlCancelar ;}
			set {_preguntarAlCancelar =value;}
		}

		#endregion
		#region Variables Privadas
		private ProcessManager _parentProcess;
		private string _taskName;
		private ItemsDatasetErrors _errors = new ItemsDatasetErrors();
		private mz.erp.commontypes.SentenciasReplicacion _sentencia;
		#endregion
		#region custom members
		private void ValidarDatos()
		{
			_errors.Clear();
		}
		private void InitializeData()
		{
			/*German 20090325*/
			_calculaPPP = Variables.GetValueBool(this._parentProcess.Process.ProcessName, this._taskName,"PrecioDeCosto.CalculaPPP","Productos.PrecioDeCosto.CalculaPPP", _calculaPPP);
			_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista = Variables.GetValueBool(this._parentProcess.Process.ProcessName, this._taskName, "ModificaPrecioDeCostoListaProveedorTrasladaPrecioDeVentaBruto","Productos.Precio.ModificaPrecioDeCostoListaProveedorTrasladaPrecioDeVentaBruto", _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista);
			_producto = new Producto(_calculaPPP, _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista);
			/*Fin German 20090325*/
			_preguntarAlCancelar = Variables.GetValueBool(_parentProcess.Process.ProcessName,_taskName,"PreguntarAlCancelar");

		}
		#endregion
	}
}
