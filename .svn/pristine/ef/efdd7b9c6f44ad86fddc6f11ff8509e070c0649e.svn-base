using System;
using System.Collections;
using mz.erp.businessrules.comprobantes;
using mz.erp.commontypes.data;
using mz.erp.businessrules.data;
using mz.erp.businessrules;
using System.Data;
using System.Windows.Forms;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Clase utilizada para la creación y modificación de una condición de venta.
	/// </summary>
	public class CondicionDeVenta
	{
		private string _estado;

		private tsa_CondicionesDeVentasDataset _dataCondVenta = new mz.erp.commontypes.data.tsa_CondicionesDeVentasDataset();
		private tsa_CondicionesDeVentaDetDataset _dataCondVentaDet = new mz.erp.commontypes.data.tsa_CondicionesDeVentaDetDataset();
		private tfi_TDCompTesoreria_CondicionesDeVentaDataset _dataTDCompTesoreria_CondVenta = new tfi_TDCompTesoreria_CondicionesDeVentaDataset();
		private Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset _dataTiposDeCompTDCompTesoreriaCondVentas = new Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset();
		private tsa_CuentasCondicionesDeVenta_TDCompTesoreriaDataset _dataCuentasTDCompTesoreriaCondVentas = new tsa_CuentasCondicionesDeVenta_TDCompTesoreriaDataset();
		private ArrayList _idTDComp = new ArrayList();
		private string _proceso = string.Empty;

		/**
		public CondicionDeVenta()
		{

		}*/

		public CondicionDeVenta(string IdCondicionDeVenta, string Proceso)
		{
			_proceso = Proceso;
			if (IdCondicionDeVenta == null)
			{
				//creacion de todos los objetos de las clases relacionadas
				//_formasDePago = new FormasDePagoCondicionDeVenta(IdCondicionDeVenta);
				//_cuentas = new CuentaCondicionesDeVenta(IdCondicionDeVenta);
				//_tipoDeComprobante = new TipoDeComprobanteCondicionDeVenta(IdCondicionDeVenta);
				_estado= "NEW";
			}
			else 
			{
				//levantar todos los ojetos de este id
				this.GetCondicionDeVenta_IdCondicionDeVenta(IdCondicionDeVenta);

				_estado ="MODIFY";
			
			}

		}

		#region Propiedades

		private string _idCondicionDeVenta = string.Empty;		
		public string IdCondicionDeVenta
		{
			get { return _idCondicionDeVenta; }
			set
			{
					GetCondicionDeVenta_IdCondicionDeVenta(value);
				_idCondicionDeVenta = value;
			}
		}


		private int _cuotas;
		public int Cuotas
		{
			get	{return _cuotas;}
			set
			{
				_cuotas = value;
			}
		}

		private short _diasDeVencimiento;
		public short DiasDeVencimiento
		{
			get	{return _diasDeVencimiento;}
			set
			{
				_diasDeVencimiento = value;
			}
		}

		private Decimal	_recargo;
		public Decimal Recargo
		{
			get	{return _recargo;}
			set
			{
				_recargo = value;
			}
		}

		private bool _activo = true;
		public bool Activo
		{
			get	{return _activo;}
			set
			{
				_activo = value;
			}
		}

		private string _descripcion = String.Empty;
		public string Descripcion
		{
			get	{return _descripcion;}
			set
			{
				_descripcion = value;
			}
		}

		private string _metodoAsignacionTipoDeComprobante = String.Empty;
		public string MetodoDeAsignacionTipoDeComprobante
		{
			get{return _metodoAsignacionTipoDeComprobante;}
			set{_metodoAsignacionTipoDeComprobante = value;}
		}

		private string _metodoAsignacionCuenta = String.Empty;
		public string MetodoDeAsignacionCuenta
		{
			get{return _metodoAsignacionCuenta;}
			set{_metodoAsignacionCuenta = value;}
		}

		private string _metodoComparacion = String.Empty;
		public string MetodoComparacion
		{
			get{return _metodoComparacion;}
			set{_metodoComparacion = value;}
		}

		private bool _todosLosComprobantes;
		public bool TodosLosComprobantes
		{
			get {return _todosLosComprobantes;}
			set{_todosLosComprobantes = value;}
		}

		private TiposDeComprobantes _listaTiposDeComprobantesSeleccionados = new TiposDeComprobantes();
		public TiposDeComprobantes ListaTiposDeComprobantesSeleccionados
		{
			get {return _listaTiposDeComprobantesSeleccionados;}
			set {_listaTiposDeComprobantesSeleccionados = value;}
		}

		private TiposDeComprobantes _tiposDeComprobantes = new TiposDeComprobantes();
		public TiposDeComprobantes TiposDeComprobantes
		{
			get {return _tiposDeComprobantes;}
			set {_tiposDeComprobantes = value;}
		}

		private FormasDePagos _listaFormasDePagoSeleccionadas = new FormasDePagos();
		public FormasDePagos ListaFormasDePagoSeleccionadas
		{
			get {return _listaFormasDePagoSeleccionadas;}
			set {_listaFormasDePagoSeleccionadas = value;}
		}

		private FormasDePagos _formasDePago = new FormasDePagos();
		public FormasDePagos FormasDePago
		{
			get {return _formasDePago;}
			set {_formasDePago = value;}
		}

		private ArrayList _listaCuentasABorrar = new ArrayList();
		public ArrayList ListaCuentasSeleccionadasABorrar
		{
			get {return _listaCuentasABorrar;}
			set {_listaCuentasABorrar = value;}
		}

		private Cuentas _listaCuentas = new Cuentas();
		public Cuentas ListaCuentas
		{
			get {return _listaCuentas;}
			set {_listaCuentas = value;}
		}

		public tsa_CondicionesDeVentasDataset DataCondicionDeVenta
		{
			get {return _dataCondVenta;}
		}

		public tsa_CondicionesDeVentaDetDataset DataCondicionDeVentaDet
		{
			get {return _dataCondVentaDet;}
		}
		
		public tfi_TDCompTesoreria_CondicionesDeVentaDataset DataTDComp_Tesoreria_CondDeVenta
		{
			get {return _dataTDCompTesoreria_CondVenta;}
		}

		public Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset DataTiposDeComp_Tesoreria_CondVenta
		{
			get {return _dataTiposDeCompTDCompTesoreriaCondVentas;}
		}

		public tsa_CuentasCondicionesDeVenta_TDCompTesoreriaDataset DataCuenta_TDComp_Tesoreria 
		{
			get {return _dataCuentasTDCompTesoreriaCondVentas;}
		}

		#endregion


		public void Commit()
		{
			if (_estado == "NEW")
			{
				#region NEW

				tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasRow rowCondVta = _dataCondVenta.tsa_CondicionesDeVentas.Newtsa_CondicionesDeVentasRow();
				
				mz.erp.businessrules.tsa_CondicionesDeVentas.SetRowDefaultValues(rowCondVta);
				
				rowCondVta.Descripcion = this._descripcion;
				rowCondVta.Recargo = this._recargo;
				rowCondVta.Activo = this._activo;

				_dataCondVenta.tsa_CondicionesDeVentas.Rows.Add(rowCondVta);

				tsa_CondicionesDeVentaDetDataset.tsa_CondicionesDeVentaDetRow rowCondVtaDet = _dataCondVentaDet.tsa_CondicionesDeVentaDet.Newtsa_CondicionesDeVentaDetRow();
				
				mz.erp.businessrules.tsa_CondicionesDeVentaDet.SetRowDefaultValues(rowCondVtaDet);
				rowCondVtaDet.DiasVencimiento = this._diasDeVencimiento;
				
				_dataCondVentaDet.tsa_CondicionesDeVentaDet.Rows.Add(rowCondVtaDet);

				AgregarFormaDePago();
				AgregarComprobante();
				AgregarCuenta();
	
				#endregion 
                			
			}
			else 
			{  //estado = "MODIFY"

				#region MODIFY

				tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasRow rowCondVta = mz.erp.dataaccess.tsa_CondicionesDeVentas.GetByPk(_idCondicionDeVenta);
		
				rowCondVta.Descripcion = this._descripcion;
				rowCondVta.Recargo = this._recargo;
				rowCondVta.Activo = this._activo;
				
				_dataCondVenta.tsa_CondicionesDeVentas.ImportRow(rowCondVta);
				
				tsa_CondicionesDeVentaDetDataset.tsa_CondicionesDeVentaDetRow rowCondVtaDet = mz.erp.dataaccess.tsa_CondicionesDeVentaDet.GetByPk(_idCondicionDeVenta,1);
				
				rowCondVtaDet.DiasVencimiento = this._diasDeVencimiento;
				
				_dataCondVentaDet.tsa_CondicionesDeVentaDet.ImportRow(rowCondVtaDet);

				ModificarFormaDePago(_idCondicionDeVenta);
				ModificarComprobante(_idCondicionDeVenta);
				ModificarCuenta(_idCondicionDeVenta);

			}
			#endregion
			
		}


		#region Métodos privados

		private void AgregarFormaDePago()
		{ 
			if (this._listaFormasDePagoSeleccionadas.Count == 0)
			{
				tfi_TDCompTesoreria_CondicionesDeVentaDataset.tfi_TDCompTesoreria_CondicionesDeVentaRow rowTDCompTes_ConVta = _dataTDCompTesoreria_CondVenta.tfi_TDCompTesoreria_CondicionesDeVenta.Newtfi_TDCompTesoreria_CondicionesDeVentaRow();	
				mz.erp.businessrules.tfi_TDCompTesoreria_CondicionesDeVenta.SetRowDefaultValues(rowTDCompTes_ConVta);
				rowTDCompTes_ConVta.idTDCompTesoreria = null;
				rowTDCompTes_ConVta.MetodoDeComparacion = this._metodoComparacion;
				_dataTDCompTesoreria_CondVenta.tfi_TDCompTesoreria_CondicionesDeVenta.Addtfi_TDCompTesoreria_CondicionesDeVentaRow(rowTDCompTes_ConVta);
			}
			else 
			{
				foreach(FormaDePago fp in this._listaFormasDePagoSeleccionadas)
				{
					tfi_TDCompTesoreria_CondicionesDeVentaDataset.tfi_TDCompTesoreria_CondicionesDeVentaRow rowTDCompTes_ConVta = _dataTDCompTesoreria_CondVenta.tfi_TDCompTesoreria_CondicionesDeVenta.Newtfi_TDCompTesoreria_CondicionesDeVentaRow();	
					mz.erp.businessrules.tfi_TDCompTesoreria_CondicionesDeVenta.SetRowDefaultValues(rowTDCompTes_ConVta);
					rowTDCompTes_ConVta.idTDCompTesoreria = fp.IdFormaDePago;
					this._idTDComp.Add(fp.IdFormaDePago);
					rowTDCompTes_ConVta.MetodoDeComparacion = this._metodoComparacion;
					_dataTDCompTesoreria_CondVenta.tfi_TDCompTesoreria_CondicionesDeVenta.Addtfi_TDCompTesoreria_CondicionesDeVentaRow(rowTDCompTes_ConVta);
				}
			}
		}


		private void ModificarFormaDePago(string IdCondicionDeVenta)
		{ 

			if (this.ListaFormasDePagoSeleccionadas.Count == 0 && _diasDeVencimiento != 0)
			{
				bool _insertarNull = true;

				tfi_TDCompTesoreria_CondicionesDeVentaDataset dataAux = tfi_TDCompTesoreria_CondicionesDeVenta.GetList(null,null,IdCondicionDeVenta);
				foreach (tfi_TDCompTesoreria_CondicionesDeVentaDataset.tfi_TDCompTesoreria_CondicionesDeVentaRow row in dataAux.tfi_TDCompTesoreria_CondicionesDeVenta.Rows)
				{
					if (row.IsidTDCompTesoreriaNull())
					{
						_insertarNull = false;
					}
				}
				if (_insertarNull)
				{
					tfi_TDCompTesoreria_CondicionesDeVentaDataset.tfi_TDCompTesoreria_CondicionesDeVentaRow rowTDCompTes_ConVta = _dataTDCompTesoreria_CondVenta.tfi_TDCompTesoreria_CondicionesDeVenta.Newtfi_TDCompTesoreria_CondicionesDeVentaRow();	
					mz.erp.businessrules.tfi_TDCompTesoreria_CondicionesDeVenta.SetRowDefaultValues(rowTDCompTes_ConVta);
					rowTDCompTes_ConVta.idTDCompTesoreria = null;
					rowTDCompTes_ConVta.MetodoDeComparacion = this._metodoComparacion;
					_dataTDCompTesoreria_CondVenta.tfi_TDCompTesoreria_CondicionesDeVenta.Addtfi_TDCompTesoreria_CondicionesDeVentaRow(rowTDCompTes_ConVta);
				}
			}

			bool agregue = false;

			foreach(FormaDePago fp in this.FormasDePago)
			{	
				if (fp.Agregada)
				{
					#region No vino de la BD

                    if (!fp.SourceBD)
                    {// Agregar Forma de Pago
                        tfi_TDCompTesoreria_CondicionesDeVentaDataset.tfi_TDCompTesoreria_CondicionesDeVentaRow rowTDCompTes_ConVta = _dataTDCompTesoreria_CondVenta.tfi_TDCompTesoreria_CondicionesDeVenta.Newtfi_TDCompTesoreria_CondicionesDeVentaRow();
                        mz.erp.businessrules.tfi_TDCompTesoreria_CondicionesDeVenta.SetRowDefaultValues(rowTDCompTes_ConVta);
                        rowTDCompTes_ConVta.idTDCompTesoreria = fp.IdFormaDePago;
                        this._idTDComp.Add(fp.IdFormaDePago);
                        rowTDCompTes_ConVta.MetodoDeComparacion = this._metodoComparacion;
                        _dataTDCompTesoreria_CondVenta.tfi_TDCompTesoreria_CondicionesDeVenta.Addtfi_TDCompTesoreria_CondicionesDeVentaRow(rowTDCompTes_ConVta);

                        foreach (TipoDeComprobante tc in this.ListaTiposDeComprobantesSeleccionados)
                        {
                            if (tc.SourceBD)
                            {
                                Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow row_TC_CV_TDCT = this._dataTiposDeCompTDCompTesoreriaCondVentas.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.NewTsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow();
                                mz.erp.businessrules.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.SetRowDefaultValues(row_TC_CV_TDCT);
                                row_TC_CV_TDCT.IdTipoDeComprobante = tc.IdTipoComprobante;
                                row_TC_CV_TDCT.MetodoDeAsignacion = this.MetodoDeAsignacionTipoDeComprobante;
                                row_TC_CV_TDCT.IdTDCompTesoreria = fp.IdFormaDePago;
                                _dataTiposDeCompTDCompTesoreriaCondVentas.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.AddTsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow(row_TC_CV_TDCT);
                            }
                        }

                        agregue = true;

                        foreach (Cuenta cta in this.ListaCuentas)
                        {
                            if (cta.SourceBD)
                            {
                                tsa_CuentasCondicionesDeVenta_TDCompTesoreriaDataset.tsa_CuentasCondicionesDeVenta_TDCompTesoreriaRow row_C_CV_TDCT = this._dataCuentasTDCompTesoreriaCondVentas.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.Newtsa_CuentasCondicionesDeVenta_TDCompTesoreriaRow();
                                mz.erp.businessrules.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.SetRowDefaultValues(row_C_CV_TDCT);
                                row_C_CV_TDCT.IdCuenta = cta.IdCuenta;
                                row_C_CV_TDCT.MetodoDeAsignacion = this.MetodoDeAsignacionCuenta;
                                row_C_CV_TDCT.idTDCompTesoreria = fp.IdFormaDePago;
                                _dataCuentasTDCompTesoreriaCondVentas.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.Addtsa_CuentasCondicionesDeVenta_TDCompTesoreriaRow(row_C_CV_TDCT);
                            }
                        }
                    }
                    #endregion
                    /* Silvina 20100601 - Tarea 767 */
                    else
                    {
                        tfi_TDCompTesoreria_CondicionesDeVentaDataset data = tfi_TDCompTesoreria_CondicionesDeVenta.GetList(null, fp.IdFormaDePago, _idCondicionDeVenta);
                        foreach (tfi_TDCompTesoreria_CondicionesDeVentaDataset.tfi_TDCompTesoreria_CondicionesDeVentaRow row in data.tfi_TDCompTesoreria_CondicionesDeVenta.Rows)
                        {
                            foreach (FormaDePago fps in this.ListaFormasDePagoSeleccionadas)
                            {
                                // if (!row.IsIdTDCompTesoreriaNull() && fp.IdFormaDePago.Equals(row.IdTDCompTesoreria))
                                if (fps.SourceBD && fps.Agregada && fps.IdFormaDePago.Equals(row.idTDCompTesoreria))
                                {
                                    row.MetodoDeComparacion = this.MetodoComparacion;
                                    _dataTDCompTesoreria_CondVenta.tfi_TDCompTesoreria_CondicionesDeVenta.ImportRow(row);
                                }

                            }
                        }
                    }
                    /* Fin Silvina */
				}
				else 
				{
					#region vino de la BD
					if (fp.SourceBD)
					{/* Borrar Forma de Pago
						Tambien hay que borrarlo de Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria
						y de tsa_CuentasCondicionesDeVenta_TDCompTesoreria */

						//Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset dataComprobantes = mz.erp.dataaccess.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.GetList(null,fp.IdTDComprobante,fp.IdFormaDePago,IdCondicionDeVenta);
						Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset dataComprobantes = mz.erp.dataaccess.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.GetList(null,null,fp.IdFormaDePago,IdCondicionDeVenta);
						foreach (Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow rowTDComp in dataComprobantes.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.Rows)
						{
							rowTDComp.Delete();
						}
					
						_dataTiposDeCompTDCompTesoreriaCondVentas.Merge(dataComprobantes);

						DataSet data = mz.erp.dataaccess.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.GetList(null,IdCondicionDeVenta,fp.IdFormaDePago);
				
						foreach (DataRow rowCuenta in data.Tables["tsa_CuentasCondicionesDeVenta_TDCompTesoreria"].Rows)
						{
							rowCuenta.Delete();
						}
						_dataCuentasTDCompTesoreriaCondVentas.Merge(data);

						// Borra de tfi_TDCompTesoreria_CondicionesDeVenta
						//_dataTDCompTesoreria_CondVenta = mz.erp.dataaccess.tfi_TDCompTesoreria_CondicionesDeVenta.GetList(null,fp.IdFormaDePago,IdCondicionDeVenta);	
						//_dataTDCompTesoreria_CondVenta.tfi_TDCompTesoreria_CondicionesDeVenta.Rows[0].Delete();

						
              			 tfi_TDCompTesoreria_CondicionesDeVentaDataset dataTDComp = mz.erp.dataaccess.tfi_TDCompTesoreria_CondicionesDeVenta.GetList(null,fp.IdFormaDePago,IdCondicionDeVenta);	
						foreach (tfi_TDCompTesoreria_CondicionesDeVentaDataset.tfi_TDCompTesoreria_CondicionesDeVentaRow rowTDComp in dataTDComp.tfi_TDCompTesoreria_CondicionesDeVenta.Rows)
						{
							rowTDComp.Delete();
						}
						_dataTDCompTesoreria_CondVenta.Merge(dataTDComp);
						
					}
					#endregion
				}
			}

			if (agregue)
			{
				tfi_TDCompTesoreria_CondicionesDeVentaDataset dataAux = tfi_TDCompTesoreria_CondicionesDeVenta.GetList(null,null,IdCondicionDeVenta);
				foreach (tfi_TDCompTesoreria_CondicionesDeVentaDataset.tfi_TDCompTesoreria_CondicionesDeVentaRow row in dataAux.tfi_TDCompTesoreria_CondicionesDeVenta.Rows)
				{
					if (row.IsidTDCompTesoreriaNull())
					{
						row.Delete();
						_dataTDCompTesoreria_CondVenta.tfi_TDCompTesoreria_CondicionesDeVenta.ImportRow(row);
					}
				}

				Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset dataComprobantes = mz.erp.dataaccess.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.GetList(null,null,null,IdCondicionDeVenta);
				foreach (Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow rowTDComp in dataComprobantes.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.Rows)
				{
					if (rowTDComp.IsIdTDCompTesoreriaNull())
					{
						rowTDComp.Delete();
						_dataTiposDeCompTDCompTesoreriaCondVentas.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.ImportRow(rowTDComp);
					}
				}
					
			}
		}
	
		private void AgregarComprobante()
		{
			foreach(TipoDeComprobante tc in this._listaTiposDeComprobantesSeleccionados)
			{
				if (this._idTDComp.Count == 0)
				{
					Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow row_TC_CV_TDCT = this._dataTiposDeCompTDCompTesoreriaCondVentas.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.NewTsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow();
					mz.erp.businessrules.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.SetRowDefaultValues(row_TC_CV_TDCT);
					row_TC_CV_TDCT.IdTipoDeComprobante = tc.IdTipoComprobante;
					row_TC_CV_TDCT.MetodoDeAsignacion = this.MetodoDeAsignacionTipoDeComprobante;
					row_TC_CV_TDCT.IdTDCompTesoreria = null;
					_dataTiposDeCompTDCompTesoreriaCondVentas.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.AddTsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow(row_TC_CV_TDCT);
				}
				else 
				{
					foreach(string id in this._idTDComp)
					{					
						Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow row_TC_CV_TDCT = this._dataTiposDeCompTDCompTesoreriaCondVentas.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.NewTsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow();
						mz.erp.businessrules.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.SetRowDefaultValues(row_TC_CV_TDCT);
						row_TC_CV_TDCT.IdTipoDeComprobante = tc.IdTipoComprobante;
						row_TC_CV_TDCT.MetodoDeAsignacion = this.MetodoDeAsignacionTipoDeComprobante;
						row_TC_CV_TDCT.IdTDCompTesoreria = id;
						_dataTiposDeCompTDCompTesoreriaCondVentas.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.AddTsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow(row_TC_CV_TDCT);
					}
				}
			}
		}

		private void ModificarComprobante(string IdCondicionDeVenta)
		{ 
			foreach(TipoDeComprobante tc in this.TiposDeComprobantes)
			{
				if (tc.Agregado)
				{

					if (this.ListaFormasDePagoSeleccionadas.Count == 0)
					{
						bool _insertarNull = true;
						
						Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset data = Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.GetList(null,null,null,IdCondicionDeVenta);
						foreach (Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow row in data.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.Rows)
						{
							if (row.IsIdTDCompTesoreriaNull())
							{
								_insertarNull = false;
							}
						}
						if (_insertarNull)
						{
							Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow row_TC_CV_TDCT = this._dataTiposDeCompTDCompTesoreriaCondVentas.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.NewTsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow();
							mz.erp.businessrules.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.SetRowDefaultValues(row_TC_CV_TDCT);
							row_TC_CV_TDCT.IdTipoDeComprobante = tc.IdTipoComprobante;
							row_TC_CV_TDCT.MetodoDeAsignacion = this.MetodoDeAsignacionTipoDeComprobante;
							row_TC_CV_TDCT.IdTDCompTesoreria = null;
							_dataTiposDeCompTDCompTesoreriaCondVentas.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.AddTsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow(row_TC_CV_TDCT);
						}
					}
					else  {
                        if (!tc.SourceBD)
                        {// Agregar el Comprobante

                            foreach (FormaDePago fp in this.ListaFormasDePagoSeleccionadas)
                            {
                                Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow row_TC_CV_TDCT = this._dataTiposDeCompTDCompTesoreriaCondVentas.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.NewTsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow();
                                mz.erp.businessrules.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.SetRowDefaultValues(row_TC_CV_TDCT);
                                row_TC_CV_TDCT.IdTipoDeComprobante = tc.IdTipoComprobante;
                                row_TC_CV_TDCT.MetodoDeAsignacion = this.MetodoDeAsignacionTipoDeComprobante;
                                row_TC_CV_TDCT.IdTDCompTesoreria = fp.IdFormaDePago;
                                _dataTiposDeCompTDCompTesoreriaCondVentas.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.AddTsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow(row_TC_CV_TDCT);
                            }
                        }
                        /* Silvina 20100601 - Tarea 767 */
                        else
                        {
                            Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset data = Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.GetList(null, tc.IdTipoComprobante, null, IdCondicionDeVenta);
                            foreach (Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow row in data.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.Rows)
                            {
                                foreach (FormaDePago fp in this.ListaFormasDePagoSeleccionadas)
                                {
                                   // if (!row.IsIdTDCompTesoreriaNull() && fp.IdFormaDePago.Equals(row.IdTDCompTesoreria))
                                    if (fp.SourceBD && fp.Agregada && fp.IdFormaDePago.Equals(row.IdTDCompTesoreria))
                                    {
                                        row.MetodoDeAsignacion = this.MetodoDeAsignacionTipoDeComprobante;
                                        _dataTiposDeCompTDCompTesoreriaCondVentas.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.ImportRow(row);
                                    }
                                }
                            }
                        }
                        /* Fin Silvina */
					}
				}
				else 
				{
					if (tc.SourceBD)
					{// Borrar el Comprobante

						Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset dataTiposComp= mz.erp.dataaccess.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.GetList(null,tc.IdTipoComprobante,null,IdCondicionDeVenta);
						foreach (Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow rowTDComp in dataTiposComp.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.Rows)
						{
							rowTDComp.Delete();
						}
						_dataTiposDeCompTDCompTesoreriaCondVentas.Merge(dataTiposComp);
					}
				}
			}
		}

		private void AgregarCuenta()
		{
			foreach(Cuenta c in this._listaCuentas)
			{

				if (this._idTDComp.Count == 0)
				{
					tsa_CuentasCondicionesDeVenta_TDCompTesoreriaDataset.tsa_CuentasCondicionesDeVenta_TDCompTesoreriaRow row_C_CV_TDCT = this._dataCuentasTDCompTesoreriaCondVentas.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.Newtsa_CuentasCondicionesDeVenta_TDCompTesoreriaRow();
					mz.erp.businessrules.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.SetRowDefaultValues(row_C_CV_TDCT);
					row_C_CV_TDCT.IdCuenta = c.IdCuenta;
					row_C_CV_TDCT.MetodoDeAsignacion = this.MetodoDeAsignacionCuenta;			
					row_C_CV_TDCT.idTDCompTesoreria =  null; 
					_dataCuentasTDCompTesoreriaCondVentas.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.Addtsa_CuentasCondicionesDeVenta_TDCompTesoreriaRow(row_C_CV_TDCT);
				}
				else 
				{
					foreach(string id in this._idTDComp)
					{
						tsa_CuentasCondicionesDeVenta_TDCompTesoreriaDataset.tsa_CuentasCondicionesDeVenta_TDCompTesoreriaRow row_C_CV_TDCT = this._dataCuentasTDCompTesoreriaCondVentas.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.Newtsa_CuentasCondicionesDeVenta_TDCompTesoreriaRow();
						mz.erp.businessrules.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.SetRowDefaultValues(row_C_CV_TDCT);
						row_C_CV_TDCT.IdCuenta = c.IdCuenta;
						row_C_CV_TDCT.MetodoDeAsignacion = this.MetodoDeAsignacionCuenta;			
						row_C_CV_TDCT.idTDCompTesoreria =  id; 
						_dataCuentasTDCompTesoreriaCondVentas.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.Addtsa_CuentasCondicionesDeVenta_TDCompTesoreriaRow(row_C_CV_TDCT);
					}					
				}
			}
		}

		private void ModificarCuenta(string IdCondicionDeVenta)
		{ 

			foreach(Cuenta c in this._listaCuentasABorrar)
			{
				//Borrar de tsa_CuentasCondicionesDeVenta_TDCompTesoreriaRow
				
				DataSet data = mz.erp.dataaccess.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.GetList(c.IdCuenta,IdCondicionDeVenta,null);
				
				foreach (DataRow rowCuenta in data.Tables["tsa_CuentasCondicionesDeVenta_TDCompTesoreria"].Rows)
				{
					rowCuenta.Delete();
				}
				_dataCuentasTDCompTesoreriaCondVentas.Merge(data);
			}

			foreach(Cuenta c in this._listaCuentas)
			{
				if (c.Agregado && !c.SourceBD)
                {
                        //insertar en tsa_CuentasCondicionesDeVenta_TDCompTesoreriaRow

                        if (this.ListaFormasDePagoSeleccionadas.Count == 0)
                        {
                            tsa_CuentasCondicionesDeVenta_TDCompTesoreriaDataset.tsa_CuentasCondicionesDeVenta_TDCompTesoreriaRow row_C_CV_TDCT = this._dataCuentasTDCompTesoreriaCondVentas.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.Newtsa_CuentasCondicionesDeVenta_TDCompTesoreriaRow();
                            mz.erp.businessrules.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.SetRowDefaultValues(row_C_CV_TDCT);
                            row_C_CV_TDCT.IdCuenta = c.IdCuenta;
                            row_C_CV_TDCT.MetodoDeAsignacion = this.MetodoDeAsignacionCuenta;
                            row_C_CV_TDCT.idTDCompTesoreria = null;
                            _dataCuentasTDCompTesoreriaCondVentas.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.Addtsa_CuentasCondicionesDeVenta_TDCompTesoreriaRow(row_C_CV_TDCT);
                        }
                        else
                        {
                            foreach (FormaDePago fp in this.ListaFormasDePagoSeleccionadas)
                            {
                                tsa_CuentasCondicionesDeVenta_TDCompTesoreriaDataset.tsa_CuentasCondicionesDeVenta_TDCompTesoreriaRow row_C_CV_TDCT = this._dataCuentasTDCompTesoreriaCondVentas.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.Newtsa_CuentasCondicionesDeVenta_TDCompTesoreriaRow();
                                mz.erp.businessrules.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.SetRowDefaultValues(row_C_CV_TDCT);
                                row_C_CV_TDCT.IdCuenta = c.IdCuenta;
                                row_C_CV_TDCT.MetodoDeAsignacion = this.MetodoDeAsignacionCuenta;
                                row_C_CV_TDCT.idTDCompTesoreria = fp.IdFormaDePago;
                                _dataCuentasTDCompTesoreriaCondVentas.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.Addtsa_CuentasCondicionesDeVenta_TDCompTesoreriaRow(row_C_CV_TDCT);
                            }
                        }
                }
                /* Silvina 20100601 - Tarea 767 */
                else
                {
                     DataSet data = mz.erp.dataaccess.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.GetList(c.IdCuenta, IdCondicionDeVenta, null);
                     foreach (DataRow row in data.Tables[0].Rows)
                     {
                         foreach (Cuenta cta in ListaCuentasSeleccionadasABorrar)
                         {
                             if (row["IdCuenta"].ToString().Equals(cta.IdCuenta))
                             {
                                 row["MetodoDeAsignacion"] = this.MetodoDeAsignacionCuenta;
                                 _dataCuentasTDCompTesoreriaCondVentas.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.ImportRow(row);
                             }
                         }
                     }
                }
                /* Fin Silvina */
				
			}
		}

		private void FillStaticData(tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasRow row) 
		{		 
			if (row !=null)
			{
				this.Activo = row.Activo;
				this.Descripcion = row.Descripcion;
				this.Recargo = row.Recargo;				
			}
		}

		private void FillStaticDataDet(tsa_CondicionesDeVentaDetDataset.tsa_CondicionesDeVentaDetRow row)
		{
			if (row !=null)
			{
				this.Cuotas = row.Cuota;
				this.DiasDeVencimiento = row.DiasVencimiento;
			}
		}
		#endregion

		#region Métodos públicos
		public void GetCondicionDeVenta_IdCondicionDeVenta(string IdCondicionDeVenta) 
		{
			_estado = "MODIFY";

			tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasRow row = mz.erp.dataaccess.tsa_CondicionesDeVentas.GetByPk(IdCondicionDeVenta);
			this.FillStaticData(row);
			tsa_CondicionesDeVentaDetDataset.tsa_CondicionesDeVentaDetRow rowCondVtaDet = mz.erp.dataaccess.tsa_CondicionesDeVentaDet.GetByPk(IdCondicionDeVenta,1);
			this.FillStaticDataDet(rowCondVtaDet);

			tfi_TDCompTesoreria_CondicionesDeVentaDataset data = mz.erp.dataaccess.tfi_TDCompTesoreria_CondicionesDeVenta.GetList(null,null,IdCondicionDeVenta);
			//_dataTDCompTesoreria_CondVenta = mz.erp.dataaccess.tfi_TDCompTesoreria_CondicionesDeVenta.GetList(null,null,IdCondicionDeVenta);
			this._listaFormasDePagoSeleccionadas.RemoveRange(0,this._listaFormasDePagoSeleccionadas.Count);

			if (data.tfi_TDCompTesoreria_CondicionesDeVenta.Rows.Count != 0)
			{
			tfi_TDCompTesoreria_CondicionesDeVentaDataset.tfi_TDCompTesoreria_CondicionesDeVentaRow rowTDComp = (tfi_TDCompTesoreria_CondicionesDeVentaDataset.tfi_TDCompTesoreria_CondicionesDeVentaRow)data.tfi_TDCompTesoreria_CondicionesDeVenta.Rows[0];
			this.MetodoComparacion = rowTDComp.MetodoDeComparacion;				

			foreach(tfi_TDCompTesoreria_CondicionesDeVentaDataset.tfi_TDCompTesoreria_CondicionesDeVentaRow rowfp in data.tfi_TDCompTesoreria_CondicionesDeVenta.Rows)
			{
				if ((rowfp["idTDCompTesoreria"].ToString() != string.Empty) && (rowfp["idTDCompTesoreria"].ToString() != "NULL"))
				{
					FormaDePago fp = _formasDePago.GetByTDCompTesoreria(rowfp.idTDCompTesoreria);
					this._listaFormasDePagoSeleccionadas.Add(fp);
				}
			}			
			}

			Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset dataTiposComp = mz.erp.dataaccess.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.GetList(null,null,null,IdCondicionDeVenta);
            /* Silvina 20100601 - Tarea 767 */
            if (dataTiposComp.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.Count != 0)
            {
                Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow rowTiposComp = (Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow)dataTiposComp.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.Rows[0];
                this.MetodoDeAsignacionTipoDeComprobante = rowTiposComp.MetodoDeAsignacion;
            }
            /* Fin Silvina */

			this._listaTiposDeComprobantesSeleccionados.RemoveRange(0,this._listaTiposDeComprobantesSeleccionados.Count);

			if (dataTiposComp.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.Rows.Count != 0)
			{
				foreach(Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow rowTDC in dataTiposComp.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.Rows)
				{
					TipoDeComprobante tdc = _tiposDeComprobantes.GetByTDComp(rowTDC.IdTipoDeComprobante);
					if (tdc != null)
					{
						this._listaTiposDeComprobantesSeleccionados.Add(tdc);
					}

				}			
			}

			this._listaCuentas = mz.erp.businessrules.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.GetCuentas(IdCondicionDeVenta);
            /* Silvina 20100601 - Tarea 767 */
            if (_listaCuentas.Count != 0)
                this.MetodoDeAsignacionCuenta = ((Cuenta)_listaCuentas[0]).MetodoDeAsignacion;
            /* Fin Silvina */

			if (_proceso.Equals("ProcesoModificarCondicionDeVentaGeneral"))
			{
				foreach(Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow rowComp in dataTiposComp.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.Rows)
				{
					if (rowComp.MetodoDeAsignacion.Equals("E"))
					{
						MessageBox.Show("Hay comprobantes por exclusión","Advertencia",System.Windows.Forms.MessageBoxButtons.OK);
						break;
					}
				}		
				Cuentas cuentas = _listaCuentas.GetByMetodoAsignacion("E");
				if (cuentas.Count != 0)
				{
					MessageBox.Show("Hay cuentas Excluidas","Advertencia",System.Windows.Forms.MessageBoxButtons.OK);
				}								
			}
		}

		public bool ClienteRepetido(string CodigoCuenta)
		{
			foreach(Cuenta c in this._listaCuentas)
			{
				if(c.Codigo.Equals(CodigoCuenta))
					return true;
			}
			return false;
		}

		public void UpdateCuentas(string CodigoCuenta)
		{
			if(CodigoCuenta != null && CodigoCuenta != string.Empty)
			{
				Cuenta cuenta = new Cuenta();
				cuenta.GetCuenta_CodigoCuenta(CodigoCuenta);
				cuenta.Agregado = true;
				_listaCuentas.Add(cuenta);
			}
		}

		#endregion
	}
}
