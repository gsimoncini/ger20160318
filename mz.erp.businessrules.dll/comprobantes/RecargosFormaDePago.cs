using System;
using System.Collections;

namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Descripción breve de RecargosFormaDePago.
	/// </summary>
	public class RecargosFormaDePago : CollectionBase
	{
		
		public event EventHandler ImporteAbonadoChanged;
		public event EventHandler RecargosIncluidosChanged;

		public RecargosFormaDePago()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			
			
		}



		protected override void OnRemove(int index, object value)
		{
			base.OnRemove (index, value);
			if(OnModified != null)
				OnModified(this, new EventArgs());
		}

		protected override void OnInsert(int index, object value)
		{
			base.OnInsert (index, value);
			if(OnModified != null)
				OnModified(this, new EventArgs());
		}



	

		public void Add(RecargoFormaDePago recargo)
		{
			this.List.Add(recargo);
		}

		public void Clear()
		{
			this.List.Clear();
		}

		public event EventHandler OnModified;


		//hacer
		public void AddRecargo(Valor valor, FormaDePago formaDePago, decimal totalComprobanteSinRecargo, decimal totalComprobante)
		{
			RecargoFormaDePago recargo = new RecargoFormaDePago();
			recargo.FormaDePago = formaDePago;
			recargo.FormaDePago.Valor = valor;
			/*Deberia ser configurable*/
			
			recargo.ImporteAbonado = valor.MontoSinRecargos;
			recargo.RecargosIncluidos = valor.IncluyeRecargos;

			recargo.RecargosIncluidosChanged +=new EventHandler(recargo_RecargosIncluidosChanged);
			recargo.RecargosIncluidosChanged +=new EventHandler(valor.Refresh);
			recargo.ImporteAbonadoChanged +=new EventHandler(recargo_ImporteAbonadoChanged);
			recargo.ImporteAbonadoChanged +=new EventHandler(valor.Refresh);
			valor.OnFinalizeEdit +=new EventHandler(recargo.Refresh);
            //valor.ValorChange +=new mz.erp.businessrules.comprobantes.Valor.ValorChangeEventHandler(valor_ValorChange);
			//valor.IncluyeRecargosChanged +=new EventHandler(recargo.RefreshRecargosIncluidos);
			this.Add(recargo);
	
		}

		public void AddRecargo(FormaDePago formaDePago, decimal total)
		{
			RecargoFormaDePago recargo = new RecargoFormaDePago();
			recargo.ImporteAbonadoChanged +=new EventHandler(recargo_ImporteAbonadoChanged);
			recargo.RecargosIncluidosChanged +=new EventHandler(recargo_RecargosIncluidosChanged);
			recargo.FormaDePago = formaDePago;
			/*Deberia ser configurable - Deberia coincidir con la configuracion de la propiedad
			 * IncluyeRecargos de la clase Valor
			 * */
			recargo.ImporteAbonado = formaDePago.Valor.MontoCotizado;
			Valor valor = formaDePago.Valor;
			recargo.RecargosIncluidos = valor.IncluyeRecargos;
			valor.OnFinalizeEdit +=new EventHandler(recargo.Refresh);
			//valor.IncluyeRecargosChanged +=new EventHandler(recargo.RefreshRecargosIncluidos);
			//valor.ValorSinRecargoChange +=new mz.erp.businessrules.comprobantes.Valor.ValorChangeEventHandler(valor_ValorChange);
			recargo.ImporteAbonadoChanged +=new EventHandler(valor.Refresh);
			recargo.RecargosIncluidosChanged +=new EventHandler(valor.Refresh);
			formaDePago.Valor.MontoCotizado = recargo.Total;
			formaDePago.Valor.MontoSinRecargos = recargo.ImporteAbonado;
			if (recargo.ImporteAbonado > 0) 
			{
				this.Add(recargo);
			}			
		}

		private void recargo_ImporteAbonadoChanged(object sender, EventArgs e)
		{
			if(ImporteAbonadoChanged != null)
				ImporteAbonadoChanged(this, new EventArgs());
		}

		public decimal TotalPorcentajeRecargo
		{
			get
			{	
				/*
				decimal totalPorcentaje = 0; 
				foreach(RecargoFormaDePago recargo in this.List)
				{
					totalPorcentaje += recargo.PorcentajeRecargo;
				}
				return decimal.Round(totalPorcentaje,2);
				*/
				if(TotalImporteAbonado > 0)
					return TotalImporteRecargo / TotalImporteAbonado;
				return 0;
			}
		}

		public decimal TotalImporteAbonado
		{
			get
			{		
				decimal totalAbonado = 0;
				foreach(RecargoFormaDePago recargo in this.List)
				{
					totalAbonado += recargo.ImporteAbonado;
				}
				//return decimal.Round(totalAbonado,2);
				return totalAbonado;
			}
		}

		public decimal Total
		{
			get
			{
				decimal total = 0;
				foreach(RecargoFormaDePago recargo in this.List)
				{
					total += recargo.Total;
				}
				//return decimal.Round(total,2);
				return total;
	
			}
		}

		public decimal TotalImporteRecargo
		{
			get
			{
				decimal totalImporteRecargo = 0;
				foreach(RecargoFormaDePago recargo in this.List)
				{
					totalImporteRecargo += recargo.ImporteRecargo;
				}
				//return decimal.Round(totalImporteRecargo,2);
				return totalImporteRecargo;

			}
		}

		private void valor_ValorChange()
		{
			foreach(RecargoFormaDePago recargo in this.List)
			{
				recargo.ImporteAbonado = recargo.FormaDePago.Valor.MontoSinRecargos;
			}
		}

		private void recargo_RecargosIncluidosChanged(object sender, EventArgs e)
		{
			if(RecargosIncluidosChanged != null)
				RecargosIncluidosChanged(this, new EventArgs());
		}

		private void valor_OnFinalizeEdit(object sender, EventArgs e)
		{

		}
	}

	public class RecargoFormaDePago
	{
		public RecargoFormaDePago()
		{
		}
		public  void Refresh(object sender, EventArgs e)
		{
			this._recargosIncluidos = this._formaDePago.Valor.IncluyeRecargos;
			this._importeAbonado = this._formaDePago.Valor.MontoCotizado;
			if(RecargosIncluidosChanged != null)
				RecargosIncluidosChanged(this, new EventArgs());
		}


		#region Variables privadas
			
		private FormaDePago _formaDePago;
		private decimal _importeAbonado;
		private bool _recargosIncluidos;
			
		#endregion

		#region Eventos


		
			public event EventHandler ImporteAbonadoChanged;
			public event EventHandler RecargosIncluidosChanged;

		#endregion
		
		#region Propiedades


		public bool RecargosIncluidos
		{
			get
			{
				return _recargosIncluidos;
			}
			set
			{
				_recargosIncluidos = value;
				if(RecargosIncluidosChanged != null)
					RecargosIncluidosChanged(this, new EventArgs());
			}
		}
		
		public decimal ImporteAbonado
		{
			get
			{
				return _importeAbonado;
			}
			set
			{
				if(_importeAbonado != value)
				{
					_importeAbonado = value;
					if (ImporteAbonadoChanged != null)
						ImporteAbonadoChanged(this, new EventArgs());
				}
			}

		}

		public decimal PorcentajeRecargo
		{
			get
			{
				//return decimal.Round(this._formaDePago.Recargo/100,2);
				return this._formaDePago.Recargo/100;
			}
		}

		public decimal ImporteRecargo
		{
			get
			{		
				return this._importeAbonado * this.PorcentajeRecargo;//decimal.Round(this._importeAbonado * this.PorcentajeRecargo,2);
			}
		}

		public decimal Total
		{
			get
			{
				if(RecargosIncluidos)
				return _importeAbonado + ImporteRecargo;//decimal.Round(_importeAbonado + ImporteRecargo,2);
				else return _importeAbonado;//decimal.Round(_importeAbonado,2);
			}
			/*
			set
			{
				if(PorcentajeRecargo > 0)
					ImporteAbonado = value / (1/_formaDePago.Recargo);
			}
			*/
		}

		public FormaDePago FormaDePago
		{
			get
			{
				return _formaDePago;
			}
			set
			{
				_formaDePago = value;
			}
		}

		public string Concepto
		{
			get
			{
				return this._formaDePago.DescripcionComprobante + " " + this._formaDePago.DescripcionEntidad + " " + this._formaDePago.DescripcionMoneda;
			}
		}

		

		

		#endregion
	}
}
