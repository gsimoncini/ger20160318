using System;

using mz.erp.commontypes.data;
using mz.erp.commontypes;
using System.Data;
using System.Collections;


namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Descripción breve de ComprobantesDetalleDePagos.
	/// </summary>
	public class ComprobantesDetalleDePagos:DataObject
	{
		public ComprobantesDetalleDePagos()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		private ComprobanteDePago _parent;
		private Hashtable _tablaDeValoresFormasDePago = new Hashtable();

		public Hashtable TablaDeValoresFormasDePago
		{
			get
			{
				return _tablaDeValoresFormasDePago;
			}
			set
			{
				_tablaDeValoresFormasDePago = value;
			}
		}



		public ComprobanteDePago Parent
		{
			get{return _parent;}
			set {_parent = value;}
		

		}

		private bool _creaIdValoresNuevos = true;
		public bool CreaIdValoresNuevos
		{
			get{return _creaIdValoresNuevos;}
			set{_creaIdValoresNuevos = value;}
		}

		public override void Commit()
		{
			ComprobanteDePago cdp = this.Parent;
			tsa_ComprobantesExDataset data = cdp.DatasetComprobante;
			Valores Valores = cdp.Valores;
			tsa_ComprobantesExDataset.tfi_ValoresDataTable TablaValores = data.tfi_Valores;
			tsa_ComprobantesExDataset.tsa_ComprobantesDataTable TablaComprobantes = data.tsa_Comprobantes;
			string comprobantesdePago = Variables.GetValueString("Comprobantes.ComprobantesDePago");
			ArrayList comps = mz.erp.systemframework.Util.Parse(comprobantesdePago,",");	
			tsa_ComprobantesExDataset.tsa_ComprobantesRow rowComprobante = null;
			foreach(System.Data.DataRow row in TablaComprobantes.Rows)
			{
				if(comps.Contains(Convert.ToString(row["IdTipoDeComprobante"])))
				{
					rowComprobante = (tsa_ComprobantesExDataset.tsa_ComprobantesRow) row;		
				}
			}
			
			
			/*
			int i = 0;
			
			foreach(tsa_ComprobantesExDataset.tfi_ValoresRow row in TablaValores.Rows)
			{
				tsa_ComprobantesExDataset.tsa_ComprobanteDetalleDePagosRow rowPagos= data.tsa_ComprobanteDetalleDePagos.Newtsa_ComprobanteDetalleDePagosRow();
				if (i < Valores.MisValores.Count) 
				{
					Valor valor = (Valor)Valores.MisValores[i];
					i++;
					valor.SetRowValues(rowPagos, row ,rowComprobante, _tablaDeValoresFormasDePago);
					data.tsa_ComprobanteDetalleDePagos.Addtsa_ComprobanteDetalleDePagosRow(rowPagos);
				}
			}
			*/
			/*
			foreach(Valor valor in Valores.MisValores)
			{
			*/
			for (int i = 1; i <= Valores.MisValores.Count; i++)  
			{				
				if(Valores.MisValores[i-1] != null)
				{
					Valor valor = (Valor) Valores.MisValores[i-1];
					//if((_creaIdValoresNuevos)|| (!_creaIdValoresNuevos && (!valor.IsStep || valor.Agrupado)))
					if( valor.Agrupado || valor.State.ToUpper().Equals("NEW"))
					{
						tsa_ComprobantesExDataset.tfi_ValoresRow row = data.tfi_Valores.FindByIdValor(valor.IdValor);
						tsa_ComprobantesExDataset.tsa_ComprobanteDetalleDePagosRow rowPagos= data.tsa_ComprobanteDetalleDePagos.Newtsa_ComprobanteDetalleDePagosRow();
						 valor.SetRowValues(rowPagos, valor.IdValor ,rowComprobante, _tablaDeValoresFormasDePago);
						data.tsa_ComprobanteDetalleDePagos.Addtsa_ComprobanteDetalleDePagosRow(rowPagos);
					}
					else
					{
						//DataRow row  = mz.erp.businessrules.tfi_Valores.GetByPk(valor.IdValor);
						//if(row != null)
						//{
						//	data.tfi_Valores.LoadDataRow(row.ItemArray,true);
							tsa_ComprobantesExDataset.tsa_ComprobanteDetalleDePagosRow rowPagos= data.tsa_ComprobanteDetalleDePagos.Newtsa_ComprobanteDetalleDePagosRow();
							valor.SetRowValues(rowPagos, valor.IdValor ,rowComprobante, _tablaDeValoresFormasDePago);
							data.tsa_ComprobanteDetalleDePagos.Addtsa_ComprobanteDetalleDePagosRow(rowPagos);
						//}
					}
				}
			}
				

				

			//}	

		}


		

	}
}
