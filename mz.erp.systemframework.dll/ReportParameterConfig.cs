using System;

namespace mz.erp.systemframework
{
	/// <summary>
	/// Descripción breve de ReportParameterConfig.
	/// </summary>
	public class ReportParameterConfig:IComparable
	{
		private string _nombre;
		private string _decripcion;
		private string _tipoDeDato;
		private string _valorPorDefecto;
		private int _orden;

		public ReportParameterConfig()
		{
		}

		public string Nombre
		{
			get{ return _nombre; }
			set{ _nombre = value; }
		}


		public string Descripcion
		{
			get{ return _decripcion; }
			set{ _decripcion = value; }
		}

		public string TipoDeDato
		{
			get{ return _tipoDeDato; }
			set{ _tipoDeDato = value; }
		}

		public string ValorPorDefecto
		{
			get{ return _valorPorDefecto; }
			set{ _valorPorDefecto = value; }
		}

		public int Orden
		{
			get{return _orden;}
			set{_orden = value;}
		}

		#region Miembros de IComparable

		public int CompareTo( object obj )
		{
			return (this.Orden - ( ( ( ReportParameterConfig )obj ).Orden ));
		}

		#endregion
	}
}
