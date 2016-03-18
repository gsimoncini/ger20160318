using System;
using System.Data;
using System.Text;
using System.Collections;

using mz.erp.businessrules;


namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de PorcentajeAdicionalMedidaSugeridoController.
	/// </summary>
	public class PorcentajeAdicionalMedidaSugeridoController
	{
		
		private Conversion _conversion;
		private ConversionItem _itemAux;
		string[] _fieldList = null;
		public string[] FieldList
		{
			set
			{
				_fieldList =value;
			}
		}

		public string LayoutData
		{
			get
			{
				return this.GetLayoutData();
			}
		}

		public ArrayList DataSource
		{
			get
			{
				return this.GetDataSource();
			}
		}
	

		public PorcentajeAdicionalMedidaSugeridoController(Conversion conversion)
		{
			_conversion = conversion;
			ConversionItem item = _conversion.Items.Get(0);
			_itemAux = new ConversionItem();
			//_itemAux.Descripcion = item.Descripcion;
			_itemAux.Formula = item.Formula;
			_itemAux.IdUnidadDestino = item.IdUnidadDestino;
			_itemAux.IdUnidadOrigen = item.IdUnidadOrigen;
			_itemAux.UnidadDestino = item.UnidadDestino;
			_itemAux.UnidadOrigen = item.UnidadOrigen;
			_itemAux.ValorConversion = item.ValorConversion;
			_itemAux.ValorSinConvertir = item.ValorSinConvertir;
		}

		public void Aceptar()
		{
			ConversionItem item = _conversion.Items.Get(0);								
			item.ValorSinConvertir = _itemAux.ValorSinConvertir;
		}

		public bool  IsValid()
		{
			return true;
		}



		public void Cancelar()
		{
			
		}

		public void SelectionChange(object porcentajeSugeridoItem)
		{
			PorcentajeSugeridoItem	psi = (PorcentajeSugeridoItem) porcentajeSugeridoItem;
			_itemAux.ValorSinConvertir = psi.CantidadOrigen;
		}

		private string GetLayoutData()
		{
		
				ArrayList fl = new ArrayList();
				if (_fieldList != null )
				{
					fl.AddRange( _fieldList );
				}
				int i = 0;
				StringBuilder sb = new StringBuilder();
				sb.Append( LayoutBuilder.GetHeader() );			
			
				if ( fl.Contains( "Porcentaje" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Porcentaje", "%", 30 ) );
				if ( fl.Contains( "IncrementoOrigen" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IncrementoOrigen", "Inc en " +this._conversion.Items.Get(0).UnidadOrigen  ,75 ,Types.Aligment.Far) );
				if ( fl.Contains( "IncrementoDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IncrementoDestino", "IncrementoDestino", true ) );
				if ( fl.Contains( "CantidadOrigen" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CantidadOrigen", this._conversion.Items.Get(0).UnidadOrigen,60,Types.Aligment.Far ) );
				if ( fl.Contains( "CantidadDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CantidadDestino", this._conversion.Items.Get(0).UnidadDestino,60 ,Types.Aligment.Far) );
			
				sb.Append( LayoutBuilder.GetFooter() );

				return sb.ToString();

			

		}

		private ArrayList GetDataSource()
		{
			if(_conversion != null)
			{
				ArrayList result = new ArrayList();
				//string aux = Variables.GetValueString("Prodcutos.Medidas.PorcentajesSugeridos");
				ArrayList lista = mz.erp.systemframework.Util.Parse("0,10,15,20,25",",");
				
				
				ConversionItem item = _conversion.Items.Get(0);
				foreach(string procentaje in lista)
				{	
					
					PorcentajeSugeridoItem psi = new PorcentajeSugeridoItem();
					psi.Porcentaje = Convert.ToDecimal(procentaje);
					psi.IncrementoOrigen = item.ValorSinConvertir*psi.Porcentaje/100;
					psi.CantidadOrigen = item.ValorSinConvertir + psi.IncrementoOrigen;
					_itemAux.ValorSinConvertir = psi.CantidadOrigen;
					psi.CantidadDestino = _itemAux.ValorConvertido;
					result.Add(psi);


					
				}


				return result;
			}
			else
				return new ArrayList();
		}

		

	}


	public class PorcentajeSugeridoItem
	{
		public PorcentajeSugeridoItem()
		{
		}

		private decimal _porcentaje;
		private decimal _incrementoOrigen;
		private decimal _incrementoDestino;
		private decimal _cantidadOrigen;
		private decimal _cantidadDestino;

		public decimal Porcentaje
		{
			get
			{
				return _porcentaje;
			}
			set
			{
				_porcentaje = value;
			}
		}

		public decimal IncrementoOrigen
		{
			get
			{
				return _incrementoOrigen;
			}
			set
			{
				_incrementoOrigen = value;
			}
		}

		public decimal IncrementoDestino
		{
			get
			{
				return _incrementoDestino;
			}
			set
			{
				_incrementoDestino = value;
			}
			
		}
		public decimal CantidadDestino
		{
			get
			{
				return _cantidadDestino;
			}
			set
			{	
				_cantidadDestino = value;
			}
		}

		public decimal CantidadOrigen
		{
			get
			{
				return _cantidadOrigen;
			}
			set
			{
				_cantidadOrigen = value;
			}

		}

		


	}
}
