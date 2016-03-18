using System;
using System.Drawing;

namespace mz.erp.ui.controls
{
	/// <summary>
	/// Descripción breve de FormatoCondicional.
	/// </summary>
	public class FormatoCondicional
	{		
		private bool _visible = false;
		public bool Visible
		{
			set {_visible = value;}
			get {return _visible;}
		}

		private string _campo = "";
		public string Campo 
		{
			set {_campo = value;}
			get {return _campo;}
		}

		private string _condicion = "";
		public string Condicion
		{
			set {_condicion = value;}
			get {return _condicion;}
		}

		private string _valor = "";
		public string Valor
		{
			set {_valor = value;}
			get {return _valor;}
		}

		private System.Drawing.Color _color = Color.Black;
		public System.Drawing.Color Color
		{
			set {_color = value;}
			get {return _color;}
		}

		public FormatoCondicional()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public FormatoCondicional(bool Visible, string Campo, string Condicion, string Valor, System.Drawing.Color Color)
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			_visible = Visible;
			_campo = Campo;
			_condicion = Condicion;
			_valor = Valor;
			_color = Color;
		}


	}
}
