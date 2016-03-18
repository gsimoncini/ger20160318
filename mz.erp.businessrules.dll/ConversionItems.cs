using System;
using System.Collections;
using mz.erp.commontypes.CommonInterfaces;
using mz.erp.commontypes;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ConversionItems.
	/// </summary>
	public class ConversionItems : CollectionBase
	{
		public ConversionItems()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}


		public event EventHandler OnConversionChanged;

		public ConversionItems Filter(string unidadOrigen, string unidadDestino)
		{
			ConversionItems items  = new ConversionItems();
			foreach(ConversionItem item in this.List)
			{
				if(unidadOrigen == null)
				{
					if(item.IdUnidadDestino.Equals(unidadDestino))
						items.Add(item);
				}
				else
					if(unidadDestino == null)
					{
						if(item.IdUnidadOrigen.Equals(unidadOrigen))
							items.Add(item);
					}
					else
					{
						if(item.IdUnidadOrigen.Equals(unidadOrigen) && item.IdUnidadDestino.Equals(unidadDestino))
							items.Add(item);
					}
			}

					return items;
			
		}


		#region Override metodos de CollectionBase

		public virtual void Add( ConversionItem item )
		{
			
			if(!this.Contains(item))
			{
				List.Add ( item );
				item.OnConverionChanged +=new EventHandler(item_OnConverionChanged);
			}

		}

		public virtual	int IndexOf(ConversionItem item)
		{
			int index = 0;
			foreach (ConversionItem it in this.List)
			{
				if (!(this.Contains(it) ) )
					index++;
			}
			return index;

		}

		public  bool Contains( ConversionItem item )
		{
			foreach (ConversionItem it in this.List)
			{
				if (it.IdUnidadDestino.Equals(item.IdUnidadDestino)  && it.IdUnidadOrigen.Equals(item.IdUnidadOrigen))
					return true;
			}
			return false;
		}


	

		public virtual void Remove( object item )
		{
			List.Remove( item );
			//if (OnRecalcItems != null )
			//{
			//	this.OnRecalcItems( this, new System.EventArgs() );
			//}
		}


		public virtual void Remove( ConversionItem item )
		{
			Remove( (object)item );
		}

		public ConversionItem Get(int index)
		{
			return (ConversionItem)List[index];
		}


	

		#endregion

		private void item_OnConverionChanged(object sender, EventArgs e)
		{
			if(OnConversionChanged != null)

					OnConversionChanged(sender, e);
		}
	}
}
