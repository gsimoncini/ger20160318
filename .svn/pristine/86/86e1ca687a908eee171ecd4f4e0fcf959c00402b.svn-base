using System;
using mz.erp.businessrules.comprobantes;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de FormasDePagoCondicionDeVenta.
	/// </summary>
	public class FormasDePagoCondicionDeVenta //tiene que heredar de ICOllection
	{
		private string _estado;
		private FormasDePagos _formasDePago;
		private tfi_TDCompTesoreria_CondicionesDeVentaDataset _dataTDCompTesoreria_CondVenta = new tfi_TDCompTesoreria_CondicionesDeVentaDataset();


		public FormasDePagoCondicionDeVenta(string IdCondicionDeVenta)
		{
			if (IdCondicionDeVenta == null)
			{
				//creacion de todos los objetos de las clases relacionadas
				//_formasDePago = new FormaDePago();
				_estado= "NEW";
			}
			else 
			{
				//crear todos los ojetos de este id
				_estado ="MODIFY";
			
			}

		}

		#region Propiedades

		private string _idTDCompTesoreria = string.Empty;		
		public string IdTDCompTesoreria
		{
			get { return _idTDCompTesoreria; }
			set
			{
				_idTDCompTesoreria = value;
			}
		}

		private string _metodoDeComparacion = string.Empty;
		public string MetodoDeComparacion
		{
			get	{return _metodoDeComparacion;}
			set
			{
				_metodoDeComparacion = value;
			}
		}

		public tfi_TDCompTesoreria_CondicionesDeVentaDataset DataTDComp_Tesoreria_CondVenta
		{
			get {return _dataTDCompTesoreria_CondVenta;}
		}

		#endregion

		public void Commit()
		{
			if (_estado == "NEW")
			{/*
				tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasRow rowCondVta = _dataCondVenta.tsa_CondicionesDeVentas.Newtsa_CondicionesDeVentasRow();
				
				mz.erp.businessrules.tsa_CondicionesDeVentas.SetRowDefaultValues(rowCondVta);
				
				rowCondVta.Descripcion = this._descripcion;
				rowCondVta.Recargo = this._recargo;
				rowCondVta.Activo = this._activo;
				rowCondVta.MetodoDeAsignacion = this._metodoDeAsignacion;

				*/

				
				tfi_TDCompTesoreria_CondicionesDeVentaDataset.tfi_TDCompTesoreria_CondicionesDeVentaRow rowTDCompTes_ConVta = _dataTDCompTesoreria_CondVenta.tfi_TDCompTesoreria_CondicionesDeVenta.Newtfi_TDCompTesoreria_CondicionesDeVentaRow();	
				mz.erp.businessrules.tfi_TDCompTesoreria_CondicionesDeVenta.SetRowDefaultValues(rowTDCompTes_ConVta);
				rowTDCompTes_ConVta.idTDCompTesoreria = this.IdTDCompTesoreria;
				rowTDCompTes_ConVta.MetodoDeComparacion = this.MetodoDeComparacion;
				
				_dataTDCompTesoreria_CondVenta.tfi_TDCompTesoreria_CondicionesDeVenta.Rows.Add(rowTDCompTes_ConVta);
				_formasDePago.Add(rowTDCompTes_ConVta);
                			
			}
			/*else 
			{  estado = "MODIFY"
				tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasRow row = mz.erp.dataaccess.tsa_CondicionesDeVentas.GetByPk(_idCondicionDeVenta);
			}*/
		}
	}
}
