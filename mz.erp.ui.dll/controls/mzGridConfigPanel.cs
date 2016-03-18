using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using mz.erp.ui.controllers;
using mz.erp.commontypes;

namespace mz.erp.ui.controls
{
	/// <summary>
	/// Descripción breve de mzGridConfigPanel.
	/// </summary>
	public class mzGridConfigPanel : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chVisualizacion;
		private Infragistics.Win.Misc.UltraButton bReestablecer;
		private Infragistics.Win.Misc.UltraButton bGuardar;

		private System.ComponentModel.Container components = null;

		#region constructores
		
		public mzGridConfigPanel()
		{
			InitializeComponent();
			Init();
		}
		
		private void Init()
		{
			InitData();
			InitEventsHandler();
			InitDataBindings();
			
		}

		private void InitEventsHandler()
		{
			bGuardar.Click += new EventHandler(bGuardar_Click);
			bReestablecer.Click += new EventHandler(bReestablecer_Click);
		}

		private void InitDataBindings()
		{
			BindingController.Bind(	chVisualizacion, "Checked", this , "LoadFromFile");
		}

		private void InitData()
		{
			_loadFromFile = true;
		}
		#endregion

		#region destructores
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
				BindingController.Clear( chVisualizacion, "Checked", this , "LoadFromFile");
			}
			base.Dispose( disposing );

		}

		#endregion
		
		#region Código generado por el Diseñador de componentes
		/// <summary> 
		/// Método necesario para admitir el Diseñador. No se puede modificar 
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chVisualizacion = new System.Windows.Forms.CheckBox();
			this.bReestablecer = new Infragistics.Win.Misc.UltraButton();
			this.bGuardar = new Infragistics.Win.Misc.UltraButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.bReestablecer);
			this.groupBox1.Controls.Add(this.bGuardar);
			this.groupBox1.Controls.Add(this.chVisualizacion);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(304, 43);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			// 
			// chVisualizacion
			// 
			this.chVisualizacion.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.chVisualizacion.Location = new System.Drawing.Point(0, -8);
			this.chVisualizacion.Name = "chVisualizacion";
			this.chVisualizacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.chVisualizacion.Size = new System.Drawing.Size(168, 32);
			this.chVisualizacion.TabIndex = 9;
			this.chVisualizacion.Text = "Visualización personalizada";
			this.chVisualizacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// bReestablecer
			// 
			this.bReestablecer.AcceptsFocus = false;
			this.bReestablecer.Location = new System.Drawing.Point(136, 16);
			this.bReestablecer.Name = "bReestablecer";
			this.bReestablecer.Size = new System.Drawing.Size(152, 22);
			this.bReestablecer.TabIndex = 8;
			this.bReestablecer.TabStop = false;
			this.bReestablecer.Text = "&Restablecer  Configuración";
			// 
			// bGuardar
			// 
			this.bGuardar.AcceptsFocus = false;
			this.bGuardar.Location = new System.Drawing.Point(8, 16);
			this.bGuardar.Name = "bGuardar";
			this.bGuardar.Size = new System.Drawing.Size(128, 22);
			this.bGuardar.TabIndex = 7;
			this.bGuardar.TabStop = false;
			this.bGuardar.Text = "&Guardar Configuración";
			// 
			// mzGridConfigPanel
			// 
			this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.Controls.Add(this.groupBox1);
			this.Name = "mzGridConfigPanel";
			this.Size = new System.Drawing.Size(304, 43);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Variables Privadas
			
		private mz.erp.ui.controllers.mzGridConfigPanelController _uiController = new mzGridConfigPanelController();
		
		private Janus.Windows.GridEX.GridEX _gridSource;
		private string _layoutDefault;
		private bool _loadFromFile; 
		
		#endregion

		#region Propiedades
		
		public Janus.Windows.GridEX.GridEX GridSource
		{
			get{ return _gridSource;}
			set
			{ 
				if (value != null)
				{
					_gridSource = value;
					_uiController.GridName = _gridSource.Name;
				}
			}
		}

		public string ProcessName
		{
			get{ return _uiController.ProcessName;}
			set{ _uiController.ProcessName = value;}
		}
		public string TaskName
		{
			get{ return _uiController.TaskName;}
			set{ _uiController.TaskName = value;}
		}

		public string LayoutDefault
		{
			set {_layoutDefault = value;}
			get {return _layoutDefault;}
		}

		public bool LoadFromFile
		{
			get{return _loadFromFile;}
			set
			{
				if (_loadFromFile != value)
				{
					_loadFromFile = value;
					bGuardar.Enabled = value;
					bReestablecer.Enabled = value;
					if( _gridSource != null)
					{
						if (value)
						{
							if (System.IO.File.Exists(_uiController.Path) )
							{
								System.IO.StreamReader str = new System.IO.StreamReader(_uiController.Path);
								_gridSource.LoadLayoutFile(str.BaseStream);
								str.Close();
							}
						}
						else
						{
							_gridSource.LayoutData = _layoutDefault;
						}
						if (LayoutChanged != null)
							LayoutChanged (this, new EventArgs());
					}
				}
			}
		}


		#endregion

		#region Eventos

		public event EventHandler LayoutChanged; 
		public event EventHandler LoadFromFileChanged;
		
		#endregion

		#region metodos privados
		
		private void bGuardar_Click(object sender, EventArgs e)
		{
			if (_gridSource != null)
			{
				string path = _uiController.Path;
				System.IO.StreamWriter str = new System.IO.StreamWriter(path);
				_gridSource.SaveLayoutFile(str.BaseStream);
				str.Close();
			}
		}

		private void bReestablecer_Click(object sender, EventArgs e)
		{
			this.LoadLayout();
			if (_gridSource != null)
				if (LayoutChanged != null)
					LayoutChanged(this, new EventArgs());
		}

		/*private void chVisualizacion_CheckedChanged(object sender, EventArgs e)
		{
			bGuardar.Enabled = chVisualizacion.Checked;
			bReestablecer.Enabled = chVisualizacion.Checked;
			if( _gridSource != null)
			{
				if (chVisualizacion.Checked)
				{
					if (System.IO.File.Exists(_uiController.Path) )
					{
						System.IO.StreamReader str = new System.IO.StreamReader(_uiController.Path);
						_gridSource.LoadLayoutFile(str.BaseStream);
						str.Close();
						_loadFromFile = true;
					}
				}
				else
				{
					_gridSource.LayoutData = _layoutDefault;
					_loadFromFile = false;
				}
			}
		}*/
		#endregion
		
		#region metodos publicos
	
		public void LoadLayout()
		{
			if (_gridSource != null)
			{
				if (System.IO.File.Exists(_uiController.Path) )
				{
					System.IO.StreamReader str = new System.IO.StreamReader(_uiController.Path);
					_gridSource.LoadLayoutFile(str.BaseStream);
					str.Close();
					_loadFromFile = true;
				}
				else 
				{
					_gridSource.LayoutData = _layoutDefault;
					_loadFromFile = false;
				}
			}
		}
	
		public void Initialize(string Process, string Task, string LayoutDefault )
		{
			this.ProcessName = Process;
			this.TaskName = Task;
			this.LayoutDefault = LayoutDefault;
			this.LoadLayout();
		}

		#endregion
	}
}
