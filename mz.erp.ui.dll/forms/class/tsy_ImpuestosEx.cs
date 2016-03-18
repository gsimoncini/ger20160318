namespace mz.erp.ui.forms.classes
{
	using System;
	using System.Data;
	using System.Text;
	using System.Collections;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.ui.forms.classes;
	using mz.erp.ui.controllers;

	public class tsy_ImpuestosEx : IDisposable, IGridDocument
	{
		public tsy_ImpuestosEx()
		{
		}

		public tsy_ImpuestosEx( string[] fieldList )
		{
			_fieldList = fieldList;
		}
		
		public string GetLayout()
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "Nombre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Nombre", "Nombre" ) );
			if ( fl.Contains( "Valor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Valor", "Valor" ) );
            //German 20110602 - Tarea 0000149
            if (_esImpuestoInterno)
            {
                if (fl.Contains("IdImpuesto") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "IdImpuesto", "IdImpuesto",true));
                if (fl.Contains("Impuesto") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "Impuesto", "Clave", 150, Types.ColumnTypes.Text, Types.EditType.TextBox));
                if (fl.Contains("Descripcion") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "Descripcion", "Descripción", 250, Types.ColumnTypes.Text, Types.EditType.TextBox));
                if (fl.Contains("Alicuota1") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "Alicuota1", "Alicuota", 100, Types.ColumnTypes.Text, Types.EditType.TextBox));
                if (fl.Contains("FechaInicio") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "FechaInicio", "FechaInicio", true));
            }
            else
            {
                if (fl.Contains("Descripcion") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "Descripcion", "Descripción", 250, Types.ColumnTypes.Text, Types.EditType.NoEdit));
                if (fl.Contains("Alicuota1") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "Alicuota1", "Alicuota", 100, Types.ColumnTypes.Text, Types.EditType.TextBox));
            }
            //Fin German 20110602 - Tarea 0000149
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}

		public static string GetLayoutAbmExProductos()
		{
			string[] _fieldList = new string[] {"Key","DescripcionCorta","Formula", "Activo"};
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "IdImpuesto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdImpuesto", "Id Impuesto",100,Types.ColumnTypes.Text, Types.EditType.NoEdit) );
			if ( fl.Contains( "Key" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Key", "Impuesto",100, Types.ColumnTypes.Text, Types.EditType.NoEdit) );
			if ( fl.Contains( "DescripcionCorta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionCorta", "Descripción",250, Types.ColumnTypes.Text, Types.EditType.NoEdit) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripción",250, Types.ColumnTypes.Text, Types.EditType.NoEdit) );
			if ( fl.Contains( "Formula" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Formula", "Formula", true) );
			if ( fl.Contains( "Activo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo",50,Types.ColumnTypes.CheckBox,Types.EditType.CheckBox) );
			if ( fl.Contains( "Alicuota1" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Alicuota1", "Alicuota",50,Types.ColumnTypes.Text,Types.EditType.TextBox) );
			//f ( fl.Contains( "IsAvailable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IsAvailable", "Disponible",100,Types.ColumnTypes.CheckBox,Types.EditType.CheckBox ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}


		public void Update( object dataTable )
		{
            //German 20110602 - Tarea 0000149


            if (_esImpuestoInterno)
            {
                tsy_ImpuestosDataset.tsy_ImpuestosDataTable table = (tsy_ImpuestosDataset.tsy_ImpuestosDataTable)dataTable;

                /*
                 sy_VariablesDataset.sy_VariablesRow rowVar1 = mz.erp.businessrules.sy_Variables.GetByPk("Impuestos.II");
                 sy_VariablesDataset.sy_VariablesRow rowVar2 = mz.erp.businessrules.sy_Variables.GetByPk("Productos.Impuestos.ImpuestosDirectos");
                 sy_VariablesDataset.sy_VariablesRow rowVar3 = mz.erp.businessrules.sy_Variables.GetByPk("Productos.ProductosSucursales.PrecioFinalEstimado.ImpuestosAsociados");

                 string var1 = rowVar1.ValorDefault;
                 string var2 = rowVar2.ValorDefault;
                 string var3 = rowVar3.ValorDefault;
                 **/

                foreach (tsy_ImpuestosDataset.tsy_ImpuestosRow row in table.Rows)
                {
                    if (row.RowState.Equals(DataRowState.Added) || row.RowState.Equals(DataRowState.Modified))
                    {
                        row.DescripcionCorta = row.Impuesto;
                        row.DescripcionLarga = "II";
                        row.IdTipoDeConcepto = "G";
                        row.MetodoDeComparacion = "E";
                        row.FormulaDeCalculo = string.Empty;
                        row.Alicuota2 = 0;
                        row.Alicuota3 = 0;
                        row.Alicuota4 = 0;
                        row.Activo = true;
                        row.IdConexionCreacion = mz.erp.businessrules.Security.IdConexion;
                        row.IdConexionUltimaModificacion = mz.erp.businessrules.Security.IdConexion;
                        row.IdReservado = 0;
                        row.IdEmpresa = mz.erp.businessrules.Security.IdEmpresa;
                        row.IdSucursal = mz.erp.businessrules.Security.IdSucursal;

                    }
                    /*
                    if (row.RowState.Equals(DataRowState.Added) || row.RowState.Equals(DataRowState.Deleted))
                    {
                        if (row.RowState.Equals(DataRowState.Added))
                        {
                            var1 = var1 + "," + row.Impuesto;
                            var2 = var2 + "," + row.Impuesto;
                            var3 = var3 + "," + row.Impuesto;
                        }
                        else
                        {
                            var1 = var1.Replace(row.g, "");
                            var2 = var2.Replace(row.Impuesto, "");
                            var3 = var3.Replace(row.Impuesto, "");
                        }
                    }
                     **/

                }

                /*
                rowVar1.ValorDefault = var1;
                rowVar2.ValorDefault = var2;
                rowVar3.ValorDefault = var3;
                sy_VariablesDataset dataVariables = new sy_VariablesDataset();
                dataVariables.sy_Variables.ImportRow(rowVar1);
                dataVariables.sy_Variables.ImportRow(rowVar2);
                dataVariables.sy_Variables.ImportRow(rowVar3);
                mz.erp.businessrules.tsy_Impuestos.Update((tsy_ImpuestosDataset.tsy_ImpuestosDataTable)dataTable, dataVariables.sy_Variables);
                mz.erp.businessrules.Variables.Reset();
                 */

            }
            mz.erp.businessrules.tsy_Impuestos.Update( ( tsy_ImpuestosDataset.tsy_ImpuestosDataTable) dataTable);
          

            //Fin German 20110602 - Tarea 0000149
			//mz.erp.businessrules.tsh_Productos.Update( ( tsh_ProductosDataset.tsh_ProductosDataTable )dataTable );

		}
		public DataTable GetList()
		{
            //German 20110602 - Tarea 0000149
			if(_esImpuestoInterno)
                return mz.erp.businessrules.tsy_Impuestos.GetListImpuestosInternos().tsy_Impuestos;
            //Fin German 20110602 - Tarea 0000149
            return mz.erp.businessrules.tsy_Impuestos.GetList().tsy_Impuestos;
		}
		
		private string[] _fieldList;
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

        //German 20110602 - Tarea 0000149
        private bool _esImpuestoInterno = false;

        public tsy_ImpuestosEx(string[] fieldList, bool EsImpuestoInterno)
        {
            _fieldList = fieldList;
            _esImpuestoInterno = EsImpuestoInterno;
        }
        //Fin German 20110602 - Tarea 0000149
		
	}
}

