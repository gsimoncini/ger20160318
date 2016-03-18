using System;
using System.Collections;
using System.Data;
using mz.erp.businessrules;
using mz.erp.commontypes.data;
using mz.erp.commontypes;
using mz.erp.systemframework;
using mz.erp.businessrules.comprobantes;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de RegistrarNumerosDeSerie.
	/// </summary>
	public class RegistrarNumerosDeSerie: ITask, IPersistentTask
	{
		#region Clases auxiliares

		sealed class Table 
		{
			private Hashtable _table = new Hashtable();
			


			public Table()
			{
			}

			public ArrayList Keys()
			{
				return new ArrayList(this._table.Keys);
			}
				
			public void Minus(Table table)
			{
				foreach(string codigo in table.Keys())
				{
					if(this.ContainsKey(codigo))
						this._table[codigo] = this.Get(codigo) - table.Get(codigo); 
				}
				
			}
			public void Generate(ItemsNumerosDeSerie items)
			{
				foreach(ItemNumeroDeSerie item in items)
				{
					Add(item.Codigo, 1);
				}
			}

			public void Generate(ArrayList items)
			{
				foreach(ItemAjuste item in items)
				{
					Add(item.Codigo, item.Cantidad);
				}
			}

			public decimal Get(string codigo)
			{
				if(ContainsKey(codigo))
					return Convert.ToDecimal(_table[codigo]);
				else return 0;
			}

			private bool ContainsKey(string codigo)
			{
				return _table.ContainsKey(codigo);
			}
			public void Add(string key , decimal cant)
			{
				if(_table.ContainsKey(key))
				{
					_table[key] = Convert.ToDecimal(_table[key]) + cant;
				}
				else
					this._table.Add(key, cant);
			}

		}
		
		public sealed class ItemNumeroDeSerieMovimientosDeStock:CollectionBase
		{
			public void Add(ItemNumeroDeSerieMovimientoDeStock item)
			{
				this.List.Add(item);
			}

			public bool Contains(string IdDeposito, string IdSeccion, string IdEstadoDeStock, short Signo)
			{
				foreach(ItemNumeroDeSerieMovimientoDeStock item in this.List)
				{
					if(item.IdDeposito.Equals(IdDeposito) && item.IdSeccion.Equals(IdSeccion)
						&& item.IdEstadoDeStock.Equals(IdEstadoDeStock) && item.Signo.Equals(Signo))
					{
						return true;
					}
				}
				return false;
			}

			public void Delete(string IdDeposito, string IdSeccion, string IdEstadoDeStock, short Signo)
			{
				ItemNumeroDeSerieMovimientoDeStock i= null;
				foreach(ItemNumeroDeSerieMovimientoDeStock item in this.List)
				{
					if(item.IdDeposito.Equals(IdDeposito) && item.IdSeccion.Equals(IdSeccion)
						&& item.IdEstadoDeStock.Equals(IdEstadoDeStock) && item.Signo.Equals(Signo))
					{
						i = item;
						break;
					}
				}
				if(i != null)
					this.List.Remove(i);
			}
				
		}

		public sealed class ItemNumeroDeSerieMovimientoDeStock
		{
			private string _idDeposito = string.Empty;
			private string _idSeccion = string.Empty;
			private string _idEstadoDeStock = string.Empty;
			private short _signo = 1;
			string _idMovimientoDeStock = string.Empty;

			
			public short Signo
			{
				get{return _signo;}
				set{_signo = value;}
			}

			public string IdSeccion
			{
				get{return _idSeccion;}
				set{_idSeccion = value;}
			}

			public string IdDeposito
			{
				get{return _idDeposito;}
				set{_idDeposito = value;}
			}

			public string IdEstadoDeStock
			{
				get{return _idEstadoDeStock;}
				set{_idEstadoDeStock = value;}
			}
			public string IdMovimientoDeStock
			{
				get{return _idMovimientoDeStock;}
				set{_idMovimientoDeStock = value;}
			}

			

		}

		public  class ItemNumeroDeSerie
		{
			#region contructor
			private IList _parent;

			public ItemNumeroDeSerie()
			{				
			}
			#endregion
			#region variables
			
			long _idOrdinal = long.MinValue;
			string _idProducto= string.Empty;
			string  _codigo = string.Empty;
			string  _codigoSecundario = string.Empty;
			string _descripcion = string.Empty;
			string _numeroDeSerie = string.Empty;
			int _item = 0;
			bool _seleccion = true;
			bool _verifyRepeat = true;
			ItemNumeroDeSerieMovimientosDeStock _movimientos = new ItemNumeroDeSerieMovimientosDeStock();
			bool _visible = true;

			long _idOR = long.MinValue;
			long _idInstanciaOR = long.MinValue;
			string _tipoProducto = string.Empty;
		

			private bool _mustValidate = false;
			#endregion
			#region Set y Get

			public string TipoProducto
			{
				get{return _tipoProducto;}
				set{_tipoProducto = value;}
			}

			
			public long IdOrdenReparacion
			{
				get{return _idOR;}
				set{_idOR = value;}
			}
			
			public long IdInstanciaOrdenReparacion
			{
				get{return _idInstanciaOR;}
				set{_idInstanciaOR = value;}
			}

			
			public bool MustValidate
			{
				set{_mustValidate = value;}
				get{return _mustValidate;}
			}
			
			public int Item 
			{
				get{return _item;}
				set{_item = value;}
			}
			public long IdOrdinal
			{
				set { _idOrdinal = value;}
				get { return _idOrdinal;}
			}
			public string IdProducto
			{
				set 
				{ 
					if(_idProducto != value)
					{
						_idProducto = value;
						if(_idProducto != null && !_idProducto.Equals(string.Empty))
						{
							DataRow row = mz.erp.businessrules.tsh_Productos.GetByPk(_idProducto);
							if(row != null)
							{
								_mustValidate = Convert.ToBoolean(row["ObligaNumeroSerie"]);
								_codigoSecundario = Convert.ToString(row["CodigoSecundario"]);
							}
						}
					}
				}
				get { return _idProducto;}
			}
			public string  Codigo
			{
				set { _codigo = value;}
				get { return _codigo;}
			}

			public string  CodigoSecundario
			{
				set { _codigoSecundario = value;}
				get { return _codigoSecundario;}
			}

			public string Descripcion
			{
				set { _descripcion = value;}
				get { return _descripcion;}
			}

			

			public bool Seleccion
			{
				get
				{
					return _seleccion;
				}
				set
				{
					_seleccion = value;
				}
			}
			public IList Parent
			{
				set { this._parent = value ; }
			}

			public bool VerifyRepeat
			{
				get{return _verifyRepeat;}
				set{_verifyRepeat = value;}
			}
			

			public string NumeroDeSerie
			{
				set 
				{	
					if(_verifyRepeat)
					{
						if (this._parent != null)
						{
							bool found = false;
							foreach( ItemNumeroDeSerie parentvalue in this._parent )
							{
								if(this != parentvalue)
									if (parentvalue.NumeroDeSerie.CompareTo( value )==0 && parentvalue.IdProducto.CompareTo( this._idProducto )== 0)
										found = true;
							}
							if (!found)
							{
								_numeroDeSerie= value;
							}
							else
								_numeroDeSerie = string.Empty;
						}
						else
							_numeroDeSerie = string.Empty;
					
					}
					else _numeroDeSerie = value;
				}
				get { return _numeroDeSerie.Trim();}
			}

			public ArrayList MovimientosDeStock
			{
				get{return new ArrayList(this._movimientos);}
			}

			public bool Visible
			{
				get{return _visible;}
				set {_visible = value;}
			}

			#endregion
			#region Metodos
				
			public void AddMovimiento(string IdMovimiento, string IdDeposito, string IdSeccion, string IdEstadoDeStock, short Signo)
			{
				
				if(!this._movimientos.Contains(IdDeposito, IdSeccion, IdEstadoDeStock, Convert.ToInt16(Signo*(Convert.ToInt16(-1)))))
				{
					ItemNumeroDeSerieMovimientoDeStock item = new ItemNumeroDeSerieMovimientoDeStock();
					item.IdDeposito = IdDeposito;
					item.IdMovimientoDeStock = IdMovimiento;
					item.IdSeccion = IdSeccion;
					item.Signo = Signo;
					item.IdEstadoDeStock = IdEstadoDeStock;
					this._movimientos.Add(item);
				}
				else
					this._movimientos.Delete(IdDeposito, IdSeccion, IdEstadoDeStock,  Convert.ToInt16(Signo*(Convert.ToInt16(-1))));

			}

			

			
				
			#endregion

		}

		public class SortByCodigo : IComparer
		{
			#region Miembros de IComparer

			public int Compare(object x, object y)
			{
				ItemNumeroDeSerie item1 = (ItemNumeroDeSerie)x;
				ItemNumeroDeSerie item2 = (ItemNumeroDeSerie)y;
				return item1.Codigo.CompareTo(item2.Codigo);
			}

			#endregion

		}

		public sealed class ItemsNumerosDeSerie: CollectionBase, IEnumerator
		{
		
			#region contructor
			public ItemsNumerosDeSerie()
			{
			}
			#endregion
			
			//cuando se llama al add verificar q la longitud cambio, si no cambio, propagar mensaje de warning
			public void Add(ItemNumeroDeSerie ins)
			{
				//si no esta --> lo agrega
				
				if (!Contains(ins.NumeroDeSerie)) 
				{
					List.Add(ins);
					
				}
			}

			public void Add(ItemNumeroDeSerie ins, bool permiteRepetidos)
			{
				if(permiteRepetidos)
					List.Add(ins);
				else this.Add(ins);

					
				
			}

			public void RebuildIDs()
			{
				int id = 1;
				ArrayList aux = new ArrayList(List);
				aux.Sort(new SortByCodigo());
				foreach( ItemNumeroDeSerie ins in aux)
				{
					ins.Item = id;
					id++;
				}
				
			}


			public ArrayList Filter(string IdProducto, string NroSerie)
			{
				ArrayList result = new ArrayList();
				bool cond1 = false;
				bool cond2 = false;
				foreach( ItemNumeroDeSerie ins in List )
				{
					cond1 = ins.IdProducto.Equals(IdProducto) || IdProducto == null;
					cond2 = ins.NumeroDeSerie.Equals(NroSerie) || NroSerie == null;
					
					if(cond1 && cond2)
						result.Add(ins);

						
				}
				return result;

			}
			

			public ArrayList Filter(string codigo, string NroSerie, long ordinal)
			{
				ArrayList result = new ArrayList();
				bool cond1 = false;
				bool cond2 = false;
				bool cond3 = false;
				foreach( ItemNumeroDeSerie ins in List )
				{
					cond1 = ins.Codigo.Equals(codigo) || codigo == null;
					cond2 = ins.NumeroDeSerie.Equals(NroSerie) || NroSerie == null;
					cond3 = ins.IdOrdinal.Equals(ordinal) || ordinal.Equals(long.MinValue);
					if(cond1 && cond2 && cond3)
						result.Add(ins);

						
				}
				return result;
			}

			public bool Contains(string codigo, long ordinal)
			{
				foreach( ItemNumeroDeSerie ins in List )
				{
					if ((ins.Codigo.Equals(codigo) || codigo == null) && (ins.IdOrdinal.Equals(ordinal) || ordinal.Equals(long.MinValue)))
						return true;
				}
				return false;
			}

			public void Remove(ItemNumeroDeSerie item)
			{
				List.Remove(item);
			}


			
			#region Miembros de ICollection

			public bool IsSynchronized
			{
				get
				{
					// TODO: agregar la implementación del captador ItemsNumerosDeSerie.IsSynchronized
					return false;
				}
			}

			public int Count
			{
				get
				{
					// TODO: agregar la implementación del captador ItemsNumerosDeSerie.Count
					return 0;
				}
			}

			public void CopyTo(Array array, int index)
			{
				// TODO: agregar la implementación ItemsNumerosDeSerie.CopyTo
			}

			public object SyncRoot
			{
				get
				{
					// TODO: agregar la implementación del captador ItemsNumerosDeSerie.SyncRoot
					return null;
				}
			}

			#endregion
			
			public bool Contains(string number)
			{
				foreach( ItemNumeroDeSerie ins in List )
				{
					if (!ins.NumeroDeSerie.Equals(string.Empty) && !ins.NumeroDeSerie.Equals(string.Empty)&& ins.NumeroDeSerie.Equals(number) )
						return true;
				}
				return false;
			}

			public ItemNumeroDeSerie Get(string number)
			{
				foreach( ItemNumeroDeSerie ins in List )
				{
					if (ins.NumeroDeSerie.Equals(number))
						return ins;
				}
				return null;
			}
			public void Remove(int index)
			{
				
			}
			#region Miembros de IEnumerator
			int index = -1;
			public void Reset()
			{
				index = -1;
			}

			public object Current
			{
				get
				{
					return base.List[ index ];
				}
			}

			public bool MoveNext()
			{
				index++;
				return index < base.Count;
			}

			#endregion


		}


		#endregion

		public RegistrarNumerosDeSerie()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			Init();
		}		


		#region variables , set y get
		private tlg_MovimientosDeStockNumerosDeSerieDataset _data = new tlg_MovimientosDeStockNumerosDeSerieDataset();
		private tlg_StockNumerosDeSerieDataset _dataStockNumerosDeSerie = new tlg_StockNumerosDeSerieDataset();
		
		ProcessManager _processParent = null;
		
		
		private string _leyendaFormulario = "Registración de Números de Serie";
		private bool _allowSeleccion = false;

		private string _idComprobante = string.Empty;
		private string _idDeposito = string.Empty;
		private string _idSeccion = string.Empty;
		string _idTipoDeAjuste = string.Empty;
		string _idEstadoDeStockOrigen = string.Empty;	
		string _idEstadoDeStockDestino = string.Empty;	
		private string _idDepositoDestino = string.Empty;
		private string _idSeccionDestino = string.Empty;
		string _idTipoDeAjusteDestino = string.Empty;
		Stock.OperationNumerosDeSerie _operation;
	

		private bool _hasShow = true;
		private string _idComprobanteDeCompra = string.Empty;
		private string _listaTiposDeArticulosBuscarNrosDeSeries = string.Empty;
		private bool _allowEditNroSerieSugerido = false;

		private IList _detalle = new ItemsNumerosDeSerie();

		string _nombreClienteComprobanteEntregaAsociado = string.Empty;

		
		bool _validarNroSerieEstadoStock = false;
		bool _validarExistenciaNroDeSerie = false;
		bool _advertirNroSerieEstadoStock = false;
		bool _advertirIngresoDeNroDeSerie = false;
		bool _validarIngresoDeNroDeSerie = false;

		private bool _buscayAsignaNumerosDeSeriesExistentes = false;

		
		
		public string NombreClienteComprobanteEntregaAsociado
		{
			get{return _nombreClienteComprobanteEntregaAsociado;}
		}
		public IList Detalle
		{
			set 
			{
				_detalle = (IList)value;
			}
			get 
			{ 
				return (IList)_detalle;
			}
		}
		
		public bool AllowSeleccion 
		{
			get { return _allowSeleccion; }
		}

		public ProcessManager GetProcessManagerParent()
		{
			return _processParent;
		}

		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_processParent = processManager;
		}

		#endregion

		#region Miembros de ITask

		
		#region Variables privadas ITASK
		
		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		
	
		#endregion

		public event System.EventHandler ObjectHasChanged;
		public event System.EventHandler OnTaskBeforeExecute;
		public event System.EventHandler OnTaskAfterExecute;
		public event System.EventHandler OnTaskBeforePrevious;
		public event System.EventHandler OnTaskAfterPrevious;

		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
		}

		public void ListenerTaskDependentChanged(object sender)
		{
			// TODO: agregar la implementación RegistrarNumerosDeSerie.ListenerTaskDependentChanged
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.comprobantes.ComprobanteDeCompra)))
			{
				ComprobanteDeCompra cc = (ComprobanteDeCompra) sender;
				LoadFromComprobanteDeCompra(cc);
			}
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.comprobantes.ComprobanteDeVenta)))
			{
				ComprobanteDeVenta cc = (ComprobanteDeVenta) sender;
				LoadFromComprobanteDeVenta(cc);
			}
			if (sender.GetType().Equals(typeof(mz.erp.businessrules.comprobantes.ComprobanteDeEntrega)))
			{
				ComprobanteDeEntrega ce = (ComprobanteDeEntrega) sender;
				LoadFromComprobanteDeEntrega(ce);
			}

			if (sender.GetType().Equals(typeof(mz.erp.businessrules.AjustarStock)) && !this._processParent.Process.ProcessName.Equals("ProcesoDevolucionMercaderiaAST"))
			{
				AjustarStock aj = (AjustarStock) sender;
				LoadFromAjustarStock(aj);
				if(this._processParent.Process.ProcessName.Equals("ProcesoTransferenciaMercaderiaAST"))
					EnableMustValidate();
			}
			if (sender.GetType().Equals(typeof(mz.erp.businessrules.AjustarStock)) && this._processParent.Process.ProcessName.Equals("ProcesoDevolucionMercaderiaAST"))
			{
				AjustarStock aj = (AjustarStock) sender;
				_idDeposito = aj.IdDeposito;
				_idSeccion = aj.IdSeccion;
				_idEstadoDeStockOrigen = aj.IdEstadoDeStock;
			}
			if (sender.GetType().Equals(typeof(mz.erp.businessrules.SeleccionarComprobantesConProductosPendientesDeNumeroDeSerie)))
			{
				SeleccionarComprobantesConProductosPendientesDeNumeroDeSerie se = (SeleccionarComprobantesConProductosPendientesDeNumeroDeSerie) sender;
				LoadFromSeleccionarComprobantesConProductosPendientesDeNumeroDeSerie(se);
			}
			if(this._processParent.Process.ProcessName.Equals("ProcesoDevolucionMercaderiaAST") && sender.GetType().Equals(typeof(mz.erp.businessrules.SeleccionarInstanciaOrdenReparacion)))
			{
				SeleccionarInstanciaOrdenReparacion sior = (SeleccionarInstanciaOrdenReparacion) sender;
				LoadSeleccionarInstanciaOrdenReparacion(sior);
			}
			/*Analizar con Oscar si es necesario*/
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.AjustarStockComprobantes)))
			{
				AjustarStockComprobantes asc = (AjustarStockComprobantes) sender;
				LoadFromAjustarStockComprobantes(asc);
			}
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.ObtenerComprobantesAsociados)))
			{
				ObtenerComprobantesAsociados cc = (ObtenerComprobantesAsociados) sender;
				LoadFromObtenerComprobantesAsociados(cc);
			}
			
		}

		private void EnableMustValidate()
		{
			foreach(ItemNumeroDeSerie item in this._detalle)
			{
				item.MustValidate = true;
			}
		}


		private void LoadFromObtenerComprobantesAsociados(ObtenerComprobantesAsociados obj)
		{
			if(this._processParent.Process.ProcessName.Equals("ProcesoEntregar"))
			{
				//this._detalle.Clear();
				ArrayList IdComprobantes = obj.ListaIdComprobantesHaciaAtrasAdelante;
				foreach(string IdComprobante in IdComprobantes)
				{
					DataSet dataNroSeries = mz.erp.dataaccess.tsa_ComprobantesMovimientosDeStock.GetNumerosDeSerieByComprobante(IdComprobante);
					foreach(DataRow row in dataNroSeries.Tables[0].Rows)
					{
						string IdProducto = Convert.ToString(row["IdProducto"]);
						string NumeroDeSerie = Convert.ToString(row["NumeroDeSerie"]);
						ArrayList prodSinNroSerie = ((ItemsNumerosDeSerie)this._detalle).Filter(IdProducto, string.Empty);
						if(prodSinNroSerie.Count > 0)
						{
							ItemNumeroDeSerie item = (ItemNumeroDeSerie)prodSinNroSerie[0];
							item.NumeroDeSerie = NumeroDeSerie;
						}
					

					}
				}

			}
		}

		private void LoadFromAjustarStockComprobantes (AjustarStockComprobantes asc)
		{
			Hashtable ordenReparacionInstancias = asc.OrdenReparacionInstancias;
			string estadosDeStock = asc.EstadosDeStockNumerosDeSeries;
			this._detalle.Clear();
			foreach(long IdOrdenReparacion  in ordenReparacionInstancias.Keys)
			{
				ArrayList instancias = (ArrayList) ordenReparacionInstancias[IdOrdenReparacion];
				foreach(long IdIsntanciaOrdenReparacion in instancias)
				{
					DataSet data = mz.erp.businessrules.st_OrdenReparacion.GetNumerosDeSeriesParaDevolver(IdOrdenReparacion, IdIsntanciaOrdenReparacion, estadosDeStock);
					foreach (DataRow row in data.Tables[0].Rows) 
					{				
						ItemNumeroDeSerie itemNroSerie = new ItemNumeroDeSerie();
						itemNroSerie.VerifyRepeat = false;
						itemNroSerie.Parent = this._detalle;
						itemNroSerie.Codigo = row["Codigo"].ToString();
						itemNroSerie.Descripcion = row["Descripcion"].ToString();
						itemNroSerie.IdOrdinal = 0;
						itemNroSerie.IdProducto = row["IdProducto"].ToString();
						itemNroSerie.NumeroDeSerie = row["NumeroDeSerie"].ToString();
						itemNroSerie.Seleccion = false;
						itemNroSerie.IdOrdenReparacion = IdOrdenReparacion;
						itemNroSerie.IdInstanciaOrdenReparacion = IdIsntanciaOrdenReparacion;
						/*Puede haber numeros de Serie repetidos*/
						((ItemsNumerosDeSerie)this._detalle).Add(itemNroSerie,true);										
					}
					
		
				}
			}
			((ItemsNumerosDeSerie)this._detalle).RebuildIDs();
		}
		private void LoadFromComprobanteDeVenta (ComprobanteDeVenta comprobante)
		{
			this._detalle.Clear();			
			_idDeposito = comprobante.IdDeposito;
			_idSeccion = comprobante.IdSeccion;
			//_nombreClienteComprobanteEntregaAsociado = comprobante.Cuenta.Nombre;
			ArrayList TiposDeArticulos = mz.erp.systemframework.Util.Parse(_listaTiposDeArticulosBuscarNrosDeSeries, ",");
			foreach(ItemComprobante item in comprobante.Items)
			{
				DataRow rowP = mz.erp.businessrules.tsh_Productos.GetByPk(item.IdProducto);
				bool ok = false;
				if(rowP != null)
					ok = Convert.ToBoolean(rowP["ObligaNumeroSerie"]);
				if(ok)
				{
					decimal cant = item.Cantidad;
					for(int i = 0; i < cant ; i++)
					{
						ItemNumeroDeSerie itemNroSerie = new ItemNumeroDeSerie();
						itemNroSerie.Parent = this._detalle;
						itemNroSerie.Codigo = item.Codigo;
						itemNroSerie.Descripcion = item.Descripcion;
						itemNroSerie.IdOrdinal = item.Ordinal;
						itemNroSerie.IdProducto = item.IdProducto;
						itemNroSerie.NumeroDeSerie = string.Empty;
						itemNroSerie.TipoProducto = Convert.ToString(rowP["IdTipoProducto"]);
						this._detalle.Add(itemNroSerie);
					}
				}
			}
			/*Hashtable tabla = new Hashtable();
			foreach(ItemNumeroDeSerie item in this._detalle)
			{
				if(TiposDeArticulos.Contains(item.TipoProducto))
				{
					if(!tabla.ContainsKey(item.IdProducto))
					{
						ArrayList numerosDeSeries = GetNumerosDeSerieParaBaja(item.IdProducto, _idEstadoDeStockOrigen);
						tabla.Add(item.IdProducto, numerosDeSeries);
					}
					ArrayList nros  = (ArrayList) tabla[item.IdProducto];
					if(nros.Count > 0)
					{
						item.NumeroDeSerie = Convert.ToString(nros[0]);
						nros.RemoveAt(0);
					}
				}
			}
			if(comprobante.Items.Count > 0)
			{
				((ItemsNumerosDeSerie)this._detalle).RebuildIDs();
				if(ObjectHasChanged != null)
					ObjectHasChanged(this, new EventArgs());
			}*/
			((ItemsNumerosDeSerie)this._detalle).RebuildIDs();

		}
		private void LoadSeleccionarInstanciaOrdenReparacion(SeleccionarInstanciaOrdenReparacion sior)
		{
			long IdInstanciaOR = sior.IdInstanciaOrdenReparacion;
			string IdOrdenReparacion = sior.IdOrdenReparacion.ToString();
			/*
			 * 
			 * 
			 * Esta Variable si es necesaria
			 * 
			 * 
			 * */
			string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "EstadosDeStock";
			string IdEstadosDeStock = Variables.GetValueString(variable);			
			
			this._detalle.Clear();
			DataSet data = mz.erp.businessrules.st_OrdenReparacion.GetProductosParaDevolver(IdOrdenReparacion, IdInstanciaOR, IdEstadosDeStock);

			int i = 0;
			foreach (DataRow row in data.Tables[0].Rows) 
			{				
				int cant = Convert.ToInt32(Math.Abs(Convert.ToDecimal(row["Cantidad"])));
				for (int j = 0; j < cant; j++) 
				{
					ItemNumeroDeSerie itemNroSerie = new ItemNumeroDeSerie();
					itemNroSerie.VerifyRepeat = false;
					itemNroSerie.Parent = this._detalle;
					itemNroSerie.Codigo = row["Codigo"].ToString();
					itemNroSerie.Descripcion = row["Descripcion"].ToString();
					itemNroSerie.IdOrdinal = i;
					itemNroSerie.IdProducto = row["IdProducto"].ToString();
					itemNroSerie.NumeroDeSerie = row["NumeroDeSerie"].ToString();
					itemNroSerie.Seleccion = false;
					/*Puede haber numeros de Serie repetidos*/
					((ItemsNumerosDeSerie)this._detalle).Add(itemNroSerie,true);										
					i++;
				}
				
			}
			((ItemsNumerosDeSerie)this._detalle).RebuildIDs();
		}

		private void LoadFromSeleccionarComprobantesConProductosPendientesDeNumeroDeSerie(SeleccionarComprobantesConProductosPendientesDeNumeroDeSerie ss)
		{
			this._detalle.Clear();
			_idDeposito = Variables.GetValueString("Momentos." + _taskName + "." + _processParent.Process.ProcessName + ".IdDeposito");
			_idSeccion = Variables.GetValueString("Momentos." + _taskName + "." + _processParent.Process.ProcessName + ".IdSeccion");
			ArrayList productos = ss.ProductosPendientesDeNumeroDeSerie;
			if(ss.ArrayIdComporbantesPendientes.Count > 0) _idComprobanteDeCompra = Convert.ToString(ss.ArrayIdComporbantesPendientes[0]);
			foreach(ProductoNumeroDeSerie item in productos)
			{
				decimal cant = item.Cantidad;
				for(int i = 0; i < cant ; i++)
				{
					ItemNumeroDeSerie itemNroSerie = new ItemNumeroDeSerie();
					itemNroSerie.Parent = this._detalle;
					itemNroSerie.Codigo = item.Codigo;
					itemNroSerie.Descripcion = item.Descripcion;
					itemNroSerie.IdOrdinal = i;
					itemNroSerie.IdProducto = item.IdProducto;
					itemNroSerie.NumeroDeSerie = string.Empty;
					this._detalle.Add(itemNroSerie);
				}
			}
			if(productos.Count > 0)
			{
				((ItemsNumerosDeSerie)this._detalle).RebuildIDs();
				if(ObjectHasChanged != null)
					ObjectHasChanged(this, new EventArgs());
			}
		}
		

		private void LoadFromAjustarStock(AjustarStock ajuste)
		{
			
			
			
			if(ajuste.GetTaskName().Equals("AjustarStockDestino"))
			{
				_idTipoDeAjusteDestino = ajuste.IdTipoDeAjuste;
				_idEstadoDeStockDestino = ajuste.IdEstadoDeStock;
				_idDepositoDestino = ajuste.IdDeposito;
				_idSeccionDestino = ajuste.IdSeccion;
			}
			else
			{
				_idTipoDeAjuste = ajuste.IdTipoDeAjuste;
				_idEstadoDeStockOrigen = ajuste.IdEstadoDeStock;
				_idDeposito = ajuste.IdDeposito;
				_idSeccion = ajuste.IdSeccion;
			}
			Table table = new Table();
			table.Generate((ItemsNumerosDeSerie)this._detalle);
			Table tableAjustes = new Table();
			tableAjustes.Generate(ajuste.Items);
			foreach(ItemAjuste item in ajuste.Items)
			{
				DataRow rowP = mz.erp.businessrules.tsh_Productos.GetByPk(item.IdProducto);
				bool ok = false;
				if(rowP != null)
					ok = Convert.ToBoolean(rowP["ObligaNumeroSerie"]);
				if(ok)
				{
					int ordinal = 0;
					decimal cant = tableAjustes.Get(item.Codigo);
					decimal cantAgregados = 0;
					decimal cantYaAgregados = table.Get(item.Codigo);
					for(int i = 0; i < cant - cantYaAgregados ; i++)
					{
						ItemNumeroDeSerie itemNroSerie = new ItemNumeroDeSerie();
						itemNroSerie.Parent = this._detalle;
						itemNroSerie.Codigo = item.Codigo;
						itemNroSerie.Descripcion = item.Descripcion;
						itemNroSerie.IdOrdinal = ordinal;
						itemNroSerie.IdProducto = item.IdProducto;
						itemNroSerie.NumeroDeSerie = string.Empty;
						((ItemsNumerosDeSerie)this._detalle).Add(itemNroSerie);
						table.Add(item.Codigo,1);
						ordinal++;
					}
				}
			}
			table.Minus(tableAjustes);
			ArrayList keys = table.Keys();
			foreach(string codigo in keys)
			{
				decimal cantAEliminar = table.Get(codigo);
				if(cantAEliminar > 0)
				{
					
					ItemsNumerosDeSerie items = (ItemsNumerosDeSerie)this._detalle;
					ArrayList result = items.Filter(codigo,string.Empty,long.MinValue);
					if(result.Count >= cantAEliminar)
					{
						for(int j = 0; j < cantAEliminar; j++)
						{
							ItemNumeroDeSerie it = (ItemNumeroDeSerie) result[j];
							items.Remove(it);
						}
					}
					else
					{
						
						
						if(result.Count > 0)
						{
							decimal cantAEliminarSinNroSerie = cantAEliminar - result.Count;
							for(int k = 0; k < cantAEliminarSinNroSerie; k++)
							{
								if (k < result.Count) 
								{
									ItemNumeroDeSerie it = (ItemNumeroDeSerie) result[k];
									items.Remove(it);
									cantAEliminar--;
								}
							}
						}
						decimal cantAEliminarConNroSerie = cantAEliminar;
						result = items.Filter(codigo,null,long.MinValue);
						for(int h = 0; h < cantAEliminarConNroSerie; h++)
						{
							ItemNumeroDeSerie it = (ItemNumeroDeSerie) result[h];
							items.Remove(it);
						}
					}
				}

			}
			ItemsNumerosDeSerie its = (ItemsNumerosDeSerie)this._detalle;
			its.RebuildIDs();
			//if(this._processParent.Process.ProcessName.Equals("ProcesoAjustarStockNegativo"))
			if(_buscayAsignaNumerosDeSeriesExistentes)
			{
				BuscarYAsignarNumerosDeSeriesExistentes();

			}
			if(ObjectHasChanged != null)
					ObjectHasChanged(this, new EventArgs());
			
			
		}


		private void BuscarYAsignarNumerosDeSeriesExistentes()
		{
			Hashtable tabla = new Hashtable();
			foreach(ItemNumeroDeSerie item in this._detalle)
			{
				if(!tabla.ContainsKey(item.IdProducto))
				{
					ArrayList numerosDeSeries = GetNumerosDeSerieParaBaja(item.IdProducto, _idEstadoDeStockOrigen);
					tabla.Add(item.IdProducto, numerosDeSeries);
				}
				ArrayList nros  = (ArrayList) tabla[item.IdProducto];
				if(nros.Count > 0)
				{
					item.NumeroDeSerie = Convert.ToString(nros[0]);
					nros.RemoveAt(0);
				}
			}

		}
		private ArrayList GetNumerosDeSerieParaBaja(string IdProducto, string IdEstadoDeStock)
		{
			ArrayList result = new ArrayList();
			/*Deprecated*/
			/*DataSet data = mz.erp.businessrules.tlg_MovimientosDeStockNumerosDeSerie.GetNumerosDeSerieParaBaja(IdProducto, IdEstadoDeStock);*/
			/*Por ahora no se tiene en cuenta el estado de stock - Analizar su inclusion*/
			DataSet data = mz.erp.businessrules.tlg_StockNumerosDeSerie.GetNumerosDeSerieParaBaja(IdProducto,_idDeposito, _idSeccion, IdEstadoDeStock );
			foreach(DataRow row in data.Tables[0].Rows)
			{
				result.Add(row["NumeroDeSerie"]);
			}
			return result;
		}


		public bool PermiteModificarNroSerieSugerido(ItemNumeroDeSerie item)
		{
			ArrayList TiposDeArticulos = mz.erp.systemframework.Util.Parse(_listaTiposDeArticulosBuscarNrosDeSeries, ",");
			if(item.TipoProducto != null && item.TipoProducto != string.Empty)
			{
				if(TiposDeArticulos.Contains(item.TipoProducto))
				{
					return _allowEditNroSerieSugerido;
				}
			}
			return true;
		}

		
		private void LoadFromComprobanteDeEntrega( ComprobanteDeEntrega comprobante)
		{
			this._detalle.Clear();			
			_idDeposito = comprobante.IdDeposito;
			_idSeccion = comprobante.IdSeccion;
			_nombreClienteComprobanteEntregaAsociado = comprobante.Cuenta.Nombre;
			ArrayList TiposDeArticulos = mz.erp.systemframework.Util.Parse(_listaTiposDeArticulosBuscarNrosDeSeries, ",");
            foreach(ItemComprobante item in comprobante.Items)
			{
				
				DataRow rowP = mz.erp.businessrules.tsh_Productos.GetByPk(item.IdProducto);
				bool ok = false;
				if(rowP != null)
					ok = Convert.ToBoolean(rowP["ObligaNumeroSerie"]);
				if(ok)
				{
					decimal cant = item.Cantidad;
					for(int i = 0; i < cant ; i++)
					{
						ItemNumeroDeSerie itemNroSerie = new ItemNumeroDeSerie();
						itemNroSerie.Parent = this._detalle;
						itemNroSerie.Codigo = item.Codigo;
						itemNroSerie.Descripcion = item.Descripcion;
						itemNroSerie.IdOrdinal = item.Ordinal;
						itemNroSerie.IdProducto = item.IdProducto;
						itemNroSerie.NumeroDeSerie = string.Empty;
						itemNroSerie.TipoProducto = Convert.ToString(rowP["IdTipoProducto"]);
						this._detalle.Add(itemNroSerie);
					}
				}
			}
			Hashtable tabla = new Hashtable();
			foreach(ItemNumeroDeSerie item in this._detalle)
			{
				if(TiposDeArticulos.Contains(item.TipoProducto))
				{
					if(!tabla.ContainsKey(item.IdProducto))
					{
						ArrayList numerosDeSeries = GetNumerosDeSerieParaBaja(item.IdProducto, _idEstadoDeStockOrigen);
						tabla.Add(item.IdProducto, numerosDeSeries);
					}
					ArrayList nros  = (ArrayList) tabla[item.IdProducto];
					if(nros.Count > 0)
					{
						item.NumeroDeSerie = Convert.ToString(nros[0]);
						nros.RemoveAt(0);
					}
				}
			}
			if(comprobante.Items.Count > 0)
			{
				((ItemsNumerosDeSerie)this._detalle).RebuildIDs();
				if(ObjectHasChanged != null)
					ObjectHasChanged(this, new EventArgs());
			}
			
		}
		private void LoadFromComprobanteDeCompra(ComprobanteDeCompra comprobante)
		{
			if(!comprobante.IdComprobante.Equals(_idComprobante))
			{
				_idComprobante = comprobante.IdComprobante;
				_detalle.Clear();
			}
			_idDeposito = comprobante.IdDeposito;
			_idSeccion = comprobante.IdSeccion;
			foreach(ItemComprobanteCompra item in comprobante.Items)
			{
				DataRow rowP = mz.erp.businessrules.tsh_Productos.GetByPk(item.IdProducto);
				bool ok = false;
				if(rowP != null)
					ok = Convert.ToBoolean(rowP["ObligaNumeroSerie"]);
				if(ok)
				{
					decimal cant = item.Cantidad;
					decimal cantAgregados = 0;
					if(!((ItemsNumerosDeSerie)this._detalle).Contains(item.Codigo, item.Ordinal))
					{
						for(int i = 0; i < cant ; i++)
						{
					
					
							ItemNumeroDeSerie itemNroSerie = new ItemNumeroDeSerie();
							itemNroSerie.Parent = this._detalle;
							itemNroSerie.Codigo = item.Codigo;
							itemNroSerie.Descripcion = item.Descripcion;
							itemNroSerie.IdOrdinal = item.Ordinal;
							itemNroSerie.IdProducto = item.IdProducto;
							itemNroSerie.NumeroDeSerie = string.Empty;						
							this._detalle.Add(itemNroSerie);
						}
					}
					else
					{
						cantAgregados = ((ItemsNumerosDeSerie)this._detalle).Filter(item.Codigo, null, item.Ordinal).Count;
						if(cantAgregados > cant)
						{
							decimal cantAEliminar = cantAgregados -  cant;
							ItemsNumerosDeSerie items = (ItemsNumerosDeSerie)this._detalle;
							ArrayList result = items.Filter(item.Codigo,string.Empty,item.Ordinal);
							if(result.Count >= cantAEliminar)
							{
								for(int j = 0; j < cantAEliminar; j++)
								{
									ItemNumeroDeSerie it = (ItemNumeroDeSerie) result[j];
									items.Remove(it);
								}
							}
							else
							{
								decimal cantAEliminarSinNroSerie = cantAEliminar - result.Count;
								decimal cantAEliminarConNroSerie = cantAEliminar - cantAEliminarSinNroSerie;
								for(int k = 0; k < cantAEliminarSinNroSerie; k++)
								{
									ItemNumeroDeSerie it = (ItemNumeroDeSerie) result[k];
									items.Remove(it);
								}
								result = items.Filter(item.Codigo,null,item.Ordinal);
								for(int h = 0; h < cantAEliminarConNroSerie; h++)
								{
									ItemNumeroDeSerie it = (ItemNumeroDeSerie) result[h];
									items.Remove(it);
								}
							}
						}
						else
						{
							if(cant > cantAgregados)
							{
								decimal cantAgregar = cant - cantAgregados;
								for(int i = 0; i < cantAgregar ; i++)
								{
					
					
									ItemNumeroDeSerie itemNroSerie = new ItemNumeroDeSerie();
									itemNroSerie.Parent = this._detalle;
									itemNroSerie.Codigo = item.Codigo;
									itemNroSerie.Descripcion = item.Descripcion;
									itemNroSerie.IdOrdinal = item.Ordinal;
									itemNroSerie.IdProducto = item.IdProducto;
									itemNroSerie.NumeroDeSerie = string.Empty;						
									this._detalle.Add(itemNroSerie);
								}

							}
						}
					}
				
				}
			}
			ArrayList itemsAEliminar = new ArrayList();
			foreach(ItemNumeroDeSerie itemNroSerie in this._detalle)
			{
				if(!comprobante.Items.Contains(itemNroSerie.Codigo, itemNroSerie.IdOrdinal))
				{
					itemsAEliminar.Add(itemNroSerie.Codigo);
					itemsAEliminar.Add(itemNroSerie.IdOrdinal);
				}
			}
			for(int index = 0; index < (itemsAEliminar.Count/2); index++)
			{
				string codigo = Convert.ToString(itemsAEliminar[index*2]);
				long ordinal = Convert.ToInt64(itemsAEliminar[index*2 + 1]);
				ItemsNumerosDeSerie items = (ItemsNumerosDeSerie)this._detalle;
				ArrayList filtrados = items.Filter(codigo, null, ordinal);
				foreach(ItemNumeroDeSerie itemNS in filtrados)
				{
					items.Remove(itemNS);
				}
			}
			ItemsNumerosDeSerie its = (ItemsNumerosDeSerie)this._detalle;
			its.RebuildIDs();
            //German 20110309 - tarea 0000038
			/*
            if(comprobante.IsStep && (_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia")
				|| _processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior")
				))
             * */
            if (comprobante.IsStep && Workflow.EsProcesoDeConfirmacionDePrecios(_processParent.Process.ProcessName))
            //Fin German 20110309 - tarea 0000038
			{
				/*Hay q recuperar los Numeros de Serie q fueron ingresados con el remito de compra*/
				this._hasShow = false;
				string IdComprobante = comprobante.IdComprobanteOrigen;

				/* Arreglar este SP*/
				DataSet dataNroSeries = mz.erp.businessrules.tpu_ComprobantesMovimientosDeStock.GetNumerosDeSerieByComprobante(IdComprobante);
				/*******************/
				foreach(DataRow row in dataNroSeries.Tables[0].Rows)
				{
					string IdProducto = Convert.ToString(row["IdProducto"]);
					string NumeroDeSerie = Convert.ToString(row["NumeroDeSerie"]);
					ArrayList prodSinNroSerie = ((ItemsNumerosDeSerie)this._detalle).Filter(IdProducto, string.Empty);
					if(prodSinNroSerie.Count > 0)
					{
						ItemNumeroDeSerie item = (ItemNumeroDeSerie)prodSinNroSerie[0];
						item.NumeroDeSerie = NumeroDeSerie;
					}
					

				}

			}
			if(comprobante.Items.Count > 0)
			{
				if(ObjectHasChanged != null)
					ObjectHasChanged(this, new EventArgs());
			}
		}
		
		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación RegistrarNumerosDeSerie.ListenerBeforeExecuteDependentTask
		}

		public void Init()
		{
			// TODO: agregar la implementación RegistrarNumerosDeSerie.Init
			if (this._processParent != null) 
			{
				if (this._processParent.Process.ProcessName.Equals("ProcesoDevolucionMercaderiaAST"))
				{				
					_allowSeleccion = true;
				}
				_operation = Stock.GetOperacionNumerosDeSerie(this._processParent.Process.ProcessName, this._taskName);
				switch (_operation)
				{
					
					case Stock.OperationNumerosDeSerie.Insert:
					{
						_idEstadoDeStockOrigen = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "IdEstadoDeStockOrigen");
						_idDeposito = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "IdDeposito");
						_idSeccion = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "IdSeccion");
					}
					break;
					case Stock.OperationNumerosDeSerie.Delete:
					{
						_idEstadoDeStockOrigen = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "IdEstadoDeStockOrigen");
						_idDeposito = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "IdDeposito");
						_idSeccion = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "IdSeccion");
					}
					break;
					case Stock.OperationNumerosDeSerie.DeleteInsert:
					{
						_idEstadoDeStockOrigen = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "IdEstadoDeStockOrigen");
						_idEstadoDeStockDestino = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "IdEstadoDeStockDestino");
						_idDeposito = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "IdDeposito");
						_idSeccion = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "IdSeccion");
					}
					break;

				}
				_listaTiposDeArticulosBuscarNrosDeSeries = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "ListaTipoProductoSugerirNroDeSerie");
				_allowEditNroSerieSugerido = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "PermiteCambiarNumeroDeSerieSugerido");
				_validarNroSerieEstadoStock = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "ValidarNroSerieEstadoStock");		
				_validarExistenciaNroDeSerie = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName,"ValidarExistenciaNroDeSerie");
				_advertirNroSerieEstadoStock = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName,"MostrarWarning.NroSerieEstadoStock");
				_advertirIngresoDeNroDeSerie = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName,"MostrarWarning.NroSerieNoVacio");
				_validarIngresoDeNroDeSerie = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName,"ValidarNroSerieNoVacio");
				_buscayAsignaNumerosDeSeriesExistentes = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName,"BuscaYAsignaNumerosDeSeriesExistentes");
				
			

			}				
		}

		private ArrayList _numerosDeSeriesRepetidos = new ArrayList();
		/**
		 * Este metodo valida q los numeros de series asociados a un producto no existan.
		 * Para ello verifica en la pila de numeros de serie, sin tener en cuenta el estado de stock,
		 * el deposito y la seccion. Analizar performance dada q la busqueda esta impelementada
		 * con el SP Search
		 * */
		
		private bool IsValidNumeroDeSerie()
		{
			_numerosDeSeriesRepetidos.Clear();
			foreach(ItemNumeroDeSerie item in this._detalle)
			{
				if(item.MustValidate)
				{
					string nroSerie = item.NumeroDeSerie;
					string IdProducto = item.IdProducto;
					string Descripcion = item.Descripcion;
					string codigo = item.Codigo;
					if(nroSerie != null && !nroSerie.Trim().Equals(string.Empty))
					{
						/*Deprecated*/
						//if(mz.erp.businessrules.tlg_MovimientosDeStockNumerosDeSerie.ExistsNueroDeSerie(nroSerie, IdProducto, _idEstadoDeStockOrigen))
						/*Por ahora no se tiene en cuenta el estado de Stock - Analizar su inclusion*/
                       
						if(item.CodigoSecundario != null && item.CodigoSecundario != string.Empty && item.CodigoSecundario.ToUpper().Equals(nroSerie.ToUpper()))
						{
							ArrayList aux = new ArrayList();
							aux.Add(nroSerie);
							aux.Add(Descripcion);
							_numerosDeSeriesRepetidos.Add(aux);
						}
						else
						if(mz.erp.businessrules.tlg_StockNumerosDeSerie.ExistsNumeroDeSerie(IdProducto, nroSerie))
						{
							ArrayList aux = new ArrayList();
							aux.Add(nroSerie);
							aux.Add(Descripcion);
							_numerosDeSeriesRepetidos.Add(aux);

						}
					}
				}
				

			}
			return _numerosDeSeriesRepetidos.Count == 0;
		}

		private Hashtable _numerosDeSerieInvalidos = new Hashtable();
		private bool ExistsNumerosDeSerieEstadoDeStock()
		{
			_numerosDeSerieInvalidos.Clear();
			Hashtable table = new Hashtable();
			bool existe = false;
			foreach(ItemNumeroDeSerie item in _detalle)
			{
				if(item.MustValidate)
				{
					ArrayList nrosDeSeriesExistentes = new ArrayList();
					if(!table.ContainsKey(item.IdProducto))
					{
						nrosDeSeriesExistentes = GetNumerosDeSerieParaBaja(item.IdProducto, _idEstadoDeStockOrigen);
						table.Add(item.IdProducto, nrosDeSeriesExistentes);
					}
					else 
						nrosDeSeriesExistentes = (ArrayList)table[item.IdProducto];

					if(item.NumeroDeSerie != null && !item.NumeroDeSerie.Equals(string.Empty) && !nrosDeSeriesExistentes.Contains(item.NumeroDeSerie))
					{	
						existe = true;
						if(!_numerosDeSerieInvalidos.ContainsKey(item.Codigo))
							_numerosDeSerieInvalidos.Add(item.Codigo, new ArrayList());
						ArrayList numeros = (ArrayList)_numerosDeSerieInvalidos[item.Codigo];
						numeros.Add(item.NumeroDeSerie);
					}
				}

			}
			return existe;

		}
	
		public bool IsValid()
		{			
			bool IsValid = true;
			
			_errores.Clear();
			if(_validarIngresoDeNroDeSerie)
			{
				foreach(ItemNumeroDeSerie item in _detalle)
				{
					if(item.MustValidate)
					{
						if(item.NumeroDeSerie == string.Empty)
						{
							IsValid = false;
							_errores.Add( new ItemDatasetError( "Numero De Serie","Numeros de Series","Se deben ingresar todos los numeros de series"));
							break;
						}

					}
				}
				
			}
			if(_validarExistenciaNroDeSerie)
			{
				if(!IsValidNumeroDeSerie())
				{
					IsValid = false;
					foreach(ArrayList nrosSerieRepetido in _numerosDeSeriesRepetidos)
					{
						string nroSerie = Convert.ToString(nrosSerieRepetido[0]);
						string descripcion = Convert.ToString(nrosSerieRepetido[1]);
						_errores.Add( new ItemDatasetError( "Numero De Serie","Numero de Serie","El Numero de Serie "+ nroSerie + " ya ha sido ingresado para el producto " + descripcion + " o es igual al codigo secundario"));
					}
				}
			}
			/*
			   Se valida q los Nro de Serie Seleccionados existan en el Estado de Stock determinado por el 
			 * ajuste de Stock q se esta llevando a cabo o q se obtiene de variable de sistema
			 */				
			if (_validarNroSerieEstadoStock) 
			{
				if(ExistsNumerosDeSerieEstadoDeStock())
				{
					IsValid = false;
					foreach(string codigo in this._numerosDeSerieInvalidos.Keys)
					{
						ArrayList numeros = (ArrayList) _numerosDeSerieInvalidos[codigo];
						foreach(string nroSerie in numeros)
						{					
							_errores.Add( new ItemDatasetError( "Numero De Serie","Producto: " + codigo,"El Numero de Serie "+ nroSerie + " No es valido"));
						}
					}
				}
			}
			//}
			
			if(this._processParent.Process.ProcessName.Equals("ProcesoDevolucionMercaderiaAST"))
			{				
				if (_detalle.Count == 0) 
				{
					_errores.Add( new ItemDatasetError( "Devolución de mercadería","Mercadería","No hay ítems para devolver"));
				}				
			}
			
			
			return IsValid;
		}
	
		public bool AllowShow()
		{
			return _hasShow && this._detalle.Count > 0;
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
			
			string result = string.Empty;
			bool ok = true;
			if(_advertirIngresoDeNroDeSerie)
			{
				foreach(ItemNumeroDeSerie item in _detalle)
				{
					if(item.MustValidate)
					{
						if(item.NumeroDeSerie == string.Empty)
						{
							ok = false;
							break;
						}

					}
				}
				if(!ok)
					return "No se han Ingresado todos los numeros de series. Presione Cancelar para ingresarlos o Aceptar para continuar.";
			}
			if (_advertirNroSerieEstadoStock) 
			{
				if(ExistsNumerosDeSerieEstadoDeStock())
				{
					result = "Los siguientes Productos tienen numeros de series invalidos. Presione Cancelar para cambiarlos o Aceptar para Continuar. ";
					foreach(string codigo in this._numerosDeSerieInvalidos.Keys)
					{
						ArrayList numeros = (ArrayList) _numerosDeSerieInvalidos[codigo];
						foreach(string nroSerie in numeros)
						{					
							if(nroSerie != string.Empty)
								result = result + "Producto: " + codigo + ". El Numero de Serie "+ nroSerie + " No es válido. ";
						}
					}
					return result;
				}
				else return null;
			}
			else return null;
		}

		public string GetTaskName()
		{
			return this._taskName;
		}

		public void SetTaskName(string taskName)
		{
			this._taskName = taskName;
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
			// TODO: agregar la implementación RegistrarNumerosDeSerie.ListenerAfterPreviousDependentTask
		}

		public void ListenerBeforePreviousDependentTask(object sender)
		{
			// TODO: agregar la implementación RegistrarNumerosDeSerie.ListenerBeforePreviousDependentTask
		}
		public void Continue()
		{
			_processParent.MostroWarnings = true;
			OnTaskAfterExecute(this, new EventArgs());		
		}

		#endregion

		#region Miembros de IPersistentTask

		public event System.EventHandler OnTaskBeforeFlush;
		public event System.EventHandler OnTaskAfterFlush;

		public ArrayList GetDataList()
		{
			ArrayList array = new ArrayList();
			return null;
		}

		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();
			data.Add( (DataSet) this._data);
			data.Add( (DataSet) this._dataStockNumerosDeSerie);
			return data;
			
		}

	
		public void Commit()
		{
			
			if(this._processParent.Process.ProcessName.Equals("ProcesoRegistrarNumerosDeSeriesPendientes"))
			{
				
				#region Remito de Compra
				Hashtable table = new Hashtable();
				Hashtable auxDestino = new Hashtable();
				Hashtable auxOrigen = new Hashtable();
				table = GenerateTableComprobanteOrigen(_idComprobanteDeCompra);
				mz.erp.commontypes.data.tlg_MovimientosDeStockNumerosDeSerieDataset.tlg_MovimientosDeStockNumerosDeSerieRow _rowMovimientosNumerosDeSerie ;
                Hashtable infoMovimmientos = new Hashtable();
				foreach (ItemNumeroDeSerie item in this._detalle)
				{
					if (item.NumeroDeSerie.CompareTo( string.Empty ) != 0)
					{
							/*Asocia la Movimiento destino*/
							
						ArrayList arrayAux = (ArrayList)table[item.IdProducto];
						Hashtable tempDestino = (Hashtable)arrayAux[0];
						foreach(string IdMov in tempDestino.Keys)
						{
							if(!infoMovimmientos.ContainsKey(IdMov))
							{
								DataRow rowMov = mz.erp.businessrules.tlg_MovimientosDeStock.GetByPk(IdMov);
								ArrayList auxInfoMov = new ArrayList();
								auxInfoMov.Add(Convert.ToString(rowMov["IdDeposito"]));
								auxInfoMov.Add(Convert.ToString(rowMov["IdSeccion"]));
								auxInfoMov.Add(Convert.ToString(rowMov["IdEstadoDeStock"]));
								infoMovimmientos.Add(IdMov, auxInfoMov);
							}
							decimal cant =  Convert.ToDecimal(tempDestino[IdMov]);
							if(cant > 0)
							{	
								if(!auxDestino.ContainsKey(IdMov)) auxDestino.Add(IdMov, 0);
								if(cant > Convert.ToDecimal(auxDestino[IdMov]))
								{
									
									_rowMovimientosNumerosDeSerie = mz.erp.businessrules.tlg_MovimientosDeStockNumerosDeSerie.NewRow();
									_rowMovimientosNumerosDeSerie.NumeroDeSerie = item.NumeroDeSerie;
									_rowMovimientosNumerosDeSerie.IdMovimientoDeStock =IdMov;
									ArrayList aux = (ArrayList)infoMovimmientos[IdMov];
									string IdDeposito = Convert.ToString(aux[0]);
									string IdSeccion = Convert.ToString(aux[1]);
									string IdEstadoDeStock = Convert.ToString(aux[2]);
                                   item.AddMovimiento(IdMov,IdDeposito, IdSeccion, IdEstadoDeStock,1);
									this._data.tlg_MovimientosDeStockNumerosDeSerie.Rows.Add(  _rowMovimientosNumerosDeSerie.ItemArray );
									auxDestino[IdMov] = Convert.ToDecimal(auxDestino[IdMov])+1;
									break;
								}
							}
						}

						/*Asocia la Movimiento Origen*/
						arrayAux = (ArrayList)table[item.IdProducto];
						Hashtable tempOrigen = (Hashtable)arrayAux[1];
						
						foreach(string IdMov in tempOrigen.Keys)
						{
							if(!infoMovimmientos.ContainsKey(IdMov))
							{
								DataRow rowMov = mz.erp.businessrules.tlg_MovimientosDeStock.GetByPk(IdMov);
								ArrayList auxInfoMov = new ArrayList();
								auxInfoMov.Add(Convert.ToString(rowMov["IdDeposito"]));
								auxInfoMov.Add(Convert.ToString(rowMov["IdSeccion"]));
								auxInfoMov.Add(Convert.ToString(rowMov["IdEstadoDeStock"]));
								infoMovimmientos.Add(IdMov, auxInfoMov);
							}
							decimal cant =  Math.Abs(Convert.ToDecimal(tempOrigen[IdMov]));
							if(cant > 0)
							{	
								if(!auxOrigen.ContainsKey(IdMov)) auxOrigen.Add(IdMov, 0);
								if(cant > Convert.ToDecimal(auxOrigen[IdMov]))
								{
									_rowMovimientosNumerosDeSerie = mz.erp.businessrules.tlg_MovimientosDeStockNumerosDeSerie.NewRow();
									_rowMovimientosNumerosDeSerie.NumeroDeSerie = item.NumeroDeSerie;
									_rowMovimientosNumerosDeSerie.IdMovimientoDeStock =IdMov;
									ArrayList aux = (ArrayList)infoMovimmientos[IdMov];
									string IdDeposito = Convert.ToString(aux[0]);
									string IdSeccion = Convert.ToString(aux[1]);
									string IdEstadoDeStock = Convert.ToString(aux[2]);
									item.AddMovimiento(IdMov,IdDeposito, IdSeccion, IdEstadoDeStock,-1);
									this._data.tlg_MovimientosDeStockNumerosDeSerie.Rows.Add(  _rowMovimientosNumerosDeSerie.ItemArray );
									auxOrigen[IdMov] = Convert.ToDecimal(auxOrigen[IdMov])+1;
									break;
								}
							}
						}

						//}
						
										
					}
				}
				#endregion

				#region Confirmacion del Remito de Compra
				DataSet data = Workflow.GetCaminoComprobantesCompraTopDown(_idComprobanteDeCompra, "CRMXC");
				table = new Hashtable();
				auxDestino = new Hashtable();
				auxOrigen = new Hashtable();
				table = GenerateTableComprobantesDestino(data);
				infoMovimmientos = new Hashtable();
				foreach (ItemNumeroDeSerie item in this._detalle)
				{
					if (item.NumeroDeSerie.CompareTo( string.Empty ) != 0)
					{
						/*Asocia la Movimiento destino*/
						
						if(table.ContainsKey(item.IdProducto))
						{
							ArrayList arrayAux = (ArrayList)table[item.IdProducto];
							if(arrayAux != null && arrayAux.Count > 0)
							{
								Hashtable tempDestino = (Hashtable)arrayAux[0];
								foreach(string IdMov in tempDestino.Keys)
								{
									if(!infoMovimmientos.ContainsKey(IdMov))
									{
										DataRow rowMov = mz.erp.businessrules.tlg_MovimientosDeStock.GetByPk(IdMov);
										ArrayList auxInfoMov = new ArrayList();
										auxInfoMov.Add(Convert.ToString(rowMov["IdDeposito"]));
										auxInfoMov.Add(Convert.ToString(rowMov["IdSeccion"]));
										auxInfoMov.Add(Convert.ToString(rowMov["IdEstadoDeStock"]));
										infoMovimmientos.Add(IdMov, auxInfoMov);
									}
									decimal cant =  Convert.ToDecimal(tempDestino[IdMov]);
									if(cant > 0)
									{	
										if(!auxDestino.ContainsKey(IdMov)) auxDestino.Add(IdMov, 0);
										if(cant > Convert.ToDecimal(auxDestino[IdMov]))
										{
									
											_rowMovimientosNumerosDeSerie = mz.erp.businessrules.tlg_MovimientosDeStockNumerosDeSerie.NewRow();
											_rowMovimientosNumerosDeSerie.NumeroDeSerie = item.NumeroDeSerie;
											_rowMovimientosNumerosDeSerie.IdMovimientoDeStock =IdMov;
											ArrayList aux = (ArrayList)infoMovimmientos[IdMov];
											string IdDeposito = Convert.ToString(aux[0]);
											string IdSeccion = Convert.ToString(aux[1]);
											string IdEstadoDeStock = Convert.ToString(aux[2]);
											item.AddMovimiento(IdMov,IdDeposito, IdSeccion, IdEstadoDeStock,1);
											this._data.tlg_MovimientosDeStockNumerosDeSerie.Rows.Add(  _rowMovimientosNumerosDeSerie.ItemArray );
											auxDestino[IdMov] = Convert.ToDecimal(auxDestino[IdMov])+1;
											break;
										}
									}
								}
							}
						

							/*Asocia la Movimiento Origen*/
							arrayAux = (ArrayList)table[item.IdProducto];
							if(arrayAux != null && arrayAux.Count > 1)
							{
								
								Hashtable tempOrigen = (Hashtable)arrayAux[1];
						
								foreach(string IdMov in tempOrigen.Keys)
								{
									if(!infoMovimmientos.ContainsKey(IdMov))
									{
										DataRow rowMov = mz.erp.businessrules.tlg_MovimientosDeStock.GetByPk(IdMov);
										ArrayList auxInfoMov = new ArrayList();
										auxInfoMov.Add(Convert.ToString(rowMov["IdDeposito"]));
										auxInfoMov.Add(Convert.ToString(rowMov["IdSeccion"]));
										auxInfoMov.Add(Convert.ToString(rowMov["IdEstadoDeStock"]));
										infoMovimmientos.Add(IdMov, auxInfoMov);
									}
									decimal cant =  Math.Abs(Convert.ToDecimal(tempOrigen[IdMov]));
									if(cant > 0)
									{	
										if(!auxOrigen.ContainsKey(IdMov)) auxOrigen.Add(IdMov, 0);
										if(cant > Convert.ToDecimal(auxOrigen[IdMov]))
										{
											_rowMovimientosNumerosDeSerie = mz.erp.businessrules.tlg_MovimientosDeStockNumerosDeSerie.NewRow();
											_rowMovimientosNumerosDeSerie.NumeroDeSerie = item.NumeroDeSerie;
											_rowMovimientosNumerosDeSerie.IdMovimientoDeStock =IdMov;
											ArrayList aux = (ArrayList)infoMovimmientos[IdMov];
											string IdDeposito = Convert.ToString(aux[0]);
											string IdSeccion = Convert.ToString(aux[1]);
											string IdEstadoDeStock = Convert.ToString(aux[2]);
											item.AddMovimiento(IdMov,IdDeposito, IdSeccion, IdEstadoDeStock,-1);
											this._data.tlg_MovimientosDeStockNumerosDeSerie.Rows.Add(  _rowMovimientosNumerosDeSerie.ItemArray );
											auxOrigen[IdMov] = Convert.ToDecimal(auxOrigen[IdMov])+1;
											break;
										}
									}
								}
							}

							//}
						
							
						}
					}
				}
				
			
				#endregion
				

			}
			/*
			if(this._processParent.Process.ProcessName.Equals("ProcesoDevolucionMercaderiaAST")) 
			{
				foreach (ItemNumeroDeSerie item in this._detalle)
				{
					if (item.NumeroDeSerie.CompareTo( string.Empty ) != 0 && item.Seleccion == true)
					{
						mz.erp.commontypes.data.tlg_MovimientosDeStockNumerosDeSerieDataset.tlg_MovimientosDeStockNumerosDeSerieRow _rowMovimientosNumerosDeSerie = mz.erp.businessrules.tlg_MovimientosDeStockNumerosDeSerie.NewRow();
						_rowMovimientosNumerosDeSerie.NumeroDeSerie = item.NumeroDeSerie;
						_rowMovimientosNumerosDeSerie.IdMovimientoDeStock =item.IdMovimientoDeStock;
						this._data.tlg_MovimientosDeStockNumerosDeSerie.Rows.Add(  _rowMovimientosNumerosDeSerie.ItemArray );															
					}
				}
			}
			/*
			if((this._processParent.Process.ProcessName.Equals("ProcesoRegistrarNumerosDeSeriesPendientes") && estaConfirmado ) || !(this._processParent.Process.ProcessName.Equals("ProcesoRegistrarNumerosDeSeriesPendientes")))
			{
				AddStockNumerosDeSerie();
			}
			*/

		}


		private void AddStockNumerosDeSerie()
		{
			
			mz.erp.commontypes.data.tlg_StockNumerosDeSerieDataset.tlg_StockNumerosDeSerieRow row;
			if(_data.tlg_MovimientosDeStockNumerosDeSerie.Rows.Count > 0 && _operation.Equals(Stock.OperationNumerosDeSerie.Nothing))
			{	
				foreach (ItemNumeroDeSerie item in this._detalle)
				{
					if (item.NumeroDeSerie.CompareTo( string.Empty ) != 0 && item.Seleccion == true )
					{
						foreach(ItemNumeroDeSerieMovimientoDeStock it in item.MovimientosDeStock)
						{
							switch (it.Signo)
							{
								case 1:
								{
									tlg_StockNumerosDeSerieDataset dataSNS  = mz.erp.businessrules.tlg_StockNumerosDeSerie.GetList(null, item.IdProducto, it.IdDeposito, it.IdSeccion, it.IdEstadoDeStock, item.NumeroDeSerie);
									if(dataSNS.Tables[0].Rows.Count == 0)
									{
										row = mz.erp.businessrules.tlg_StockNumerosDeSerie.NewRow();
										row.IdProducto = item.IdProducto;
										row.IdEstadoDeStock = it.IdEstadoDeStock;
										row.IdDeposito = it.IdDeposito;
										row.IdSeccion = it.IdSeccion;
										row.NumeroDeSerie = item.NumeroDeSerie;
										this._dataStockNumerosDeSerie.tlg_StockNumerosDeSerie.Rows.Add( row.ItemArray);
									}
								}
									break;
								case -1:
								{
									tlg_StockNumerosDeSerieDataset dataSNS  = mz.erp.businessrules.tlg_StockNumerosDeSerie.GetList(null, item.IdProducto, it.IdDeposito, it.IdSeccion, it.IdEstadoDeStock, item.NumeroDeSerie);
									if(dataSNS.Tables[0].Rows.Count > 0)
									{
										row = (tlg_StockNumerosDeSerieDataset.tlg_StockNumerosDeSerieRow)dataSNS.tlg_StockNumerosDeSerie.Rows[0];
										row.Delete();
										_dataStockNumerosDeSerie.tlg_StockNumerosDeSerie.ImportRow(row);
									}
								}
									break;
							}
						}
					}
				}
			}
			else
			switch (_operation)
			{
					
				case Stock.OperationNumerosDeSerie.Insert:
				{
						
					foreach (ItemNumeroDeSerie item in this._detalle)
					{
						if (item.NumeroDeSerie.CompareTo( string.Empty ) != 0 && item.Seleccion == true )
						{
							tlg_StockNumerosDeSerieDataset dataSNS  = mz.erp.businessrules.tlg_StockNumerosDeSerie.GetList(null, item.IdProducto, _idDeposito, _idSeccion, _idEstadoDeStockOrigen, item.NumeroDeSerie);
							if(dataSNS.Tables[0].Rows.Count == 0)
							{
								row = mz.erp.businessrules.tlg_StockNumerosDeSerie.NewRow();
								row.IdProducto = item.IdProducto;
								row.IdEstadoDeStock = _idEstadoDeStockOrigen;
								row.IdDeposito = _idDeposito;
								row.IdSeccion = _idSeccion;
								row.NumeroDeSerie = item.NumeroDeSerie;
								this._dataStockNumerosDeSerie.tlg_StockNumerosDeSerie.Rows.Add( row.ItemArray);
							}
						}
					}

				}
					break;
				case Stock.OperationNumerosDeSerie.Delete:
				{
					foreach (ItemNumeroDeSerie item in this._detalle)
					{
						if (item.NumeroDeSerie.CompareTo( string.Empty ) != 0 && item.Seleccion == true )
						{
							tlg_StockNumerosDeSerieDataset dataSNS  = mz.erp.businessrules.tlg_StockNumerosDeSerie.GetList(null, item.IdProducto, _idDeposito, _idSeccion, _idEstadoDeStockOrigen, item.NumeroDeSerie);
							if(dataSNS.Tables[0].Rows.Count > 0)
							{
								row = (tlg_StockNumerosDeSerieDataset.tlg_StockNumerosDeSerieRow)dataSNS.tlg_StockNumerosDeSerie.Rows[0];
								row.Delete();
								_dataStockNumerosDeSerie.tlg_StockNumerosDeSerie.ImportRow(row);
							}
						}
					}
						
				}
					break;
				case Stock.OperationNumerosDeSerie.DeleteInsert:
				{
					foreach (ItemNumeroDeSerie item in this._detalle)
					{
						if (item.NumeroDeSerie.CompareTo( string.Empty ) != 0 && item.Seleccion == true )
						{
							tlg_StockNumerosDeSerieDataset dataSNS  = mz.erp.businessrules.tlg_StockNumerosDeSerie.GetList(null, item.IdProducto, _idDeposito, _idSeccion, _idEstadoDeStockOrigen, item.NumeroDeSerie);
							if(dataSNS.Tables[0].Rows.Count > 0)
							{
								row = (tlg_StockNumerosDeSerieDataset.tlg_StockNumerosDeSerieRow)dataSNS.tlg_StockNumerosDeSerie.Rows[0];
								row.Delete();
								_dataStockNumerosDeSerie.tlg_StockNumerosDeSerie.ImportRow(row);
							}
						}
					}
					foreach (ItemNumeroDeSerie item in this._detalle)
					{
						if (item.NumeroDeSerie.CompareTo( string.Empty ) != 0 && item.Seleccion == true )
						{
							tlg_StockNumerosDeSerieDataset dataSNS  = mz.erp.businessrules.tlg_StockNumerosDeSerie.GetList(null, item.IdProducto, _idDeposito, _idSeccion, _idEstadoDeStockDestino, item.NumeroDeSerie);
							if(dataSNS.Tables[0].Rows.Count == 0)
							{
								row = mz.erp.businessrules.tlg_StockNumerosDeSerie.NewRow();
								row.IdProducto = item.IdProducto;
								row.IdDeposito = _idDeposito;
								row.IdSeccion = _idSeccion;
								row.IdEstadoDeStock = _idEstadoDeStockDestino;
								row.NumeroDeSerie = item.NumeroDeSerie;
								this._dataStockNumerosDeSerie.tlg_StockNumerosDeSerie.Rows.Add( row.ItemArray);
							}
						}
					}
				}
					break;
			}
		}

		private Hashtable GenerateTableComprobanteOrigen(string IdComprobanteDestino)
		{
			Hashtable table = new Hashtable();
			DataSet data = mz.erp.businessrules.tpu_Comprobantes.GetMovimientosNumeroDeSeriePendientes(IdComprobanteDestino,null);
			foreach(DataRow row in data.Tables[0].Rows)
			{
				string IdProducto = Convert.ToString(row["IdProducto"]);
				string IdMovimientoDeStock = Convert.ToString(row["IdMovimientoDeStock"]);
				decimal CantPendiente = Convert.ToDecimal(row["CantidadPendiente"]);
				if(table.ContainsKey(IdProducto))
				{
					ArrayList auxArray = (ArrayList)table[IdProducto];
					int index = CantPendiente > 0?0:1;
					Hashtable hash = (Hashtable)auxArray[index];
					hash.Add(IdMovimientoDeStock, CantPendiente);
					
				}
				else
				{
					ArrayList auxArray= new ArrayList(2);
					auxArray.Add(new Hashtable());
					auxArray.Add(new Hashtable());
					int index = CantPendiente > 0?0:1;
					Hashtable hash = (Hashtable)auxArray[index];
					hash.Add(IdMovimientoDeStock, CantPendiente);
					table.Add(IdProducto, auxArray);
				}
			}
			return table;

		}


		private Hashtable GenerateTableComprobantesDestino(DataSet DataComprobantesDestinos)
		{
			Hashtable table = new Hashtable();
			foreach(DataRow rowC in DataComprobantesDestinos.Tables[0].Rows)
			{
				string IdComprobanteDestino = Convert.ToString(rowC["IdComprobante"]);
				string IdTipoDeComprobante = Convert.ToString(rowC["IdTipoDeComprobante"]);
				if(IdTipoDeComprobante.Equals("CRMXC"))
				{
					DataSet data = mz.erp.businessrules.tpu_Comprobantes.GetMovimientosNumeroDeSeriePendientes(IdComprobanteDestino,null);
					foreach(DataRow row in data.Tables[0].Rows)
					{
						string IdProducto = Convert.ToString(row["IdProducto"]);
						string IdMovimientoDeStock = Convert.ToString(row["IdMovimientoDeStock"]);
						decimal CantPendiente = Convert.ToDecimal(row["CantidadPendiente"]);
						if(table.ContainsKey(IdProducto))
						{
							ArrayList auxArray = (ArrayList)table[IdProducto];
							int index = CantPendiente > 0?0:1;
							Hashtable hash = (Hashtable)auxArray[index];
							hash.Add(IdMovimientoDeStock, CantPendiente);
					
						}
						else
						{
							ArrayList auxArray= new ArrayList(2);
							auxArray.Add(new Hashtable());
							auxArray.Add(new Hashtable());
							int index = CantPendiente > 0?0:1;
							Hashtable hash = (Hashtable)auxArray[index];
							hash.Add(IdMovimientoDeStock, CantPendiente);
							table.Add(IdProducto, auxArray);
						}
					}
				}
			}
			return table;

		}


		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());
			mz.erp.businessrules.tlg_MovimientosDeStockNumerosDeSerie.Update(this._data, IdTransaction);
			mz.erp.businessrules.tlg_StockNumerosDeSerie.Update(this._dataStockNumerosDeSerie, IdTransaction);
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}

	
		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			// TODO: agregar la implementación RegistrarNumerosDeSerie.PutExtraDataOnCommit
		}
		/// <summary>
		/// Movimientos de Stock siempre vendra con una estructura origen destino
		/// El producto no se repetira salvo que se modifique el estado lógico del stock y los depositos
		/// Aun asi, siempre las cantidades quedarán consolidadas
		/// </summary>
		/// <param name="_processCollectionData"></param>
		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{   
			if(!this._processParent.Process.ProcessName.Equals("ProcesoRegistrarNumerosDeSeriesPendientes"))
							this._data.tlg_MovimientosDeStockNumerosDeSerie.Rows.Clear();

			foreach( TaskCollectionData _collectionTask in _processCollectionData)
			{
				if(_collectionTask.TaskName.Equals("ConfirmarIngresoMercaderia") || _collectionTask.TaskName.Equals("IngresarMercaderia"))
				{
					foreach (System.Data.DataSet undata in _collectionTask )
					{
						if (undata.DataSetName.Equals("tlg_MovimientosDeStockDataset"))
						{
							//ArrayList MovStockUsados = new ArrayList();
							ArrayList NumSeriesUsadosPositivos = new ArrayList();
							ArrayList NumSeriesUsadosNegativos = new ArrayList();
							foreach(DataRow row in undata.Tables["tlg_MovimientosDeStock"].Rows)
							{
								string idMovimientoDeStock = Convert.ToString(row["IdMovimientoDeStock"]);
								string idProducto = Convert.ToString(row["IdProducto"]);
								string IdDeposito = Convert.ToString(row["IdDeposito"]);
								string IdSeccion = Convert.ToString(row["IdSeccion"]);
								string IdEstadoDeStock = Convert.ToString(row["IdEstadoDeStock"]);
								int cant = Convert.ToInt32(Math.Round(Math.Abs(Convert.ToDecimal(row["Cantidad"])),0));
								short Signo =Convert.ToInt16(Convert.ToDecimal(row["Cantidad"])>0?1:-1);
								
								for(int i= 0; i < cant; i++)
								{
									foreach (ItemNumeroDeSerie item in this.GetASetOfSerialNumbers(idProducto) )
									{
										bool cond = (NumSeriesUsadosPositivos.Contains(idProducto+item.NumeroDeSerie) && Signo == Convert.ToInt16(1))
											|| (NumSeriesUsadosNegativos.Contains(idProducto+item.NumeroDeSerie) && Signo == Convert.ToInt16(-1));
										if (item.NumeroDeSerie.CompareTo( string.Empty ) != 0 &&
											//!MovStockUsados.Contains(idMovimientoDeStock) &&
											! cond)
										{
											mz.erp.commontypes.data.tlg_MovimientosDeStockNumerosDeSerieDataset.tlg_MovimientosDeStockNumerosDeSerieRow _rowMovimientosNumerosDeSerie = mz.erp.businessrules.tlg_MovimientosDeStockNumerosDeSerie.NewRow();
											_rowMovimientosNumerosDeSerie.NumeroDeSerie = item.NumeroDeSerie;
											_rowMovimientosNumerosDeSerie.IdMovimientoDeStock = idMovimientoDeStock;
											item.AddMovimiento(idMovimientoDeStock,IdDeposito, IdSeccion, IdEstadoDeStock,Signo);
											if(Signo == Convert.ToInt16(1))
												NumSeriesUsadosPositivos.Add(idProducto+item.NumeroDeSerie);
											else NumSeriesUsadosNegativos.Add(idProducto+item.NumeroDeSerie);
											this._data.tlg_MovimientosDeStockNumerosDeSerie.Rows.Add(  _rowMovimientosNumerosDeSerie.ItemArray );										
											break;
										}
										
									}
								}							
							}
						}
					}
				}
				
				
				
				
				else
				if (_collectionTask.TaskName.Equals("Entregar") || _collectionTask.TaskName.Equals("ConfirmarPreparar")
					|| _collectionTask.TaskName.Equals("Remitir"))
				{
					foreach (System.Data.DataSet undata in _collectionTask )
					{
						if (undata.DataSetName.Equals("tsa_ComprobantesExDataset"))
						{
							//ArrayList MovStockUsados = new ArrayList();
							ArrayList NumSeriesUsadosPositivos = new ArrayList();
							ArrayList NumSeriesUsadosNegativos = new ArrayList();
							foreach(DataRow row in undata.Tables["tlg_MovimientosDeStock"].Rows)
							{
								string idMovimientoDeStock = Convert.ToString(row["IdMovimientoDeStock"]);
								string idProducto = Convert.ToString(row["IdProducto"]);
								string IdDeposito = Convert.ToString(row["IdDeposito"]);
								string IdSeccion = Convert.ToString(row["IdSeccion"]);
								string IdEstadoDeStock = Convert.ToString(row["IdEstadoDeStock"]);
								int cant = Convert.ToInt32(Math.Round(Math.Abs(Convert.ToDecimal(row["Cantidad"])),0));
								short Signo =Convert.ToInt16(Convert.ToDecimal(row["Cantidad"])>0?1:-1);
								
								for(int i= 0; i < cant; i++)
								{
									foreach (ItemNumeroDeSerie item in this.GetASetOfSerialNumbers(idProducto) )
									{
										bool cond = (NumSeriesUsadosPositivos.Contains(idProducto+item.NumeroDeSerie) && Signo == Convert.ToInt16(1))
											|| (NumSeriesUsadosNegativos.Contains(idProducto+item.NumeroDeSerie) && Signo == Convert.ToInt16(-1));
										if (item.NumeroDeSerie.CompareTo( string.Empty ) != 0 &&
											//!MovStockUsados.Contains(idMovimientoDeStock) &&
											! cond)
										{
											mz.erp.commontypes.data.tlg_MovimientosDeStockNumerosDeSerieDataset.tlg_MovimientosDeStockNumerosDeSerieRow _rowMovimientosNumerosDeSerie = mz.erp.businessrules.tlg_MovimientosDeStockNumerosDeSerie.NewRow();
											_rowMovimientosNumerosDeSerie.NumeroDeSerie = item.NumeroDeSerie;
											_rowMovimientosNumerosDeSerie.IdMovimientoDeStock = idMovimientoDeStock;
											item.AddMovimiento(idMovimientoDeStock,IdDeposito, IdSeccion, IdEstadoDeStock,Signo);
											if(Signo == Convert.ToInt16(1))
												NumSeriesUsadosPositivos.Add(idProducto+item.NumeroDeSerie);
											else NumSeriesUsadosNegativos.Add(idProducto+item.NumeroDeSerie);
											this._data.tlg_MovimientosDeStockNumerosDeSerie.Rows.Add(  _rowMovimientosNumerosDeSerie.ItemArray );
											break;
										}
									}
								}							
							}

						}
					}					
				}
				else
					if (((_collectionTask.TaskName.Equals("AjustarStockOrigen")) || (_collectionTask.TaskName.Equals("AjustarStockDestino")))
					&& (this._processParent.Process.ProcessName.Equals("ProcesoDevolucionMercaderiaAST")) )
				{
					foreach (System.Data.DataSet undata in _collectionTask )
					{
						if (undata.DataSetName.Equals("tlg_MovimientosDeStockDataset"))
						{
							
							ArrayList MovStockUsados = new ArrayList();
							ArrayList NumSeriesUsados = new ArrayList();
							foreach(DataRow row in undata.Tables["tlg_MovimientosDeStock"].Rows)
							{
								string idMovimientoDeStock = Convert.ToString(row["IdMovimientoDeStock"]);
								string idProducto = Convert.ToString(row["IdProducto"]);
								string IdDeposito = Convert.ToString(row["IdDeposito"]);
								string IdSeccion = Convert.ToString(row["IdSeccion"]);
								string IdEstadoDeStock = Convert.ToString(row["IdEstadoDeStock"]);
								short Signo =Convert.ToInt16(Convert.ToDecimal(row["Cantidad"])>0?1:-1);
								
								foreach (ItemNumeroDeSerie item in this.GetASetOfSerialNumbers(idProducto) )
								{
									if ((item.NumeroDeSerie.CompareTo( string.Empty ) != 0) &&
										!MovStockUsados.Contains(idMovimientoDeStock) &&
										!NumSeriesUsados.Contains(idProducto+item.NumeroDeSerie) &&
										item.Seleccion == true)
									{
										mz.erp.commontypes.data.tlg_MovimientosDeStockNumerosDeSerieDataset.tlg_MovimientosDeStockNumerosDeSerieRow _rowMovimientosNumerosDeSerie = mz.erp.businessrules.tlg_MovimientosDeStockNumerosDeSerie.NewRow();
										_rowMovimientosNumerosDeSerie.NumeroDeSerie = item.NumeroDeSerie;
										_rowMovimientosNumerosDeSerie.IdMovimientoDeStock = idMovimientoDeStock;
										this._data.tlg_MovimientosDeStockNumerosDeSerie.Rows.Add(  _rowMovimientosNumerosDeSerie.ItemArray );
										MovStockUsados.Add(idMovimientoDeStock);
										NumSeriesUsados.Add(idProducto+item.NumeroDeSerie);
										item.AddMovimiento(idMovimientoDeStock,IdDeposito, IdSeccion, IdEstadoDeStock,Signo);
									}
								}														
							}
						}
					}				
				}
				else
				{
					foreach (System.Data.DataSet undata in _collectionTask )
					{
						if (undata.DataSetName.Equals("tlg_MovimientosDeStockDataset"))
						{
							//ArrayList MovStockUsados = new ArrayList();
							ArrayList NumSeriesUsadosPositivos = new ArrayList();
							ArrayList NumSeriesUsadosNegativos = new ArrayList();
							foreach(DataRow row in undata.Tables["tlg_MovimientosDeStock"].Rows)
							{
								string idMovimientoDeStock = Convert.ToString(row["IdMovimientoDeStock"]);
								string idProducto = Convert.ToString(row["IdProducto"]);
								string IdDeposito = Convert.ToString(row["IdDeposito"]);
								string IdSeccion = Convert.ToString(row["IdSeccion"]);
								string IdEstadoDeStock = Convert.ToString(row["IdEstadoDeStock"]);
								int cant = Convert.ToInt32(Math.Round(Math.Abs(Convert.ToDecimal(row["Cantidad"])),0));
								short Signo =Convert.ToInt16(Convert.ToDecimal(row["Cantidad"])>0?1:-1);
								
								for(int i= 0; i < cant; i++)
								{
									foreach (ItemNumeroDeSerie item in this.GetASetOfSerialNumbers(idProducto) )
									{
										bool cond = (NumSeriesUsadosPositivos.Contains(idProducto+item.NumeroDeSerie) && Signo == Convert.ToInt16(1))
											|| (NumSeriesUsadosNegativos.Contains(idProducto+item.NumeroDeSerie) && Signo == Convert.ToInt16(-1));
										if (item.NumeroDeSerie.CompareTo( string.Empty ) != 0 &&
											//!MovStockUsados.Contains(idMovimientoDeStock) &&
											! cond)
										{
											mz.erp.commontypes.data.tlg_MovimientosDeStockNumerosDeSerieDataset.tlg_MovimientosDeStockNumerosDeSerieRow _rowMovimientosNumerosDeSerie = mz.erp.businessrules.tlg_MovimientosDeStockNumerosDeSerie.NewRow();
											_rowMovimientosNumerosDeSerie.NumeroDeSerie = item.NumeroDeSerie;
											_rowMovimientosNumerosDeSerie.IdMovimientoDeStock = idMovimientoDeStock;
											item.AddMovimiento(idMovimientoDeStock,IdDeposito, IdSeccion, IdEstadoDeStock,Signo);
											if(Signo == Convert.ToInt16(1))
												NumSeriesUsadosPositivos.Add(idProducto+item.NumeroDeSerie);
											else NumSeriesUsadosNegativos.Add(idProducto+item.NumeroDeSerie);
											this._data.tlg_MovimientosDeStockNumerosDeSerie.Rows.Add(  _rowMovimientosNumerosDeSerie.ItemArray );										
											break;
										}
									}
								}							
							}

						}
					}
				}
				
			}
			AddStockNumerosDeSerie();
		}

		private ArrayList GetASetOfSerialNumbers( string IdProducto )
		{
			ArrayList _unConjunto = new ArrayList();
			foreach ( ItemNumeroDeSerie item in this._detalle )
			{
				if (( item.IdProducto.CompareTo( IdProducto ) ==0) && (item.NumeroDeSerie.CompareTo( string.Empty ) != 0))
				{
					_unConjunto.Add( item );
				}
			}
			return _unConjunto;
		}

		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			// TODO: agregar la implementación RegistrarNumerosDeSerie.GetSentenceReplication
			return null;
		}

		public bool GetHasSaved()
		{
			// TODO: agregar la implementación RegistrarNumerosDeSerie.GetHasSaved
			return false;
		}

		#endregion

		#region Propiedades públicas
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
		#endregion

		
	}


	

}
