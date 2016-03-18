using System;
using System.Collections;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Contiene una coleccion de Impuesto. Se asocia a cada item
	/// </summary>
	public class Impuestos	: System.Collections.CollectionBase
	{
		/// <summary>
		/// Obtiene una nueva instancia de la clase impuestos para ser utilizada no asociada directamente a un item.
		/// </summary>
		public Impuestos()
		{
		}
		/// <summary>
		/// Obtiene una nueva instancia de impuesto
		/// </summary>
		/// <param name="action">Valores NEW or EDIT</param>
		/// <param name="itemComprobante"></param>
		/// 
		
		public Impuestos( string action, ItemComprobante itemComprobante )
		{
			_itemComprobante = itemComprobante;
			Init(action);
		}
		
		
		private void Init( string action )
		{
			switch (action.ToUpper())
			{
				case "NEW":
					FillNewData();
					break;
				case "EDIT":
					FillEditData();
					break;
			}
		}

		private void FillStaticData()
		{

		}
		private void FillNewData()
		{
			string IdCuenta = this.ItemComprobante.ItemsComprobantes.ComprobanteDeVenta.Cuenta.IdCuenta;
			string IdTipoDeComprobante = this.ItemComprobante.ItemsComprobantes.ComprobanteDeVenta.TipoComprobanteDestino;
			string IdProducto = this.ItemComprobante.IdProducto;
			
			string descIngresosBrutos = Variables.GetValueString("Impuestos.PercepcionIngresosBrutos.Descripcion");

			tsy_ImpuestosExDataset.tsy_ImpuestosExDataTable data = mz.erp.businessrules.tsy_ImpuestosEx.GetList( IdProducto, IdCuenta, IdTipoDeComprobante );
			foreach (tsy_ImpuestosExDataset.tsy_ImpuestosExRow row in data )
			{
				
				if( row.Impuesto.Equals("IB") || row.Impuesto.Equals("IB RI")) 
				{
					if(IdCuenta != null && IdCuenta != string.Empty)
					{
						decimal alicuotaIngresosBrutos = this.ItemComprobante.ItemsComprobantes.ComprobanteDeVenta.Cuenta.AlicuotaPercepcionIngresosBrutos;
						string desc = descIngresosBrutos + " " +  Convert.ToString(Decimal.Round(alicuotaIngresosBrutos,2)) + "%";
						Impuesto imp = new Impuesto( this, row.IdImpuesto, row.Impuesto, row.Descripcion, desc,desc, row.AplicadoA, row.FormulaDeCalculo, alicuotaIngresosBrutos);
						this.Add( imp );
					}
					else
					{
						Impuesto imp = new Impuesto( this, row.IdImpuesto, row.Impuesto, row.Descripcion,row.DescripcionCorta,row.DescripcionLarga, row.AplicadoA, row.FormulaDeCalculo, row.Alicuota );
						this.Add( imp );
					}
				}
				else
				{
				
					Impuesto imp = new Impuesto( this, row.IdImpuesto, row.Impuesto, row.Descripcion,row.DescripcionCorta,row.DescripcionLarga, row.AplicadoA, row.FormulaDeCalculo, row.Alicuota );
					this.Add( imp );
				}
				
				/* Anterior */ 
				/*
				Impuesto imp = new Impuesto( this, row.IdImpuesto, row.Impuesto, row.Descripcion,row.DescripcionCorta,row.DescripcionLarga, row.AplicadoA, row.FormulaDeCalculo, row.Alicuota );
				this.Add( imp );
				*/
				
				
			}
		}
		private void FillEditData()
		{
			/*Reveer este metodo si en algun momento se permite la edicion de comprobantes de ventas*/
			string IdCuenta = this.ItemComprobante.ItemsComprobantes.ComprobanteDeVenta.Cuenta.IdCuenta;
			string IdTipoDeComprobante = this.ItemComprobante.ItemsComprobantes.ComprobanteDeVenta.TipoComprobanteDestino;
			string IdProducto = this.ItemComprobante.IdProducto;
			tsa_ComprobantesExDataset.tsa_ComprobanteDetalleImpuestosDataTable data = this.ItemComprobante.ItemsComprobantes.ComprobanteDeVenta.DatasetComprobante.tsa_ComprobanteDetalleImpuestos;
			foreach (tsa_ComprobantesExDataset.tsa_ComprobanteDetalleImpuestosRow row in data )
			{
				if (row.Ordinal == this._itemComprobante.Ordinal)
				{
					tsy_ImpuestosExDataset.tsy_ImpuestosExRow rowImpuesto = mz.erp.businessrules.tsy_ImpuestosEx.GetByPk( row.IdImpuesto );
					Impuesto imp = new Impuesto( this, row.IdImpuesto, rowImpuesto.Impuesto, rowImpuesto.Descripcion,rowImpuesto.DescripcionCorta,rowImpuesto.DescripcionLarga, row.AplicadoA, rowImpuesto.FormulaDeCalculo, rowImpuesto.Alicuota );
					this.Add( imp );
				}
			}
		}
		private ItemComprobante _itemComprobante;

		/// <summary>
		/// Devuelve el item que lo contiene
		/// </summary>
		public ItemComprobante ItemComprobante
		{
			get
			{
				return _itemComprobante;
			}
			set
			{
				_itemComprobante = value;
			}
		}

		/// <summary>
		/// Agrega un nuevo impuesto a la colección.
		/// </summary>
		/// <param name="item"></param>
		public void Add( Impuesto item )
		{
			List.Add( item );
		}
		
		/// <summary>
		/// Obtiene la sumatoria de cada uno de los impuestos contenidos en la coleccion
		/// </summary>
		public decimal Total
		{
			get
			{
				decimal subtotal = 0;
				foreach (Impuesto item in List)
				{
					subtotal+= item.Valor;
				}
			return subtotal;
			}			
		}

		public decimal TotalBruto
		{
			get
			{
				decimal subtotal = 0;
				foreach (Impuesto item in List)
				{
					subtotal+= item.ValorBruto;
				}
				return subtotal;
			}		
		}

		public decimal GetTotalImpuesto (string NombreImpuesto) 
		{			
			decimal valor = 0;
			foreach (Impuesto item in List)
			{
				if (item.Key == NombreImpuesto) 
				{
					valor = item.Valor;				
				}
			}
			return valor;
		}

		public decimal GetTotalImpuesto (ArrayList NombresImpuestos) 
		{			
			decimal valor = 0;
			foreach (Impuesto item in List)
			{
				if (NombresImpuestos.Contains(item.Key))
				{
                    //German 20110530 - Tarea 0000143
                    //valor = item.Valor;
                    valor = valor + item.Valor;
                    //German 20110530 - Tarea 0000143
				}
			}
			return valor;
		}
		public decimal GetAlicuota( string NombreImpuesto) 
		{
			bool encontro = false;
			decimal valor = 0;
			foreach (Impuesto item in List)
			{
				if (item.Key == NombreImpuesto) 
				{					
					valor = item.Alicuota;
				}
			}
			return valor;
		}
		public decimal GetPorcentajeImpuesto (string NombreImpuesto) 
		{
			bool encontro = false;
			decimal valor = 0;
			foreach (Impuesto item in List)
			{
				if (item.Key == NombreImpuesto) 
				{
					valor = item.Valor;
					encontro = true;
				}
			}
			if (encontro) 
			{
				if (this.ItemComprobante.Precio == 0) 
				{return 0;}
				else 
				{return (valor * 100 / this.ItemComprobante.Precio);}				
			}
			else 
			{return valor;}
		}

		public void SetAlicuotaMonto()
		{
			foreach (Impuesto item in List)
			{
				switch (item.Key.ToUpper())
				{
					case "IB": 
					case "IB RI": 						
						item.AlicuotaMonto = 0;
						break;						
					case "IIVP":
					case "IICOMUN":
					case "IISUPER":
					case "IIPD":
					case "IIGO":
					case "IIKERO":
					case "IIGNC":
                    //German 20110524 - Tarea 0000140
                    case "TASAVP":
                    case "TASACOMUN":
                    case "TASASUPER":
                    case "TASAPD":
                    case "TASAGO":
                    case "TASAKERO":
                    case "TASAGNC":
                    //Fin German 20110524 - Tarea 0000140
						item.AlicuotaMonto = item.Alicuota;
						item.Alicuota = item.Alicuota*100/_itemComprobante.Precio;						
						break;
					default:
                        //German 20110605 - Tarea 0000149
                        if (item.DescripcionLarga.ToUpper().Equals("II"))
                        {
                            item.AlicuotaMonto = item.Alicuota;
                            item.Alicuota = item.Alicuota * 100 / _itemComprobante.Precio;	
                        }
                        else
                            //Fin German 20110605 - Tarea 0000149
                            item.AlicuotaMonto = 0;
						break;
				}
			}
		}

		/// <summary>
		/// Fuerza la escritura de todos sus miembros al dataset de comprobante de venta
		/// </summary>
		public void Commit()
		{
			foreach (Impuesto imp in List)
			{
				imp.Commit();
			}
		}

		public bool IsDirty
		{
			set
			{
				foreach (Impuesto imp in List)
				{
					imp.IsDirty = value;
				}
			}
			get
			{
				bool valor = false;
				if (List.Count > 0)
				{
					valor = ((Impuesto)List[0]).IsDirty;
				}
				return valor;
			}
		}

        //Matias 20110823 - Tarea 0000131
        public bool Contiene(string impuestos)
        {
            ArrayList impuestosArray = mz.erp.systemframework.Util.Parse(impuestos); //siempre deben venir separados por ','
            foreach (Impuesto imp in List)
            {
                if (impuestosArray.Contains(imp.Key))
                    return true;
            }
            return false;
        }
        //FinMatias 20110823 - Tarea 0000131

	}// END CLASS DEFINITION Impuestos
}