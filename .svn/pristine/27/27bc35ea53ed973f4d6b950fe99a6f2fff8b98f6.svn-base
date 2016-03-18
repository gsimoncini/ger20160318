using System;
using mz.erp.businessrules;
using System.Collections;
using mz.erp.commontypes;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de CuentaCorrienteController.
	/// </summary>
	public class CuentaCorrienteController
	{
		#region Variables privadas
		private CuentaCorrienteWF _brClass = new CuentaCorrienteWF();
		private ImputarPagoCuentaCorriente _imputarPagoCtaCte;
		
		#endregion

		public CuentaCorrienteController()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//			
			//Init();
		}
		#region Propiedades		
		/*public string Entidad
		{
			get {return _brClass.Entidad ;}
			set {_brClass.Entidad = value;}
		}*/
		/*public string Id
		{
			get {return _brClass.Id ;}
			set {_brClass.Id = value;}
		}*/

		public string NombreEntidad
		{
			get{return _brClass.NombreEntidad;}
		}


		public string Codigo
		{
			get {return _brClass.Codigo ;}
			set {_brClass.Codigo = value;}
		}
		public DateTime FechaDesde
		{
			get {return _brClass.FechaDesde ;}
			set {_brClass.FechaDesde = value;}
		}
		public DateTime FechaHasta
		{
			get {return _brClass.FechaHasta ;}
			set {_brClass.FechaHasta = value;}
		}
        //German 20120416 - Tarea 0000247
        public bool SoloAcopios
        {
            get { return _brClass.SoloAcopios; }
            set { _brClass.SoloAcopios = value; }
        }
        //German 20120416 - Tarea 0000247
		public bool SoloPendientes
		{
			get {return _brClass.SoloPendientes ;}
			set {_brClass.SoloPendientes = value;}
		}		
		public string Comprobantes
		{
			get {return _brClass.Comprobantes ;}
			set {_brClass.Comprobantes = value;}
		}		
		public string OrderBy
		{
			get {return _brClass.OrderBy ;}
			set {_brClass.OrderBy = value;}
		}
		public string FilterBy
		{
			get {return _brClass.FilterBy ;}
			set {_brClass.FilterBy = value;}
		}		
		public string LeyendaFormulario
		{
			get {return _brClass.LeyendaFormulario ;}			
		}
		
		public Type ProveedoresSearchObject 
		{
			get 
			{
				return typeof(mz.erp.ui.controllers.tpu_Proveedores);
			}
		}		
		public bool GetDataFromDB
		{
			get {return _brClass.GetDataFromDB; }
			set {_brClass.GetDataFromDB = value; }
		}

        //German 20120222 -  Tarea 0000247
        public decimal SaldoRemitosSinFacturar
        {
            get { return _brClass.SaldoRemitosSinFacturar; }
        }

        public decimal SaldoAcopios
        {
            get { return _brClass.SaldoAcopios; }
        }

        public bool VisualizaSaldoRemitos
        {
            get { return _brClass.VisualizaSaldoRemitos; }

        }
       

        public bool VisualizaSaldoAcopios
        {
            get { return _brClass.VisualizaSaldoAcopios; }

        }

        //Fin German 20120222 -  Tarea 0000247

		public decimal SaldoAnterior
		{
			get {return _brClass.SaldoAnterior; }			
		}		
		public decimal SaldoPosterior
		{
			get {return _brClass.SaldoPosterior; }			
		}		
		public string ProcessName
		{
			get {return _brClass.ProcessName;}			
			set {_brClass.ProcessName = value;}
		}
		public string TaskName
		{
			get {return _brClass.TaskName;}			
		}			

		public string FiltroFechaDefault
		{
			get {return _brClass.FiltroFechaDefault;}
		}	
		public string FiltroComprobantesDefault
		{
			get {return _brClass.FiltroComprobantesDefault;}
		}	
		public string OrdenacionDefault
		{
			get {return _brClass.OrdenacionDefault;}
		}	
		public string ColorPositivo
		{
			get {return _brClass.ColorPositivo;}
		}	
		public string ColorNegativo
		{
			get {return _brClass.ColorNegativo;}
		}	

		public ArrayList Result
		{
			get { return _brClass.Result ; }
		}

		private ItemsDatasetErrors _errors;
		public ItemsDatasetErrors Errors
		{
			get {return _errors;}
		}

		public string IdCuenta
		{
			get {return _brClass.IdCuenta;}
		}

		public CuentaCorriente CuentaCorriente
		{
			get {return _brClass.CuentaCorriente;}
		}

		#endregion
		#region Métodos privados
		public void Init()
		{
			_brClass.DataSearchChanged+=new EventHandler(_brClass_DataSearchChanged);			
			_brClass.Init();
		}
		#endregion



		#region Métodos públicos
		public void BuscarAhora()
		{
			_errors = _brClass.GetErrors();
			if (_brClass.IsValid())
				_brClass.BuscarAhora();
			else
				if (_errors.Count > 0)
				{
					if(OnErrors != null)
						OnErrors( this, new System.EventArgs() );
				}
		}

		public bool DesimputarCliente(ItemCuentaCorriente icc)		
		{
			return _brClass.DesimputarCliente(icc);
		}
		
		public bool DesimputarProveedor(ItemCuentaCorriente icc)		
		{
			return _brClass.DesimputarProveedor(icc);
		}

		public void FlushDesimputarCliente(ItemCuentaCorriente icc)		
		{
            _brClass.FlushDesimputarCliente(icc);
		}
		
		public void FlushDesimputarProveedor(ItemCuentaCorriente icc)		
		{
            _brClass.FlushDesimputarProveedor(icc);
		}
        //Cristian Tsrea 0000050 20110310
        public void updateFechas(DateTime fechaDesde, bool ordenInverso)
        {
            this._brClass.updateFechas(fechaDesde, ordenInverso);

        }
        //Fin Cristian


		#endregion
		#region Eventos
		public event EventHandler DataSearchChanged;	
		public event EventHandler OnErrors;
		#endregion

		private void _brClass_DataSearchChanged(object sender, EventArgs e)
		{
			if (DataSearchChanged != null)
			{
				DataSearchChanged( this, new System.EventArgs() );
			}
		}
		
	}
}
