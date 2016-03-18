/* Silvina 20110504 - Tarea 0000123 */
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
    using mz.erp.businessrules;

    using System.Data.SqlClient;

	public class sy_BasesDeDatos
	{
        private string[] _fieldList;

		public sy_BasesDeDatos()
		{
		}

        public sy_BasesDeDatos(string[] fieldList)
		{
			_fieldList = fieldList;
		}

		public string GetLayout()
		{
			
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
            sb.Append(LayoutBuilder.GetRow(i++, "Name", "Name"));
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}
		
		[ValueListGridMember]
		public virtual DataTable GetList()
		{
            DataSet data = new DataSet();

            SqlCommand cmd = new SqlCommand();
            SqlConnection connec = dbhelper.Connection.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter();

            cmd.Connection = connec;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Exec sp_helpdb";

            da.SelectCommand = cmd;
            da.Fill(data);

            string metodo = Variables.GetValueString("Sistema.BasesDeDatos.MetodoDeComparacion", "E");
            string bases =  Variables.GetValueString("Sistema.BasesDeDatos");
            ArrayList arrayBases;
            arrayBases = mz.erp.systemframework.Util.Parse(bases, ",");

            sy_EmpresasDataset.sy_EmpresasDataTable table = new sy_EmpresasDataset.sy_EmpresasDataTable();
            foreach (DataRow row in data.Tables[0].Rows)
            {
                string nombre = row["Name"].ToString();
                if (((metodo.Equals("E")) && (!arrayBases.Contains(nombre))) ||
                   ((metodo.Equals("I")) && (arrayBases.Contains(nombre))))
                {
                    sy_EmpresasDataset.sy_EmpresasRow r = table.Newsy_EmpresasRow();
                    r.Descripcion = string.Empty;
                    r.Conexion = string.Empty;
                    r.BaseDeDatos = nombre;
                    r.Usuario = string.Empty;
                    r.Password = string.Empty;
                    r.IdConexionCreacion = 1;
                    r.FechaCreacion = Sistema.DateTime.Now;
                    r.IdEmpresa = Convert.ToInt16(row["dbid"]);
                    table.Rows.Add(r);
                }
            }
            return table;

		}
		
		public virtual void Update( object dataTable )
		{
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
		
		public void DeletingRowValidate( DataRow row )
		{
		}

		public void Dispose()
		{
		}
	
	}
}
/* Fin Silvina 20110504 - Tarea 0000123 */