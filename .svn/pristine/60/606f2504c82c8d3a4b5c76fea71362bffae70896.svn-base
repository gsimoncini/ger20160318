using System;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de AbmProductosSecurity.
	/// </summary>
	public class AbmProductosSecurity
	{
		
		private AbmProductosSecurity()
		{
			Init();
		}

		private static AbmProductosSecurity _instance = null;

		public static AbmProductosSecurity GetInstance()
		{
			if(_instance == null)
				return new AbmProductosSecurity();
			else return _instance;
			
		}

		private void Init()
		{
			_allowEditCodigo = Variables.GetValueBool("Productos.CodigoAutomatico");


		}

		private bool _allowShowCodigo = true;
		private bool _allowEditCodigo = true;

		public bool AllowShowCodigo
		{
			get{return _allowShowCodigo;}
		}

		public bool AllowEditCodigo
		{
			get{return _allowEditCodigo;}
		}



	}
}
