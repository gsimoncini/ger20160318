using System;
using System.Collections;
using System.Data;

namespace mz.erp.commontypes
{
	public class ReportFilterItem
	{
		private string _clave;
		private string _leyenda;
		private bool _enabled;
		private object _defaultvalue;
		private string _propertyBinding;
		private DataTable _table ; 

		/*NUEVO METODO PARA EL WORKFLOW*/

		public ReportFilterItem(string clave, string leyenda, bool enabled, object defaultValue, string propertyBinding)
		{
				Init(clave,leyenda,enabled,defaultValue,propertyBinding);
		}
		public ReportFilterItem(string clave, string leyenda, bool enabled, object defaultValue, string propertyBinding, DataTable table)
		{
			Init(clave,leyenda,enabled,defaultValue,propertyBinding);
			_table = table;
		}

		public ReportFilterItem( string clave, string leyenda )
		{
			Init(clave,leyenda,true,null,null);
		}
		public ReportFilterItem( string clave, string leyenda, bool enabled, object defaultvalue )
		{
			Init(clave,leyenda,enabled,defaultvalue,null);
		}
		private void Init( string clave, string leyenda, bool enabled, object defaultvalue, string propertyBinding )
		{
			_clave = clave;
			_leyenda = leyenda;
			_enabled = enabled;
			_defaultvalue = defaultvalue;
			_propertyBinding = propertyBinding;

		}
		public string Clave
		{
			get { return _clave; }
		}
		public string Leyenda
		{
			get { return _leyenda; }
		}
		public bool Enabled
		{
			get { return _enabled; }
		}
		public object DefaultValue
		{
			get { return _defaultvalue; }
		}
		public string PropertyBinding
		{
			get
			{
				return _propertyBinding;
			}
		}

		public DataTable Table
		{
			get
			{
				return _table;
			}
		}
		

	}
	/// <summary>
	/// Descripción breve de ReportFilterArray.
	/// </summary>
	public class ReportFilterArray: CollectionBase
	{
		public ReportFilterArray()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public void Add( ReportFilterItem item)
		{
			List.Add(item);
		}
		
		public void Add(string clave, string leyenda, bool enabled, object defaultValue, string propertyBinding, DataTable table)
		{
			ReportFilterItem item = new ReportFilterItem( clave, leyenda,enabled,defaultValue,propertyBinding,table);
			List.Add(item);
		}
		public void Add( string clave, string leyenda, bool enabled, object defaultValue)
		{
			ReportFilterItem item = new ReportFilterItem( clave, leyenda,enabled,defaultValue);
			List.Add(item);
		}
		public void Add( string clave, string leyenda, bool enabled, object defaultValue, string  propertyBinding)
		{
			ReportFilterItem item = new ReportFilterItem( clave, leyenda,enabled,defaultValue,propertyBinding);
			List.Add(item);
		}
		public void Add( string clave, string leyenda )
		{
			ReportFilterItem item = new ReportFilterItem( clave, leyenda );
			List.Add(item);
		}

		public ReportFilterItem this[ int index ]  
		{
			get  
			{
				return( (ReportFilterItem) List[index] );
			}
		}

		
		
	}
}
