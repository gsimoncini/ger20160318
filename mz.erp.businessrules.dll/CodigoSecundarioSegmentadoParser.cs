using System;
using System.Collections;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Esta calse tiene como objetivo parsear y administrar codigos secundarios segmentado de los prodcutos.
	/// Un codigo secundario segmentado es un codigo formado por partes con una definicion particular.
	/// Un codigo secundario esta formado de 3 partes: prefijo;IdentificadorProducto;PrecioOCantidad.
	/// El prefijo es fijo y siempre es la primera parte de un codigo secundario segmentado. El orden de las partes
	/// subsiguientes puede varias. 
	/// Dicha clase necesita las siguientes variables:
	///		- Productos.CodigoSecundariSegmentado: determina si se trabaja con cod. sec. seg. en el sistema.
	///		- Productos.CodigoSecundariSegmentado.Prefijo
	///		- Productos.CodigoSecundariSegmentado.Prefijo.Longittud
	///		- Productos.CodigoSecundariSegmentado.IdentificadorPoducto.Longitud
	///		- Productos.CodigoSecundariSegmentado.CantidadOPrecio.Longitud
	///		- Productos.CodigoSecundariSegmentado.Composicion: es un string separados por ; q indica las partes del 
	///		codigo secundario segmentado. Los valores posibles son: 
	///			PREF: indica el prefijo
	///			CANT: indica q el valor almacenado en dicha seccion es la cantidad
	///			PREC: indica q el valor almacenado en dicha seccion es el precio
	///			CODI: indica q el valor almacenado en dicha seccion es el codigo interno
	///			CODS: indica q el valor almacenado en dicha seccion es el codigo secundario
	///			CODP: indica q el valor almacenado en dicha seccion es el codigo proveedor
	/// </summary>
	public class CodigoSecundarioSegmentadoParser
	{
		public CodigoSecundarioSegmentadoParser(string CodigoSecundarioSegmentado)
		{
			_codigoSecundarioSegmentado = CodigoSecundarioSegmentado;
			Init();
			Parser();
		}

		private string _codigoSecundarioSegmentado = string.Empty;
		private bool _isValid = false;
		private int _longitud = -1;
		private int _longitudPrefijo = -1;
		private int _longitudPrecioOCantidad = -1;
		private int _longitudIdentificador = -1;
		private ArrayList _composicion = new ArrayList();
		private bool _habilitaCodigoSecundarioSegmentado = false;
		private string _prefijo = string.Empty;
		private bool _usaPrecio = false;
		private bool _usaCantidad = false;
		private bool _usaCodigo = false;
		private bool _usaCodigoSecundario = false;
		private bool _usaCodigoProveedor = false;
		private decimal _precio = 0;
		private decimal _cantidad = 0;
		private string _codigo = string.Empty;
		private string _codigoSecundario = string.Empty;
		private string _codigoProveedor = string.Empty;
		private bool _conservaCeros = true;
		private decimal _divisorDecimalCantidad = 1;
		private decimal _divisorDecimalPrecio = 1;
		

		public decimal Precio
		{
			get{return _precio;}
		}

		public decimal Cantidad
		{
			get
			{
				return _cantidad;
			}
		}

		public string CodigoSecundarioSegmentado
		{
			get
			{
				return _codigoSecundarioSegmentado;
			}
		}

		public string Codigo
		{
			get
			{
				return _codigo;
			}
		}

		public string CodigoSecundario
		{
			get
			{
				return _codigoSecundario;
			}
		}

		public string CodigoProveedor
		{
			get
			{
				return _codigoProveedor;
			}
		}

		
		public bool IsValid
		{
			get{return _isValid;}
		}

		public bool UsaCantidad
		{
			get
			{
				return _usaCantidad;
			}
		}

		public bool UsaPrecio
		{
			get
			{
				return _usaPrecio;
			}
		}

		public bool UsaCodigo
		{
			get
			{
				return _usaCodigo;
			}
		}
		public bool UsaCodigoSecundario
		{
			get
			{
				return _usaCodigoSecundario;
			}
		}
		public bool UsaCodigoProveedor
		{
			get
			{
				return _usaCodigoProveedor;
			}
		}


		private void Parser()
		{
			if(_isValid)
			{
				int indice = 0;
				foreach(string parte in _composicion)
				{
					switch(parte)
					{
						case "PREF": 
						{
							if(_isValid)
							{
								string pref = _codigoSecundarioSegmentado.Substring(indice, _longitudPrefijo);
								indice = indice + _longitudPrefijo;
								if(!pref.Equals(_prefijo))
									_isValid = false;
							}
						}break;
						case "CANT": 
						{
							if(_isValid)
							{
								_cantidad = Convert.ToInt32(_codigoSecundarioSegmentado.Substring(indice, _longitudPrecioOCantidad))/_divisorDecimalCantidad;
								indice = indice + _longitudPrecioOCantidad;
							}
						}break;
						case "PREC": 
						{
							if(_isValid)
							{
								_precio = Convert.ToDecimal(_codigoSecundarioSegmentado.Substring(indice, _longitudPrecioOCantidad))/_divisorDecimalPrecio;
								indice = indice + _longitudPrecioOCantidad;
							}
						}break;

						case "CODI": 
						{
							if(_isValid)
							{
								
								_codigo = _codigoSecundarioSegmentado.Substring(indice, _longitudIdentificador);
								if(!_conservaCeros)
									_codigo = mz.erp.systemframework.Util.RemoveZerosLeft(_codigo);
								indice = indice + _longitudIdentificador;
							}
							
						}break;
						case "CODS": 
						{
							if(_isValid)
							{
								_codigoSecundario = _codigoSecundarioSegmentado.Substring(indice, _longitudIdentificador);
								if(!_conservaCeros)
									_codigoSecundario = mz.erp.systemframework.Util.RemoveZerosLeft(_codigoSecundario);
								indice = indice + _longitudIdentificador;
							}
						}break;
						case "CODP": 
						{
							if(_isValid)
							{
								_codigoProveedor = _codigoSecundarioSegmentado.Substring(indice, _longitudIdentificador);
								if(!_conservaCeros)
									_codigoProveedor = mz.erp.systemframework.Util.RemoveZerosLeft(_codigoProveedor);
								indice = indice + _longitudIdentificador;
							}
						}break;
					}
				}//For
			}

		}
	
		private void Init()
		{
			_habilitaCodigoSecundarioSegmentado = Variables.GetValueBool("Productos.CodigoSecundarioSegmentado");
			_conservaCeros = Variables.GetValueBool("Productos.CodigoSecundarioSegmentado.CodigoProveedor.ConservaCeros", _conservaCeros);
			_divisorDecimalCantidad = Variables.GetValueDecimal("Productos.CodigoSecundarioSegmentado.Cantidad.DivisorDecimal");
			_divisorDecimalPrecio = Variables.GetValueDecimal("Productos.CodigoSecundarioSegmentado.Precio.DivisorDecimal");
			if(_habilitaCodigoSecundarioSegmentado)
			{
				decimal longi = Variables.GetValueDecimal("Productos.CodigoSecundarioSegmentado.Longitud");
				if(longi.Equals(decimal.MinValue))
					_longitud = -1;
				else
					_longitud = Convert.ToInt32(longi);
				if(_longitud != -1)
				{	
					string comp = Variables.GetValueString("Productos.CodigoSecundarioSegmentado.Composicion");
					_composicion = mz.erp.systemframework.Util.Parse(comp, ";");
					foreach(string parte in _composicion)
					{
						switch(parte)
						{
							case "PREF": 
							{
								decimal longiPref = Variables.GetValueDecimal("Productos.CodigoSecundarioSegmentado.Prefijo.Longitud");
								if(longiPref.Equals(decimal.MinValue))
									_longitudPrefijo = -1;
								else
									_longitudPrefijo = Convert.ToInt32(longiPref);
								_prefijo = Variables.GetValueString("Productos.CodigoSecundarioSegmentado.Prefijo");
							}break;
							case "CANT": 
							{
								decimal longiCant = Variables.GetValueDecimal("Productos.CodigoSecundarioSegmentado.CantidadOPrecio.Longitud");
								if(longiCant.Equals(decimal.MinValue))
									_longitudPrecioOCantidad = -1;
								else
									_longitudPrecioOCantidad = Convert.ToInt32(longiCant);
								_usaCantidad = true;
							}break;
							case "PREC": 
							{
								decimal longiCant = Variables.GetValueDecimal("Productos.CodigoSecundarioSegmentado.CantidadOPrecio.Longitud");
								if(longiCant.Equals(decimal.MinValue))
									_longitudPrecioOCantidad = -1;
								else
									_longitudPrecioOCantidad = Convert.ToInt32(longiCant);
								_usaPrecio = true;
							}break;

							case "CODI": 
							{
								decimal longiID = Variables.GetValueDecimal("Productos.CodigoSecundarioSegmentado.IdentificadorProducto.Longitud");
								if(longiID.Equals(decimal.MinValue))
									_longitudIdentificador = -1;
								else
									_longitudIdentificador = Convert.ToInt32(longiID);
								_usaCodigo = true;
							}break;
							case "CODS": 
							{
								decimal longiID = Variables.GetValueDecimal("Productos.CodigoSecundarioSegmentado.IdentificadorProducto.Longitud");
								if(longiID.Equals(decimal.MinValue))
									_longitudIdentificador = -1;
								else
									_longitudIdentificador = Convert.ToInt32(longiID);
								_usaCodigoSecundario = true;
							}break;
							case "CODP": 
							{
								decimal longiID = Variables.GetValueDecimal("Productos.CodigoSecundarioSegmentado.IdentificadorProducto.Longitud");
								if(longiID.Equals(decimal.MinValue))
									_longitudIdentificador = -1;
								else
									_longitudIdentificador = Convert.ToInt32(longiID);
								_usaCodigoProveedor = true;
							}break;
						}
					}//For
					if((_longitud == (_longitudIdentificador + _longitudPrecioOCantidad + _longitudPrefijo))
						&& (_longitud <= _codigoSecundarioSegmentado.Length))
						_isValid = true;
				}
			}
		}

	}
}
