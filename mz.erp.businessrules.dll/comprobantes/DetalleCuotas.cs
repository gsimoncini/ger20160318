using System;

namespace mz.erp.businessrules
{
	public class DetalleCuotas
	{
		private int _idCuota;
		private DateTime _fechaVencimiento;
		private decimal _monto;
		private decimal _porcentaje;
        //German 20101119 - Tarea 943
        private short _diasVencimiento;


        public short DiasVencimiento
        {
            get
            {
                return _diasVencimiento;
            }
            set
            {
                _diasVencimiento = value;
            }
        }

        //Fin German 20101119 - Tarea 943
	

		public DetalleCuotas()
		{
		}


		public int GetIdCuota()
		{
			return IdCuota;
		}
		public int IdCuota
		{
			get
			{
				return this._idCuota;
			}
		}
		public DateTime FechaVencimiento
		{
			get
			{
				return this._fechaVencimiento;
			}
		}

		public decimal Monto
		{
			get
			{
				return this._monto;
			}
		}
		public void SetIdCuota(int IdCuota)
		{
			this._idCuota= IdCuota;
		}


		
		public DateTime GetFechaVencimiento()
		{
			return this._fechaVencimiento;
		}
		public void SetFechaVencimiento(DateTime FechaVencimiento)
		{
			this._fechaVencimiento= FechaVencimiento;
		}

		public decimal GetMonto()
		{
			return this._monto;
		}
		public void SetMonto(decimal  Monto)
		{
			this._monto= Monto;
		}

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
		public void SetPorcentaje( decimal porcentaje )
		{
			_porcentaje = porcentaje;
		}
		public decimal GetPorcentaje()
		{
			return _porcentaje;
		}
	}
}
