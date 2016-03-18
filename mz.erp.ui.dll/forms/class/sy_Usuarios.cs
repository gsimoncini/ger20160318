namespace mz.erp.ui.forms.classes
{
	using System;
	using System.Data;
	using System.Text;    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using System.Collections;
	using mz.erp.ui.controls;
	using mz.erp.ui.controllers;

	public class sy_Usuarios : IDisposable, IGridDocument
	{
		public sy_Usuarios()
		{
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
		
		[ atMethodLayoutData ]
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

			if ( fl.Contains( "IdUsuario" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdUsuario", "Id. Usuario", false ) );
			if ( fl.Contains( "Nombre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Nombre", "Nombre",250, false) );
			/*if ( fl.Contains( "Comentarios" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Comentarios", "Comentarios",true ) );
			if ( fl.Contains( "Telefonos" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Telefonos", "Telefonos",150) );
			if ( fl.Contains( "Email" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Email", "Email",200 ) );
			if ( fl.Contains( "InstantMesseger" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "InstantMesseger", "InstantMesseger",200) );
			if ( fl.Contains( "Observaciones" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Observaciones", "Observaciones", true ));
			if ( fl.Contains( "Activo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo",true) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "Fecha de Creacion", true) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ,true) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "Ultima Modificacion",true) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion",true) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado",true ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId", true ) );
			if ( fl.Contains( "IdTratamiento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTratamiento", "Tratamiento",true) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "Empresa", true) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "Sucursal",true) );*/
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}

		[ValueListGridMember]
		public DataTable GetList()
		{
			string PerfilesSuperiores = mz.erp.businessrules.Variables.GetValueString("Seguridad.Perfiles.PerfilesSuperiores");
			ArrayList PerfilesSuperioresList = mz.erp.systemframework.Util.Parse(PerfilesSuperiores);
			if(!PerfilesSuperioresList.Contains(mz.erp.businessrules.Security.IdPerfil.ToString()))
			{
				return mz.erp.businessrules.sy_Usuarios.GetListActivos(PerfilesSuperiores).sy_Usuarios;
			}
			return mz.erp.businessrules.sy_Usuarios.GetListActivos();
		}

		[ SearchMember( "sy_Usuarios" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdUsuario",IsAlternativePrimaryKey= true ) ] string IdUsuario, 
			[ SearchParameterInfo( "Nombre", IsDescription= true ) ] string Nombre
		//	[ SearchParameterInfo( "Telefonos" ) ] string Telefonos
			)
		{			
			sy_UsuariosDataset data = mz.erp.businessrules.sy_Usuarios.GetList(IdUsuario, Nombre);
			return ( DataSet )data;
		}

		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.sy_Usuarios.Update( ( sy_UsuariosDataset.sy_UsuariosDataTable )dataTable );
		}
		
		public void Dispose()
		{
		}
		
	}
}

