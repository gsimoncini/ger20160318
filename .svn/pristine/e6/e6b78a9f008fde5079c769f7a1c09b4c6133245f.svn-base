using System;
using System.Collections;
using System.Collections.Specialized;
using mz.erp.businessrules;
using mz.erp.commontypes.data;
using mz.erp.commontypes;


namespace mz.erp.businessrules.Comprobantes_de_Compra
{
	/// <summary>
	/// Descripción breve de RelacionComprobanteOrigenDestino.
	/// </summary>
	public class RelacionesComprobanteDeCompraOrigenDestino:System.Collections.CollectionBase
	{
		public RelacionesComprobanteDeCompraOrigenDestino(ArrayList IdComprobantes)
		{			
			string IdTipoDeComprobanteGral = String.Empty;

			ArrayList lista = new ArrayList(IdComprobantes);			
			for (int i = 0; i < lista.Count; i++) 
			{
				string IdComprobante = lista[i].ToString();
				tpu_ComprobantesDataset.tpu_ComprobantesRow CompOrigen = tpu_Comprobantes.GetByPk(IdComprobante);				

				//Datos comunes a todos los items de un mismo comprobante
				string IdTipoDeComprobante = CompOrigen.IdTipoDeComprobante;
				string Numero = CompOrigen.Numero;
				long OrdinalOrigen = -1;
				decimal CantidadOrigen = 0;
				string IdProducto = String.Empty;
				string Descripcion = String.Empty;
				long IdSucursal = Security.IdSucursal;
				long IdEmpresa = Security.IdEmpresa;
				DateTime Fecha = CompOrigen.Fecha;
				Decimal PrecioDeCosto = 0;
				this.IdProveedor= CompOrigen.IdProveedor;
				this.IdResponsable = CompOrigen.IdResponsable;

				if (IdTipoDeComprobanteGral == String.Empty) 
				{
					IdTipoDeComprobanteGral = IdTipoDeComprobante;
				}

				//Si el tipo de Comprobante actual es distinto al tipo de comprobante del primer comprobante no hace nada (por ahora)
				if (IdTipoDeComprobante == IdTipoDeComprobanteGral) 
				{
					//Para cada IdComprobante tengo que obtener los ítems
					//Datos del item del comprobante				
					tpu_ComprobantesDetDataset Items = businessrules.tpu_ComprobantesDet.GetByPk(IdComprobante);

					foreach (tpu_ComprobantesDetDataset.tpu_ComprobantesDetRow row in Items.tpu_ComprobantesDet )
					{
						OrdinalOrigen = row.Ordinal;
						CantidadOrigen = row.Cantidad; 
						
						//Por ahora estoy tomando en CantidadOrigen la cantidad original del item. Luego tengo que hacer aparecer lo que está en tsa_ComprobantesRelacionOrigenDestino
						IdProducto = row.IdProducto;
						Descripcion = tsh_Productos.GetByPk(row.IdProducto).Descripcion;
						PrecioDeCosto = row.PrecioDeCosto;
						IdSucursal = row.IdSucursal;
						IdEmpresa = row.IdEmpresa;
						RelacionComprobanteDeCompraOrigenDestino ItemOrigen = new RelacionComprobanteDeCompraOrigenDestino(IdComprobante, IdTipoDeComprobante, Numero, OrdinalOrigen, CantidadOrigen, IdProducto, Descripcion, PrecioDeCosto, IdSucursal, IdEmpresa);
						this.Add(ItemOrigen);
					}
				}				
			}
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		
		public virtual void Add( RelacionComprobanteDeCompraOrigenDestino rcod )
		{				
			List.Add ( rcod );			
		}
		
		public RelacionComprobanteDeCompraOrigenDestino Get(int index)
		{
			return (RelacionComprobanteDeCompraOrigenDestino) List[index];
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
			foreach( RelacionComprobanteDeCompraOrigenDestino detalle in this.List )
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
			foreach( RelacionComprobanteDeCompraOrigenDestino detalle in this.List )
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
		private string _idProveedor = string.Empty;
		public string IdProveedor
		{
			set 
			{
				_idProveedor = value;
			}
			get
			{
				return _idProveedor;
			}
		}

	}

	/// <summary>
	/// Descripción breve de RelacionComprobanteOrigenDestino.
	/// </summary>
	/// 
	public class RelacionComprobanteDeCompraOrigenDestino
	{
		private long _ordinalOrigen;
		public long OrdinalOrigen 
		{
			get 
			{
				return _ordinalOrigen;
			}
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
				if (value <= _cantidadOrigen)
				{
					_cantidadDestino = value;
				}
				else 
				{
					_cantidadDestino = 0;
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
		private decimal _precioDeCosto;
		public decimal PrecioDeCosto 
		{
			get 
			{
				return _precioDeCosto;
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
		private long _idSucursal=0;
		public long IdSucursal
		{
			get
			{
				return _idSucursal;
			}
		}
		private long _idEmpresa = 0;
		public long IdEmpresa
		{
			get
			{
				return _idEmpresa;
			}
		}

		public RelacionComprobanteDeCompraOrigenDestino(string IdComprobante, string IdTipoDeComprobante, string Numero, long OrdinalOrigen, decimal CantidadOrigen, string IdProducto, string Descripcion, decimal PrecioDeCosto, long IdSucursal, long IdEmpresa)
		{
			_idComprobante = IdComprobante;
			_idTipoDeComprobante = IdTipoDeComprobante;
			_numero = Numero;			
			_ordinalOrigen = OrdinalOrigen;
			_cantidadOrigen = CantidadOrigen;
			_cantidadDestino = CantidadOrigen;
			_idProducto = IdProducto;
			_descripcion = Descripcion;
			_precioDeCosto = PrecioDeCosto;
			_idSucursal = IdSucursal;
			_idEmpresa = IdEmpresa;
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

	}
}

	

