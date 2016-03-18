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

	[ValueListGridAttributes("IdCaja",typeof(mz.erp.ui.forms.classes.tfi_Cajas),"IdCaja","Descripcion")] 
	[ValueListGridAttributes("IdResponsable",typeof(mz.erp.ui.forms.classes.sy_Usuarios),"IdUsuario","IdUsuario")] 
	public class tfi_ResponsablesCajas : IDisposable, IGridDocument
	{
		public tfi_ResponsablesCajas()
		{
		}

		public tfi_ResponsablesCajas( string[] fieldList )
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
			
			if ( fl.Contains( "IdCaja" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCaja", "Caja",250 ) );
			if ( fl.Contains( "IdResponsable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdResponsable", "Responsable",250 ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion",true ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion",true ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion",true ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion",true ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado",true ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId,",true ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa",true ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal",true ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			DataTable table =  mz.erp.businessrules.tfi_ResponsablesCajas.GetList().tfi_ResponsablesCajas;
			string PerfilesSuperiores = mz.erp.businessrules.Variables.GetValueString("Seguridad.Perfiles.PerfilesSuperiores");
			string IdCajaTemporalDefault = mz.erp.businessrules.Variables.GetValueString("Cajas.CajaTemporalDefault");
			ArrayList PerfilesSuperioresList = mz.erp.systemframework.Util.Parse(PerfilesSuperiores);
			DataTable tableUsuariosSegunPerfiles = mz.erp.businessrules.sy_Usuarios.GetUsuariosActivosSegunPerfiles(PerfilesSuperiores);
			ArrayList aux = new ArrayList();
			if(!PerfilesSuperioresList.Contains(mz.erp.businessrules.Security.IdPerfil.ToString()))
			{
				foreach(DataRow row in table.Rows)
				{
					if(Convert.ToString(row["IdCaja"]).Equals(IdCajaTemporalDefault))
					{
						aux.Add(row);
					}
					else
					{
						foreach(DataRow rowU in tableUsuariosSegunPerfiles.Rows)
						{
							if(Convert.ToString(rowU["IdUsuario"]).Equals(Convert.ToString(row["IdResponsable"])))
								aux.Add(row);
						}
					}
				}
				foreach(DataRow rowAux in aux)
				{
					table.Rows.Remove(rowAux);
				}
			}
			return table;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tfi_ResponsablesCajas.Update( ( tfi_ResponsablesCajasDataset.tfi_ResponsablesCajasDataTable )dataTable );
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

	/*	[ SearchMember( "tfi_ResponsablesCajas" ) ]
		public static DataSet GetList(  )
		{
			tfi_ResponsablesCajasDataset data = mz.erp.businessrules.tfi_ResponsablesCajas.GetList(  );
			return ( DataSet )data;
		}
		*/
		public void Dispose()
		{
		}
		
	}
}

