using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Collections;
    
using mz.erp.dbhelper;
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;


namespace mz.erp.businessrules.data
{
	/// <summary>
	/// Descripción breve de UsuariosPersonas.
	/// </summary>
	public class UsuariosPersonas
	{
		#region dinamica
		
		#endregion
		public UsuariosPersonas()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		private string _idPersona = string.Empty;
		private string _idUsuario = string.Empty;
		private string _Nombre = string.Empty;
		public string IdPersona
		{
			get { return _idPersona ; }
			set { _idPersona = value; }
		}
		public string IdUsuario
		{
			get { return _idUsuario ; }
			set { _idUsuario = value ;}
		}
		public string Nombre
		{
			get { return _Nombre ; }
			set { _Nombre = value ; }
		}
		public static Hashtable GetPersonasHashTable()
		{
			Hashtable _hash = new Hashtable();
			DataTable _table = sy_Usuarios.UsuariosPersonasGetList().Tables[0];
			foreach(System.Data.DataRow _row in _table.Rows )
			{
				UsuariosPersonas up = new UsuariosPersonas();
				up.IdPersona = Convert.ToString( _row["IdPersona"] );
				up.IdUsuario = Convert.ToString( _row["IdUsuario"] );
				up.Nombre = Convert.ToString( _row["Nombre"] );
				_hash.Add( Convert.ToString(_row["IdUsuario"]) , up ) ;
			}
			return _hash;
		}
		
		public static DataSet GetPersonas(sy_UsuariosDataset usuarios) 
		{
			DataRow rowModelo = tsh_Personas.NewRow();
			DataSet data = new DataSet();
			data.Tables.Add("tsh_Personas"); //Lo llamo tsh_Personas para no tener problemas después cuando hago GetDescription en mzComboSearchEditor
			foreach (System.Data.DataColumn col in rowModelo.Table.Columns )
			{
				data.Tables[0].Columns.Add(col.ColumnName);
			}
			
			//data.Tables[0].Columns.Add(tsh_PersonasDataset.tsh_PersonasRow"Nombre");//.AddRange(rowModelo.Table.);
			
			tsh_Personas.NewRow();			

			foreach (sy_UsuariosDataset.sy_UsuariosRow rowUsuario in usuarios.sy_Usuarios.Rows)
			{
				string IdPersona = rowUsuario.IdPersona.ToString();
				tsh_PersonasDataset.tsh_PersonasRow rowPersona = tsh_Personas.NewRow();
				rowPersona = businessrules.tsh_Personas.GetByPk(IdPersona);

				data.Tables[0].ImportRow( (System.Data.DataRow)rowPersona );					
			}						
			return data;
		}	
	
		public static DataTable GetList()
		{
			DataTable usuarios = (DataTable) mz.erp.businessrules.sy_Usuarios.UsuariosPersonasGetList().Tables[0];			
			return usuarios;
			/*tsh_PersonasDataset data = new tsh_PersonasDataset();			
			DataTable personas = data.tsh_Personas;
			foreach (System.Data.DataRow _row in usuarios.Rows)
			{

				tsh_PersonasDataset.tsh_PersonasRow _personaRow = data.tsh_Personas.Newtsh_PersonasRow();
				_personaRow.Activo = Convert.ToBoolean(_row["Activo"]);
				_personaRow.Nombre = Convert.ToString( _row["Nombre"]);
				_personaRow.IdPersona = Convert.ToString( _row["IdPersona"]);
				
				personas.Rows.Add( _personaRow.ItemArray );

			}

			return personas;*/
			
			/*
			DataSet data = new DataSet();
			data.Tables.Add("tsh_Personas"); //Lo llamo tsh_Personas para no tener problemas después cuando hago GetDescription en mzComboSearchEditor
			foreach (System.Data.DataColumn col in rowModelo.Table.Columns )
			{
				data.Tables[0].Columns.Add(col.ColumnName);
			}
			*/

			/*sy_UsuariosDataset usuarios = mz.erp.businessrules.sy_Usuarios.GetList();
			tsh_PersonasDataset data = new tsh_PersonasDataset();
			tsh_PersonasDataset.tsh_PersonasDataTable table = data.tsh_Personas;
			foreach(System.Data.DataRow row in usuarios.sy_Usuarios.Rows)
			{
				string IdPersona = (string ) row["IdPersona"];
				if(IdPersona != string.Empty)
				{
					System.Data.DataRow rowPersona = mz.erp.businessrules.tsh_Personas.GetByPk(IdPersona);
					table.LoadDataRow(rowPersona.ItemArray, true);
				}
			}
			return table;*/
		}

        public static DataTable GetList(bool Activos)
        {
            DataTable usuarios = (DataTable)mz.erp.businessrules.sy_Usuarios.UsuariosPersonasGetList(Activos).Tables[0];
            return usuarios;
        }
	}
}
