using System;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ConversionItem.
	/// </summary>
	public class ConversionItem
	{
		public ConversionItem()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}


		private string _unidadOrigen;
		private string _unidadDestino;
		private string _idUnidadDestino;
		private string _idUnidadOrigen;
		
		private decimal _valorConversion;
		private decimal _valorConvertido;
		private decimal _valorSinConvertir;
		private string _formula;
		private int _ordinal;

		public event EventHandler OnConverionChanged;
		public event EventHandler ValorConvertidoChanged;

		
		public string Descripcion
		{
			get
			{	
				string result = string.Empty;
				result = result + Convert.ToString(decimal.Round(_valorConversion,2)) + " " + _unidadOrigen;
				result = result + "=";
				result = result +  " 1 " + _unidadDestino;
				return result;


			}



		}
		

		public decimal getValorInverso()
		{
			if(_valorConvertido != 0)
			{
				return _valorConvertido * _valorConversion;

			}
			return 0;

		}




		public decimal ValorSinConvertir
		{
			get{return _valorSinConvertir;}
			set 
			{
				
				_valorSinConvertir = value;
				if(_valorConversion != 0)
				{
						_valorConvertido = value / _valorConversion;
				
					decimal rest = Decimal.Subtract(_valorConvertido, Decimal.Truncate(_valorConvertido));
					if( rest != 0)
					{
					
						long var = Variables.GetValueLong("Productos.MetodoRedondeoConversiones");
						decimal parteEntera = Decimal.Truncate(_valorConvertido);
						switch (var) 
						{
							case  0:
								_valorConvertido = parteEntera;
								break;
							case 1:
								_valorConvertido = parteEntera  +  1;
								break;
							case 2:									
								break;	
							case 4:
								_valorConvertido = value;
								break;
						}
					
					}
				}
				else _valorConvertido = 0;
				ValorConvertido = _valorConvertido;
				if(OnConverionChanged != null)
					OnConverionChanged(this, new EventArgs());
					
			}
		}

		public decimal ValorConvertido
		{
			get {
                return _valorConvertido;}
			set
			{
				_valorConvertido = value;
				if(ValorConvertidoChanged != null)
					ValorConvertidoChanged(this, new EventArgs());
			}
		}

		public string UnidadOrigen
		{
			get{return _unidadOrigen;}
			set{_unidadOrigen = value;}
		}

		public string UnidadDestino
		{
			get {return _unidadDestino;}
			set {_unidadDestino = value;}

		}

		public string IdUnidadOrigen
		{
			get{return _idUnidadOrigen;}
			set{_idUnidadOrigen = value ;}
		}

		public string IdUnidadDestino
		{
			get{return _idUnidadDestino;}
			set{_idUnidadDestino = value ;}
		}

		public decimal ValorConversion
		{
			get {return decimal.Round(_valorConversion,2);}
			set {_valorConversion = decimal.Round(value,2);}
		}

		public string Formula 
		{
			get {return _formula;}
			set {_formula = value;}
		}

		public int Ordinal 
		{
			get {return _ordinal;}
			set {_ordinal = value;}
		}


	}
}
