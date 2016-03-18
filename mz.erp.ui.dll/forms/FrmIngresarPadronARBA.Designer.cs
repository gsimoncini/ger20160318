//Matias 20110422 - Tarea 0000061
namespace mz.erp.ui.forms
{
    partial class FrmIngresarPadronARBA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.labelTarea = new System.Windows.Forms.Label();
            this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFileChooser = new Infragistics.Win.Misc.UltraButton();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolBarStandar = new System.Windows.Forms.ToolBar();
            this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
            this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
            this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
            this.imglStandar = new System.Windows.Forms.ImageList(this.components);
            this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
            this.ultraExplorerBarContainerControl2.SuspendLayout();
            this.ultraExplorerBarContainerControl5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
            this.ultraExplorerBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraExplorerBarContainerControl2
            // 
            this.ultraExplorerBarContainerControl2.Controls.Add(this.labelTarea);
            this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 24);
            this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
            this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(829, 27);
            this.ultraExplorerBarContainerControl2.TabIndex = 9;
            // 
            // labelTarea
            // 
            this.labelTarea.BackColor = System.Drawing.Color.Transparent;
            this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarea.Location = new System.Drawing.Point(0, 0);
            this.labelTarea.Name = "labelTarea";
            this.labelTarea.Size = new System.Drawing.Size(829, 23);
            this.labelTarea.TabIndex = 1;
            this.labelTarea.Text = "Tarea";
            this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ultraExplorerBarContainerControl5
            // 
            this.ultraExplorerBarContainerControl5.Controls.Add(this.panel1);
            this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, 108);
            this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
            this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(829, 254);
            this.ultraExplorerBarContainerControl5.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnFileChooser);
            this.panel1.Controls.Add(this.txtFileName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 62);
            this.panel1.TabIndex = 135;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 15);
            this.label3.TabIndex = 141;
            this.label3.Tag = "FechaFin";
            this.label3.Text = "(Tiempo aprox. de ejecución: 1 / 2 minutos)";
            // 
            // btnFileChooser
            // 
            this.btnFileChooser.Location = new System.Drawing.Point(118, 16);
            this.btnFileChooser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFileChooser.Name = "btnFileChooser";
            this.btnFileChooser.Size = new System.Drawing.Size(28, 22);
            this.btnFileChooser.TabIndex = 135;
            this.btnFileChooser.Text = "...";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(151, 18);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(552, 20);
            this.txtFileName.TabIndex = 136;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 137;
            this.label1.Tag = "FechaFin";
            this.label1.Text = "Seleccionar archivo";
            // 
            // toolBarStandar
            // 
            this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbbAnterior,
            this.tbbSeparator,
            this.tbbSiguiente,
            this.tbbSeparator2,
            this.tbbCancelar});
            this.toolBarStandar.DropDownArrows = true;
            this.toolBarStandar.ImageList = this.imglStandar;
            this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
            this.toolBarStandar.Name = "toolBarStandar";
            this.toolBarStandar.ShowToolTips = true;
            this.toolBarStandar.Size = new System.Drawing.Size(878, 28);
            this.toolBarStandar.TabIndex = 23;
            this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            // 
            // tbbAnterior
            // 
            this.tbbAnterior.ImageIndex = 9;
            this.tbbAnterior.Name = "tbbAnterior";
            this.tbbAnterior.Text = "&Anterior";
            // 
            // tbbSeparator
            // 
            this.tbbSeparator.Name = "tbbSeparator";
            this.tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbSiguiente
            // 
            this.tbbSiguiente.ImageIndex = 8;
            this.tbbSiguiente.Name = "tbbSiguiente";
            this.tbbSiguiente.Text = "&Siguiente";
            // 
            // tbbSeparator2
            // 
            this.tbbSeparator2.Name = "tbbSeparator2";
            this.tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbCancelar
            // 
            this.tbbCancelar.ImageIndex = 7;
            this.tbbCancelar.Name = "tbbCancelar";
            this.tbbCancelar.Text = "&Cancelar";
            // 
            // imglStandar
            // 
            this.imglStandar.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
            this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
            // 
            // ultraExplorerBar1
            // 
            this.ultraExplorerBar1.AnimationEnabled = false;
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl5);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
            this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl2;
            ultraExplorerBarGroup1.Key = "Tarea";
            ultraExplorerBarGroup1.Settings.ContainerHeight = 27;
            ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
            ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup1.Text = "Tarea";
            ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl5;
            ultraExplorerBarGroup2.Key = "Cabecera";
            ultraExplorerBarGroup2.Settings.ContainerHeight = 254;
            ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup2.Text = "Datos Generales";
            this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
            ultraExplorerBarGroup1,
            ultraExplorerBarGroup2});
            this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
            this.ultraExplorerBar1.Name = "ultraExplorerBar1";
            this.ultraExplorerBar1.Size = new System.Drawing.Size(878, 409);
            this.ultraExplorerBar1.TabIndex = 24;
            this.ultraExplorerBar1.TabStop = false;
            // 
            // FrmIngresarPadronARBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 437);
            this.Controls.Add(this.ultraExplorerBar1);
            this.Controls.Add(this.toolBarStandar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmIngresarPadronARBA";
            this.Text = "FrmIngresarPadronARBA";
            this.ultraExplorerBarContainerControl2.ResumeLayout(false);
            this.ultraExplorerBarContainerControl5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
            this.ultraExplorerBar1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolBar toolBarStandar;
        private System.Windows.Forms.ToolBarButton tbbAnterior;
        private System.Windows.Forms.ToolBarButton tbbSeparator;
        private System.Windows.Forms.ToolBarButton tbbSiguiente;
        private System.Windows.Forms.ToolBarButton tbbSeparator2;
        private System.Windows.Forms.ToolBarButton tbbCancelar;
        private System.Windows.Forms.ImageList imglStandar;
        protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
        private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
        private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
        private System.Windows.Forms.Label labelTarea;
        private System.Windows.Forms.Panel panel1;
        private Infragistics.Win.Misc.UltraButton btnFileChooser;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}