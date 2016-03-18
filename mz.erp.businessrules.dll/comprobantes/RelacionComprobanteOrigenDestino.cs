using System;
using System.Collections;
using System.Collections.Specialized;
using mz.erp.businessrules;
using mz.erp.commontypes.data;
using mz.erp.commontypes;
using System.Windows.Forms;
using System.Data;


namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Descripción breve de RelacionComprobanteOrigenDestino.
	/// </summary>
	public class RelacionesComprobanteOrigenDestino:System.Collections.CollectionBase
	{
		public bool _actualizaPrecio = false;
		private bool _isValid = true;
		private bool _permiteTiposDeComprobanteOrigenDistintos = false;

		public bool IsValid 
		{
			get{return _isValid;}
		}
		private string _processName = string.Empty;
		private string _taskName = string.Empty;
		private string _mainTaskName = string.Empty;

		private decimal _MACOR = 0;

		public decimal MACOR
		{
			get{return _MACOR;}
		}
		public bool ActualizaPrecio 
		{
			get {return _actualizaPrecio;}
			set {_actualizaPrecio = value;}

		}
		/*
		public RelacionesComprobanteOrigenDestino()
		{
		}
		*/
		public RelacionesComprobanteOrigenDestino(string ProcessName, string TaskName, string MainTaskName)
		{
			_processName = ProcessName;
			_taskName = TaskName;
			_mainTaskName = MainTaskName;
		}
		
		public RelacionesComprobanteOrigenDestino(ArrayList IdComprobantes, string ProcessName, string TaskName, string MainTaskName)
		{			
			_processName = ProcessName;
			_taskName = TaskName;
			_mainTaskName = MainTaskName;
			this.Load(IdComprobantes);
		}
		

		public RelacionesComprobanteOrigenDestino()
		{			
		}
		

		private void Load(ArrayList IdComprobantes) 
		{
			string IdTipoDeComprobanteGral = String.Empty;
			_permiteTiposDeComprobanteOrigenDistintos = Variables.GetValueBool(_processName, _taskName, "Step.PermiteDistintosTiposDeComprobantesOrigen");
			_actualizaPrecio = Variables.GetValueBool(_processName, _mainTaskName, "Step.ActualizaPrecios");
			string IdListaDePreciosDefault = Variables.GetValueString(_processName, _taskName, "ListaDePreciosDefault");	
			if(IdListaDePreciosDefault.Equals(string.Empty))
				IdListaDePreciosDefault = businessrules.tsh_ListasDePrecios.GetDefault().IdListaDePrecio;
			ArrayList lista = new ArrayList(IdComprobantes);			
			for (int i = 0; i < lista.Count; i++) 
			{
				string IdComprobante = lista[i].ToString();
				tsa_ComprobantesDataset.tsa_ComprobantesRow CompOrigen = tsa_Comprobantes.GetByPk(IdComprobante);				

				//Datos comunes a todos los items de un mismo comprobante
				string IdTipoDeComprobante = CompOrigen.IdTipoDeComprobante;
				string Numero = CompOrigen.Numero;
				long OrdinalOrigen = -1;
				decimal CantidadOrigen = 0;
				decimal CantidadDestino = 0;
				string IdProducto = String.Empty;
				string Descripcion = String.Empty;				
				DateTime Fecha = CompOrigen.Fecha;
				Decimal Precio = 0;
				this.Observaciones = CompOrigen.Observaciones;
				this.IdCuenta= CompOrigen.IdCuenta;				
				_idResponsable = CompOrigen.IdResponsable;
				//German 20091023 - tarea 470
				if(!_responsablesComprobantesAnteriores.Contains(_idResponsable))
					_responsablesComprobantesAnteriores.Add(_idResponsable);
				//Fin German 20091023 - tarea 470
				_infoCliente = CompOrigen.Cliente;		

				string IdCondicionDeVenta = string.Empty;

				
				

				string idCondVen = Convert.ToString(CompOrigen["IdCondicionDeVenta"]);
				if(idCondVen != null && idCondVen != string.Empty)
					IdCondicionDeVenta = idCondVen;
				else
				{
					/*Con el pasar del tiempo esto debe desaparecer - La Condicionde venta se guarda
					 * en tsa_comprobantes y no como una variable auxiliar asocicada al comprobante
					 * 
					*/
					System.Data.DataRow rowVarAux = mz.erp.businessrules.tsa_ComprobanteValoresVarAux.GetByPk(IdComprobante , ComprobantesRules.Comprobantes_Variables_IdCondicionDeVenta);
					if(rowVarAux != null)
						IdCondicionDeVenta = Convert.ToString(rowVarAux["Valor"]);
				}
				if (IdTipoDeComprobanteGral == String.Empty) 
				{
				
					IdTipoDeComprobanteGral = IdTipoDeComprobante;
				}

				//Si el tipo de Comprobante actual es distinto al tipo de comprobante del primer comprobante no hace nada (por ahora)
				if (IdTipoDeComprobante == IdTipoDeComprobanteGral || _permiteTiposDeComprobanteOrigenDistintos) 
				{
				
					//Para cada IdComprobante tengo que obtener los ítems
					//Datos del item del comprobante				
					tsa_ComprobantesDetDataset Items = businessrules.tsa_ComprobantesDet.GetByPk(IdComprobante);

					decimal Pendiente = CantidadOrigen;						
					bool PermitePendienteCero = Variables.GetValueBool(_processName, _taskName, "PermitePendienteCero");
					bool RequierePendiente = Variables.GetValueBool(_processName, _taskName, "RequiereBuscarPendientes", true);

					foreach (tsa_ComprobantesDetDataset.tsa_ComprobantesDetRow row in Items.tsa_ComprobantesDet )
					{
						OrdinalOrigen = row.Ordinal;
						CantidadOrigen = row.Cantidad; 
						bool Visible = row.Visible;
						string IdListaDePrecio = row.IdListaDePrecio;
						decimal CoeficienteListaDePrecio = row.CoeficienteListaDePrecio;
						string ModoDeAplicacion = row.ModoDeAplicacion;
						
											
						SortedList aux = Workflow.GetComprobantesAsociadosList(Workflow.GetIdTakByName(_mainTaskName));
						ArrayList aux1 = new ArrayList(aux.Keys);
						string TiposComprobantesDestino = systemframework.Util.PackString(aux1, ",");
						string TiposComprobantesDestinoExcluidos = Variables.GetValueString(_processName, _taskName, "TiposDeComprobantesExcluidos");
						
						System.Data.DataRow rowPend;
						if(RequierePendiente)
						{
							if (PermitePendienteCero)
							{
								rowPend = businessrules.tsa_ComprobantesEx.ComprobantesDet(TiposComprobantesDestino, TiposComprobantesDestinoExcluidos,IdComprobante, OrdinalOrigen);
							}
							else 
							{
								rowPend = businessrules.tsa_ComprobantesEx.ComprobantesPendientesDet(TiposComprobantesDestino, TiposComprobantesDestinoExcluidos,IdComprobante, OrdinalOrigen);
							}
						}
						else rowPend = row;
						if (rowPend != null)
						{
							Pendiente = Convert.ToDecimal(rowPend["Cantidad"]);
							if(Pendiente  > 0 || PermitePendienteCero)
							{						
								CantidadDestino = Pendiente;
						
								//Por ahora estoy tomando en CantidadOrigen la cantidad original del item. Luego tengo que hacer aparecer lo que está en tsa_ComprobantesRelacionOrigenDestino
								IdProducto = row.IdProducto;
								Descripcion = tsh_Productos.GetByPk(row.IdProducto).Descripcion;						
								Precio = row.PrecioFinal;

								tsh_ProductosDataset.tsh_ProductosRow producto = businessrules.tsh_Productos.GetByPk(IdProducto);
								
								// matias 16/09/08
								//_actualizaPrecio = false;
								// ----------------
								
								/*Ojo aca pq el precio neto en el detalle de omprobantes se guardan con bonifiaciones y descuentos incluidos
								 * y puede ser diferente al precio neto del producto. 
								 * */
								decimal PrecioNetoActual = 0;
								if (row.PrecioNeto != producto.PrecioDeVentaNeto && _actualizaPrecio) 
								{
									PrecioNetoActual = producto.PrecioDeVentaNeto;
								}
								else 
								{
									PrecioNetoActual = row.PrecioNeto;
								}
								RelacionComprobanteOrigenDestino ItemOrigen = new RelacionComprobanteOrigenDestino(IdComprobante, IdTipoDeComprobante, Numero, OrdinalOrigen, CantidadOrigen, CantidadDestino, IdProducto, Descripcion, Precio, IdCondicionDeVenta, PrecioNetoActual, _processName, _taskName, _mainTaskName, IdListaDePrecio, CoeficienteListaDePrecio, ModoDeAplicacion, IdListaDePreciosDefault);

								
								ItemOrigen.Visible = Visible;
								this.Add(ItemOrigen);
							}
						}
					}
				}				
			}

		}
		
		string _idPersona = string.Empty;
		int _equipo = 0;
		bool _habilitaUsuariaAltaOR = false;
		public void LoadFromOrdenReparaciones(ArrayList IdComprobantes)
		{
			string IdTipoDeComprobanteGral = String.Empty;
			_habilitaUsuariaAltaOR = Variables.GetValueBool("Sistema.RentabilidadOR.HabilitaUsuarioAlta");
			ArrayList lista = new ArrayList(IdComprobantes);			
			for (int i = 0; i < lista.Count; i++) 
			{
				string IdComprobante = lista[i].ToString();
				/*Recuperar Cabecera de la Orden de Reparacion*/
				DataRow CompOrigen = mz.erp.businessrules.st_OrdenReparacion.GetByPk(IdComprobante);

				//Datos comunes a todos los items de un mismo comprobante
				string IdTipoDeComprobante ="OR";
				bool esEquipoNuevo = Convert.ToBoolean(CompOrigen["EsEquipoNuevo"]);
				string Numero = string.Empty;
				long OrdinalOrigen = -1;
				decimal CantidadOrigen = 0;
				decimal CantidadDestino = 0;
				string IdProducto = String.Empty;
				string Descripcion = String.Empty;
				DateTime Fecha = Convert.ToDateTime(CompOrigen["FechaCreacion"]);
				Decimal Precio = 0;
				string IdRecepcionCliente = Convert.ToString(CompOrigen["IdRecepcionCliente"]);
				DataRow rowRecepcionCliente = mz.erp.businessrules.st_RecepcionCliente.GetByPk(IdRecepcionCliente);
				string IdUsuarioAlta = Convert.ToString(CompOrigen["IdUsuarioAlta"]);
				DataRow rowPersona = mz.erp.businessrules.sy_Usuarios.GetByPk(IdUsuarioAlta);
				string IdPersona = string.Empty;
				int equipo = 0;
				if(rowPersona != null)
				{
					_idPersona = Convert.ToString(rowPersona["IdPersona"]);
					if(!rowPersona.IsNull("Equipo"))
						_equipo = Convert.ToInt32(rowPersona["Equipo"]);
				}
				this.IdCuenta= Convert.ToString(rowRecepcionCliente["IdCuenta"]);
				this.IdResponsable = IdPersona; 
				string IdCondicionDeVenta = string.Empty;				
			
				long IdRepuestoOrdenReparacion = 0;	
				long IdTareaRealizada = 0;
                //German 20100806 - Tarea 812
                /*
                object totalTareasInformado = CompOrigen["TotalTareasInformado"];
                bool isNull =  CompOrigen.IsNull(CompOrigen.Table.Columns["TotalTareasInformado"],System.Data.DataRowVersion.Original);
                decimal TotalTareas = -1;
                if(!isNull)
                    TotalTareas = Convert.ToDecimal(totalTareasInformado);
                decimal TotalTareas = -1;
                 */
                //Fin German 20100806 - Tarea 812
                //German 20100825 - Tarea 813
                object totalTareasAFacturar = CompOrigen["TotalTareasAFacturar"];
                bool isNull = CompOrigen.IsNull(CompOrigen.Table.Columns["TotalTareasAFacturar"], System.Data.DataRowVersion.Original);
                decimal TotalTareas = -1;
                if(!isNull)
                    TotalTareas = Convert.ToDecimal(totalTareasAFacturar);
                isNull = CompOrigen.IsNull(CompOrigen.Table.Columns["Mac"], System.Data.DataRowVersion.Original);
                //Fin German 20100825 - Tarea 813
				
                if(!isNull)
					_MACOR = Convert.ToDecimal(CompOrigen["Mac"]);

				System.Data.DataRow rowVarAux = mz.erp.businessrules.tsa_ComprobanteValoresVarAux.GetByPk(IdComprobante , ComprobantesRules.Comprobantes_Variables_IdCondicionDeVenta);
				if(rowVarAux != null)
					IdCondicionDeVenta = Convert.ToString(rowVarAux["Valor"]);
				if (IdTipoDeComprobanteGral == String.Empty) 
				{
					IdTipoDeComprobanteGral = IdTipoDeComprobante;
				}

				//Si el tipo de Comprobante actual es distinto al tipo de comprobante del primer comprobante no hace nada (por ahora)
				if (IdTipoDeComprobante == IdTipoDeComprobanteGral) 
				{
					//Para cada IdComprobante tengo que obtener los ítems
					//Como es una Orden de repracion debo traer las tareas y los repuestos.			
					DataSet detalleTareas = mz.erp.businessrules.st_OrdenReparacion.GetDetalleTareasByPk(IdComprobante);
					bool tareasAgrupadas = Variables.GetValueBool("Comprobantes.OrdenReparacion.AgruparTareas");
					int ordinal = 0;
					if(!esEquipoNuevo)
					{
						/*Proceso Primero las Tareas de la Orden de facturacion*/
						if(!tareasAgrupadas)
						{
							foreach (DataRow row in detalleTareas.Tables[0].Rows )
							{

								OrdinalOrigen = ordinal;
								ordinal++;
                                //German 20100806 - Tarea 812
								//CantidadOrigen = Convert.ToUInt32(row["Cantidad"]); 
                                CantidadOrigen = 1;
                                //Fin German 20100806 - Tarea 812
								CantidadDestino = CantidadOrigen;
								IdProducto = Convert.ToString(row["IdProducto"]);
								Descripcion = Convert.ToString(row["Tarea"]);						
								Precio = Convert.ToDecimal(row["Precio"]);
								IdTareaRealizada = Convert.ToInt64(row["IdTareaRealizada"]);
								long IdInstanciaOR = Convert.ToInt64(row["IdInstanciaOrdenReparacion"]);
								decimal PrecioNetoActual = Precio;
								RelacionComprobanteOrigenDestino ItemOrigen = new RelacionComprobanteOrigenDestino(IdComprobante, IdTipoDeComprobante, Numero, OrdinalOrigen, CantidadOrigen, CantidadDestino, IdProducto, Descripcion, Precio, IdCondicionDeVenta, PrecioNetoActual,esEquipoNuevo, _processName, _taskName, _mainTaskName, IdInstanciaOR);														
								ItemOrigen.IdOrdenReparacion = Convert.ToInt64(IdComprobante);
								ItemOrigen.IdInstanciaOrdenReparacion = Convert.ToInt64(IdInstanciaOR);
								ItemOrigen.IdTareaRealizada = IdTareaRealizada;
								if(_habilitaUsuariaAltaOR)
								{
									ItemOrigen.Equipo = _equipo;
									ItemOrigen.IdResponsableOrigen = _idPersona;
								}
								this.Add(ItemOrigen);
							}
						}
						else
						{
							decimal PrecioNetoActual = 0;
							long IdInstanciaOR = 0;
                            if (TotalTareas.Equals(Convert.ToDecimal(-1)))
                            {
                                foreach (DataRow row in detalleTareas.Tables[0].Rows)
                                {
                                    //German 20100806 - Tarea 812
                                    /*
                                    bool isNullPrecio =  row.IsNull(row.Table.Columns["Precio"],System.Data.DataRowVersion.Original);
									bool isNullCantidad =  row.IsNull(row.Table.Columns["Cantidad"],System.Data.DataRowVersion.Original);
									if(!isNullCantidad && !isNullPrecio)
										Precio = Precio + (Convert.ToDecimal(row["Precio"]) * Convert.ToDecimal(row["Cantidad"]));
                                     */
                                    bool isNullPrecio = row.IsNull(row.Table.Columns["Precio"], System.Data.DataRowVersion.Original);
                                    if (!isNullPrecio)
                                        Precio = Precio + Convert.ToDecimal(row["Precio"]);
                                    //Fin German 20100806 - Tarea 812
                                }

                            }
                            else
                                //German 20101106 - Tarea 916
                            {
                                if (detalleTareas.Tables[0].Rows.Count > 0)
                                    Precio = TotalTareas;
                                else
                                {
                                    object totalServiciosAFacturar = CompOrigen["TotalServiciosAFacturar"];
                                    bool isNullAux = CompOrigen.IsNull(CompOrigen.Table.Columns["TotalServiciosAFacturar"], System.Data.DataRowVersion.Original);
                                    if (!isNullAux)
                                        Precio = Convert.ToDecimal(totalServiciosAFacturar);

                                }
                            }
                            //Fin German 20101106 - Tarea 916
							if(detalleTareas.Tables[0].Rows.Count > 0)
								IdInstanciaOR = Convert.ToInt64(detalleTareas.Tables[0].Rows[0]["IdInstanciaOrdenReparacion"]);
                            //German 20100908 - Tarea 825
                            IdProducto = ComprobantesRules.Comprobantes_OrdenReparcion_IdProductoComodinServicios();
                            //Fin German 20100908 - Tarea 825
							Descripcion = Variables.GetValueString("Comprobantes.OrdenReparacion.AgruparTareas.Descripcion");
							System.Collections.Hashtable table = new System.Collections.Hashtable();
							table = FuncionesImpuestos.ObtenerFormulas( null,null,IdProducto );
							Precio = FuncionesImpuestos.CalcularInversa(table, Precio);	
							PrecioNetoActual = Precio;
							OrdinalOrigen = ordinal;
							CantidadOrigen = 1; 
							CantidadDestino = 1;
							string descripcionEquipo = Convert.ToString(CompOrigen["DescripcionEquipo"]);
							string IdEquipo = Convert.ToString(CompOrigen["IdEquipo"]);
							DataRow rowEquipo = mz.erp.businessrules.st_Equipo.GetByPk(IdEquipo);
							string nroSerie = Convert.ToString(rowEquipo["Codigo"]);
							string concat = descripcionEquipo + "  #" + nroSerie;
							Descripcion = string.Format(Descripcion, new object[]{IdComprobante, concat});
							RelacionComprobanteOrigenDestino ItemOrigen = new RelacionComprobanteOrigenDestino(IdComprobante, IdTipoDeComprobante, Numero, OrdinalOrigen, CantidadOrigen, CantidadDestino, IdProducto, Descripcion, Precio, IdCondicionDeVenta, PrecioNetoActual, esEquipoNuevo, _processName, _taskName, _mainTaskName, IdInstanciaOR);						
							ItemOrigen.IdOrdenReparacion = Convert.ToInt64(IdComprobante);
							ItemOrigen.IdInstanciaOrdenReparacion = Convert.ToInt64(IdInstanciaOR);
							ItemOrigen.IdTareaRealizada = 0;
							if(_habilitaUsuariaAltaOR)
							{
								ItemOrigen.Equipo = _equipo;
								ItemOrigen.IdResponsableOrigen = _idPersona;
							}
							this.Add(ItemOrigen);

							ordinal++;
						}
					
						/*Proceso Los repuestos de las Ordenes de reparacion*/
						ordinal = AddRepuestos(ordinal, IdComprobante, IdTipoDeComprobante, Numero, IdCondicionDeVenta, true, esEquipoNuevo);
					
					}
					else //Es un equipo Nuevo
					{
						ordinal = AddRepuestos(ordinal, IdComprobante, IdTipoDeComprobante, Numero, IdCondicionDeVenta, false, esEquipoNuevo);
						string CodigoEquipoComodin = Variables.GetValueString(_processName, "RelacionesComprobanteOrigenDestino", "EquipoNuevo.Default");
						if(CodigoEquipoComodin.Equals(string.Empty))
							CodigoEquipoComodin = Variables.GetValueString("Productos.EquipoNuevo.Default");
						if(CodigoEquipoComodin.Equals(string.Empty))
							_isValid = false;
						if(_isValid)
						{
							IdProducto = mz.erp.businessrules.tsh_Productos.GetPkByCodigo(CodigoEquipoComodin);
							if(IdProducto != null && !IdProducto.Equals(string.Empty))
							{
								DataRow row = mz.erp.businessrules.tsh_Productos.GetByPk(IdProducto);
								if(row != null)
								{
									CantidadOrigen = 1; 
									CantidadDestino = 1;
									Descripcion = "OR " + IdComprobante + " " + Convert.ToString(row["Descripcion"]);							
									Precio = Convert.ToDecimal(row["PrecioDeVentaNeto"]);
									decimal PrecioNetoActual = Precio;
									long IdInstanciaOR = 0;
									if(this.Count > 0)
									{
										RelacionComprobanteOrigenDestino aux =  (RelacionComprobanteOrigenDestino)this.List[0];	
										IdInstanciaOR = aux.IdInstanciaOR;
									}
									RelacionComprobanteOrigenDestino ItemOrigen = new RelacionComprobanteOrigenDestino(IdComprobante, IdTipoDeComprobante, Numero, ordinal, CantidadOrigen, CantidadDestino, IdProducto, Descripcion, Precio, IdCondicionDeVenta, PrecioNetoActual, esEquipoNuevo, _processName, _taskName, _mainTaskName, IdInstanciaOR);						
									ItemOrigen.Visible = true;
									ItemOrigen.IdOrdenReparacion = Convert.ToInt64(IdComprobante);
									ItemOrigen.IdInstanciaOrdenReparacion = Convert.ToInt64(IdInstanciaOR);
									this.Add(ItemOrigen);
								}
							}
						}

					}
					
				}	
				
			}
			//
			// TODO: agregar aquí la lógica del constructor
			//


		}

		private int AddRepuestos(int Ordinal, string IdComprobante,string IdTipoDeComprobante, string Numero, string IdCondicionDeVenta, bool ItemsVisibles, bool EsEquipoNuevo)
		{
			DataSet detalleRepuestos = mz.erp.businessrules.st_OrdenReparacion.GetDetalleRepuestosByPk(IdComprobante);
			foreach (DataRow row in detalleRepuestos.Tables[0].Rows )
			{

				long OrdinalOrigen = -1;
				decimal CantidadOrigen = 0;
				decimal CantidadDestino = 0;
				string IdProducto = String.Empty;
				string Descripcion = String.Empty;
				decimal Entregado =0 ;
				decimal Reservado = 0; 
				bool isNull =  row.IsNull(row.Table.Columns["Entregado"],System.Data.DataRowVersion.Original);
				if(!isNull)
                    //German 20101216 - Tarea 996
					Entregado = Convert.ToDecimal(row["Entregado"]);
                    //Fin  German 20101216 - Tarea 996
				isNull =  row.IsNull(row.Table.Columns["Reservado"],System.Data.DataRowVersion.Original);
				if(!isNull)
                    //German 20101216 - Tarea 996
                    Reservado = Convert.ToDecimal(row["Reservado"]);
                    //Fin German 20101216 - Tarea 996
				decimal Precio = 0;
				OrdinalOrigen = Ordinal;
				Ordinal++;
				CantidadOrigen = Entregado + Reservado ; 
				CantidadDestino = CantidadOrigen;
				IdProducto = Convert.ToString(row["IdProducto"]);
				Descripcion = Descripcion = Convert.ToString(row["Producto"]);	
				isNull =  row.IsNull(row.Table.Columns["Precio"],System.Data.DataRowVersion.Original);
				if(!isNull)
					Precio = Convert.ToDecimal(row["Precio"]);
				string IdCond = Variables.GetValueString("Productos.Buscador.Precio.CondicionDeVentaVisualizacion");
				if(IdCond != string.Empty)
				{
					DataRow rowCond = mz.erp.businessrules.tsa_CondicionesDeVentas.GetByPk(IdCond);
					if(rowCond != null)
					{
						decimal Recargo = Convert.ToDecimal(rowCond["Recargo"]);
						Precio = Precio /(1+Recargo/100);
					}
				}
				tsh_ProductosDataset.tsh_ProductosRow producto = businessrules.tsh_Productos.GetByPk(IdProducto);
				_actualizaPrecio = false;
				decimal PrecioNetoActual = Precio;
				long IdInstanciaOR = Convert.ToInt64(row["IdInstanciaOrdenReparacion"]);
				RelacionComprobanteOrigenDestino ItemOrigen = new RelacionComprobanteOrigenDestino(IdComprobante, IdTipoDeComprobante, Numero, OrdinalOrigen, CantidadOrigen, CantidadDestino, IdProducto, Descripcion, Precio, IdCondicionDeVenta, PrecioNetoActual, EsEquipoNuevo, _processName, _taskName, _mainTaskName, IdInstanciaOR);						
				ItemOrigen.Visible = ItemsVisibles;
				ItemOrigen.IdOrdenReparacion = Convert.ToInt64(IdComprobante);
				ItemOrigen.IdInstanciaOrdenReparacion = IdInstanciaOR;
				ItemOrigen.IdTareaRealizada = 0;
				ItemOrigen.IdRepuestoOrdenReparacion = Convert.ToInt64(row["IdRepuestoOrdenReparacion"]);
				if(!EsEquipoNuevo && _habilitaUsuariaAltaOR)
				{
					ItemOrigen.Equipo = _equipo;
					ItemOrigen.IdResponsableOrigen = _idPersona;
				}
				this.Add(ItemOrigen);
			}
			return Ordinal;
		}



		public virtual void Add( RelacionComprobanteOrigenDestino rcod )
		{				
			List.Add ( rcod );			
		}
		
		public RelacionComprobanteOrigenDestino Get(int index)
		{
			return (RelacionComprobanteOrigenDestino) List[index];
		}
		/// <summary>
		/// Devuelve los comprobantes destino habilitados una vez que chequeo por cada comprobante y ordinal del detalle cuales son los comprobante destino
		/// que podrian efectuados y a su vez del resultado obtenido cuales de aquellos no estan en infracción por generar un ciclo dentro del workflow de comprobantes.
		/// Por cada comprobante sugerido chequeo que no existan exclusiones por circuitos
		/// Cada vez que itere devuelvo una nueva lista con los valores resultados, si a la lista se le
		/// van excluyendo progresivamente los comprobantes que contienen algunas vueltas de ciclo
		/// esta función puede llegar a dar como resultado que ningun comprobante sugerido está habilitado
		/// para completar el ciclo de los comprobantes origenes seleccionados.
		/// </summary>
		/// <returns></returns>
		public ArrayList ComprobantesDestinoPermitidos()
		{
			
			Hashtable lista = new Hashtable();
			foreach( RelacionComprobanteOrigenDestino detalle in this.List )
			{
				ArrayList array = mz.erp.businessrules.tlg_TiposComprobantesOrigenDestino.GetTipoComprobanteDestino( detalle.IdTipoDeComprobante );
				for (int i=0;i<array.Count;i++)
				{
					if (!lista.Contains( array[i] ))
					{
						lista.Add( array[i], true );
					}
				
				}
			}
			ArrayList arrayresultado = new ArrayList();
			Hashtable tablaNueva = new Hashtable();
			foreach( RelacionComprobanteOrigenDestino detalle in this.List )
			{
				foreach(object key in lista.Keys)
				{
					if ((bool)lista[key])
					{
						string comprobantesugerido = Convert.ToString(key);
						bool puedohacer = true; //funcionGerman.QuieroHacer( comprobantesugerido, idcomprobante, Ordinal )
						if(!(tablaNueva.Contains(key)))
							tablaNueva.Add(key,puedohacer);
					}
				}

			}
			foreach( object key in tablaNueva.Keys )
			{
				if ((bool)tablaNueva[key])
				{
					arrayresultado.Add( (string)key );
				}
			}
			return arrayresultado;
		}
		//German 20091023 - tarea 470
		private ArrayList _responsablesComprobantesAnteriores = new ArrayList();
		public ArrayList ResponsablesComprobantesAnteriores
		{
			get
			{
				return _responsablesComprobantesAnteriores;
			}
		}
		//Fin German 20091023 - tarea 470

		private string _idResponsable = string.Empty;
 

		public string IdResponsable
		{
			set 
			{
				_idResponsable = value;
			}
			get
			{
				return _idResponsable;
			}
		}

		private string _infoCliente = string.Empty;
		public string InfoCliente
		{
			set 
			{
				_infoCliente = value;
			}
			get 
			{
				return _infoCliente;
			}
		}
		private string _idCuenta = string.Empty;
		public string IdCuenta
		{
			set 
			{
				_idCuenta = value;
			}
			get
			{
				return _idCuenta;
			}		
		}
		private string _observaciones = string.Empty;
		public string Observaciones
		{
			set 
			{
				_observaciones = value;
			}
			get
			{
				return _observaciones;
			}		
		}
		private ArrayList _arrTiposComprobantesDestino = new ArrayList();
		public ArrayList ArrTiposComprobantesDestino
		{
			set 
			{
				_arrTiposComprobantesDestino = value;
			}
			get
			{
				return _arrTiposComprobantesDestino;
			}		
		}
		
	}

	/// <summary>
	/// Descripción breve de RelacionComprobanteOrigenDestino.
	/// </summary>
	/// 
	public class RelacionComprobanteOrigenDestino
	{
		
		private long _idInstanciaOR = 0;
		
		public long IdInstanciaOR
		{
			get{return _idInstanciaOR;}
		}

		private decimal _MACOR = 0;

		public decimal MACOR
		{
			get{return _MACOR;}
			set{_MACOR = value;}
		}
		
		private bool _visible = true;
		public bool Visible
		{
			get{return _visible;}
			set{_visible = value;}
		}
		private string _idTipoProducto = "A";
		public string IdTipoProducto
		{
			get
			{
				return _idTipoProducto;
			}
			set
			{
				_idTipoProducto = value;
			}
		}
		
		private bool _allowEdit = true;
		public bool AllowEdit
		{
			get
			{
				return _allowEdit;
			}
			set
			{
				_allowEdit = value;
			}
		}

		private bool _afectaStock = true;
		public bool AfectaStock
		{
			get
			{
				return _afectaStock;
			}
			set
			{
				_afectaStock = value;
			}
		}

		private bool _cierraCircuito = false;
		public bool CierraCircuito
		{
			get
			{
				return _cierraCircuito;
			}
			set
			{
				_cierraCircuito = value;
			}
		}

		private bool _entregar = true;
		public bool Entregar
		{
			get
			{
				return _entregar;
			}
			set
			{
				_entregar = value;
			}
		}

		private long _ordinalOrigen;
		public long OrdinalOrigen 
		{
			get 
			{
				return _ordinalOrigen;
			}
		}

		private decimal _cantidadPendiente;
		public decimal CantidadPendiente
		{
			get{return _cantidadPendiente;}
		}
		private decimal _cantidadOrigen;
		public decimal CantidadOrigen 
		{
			get 
			{
				return _cantidadOrigen;
			}
		}
		private decimal _cantidadDestino;
		public decimal CantidadDestino
		{
			get 
			{
				return _cantidadDestino;
			}
			set 
			{
				if (value < 0) 
				{
					_cantidadDestino = this.CantidadDestino;
				}
				else
				{
					if (value <= _cantidadOrigen)
					{
						_cantidadDestino = value;
					}
					else 
					{
						_cantidadDestino = this.CantidadDestino;
					}
				}
			}
		}

		private string _idProducto;
		public string IdProducto 
		{
			get 
			{
				return _idProducto;
			}
		}
		private string _descripcion;
		public string Descripcion 
		{
			get 
			{
				return _descripcion;
			}
		}
		private decimal _precio;
		public decimal Precio 
		{
			get 
			{
				return _precio;
			}
		}

		private decimal _precioNetoActual;
		public decimal PrecioNetoActual
		{
			get 
			{
				return _precioNetoActual;
			}
		}


		private string _idComprobante;
		public string IdComprobante
		{
			get 
			{
				return _idComprobante;
			}
		}

		private string _idTipoDeComprobante;
		public string IdTipoDeComprobante
		{
			get 
			{
				return _idTipoDeComprobante;
			}
		}

		private string _numero;
		public string Numero
		{
			get 
			{
				return _numero;
			}
		}


		private string _idCondicionDeVenta;
		public string IdCondicionDeVenta
		{
			get
			{
				return _idCondicionDeVenta;
			}
			
		}

		private bool _percibeIB = true;
		public bool PercibeIB
		{
			get{return _percibeIB;}
		}

		private long _contadorOrigen = 0;
		public long ContadorOrigen
		{
			get {return _contadorOrigen;}
			set {_contadorOrigen = value;}
		}

		private long _contadorDestino = 0;
		public long ContadorDestino
		{
			get {return _contadorDestino;}
			set {_contadorDestino = value;}
		}

		private long _idOrdenReparacion = 0;
		private long _idInstanciaOrdenReparacion = 0;
		private long _idTareaRealizada = 0;
		private long _idRepuestoOrdenReparacion = 0;
		private string _idComprobantesSucesores = string.Empty;
		private string _idComprobantesPredecesores = string.Empty;
		private string _idTiposComprobantesSucesores = string.Empty;
		private string _idTiposComprobantesPredecesores = string.Empty;
		private string _idResponsableOrigen=string.Empty;
		private long _equipo=0;
		private string _idListaDePrecios = string.Empty;
		private decimal _coeficienteListaDePrecios = 0; 
		private string _modoDeAplicacionListaDePrecios = string.Empty;
		private string _idListaDePreciosDefault = tsh_ListasDePrecios.GetDefault().IdListaDePrecio;


		private string _ordinalesPredecesores = string.Empty;
		private string _ordinalesSucesores = string.Empty;

		public string OrdinalesSucesores
		{
			get
			{
				return _ordinalesSucesores;
			}
			set
			{
				_ordinalesSucesores = value;
			}
		}

		public string OrdinalesPredecesores
		{
			get
			{
				return _ordinalesPredecesores;
			}
			set
			{
				_ordinalesPredecesores = value;
			}
		}

		public long IdInstanciaOrdenReparacion
		{
			get {return _idInstanciaOrdenReparacion;}
			set {_idInstanciaOrdenReparacion = value;}
		}

		public long IdRepuestoOrdenReparacion
		{
			get {return _idRepuestoOrdenReparacion;}
			set {_idRepuestoOrdenReparacion = value;}
		}

		public long IdOrdenReparacion
		{
			get {return _idOrdenReparacion;}
			set {_idOrdenReparacion = value;}
		}

		public long IdTareaRealizada
		{
			get {return _idTareaRealizada;}
			set {_idTareaRealizada = value;}
		}

		public string IdTiposComprobantesPredecesores
		{
			get {return _idTiposComprobantesPredecesores;}
			set {_idTiposComprobantesPredecesores = value;}
		}

		public string IdTiposComprobantesSucesores
		{
			get {return _idTiposComprobantesSucesores;}
			set {_idTiposComprobantesSucesores = value;}
		}

		
		public string IdResponsableOrigen
		{
			get {return _idResponsableOrigen;}
			set {_idResponsableOrigen = value;}
		}

		public long Equipo
		{
			get {return _equipo;}
			set {_equipo = value;}
		}
		public string IdComprobantesPredecesores
		{
			get {return _idComprobantesPredecesores;}
			set {_idComprobantesPredecesores = value;}
		}


		public string IdComprobantesSucesores
		{
			get {return _idComprobantesSucesores;}
			set {_idComprobantesSucesores = value;}
		}

		public string IdListaDePrecios
		{
			get { return _idListaDePrecios; }
			set { _idListaDePrecios = value; }
		}

		public decimal CoeficienteListaDePrecios
		{
			get { return _coeficienteListaDePrecios; }
			set { _coeficienteListaDePrecios = value; }
		}

		public string ModoDeAplicacionListaDePrecios
		{
			get { return _modoDeAplicacionListaDePrecios; }
			set { _modoDeAplicacionListaDePrecios = value; }
		}


		public string IdListaDePreciosDefault
		{
			get { return _idListaDePreciosDefault; }
			set { _idListaDePreciosDefault = value; }
		}
		private string _codigoProducto = string.Empty;
		public string CodigoProducto
		{
			get{return _codigoProducto;}
		}

        // ---- Matias - Tarea 204 - 20090722
		private string _campoAuxiliar1 = string.Empty;
		private string _campoAuxiliar2 = string.Empty;
		private string _campoAuxiliar3 = string.Empty;
		private string _campoAuxiliar4 = string.Empty;
		private string _campoAuxiliar5 = string.Empty;
		private string _campoAuxiliar6 = string.Empty;
		private string _codigoProveedor = string.Empty;
		private string _observaciones = string.Empty;
		private DateTime _fechaUltimaModificacionPrecioCosto;
		private DateTime _fechaUltimaModificacionPrecioVenta;

		public string CampoAuxiliar1
		{
			get	{return _campoAuxiliar1;}
		}
		public string CampoAuxiliar2
		{
			get	{return _campoAuxiliar2;}
		}
		public string CampoAuxiliar3
		{
			get	{return _campoAuxiliar3;}
		}
		public string CampoAuxiliar4
		{
			get	{return _campoAuxiliar4;}
		}
		public string CampoAuxiliar5
		{
			get	{return _campoAuxiliar5;}
		}
		public string CampoAuxiliar6
		{
			get	{return _campoAuxiliar6;}
		}
		public string CodigoProveedor
		{
			get	{return _codigoProveedor;}
		}
		public string Observaciones
		{
			get	{return _observaciones;}
		}
		public DateTime FechaUltimaModificacionPrecioCosto
		{
			get	{return _fechaUltimaModificacionPrecioCosto;}
		}
		public DateTime FechaUltimaModificacionPrecioVenta
		{
			get	{return _fechaUltimaModificacionPrecioVenta;}
		}
		// ---- FinMatias

		
		private bool EsPorEquipoNuevo(string IdComprobante, string IdTipoDeComprobante, ArrayList info)
		{
			DataRow row;
			if(IdTipoDeComprobante.Equals("OR"))
			{
				row = mz.erp.businessrules.st_OrdenReparacion.GetByPk(IdComprobante);
				if(row != null)
					return Convert.ToBoolean(row["EsEquipoNuevo"]);
				else return false;
			}
			else
			{
				bool pertenceOR = Convert.ToBoolean(info[0]);
				if(IdTipoDeComprobante.Equals("PFA") || IdTipoDeComprobante.Equals("PFB") && pertenceOR)
				{
					DataTable table = (DataTable)info[1];
					string IdOrdenReparacion = Convert.ToString(table.Rows[0]["IdOrdenReparacion"]);
					row = mz.erp.businessrules.st_OrdenReparacion.GetByPk(IdOrdenReparacion);
					if(row != null)
						return Convert.ToBoolean(row["EsEquipoNuevo"]);
					else return false;

				}
			}
			return false;
		}
		

		private long GetORAsociada(DataSet data)
		{
			
			
			foreach(DataRow row in data.Tables[0].Rows)
			{
				string IdTipoDeComprobante = Convert.ToString(row["IdTipoDeComprobante"]);
				if(IdTipoDeComprobante !=null && IdTipoDeComprobante.Equals("OR"))
				{
					return Convert.ToInt64(row["IdComprobante"]);

				}
			}	
			return long.MinValue;
		}

        //German 20120302 -  Tarea 0000247 - Se pone  private para que el constructor publico sea el mas completo, esto estaba provocanco que no se tenga en cuenta las listas de precios de ventas para comprobantes de entregas
		private RelacionComprobanteOrigenDestino(string IdComprobante, string IdTipoDeComprobante, string Numero, 
			long OrdinalOrigen, decimal CantidadOrigen, decimal CantidadDestino, string IdProducto, 
			string Descripcion, decimal Precio, string IdCondicionDeVenta, decimal PrecioNetoActual,
			string ProcessName, string CurrentTaskName, string MainTaskName)
        //Fin German 20120302 -  Tarea 0000247
		{
			_idComprobante = IdComprobante;
			_idTipoDeComprobante = IdTipoDeComprobante;
			_numero = Numero;			
			_ordinalOrigen = OrdinalOrigen;
			_cantidadOrigen = CantidadOrigen;
            _cantidadDestino = CantidadDestino;
			_cantidadPendiente = CantidadDestino;
			_idProducto = IdProducto;
			_descripcion = Descripcion;
			_precio = Precio;			
			_idCondicionDeVenta = IdCondicionDeVenta;
			_precioNetoActual = PrecioNetoActual;
			_allowEdit = true;
			_afectaStock = true;
			_entregar = true;
			_cierraCircuito = false;

			tsa_ComprobantesDetAuxiliaresDataset.tsa_ComprobantesDetAuxiliaresRow rowDA = mz.erp.businessrules.tsa_ComprobantesDetAuxiliares.GetByPk(IdComprobante, OrdinalOrigen);
			if(rowDA != null)
			{
				_contadorOrigen = rowDA.ContadorOrigen;
				_contadorDestino = rowDA.ContadorDestino;
				_idOrdenReparacion = rowDA.IdOrdenReparacion;
				_idComprobantesSucesores = rowDA.IdComprobantesSucesores;
				_idComprobantesPredecesores = rowDA.IdComprobantesPredecesores;
				_idTiposComprobantesPredecesores = rowDA.IdTiposComprobantesPredecesores;
				_idTiposComprobantesSucesores = rowDA.IdTiposComprobantesSucesores;
				_idRepuestoOrdenReparacion = rowDA.IdRepuestoOrdenReparacion;
				_idTareaRealizada = rowDA.IdTareaRealizada;
				_idInstanciaOrdenReparacion = rowDA.IdInstanciaOrdenReparacion;
				_idResponsableOrigen=rowDA.IdResponsableOrigen;
				_equipo=rowDA.Equipo;
				_ordinalesPredecesores = rowDA.OrdinalesPredecesores;
				_ordinalesSucesores = rowDA.OrdinalesSucesores;
			}
			
			DataRow row = mz.erp.businessrules.tsh_Productos.GetByPk(_idProducto);
			if(row != null)
			{
				_idTipoProducto = Convert.ToString(row["IdTipoProducto"]);
				//German 20090907
				//_afectaStock = mz.erp.businessrules.tsy_TipoProducto.AfectaStock(_idTipoProducto);
				//Fin German 20090907
				_percibeIB = Convert.ToBoolean(row["PercibeIB"]);
				_codigoProducto = Convert.ToString(row["Codigo"]);

				// ---- Matias - Tarea 204 - 20090722
				_campoAuxiliar1 = Convert.ToString(row["CampoAuxiliar1"]);
				_campoAuxiliar2 = Convert.ToString(row["CampoAuxiliar2"]);
				_campoAuxiliar3 = Convert.ToString(row["CampoAuxiliar3"]);
				_campoAuxiliar4 = Convert.ToString(row["CampoAuxiliar4"]);
				_campoAuxiliar5 = Convert.ToString(row["CampoAuxiliar5"]);
				_campoAuxiliar6 = Convert.ToString(row["CampoAuxiliar6"]);
				_codigoProveedor = Convert.ToString(row["CodigoProveedor"]);
				_observaciones = Convert.ToString(row["Observaciones"]);
				if ( row.IsNull("FechaUltimaModificacionPrecioDeCosto") )
					_fechaUltimaModificacionPrecioCosto= DateTime.MinValue;
				else
					_fechaUltimaModificacionPrecioCosto = Convert.ToDateTime(row["FechaUltimaModificacionPrecioDeCosto"]);
											
				if ( row.IsNull("FechaUltimaModificacionPrecioDeVenta") )
					_fechaUltimaModificacionPrecioVenta = DateTime.MinValue;
				else
					_fechaUltimaModificacionPrecioVenta = Convert.ToDateTime(row["FechaUltimaModificacionPrecioDeVenta"]);
				// ---- FinMatias
			}

			ArrayList result = new ArrayList();
			bool pertenceOrdenReparacion = false;
			bool EsEquipoNuevo = false;
			
			string prefacturas = Variables.GetValueString("Comprobantes.TiposDeComprobantes.Prefacturas");
			string prefacturasDV = Variables.GetValueString("Comprobantes.TiposDeComprobantes.Prefacturas DV");
			ArrayList compPrevios = mz.erp.systemframework.Util.Parse(prefacturas, ",");
			compPrevios.AddRange(mz.erp.systemframework.Util.Parse(prefacturasDV, ","));
			if(compPrevios.Contains(IdTipoDeComprobante))
			{	
				DataSet dataOR = Workflow.GetCaminoComprobantesOrdinalBottonUp(IdComprobante, OrdinalOrigen, "OR");
				long IdOR = GetORAsociada(dataOR);
				if( !IdOR.Equals(long.MinValue))
				{
					EsEquipoNuevo = EsPorEquipoNuevo(Convert.ToString(IdOR), "OR", result);
				
					bool AllowEditEquipoNuevo = false;
					bool AllowEditReparacion = false;
					if(EsEquipoNuevo)
					{
						_allowEdit = Variables.GetValueBool(ProcessName,"ArmarEquipoNuevo","Emision.Editar.Items");
						_entregar = Variables.GetValueBool(string.Empty,"ArmarEquipoNuevo","HabilitaEntregarMercaderia");
						_cierraCircuito =  !_entregar;
					}
					else
					{
						_allowEdit = Variables.GetValueBool(string.Empty,"Reparar","Emision.Editar.Items");
						_entregar = Variables.GetValueBool(string.Empty,"Reparar","HabilitaEntregarMercaderia");
						_cierraCircuito =  !_entregar;
					}
				}
				else 
				{
					_entregar = DebeEntregar(IdComprobante, OrdinalOrigen) ;//&& !TiposDeProductosExcluidosEntregaList.Contains(_idTipoProducto);
					_cierraCircuito = !_entregar;
				}

			}
			else
			{
				
				/*Responsable German*/
				bool ValidarEntregar = Variables.GetValueBool( ProcessName, CurrentTaskName, "Validar.GeneraEntregaMercaderia");
                if(ValidarEntregar)
				{
					_entregar = DebeEntregar(IdComprobante, OrdinalOrigen) ;//&& !TiposDeProductosExcluidosEntregaList.Contains(_idTipoProducto);
					_cierraCircuito = !_entregar;
				}
			}
			
			
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		
		
		
		public RelacionComprobanteOrigenDestino(string IdComprobante, string IdTipoDeComprobante, string Numero, 
			long OrdinalOrigen, decimal CantidadOrigen, decimal CantidadDestino, string IdProducto, 
			string Descripcion, decimal Precio, string IdCondicionDeVenta, decimal PrecioNetoActual,
			string ProcessName, string CurrentTaskName, string MainTaskName, string IdListaDePrecio, decimal CoeficienteListaDePrecio, string ModoDeAplicacion, string IdListaDePrecioDefault)
			
			:this(IdComprobante, IdTipoDeComprobante, Numero, 
			OrdinalOrigen, CantidadOrigen, CantidadDestino, IdProducto, Descripcion, Precio, IdCondicionDeVenta, PrecioNetoActual,
			ProcessName, CurrentTaskName, MainTaskName)
		{
			_idListaDePrecios = IdListaDePrecio;
			_coeficienteListaDePrecios = CoeficienteListaDePrecio;
			_modoDeAplicacionListaDePrecios = ModoDeAplicacion;
			_idListaDePreciosDefault = IdListaDePrecioDefault;
		}
		
		private bool DebeEntregar(string IdComprobante, long Ordinal)
		{
			System.Data.DataSet data = Workflow.GetCaminoComprobantesOrdinalBottonUp(IdComprobante, Ordinal,string.Empty);
			string ComprobantesDeEntrega = Variables.GetValueString("Comprobantes.ComprobantesDeEntrega");
			ArrayList ComprobantesDeEntregaList = mz.erp.systemframework.Util.Parse(ComprobantesDeEntrega, ",");
			foreach(System.Data.DataRow row in data.Tables[0].Rows)
			{
				if(ComprobantesDeEntregaList.Contains(Convert.ToString(row["IdTipoDeComprobante"])))
					return false;
			}
			return true;
		}

		#region Solo debe ser llamado cuando el Origen es una OR		
		public RelacionComprobanteOrigenDestino(string IdComprobante, string IdTipoDeComprobante, string Numero, 
			long OrdinalOrigen, decimal CantidadOrigen, decimal CantidadDestino, string IdProducto, 
			string Descripcion, decimal Precio, string IdCondicionDeVenta, decimal PrecioNetoActual, 
			bool EsEquipoNuevo, string ProcessName, string CurrentTaskName, string MainTaskName, long IdInstanciaOR)
		{
			_idComprobante = IdComprobante;
			_idTipoDeComprobante = IdTipoDeComprobante;
			_numero = Numero;			
			_ordinalOrigen = OrdinalOrigen;
			_cantidadOrigen = CantidadOrigen;
			_cantidadDestino = CantidadDestino;
			_cantidadPendiente = CantidadDestino;
			_idProducto = IdProducto;
			_descripcion = Descripcion;
			_precio = Precio;			
			_idCondicionDeVenta = IdCondicionDeVenta;
			_precioNetoActual = PrecioNetoActual;
			_allowEdit = true;
			_afectaStock = true;
			_entregar = true;
			_cierraCircuito = false;
			_idInstanciaOR = IdInstanciaOR;

			DataRow row = mz.erp.businessrules.tsh_Productos.GetByPk(_idProducto);
			if(row != null)
			{
				_idTipoProducto = Convert.ToString(row["IdTipoProducto"]);
				//German 20090907
				//_afectaStock = mz.erp.businessrules.tsy_TipoProducto.AfectaStock(_idTipoProducto);
				//Fin German 20090907
				_percibeIB = Convert.ToBoolean(row["PercibeIB"]);
				_codigoProducto = Convert.ToString(row["Codigo"]);

				// ---- Matias - Tarea 204 - 20090722
				_campoAuxiliar1 = Convert.ToString(row["CampoAuxiliar1"]);
				_campoAuxiliar2 = Convert.ToString(row["CampoAuxiliar2"]);
				_campoAuxiliar3 = Convert.ToString(row["CampoAuxiliar3"]);
				_campoAuxiliar4 = Convert.ToString(row["CampoAuxiliar4"]);
				_campoAuxiliar5 = Convert.ToString(row["CampoAuxiliar5"]);
				_campoAuxiliar6 = Convert.ToString(row["CampoAuxiliar6"]);
				_codigoProveedor = Convert.ToString(row["CodigoProveedor"]);
				_observaciones = Convert.ToString(row["Observaciones"]);
				if ( row.IsNull("FechaUltimaModificacionPrecioDeCosto") )
					_fechaUltimaModificacionPrecioCosto = DateTime.MinValue;
				else
					_fechaUltimaModificacionPrecioCosto = Convert.ToDateTime(row["FechaUltimaModificacionPrecioDeCosto"]);
				if ( row.IsNull("FechaUltimaModificacionPrecioDeVenta") )
					_fechaUltimaModificacionPrecioVenta = DateTime.MinValue;
				else
					_fechaUltimaModificacionPrecioVenta = Convert.ToDateTime(row["FechaUltimaModificacionPrecioDeVenta"]);
				// ---- FinMatias
			}
			if(EsEquipoNuevo)
			{
				_allowEdit = Variables.GetValueBool(ProcessName,"ArmarEquipoNuevo","Emision.Editar.Items");
				_entregar = Variables.GetValueBool(string.Empty,"ArmarEquipoNuevo","HabilitaEntregarMercaderia");
				_cierraCircuito =  !_entregar;
			}
			else
			{
				_allowEdit = Variables.GetValueBool(string.Empty,"Reparar","Emision.Editar.Items");
				_entregar = Variables.GetValueBool(ProcessName,"Reparar","HabilitaEntregarMercaderia");
				_cierraCircuito =  !_entregar;
			}	
			
		}
		#endregion

	}

    //German 20120307 - Tarea 0000290
    public class RelacionComprobanteOrigen
    {

        private string _idComprobanteOrigen = string.Empty;
        private long _ordinalOrigen;
        private decimal _cantidadOrigen; //Es la cantidad Original
        private decimal _cantidadDestino; //Es la cantidad destino para el comprobante actual, debe ser menor a la pendiente
        private decimal _precioDeCostoOrigen;
        private decimal _cantidadOrigenPendiente; //Es la cantidad pendiente (Cantidad Origen - Cantidad Destino)

        public RelacionComprobanteOrigen(string IdComprobanteOrigen, long Ordinal, decimal Cantidad, decimal CantidadPendiente, decimal CantidadDestino, decimal PrecioDeCosto)
        {
            _ordinalOrigen = Ordinal;
            _cantidadOrigen = Cantidad;
            _cantidadOrigenPendiente = CantidadPendiente;
            _precioDeCostoOrigen = PrecioDeCosto;
            _idComprobanteOrigen = IdComprobanteOrigen;
            _cantidadDestino = CantidadDestino;
        }

        public long OrdinalOrigen
        {
            get { return _ordinalOrigen; }
        }
        public decimal CantidadOrigenPendiente
        {
            get { return _cantidadOrigenPendiente; }
        }

        public decimal CantidadOrigen
        {
            get { return _cantidadOrigen; }
        }

        public decimal PrecioDeCostoOrigen
        {
            get { return _precioDeCostoOrigen; }
        }

        public string IdComprobanteOrigen
        {
            get { return _idComprobanteOrigen; }
        }

        public decimal CantidadDestino
        {
            get { return _cantidadDestino; }
        }




    }
    //Fin German 20120307 - Tarea 0000290

}

	

