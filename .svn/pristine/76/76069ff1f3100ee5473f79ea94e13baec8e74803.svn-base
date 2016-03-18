using System;
using System.Collections;
using mz.erp.businessrules.comprobantes;
using mz.erp.businessrules;
using mz.erp.ui.forms;
using System.Reflection;
using System.Windows.Forms;

/*using System.Collections.Specialized;

using mz.erp.commontypes.data;
using mz.erp.commontypes;*/


namespace mz.erp.ui.forms.classes
{
	/// <summary>
	/// Descripción breve de RelacionComprobanteOrigenDestino.
	/// </summary>
	public class RelacionComprobanteOrigenDestino
	{
		private string _idComprobanteOrigen;
		private string _idTipoDeComprobanteOrigen;
		private string _momentoStepDefault = null;

		private Form _formOwner;

		public Form FormOwner
		{
			set
			{
				_formOwner = value;
			}
		}

		public string MomentoStepDefault
		{
			set
			{
				_momentoStepDefault = value;
			}
		}

		public RelacionComprobanteOrigenDestino()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public RelacionComprobanteOrigenDestino(string IdComprobanteOrigen, string IdTipoDeComprobanteOrigen)
		{
			_idComprobanteOrigen = IdComprobanteOrigen;
			_idTipoDeComprobanteOrigen = IdTipoDeComprobanteOrigen;
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public void Step() 
		{
			RelacionesComprobanteOrigenDestino items;					
			ArrayList IdComprobantes = new ArrayList();					
			IdComprobantes.Add(_idComprobanteOrigen);
			items = new RelacionesComprobanteOrigenDestino( IdComprobantes);
			string MomentoDestino = "";
			if(_momentoStepDefault == null)
			{
				string MomentoOrigen = businessrules.tsy_TiposDeComprobantes.GetByPk(_idTipoDeComprobanteOrigen).Momento;				
				MomentoDestino = Variables.GetValueString("Momentos." + MomentoOrigen + ".Step.Default");			
			}
			else MomentoDestino = _momentoStepDefault;
			if (MomentoDestino != "")
			{
				FrmComprobantes frmComprobantes = new FrmComprobantes();
				if(_formOwner != null)
				{
					EventInfo ei =frmComprobantes.GetType().GetEvent("OnCommitComprobante");
					Delegate del1 = Delegate.CreateDelegate( ei.EventHandlerType, this._formOwner, "processEventChange" );
					ei.AddEventHandler(frmComprobantes, del1);
				}	
				frmComprobantes.Step(MomentoDestino, items);								
			}				
			
		}

		public RelacionesComprobanteOrigenDestino GetRelaciones()
		{
			RelacionesComprobanteOrigenDestino items;					
			ArrayList IdComprobantes = new ArrayList();					
			IdComprobantes.Add(_idComprobanteOrigen);
			items = new RelacionesComprobanteOrigenDestino( IdComprobantes);
			return items;
		}

	
	}
}
