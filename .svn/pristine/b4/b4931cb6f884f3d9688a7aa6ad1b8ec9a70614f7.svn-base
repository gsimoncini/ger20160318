using System;
using System.Data;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.businessrules.comprobantes;
using mz.erp.businessrules;


namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Esta SuperClase se puede "utilizar" para realizar cualquier consulta con la estructura 
	/// del workflow que requiera el uso de FRMConsultas (Es una clase abstracta!!)
	/// Esta pensada para hacer consultas sobre comprobantes, pero prodria (y debería) extenderse.
	/// </summary>
	/// <example> Un ejemplo de una clase que cuelgue de ella es ListarComprobantesPendientesController</example>
	/// <remarks> Se puede ver en el menú "Entregas / Consultas / Ordenes de Envío" </remarks>
	
	
	public abstract class ConsultasController
	{
		public ConsultasController()
		{
			
		}


		#region variables

		protected ReportFilterArray _filtros;
		protected bool _allowMultipleSelect = false;
		protected bool _allowPrintItem = false;
		protected bool _allowShowDetail = false;
		protected bool _allowFastSearch = true;

		protected string _layoutData;
		protected string _leyendaFormulario;		
		protected bool _visualizaBotonImprimir = false;		
		protected string _tiposComprobantesDestinoExcluidos;
		protected DataTable _table;
		protected ArrayList _arrayComprobantesPendientes = new ArrayList(); 
		protected RelacionesComprobanteOrigenDestino _relacionesComprobanteOrigenDestino;
		
		protected string _groups = string.Empty;
		protected bool _editGroups = false;
		protected bool _totalGroups = false;
		protected bool _gridTotal = false;
		protected string _fieldsTotalGroups = string.Empty;
		protected string _fieldsTotalGrid = string.Empty;
		protected string _idComprobanteFieldName = string.Empty;
		protected string _idTipoDeComprobanteFieldName = string.Empty;
		protected string _showDetailBy = string.Empty;

		protected bool _allowExportarAExcel = false;

        //German 2010105 - Tarea 856
        protected string _orderBy = string.Empty;
        //Fin German 2010105 - Tarea 856

		
		#endregion variables


		#region set y get

        //German 2010105 - Tarea 856
        public string OrderBy
        {
            get { return _orderBy; }
        }
        //Fin German 2010105 - Tarea 856

		public bool AllowExportarAExcel
		{
			get{return _allowExportarAExcel;}
		}

		public string ShowDetailBy
		{
			get{return _showDetailBy;}
		}


		public string IdComprobanteFieldName
		{
			get{return _idComprobanteFieldName;}
		}

		public string IdTipoDeComprobanteFieldName
		{
			get{return _idTipoDeComprobanteFieldName;}
		}

		public bool GridTotal
		{
			get{return _gridTotal;}
		}

		public string FieldsTotalGrid
		{
			get{return _fieldsTotalGrid;}
		}

		public string Groups
		{
			get{return _groups;}
		}

		public string FieldsTotalGroups
		{
			get{return _fieldsTotalGroups;}
		}

		public bool EditGroups
		{
			get{return _editGroups;}
		}

		public bool TotalGroups
		{
			get{return _totalGroups;}
		}




		protected  bool _hasShowSeleccionItems = false;
		public virtual bool HasShowSeleccionItems
		{
			get
			{
				return _hasShowSeleccionItems;
			}
			set
			{	
				_hasShowSeleccionItems = value;
			}
		}
		
		public ReportFilterArray Filtros
		{
			get
			{
				return _filtros;
			}
			set
			{
				_filtros = value;
			}
		}

		public bool AllowMultipleSelect
		{
			get
			{
				return _allowMultipleSelect;
			}
			set
			{
				_allowMultipleSelect = value;
			}
		}
		public bool AllowPrintItem
		{
			get
			{
				return _allowPrintItem;
			}
			set
			{
				_allowPrintItem = value;
			}
		}

		public bool AllowFastSearch
		{
			get
			{
				return _allowFastSearch;
			}
		}

		public bool AllowShowDetail
		{
			get
			{
				return _allowShowDetail;
			}
			set
			{
				_allowShowDetail = value;
			}
		}

		public string LayoutData
		{
			get
			{
				return _layoutData;
			}
		}

		public string LeyendaFormulario
		{
			get { return _leyendaFormulario; }
		}

		public DataTable Table
		{
			get
			{
				return _table;
			}
		}

		public virtual ArrayList ArrayComprobantesPendientes
		{
			set
			{
				this._arrayComprobantesPendientes = value;
			}
			get
			{
				return _arrayComprobantesPendientes;
			}			
		}
		public virtual string TextoBotonSiguiente
		{
			get 
			{				
				return "Siguiente";
			}
		}

		public virtual string TextoBotonAnterior
		{
			get 
			{
				return "Anterior";
			}
		}		
		public bool VisualizaBotonImprimir
		{
			get 
			{
				return _visualizaBotonImprimir;
			}
		}


		#endregion


		public virtual void Execute(){}
		public virtual void Previous(){}
		public virtual void RefreshData(){} 
		public virtual bool IsFirstTask(){return false;}
		public virtual bool IsLastTask(){return false;}
		public virtual bool IsBackState(){return false;}
		public virtual bool IsNextState(){return false;}
		public virtual bool AllowShow(){return false;}
		public virtual bool IsFlushedState(){return false;}
		public virtual void GenerateRelacionOrigenDestino(string IdComprobante){}
		public virtual void SetSelectedItems(ArrayList selectedItems){}
		public virtual bool MustImprimir(){return false;}
        //Cristian Tarea 0000050 20110315
        public virtual DateTime updateFechas(DateTime fechaDesde, bool ordenInverso) { return  new DateTime();}
        //Fin Cristian

		
		public virtual RelacionesComprobanteOrigenDestino RelacionesComprobantesOrigenDestino
		{		
			get
			{
				return _relacionesComprobanteOrigenDestino;
			}
			set
			{
				_relacionesComprobanteOrigenDestino = value;
			}
		}
		public virtual string FamiliaComprobantes
		{
			get
			{
				return "";
			}
			set
			{
				string x = value;
			}
		}
	}
}
