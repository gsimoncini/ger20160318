using System;
using System.Collections;
using System.Data;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de Contacto.
	/// </summary>
	public class Contacto
	{
 
		#region Constructores

		public Contacto(string idCuenta,string estado)			
		{
			_estado = estado;
			_idCuenta = idCuenta;
			_activo = true;
		}

		public Contacto(string idCuenta, string idPersona, string nombre, string telefonos, string email, string comentarios, string instantMesseger, bool activo, string estado)			
		{
			_estado = estado;
			_idCuenta = idCuenta;
			_idPersona = idPersona;
			_nombre = nombre;
			_telefonos = telefonos;
			_email = email;
			_comentarios = comentarios;
			_instantMesseger = instantMesseger;
			_activo = activo;

		}		

		public Contacto(DataRow row)			
		{
			_idCuenta = row["IdCuenta"].ToString();
			_idPersona = row["IdPersona"].ToString();
			if(row["IdTipoContacto"] != System.DBNull.Value)
				_idTipoContacto = Convert.ToInt64(row["IdTipoContacto"]);
			if(row["IdCargo"] != System.DBNull.Value)
                _idCargo = Convert.ToInt64(row["IdCargo"]);
			_observacionesContacto = row["ObservacionesContacto"].ToString();
            _nombre = row["Nombre"].ToString();
			_comentarios = row["Comentarios"].ToString();
			_telefonos = row["Telefonos"].ToString();
			_email = row["Email"].ToString();
			_instantMesseger = row["InstantMesseger"].ToString();
			_observacionesPersona = row["ObservacionesPersona"].ToString();
			_activo = Convert.ToBoolean(row["Activo"]);
			_descripcionTipoContacto = row["TipoDeContacto"].ToString();
			_descripcionCargo = row["Cargo"].ToString();
		}
		#endregion

		#region Variables Privadas
		//Datos de la tabla tsh_Contactos
		string _idCuenta = string.Empty;
		string _idPersona = string.Empty;
		long _idTipoContacto = long.MinValue;
		long _idCargo = long.MinValue;
		string _observacionesContacto = string.Empty;
		
		//Datos de la tabla tsh_Personas
		string _nombre = string.Empty;
		string _comentarios = string.Empty;
		string _telefonos = string.Empty;
		string _email = string.Empty;
		string _instantMesseger = string.Empty;
		string _observacionesPersona = string.Empty;
		bool _activo = false;

		//Datos de la tabla tcs_TiposContactos
		string _descripcionTipoContacto = string.Empty;

		//Datos de la tabla tcs_Cargos
        string _descripcionCargo = string.Empty;

		string _estado = string.Empty;


		#endregion

		#region Propiedades
		public string IdCuenta
		{
			get{return _idCuenta;}
		}

		public string IdPersona
		{
			get{return _idPersona;}
		}

		public long IdTipoContacto
		{
			get{return _idTipoContacto;}
			set{_idTipoContacto = value;}
		}
		
		public long IdCargo
		{
			get{return _idCargo;}
			set{_idCargo = value;}
		}
		
		public string Observaciones
		{
			get{return _observacionesContacto;}
			set{_observacionesContacto = value;}
		}
		
		public string Nombre
		{
			get{return _nombre;}
			set{_nombre = value;}
		}

		public string Comentarios
		{
			get{return _comentarios;}
			set{_comentarios = value;}
		}
		
		public string Telefonos
		{
			get{return _telefonos;}
			set{_telefonos = value;}
		}

		public string Email
		{
			get{return _email;}
			set{_email = value;}
		}

		public string InstantMesseger
		{
			get{return _instantMesseger;}
			set{_instantMesseger = value;}
		}

		public string ObservacionesPersona
		{
			get{return _observacionesPersona;}
		}

		public bool Activo
		{
			get{return _activo;}
			set{_activo = value;}
		}

		public string TipoDeContacto
		{
			get{return _descripcionTipoContacto;}
			set{_descripcionTipoContacto = value;}
		}

		public string Cargo
		{
			get{return _descripcionCargo;}
			set{_descripcionCargo = value;}
		}

		public string Estado
		{
			get{return _estado;}
			set{_estado = value;}
		}

		#endregion
	
		#region Métodos Públicos

		public tsa_CuentasExDataset Commit(mz.erp.commontypes.data.tsa_CuentasExDataset data)
		{
			
			
			switch(_estado)
			{
                    case "NEW": //Nuevo contacto
					{
						if(this.Nombre != null && this.Nombre != string.Empty)
						{
							tsa_CuentasExDataset.tsh_PersonasRow rowP = data.tsh_Personas.FindByIdPersona(this.IdPersona);
							if(rowP == null) //Agrego la persona
							{
								rowP = data.tsh_Personas.Newtsh_PersonasRow();
								rowP.IdPersona = systemframework.Util.NewStringId();
								rowP.Nombre = this.Nombre; 
								rowP.Comentarios = this.Comentarios;
								rowP.Telefonos = this.Telefonos;
								rowP.Email = this.Email;
								rowP.InstantMesseger = this.InstantMesseger;
								rowP.Activo = this.Activo;
								rowP.FechaCreacion = DateTime.Now;
								rowP.IdConexionCreacion = Security.IdConexion;
								rowP.IdReservado = 0;
								rowP.IdEmpresa = Security.IdEmpresa;			
								rowP.IdSucursal = Security.IdSucursal;
								data.tsh_Personas.Addtsh_PersonasRow(rowP);
							}

							//Agrego el contacto
							tsa_CuentasExDataset.tsh_ContactosRow rowC = data.tsh_Contactos.Newtsh_ContactosRow();
							rowC.IdCuenta = this.IdCuenta;
							rowC.IdPersona = rowP.IdPersona;
							if(this.IdTipoContacto.Equals(long.MinValue))
								rowC["IdTipoContacto"] = System.DBNull.Value;
							else 
								rowC["IdTipoContacto"] = this.IdTipoContacto;
							if(this.IdCargo.Equals(long.MinValue))
								rowC["IdCargo"] = System.DBNull.Value;
							else 
								rowC["IdCargo"] = this.IdCargo;
							rowC["Observaciones"] = this.Observaciones;
							rowC.FechaCreacion = DateTime.Now;
							rowC.IdConexionCreacion = Security.IdConexion;
							rowC.IdReservado = 0;
							rowC.IdEmpresa = Security.IdEmpresa;			
							data.tsh_Contactos.Addtsh_ContactosRow(rowC);
						}
						break;

					}
					case "MODIF": //Modificacion de contacto
					{
						DataRow rowP = mz.erp.businessrules.tsh_Personas.GetByPk(this.IdPersona);
						rowP["Nombre"] = this.Nombre;
						rowP["Telefonos"] = this.Telefonos;
						rowP["Email"] = this.Email;
						rowP["Comentarios"] = this.Comentarios;
						rowP["Activo"] = this.Activo;
						rowP["InstantMesseger"] = this.InstantMesseger;
						data.tsh_Personas.ImportRow(rowP);

						DataRow rowC = mz.erp.businessrules.tsh_Contactos.GetByPk(this.IdCuenta, this.IdPersona);
						if(this.IdTipoContacto.Equals(long.MinValue))
							rowC["IdTipoContacto"] = System.DBNull.Value;
						else 
							rowC["IdTipoContacto"] = this.IdTipoContacto;
						if(this.IdCargo.Equals(long.MinValue))
                            rowC["IdCargo"] = System.DBNull.Value;
						else 
							rowC["IdCargo"] = this.IdCargo;
						rowC["Observaciones"] = this.Observaciones;
						data.tsh_Contactos.ImportRow(rowC);

						break;
					}
					case "DEL": //Borrado de contacto
					{
						DataRow rowC = mz.erp.businessrules.tsh_Contactos.GetByPk(this.IdCuenta, this.IdPersona);
						rowC.Delete();
						data.tsh_Contactos.ImportRow(rowC);
						break;
					}

				case "ADD": //Agrega un contacto
				{
					DataRow rowP = data.tsh_Personas.FindByIdPersona(this.IdPersona);
					if(rowP == null)
					{
						rowP = mz.erp.businessrules.tsh_Personas.GetByPk(this.IdPersona);
						data.tsh_Personas.ImportRow(rowP);
					}					

					//Agrego el contacto
					tsa_CuentasExDataset.tsh_ContactosRow rowC = data.tsh_Contactos.Newtsh_ContactosRow();
					rowC.IdCuenta = this.IdCuenta;
					rowC.IdPersona = this.IdPersona;
					if(this.IdTipoContacto.Equals(long.MinValue))
						rowC["IdTipoContacto"] = System.DBNull.Value;
					else 
						rowC["IdTipoContacto"] = this.IdTipoContacto;
					if(this.IdCargo.Equals(long.MinValue))
						rowC["IdCargo"] = System.DBNull.Value;
					else 
						rowC["IdCargo"] = this.IdCargo;
					rowC["Observaciones"] = this.Observaciones;
					rowC.FechaCreacion = DateTime.Now;
					rowC.IdConexionCreacion = Security.IdConexion;
					rowC.IdReservado = 0;
					rowC.IdEmpresa = Security.IdEmpresa;			
					data.tsh_Contactos.Addtsh_ContactosRow(rowC);
					break;

				}

				    case "":
					   break;

			}
			return data;

		}


		#endregion

		#region Métodos Privados
		#endregion
	}
}
