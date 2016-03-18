using System;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de Proveedor.
	/// </summary>
	public class Proveedor
	{
		#region Constructores
		
		public Proveedor()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public Proveedor(string IdProveedor)
		{
			_idProveedor = IdProveedor;
			Init();
		}
		#endregion
		#region Propiedades públicas

		private string _idProveedor = string.Empty;
		public string IdProveedor
		{
			get { return _idProveedor; }
			/*set
			{
				_idProveedor = value;
			}*/
		}


		private string _telefonos = string.Empty;
		public string Telefonos
		{
			get { return _telefonos; }
			/*set
			{
				_telefonos = value;
			}*/
		}


		private string _codigo = string.Empty;
		public string Codigo
		{
			get { return _codigo; }
			/*set
			{
				_codigo = value;
			}*/
		}

		private string _nombre = string.Empty;
		public string Nombre
		{
			get { return _nombre; }
			/*set
			{
				_nombre = value;
			}*/
		}

		private string _domicilio = string.Empty;
		public string Domicilio
		{
			get { return _domicilio; }
			/*set
			{
				_domicilio = value;
			}*/
		}

		private string _tipoDocumento = string.Empty;
		public string TipoDocumento
		{
			get { return _tipoDocumento; }
			/*set
			{
				_tipoDocumento = value;
			}*/
		}

		private string _documento = string.Empty;
		public string Documento
		{
			get { return _documento; }
			/*set
			{
				_documento = value;
			}*/
		}
		private string _categoriaImpositiva = String.Empty;
		public string CategoriaImpositiva
		{
			get { return _categoriaImpositiva; }
			//set {_documento = value; }
		}	
		private bool _excluyeRetencionIIBB = false;
		public bool ExcluyeRetencionIIBB
		{
			get{return _excluyeRetencionIIBB;}
			set{_excluyeRetencionIIBB = value;}
		}
		private string _campoAuxiliar1 = String.Empty;
		public string CampoAuxiliar1
		{
			get { return _campoAuxiliar1; }
		}	

		private string _campoAuxiliar2 = String.Empty;
		public string CampoAuxiliar2
		{
			get { return _campoAuxiliar2; }
		}	
		
		private string _campoAuxiliar3 = String.Empty;
		public string CampoAuxiliar3
		{
			get { return _campoAuxiliar3; }
		}	
		private string _campoAuxiliar4 = String.Empty;
		public string CampoAuxiliar4
		{
			get { return _campoAuxiliar4; }
		}	

		private decimal _campoAuxiliar5;
		public decimal CampoAuxiliar5
		{
			get { return _campoAuxiliar5; }
		}	
		

		#endregion
		#region Métodos privados
		private void Init() 
		{
			this.GetProveedor_IdProveedor(_idProveedor);
		}
		private void FillStaticData(tpu_ProveedoresDataset.tpu_ProveedoresRow row) 
		{			 
			if (row !=null)
			{
				this._idProveedor = row.IdProveedor;
				this._codigo = row.Codigo;
				this._nombre = row.Nombre;
				this._domicilio = row.Domicilio;
				this._tipoDocumento = row.idTipoDocumento;
				this._documento = row.Numero;
				this._telefonos = row.Telefonos;
				this._categoriaImpositiva = row.IdCategoriaIva;
				this._excluyeRetencionIIBB = row.ExcluyeRetencionIIBB;
				this._campoAuxiliar1 = row.CampoAuxiliar1;
				this._campoAuxiliar2 = row.CampoAuxiliar2;
				this._campoAuxiliar3 = row.CampoAuxiliar3;
				this._campoAuxiliar4 = row.CampoAuxiliar4;
				this._campoAuxiliar5 = row.CampoAuxiliar5;

			}
		}
		#endregion
		#region Métodos públicos
		public void GetProveedor_IdProveedor(string IdProveedor) 
		{
            /* Silvina 20100730 - Tarea 801 */
            tpu_ProveedoresDataset.tpu_ProveedoresRow row = mz.erp.businessrules.tpu_Proveedores.GetByPk(IdProveedor);
            /* Fin Silvina */
			this.FillStaticData(row);

		}
		public void GetCuenta_CodigoProveedor(string Codigo)
		{			
			tpu_ProveedoresDataset.tpu_ProveedoresRow row = mz.erp.businessrules.tpu_Proveedores.GetByCodigo(Codigo);
			this.FillStaticData(row);
		}


		

		#endregion
		
	}
}
