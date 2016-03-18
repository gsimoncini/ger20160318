using System;

namespace mz.erp.businessrules.reportes
{
	/// <summary>
	/// Descripción breve de ReportParameterConfig.
	/// </summary>
	public class ReportParameterConfig:IComparable
	{
		private string _nombre;
		private string _decripcion;
		private string _tipoDeDato;
		private object _valorPorDefecto;
		private string _valor;	
		private int _orden;
		private bool _variableSistema;
		private ReportParameterControlType _controlUIType;

		public event EventHandler ValorPorDefectoChanged;


		public ReportParameterConfig()
		{
		}

		public bool VariableSistema
		{
			get
			{
				return _variableSistema;
			}
			set
			{
				_variableSistema = value;
			}
	

		}

		public ReportParameterControlType ControlUIType
		{
			get{return _controlUIType;}
			set{_controlUIType = value;}
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

		public object ValorPorDefecto
		{
			get{ return _valorPorDefecto; }
			set{ 
				
				
				if(!_valorPorDefecto.Equals(value))
				{
                    _valorPorDefecto = value; 
					if(ValorPorDefectoChanged != null)
						ValorPorDefectoChanged(this, new EventArgs());
				}
			
			}
		}

		public string Valor
		{
			get{ return _valor; }
			set
			{ 
				if(_valor != value)
				{
					if(this._tipoDeDato.Equals("Bit"))
					{
						if ( value.Equals("True") )
							{_valorPorDefecto = true;	}
						else	
							{_valorPorDefecto = false;}
					}
					else
						_valorPorDefecto = value;
					_valor= value; 
					
					
				}
			
			}
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
