using System;
using System.Collections;
using mz.erp.businessrules.comprobantes;
using mz.erp.commontypes.data;
using mz.erp.commontypes;
using mz.erp.systemframework;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de Herramienta.
	/// </summary>
	public class Herramienta
	{
		public Herramienta()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		private int _idHerramienta;
		private int _idHerramientaPadre;
		private string _id;
		private bool _habilitado;
		private ArrayList _recursos;
		private ArrayList _perfiles;
		private ArrayList _barraHerramientas;
		private string _shortcut;
	

	public int IdHerramienta
	{	
		get{return _idHerramienta;}
		set{_idHerramienta = value;}

	}
		public int IdHerramientaPadre
		{
			get{return _idHerramientaPadre;}
			set{_idHerramientaPadre = value;}
		}
		public string Id
		{
			get{return _id;}
			set{_id = value;}

		}
		public string ShortCut
		{
			get{return _shortcut;}
			set{_shortcut = value;}
		}

		public bool Habilitado
		{
			get {return _habilitado;}
			set{_habilitado = value;}
		}

		public ArrayList Recursos
		{
			get {return _recursos;}
			set {_recursos = value;}

		}

		public ArrayList Perfiles
		{
			get{return _perfiles;}
			set {_perfiles = value;}

		}

		public ArrayList BarraHerraminetas
		{
			get{return _barraHerramientas;}
			set{_barraHerramientas = value;}
		}

		public void AddPerfil(int IdPerfil)
		{
			this.Perfiles.Add(IdPerfil);
		}

		public void AddBarra(int IdBarra)
		{
			this.BarraHerraminetas.Add(IdBarra);
		}

		public void AddRecurso(int IdRecurso, string data)
		{
			this.Recursos.Add(Factory.GetRecurso(IdRecurso, data));
		}

		public void Commit()
		{
			sy_HerramientasExDataset data = new sy_HerramientasExDataset();
			sy_HerramientasDataset.sy_HerramientasRow row = sy_Herramientas.NewRow();
			row.IdHerramientaPadre = this.IdHerramientaPadre;
			row.Shortcut = this.ShortCut;
			row.Habilitado = this.Habilitado;
			row.Id= this.Id;
			row.IdHerramienta = Util.NewLongId();
		
			
			data.sy_Herramientas.Rows.Add(row.ItemArray);
			
			foreach(int IdPerfil in this.Perfiles)
			{
				sy_PerfilesHerramientasDataset.sy_PerfilesHerramientasRow rowPerfil = sy_PerfilesHerramientas.NewRow();
				rowPerfil.IdHerramienta = row.IdHerramienta;
				rowPerfil.IdPerfil = IdPerfil;
				data.sy_PerfilesHerramientas.Rows.Add(rowPerfil.ItemArray);
			}
			foreach(int IdBarra in this.BarraHerraminetas)
			{
				sy_BarrasHerramientasHerramientasDataset.sy_BarrasHerramientasHerramientasRow rowB = sy_BarrasHerramientasHerramientas.NewRow();
				rowB.IdBarraHerramienta = IdBarra;
				rowB.IdHerramienta = row.IdHerramienta;
				data.sy_BarrasHerramientasHerramientas.Rows.Add(rowB.ItemArray);

			}
			foreach(Recurso r in this.Recursos)
			{
				sy_RecursosDataset.sy_RecursosRow rowR = sy_Recursos.NewRow();
				rowR.IdRecurso = Util.NewLongId();
				rowR.IdTipoRecurso = r.IdTipoDeRecurso;
				rowR.Descripcion = r.Dato;
				data.sy_Recursos.Rows.Add(rowR.ItemArray);
				sy_HerramientasRecursosIdiomasDataset.sy_HerramientasRecursosIdiomasRow rowHRI = sy_HerramientasRecursosIdiomas.NewRow();
				rowHRI.IdHerramienta = row.IdHerramienta;
				rowHRI.IdRecurso = rowR.IdRecurso;
				//Ver el tema del idioma
				rowHRI.IdIdioma = 1;
				data.sy_HerramientasRecursosIdiomas.Rows.Add(rowHRI.ItemArray);
			}
			
			this.Flush(data);
		}
		
		public void Flush(sy_HerramientasExDataset data)
		{
			mz.erp.businessrules.sy_HerramientasEx.Update(data);

		}

		}
		
	}


