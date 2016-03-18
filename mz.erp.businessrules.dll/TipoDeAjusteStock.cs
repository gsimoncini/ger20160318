using System;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de TipoDeAjusteStock.
	/// </summary>
	public class TipoDeAjusteStock
	{
		public TipoDeAjusteStock()
		{
			_estado= "NEW";
		}

		private string _estado = string.Empty;
		private string _idTipoAjusteStock = string.Empty;
		private string _idEstadoDeStock = string.Empty;
		private string _descripcion = string.Empty;
		private short _operacion = 0;
		private bool _activo = true;
		private bool _afectaSeguimientoArticulosFisico = false;
		private bool _sistema = false;

		private tlg_TiposDeAjusteDataset _dataTiposAjuste = new mz.erp.commontypes.data.tlg_TiposDeAjusteDataset();

		#region Propiedades

		public string IdTipoAjusteStock
		{
			get{return _idTipoAjusteStock;}
			set 
			{
				GetTipoAjuste(value);
				_idTipoAjusteStock = value;
			}
		}

		public string IdEstadoDeStock
		{
			get{return _idEstadoDeStock;}
			set 
			{
				_idEstadoDeStock = value;
			}
		}

		public string Descripcion
		{
			get{return _descripcion;}
			set 
			{
				_descripcion = value;
			}
		}

		public short Operacion
		{
			get {return _operacion;}
			set
			{
				_operacion = value;
			}
		}

		public bool Sistema
		{
			get{return _sistema;}
			set 
			{
				_sistema = value;
			}
		}

		public bool Activo
		{
			get{return _activo;}
			set 
			{
				_activo = value;
			}
		}

		public bool AfectaSeguimientoArticulosFisico
		{
			get{return _afectaSeguimientoArticulosFisico;}
			set 
			{
				_afectaSeguimientoArticulosFisico = value;
			}
		}

		public tlg_TiposDeAjusteDataset DataTiposAjuste
		{
			get { return _dataTiposAjuste;}
		}

		#endregion

		public void Commit()
		{
			if (_estado == "NEW")
			{
				#region NEW

				tlg_TiposDeAjusteDataset.tlg_TiposDeAjusteRow row = _dataTiposAjuste.tlg_TiposDeAjuste.Newtlg_TiposDeAjusteRow();
				tlg_TiposDeAjuste.SetRowDefaultValues(row);

				//row.IdTipoAjuste
				row.IdEstadoDeStock = _idEstadoDeStock;
				row.Descripcion = _descripcion;
				row.Sistema = _sistema;
				row.Activo = _activo;
				row.Operacion = _operacion;
				row.AfectaSeguimientoDeArticulosFisico = _afectaSeguimientoArticulosFisico;

				_dataTiposAjuste.tlg_TiposDeAjuste.Rows.Add(row);

				#endregion
			}
			else 
			{ 
				#region MODIFY

				tlg_TiposDeAjusteDataset.tlg_TiposDeAjusteRow row = tlg_TiposDeAjuste.GetByPk(_idTipoAjusteStock);

				row.IdEstadoDeStock = _idEstadoDeStock;
				row.Descripcion = _descripcion;
				row.Sistema = _sistema;
				row.Activo = _activo;
				row.Operacion = _operacion;
				row.AfectaSeguimientoDeArticulosFisico = _afectaSeguimientoArticulosFisico;

				_dataTiposAjuste.tlg_TiposDeAjuste.ImportRow(row);

				#endregion
			}
		}

		public void GetTipoAjuste(string IdTipoAjuste) 
		{
			_estado = "MODIFY";

			tlg_TiposDeAjusteDataset.tlg_TiposDeAjusteRow row = tlg_TiposDeAjuste.GetByPk(IdTipoAjuste);

			if (row !=null)
			{
				Activo = row.Activo;
				Descripcion = row.Descripcion;
				IdEstadoDeStock = row.IdEstadoDeStock;
				Operacion = row.Operacion;
				Sistema = row.Sistema;
				AfectaSeguimientoArticulosFisico = row.AfectaSeguimientoDeArticulosFisico;
			}
		}

	}
}
