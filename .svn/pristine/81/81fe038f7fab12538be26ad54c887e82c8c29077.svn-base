using System;
using System.Data;
using System.Text.RegularExpressions;
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.dataaccess;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de sy_UsuariosEx.
	/// </summary>
	public class sy_UsuariosEx
	{
		public sy_UsuariosEx()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		[ atMethodNewRow ]
		public static sy_UsuariosExDataset NewRow()
		{
			sy_UsuariosExDataset data = new sy_UsuariosExDataset();
			System.Data.DataRow rowUsuarios = mz.erp.businessrules.sy_Usuarios.NewRow();
			data.sy_Usuarios.LoadDataRow(rowUsuarios.ItemArray,false);
			data.Merge(mz.erp.businessrules.sy_Perfiles.GetList());
			
			return data;
			
		}

		[ atMethodGetByPkRow ]
		public static sy_UsuariosExDataset GetByPk( object IdUsuario )
		{
			sy_UsuariosExDataset data = new sy_UsuariosExDataset();
			System.Data.DataRow rowUsuario = mz.erp.businessrules.sy_Usuarios.GetByPk( ( string )IdUsuario );
    		string IdUsu = (string)rowUsuario["IdUsuario"];
		
			data.sy_Usuarios.ImportRow(rowUsuario);
			System.Data.DataSet dataAux = mz.erp.businessrules.sy_PerfilesUsuariosEmpresas.GetList((string)rowUsuario["IdUsuario"],long.MinValue,Security.IdEmpresa);
			data.Merge(mz.erp.businessrules.sy_Perfiles.GetList());
			
			foreach(System.Data.DataRow row in dataAux.Tables[0].Rows)
				data.sy_PerfilesUsuariosEmpresas.ImportRow(row);

			tlg_ResponsablesDepositosSeccionesDataset dataRS = tlg_ResponsablesDepositosSecciones.GetList(IdUsu);
			data.Merge(dataRS);
			return data;
				
		}

		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( sy_UsuariosExDataset data )
		{
			ApplicationAssert.Check( data != null, "El argumento data  no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( data ) )
			{
				Update( data );
			}
		}

		public static bool RowIsValid( sy_UsuariosExDataset data )
		{
			System.Data.DataTable tableUsuarios = data.sy_Usuarios;
			System.Data.DataTable tablePefilesUsuarios = data.sy_PerfilesUsuariosEmpresas;
			bool ok = true;
			foreach(System.Data.DataRow row in tableUsuarios.Rows)
			{
				ok = ok && mz.erp.businessrules.sy_Usuarios.RowIsValid(row);
			}
			foreach(System.Data.DataRow row1 in tablePefilesUsuarios.Rows)
			{
				if (row1.RowState != System.Data.DataRowState.Deleted)
				{
					ok = ok && mz.erp.businessrules.sy_PerfilesUsuariosEmpresas.RowIsValid(row1);
				}				
			}
			return ok;
		}

		public static void Update( sy_UsuariosExDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_Usuarios.Rows.Count > 0, "La tabla dataSet.sy_UsuariosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			mz.erp.dataaccess.sy_UsuariosEx.Update(dataSet);
			
		}
	}
}
