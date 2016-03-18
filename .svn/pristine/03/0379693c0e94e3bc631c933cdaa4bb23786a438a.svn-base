namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;
	/// <summary>
	/// Descripción breve de sy_VariablesEx.
	/// </summary>
	public class sy_VariablesEx : IDisposable
	{
		public sy_VariablesEx()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		#region Custom Members
		public static DataTable GetListByCola( string IdVariable )
		{
			//DataSet data = new DataSet();
			DataTable table = new DataTable("");
			DataColumn columna1=new DataColumn("IdVariable");
			DataColumn columna2=new DataColumn("ValorDefault");
			DataColumn columna3=new DataColumn("Perfil");
			DataColumn columna4=new DataColumn("Puesto");
			DataColumn columna5=new DataColumn("Usuario");
			DataColumn columna6=new DataColumn("Descripcion");
			DataColumn columna7=new DataColumn("Tipo");
			DataColumn columna8=new DataColumn("IdUsuario");
			DataColumn columna9=new DataColumn("IdPerfil");
			DataColumn columna10=new DataColumn("IdPuesto");
			columna1.DataType =typeof (string); 
			columna2.DataType =typeof (string); 
			columna3.DataType =typeof (string); 
			columna4.DataType =typeof (string); 
			columna5.DataType =typeof (string); 
			columna6.DataType =typeof (string); 
			columna7.DataType =typeof (string); 
			columna8.DataType =typeof (string); 
			columna9.DataType =typeof (long); 
			columna10.DataType =typeof (long); 
			table.Columns.Add(columna1);
			table.Columns.Add(columna2);
			table.Columns.Add(columna3);
			table.Columns.Add(columna4);
			table.Columns.Add(columna5);
			table.Columns.Add(columna6);
			table.Columns.Add(columna7);
			table.Columns.Add(columna8);
			table.Columns.Add(columna9);
			table.Columns.Add(columna10);

			DataTable tableVariables = sy_Variables.GetListByCola(IdVariable).sy_Variables;
			
			foreach (DataRow rowV in tableVariables.Rows)
			{
				DataRow rowVC = table.NewRow();
				rowVC["IdVariable"] = rowV["IdVariable"];
				rowVC["ValorDefault"] = rowV["ValorDefault"];
				rowVC["Perfil"] = "";
				rowVC["Puesto"] = "";
				rowVC["Usuario"] = "";
				rowVC["Descripcion"] = rowV["Descripcion"];
				rowVC["Tipo"] = rowV["IdTipoVariable"];
				table.Rows.Add(rowVC);
			}

			DataTable tableVariablesPerfiles = sy_VariablesPerfiles.GetListByCola(IdVariable).sy_VariablesPerfiles;
			foreach (DataRow rowP in tableVariablesPerfiles.Rows)
			{
				string idVar = (string)rowP["IdVariable"];
				sy_VariablesDataset.sy_VariablesRow rowSV = sy_Variables.GetByPk(idVar);
				DataRow rowPC = table.NewRow();
				rowPC["IdVariable"] = rowP["IdVariable"];
				rowPC["ValorDefault"] = rowP["ValorDefault"];
				rowPC["Perfil"] = rowP["Perfil"];
				rowPC["Puesto"] = "";
				rowPC["Usuario"] = "";
				if(rowSV != null)
				{
					rowPC["Descripcion"] = rowSV["Descripcion"];
					rowPC["Tipo"] = rowSV["IdTipoVariable"];
				}
				else
				{
					rowPC["Descripcion"] = "";
					rowPC["Tipo"] = "";
				}
				rowPC["IdPerfil"] = rowP["IdPerfil"];
				table.Rows.Add(rowPC);

			}

			DataTable tableVariablesUsuarios = mz.erp.businessrules.sy_VariablesUsuarios.GetListByCola(IdVariable).sy_VariablesUsuarios;
			foreach (DataRow rowU in tableVariablesUsuarios.Rows)
			{
				string idVar = (string)rowU["IdVariable"];
				sy_VariablesDataset.sy_VariablesRow rowSV = sy_Variables.GetByPk(idVar);
				DataRow rowUC = table.NewRow();
				rowUC["IdVariable"] = rowU["IdVariable"];
				rowUC["ValorDefault"] = rowU["ValorDefault"];
				rowUC["Perfil"] = "";
				rowUC["Puesto"] = "";
				rowUC["Usuario"] = rowU["Usuario"];
				if(rowSV != null)
				{
					rowUC["Descripcion"] = rowSV["Descripcion"];
					rowUC["Tipo"] = rowSV["IdTipoVariable"];
				}
				else
				{
					rowUC["Descripcion"] = "";
					rowUC["Tipo"] = "";
				}
				rowUC["IdUsuario"] = rowU["IdUsuario"];
				table.Rows.Add(rowUC);

			}
			
			DataTable tableVariablesPuestos = mz.erp.businessrules.sy_VariablesPuestos.GetListByCola(IdVariable).sy_VariablesPuestos;
			foreach (DataRow rowPU in tableVariablesPuestos.Rows)
			{
				string idVar = (string)rowPU["IdVariable"];
				sy_VariablesDataset.sy_VariablesRow rowSV = sy_Variables.GetByPk(idVar);
				DataRow rowPUC = table.NewRow();
				rowPUC["IdVariable"] = rowPU["IdVariable"];
				rowPUC["ValorDefault"] = rowPU["ValorDefault"];
				rowPUC["Perfil"] = "";
				rowPUC["Puesto"] = rowPU["Puesto"];
				rowPUC["Usuario"] = "";
				if(rowSV != null)
				{
					rowPUC["Descripcion"] = rowSV["Descripcion"];
					rowPUC["Tipo"] = rowSV["IdTipoVariable"];
				}
				else
				{
					rowPUC["Descripcion"] = "";
					rowPUC["Tipo"] = "";
				}
				rowPUC["IdPuesto"] = rowPU["IdPuesto"];
				table.Rows.Add(rowPUC);

			}
			return table;
		}
		
		#endregion

		public void Dispose()
		{
		}


	}
}
