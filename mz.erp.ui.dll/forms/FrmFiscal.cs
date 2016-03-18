using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using mz.erp.ui.controllers;
using mz.erp.ui.forms.classes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmFiscal.
	/// </summary>
	public class FrmFiscal : System.Windows.Forms.Form, ITaskForm
	{
		private System.Windows.Forms.ListBox listBox1;
		private System.ComponentModel.IContainer components;
		private InterfaceFiscal IFiscal;
		private bool _soportaComprobante;
		protected System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		private System.Windows.Forms.ToolBarButton tbStep3;
		protected System.Windows.Forms.ToolBarButton tbCancelar;
		protected System.Windows.Forms.ToolBarButton tbContinuar;
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private HtmlRichText.HtmlRichTextBox htmlRichTextBox1;
		private mz.erp.ui.controllers.FiscalController _uiController;
        
		public bool SoportaComprobante 
		
		{			
			get
			{				
				return _soportaComprobante;
			}
		}		

		public FrmFiscal()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//			
			InitializeComponent();
			listBox1.Items.Clear();
            //Matias 20110902 - Tarea 0000131
            this.eFacturaOfiscal();
            //FinMatias 20110902 - Tarea 0000131
			this.Show();			

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}

		

		public FrmFiscal(mz.erp.ui.controllers.FiscalController controller)
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//			
			InitializeComponent();
			_uiController = controller;
            //Matias 20110902 - Tarea 0000131
            this.eFacturaOfiscal();
            //FinMatias 20110902 - Tarea 0000131
			Init();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}

        //Matias 20110902 - Tarea 0000131        
        public void eFacturaOfiscal()
        {
            if (_uiController.EFacturaHabilitada)
            {
                string enter = "\r\n";
                if ((MessageBox.Show(this, "¿Desea generar la factura electrónica?" + Environment.NewLine + "(El mismo no será emitido por la impresora fiscal)", "Pregunta", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK))
                {
                    //El usuario decidio generar la eFactura
                    _uiController.EFacturaGenerar = true;
                    this.SetMensajePorEFactura();
                }
            }
            else
            {
                _uiController.EFacturaGenerar = false; //Me aseguro de NO generar la eFactura
            }
            //Caso contrario, continuar proceso normalmente ==> generar factura de manera tradicional (por impresion fiscal)
        }
        public void SetMensajePorEFactura()
        {
            htmlRichTextBox1.AddHTML("Factura Electrónica en proceso...<br><br>", true);
            htmlRichTextBox1.AddHTML("Aguarde por favor.<br>", true);
        }
        //FinMatias 20110902 - Tarea 0000131


		private void Init() 
		{
			listBox1.Items.Clear();			
			tbContinuar.Enabled = false; tbbAnterior.Enabled = false;
			_uiController.OnModelChanged += new EventHandler(this.OnChangeEstadoFiscal);
			//_uiController.OnTaskAfterExecute += new EventHandler(this.OnFinaliza);		
			KeyPreview = true;
			KeyDownManager KeyDownMan = new KeyDownManager(this);	
		}

		public void ShowForm()
		{
            //Matias 20110902 - Tarea 0000131
			//if (_uiController.AllowShow())
            //if (_uiController.AllowShow() && (!_uiController.EFacturaHabilitada || (_uiController.EFacturaHabilitada && !_uiController.EFacturaGenerar) ) )
            if (_uiController.AllowShow() || _uiController.EFacturaHabilitada)
            //FinMatias 20110902 - Tarea 0000131
			{
				Show();								
			}
			if(_uiController.IsNextState())
					this._uiController.Execute();
				else
					if(_uiController.IsBackState())
					this._uiController.Previous();
			
		}

		public void CloseForm()
		{
			//Si está todo bien se debe fijar en la variable Fiscal.CierreAutomatico
			//Sino no se tiene que cerrar			
			if (_uiController.IsValid || _uiController.IsBackState()) 
			{				
				if (_uiController.CierreAutomatico) 
				{
					Close();
				}
			}
		}

		public void KeyDownPrevious()
		{
			this.Previous();
		}

		public void KeyDownNext()
		{
			this.Execute();
		}

		public bool ImpresionFiscal(ComprobanteDeVenta Comprobante, string TipoComprobante) 
		{
			/*if (TipoComprobante == "FA" || TipoComprobante == "NC" || TipoComprobante == "ND" ||
				TipoComprobante == "TI" || TipoComprobante == "TF" || TipoComprobante == "RM")

			{
				IFiscal = new InterfaceFiscal(Comprobante, TipoComprobante);				
				IFiscal.OnChangeEstadoFiscal += new EventHandler(this.OnChangeEstadoFiscal);
				if (IFiscal.ImpresionFiscal()) 
				{
					//this.Close();
					return true;
				}								
				_soportaComprobante = IFiscal.SoportaComprobante;
			}
			else 
			{
				_soportaComprobante = false;
			}*/
			return false;
		}

		/*public bool Cierre(char Tipo) 
		{
			try 
			{
				IFiscal = new InterfaceFiscal();
				IFiscal.OnChangeEstadoFiscal += new EventHandler(this.OnChangeEstadoFiscal);
				if (IFiscal.Cierre(Tipo))
				{
					this.Close();
					return true;
				}				
			}			
			catch
			{			
				this.Close();
				MessageBox.Show( "Error en el módulo fiscal. No se puede imprimir el reporte " + Tipo + ".","Error", MessageBoxButtons.OK, MessageBoxIcon.Error );				
				return false;
			}	
			
			return false;						
		}*/
			
		/*public bool Sincronizacion() 
		{
			IFiscal = new InterfaceFiscal();
			//IFiscal = new InterfaceFiscal(Variables.GetValueString("Fiscal.Comprobante"));
			IFiscal.OnChangeEstadoFiscal += new EventHandler(this.OnChangeEstadoFiscal);
			return IFiscal.Sincronizacion();									
		}*/

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
				_uiController.OnModelChanged -= new EventHandler(this.OnChangeEstadoFiscal);

			}
			base.Dispose( disposing );
		}

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmFiscal));
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.tbContinuar = new System.Windows.Forms.ToolBarButton();
			this.tbStep3 = new System.Windows.Forms.ToolBarButton();
			this.tbCancelar = new System.Windows.Forms.ToolBarButton();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.htmlRichTextBox1 = new HtmlRichText.HtmlRichTextBox();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.listBox1.Location = new System.Drawing.Point(2, 32);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(386, 446);
			this.listBox1.TabIndex = 2;
			this.listBox1.Visible = false;
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.tbbAnterior,
																							  this.toolBarButton7,
																							  this.tbContinuar,
																							  this.tbStep3,
																							  this.tbCancelar});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(392, 28);
			this.toolBarStandar.TabIndex = 18;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			// 
			// tbbAnterior
			// 
			this.tbbAnterior.ImageIndex = 9;
			this.tbbAnterior.Text = "&Anterior";
			// 
			// toolBarButton7
			// 
			this.toolBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbContinuar
			// 
			this.tbContinuar.ImageIndex = 8;
			this.tbContinuar.Text = "&Siguiente";
			// 
			// tbStep3
			// 
			this.tbStep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.tbStep3.Visible = false;
			// 
			// tbCancelar
			// 
			this.tbCancelar.ImageIndex = 7;
			this.tbCancelar.Text = "Cancelar";
			this.tbCancelar.Visible = false;
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// htmlRichTextBox1
			// 
			this.htmlRichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.htmlRichTextBox1.Location = new System.Drawing.Point(0, 28);
			this.htmlRichTextBox1.Name = "htmlRichTextBox1";
			this.htmlRichTextBox1.Size = new System.Drawing.Size(392, 450);
			this.htmlRichTextBox1.TabIndex = 91;
			this.htmlRichTextBox1.Text = "";
			// 
			// FrmFiscal
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(392, 478);
			this.Controls.Add(this.htmlRichTextBox1);
			this.Controls.Add(this.toolBarStandar);
			this.Controls.Add(this.listBox1);
			this.Name = "FrmFiscal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Impresión de comprobante fiscal";
			this.ResumeLayout(false);

		}
		#endregion

		public void CargarUltimoEstado(string estado) 
		{
			bool AgregaItem = true;
//			if (listBox1.Items.Count > 0) 
//			{
//				//Chequeo que el próximo estado no sea igual al anterior.
//				if (listBox1.Items[listBox1.Items.Count - 1] == estado) 
//				{
//					AgregaItem = false;					
//				}
//			}

			if (AgregaItem) 
			{
				string Enter = "<br>";
				//listBox1.Items.Add(estado);
				htmlRichTextBox1.AddHTML(estado + Enter, true);
			}			
		}

		private void OnChangeEstadoFiscal(object Sender, System.EventArgs e) 
		{														
			this.CargarUltimoEstado(_uiController.Mensaje);
			this.Refresh();
			tbContinuar.Enabled = _uiController.EnabledBotonContinuar;
			tbbAnterior.Enabled = _uiController.EnabledBotonContinuar;
		}


		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					this.Previous();
					break;
				case 2:
					//tbContinuar.Enabled = false;
					//listBox1.Items.Clear();
					//_uiController.Execute();
					this.Execute();
					break;				
			}		

		}

		public void Execute()
		{
			tbContinuar.Enabled = false;
			listBox1.Items.Clear();
			htmlRichTextBox1.Clear();
            //Matias 20110905 - Tarea 0000131
            if (_uiController.EFacturaHabilitada && _uiController.EFacturaGenerar)
                this.SetMensajePorEFactura();
            //FinMatias 20110905 - Tarea 0000131
			this._uiController.Execute();
			tbContinuar.Enabled = true;
		}

		public void Previous()
		{
			this._uiController.Previous();
		}

	}
}
