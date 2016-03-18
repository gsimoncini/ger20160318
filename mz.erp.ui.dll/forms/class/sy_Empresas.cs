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

    /* Silvina 20110504 - Tarea 0000123 */
    [ValueListGridAttributes("BaseDeDatos", typeof(mz.erp.ui.forms.classes.sy_BasesDeDatos), "BaseDeDatos", "BaseDeDatos")]
    /* Fin Silvina 20110504 - Tarea 0000123 */
	public class sy_Empresas : IDisposable, IGridDocument
	{
		private string[] _fieldList;

		public sy_Empresas()
		{
		}

		public sy_Empresas( string[] fieldList )
		{
			_fieldList = fieldList;
		}

		public string GetLayout()
		{
			
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "Id Empresa" ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripción" ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Conexion", "Conexion" ) );
            /* Silvina 20110504 - Tarea 0000123 */
            sb.Append(LayoutBuilder.GetRow(i++, "BaseDeDatos", "BaseDeDatos", 150));
            sb.Append(LayoutBuilder.GetRow(i++, "FechaCreacion", "FechaCreacion", true));
            sb.Append(LayoutBuilder.GetRow(i++, "IdConexionCreacion", "IdConexionCreacion", true));
            /* Fin Silvina 20110504 - Tarea 0000123 */
			sb.Append( LayoutBuilder.GetRow( i++, "Usuario", "Usuario" ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Password", "Password" ) );
            sb.Append(LayoutBuilder.GetRow(i++, "Activo", "Activo", 50, Types.EditType.CheckBox));
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}
		
		public virtual DataTable GetList()
		{
			return mz.erp.businessrules.sy_Empresas.GetList().sy_Empresas;
		}
		
		public virtual void Update( object dataTable )
		{
			mz.erp.businessrules.sy_Empresas.Update( ( sy_EmpresasDataset.sy_EmpresasDataTable )dataTable );
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

