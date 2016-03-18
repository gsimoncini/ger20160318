namespace mz.erp.ui.forms.classes
{
    using System;
    using System.Data;
    using System.Text;
    using System.Collections;

    using mz.erp.systemframework;
    using mz.erp.commontypes;
    using mz.erp.commontypes.data;
    using mz.erp.ui.controls;
    using mz.erp.ui.controllers;

    public class tpu_CondicionesDeCompras : IDisposable, IGridDocument
	{
        		private string[] _fieldList;

		public tpu_CondicionesDeCompras()
		{
		}

        public tpu_CondicionesDeCompras(string[] fieldList)
		{
			_fieldList = fieldList;
		}

		public string GetLayout()
		{
			
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append(LayoutBuilder.GetHeader());
            sb.Append(LayoutBuilder.GetRow(i++, "IdCondicionDeCompra", "IdCondicionDeCompra",true));
            sb.Append(LayoutBuilder.GetRow(i++, "Descripcion", "Descripcion"));
            sb.Append(LayoutBuilder.GetRow(i++, "DiasVencimiento", "DiasVencimiento"));
            sb.Append(LayoutBuilder.GetRow(i++, "Recargo", "Recargo"));
            sb.Append(LayoutBuilder.GetRow(i++, "Activo", "Activo", 100, Types.ColumnTypes.CheckBox, Types.EditType.CheckBox));
            sb.Append(LayoutBuilder.GetRow(i++, "Orden", "Orden"));

			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}
		
		[ValueListGridMember]
		public virtual DataTable GetList()
		{
            return mz.erp.businessrules.tpu_CondicionesDeCompras.GetList().tpu_CondicionesDeCompras;
		}
		
		public virtual void Update( object dataTable )
		{
            tpu_CondicionesDeComprasDataset.tpu_CondicionesDeComprasDataTable data = (tpu_CondicionesDeComprasDataset.tpu_CondicionesDeComprasDataTable)dataTable;
            tpu_ProveedoresDataset prov;
            bool ok = true;
            foreach(tpu_CondicionesDeComprasDataset.tpu_CondicionesDeComprasRow row in data.Rows)
            {
                if (row.RowState.Equals(System.Data.DataRowState.Modified) && !row.Activo)
                {
                    prov = mz.erp.businessrules.tpu_Proveedores.GetByIdCondicionDeCompra(row.IdCondicionDeCompra);
                    if (prov.tpu_Proveedores.Rows.Count != 0)
                    {
                        System.Windows.Forms.MessageBox.Show("La Condicion de Compra " + row.Descripcion + " esta asociada a un Proveedor", "Error", System.Windows.Forms.MessageBoxButtons.OK);
                        ok = false;
                        break;
                    }
                }
            }
            if (ok)
            {
                mz.erp.businessrules.comprobantes.CondicionesDeComprasFactory.Clear();
                mz.erp.businessrules.tpu_CondicionesDeCompras.Update((tpu_CondicionesDeComprasDataset.tpu_CondicionesDeComprasDataTable)dataTable);
            }
		}

		public string[] FieldList
		{
			get
			{
				return _fieldList;
			}
			set
			{
				_fieldList = value;
			}
			
		}
		
		public void Dispose()
		{
		}
	
	}
}
