using System;
using System.Data;
using System.IO;
using mz.erp.businessrules.comprobantes;
using System.Collections;
using System.Data.SqlClient;
using mz.erp.dataaccess;
using mz.erp.commontypes.data;
using mz.erp.commontypes;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ConfigurarMenues.
	/// </summary>
	public class ConfigurarMenues: Agrupamientos, ITask, IPersistentTask
	{
		#region Constructores
		public ConfigurarMenues()
		{
			SetCombosData();
			InitializeDataMenues();
		}
		#endregion

		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;
		public event System.EventHandler OnTaskAfterPrevious;

		public void Previous()
		{
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
		}

		public bool AllowPrevious()
		{
			return true;
		}
		public void ListenerAfterPreviousDependentTask( object sender )
		{
		}
		public void ListenerBeforePreviousDependentTask( object sender )
		{
		}
			

		public void ListenerTaskDependentChanged(object sender)
		{
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.ListenerTaskDependentChanged
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.ListenerBeforeExecuteDependentTask
		}

		private ArrayList _perfilesSuperioresList = new ArrayList();

		public void Init()
		{
			string orden = Variables.GetValueString("Sistema.Configuracion.Menu.OrdenMinimo");
			_nombreArchivo = Variables.GetValueString("Sistema.Configuracion.Menu.NombreArchivo");
			if(!orden.Equals(string.Empty))
                _ordenMinimoMenu = Convert.ToInt16(orden);
			_perfilSuperior = mz.erp.businessrules.Security.PerteneceAPerfilSuperior;
			string perfilesSuperiores = Variables.GetValueString("Seguridad.Perfiles.PerfilesSuperiores");
			_perfilesSuperioresList = mz.erp.systemframework.Util.Parse(perfilesSuperiores,",");
			_preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar");
		}
		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
		}

		public override bool IsValid()
		{
			ValidarDatos();
			if (_errores.Count > 0)
				return false;
			else
				return true;
		}

		public bool AllowShow() 
		{
			return true;
		}
		public void FormHasClosed() 
		{
		}
		public ItemsDatasetErrors GetErrors()
		{
			return _errores;			
		}

		public string GetWarnings()
		{
			return null;			
		}

		public ProcessManager GetProcessManagerParent()
		{
			return _processParent;
		}

		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_processParent = processManager;
		}

		public string GetTaskName()
		{
			return _taskName;
		}

		public void SetTaskName(string taskName)
		{
			_taskName = taskName;
		}

		public void Execute()
		{
			if(OnTaskBeforeExecute != null)
				OnTaskBeforeExecute(this, new EventArgs());			

			this.IsValid();

			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}


		#endregion

		#region Miembros de IPersistentTask
		public event System.EventHandler OnTaskBeforeFlush;
		public event System.EventHandler OnTaskAfterFlush;

		public override void Commit() 
		{						
			_data = new sy_HerramientasExDataset();
			foreach(HerramientaEx hm in _herramientasExModificadas)
			{
				switch(hm.Modo)
				{				
					case "MODIF"://Modificacion de Menu
					{
						#region MODIF
						sy_HerramientasDataset.sy_HerramientasRow rowHerramienta = sy_Herramientas.GetByPk(hm.IdHerramienta);
						rowHerramienta.orden = hm.Orden;
						rowHerramienta.Habilitado = hm.Habilitado;
						if (hm.IdHerramientaPadre <= 0)
							rowHerramienta.SetIdHerramientaPadreNull();
						else
							rowHerramienta.IdHerramientaPadre = hm.IdHerramientaPadre;
						if(hm.ShortCut.Equals("None"))
							rowHerramienta.Shortcut = null;
						else
                            rowHerramienta.Shortcut = hm.ShortCut;
						_data.sy_Herramientas.ImportRow(rowHerramienta);

						if(_data.sy_Recursos.FindByIdRecurso(hm.IdRecurso) == null)
						{
							sy_RecursosDataset.sy_RecursosRow rowRecurso = sy_Recursos.GetByPk(hm.IdRecurso);
							rowRecurso.Descripcion = hm.Descripcion;
							_data.sy_Recursos.ImportRow(rowRecurso);
						}
						else
							throw new Exception("No se puede insertar la herramienta, el recurso " + hm.IdRecurso + " esta duplicado");
						

						foreach (PerfilView perfil in hm.PerfilesHerramientas)
						{
							sy_PerfilesHerramientasDataset.sy_PerfilesHerramientasRow rowPerfil = sy_PerfilesHerramientas.GetByPk(perfil.IdPerfil, hm.IdHerramienta);
							if(rowPerfil == null) // No existe la fila
							{
								sy_HerramientasExDataset.sy_PerfilesHerramientasRow rowP = _data.sy_PerfilesHerramientas.Newsy_PerfilesHerramientasRow();
								rowP.IdPerfil = perfil.IdPerfil;
								rowP.IdHerramienta = hm.IdHerramienta;
								rowP.FechaCreacion = DateTime.Now;
								rowP.IdConexionCreacion = Security.IdConexion;
								rowP.Visible = isVisible(perfil);
								_data.sy_PerfilesHerramientas.Addsy_PerfilesHerramientasRow(rowP);
							}
							else
							{
								bool visiblePerfil = isVisible(perfil);
								if(rowPerfil.Visible != visiblePerfil)
								{
									rowPerfil.Visible = visiblePerfil;
									_data.sy_PerfilesHerramientas.ImportRow(rowPerfil);
								}
							}
						}

						DataSet dataPerfilesHerramientas = sy_PerfilesHerramientas.GetListPerfilesFor(hm.IdHerramienta);
						DataTable tablePerfilesHerramientas = dataPerfilesHerramientas.Tables[1];
						foreach(DataRow row in tablePerfilesHerramientas.Rows)
						{
							long idPerfil = (long)row["IdPerfil"];
							PerfilView perfV = new PerfilView(idPerfil, string.Empty);
							if(!hm.PerfilesHerramientas.Contains(perfV))
							{
								sy_PerfilesHerramientasDataset.sy_PerfilesHerramientasRow rowPerfil = sy_PerfilesHerramientas.GetByPk(idPerfil, hm.IdHerramienta);
								rowPerfil.Delete();
								_data.sy_PerfilesHerramientas.ImportRow(rowPerfil);
							}

						}

						businessrules.HerramientaEx ImagenHerramienta = this.GetHerramienta(hm.IdHerramienta.ToString(), ID_TIPO_RECURSO_IMAGEN);
						if(ImagenHerramienta == null && !hm.Imagen.Equals("None")) //si le agrego una imagen
						{
							sy_HerramientasExDataset.sy_RecursosRow rowR = _data.sy_Recursos.Newsy_RecursosRow();
							rowR.IdRecurso = systemframework.Util.NewLongId();
							rowR.Descripcion = hm.Imagen;
							rowR.IdTipoRecurso = ID_TIPO_RECURSO_IMAGEN;
							rowR.FechaCreacion = DateTime.Now;
							rowR.IdConexionCreacion = Security.IdConexion;
							_data.sy_Recursos.Addsy_RecursosRow(rowR);

							sy_HerramientasExDataset.sy_HerramientasRecursosIdiomasRow rowHR = _data.sy_HerramientasRecursosIdiomas.Newsy_HerramientasRecursosIdiomasRow();
							rowHR.IdHerramienta = hm.IdHerramienta;
							rowHR.IdRecurso = rowR.IdRecurso;
							rowHR.IdIdioma = 1;
							rowHR.FechaCreacion = DateTime.Now;
							rowHR.IdConexionCreacion = Security.IdConexion;
							_data.sy_HerramientasRecursosIdiomas.Addsy_HerramientasRecursosIdiomasRow(rowHR);

						}
						else if(ImagenHerramienta != null)
						{
							if(hm.Imagen.Equals("None"))//si le borro la imagen
							{
								sy_RecursosDataset.sy_RecursosRow rowRecursoImagen = sy_Recursos.GetByPk(ImagenHerramienta.IdRecurso);
								rowRecursoImagen.Delete();
								
								if(_data.sy_Recursos.FindByIdRecurso(rowRecursoImagen.IdRecurso) == null)
								{
									_data.sy_Recursos.ImportRow(rowRecursoImagen);
								}
								else
									throw new Exception("No se puede insertar la herramienta, el recurso " + hm.IdRecurso + " esta duplicado");

								sy_HerramientasRecursosIdiomasDataset.sy_HerramientasRecursosIdiomasRow rowHerramientaRecursoImagen = sy_HerramientasRecursosIdiomas.GetByPk(ImagenHerramienta.IdHerramienta, ImagenHerramienta.IdRecurso, 1);
								rowHerramientaRecursoImagen.Delete();
								_data.sy_HerramientasRecursosIdiomas.ImportRow(rowHerramientaRecursoImagen);
							}
							else//si le modifico la imagen
							{
								sy_RecursosDataset.sy_RecursosRow rowRecursoImagen = sy_Recursos.GetByPk(ImagenHerramienta.IdRecurso);
								rowRecursoImagen.Descripcion = hm.Imagen;

															
								if(_data.sy_Recursos.FindByIdRecurso(rowRecursoImagen.IdRecurso) == null)
								{
									_data.sy_Recursos.ImportRow(rowRecursoImagen);
								}
								else
									throw new Exception("No se puede insertar la herramienta, el recurso " + hm.IdRecurso + " esta duplicado");

							}

						}

						break;	
						#endregion
					}
					case "DEL"://Borra Separador
					{
						#region DEL

						sy_HerramientasRecursosIdiomasDataset.sy_HerramientasRecursosIdiomasRow rowHR = sy_HerramientasRecursosIdiomas.GetByPk(hm.IdHerramienta, hm.IdRecurso, 1);
						rowHR.Delete();
						_data.sy_HerramientasRecursosIdiomas.ImportRow(rowHR);

						sy_RecursosDataset.sy_RecursosRow rowRecurso = sy_Recursos.GetByPk(hm.IdRecurso);
						rowRecurso.Delete();
													
						/*if(_data.sy_Recursos.FindByIdRecurso(rowRecurso.IdRecurso) == null)
						{
							_data.sy_Recursos.ImportRow(rowRecurso);
						}
						else
							throw new Exception("No se puede insertar la herramienta, el recurso " + hm.IdRecurso + " esta duplicado");
						*/
						break;	

						#endregion
					}
					case "ADD"://Agrega un Submenu
					{
						#region ADD

						sy_HerramientasExDataset.sy_HerramientasRow rowHerramienta = _data.sy_Herramientas.Newsy_HerramientasRow();

						mz.erp.businessrules.sy_Herramientas.SetRowDefaultValues(rowHerramienta);

						rowHerramienta.Id = hm.Id;
						rowHerramienta.SetordenNull();
						rowHerramienta.Habilitado = hm.Habilitado;
						if (hm.IdHerramientaPadre <= 0)
							rowHerramienta.SetIdHerramientaPadreNull();
						else
							rowHerramienta.IdHerramientaPadre = hm.IdHerramientaPadre;
						if(hm.ShortCut.Equals("None"))
							rowHerramienta.Shortcut = null;
						else
							rowHerramienta.Shortcut = hm.ShortCut;
                        //German 20110318 - Tarea 0000091
                        rowHerramienta.IdHerramienta = hm.IdHerramienta;
                        //Fin German 20110318 - Tarea 0000091
						_data.sy_Herramientas.Rows.Add(rowHerramienta);

						sy_HerramientasExDataset.sy_BarrasHerramientasHerramientasRow rowBarraHerramienta = _data.sy_BarrasHerramientasHerramientas.Newsy_BarrasHerramientasHerramientasRow();
						mz.erp.businessrules.sy_BarrasHerramientasHerramientas.SetRowDefaultValues(rowBarraHerramienta);

						rowBarraHerramienta.IdBarraHerramienta = hm.IdBarraHerramienta;
						rowBarraHerramienta.IdHerramienta = hm.IdHerramienta;
						_data.sy_BarrasHerramientasHerramientas.Rows.Add(rowBarraHerramienta);

						sy_HerramientasExDataset.sy_RecursosRow rowRecurso = _data.sy_Recursos.Newsy_RecursosRow();
						mz.erp.businessrules.sy_Recursos.SetRowDefaultValues(rowRecurso);


                        //German 20110318 - Tarea 0000091
                        rowRecurso.IdRecurso = systemframework.Util.NewLongId();
                        //Fin German 20110318 - Tarea 0000091

						rowRecurso.Descripcion = hm.Descripcion;
						rowRecurso.IdTipoRecurso = hm.IdTipoRecurso;
						_data.sy_Recursos.Rows.Add(rowRecurso);

						sy_HerramientasExDataset.sy_HerramientasRecursosIdiomasRow rowHRI = _data.sy_HerramientasRecursosIdiomas.Newsy_HerramientasRecursosIdiomasRow();
						mz.erp.businessrules.sy_HerramientasRecursosIdiomas.SetRowDefaultValues(rowHRI);
						rowHRI.IdHerramienta = hm.IdHerramienta;
						rowHRI.IdRecurso = rowRecurso.IdRecurso;
						rowHRI.IdIdioma = 1;
						rowHRI.FechaCreacion = DateTime.Now;
						rowHRI.IdConexionCreacion = Security.IdConexion;
						_data.sy_HerramientasRecursosIdiomas.Addsy_HerramientasRecursosIdiomasRow(rowHRI);

						foreach (string perfil in hm.PerfilesHerramientas)
						{
							sy_HerramientasExDataset.sy_PerfilesHerramientasRow rowP = _data.sy_PerfilesHerramientas.Newsy_PerfilesHerramientasRow();
							rowP.IdPerfil = Convert.ToInt32(perfil);
							rowP.IdHerramienta = hm.IdHerramienta;
							rowP.FechaCreacion = DateTime.Now;
							rowP.IdConexionCreacion = Security.IdConexion;
							rowP.Visible = true;
							_data.sy_PerfilesHerramientas.Addsy_PerfilesHerramientasRow(rowP);							
						}

						//businessrules.HerramientaEx ImagenHerramienta = this.GetHerramienta(hm.IdHerramienta.ToString(), ID_TIPO_RECURSO_IMAGEN);
						if(!hm.Imagen.Equals("None")) //si le agrego una imagen
						{
							sy_HerramientasExDataset.sy_RecursosRow rowR = _data.sy_Recursos.Newsy_RecursosRow();
							mz.erp.businessrules.sy_Recursos.SetRowDefaultValues(rowR);
							rowR.IdRecurso = systemframework.Util.NewLongId();
							rowR.Descripcion = hm.Imagen;
							rowR.IdTipoRecurso = ID_TIPO_RECURSO_IMAGEN;
							rowR.FechaCreacion = DateTime.Now;
							rowR.IdConexionCreacion = Security.IdConexion;
							_data.sy_Recursos.Addsy_RecursosRow(rowR);

							sy_HerramientasExDataset.sy_HerramientasRecursosIdiomasRow rowHR = _data.sy_HerramientasRecursosIdiomas.Newsy_HerramientasRecursosIdiomasRow();
							mz.erp.businessrules.sy_HerramientasRecursosIdiomas.SetRowDefaultValues(rowHR);
							rowHR.IdHerramienta = hm.IdHerramienta;
							rowHR.IdRecurso = rowR.IdRecurso;
							rowHR.IdIdioma = 1;
							rowHR.FechaCreacion = DateTime.Now;
							rowHR.IdConexionCreacion = Security.IdConexion;
							_data.sy_HerramientasRecursosIdiomas.Addsy_HerramientasRecursosIdiomasRow(rowHR);

						}
						break;	
						#endregion
					}
					case "ADD_ESTANDAR": //Agrega una herramienta en la Barra Estandar
					{
						#region ADD_ESTANDAR

						sy_HerramientasDataset.sy_HerramientasRow rowHerramienta = sy_Herramientas.GetByPk(hm.IdHerramienta);

						if(rowHerramienta.Shortcut.Equals(string.Empty))
							rowHerramienta.Shortcut = null;
						else
							rowHerramienta.Shortcut = hm.ShortCut;

						_data.sy_Herramientas.ImportRow(rowHerramienta);

						sy_HerramientasExDataset.sy_BarrasHerramientasHerramientasRow rowBarraHerramienta = _data.sy_BarrasHerramientasHerramientas.Newsy_BarrasHerramientasHerramientasRow();
						mz.erp.businessrules.sy_BarrasHerramientasHerramientas.SetRowDefaultValues(rowBarraHerramienta);

						rowBarraHerramienta.IdBarraHerramienta = hm.IdBarraHerramienta;
						rowBarraHerramienta.IdHerramienta = hm.IdHerramienta;

						_data.sy_BarrasHerramientasHerramientas.Rows.Add(rowBarraHerramienta);

						break;	
						#endregion
					}
					case "ADD_EXPLORACION": //Agrega una herramienta en la Barra de Exploración
					{
						#region ADD_EXPLORACION
						sy_HerramientasExDataset.sy_HerramientasRow rowHerramienta = _data.sy_Herramientas.Newsy_HerramientasRow();

						mz.erp.businessrules.sy_Herramientas.SetRowDefaultValues(rowHerramienta);

						rowHerramienta.Id = hm.Id;
						rowHerramienta.SetordenNull();
						rowHerramienta.Habilitado = hm.Habilitado;
						if (hm.IdHerramientaPadre <= 0)
							rowHerramienta.SetIdHerramientaPadreNull();
						else
							rowHerramienta.IdHerramientaPadre = hm.IdHerramientaPadre;
						if(hm.ShortCut.Equals("None"))
							rowHerramienta.Shortcut = null;
						else
							rowHerramienta.Shortcut = hm.ShortCut;
						_data.sy_Herramientas.Rows.Add(rowHerramienta);

						sy_HerramientasExDataset.sy_BarrasHerramientasHerramientasRow rowBarraHerramienta = _data.sy_BarrasHerramientasHerramientas.Newsy_BarrasHerramientasHerramientasRow();
						mz.erp.businessrules.sy_BarrasHerramientasHerramientas.SetRowDefaultValues(rowBarraHerramienta);

						rowBarraHerramienta.IdBarraHerramienta = hm.IdBarraHerramienta;
						rowBarraHerramienta.IdHerramienta = hm.IdHerramienta;
						_data.sy_BarrasHerramientasHerramientas.Rows.Add(rowBarraHerramienta);

						sy_HerramientasExDataset.sy_RecursosRow rowRecurso = _data.sy_Recursos.Newsy_RecursosRow();
						mz.erp.businessrules.sy_Recursos.SetRowDefaultValues(rowRecurso);

						rowRecurso.Descripcion = hm.Descripcion;
						rowRecurso.IdTipoRecurso = hm.IdTipoRecurso;
						_data.sy_Recursos.Rows.Add(rowRecurso);

						sy_HerramientasExDataset.sy_HerramientasRecursosIdiomasRow rowHRI = _data.sy_HerramientasRecursosIdiomas.Newsy_HerramientasRecursosIdiomasRow();
						mz.erp.businessrules.sy_HerramientasRecursosIdiomas.SetRowDefaultValues(rowHRI);
						rowHRI.IdHerramienta = hm.IdHerramienta;
						rowHRI.IdRecurso = rowRecurso.IdRecurso;
						rowHRI.IdIdioma = 1;
						rowHRI.FechaCreacion = DateTime.Now;
						rowHRI.IdConexionCreacion = Security.IdConexion;
						_data.sy_HerramientasRecursosIdiomas.Addsy_HerramientasRecursosIdiomasRow(rowHRI);

						foreach (PerfilView perfil in hm.PerfilesHerramientas)
						{
							sy_HerramientasExDataset.sy_PerfilesHerramientasRow rowP = _data.sy_PerfilesHerramientas.Newsy_PerfilesHerramientasRow();
							rowP.IdPerfil = Convert.ToInt32(perfil.IdPerfil);
							rowP.IdHerramienta = hm.IdHerramienta;
							rowP.FechaCreacion = DateTime.Now;
							rowP.IdConexionCreacion = Security.IdConexion;
							rowP.Visible = true;
							_data.sy_PerfilesHerramientas.Addsy_PerfilesHerramientasRow(rowP);							
						}

						if(!hm.Imagen.Equals("None")) //si le agrego una imagen
						{
							sy_HerramientasExDataset.sy_RecursosRow rowR = _data.sy_Recursos.Newsy_RecursosRow();
							mz.erp.businessrules.sy_Recursos.SetRowDefaultValues(rowR);
							rowR.IdRecurso = systemframework.Util.NewLongId();
							rowR.Descripcion = hm.Imagen;
							rowR.IdTipoRecurso = ID_TIPO_RECURSO_IMAGEN;
							rowR.FechaCreacion = DateTime.Now;
							rowR.IdConexionCreacion = Security.IdConexion;
							_data.sy_Recursos.Addsy_RecursosRow(rowR);

							sy_HerramientasExDataset.sy_HerramientasRecursosIdiomasRow rowHR = _data.sy_HerramientasRecursosIdiomas.Newsy_HerramientasRecursosIdiomasRow();
							mz.erp.businessrules.sy_HerramientasRecursosIdiomas.SetRowDefaultValues(rowHR);
							rowHR.IdHerramienta = hm.IdHerramienta;
							rowHR.IdRecurso = rowR.IdRecurso;
							rowHR.IdIdioma = 1;
							rowHR.FechaCreacion = DateTime.Now;
							rowHR.IdConexionCreacion = Security.IdConexion;
							_data.sy_HerramientasRecursosIdiomas.Addsy_HerramientasRecursosIdiomasRow(rowHR);

						}

						break;
						#endregion
					}
					case "REMOVE_ESTANDAR": //Elimina una herramienta de la Barra Estandar
					{
						#region REMOVE_ESTANDAR

						sy_BarrasHerramientasHerramientasDataset.sy_BarrasHerramientasHerramientasRow rowBarraHerramienta = sy_BarrasHerramientasHerramientas.GetByPk(hm.IdBarraHerramienta,hm.IdHerramienta);
						rowBarraHerramienta.Delete();
						_data.sy_BarrasHerramientasHerramientas.ImportRow(rowBarraHerramienta);
						break;

						#endregion
					}
					case "REMOVE_EXPLORACION": //Elimina una herramienta de la Barra de Exploración
					{
						#region REMOVE_EXPLORACION

						sy_HerramientasDataset.sy_HerramientasRow rowHerramienta = sy_Herramientas.GetByPk(hm.IdHerramienta);
						rowHerramienta.Delete();
						_data.sy_Herramientas.ImportRow(rowHerramienta);

						sy_BarrasHerramientasHerramientasDataset.sy_BarrasHerramientasHerramientasRow rowBarraHerramienta = sy_BarrasHerramientasHerramientas.GetByPk(hm.IdBarraHerramienta,hm.IdHerramienta);
						rowBarraHerramienta.Delete();
						_data.sy_BarrasHerramientasHerramientas.ImportRow(rowBarraHerramienta);

						sy_RecursosDataset dataRecursos = sy_Recursos.GetList(1,hm.IdHerramienta);
						foreach (DataRow rowRecurso in dataRecursos.sy_Recursos.Rows)
						{
							long idRecurso = Convert.ToInt16(rowRecurso["IdRecurso"].ToString());
							sy_HerramientasRecursosIdiomasDataset.sy_HerramientasRecursosIdiomasRow rowRecursoIdioma = sy_HerramientasRecursosIdiomas.GetByPk(hm.IdHerramienta,idRecurso,1);
							rowRecursoIdioma.Delete();	
							_data.sy_HerramientasRecursosIdiomas.ImportRow(rowRecursoIdioma);
							rowRecurso.Delete();			
				
														
							if(_data.sy_Recursos.FindByIdRecurso(idRecurso) == null)
							{
								_data.sy_Recursos.ImportRow(rowRecurso);
							}
							else
								throw new Exception("No se puede insertar la herramienta, el recurso " + hm.IdRecurso + " esta duplicado");

						}

						DataSet data = sy_PerfilesHerramientas.GetListPerfilesFor(hm.IdHerramienta);
						foreach (DataRow row in data.Tables["sy_Perfiles"].Rows)
						{
							row.Delete();
						}
					
						_data.Merge(data.Tables["sy_Perfiles"]);

						break;

						#endregion
					}
				}


			}
		}

		private mz.erp.commontypes.SentenciasReplicacion _replication;
		public override mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			return _replication;
		}

		private mz.erp.commontypes.SentenciasReplicacion GenerateReplication()
		{
			mz.erp.commontypes.SentenciasReplicacion replication = new mz.erp.commontypes.SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.sy_Herramientas";		
			return replication;
		}

		private bool _hasSaved = false;
		public bool GetHasSaved()
		{
			return _hasSaved;
		}
			 
		public void PutExtraData( ProcessCollectionData _processCollectionData )
		{

		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			
		}

		public ArrayList GetDataList()
		{
			ArrayList array = new ArrayList();			
			return array;
		}
		public override TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();			
			return data;
		}

		/// <summary>
		/// Envia el dataset e información adicional a la capa de acceso a datos para ejecutar la grabación de datos
		/// en el RDBM.
		/// </summary>
		public override void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());

			_replication = GenerateReplication();

			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			dataaccess.sy_HerramientasEx.Update(_data,_replication);
			foreach(HerramientaEx hm in _herramientasExModificadas)
			{
				if(hm.Modo.Equals("NEW")) //Agrega Separador
					sy_Herramientas.AddSeparator(hm.Id, hm.IdHerramientaPadre);

			}
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());

			System.Text.StringBuilder _sentencia = _replication.Sentence;
			if (_sentencia != null)
			{
				//Armar el archivo
				string path = string.Format(mz.erp.systemframework.Util.ResourcePath() + "\\resources\\" + _nombreArchivo + ".sql");
				FileInfo file = new FileInfo(path);
				StreamWriter debugWriter = new StreamWriter( file.Open( FileMode.Append, FileAccess.Write, FileShare.ReadWrite ),System.Text.Encoding.Unicode );
				debugWriter.WriteLine(_sentencia.ToString());
				debugWriter.Flush();
			}
		}
		
		#endregion

		#region Variables privadas
		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;		
		private Hashtable _barrasDeHerramientas = new Hashtable();
		private Hashtable _barrasDeHerramientasNuevas = new Hashtable();
		private long _idBarraDeHerramientaSeleccionada = 1;
		private sy_HerramientasExDataset _data = new sy_HerramientasExDataset();
		private short _ordenMinimoMenu = 1000;//-100;
		private string _nombreArchivo = string.Empty;
		private Hashtable _ordenMaximo = new Hashtable();

		#endregion

		#region Variables Publicas
		public const long ID_TIPO_RECURSO_TITULO = 1;
		public const long ID_TIPO_RECURSO_IMAGEN = 4;
		public const long ID_TIPO_RECURSO_SEPARATOR = 7;
		#endregion

		#region Eventos y Delegados
		public event System.EventHandler HerramientasExModificadasHasChanged;
		#endregion

		#region Propiedades
		private string _textoBotonAnterior = "Anterior";
		public string TextoBotonAnterior
		{
			get 
			{
				string valor = String.Empty;
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonAnterior";
				valor = Variables.GetValueString(variable);
				if (valor == String.Empty)
				{
					variable = "Sistema.Interfaz.TextoBotonAnterior";
					valor = Variables.GetValueString(variable);				
				}				
				if (valor == String.Empty) 
				{
					return _textoBotonAnterior;
				}
				else 
				{
					return valor;
				}							
			}
		}
		private string _textoBotonSiguiente = "Siguiente";
		public string TextoBotonSiguiente
		{
			get 
			{		
				string valor = String.Empty;				
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonSiguiente";
				valor = Variables.GetValueString(variable);
				if (valor == String.Empty)
				{
					variable = "Sistema.Interfaz.TextoBotonSiguiente";
					valor = Variables.GetValueString(variable);				
				}				
				if (valor == String.Empty) 
				{
					return _textoBotonSiguiente;
				}
				else 
				{
					return valor;
				}
			}
		}

		private string _leyendaFormulario = "Configuración de Menues";
		public string LeyendaFormulario
		{
			get 
			{		
				string valor = String.Empty;				
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "LeyendaFormulario";
				valor = Variables.GetValueString(variable);
				
				if (valor == String.Empty) 
				{
					return _leyendaFormulario;
				}
				else 
				{
					return valor;
				}
			}
		}

		private bool _preguntarAlCancelar = false;
		public bool PreguntarAlCancelar
		{
			get {return _preguntarAlCancelar ;}
		}

		private bool _perfilSuperior;
		public bool PerfilSuperior
		{
			get 
			{
				return _perfilSuperior;
			}
		}

		ArrayList _perfiles = new ArrayList();
		public ArrayList Perfiles
		{
			get 
			{
				_perfiles.Clear();
				DataTable perfilesDT = sy_Perfiles.GetList().sy_Perfiles;
				foreach (System.Data.DataRow row in perfilesDT.Rows)
				{
					long id = (long)row["IdPerfil"];
					string descripcion = row["Descripcion"].ToString();
					PerfilView perfil = new PerfilView(id, descripcion);
					_perfiles.Add(perfil);
				}
				return _perfiles;
			}
		}

		ArrayList _perfilesSeleccionados = new ArrayList();
		public ArrayList PerfilesSeleccionados
		{
			set 
			{
				_perfilesSeleccionados = value;
			}
		}

		public ArrayList BarrasDeHerramientas
		{
			get 
			{
				return new ArrayList(_barrasDeHerramientas.Keys);
			}
		}

		public ArrayList BarrasDeHerramientasNuevas
		{
			get 
			{
				return new ArrayList(_barrasDeHerramientasNuevas.Keys);
			}
		}

		private string _barraHerramientaSeleccionada = "Menú principal";
		public string BarraHerramientaSeleccionada
		{
			get 
			{
				return _barraHerramientaSeleccionada;
			}

			set 
			{
				if(!_barraHerramientaSeleccionada.Equals(value))
				{
					_barraHerramientaSeleccionada = value;
					_idBarraDeHerramientaSeleccionada = Convert.ToInt64(_barrasDeHerramientas[value]);
				}
			}
		}

		public long IdBarraDeHerramientaSeleccionada
		{
			get 
			{
				return _idBarraDeHerramientaSeleccionada;
			}

		}

		private System.Collections.ArrayList _herramientasEx = new ArrayList();
		public System.Collections.ArrayList HerramientasEx()
		{
			return _herramientasEx;
		}

		private System.Collections.ArrayList _herramientasExModificadas = new ArrayList();
		public System.Collections.ArrayList HerramientasExModificadas()
		{
			return _herramientasExModificadas;
		}

		private HerramientaEx _herramientaModificada = null;
		public HerramientaEx HerramientaModificada()
		{
			return _herramientaModificada;
		}

		private long _currentIdProcess;
		public long CurrentIdProcess
		{
			get {return _currentIdProcess;}
			set 
			{
				_currentIdProcess = value;
			}
		}

		private string _currentDescriptionProcess = string.Empty;
		public string CurrentDescriptionProcess
		{
			get {return _currentDescriptionProcess;}
			set 
			{
				_currentDescriptionProcess = value;
			}
		}

		/*private string _id = string.Empty;
		public string Id
		{
			get {return _id;}
			set 
			{
				_id = value;
			}
		}

		private long _idHerramientaPadre;
		public long IdHerramientaPadre
		{
			get {return _idHerramientaPadre;}
			set 
			{
				_idHerramientaPadre = value;
			}
		}

		private string _herramientaPadre = string.Empty;
		public string HerramientaPadre
		{
			get {return _herramientaPadre;}
			set 
			{
				_herramientaPadre = value;
			}
		}*/

		#endregion

		#region Métodos públicos

		public HerramientaEx GetHerramienta(string IdHerramienta, long IdTipoRecurso)
		{
			bool existe = false;
			HerramientaEx herramienta = null;
			if (!IdHerramienta.ToUpper().Equals("RAIZ")) 
			{
				long idH = Convert.ToInt64(IdHerramienta);							
				int i = 0;
				while(!existe && _herramientasEx.Count > i)
				{
					herramienta = (HerramientaEx)_herramientasEx[i];
					existe = herramienta.IdHerramienta == idH && herramienta.IdTipoRecurso == IdTipoRecurso;
					i++;
				}
			}
			if(existe)
                return herramienta;
			else return null;
		}

		public HerramientaEx GetSeparador(string IdRecurso)
		{
			bool existe = false;
			HerramientaEx herramienta = null;
			long idR = Convert.ToInt64(IdRecurso);							
			int i = 0;
			while(!existe && _herramientasEx.Count > i)
			{
				herramienta = (HerramientaEx)_herramientasEx[i];
				existe = herramienta.IdRecurso == idR;
				i++;
			}
			if(existe)
				return herramienta;
			else return null;
		}

        /* Silvina 20110805 - Tarea 0000184 */ 
		public bool AddSubmenu(string Titulo, string Imagen, string ShortCut, bool Habilitado, string IdHerramientaPadre, string Id )
        /* Fin Silvina 20110805 - Tarea 0000184 */ 
        {
			long IdHerramientaPadreEx = 0;
			if (IdHerramientaPadre != string.Empty)
				IdHerramientaPadreEx = Convert.ToInt64(IdHerramientaPadre);

			//HerramientaEx herramienta = new HerramientaEx(IdBarraDeHerramientaSeleccionada, 0, IdHerramientaPadreEx, Id, ShortCut, Habilitado, 0, 0, Titulo, ID_TIPO_RECURSO_TITULO, _perfilesSuperioresList, "ADD", this);
            //German 20110318 - Tarea 0000091
            HerramientaEx herramienta = new HerramientaEx(IdBarraDeHerramientaSeleccionada, mz.erp.systemframework.Util.NewLongId(), IdHerramientaPadreEx, Id, ShortCut, Habilitado, 0, 0, Titulo, ID_TIPO_RECURSO_TITULO, _perfilesSuperioresList, "ADD", this);
            //Fin German 20110318 - Tarea 0000091
			herramienta.Imagen = Imagen;
			herramienta.IdHerramientaPadre = IdHerramientaPadreEx;
            /* Silvina 20110805 - Tarea 0000184 */
            _errores.Clear();
            ValidarId(herramienta);
            if (_errores.Count == 0)
            {
                _herramientaModificada = herramienta;
                _herramientasExModificadas.Add(herramienta);
                if (HerramientasExModificadasHasChanged != null)
                    HerramientasExModificadasHasChanged(this, new EventArgs());
                return true;
            }
            else
            {
                //ItemDatasetError error = (ItemDatasetError)_errores.GetArray()[0];
                foreach (ItemDatasetError error in _errores)
                {
                    System.Windows.Forms.MessageBox.Show(error.Mensaje, "Error", System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                }
                return false;
            }
            /* Fin Silvina 20110805 - Tarea 0000184 */	
		}

		public void AddBarra(string IdHerramienta, string Barra)
		{
			long IdHerramientaEx = 0;
			if (IdHerramienta != string.Empty)
				IdHerramientaEx = Convert.ToInt64(IdHerramienta);

			long BarraEx = 0;
			if (Barra != string.Empty)
				BarraEx = Convert.ToInt64(_barrasDeHerramientasNuevas[Barra]);

			if (BarraEx == 2) 
			{
				//Barra Estandar
				HerramientaEx herramienta = new HerramientaEx(BarraEx, IdHerramientaEx, 0, string.Empty, string.Empty, true, 0, 0, string.Empty, ID_TIPO_RECURSO_TITULO, new ArrayList(), "ADD_ESTANDAR", this);

				_herramientaModificada = herramienta;
				_herramientasExModificadas.Add(herramienta);
				
				if(HerramientasExModificadasHasChanged != null)
					HerramientasExModificadasHasChanged(this, new EventArgs());	

			}
			else
			{
				if ( BarraEx == 3)
				{
					//Barra de Exploración

					HerramientaEx hx = this.GetHerramienta(IdHerramienta, ID_TIPO_RECURSO_TITULO);
	
					_herramientaModificada = new HerramientaEx(BarraEx, 0, 148, hx.Id, hx.ShortCut, hx.Habilitado, 0, hx.IdRecurso, hx.Descripcion, hx.IdTipoRecurso, hx.PerfilesHerramientas, "ADD_EXPLORACION", this);
					_herramientaModificada.IdHerramientaPadre = 148;
					_herramientasExModificadas.Add(_herramientaModificada);
						
					if(HerramientasExModificadasHasChanged != null)
						HerramientasExModificadasHasChanged(this, new EventArgs());	
				}
			}
		}

		public void RemoveBarra(string IdHerramienta, string Barra)
		{
			long IdHerramientaEx = 0;
			if (IdHerramienta != string.Empty)
				IdHerramientaEx = Convert.ToInt64(IdHerramienta);

			long BarraEx = 0;
			if (Barra != string.Empty)
				BarraEx = Convert.ToInt64(_barrasDeHerramientas[Barra]);

			if (BarraEx == 2) 
			{
				//Barra Estandar
				
				HerramientaEx herramienta = GetHerramienta(IdHerramienta,ID_TIPO_RECURSO_TITULO);
				herramienta.Modo = "REMOVE_ESTANDAR";

				_herramientaModificada = herramienta;
				_herramientasExModificadas.Add(herramienta);
				
				if(HerramientasExModificadasHasChanged != null)
					HerramientasExModificadasHasChanged(this, new EventArgs());	

			}
			else
			{
				if ( BarraEx == 3)
				{
					//Barra de Exploración

					HerramientaEx herramienta = GetHerramienta(IdHerramienta,ID_TIPO_RECURSO_TITULO);
					herramienta.Modo = "REMOVE_EXPLORACION";

					_herramientaModificada = herramienta;
					_herramientasExModificadas.Add(herramienta);
				
					if(HerramientasExModificadasHasChanged != null)
						HerramientasExModificadasHasChanged(this, new EventArgs());	
				}
			}
		}

		public void AddHerramientaModificada(string Titulo, string IdHerramienta, string Imagen, string ShortCut, bool Habilitado, ArrayList PerfilesSeleccionados, string IdHerramientaPadre, string Modo, bool modificaOtrasHerramientasConIgualRecurso)
		{
			long IdHerramientaPadreEx = 0;
			if(Modo.Equals("MODIF"))
			{
				#region MODIF
				long IdHerramientaEx = Convert.ToInt64(IdHerramienta);
				if (IdHerramientaPadre != string.Empty)
					IdHerramientaPadreEx = Convert.ToInt64(IdHerramientaPadre);
				int i = 0;
				bool exist = false;
				HerramientaEx herramienta = null;
				while(!exist & i < _herramientasExModificadas.Count)
				{
					herramienta = (HerramientaEx)_herramientasExModificadas[i];
					if(herramienta.IdHerramienta.Equals(IdHerramientaEx) && herramienta.IdTipoRecurso.Equals(ID_TIPO_RECURSO_TITULO))
						exist = true;
					else
						i++;
				}
				HerramientaEx hx = this.GetHerramienta(IdHerramienta, ID_TIPO_RECURSO_TITULO);
				hx.Descripcion = Titulo;
				hx.ShortCut = ShortCut;
				hx.Habilitado = Habilitado;
				hx.Imagen = Imagen;
				hx.PerfilesHerramientas = PerfilesSeleccionados;
				hx.IdHerramientaPadre = IdHerramientaPadreEx;
				if(exist)
				{
					herramienta.Descripcion = Titulo;
					herramienta.ShortCut = ShortCut;
					herramienta.Habilitado = Habilitado;
					herramienta.Imagen = Imagen;
					herramienta.PerfilesHerramientas = PerfilesSeleccionados;
					herramienta.IdHerramientaPadre = IdHerramientaPadreEx;
					_herramientaModificada = herramienta;
				}
				else	
				{
					_herramientaModificada = new HerramientaEx(hx.IdBarraHerramienta, hx.IdHerramienta, hx.IdHerramientaPadre, hx.Id, ShortCut, Habilitado, hx.Orden, hx.IdRecurso, Titulo, hx.IdTipoRecurso, PerfilesSeleccionados, Modo, this);
					_herramientaModificada.Imagen = Imagen;
					_herramientaModificada.IdHerramientaPadre = IdHerramientaPadreEx;
					_herramientasExModificadas.Add(_herramientaModificada);
				}
				if(HerramientasExModificadasHasChanged != null)
					HerramientasExModificadasHasChanged(this, new EventArgs());	
				if(modificaOtrasHerramientasConIgualRecurso)
				{
					ArrayList herramientasRecurso = GetHerramientasRecurso(hx.IdRecurso);
					foreach(HerramientaEx hr in herramientasRecurso)
						if(hr.IdHerramienta != hx.IdHerramienta && !hr.Descripcion.Equals(Titulo))
						{
							string ShortCutHR = hr.ShortCut;
							if(ShortCutHR.Equals(string.Empty))
								ShortCutHR = "None";
							this.AddHerramientaModificada(Titulo, hr.IdHerramienta.ToString(),hr.Imagen, ShortCutHR, hr.Habilitado, hr.PerfilesHerramientas, "MODIF", IdHerramientaPadre, false);
						}
				}
			#endregion
			}
		}


		public Node getNode(long IdHerramienta, long IdRecurso)
		{
			Node node = null;
			DataRow row = mz.erp.businessrules.sy_Herramientas.GetHerramientaEx_By_IdHerramientaIdRecurso(IdHerramienta, IdRecurso);
			string description = row["Descripcion"].ToString();
			bool habilitado = (bool)row["Habilitado"];
			if(habilitado)
				description = description + " (Habilitado)";
			else
				description = description + " (Deshabilitado)";
			HerramientaEx hx = this.GetHerramienta(IdHerramienta.ToString(), ID_TIPO_RECURSO_TITULO);
			hx.Descripcion = row["Descripcion"].ToString();;
			string shortCut = row["Shortcut"].ToString();
			short orden = short.MinValue;
			if(row["orden"] != null && row["orden"] != System.DBNull.Value)
				orden = Convert.ToInt16(row["orden"]);
			ArrayList perfilesHerramientas = new ArrayList();
			DataTable tableP = sy_PerfilesHerramientas.GetListPerfilesFor(IdHerramienta).Tables[1];
			foreach (System.Data.DataRow rowPerfilesHerramientas in tableP.Rows) 
			{
				long idPerfilHerramienta = Convert.ToInt64(rowPerfilesHerramientas["IdPerfil"]);
				bool visible = (bool)rowPerfilesHerramientas["Visible"];
				string descripcionPerfil = rowPerfilesHerramientas["Descripcion"].ToString();
				if(visible)
					descripcionPerfil = descripcionPerfil + " (Visible)";
				else
					descripcionPerfil = descripcionPerfil + " (No Visible)";
				PerfilView perfilView = new PerfilView(idPerfilHerramienta,descripcionPerfil);
				perfilesHerramientas.Add(perfilView);
			}
			hx.ShortCut = shortCut;
			hx.Habilitado = habilitado;
			hx.Orden = orden;
			hx.Imagen = this.RestablecerImagen(IdHerramienta);
			hx.PerfilesHerramientas = perfilesHerramientas;
			node = new Node(IdHerramienta.ToString(), description );
			return node;
		}

		public void AddPerfilHerramienta(string IdHerramienta, businessrules.PerfilView Perfil)
		{
			HerramientaEx hx = this.GetHerramienta(IdHerramienta, ID_TIPO_RECURSO_TITULO);
			hx.PerfilesHerramientas.Add(Perfil);
		}

		public void RemovePerfilHerramienta(string IdHerramienta, businessrules.PerfilView Perfil)
		{
			HerramientaEx hx = this.GetHerramienta(IdHerramienta, ID_TIPO_RECURSO_TITULO);
			hx.PerfilesHerramientas.Remove(Perfil);
		}

		public void AddSeparador(string IdHerramienta)
		{
			HerramientaEx hx = this.GetHerramienta(IdHerramienta, ID_TIPO_RECURSO_TITULO);
			long IdRecurso = mz.erp.systemframework.Util.NewLongId();
			string descripcion = "Separator_" + IdRecurso.ToString();
			_herramientaModificada = new HerramientaEx(hx.IdBarraHerramienta, Convert.ToInt64(IdHerramienta),hx.IdHerramientaPadre, hx.Id, string.Empty, true, short.MinValue, IdRecurso, descripcion, ID_TIPO_RECURSO_SEPARATOR, new ArrayList(), "NEW", this);
			_herramientasExModificadas.Add(_herramientaModificada);
			_herramientasEx.Add(_herramientaModificada);
			if(HerramientasExModificadasHasChanged != null)
				HerramientasExModificadasHasChanged(this, new EventArgs());	
		}

		public void AddSeparador(businessrules.HerramientaEx Herramienta)
		{
			DataRow row = mz.erp.businessrules.sy_Herramientas.GetHerramientaEx_By_IdHerramientaIdRecurso(Herramienta.IdHerramienta, Herramienta.IdRecurso);
            this.LoadHerramientas(_idBarraDeHerramientaSeleccionada, row);
		}

        public void RemoveSeparador(string IdHerramienta)
        {
			_herramientaModificada = this.GetHerramienta(IdHerramienta, ID_TIPO_RECURSO_SEPARATOR);
			_herramientasEx.Remove(_herramientaModificada);	
			if(!_herramientaModificada.Modo.Equals("NEW"))						
			{
				_herramientaModificada.Modo = "DEL";
				_herramientasExModificadas.Add(_herramientaModificada);
			}			
			if(HerramientasExModificadasHasChanged != null)
				HerramientasExModificadasHasChanged(this, new EventArgs());	
		}

		public bool ModificarOrdenSubir(string IdHerramienta)
		{
			HerramientaEx hx = this.GetHerramienta(IdHerramienta, ID_TIPO_RECURSO_TITULO);
			HerramientaEx hAnterior = this.GetHerramientaAnterior(hx.IdHerramientaPadre, hx.IdHerramienta, hx.Orden);
			if(hAnterior != null)
			{
				long IdHerramientaEx = Convert.ToInt64(IdHerramienta);
				int i = 0;
				bool exist = false;
				HerramientaEx herramienta = null;
				while(!exist & i < _herramientasExModificadas.Count)
				{
					herramienta = (HerramientaEx)_herramientasExModificadas[i];
					if(herramienta.IdHerramienta.Equals(IdHerramientaEx) && herramienta.IdTipoRecurso.Equals(ID_TIPO_RECURSO_TITULO))
						exist = true;
					else
						i++;
				}
				short ordenAnterior = hAnterior.Orden;
				hAnterior.Orden = hx.Orden;
				hx.Orden = ordenAnterior;
				if(exist)
				{
					herramienta.Orden = hx.Orden;
					_herramientaModificada = herramienta;
				}
				else	
				{
					string shortCut = hx.ShortCut;
					if(shortCut.Equals(string.Empty))
						shortCut = "None";
					_herramientaModificada = new HerramientaEx(hx.IdBarraHerramienta, hx.IdHerramienta, hx.IdHerramientaPadre, hx.Id, shortCut, hx.Habilitado, hx.Orden, hx.IdRecurso, hx.Descripcion, hx.IdTipoRecurso, hx.PerfilesHerramientas, "MODIF", this);
					_herramientaModificada.Imagen = hx.Imagen;
					_herramientasExModificadas.Add(_herramientaModificada);
				}
				int j = 0;
				bool existA = false;
				HerramientaEx herramientaA = null;
				while(!existA & j < _herramientasExModificadas.Count)
				{
					herramientaA = (HerramientaEx)_herramientasExModificadas[j];
					if(herramientaA.IdHerramienta.Equals(hAnterior.IdHerramienta) && herramientaA.IdTipoRecurso.Equals(ID_TIPO_RECURSO_TITULO))
						existA = true;
					else
						j++;
				}
				if(existA)
					herramientaA.Orden = hAnterior.Orden;
				else	
				{
					string shortCut = hAnterior.ShortCut;
					if(shortCut.Equals(string.Empty))
						shortCut = "None";
					HerramientaEx herramientaModificadaA = new HerramientaEx(hAnterior.IdBarraHerramienta, hAnterior.IdHerramienta, hAnterior.IdHerramientaPadre, hAnterior.Id, shortCut, hAnterior.Habilitado, hAnterior.Orden, hAnterior.IdRecurso, hAnterior.Descripcion, hAnterior.IdTipoRecurso, hAnterior.PerfilesHerramientas, "MODIF", this);
					herramientaModificadaA.Imagen = hAnterior.Imagen;
					_herramientasExModificadas.Add(herramientaModificadaA);
				}

				if(HerramientasExModificadasHasChanged != null)
					HerramientasExModificadasHasChanged(this, new EventArgs());			
				return true;
			}
			return false;
		}
		
		public bool ModificarOrdenBajar(string IdHerramienta)
		{			
			HerramientaEx hx = this.GetHerramienta(IdHerramienta, ID_TIPO_RECURSO_TITULO);
			HerramientaEx hPosterior = this.GetHerramientaPosterior(hx.IdHerramientaPadre, hx.IdHerramienta, hx.Orden);
			if(hPosterior != null)
			{
				long IdHerramientaEx = Convert.ToInt64(IdHerramienta);
				int i = 0;
				bool exist = false;
				HerramientaEx herramienta = null;
				while(!exist & i < _herramientasExModificadas.Count)
				{
					herramienta = (HerramientaEx)_herramientasExModificadas[i];
					if(herramienta.IdHerramienta.Equals(IdHerramientaEx) && herramienta.IdTipoRecurso.Equals(ID_TIPO_RECURSO_TITULO))
						exist = true;
					else
						i++;
				}
				short ordenPosterior = hPosterior.Orden;
				hPosterior.Orden = hx.Orden;
				hx.Orden = ordenPosterior;
				if(exist)
				{
					herramienta.Orden = hx.Orden;
					_herramientaModificada = herramienta;
				}
				else	
				{
					string shortCut = hx.ShortCut;
					if(shortCut.Equals(string.Empty))
						shortCut = "None";
					_herramientaModificada = new HerramientaEx(hx.IdBarraHerramienta, hx.IdHerramienta, hx.IdHerramientaPadre, hx.Id, shortCut, hx.Habilitado, hx.Orden, hx.IdRecurso, hx.Descripcion, hx.IdTipoRecurso, hx.PerfilesHerramientas, "MODIF", this);
					_herramientaModificada.Imagen = hx.Imagen;
					_herramientasExModificadas.Add(_herramientaModificada);
				}
				int j = 0;
				bool existP = false;
				HerramientaEx herramientaP = null;
				while(!existP & j < _herramientasExModificadas.Count)
				{
					herramientaP = (HerramientaEx)_herramientasExModificadas[j];
					if(herramientaP.IdHerramienta.Equals(hPosterior.IdHerramienta) && herramientaP.IdTipoRecurso.Equals(ID_TIPO_RECURSO_TITULO))
						existP = true;
					else
						j++;
				}
				if(existP)
					herramientaP.Orden = hPosterior.Orden;
				else	
				{
					string shortCut = hPosterior.ShortCut;
					if(shortCut.Equals(string.Empty))
						shortCut = "None";
					HerramientaEx herramientaModificadaP = new HerramientaEx(hPosterior.IdBarraHerramienta, hPosterior.IdHerramienta, hPosterior.IdHerramientaPadre, hPosterior.Id, shortCut, hPosterior.Habilitado, hPosterior.Orden, hPosterior.IdRecurso, hPosterior.Descripcion, hPosterior.IdTipoRecurso, hPosterior.PerfilesHerramientas, "MODIF", this);
					herramientaModificadaP.Imagen = hPosterior.Imagen;
					_herramientasExModificadas.Add(herramientaModificadaP);
				}

				if(HerramientasExModificadasHasChanged != null)
					HerramientasExModificadasHasChanged(this, new EventArgs());			
				return true;
			}
			return false;
		}

		public ArrayList GetHerramientasRecurso(long IdRecurso)
		{
			ArrayList herramientasRecurso = new ArrayList();
			foreach(HerramientaEx herramienta in _herramientasEx)
			{
				if(herramienta.IdTipoRecurso == ID_TIPO_RECURSO_TITULO && herramienta.IdRecurso.Equals(IdRecurso))
					herramientasRecurso.Add(herramienta);
			}
			return herramientasRecurso;
		}
		public HerramientaEx GetHerramientaModificada(long IdHerramienta)
		{
			int i = 0;
			bool exist = false;
			HerramientaEx h = null;
			while(!exist & i < _herramientasExModificadas.Count)
			{
				h = (HerramientaEx)_herramientasExModificadas[i];
				if(h.IdHerramienta.Equals(IdHerramienta) && h.IdTipoRecurso.Equals(ID_TIPO_RECURSO_TITULO))
					exist = true;
				else
					i++;
			}
			if(exist)
				return h;
			else
				return null;
		}
		public bool SoloCambioDescripcion(HerramientaEx Herramienta)
		{
			DataRow row = mz.erp.businessrules.sy_Herramientas.GetHerramientaEx_By_IdHerramientaIdRecurso(Herramienta.IdHerramienta, Herramienta.IdRecurso);
			bool habilitado = (bool)row["Habilitado"];
			string shortCut = row["Shortcut"].ToString();
			if(shortCut.Equals(string.Empty))
				shortCut = "None";
			short orden = short.MinValue;
			if(row["orden"] != null && row["orden"] != System.DBNull.Value)
				orden = Convert.ToInt16(row["orden"]);	
			bool soloCambioDescripcion = Herramienta.Habilitado == habilitado && Herramienta.ShortCut.Equals(shortCut) && Herramienta.Orden == orden;
			DataTable tableP = sy_PerfilesHerramientas.GetListPerfilesFor(Herramienta.IdHerramienta).Tables[1];
			foreach (System.Data.DataRow rowPerfilesHerramientas in tableP.Rows) 
			{
				long idPerfilHerramienta = Convert.ToInt64(rowPerfilesHerramientas["IdPerfil"]);
				bool visible = (bool)rowPerfilesHerramientas["Visible"];
				string descripcionPerfil = rowPerfilesHerramientas["Descripcion"].ToString();
				if(visible)
					descripcionPerfil = descripcionPerfil + " (Visible)";
				else
					descripcionPerfil = descripcionPerfil + " (No Visible)";
				PerfilView perfilView = new PerfilView(idPerfilHerramienta,descripcionPerfil);
				PerfilView perfilVHM =  GetPerfilHerramienta(Herramienta.PerfilesHerramientas, perfilView);
				soloCambioDescripcion = soloCambioDescripcion && perfilVHM != null;
			}
			soloCambioDescripcion = soloCambioDescripcion && tableP.Rows.Count == Herramienta.PerfilesHerramientas.Count;
			return soloCambioDescripcion;

		}


		public bool SoloCambioOrden(HerramientaEx Herramienta)
		{
			DataRow row = mz.erp.businessrules.sy_Herramientas.GetHerramientaEx_By_IdHerramientaIdRecurso(Herramienta.IdHerramienta, Herramienta.IdRecurso);
			string descripcion = row["Descripcion"].ToString();
			bool habilitado = (bool)row["Habilitado"];
			string shortCut = row["Shortcut"].ToString();
			if(shortCut.Equals(string.Empty))
				shortCut = "None";
			bool soloCambioOrden = Herramienta.Descripcion.Equals(descripcion) && Herramienta.Habilitado == habilitado && Herramienta.ShortCut.Equals(shortCut);
			DataTable tableP = sy_PerfilesHerramientas.GetListPerfilesFor(Herramienta.IdHerramienta).Tables[1];
			foreach (System.Data.DataRow rowPerfilesHerramientas in tableP.Rows) 
			{
				long idPerfilHerramienta = Convert.ToInt64(rowPerfilesHerramientas["IdPerfil"]);
				bool visible = (bool)rowPerfilesHerramientas["Visible"];
				string descripcionPerfil = rowPerfilesHerramientas["Descripcion"].ToString();
				if(visible)
					descripcionPerfil = descripcionPerfil + " (Visible)";
				else
					descripcionPerfil = descripcionPerfil + " (No Visible)";
				PerfilView perfilView = new PerfilView(idPerfilHerramienta,descripcionPerfil);
				PerfilView perfilVHM =  GetPerfilHerramienta(Herramienta.PerfilesHerramientas, perfilView);
				soloCambioOrden = soloCambioOrden && perfilVHM != null;
			}
			soloCambioOrden = soloCambioOrden && tableP.Rows.Count == Herramienta.PerfilesHerramientas.Count;
			return soloCambioOrden;

		}
		public HerramientaEx GetHerramientaModificadaConOrden(short Orden, long IdHerramientaPadre)
		{
			int i = 0;
			bool exist = false;
			HerramientaEx h = null;
			while(!exist & i < _herramientasExModificadas.Count)
			{
				h = (HerramientaEx)_herramientasExModificadas[i];
				if(h.IdHerramientaPadre.Equals(IdHerramientaPadre) && h.IdTipoRecurso.Equals(ID_TIPO_RECURSO_TITULO) && h.Orden == Orden)
					exist = true;
				else
					i++;
			}
			if(exist)
				return h;
			else
				return null;
		}

		/*public string GetBarraHerramienta(long IdBarraHerramienta)
		{
			bool existe = false;
			int index = 0;
			ArrayList valores = new ArrayList(_barrasDeHerramientas.Values);
			ArrayList claves = new ArrayList(_barrasDeHerramientas.Keys);
			while(!existe && index < valores.Count)
			{
				long id = Convert.ToInt64((int)valores[index]);
				if(id.Equals(IdBarraHerramienta))
					existe = true;
				else
					index++;
			}
			if(existe)
				return (string)claves[index];
			else return string.Empty;

		}*/

		public void RecuperarProceso(long IdHerramienta)
		{
			twf_ProcesosHerramientasDataset.twf_ProcesosHerramientasRow row = twf_ProcesosHerramientas.GetByPk(IdHerramienta);
			if (row != null)
			{
                /* Silvina 20110805 - Tarea 0000184 */
                _currentIdProcess = row.IdProceso; 
                /* Fin Silvina 20110805 - Tarea 0000184 */
				_currentDescriptionProcess = twf_Procesos.GetByPk(_currentIdProcess).Descripcion;
			}
			else
			{
				_currentIdProcess = 0;
				_currentDescriptionProcess = string.Empty;
			}
		}


		#endregion


		#region Métodos Privados

		private PerfilView GetPerfilHerramienta(ArrayList PerfilesHerramientas1, PerfilView Perfil)
		{
			bool existe = false;
			PerfilView pv = null;
			int i = 0;
			while(!existe && i < PerfilesHerramientas1.Count )
			{
				pv = (PerfilView)PerfilesHerramientas1[i];
				existe = pv.IdPerfil.Equals(Perfil.IdPerfil) && pv.Descripcion.Equals(Perfil.Descripcion);
				i++;
			}
			if(existe)
				return pv;
			else
				return null;
		}
		
		private bool isVisible(PerfilView perfil)
		{
			return perfil.Descripcion.IndexOf("(Visible)") > 0;
		}

		private HerramientaEx GetHerramientaPosterior(long IdHerramientaPadre, long IdHerramienta, int Orden)
		{
			int ordenPosterior = int.MaxValue; 
			int index =0;
			int i =0;
			foreach(HerramientaEx herramienta in _herramientasEx)
			{
				if(herramienta.IdHerramientaPadre.Equals(IdHerramientaPadre) && herramienta.IdTipoRecurso == ID_TIPO_RECURSO_TITULO)
				{
					if((herramienta.Orden > Orden ||(herramienta.Orden == Orden && !herramienta.IdHerramienta.Equals(IdHerramienta)))&& herramienta.Orden < ordenPosterior)
					{
						ordenPosterior = herramienta.Orden;
						index = i;
					}
				}
				i++;
			}
			if(ordenPosterior.Equals(int.MaxValue))
				return null;
			else
                return (HerramientaEx)_herramientasEx[index];
		}


		private HerramientaEx GetHerramientaAnterior(long IdHerramientaPadre, long IdHerramienta, int Orden)
		{
			int ordenAnterior = int.MinValue; 
			int index =0;
			int i =0;
			foreach(HerramientaEx herramienta in _herramientasEx)
			{
				if(herramienta.IdHerramientaPadre.Equals(IdHerramientaPadre) && herramienta.IdTipoRecurso == ID_TIPO_RECURSO_TITULO)
				{
					if((herramienta.Orden < Orden ||(herramienta.Orden == Orden && !herramienta.IdHerramienta.Equals(IdHerramienta)))&& herramienta.Orden > ordenAnterior)
					{
						ordenAnterior = herramienta.Orden;
						index = i;
					}
				}
				i++;
			}
			if(ordenAnterior.Equals(int.MinValue))
				return null;
			else
				return (HerramientaEx)_herramientasEx[index];
		}

		private string RestablecerImagen(long IdHerramienta)
		{
			DataRow row = mz.erp.businessrules.sy_Herramientas.GetImagen_By_IdHerramienta(IdHerramienta);
			HerramientaEx ImagenHerramienta = GetHerramienta(IdHerramienta.ToString(), ConfigurarMenues.ID_TIPO_RECURSO_IMAGEN);
			if(row != null)
			{
				string descriptionImagen = row["Descripcion"].ToString();
				if(ImagenHerramienta != null)
					ImagenHerramienta.Descripcion = descriptionImagen;
				return descriptionImagen;
			}
			else
			{
                if(ImagenHerramienta != null)
					_herramientasExModificadas.Remove(ImagenHerramienta);

			}
			return string.Empty;

		}

		private void SetCombosData()
		{

            _barrasDeHerramientas.Clear();
			_barrasDeHerramientas.Add("Menú principal", 1);
			_barrasDeHerramientas.Add("Estándar", 2);
			_barrasDeHerramientas.Add("Barra de exploración", 3);
			//_barrasDeHerramientas.Add("Web Servicio Técnico", 4);
			_barrasDeHerramientasNuevas.Clear();
			_barrasDeHerramientasNuevas.Add("Estándar", 2);
			_barrasDeHerramientasNuevas.Add("Barra de exploración", 3);
		}

		private void InitializeDataMenues()
		{
            foreach (int idBarraHerramienta in _barrasDeHerramientas.Values)
			{
				DataTable table = mz.erp.businessrules.sy_Herramientas.GetListPadres(Convert.ToInt64(idBarraHerramienta)).Tables[0];
				ArrayList hijosOrdenados = new ArrayList();
				foreach (System.Data.DataRow rowP in table.Rows) 
				{
					HerramientaEx hexH =this.LoadHerramientasOrdenadas(Convert.ToInt64(idBarraHerramienta), rowP);
					if(idBarraHerramienta ==  1)
						hijosOrdenados.Add(hexH);
				}
				if(idBarraHerramienta ==  1)
					this.OrdenarMenu(hijosOrdenados);
			}
			this.Commit();
			dataaccess.sy_HerramientasEx.Update(_data);
			_herramientasExModificadas.Clear();
		}

		private HerramientaEx LoadHerramientasOrdenadas(long idBarraHerramienta,  System.Data.DataRow row)
		{
			long idHerramienta = Convert.ToInt64(row["IdHerramienta"]);
			long idHerramientaPadre = long.MinValue;
			if(row["IdHerramientaPadre"] != null && row["IdHerramientaPadre"] != System.DBNull.Value)
				idHerramientaPadre = Convert.ToInt64(row["IdHerramientaPadre"]);
			string id = row["Id"].ToString();
			string shortCut = row["Shortcut"].ToString();
			if(shortCut.Equals(string.Empty))
				shortCut = "None";
			bool habilitado = (bool)row["Habilitado"];
			short orden = short.MinValue;
			if(row["orden"] != null && row["orden"] != System.DBNull.Value)
				orden = Convert.ToInt16(row["orden"]);
			long idRecurso = Convert.ToInt64(row["IdRecurso"]);
			string descripcion = row["Descripcion"].ToString();
			long idTipoRecurso = Convert.ToInt64(row["IdTipoRecurso"]);
			ArrayList perfilesHerramientas = new ArrayList();
			DataTable tableP = sy_PerfilesHerramientas.GetListPerfilesFor(idHerramienta).Tables[1];
			foreach (System.Data.DataRow rowPerfilesHerramientas in tableP.Rows) 
			{
				long idPerfilHerramienta = Convert.ToInt64(rowPerfilesHerramientas["IdPerfil"]);
				bool visible = (bool)rowPerfilesHerramientas["Visible"];
				string descripcionPerfil = rowPerfilesHerramientas["Descripcion"].ToString();
				if(visible)
					descripcionPerfil = descripcionPerfil + " (Visible)";
				else
					descripcionPerfil = descripcionPerfil + " (No Visible)";
				PerfilView perfilView = new PerfilView(idPerfilHerramienta,descripcionPerfil);
				perfilesHerramientas.Add(perfilView);
			}
			HerramientaEx hex = null;
			if(idTipoRecurso.Equals(ID_TIPO_RECURSO_TITULO))
			{
				hex = GetHerramienta(idHerramienta.ToString(), ID_TIPO_RECURSO_TITULO);
			}
			if(hex == null)
			{
				hex = new HerramientaEx(idBarraHerramienta,idHerramienta, idHerramientaPadre, id, shortCut, habilitado, orden, idRecurso, descripcion, idTipoRecurso, perfilesHerramientas, string.Empty, this);
				_herramientasEx.Add(hex);
			}
			else if(hex.IdBarraHerramienta.Equals(idBarraHerramienta))
				hex = null;
            DataTable tableH = mz.erp.businessrules.sy_Herramientas.GetListHijos(idBarraHerramienta, idHerramienta).Tables[0];
			ArrayList hijosOrdenados = new ArrayList();
			short maximo = 0;
			foreach (System.Data.DataRow rowH in tableH.Rows) 
			{
				HerramientaEx hexH = this.LoadHerramientasOrdenadas(idBarraHerramienta, rowH);
				if(hexH != null)
                    hijosOrdenados.Add(hexH);	
				short ordenHijo = short.MinValue;
				if(rowH["orden"] != null && rowH["orden"] != System.DBNull.Value)
					ordenHijo = Convert.ToInt16(rowH["orden"]);
				if (ordenHijo > maximo)
					maximo = ordenHijo;
			}
			if ((idTipoRecurso.Equals(ID_TIPO_RECURSO_TITULO)) && tableH.Rows.Count != 0)
				if (maximo > _ordenMinimoMenu)
					_ordenMaximo[idHerramienta] = ++maximo;
				else
				{
					_ordenMaximo[idHerramienta] = _ordenMinimoMenu;
					_ordenMinimoMenu ++;
				}
            this.OrdenarMenu(hijosOrdenados);
			return hex;

		}

		private void OrdenarMenu(ArrayList herramientas)
		{
			Hashtable ordenes = new Hashtable(); // Mantengo los ordenes utilizados para un padre
			
			foreach(HerramientaEx herramienta in herramientas)
			{
				ArrayList ordenesHerr = new ArrayList();
				if (herramienta.IdTipoRecurso.Equals(ID_TIPO_RECURSO_TITULO)) 
				{
					if(!herramienta.Orden.Equals(short.MinValue))
					{
						ordenesHerr = (ArrayList)ordenes[herramienta.IdHerramientaPadre];
						if (ordenesHerr != null)
							if (ordenesHerr.Contains(herramienta.Orden))
							{
								short nuevoOrden = Convert.ToInt16(_ordenMaximo[herramienta.IdHerramientaPadre]);
								herramienta.Orden = nuevoOrden;
								_ordenMaximo[herramienta.IdHerramientaPadre] = ++nuevoOrden;
								ordenesHerr = (ArrayList)ordenes[herramienta.IdHerramientaPadre];
								ordenesHerr.Add(nuevoOrden);
								ordenes[herramienta.IdHerramientaPadre] = ordenesHerr;
								this.AddHerramientaModificada(herramienta);
							}
							else
							{
								ordenesHerr = (ArrayList)ordenes[herramienta.IdHerramientaPadre];
								ordenesHerr.Add(herramienta.Orden);
								ordenes[herramienta.IdHerramientaPadre] = ordenesHerr;
								this.AddHerramientaModificada(herramienta);
							}
						else
						{
							ordenesHerr = new ArrayList();
							ordenesHerr.Add(herramienta.Orden);
							ordenes[herramienta.IdHerramientaPadre] = ordenesHerr;
							this.AddHerramientaModificada(herramienta);
						}
					}
					else
					{
						short nuevoOrden = Convert.ToInt16(_ordenMaximo[herramienta.IdHerramientaPadre]);
						herramienta.Orden = nuevoOrden;
						_ordenMaximo[herramienta.IdHerramientaPadre] = ++nuevoOrden;
						ordenesHerr = (ArrayList)ordenes[herramienta.IdHerramientaPadre];
						if (ordenesHerr == null)
							ordenesHerr = new ArrayList();
						ordenesHerr.Add(nuevoOrden);
						ordenes[herramienta.IdHerramientaPadre] = ordenesHerr;
						this.AddHerramientaModificada(herramienta);
					}
				}
			}
		}

		/*private void OrdenarMenu(ArrayList herramientas)
		{
			Hashtable ordenes = new Hashtable();
			SortedList hijosOrdenados = new SortedList();
			short indexIntMinValue = _ordenMinimoMenu;

			foreach(HerramientaEx herramienta in herramientas)
			{
				if (herramienta.IdTipoRecurso.Equals(ID_TIPO_RECURSO_TITULO)) 
				{
					if(!herramienta.Orden.Equals(short.MinValue))
					{
						if(hijosOrdenados.ContainsKey(herramienta.Orden))
						{
							int index = hijosOrdenados.IndexOfKey(herramienta.Orden) +1;
							short nuevoOrden = Convert.ToInt16(herramienta.Orden + 1);

							if(ordenes.ContainsKey(herramienta.Orden))
							{
								index = hijosOrdenados.IndexOfKey(Convert.ToInt16(ordenes[herramienta.Orden])) +1;
								nuevoOrden = Convert.ToInt16(Convert.ToInt16(ordenes[herramienta.Orden]) + 1);

								//herramienta.Orden = indexIntMinValue;

								ordenes[herramienta.Orden] = nuevoOrden;								
							}
							else
							{
								short oA = Convert.ToInt16(herramienta.Orden - 1);
								if(ordenes.ContainsKey(oA))
								{
									short vOA = Convert.ToInt16(ordenes[oA]);
									index = hijosOrdenados.IndexOfKey(vOA) +1;
									nuevoOrden = Convert.ToInt16(vOA + 1);
								}
								ordenes.Add(herramienta.Orden, nuevoOrden);
							}
							for(int i = hijosOrdenados.Count-1; i > index; i--)
							{
								HerramientaEx h = (HerramientaEx)hijosOrdenados.GetByIndex(i);
								hijosOrdenados.RemoveAt(i);
								if(ordenes.ContainsKey(h.Orden))
								{
									if(Convert.ToInt16(ordenes[h.Orden]) < Convert.ToInt16(h.Orden + 1))
										ordenes[h.Orden] = Convert.ToInt16(h.Orden + 1);
								}
								else
									ordenes.Add(h.Orden, Convert.ToInt16(h.Orden + 1));
								h.Orden = Convert.ToInt16(h.Orden + 1);
								hijosOrdenados.Add(Convert.ToInt16(h.Orden), h);
								this.AddHerramientaModificada(h);

							}								
							herramienta.Orden = nuevoOrden;
							hijosOrdenados.Add(nuevoOrden, herramienta);
							this.AddHerramientaModificada(herramienta);
						
						}
						else
							hijosOrdenados.Add(herramienta.Orden, herramienta);
					}
					else
					{
						herramienta.Orden = indexIntMinValue;
						//herramienta.Orden = nuevoOrden;
						hijosOrdenados.Add(indexIntMinValue, herramienta);
						indexIntMinValue++;
						this.AddHerramientaModificada(herramienta);
					}
				}

			}
		}*/

	
		private void AddHerramientaModificada(HerramientaEx herramienta)
		{
			int i = 0;
			bool exist = false;
			HerramientaEx h = null;
			while(!exist & i < _herramientasExModificadas.Count)
			{
				h = (HerramientaEx)_herramientasExModificadas[i];
				if(h.IdHerramienta.Equals(herramienta.IdHerramienta) && h.IdTipoRecurso.Equals(ID_TIPO_RECURSO_TITULO))
					exist = true;
				else
					i++;
			}
			if(exist)
			{
				h.Descripcion = herramienta.Descripcion;
				h.ShortCut = herramienta.ShortCut;
				h.Habilitado = herramienta.Habilitado;
				h.Imagen = herramienta.Imagen;
				h.PerfilesHerramientas = herramienta.PerfilesHerramientas;
			}
			else	
			{
			     HerramientaEx herramientaModificada = new HerramientaEx(herramienta.IdBarraHerramienta, herramienta.IdHerramienta, herramienta.IdHerramientaPadre, herramienta.Id, herramienta.ShortCut, herramienta.Habilitado, herramienta.Orden, herramienta.IdRecurso, herramienta.Descripcion, herramienta.IdTipoRecurso, herramienta.PerfilesHerramientas, "MODIF", this);
				_herramientasExModificadas.Add(herramientaModificada);
			}
			if(HerramientasExModificadasHasChanged != null)
				HerramientasExModificadasHasChanged(this, new EventArgs());	
		}

		private void LoadHerramientas(long idBarraHerramienta,  System.Data.DataRow row)
		{
			long idHerramienta = Convert.ToInt64(row["IdHerramienta"]);
			long idHerramientaPadre = long.MinValue;
			if(row["IdHerramientaPadre"] != null && row["IdHerramientaPadre"] != System.DBNull.Value)
				idHerramientaPadre = Convert.ToInt64(row["IdHerramientaPadre"]);
			string id = row["Id"].ToString();
			string shortCut = row["Shortcut"].ToString();
			if(shortCut.Equals(string.Empty))
				shortCut = "None";
			bool habilitado = (bool)row["Habilitado"];
			short orden = short.MinValue;
			if(row["orden"] != null && row["orden"] != System.DBNull.Value)
				orden = Convert.ToInt16(row["orden"]);
			long idRecurso = Convert.ToInt64(row["IdRecurso"]);
			string descripcion = row["Descripcion"].ToString();
			long idTipoRecurso = Convert.ToInt64(row["IdTipoRecurso"]);
			ArrayList perfilesHerramientas = new ArrayList();
			DataTable tableP = sy_PerfilesHerramientas.GetListPerfilesFor(idHerramienta).Tables[1];
			foreach (System.Data.DataRow rowPerfilesHerramientas in tableP.Rows) 
			{
				long idPerfilHerramienta = Convert.ToInt64(rowPerfilesHerramientas["IdPerfil"]);
				bool visible = (bool)rowPerfilesHerramientas["Visible"];
				string descripcionPerfil = rowPerfilesHerramientas["Descripcion"].ToString();
				if(visible)
					descripcionPerfil = descripcionPerfil + " (Visible)";
				else
					descripcionPerfil = descripcionPerfil + " (No Visible)";
				PerfilView perfilView = new PerfilView(idPerfilHerramienta,descripcionPerfil);
				perfilesHerramientas.Add(perfilView);
			}
			HerramientaEx hex = new HerramientaEx(idBarraHerramienta, idHerramienta, idHerramientaPadre, id, shortCut, habilitado, orden, idRecurso, descripcion, idTipoRecurso, perfilesHerramientas, string.Empty, this);
			_herramientasEx.Add(hex);
			DataTable tableH = mz.erp.businessrules.sy_Herramientas.GetListHijos(idBarraHerramienta, idHerramienta).Tables[0];
			foreach (System.Data.DataRow rowH in tableH.Rows) 
			{
				this.LoadHerramientas(idBarraHerramienta, rowH);
			}

		}

		//Valida datos antes de guardar la informacion
        /* Silvina 20110805 - Tarea 0000184 */
        private Hashtable _idAsignados = new Hashtable();
        /* Fin Silvina 20110805 - Tarea 0000184 */

		private void ValidarDatos()
		{
			_errores.Clear(); 
			Hashtable shortCutsAsigandos = new Hashtable();
			ArrayList idHerramientasErrores = new ArrayList();
            /* Silvina 20110805 - Tarea 0000184 */
            //Hashtable idAsignados = new Hashtable();
            /* Fin Silvina 20110805 - Tarea 0000184 */
			foreach(HerramientaEx hm in _herramientasExModificadas)
			{
				/*string descripcion= hm.Descripcion.Trim();
				if (descripcion.Equals(string.Empty))
				{
					_errores.Add( new ItemDatasetError( "Configuracion Menues","Descripcion","El campo descripción no puede estar vacío") );
				}*/

				string shortCut= hm.ShortCut;
				bool existeEnBD = false;
				if (!shortCut.Equals(string.Empty) && !shortCut.Equals("None"))
				{
					sy_HerramientasDataset.sy_HerramientasDataTable dataShortCut = sy_Herramientas.GetList(shortCut).sy_Herramientas;
					foreach(sy_HerramientasDataset.sy_HerramientasRow rowS in dataShortCut.Rows)
					{
						long IdHerramientaMismoShortCut = rowS.IdHerramienta;
						if(!hm.IdHerramienta.Equals(IdHerramientaMismoShortCut))
						{
							HerramientaEx herramientaRecurso = this.GetHerramienta(IdHerramientaMismoShortCut.ToString(), ID_TIPO_RECURSO_TITULO);
							if(herramientaRecurso.ShortCut.Equals(shortCut) && !idHerramientasErrores.Contains(IdHerramientaMismoShortCut))
							{
								_errores.Add( new ItemDatasetError( "Configuracion Menues","ShortCut","La herramienta " +herramientaRecurso.Descripcion +" tiene asignado el mismo shortcut") );
								idHerramientasErrores.Add(IdHerramientaMismoShortCut);
								existeEnBD = true;
							}

						}
					}
					if(!existeEnBD)
					{
						if(shortCutsAsigandos.ContainsKey(shortCut))
						{
							long idHerramientaS = (long)shortCutsAsigandos[shortCut];
							HerramientaEx herramientaRecursoModif = this.GetHerramientaModificada(idHerramientaS);
							if(!idHerramientasErrores.Contains(herramientaRecursoModif.IdHerramienta))
							{
								_errores.Add( new ItemDatasetError( "Configuracion Menues","ShortCut","La herramienta " +herramientaRecursoModif.Descripcion +" tiene asignado el mismo shortcut") );
								idHerramientasErrores.Add(herramientaRecursoModif.IdHerramienta);
							}

						}
						else
							shortCutsAsigandos.Add(shortCut, hm.IdHerramienta);
					}

				}
                /* Silvina 20110805 - Tarea 0000184 */
                /*if (hm.Modo.Equals("ADD"))
                    ValidarId(hm, idAsignados);*/
                /* Fin Silvina 20110805 - Tarea 0000184 */
			}
		}

        /* Silvina 20110805 - Tarea 0000184 */
        public void ValidarId(HerramientaEx Herramienta)
        {
            if (string.IsNullOrEmpty(Herramienta.Id))
                _errores.Add(new ItemDatasetError("Configuracion Menues", "Id", "Debe ingresar el Id de la herramienta " + Herramienta.Descripcion));
            else
            {
                sy_HerramientasDataset data = sy_Herramientas.GetList(long.MinValue, long.MinValue, Herramienta.Id, string.Empty, short.MinValue, false);
                if (data.sy_Herramientas.Rows.Count != 0)
                {
                    HerramientaEx hr = this.GetHerramienta(data.sy_Herramientas.Rows[0]["IdHerramienta"].ToString(), ID_TIPO_RECURSO_TITULO);
                    _errores.Add(new ItemDatasetError("Configuracion Menues", "Id", "El Id ingresado es igual al de la herramienta " + hr.Descripcion));
                }
                else
                {
                    string id = Herramienta.Id;
                    if (_idAsignados.ContainsKey(id))
                    {
                        long idHerr = (long)_idAsignados[id];
                        HerramientaEx hm = this.GetHerramientaModificada(idHerr);
                        _errores.Add(new ItemDatasetError("Configuracion Menues", "Id", "El Id ingresado para la herramienta " + Herramienta.Descripcion + " es igual al de la herramienta " + hm.Descripcion));
                    }
                    else
                        _idAsignados.Add(id, Herramienta.IdHerramienta);
                }
            }
        }
        /* Fin Silvina 20110805 - Tarea 0000184 */

		private Node OrdenarMenu(Node node)
		{
			Node nodeOrdenado = new Node(node.Key, node.Description);
			SortedList hijosOrdenados = new SortedList();
			while(node.HasNext())
			{
				Node nodo = node.Next();
				string keyChildNode = nodo.Key;
				if (keyChildNode.ToUpper().IndexOf("SEPARATOR") == -1) 
				{
					HerramientaEx herramienta = this.GetHerramienta(keyChildNode, ID_TIPO_RECURSO_TITULO);
					/*if(hijosOrdenados.ContainsKey(herramienta.Orden))
					{
						int index = hijosOrdenados.IndexOfKey(herramienta.Orden) +1;
						for(int i = hijosOrdenados.Count-1; i >= index; i--)
						{
							HerramientaEx h = (HerramientaEx)hijosOrdenados.GetByIndex(i);
							hijosOrdenados.RemoveAt(i);
							hijosOrdenados.Add(Convert.ToInt16(h.Orden + 1), h);

						}
						short nuevoOrden = Convert.ToInt16(herramienta.Orden + 1);
						if(!hijosOrdenados.ContainsValue(herramienta))
                            hijosOrdenados.Add(nuevoOrden, herramienta);
						
					}
					else*/
					if(!hijosOrdenados.ContainsKey(herramienta.Orden))
						hijosOrdenados.Add(herramienta.Orden, herramienta);
				}

			}
			foreach(HerramientaEx herramienta in hijosOrdenados.Values)
			{
				string keyH = herramienta.IdHerramienta.ToString();
				string descriptionH = herramienta.Descripcion;
				bool habilitado = herramienta.Habilitado;
				if(habilitado)
					descriptionH = descriptionH + " (Habilitado)";
				else
					descriptionH = descriptionH + " (Deshabilitado)";
				Node child = new Node(keyH, descriptionH);
				nodeOrdenado.AddChild(child);
				HerramientaEx separador = this.GetHerramienta(keyH, ID_TIPO_RECURSO_SEPARATOR);
				if(separador != null)
				{
					keyH = "Separator_" + separador.IdRecurso.ToString();
					descriptionH = "Separador";
					Node childS = new Node(keyH, descriptionH);
					nodeOrdenado.AddChildBeforeLast(childS);
				}

			}
			return nodeOrdenado;
		}


		#endregion

		#region Metodos de Agrupamientos

		public override void DeleteAgrupamientos(string Hierarchy)
		{
		}


		public override Node getChildsNode(string key)
		{
			System.Data.DataTable table = new DataTable();
			string descriptionH = String.Empty;
			string keyH = String.Empty;
			long tipoR = long.MinValue;
			bool habilitado = false;
			Node header;
			if (key.ToUpper().Equals("RAIZ")) 
			{
				table = mz.erp.businessrules.sy_Herramientas.GetListPadres(_idBarraDeHerramientaSeleccionada).Tables[0];
				header = new Node(key, "Menú");

			}
			else if (key.ToUpper().IndexOf("SEPARATOR") == -1) 
			{
				table = mz.erp.businessrules.sy_Herramientas.GetListHijos(_idBarraDeHerramientaSeleccionada, Convert.ToInt64(key)).Tables[0];
				header = new Node(key, key);
			}
			else
				header = new Node(key, key);


			if(_idBarraDeHerramientaSeleccionada == 2)
			{
				if(table.Rows.Count > 0)
				{
					DataView dv = new DataView( table, "IsNull( IdHerramientaPadre, -1 ) <> -1", "IdHerramientaPadre, orden", DataViewRowState.OriginalRows );
					foreach( DataRowView drv in dv )
					{
						keyH = drv["IdHerramienta"].ToString();
						tipoR = Convert.ToInt64(drv["IdTipoRecurso"]);
						HerramientaEx herramienta = this.GetHerramienta(keyH, tipoR);
						if(herramienta != null)
						{
							descriptionH = herramienta.Descripcion;
							if(tipoR == ID_TIPO_RECURSO_TITULO)
							{
								habilitado = herramienta.Habilitado;
								if(habilitado)
									descriptionH = descriptionH + " (Habilitado)";
								else
									descriptionH = descriptionH + " (Deshabilitado)";
								Node child = new Node(keyH, descriptionH);
								header.AddChild(child);
							}
							else if(tipoR == ID_TIPO_RECURSO_SEPARATOR)
							{
								keyH = "Separator_" + drv["IdRecurso"].ToString();;
								descriptionH = "Separador";
								Node child = new Node(keyH, descriptionH);
								header.AddChild(child);
							}
						}
					}
				}
			}
			else
			{

				foreach (System.Data.DataRow rowH in table.Rows) 
				{
					keyH = rowH["IdHerramienta"].ToString();
					tipoR = Convert.ToInt64(rowH["IdTipoRecurso"]);
					string IdRecurso = rowH["IdRecurso"].ToString();
					HerramientaEx herramienta = this.GetHerramienta(keyH, tipoR);
					if(tipoR == ID_TIPO_RECURSO_SEPARATOR)
                        herramienta = this.GetSeparador(IdRecurso);
					else
						herramienta = this.GetHerramienta(keyH, tipoR);
					if(herramienta != null)
					{
						descriptionH = herramienta.Descripcion;
						if(tipoR == ID_TIPO_RECURSO_TITULO)
						{
							habilitado = herramienta.Habilitado;
							if(habilitado)
								descriptionH = descriptionH + " (Habilitado)";
							else
								descriptionH = descriptionH + " (Deshabilitado)";
							Node child = new Node(keyH, descriptionH);
							header.AddChild(child);
							HerramientaEx separador = this.GetHerramienta(keyH, ID_TIPO_RECURSO_SEPARATOR);
							if(separador != null)
							{
								keyH = "Separator_" + separador.IdRecurso.ToString();
								descriptionH = "Separador";
								Node childS = new Node(keyH, descriptionH);
								header.AddChildBeforeLast(childS);
							}
						}
						else if(tipoR == ID_TIPO_RECURSO_SEPARATOR)
						{
							keyH = "Separator_" + rowH["IdRecurso"].ToString();
							descriptionH = "Separador";
							Node child = new Node(keyH, descriptionH);
							header.AddChildBeforeLast(child);
						}
					}
				}
				header = this.OrdenarMenu(header);
			}

			return header;
		}



/*		public override Node getChildsNode(string key)
		{
			System.Data.DataTable table = new DataTable();
			string descriptionH = String.Empty;
			string keyH = String.Empty;
			long tipoR = long.MinValue;
			bool habilitado = false;
			Node header;
			if (key.ToUpper().Equals("RAIZ")) 
			{
				table = mz.erp.businessrules.sy_Herramientas.GetListPadres(_idBarraDeHerramientaSeleccionada).Tables[0];
				header = new Node(key, "Menú");

			}
			else if (key.ToUpper().IndexOf("SEPARATOR") == -1) 
			{
				table = mz.erp.businessrules.sy_Herramientas.GetListHijos(_idBarraDeHerramientaSeleccionada, Convert.ToInt64(key)).Tables[0];
				header = new Node(key, key);
			}
			else
				header = new Node(key, key);


			if(_idBarraDeHerramientaSeleccionada == 2)
			{
				if(table.Rows.Count > 0)
				{
					DataView dv = new DataView( table, "IsNull( IdHerramientaPadre, -1 ) <> -1", "IdHerramientaPadre, orden", DataViewRowState.OriginalRows );
					foreach( DataRowView drv in dv )
					{
						descriptionH = drv["Descripcion"].ToString();
						keyH = drv["IdHerramienta"].ToString();
						tipoR = Convert.ToInt64(drv["IdTipoRecurso"]);
						if(tipoR == ID_TIPO_RECURSO_TITULO)
						{
							habilitado = (bool) drv["Habilitado"];
							if(habilitado)
								descriptionH = descriptionH + " (Habilitado)";
							else
								descriptionH = descriptionH + " (Deshabilitado)";
							Node child = new Node(keyH, descriptionH);
							header.AddChild(child);
						}
						else if(tipoR == ID_TIPO_RECURSO_SEPARATOR)
						{
							keyH = "Separator_" + drv["IdRecurso"].ToString();;
							descriptionH = "Separador";
							Node child = new Node(keyH, descriptionH);
							header.AddChild(child);
						}
					}
				}
			}
			else
			{

				foreach (System.Data.DataRow rowH in table.Rows) 
				{
					descriptionH = rowH["Descripcion"].ToString();
					keyH = rowH["IdHerramienta"].ToString();
					tipoR = Convert.ToInt64(rowH["IdTipoRecurso"]);
					if(tipoR == ID_TIPO_RECURSO_TITULO)
					{
						habilitado = (bool) rowH["Habilitado"];
						if(habilitado)
							descriptionH = descriptionH + " (Habilitado)";
						else
							descriptionH = descriptionH + " (Deshabilitado)";
						Node child = new Node(keyH, descriptionH);
						header.AddChild(child);
					}
					else if(tipoR == ID_TIPO_RECURSO_SEPARATOR)
					{
						keyH = "Separator_" + rowH["IdRecurso"].ToString();;
						descriptionH = "Separador";
						Node child = new Node(keyH, descriptionH);
						header.AddChildBeforeLast(child);
					}
				}
			}

			return header;
		}
*/
		public override ArrayList GetFields()
		{
			return new ArrayList();
		}

		public override void GetJerarquia(string key)
		{
		}

		public  override string  GetUIClass()
		{
			return "mz.erp.ui.controllers.tsa_CuentasObservaciones";
		}

		public override string GetUIClassAgrupamientos()
		{
			return "mz.erp.ui.controllers.tsa_AgrupCuentasObservaciones";
		}


		public override void InitializeData()
		{
		}

		public override void ProcesarElementos(ArrayList rows)
		{
		}

		public override void RelacionarJerarquiaElementos()
		{

		}

		public override DataTable SearchAgrupamientos(object target)
		{
			return null;
		}

		#endregion

	}

	public class HerramientaEx
	{
		#region Constructores
		public HerramientaEx()
		{
		}

		public HerramientaEx(long IdBarraHerramienta, long IdHerramienta, long IdHerramientaPadre, string Id, string ShortCut, bool Habilitado, short Orden, long IdRecurso, string Descripcion, long IdTipoRecurso, ArrayList PerfilesHerramientas, string Modo, ConfigurarMenues ConfigMenuesInstance)
		{		
			_idBarraHerramienta = IdBarraHerramienta; 
			_idHerramienta = IdHerramienta;			
			_idHerramientaPadre = IdHerramientaPadre;
			_id = Id;
			_shortCut = ShortCut;	
			_habilitado = Habilitado;
			_orden = Orden;			
			_idRecurso = IdRecurso;
			_descripcion = Descripcion;
			_idTipoRecurso = IdTipoRecurso;
            _perfilesHerramientas = PerfilesHerramientas;
			_configMenues = ConfigMenuesInstance;
			_modo = Modo;
		}
		#endregion

		#region Variables Privadas
		private ConfigurarMenues _configMenues = null;
		#endregion

		#region Propiedades

		private long _idBarraHerramienta;
		public long IdBarraHerramienta 
		{
			get {return _idBarraHerramienta;}
		}

		private long _idHerramienta;
		public long IdHerramienta 
		{
			get {return _idHerramienta;}
		}

		private long _idHerramientaPadre;
		public long IdHerramientaPadre 
		{
			set {_idHerramientaPadre = value;}
			get {return _idHerramientaPadre;}
		}

		private string _id;
		public string Id 
		{
			get {return _id;}
		}
		private string _shortCut;
		public string ShortCut 
		{
			get {return _shortCut;}
			set {_shortCut = value;}

		}




		private bool _habilitado;
		public bool Habilitado 
		{
			get {return _habilitado;}
			set {_habilitado = value;}

		}

		private short _orden;
		public short Orden 
		{
			get {return _orden;}
			set {_orden = value;}
		}

		private long _idRecurso;
		public long IdRecurso 
		{
			get {return _idRecurso;}
		}
		private string _descripcion;
		public string Descripcion 
		{
			get {return _descripcion;}
			set {_descripcion = value;}
		}

		private long _idTipoRecurso;
		public long IdTipoRecurso 
		{
			get {return _idTipoRecurso;}
		}
		private ArrayList _perfilesHerramientas;
		public ArrayList PerfilesHerramientas 
		{
			get {return _perfilesHerramientas;}
			set {_perfilesHerramientas = value;}

		}
		private string _modo = string.Empty;
		public string Modo 
		{
			get {return _modo;}
			set {_modo = value;}
		}

		private string _imagen = string.Empty;
		public string Imagen
		{
			get
			{
				if(_imagen.Equals(string.Empty))
				{
					businessrules.HerramientaEx ImagenHerramienta = _configMenues.GetHerramienta(this.IdHerramienta.ToString(), ConfigurarMenues.ID_TIPO_RECURSO_IMAGEN);
					if(ImagenHerramienta != null)
						_imagen = ImagenHerramienta.Descripcion;
					else
						_imagen = "None";
				}
				return _imagen;

			}
			set {_imagen = value;}
		}

		public string Perfiles 
		{
			get 
			{
				string nombresPerfiles = string.Empty;
				foreach(PerfilView perfil in _perfilesHerramientas)
				{
					if(nombresPerfiles.Equals(string.Empty))
						nombresPerfiles = perfil.Descripcion;	
					else
				        nombresPerfiles += "," + perfil.Descripcion;
				}
				return nombresPerfiles;
			}

		}
		#endregion

		#region Metodos Publicos
		public override System.Boolean Equals ( System.Object obj )
		{
			return this.IdHerramienta.Equals(((HerramientaEx)obj).IdHerramienta) && this.IdRecurso.Equals(((HerramientaEx)obj).IdRecurso);
		}

		#endregion


	}

}
