using System;
using System.Collections;
using mz.erp.commontypes.data;
using mz.erp.businessrules.comprobantes;
using mz.erp.businessrules;

namespace mz.erp.businessrules.Comprobantes_de_Compra
{
	/// <summary>
	/// Descripción breve de ItemsComprobantesCompra.
	/// </summary>
	public class ItemsComprobantesCompra:CollectionBase
	{
		
		#region Constructores
		public ItemsComprobantesCompra(string action ,ComprobanteDeCompra parent)
		{
			this._parent = parent;
			Init(action, null);
		}

		public ItemsComprobantesCompra(string action, ComprobanteDeCompra parent, RelacionesComprobanteDeCompraOrigenDestino relaciones)
		{
			this._parent = parent;
			Init(action, relaciones);

		}
		#endregion

		#region inicializadores
		
		private void Init( string action, RelacionesComprobanteDeCompraOrigenDestino relaciones)
		{
			switch (action.ToUpper())
			{
				case "NEW":
					break;
				case "EDIT":
					break;
				case "STEP":
					FillStepData( relaciones );
					break;
			}

		}
		#endregion

		#region Step

		private void FillStepData( RelacionesComprobanteDeCompraOrigenDestino relaciones )
		{
			long idSucursal = Security.IdSucursal;
			long idEmpresa = Security.IdEmpresa;
			foreach(RelacionComprobanteDeCompraOrigenDestino relacion in relaciones)
			{	
				if (idSucursal != relacion.IdSucursal)
				{
					idSucursal = relacion.IdSucursal;
					idEmpresa = relacion.IdEmpresa;
				}
				
				if (relacion.CantidadDestino > 0)
				{
					System.Data.DataRow row = (System.Data.DataRow)mz.erp.businessrules.tpu_ComprobantesDet.GetByPk( relacion.IdComprobante, relacion.OrdinalOrigen );

					Productos miProducto = new mz.erp.businessrules.Productos( relacion.IdProducto, relacion.IdSucursal, relacion.IdEmpresa );
				
					ItemComprobanteCompra.ItemCompra item = new ItemComprobanteCompra.ItemCompra();
				
					item.IdProducto = relacion.IdProducto;
					item.Codigo = miProducto.Codigo;
					item.Cantidad = relacion.CantidadDestino;
					

					item.OrdinalOrigen =relacion.OrdinalOrigen;
					item.IdComprobanteOrigen = relacion.IdComprobante;
					item.IdTipoComprobanteOrigen = relacion.IdTipoDeComprobante;
				
					item.OrdinalDestino = this.Count;
				
					item.Descripcion = miProducto.Descripcion;
					item.DescripcionCorta = miProducto.DescripcionCorta;
					item.DescripcionLarga = miProducto.DescripcionLarga;
				
					item.PrecioCosto = (decimal)row["PrecioDeCosto"];
						

					ItemComprobanteCompra miItemComprobante = new ItemComprobanteCompra("STEP",item, this );
					this.Add(miItemComprobante);
				
					
				}
			}
			//this.Parent.IdSucursal = idSucursal;
			//this.Parent.IdEmpresa = idEmpresa;

		}
		#endregion


		

		

		#region Override metodos de CollectionBase

		public virtual void Add( ItemComprobanteCompra item )
		{
			
			if(this.Contains(item))
			{
				ItemComprobanteCompra it = (ItemComprobanteCompra)this.List[this.IndexOf(item)];
				it.Cantidad = it.Cantidad + item.Cantidad;
				//List.Add(it);
			}
			else
			List.Add ( item );
			//this.IsDirty = true;
			//item.OnRecalcItem += new ItemComprobante.RecalcularItem( this.EscuchoRecalculo );
			//item.OnRefreshItem += new ItemComprobante.RefrescarItem( this.EscuchoRefresco );
			//item.Ordinal = List.Count - 1;
			//if ( OnRecalcItems != null )
			//{
			//	this.OnRecalcItems( this, new System.EventArgs() );
			//}
		}

		public virtual	int IndexOf(ItemComprobanteCompra item)
		{
			int index = 0;
			foreach (ItemComprobanteCompra it in this.List)
			{
				if (!it.IdProducto.Equals(item.IdProducto))
							index++;
			}
			return index;

		}

		public  bool Contains( ItemComprobanteCompra item )
		{
			foreach (ItemComprobanteCompra it in this.List)
			{
				if (it.IdProducto.Equals(item.IdProducto))
					return true;
			}
			return false;
		}

		public bool Contains(ItemComprobante item)
		{
			foreach (ItemComprobanteCompra it in this.List)
			{
				if (it.IdProducto.Equals(item.IdProducto))
					return true;
			}
			return false;

		}
	
		/// <summary>
		/// Agrega una nueva instancia del item a la coleccion de items.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="item"></param>
		public virtual void Add( ComprobanteDeCompra sender, ItemComprobanteCompra item )
		{
			this.Parent = sender;
			this.Add(item);
		//	item.OnRecalcItem += new ItemComprobante.RecalcularItem( this.EscuchoRecalculo );
		//	item.OnRefreshItem += new ItemComprobante.RefrescarItem( this.EscuchoRefresco );
		//	if ( OnRecalcItems != null )
		//	{
		//		this.OnRecalcItems( this, new System.EventArgs() );
		//	}
		}
		/// <summary>
		/// Elimina un item de la coleccion
		/// </summary>
		/// <param name="item"></param>
		public virtual void Remove( object item )
		{
			List.Remove( item );
			//if (OnRecalcItems != null )
			//{
			//	this.OnRecalcItems( this, new System.EventArgs() );
			//}
		}

		/// <summary>
		/// Sobrecargado. Elimina un item de la coleccion
		/// </summary>
		/// <param name="item"></param>
		public virtual void Remove( ItemComprobanteCompra item )
		{
			Remove( (object)item );
		}

		#endregion

		#region Commit

		public void Commit()
		{
			foreach (ItemComprobanteCompra item in List)
			{
				item.Commit();
			}
		}

		#endregion



	}
}
