using System;
using System.Data.SqlClient;
using mz.erp.dataaccess;
using mz.erp.commontypes.data;
using mz.erp.commontypes;
using System.Reflection;
using System.Collections;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de TipoMovimientoBancario.
	/// </summary>
	public class MovimientoBancario
	{
		public MovimientoBancario()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public MovimientoBancario(string id,string idTipoMovimiento, string idCuenta, string idValor, string nroCheque, decimal total,DateTime fechaImputacion,DateTime fechaConciliacion)
		{
			this.IdMovimientoBancario=id;
			this.IdTipoMovimiento=idTipoMovimiento;
			this.IdCuentaBancaria=idCuenta;
			this.IdValor=idValor;
			this.NroCheque=nroCheque;
			this.Total=total;
			this.FechaImputacion=fechaImputacion;
			this.FechaConciliacion=fechaConciliacion;

		}
		#region variables privadas
		private string _idMovimientoBancario=string.Empty;
		private string _idTipoMovimiento=string.Empty;
		private string _idCuentaBancaria=string.Empty;
		private string _idValor=string.Empty;
		private string _nroCheque=string.Empty;
		private decimal _total=new Decimal();
		private DateTime _fechaConciliacion=new DateTime();
		private DateTime _fechaImputacion=new DateTime();
		private mz.erp.commontypes.data.tfi_MovimientoBancarioDataset _data = new mz.erp.commontypes.data.tfi_MovimientoBancarioDataset();
		
		public string IdMovimientoBancario
		{
			get{return _idMovimientoBancario;}
			set{_idMovimientoBancario=value;}
		}
		public string IdTipoMovimiento
		{
		 get{return _idTipoMovimiento;}
		 set{_idTipoMovimiento=value;}
		}
		public string IdCuentaBancaria
		{
			get{return _idCuentaBancaria;}
			set{_idCuentaBancaria=value;}
		}
		public string IdValor
		{
			get{return _idValor;}
			set{_idValor=value;}
		}

		public tfi_MovimientoBancarioDataset Data
		{
			get{return _data;}
			set{_data=value;}
		}
		public string NroCheque
		{
			get{return _nroCheque;}
			set{_nroCheque=value;}
		}
		public decimal Total
		{
			get{return _total;}
			set{_total=value;}
		}
		public DateTime FechaConciliacion
		{
			get{return _fechaConciliacion;}
			set{_fechaConciliacion=value;}
		}
		public DateTime FechaImputacion
		{
			get{return _fechaImputacion;}
			set{_fechaImputacion=value;}
		}
		//fechaImputacion
		#endregion
		#region metodos publicos
		
		public void Commit()
		{
			//Si el id  es "" es un alta
			if (this.IdMovimientoBancario.Equals(string.Empty))
			{
			#region alta
				tfi_MovimientoBancarioDataset.tfi_MovimientoBancarioRow _row =_data.tfi_MovimientoBancario.Newtfi_MovimientoBancarioRow();
				tfi_MovimientoBancario.SetRowDefaultValues(_row);
				_row["IdTipoMovimiento"] = this.IdTipoMovimiento;
				_row["IdValor"]=this.IdValor;
				_row["NroCheque"]=this.NroCheque;
				_row["IdCuenta"]=this.IdCuentaBancaria;
				_row["Total"]=this.Total;
				_row["FechaImputacion"]=this.FechaImputacion;
				_data.Tables[0].Rows.Add(_row);	
				
				#endregion
			}
				//Es una actualización esta conciliando 
			else
			{
				#region actualizacion
				tfi_MovimientoBancarioDataset.tfi_MovimientoBancarioRow _row =tfi_MovimientoBancario.GetByPk(this.IdMovimientoBancario);
				_row["FechaConciliacion"]=this.FechaConciliacion;
				_data.Tables[0].ImportRow(_row);


				#endregion
				
			}
			
	
		}

		public void Flush(string IdTransaction)
		{	SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			businessrules.tfi_MovimientoBancario.Update( (tfi_MovimientoBancarioDataset.tfi_MovimientoBancarioDataTable) _data.Tables[0],trx);
					
		}
		
		
		
		
		
		
		
		#endregion

	}
}
