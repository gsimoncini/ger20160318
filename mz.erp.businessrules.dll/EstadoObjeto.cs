using System;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Esta clase permite manejar una especie de máquina de estados, la cual dependiendo del estado del objeto, determina el comportamiento correspondiente.
	/// </summary>
	public class EstadoObjeto
	{
		public EstadoObjeto()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public EstadoObjeto(object objeto)
		{	
			this._objeto=objeto;
		
		}
	
	
		#region variables privadas
		
		 //El usuario lo selecciono , solo pasa a este estado si el objeto tenia estado previo Nothing
		 private static  string ESTADO_SELECCIONADO= "estado_seleccionado";
		//El usuario lo deselecciono, y el objeto estaba almacenado previamente, tenia estado persistido
		 private static string ESTADO_DESELECCIONADO= "estado_deseleccionado";
		//Esta almacenado en la bd
		 private static string ESTADO_PERSISTIDO= "estado_persistido";
		//Es el estado inicial del objeto, o aquel toma cuando se selecciona y deselecciona
		 private static string NOTHING= "sin_estado";
		 private string _estado= NOTHING;
		 private bool _activo=false;
		 private object _objeto;
		
		/*
		 * NOTHING->seleccionado=SELECCIONADO
		 * Este caso es porq asumo q todo lo q no se selecciona esta deseleccionado
		 * NOTHING->deseleccionado=NOTHING
		 * PERSISTIDO->seleccionado=PERSISTIDO
		 * PERSISTIDO->deseleccionado=DESELECCIONADO
		 * DESELECCIONADO->seleccionado=PERSISTIDO
		 * SELECCIONADO->deseleccionado=NOTHING
		 * Por tanto los nuevos son los seleccionados y los q no deberian estar son los deseleccionado
		 * */

		#endregion
		#region propiedades
	

		public object Objeto
		{
			get 
			{
				return _objeto;
			}
			set 
			{
				_objeto=value;
			}
		}
		public bool Activo
		{
			get 
			{
				return _activo;
			}
			set 
			{
				_activo=value;
			}
		}
		public string Estado
		{
			get 
			{
				return _estado;
			}
			
		}

		#endregion
		#region Metodos Publicos
		/*
		 * 
		 * HAY CASOS PRACTICOS QUE PUEDEN NO DARSE DEPENDIENDO DE Q SE ENTIENDE POR DESELECCIONAR, SI SE ENTIENDE Q SI EL OBJETO NO SE SELECCIONA ESTA DESELECCIONADO,
		 * O SI SOLO SE CONSIDERA QUE UN OBJETO SE DESELECCIONA SI EFECTIVAMENTE SE DESELECCIONO.
		 * */
		/// <summary>
		/// El objeto fue seleccionado, de acuerdo a su estado anterior, se determina el estado nuevo
		/// </summary>
		public void Seleccionar(){
			switch (_estado )
			{
				case "sin_estado": 
				{
					#region NOTHING:
						this._estado=ESTADO_SELECCIONADO;
						this._activo=true;
					break;
					#endregion
				}
				case "estado_persistido": 
				{
					#region PERSISTIDO:
						//QUEDA PERSISTIDO
					break;
					#endregion
				}
				case "estado_deseleccionado": 
				{
					#region DESELECCIONADO:
					  this._estado=ESTADO_PERSISTIDO;
					  this._activo=true;
					break;
					#endregion
				}
				case "estado_seleccionado": 
				{
					#region SELECCIONADO:
					//QUEDA SELECCIONADO
					break;
					#endregion
				}

			}
		
		}
		/// <summary>
		/// El objeto fue deseleccionado, de acuerdo a su estado anterior, se determina el estado nuevo
		/// </summary>
		public void Deseleccionar()
		{
			switch (_estado )
			{
				case "estado_persistido": 
				{
					#region ESTADO_PERSISTIDO:
					this._estado=ESTADO_DESELECCIONADO;
					this._activo=false;
					break;
					#endregion
				}
				case "estado_seleccionado": 
				{
					#region ESTADO_SELECCIONADO:
					this._estado=NOTHING;
					this._activo=false;
					break;
					#endregion
				}
				case "sin_estado": 
				{
					#region NOTHING:
					//QUEDA NOTHING
					break;
					#endregion
				}
				case "estado_deseleccionado": 
				{
					#region ESTADO_DESELECCIONADO:
					
					break;
					#endregion
				}
			}
		}
//Tiene q volver al objeto al estado anterior
		public void Deshacer(){
			switch (_estado )
			{
				case "estado_seleccionado": 
				{
					#region ESTADO_SELECCIONADO:
					this._estado=NOTHING;
					this._activo=false;
					break;
					#endregion
				}
				case "estado_deseleccionado": 
				{
					#region ESTADO_DESELECCIONADO:
					this._estado=ESTADO_PERSISTIDO;
					this._activo=true;
					break;
					#endregion
				}
			}
		
		}
		//Este metodo es para 'crear' los objetos q vienen de la bd, les cambia el estado por defecto,nothing.
		public void Persistir()
		{
			switch (_estado )
			{
				case "sin_estado": 
				{
					#region NOTHING:
					this._estado=ESTADO_PERSISTIDO;
					this._activo=true;
					break;
					#endregion
				}
			}	  
		}
		public bool EsPersistente()
		{
			return (this._estado==ESTADO_PERSISTIDO);
		
		}
		public bool EsNothing()
		{
			return (this._estado==NOTHING);
		
		}
		public bool EsSeleccionado()
		{
			return (this._estado==ESTADO_SELECCIONADO);
		
		}
		public bool EsDeseleccionado()
		{
			return (this._estado==ESTADO_DESELECCIONADO);
		
		}
		public override string ToString()
		{
			return this._objeto.ToString();
		}

		#endregion
	}
}
