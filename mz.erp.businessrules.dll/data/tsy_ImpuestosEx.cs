namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsy_ImpuestosEx : IDisposable
	{
	
		#region Custom Members

		public static DataSet GetList()
		{
			DataSet data = mz.erp.dataaccess.tsy_ImpuestosEx.GetList( );
			return data;
		}

		#endregion
		
		public tsy_ImpuestosEx()
		{
		}

		public static tsy_ImpuestosExDataset.tsy_ImpuestosExRow GetByPk( string IdImpuesto )
		{
			return mz.erp.dataaccess.tsy_ImpuestosEx.GetByPk( IdImpuesto );
		}
		public static tsy_ImpuestosExDataset.tsy_ImpuestosExDataTable GetList( string IdProducto, string IdCuenta, string IdTipoDeComprobante )
		{
			tsy_ImpuestosExDataset data = mz.erp.dataaccess.tsy_ImpuestosEx.GetList( IdProducto, IdCuenta, IdTipoDeComprobante );
			return data.tsy_ImpuestosEx;
		}
		
		public void Dispose()
		{
		}
		
	}
}

