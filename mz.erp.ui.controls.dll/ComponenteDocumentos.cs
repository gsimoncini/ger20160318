using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;




namespace mz.erp.ui.controls
{
	/// <summary>
	/// Descripción breve de ComponenteDocumentos.
	/// </summary>
	public class ComponenteDocumentos : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label1;
		private mz.erp.ui.controls.mzComboEditor mzCmbTiposDocumento;
		private string _tipoDoc="";
		private ArrayList _propTipoDoc = new ArrayList();
		private string _numero = "0";
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNumero;

		/// <summary> 
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ComponenteDocumentos()
		{
			// Llamada necesaria para el Diseñador de formularios Windows.Forms.
			InitializeComponent();
			SetStyle(ControlStyles.AllPaintingInWmPaint | 
				ControlStyles.UserPaint | 
				ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor,
				true);    
			this.BackColor = Color.Transparent;

			// TODO: agregar cualquier inicialización después de llamar a InitializeComponent

		}

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
			}
			base.Dispose( disposing );
		}

		#region Código generado por el Diseñador de componentes
		/// <summary> 
		/// Método necesario para admitir el Diseñador. No se puede modificar 
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.mzCmbTiposDocumento = new mz.erp.ui.controls.mzComboEditor();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTiposDocumento)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "Tipo de Documento";
			// 
			// mzCmbTiposDocumento
			// 
			this.mzCmbTiposDocumento.DataSource = null;
			this.mzCmbTiposDocumento.DisplayMember = "";
			this.mzCmbTiposDocumento.DisplayMemberCaption = "";
			this.mzCmbTiposDocumento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbTiposDocumento.Location = new System.Drawing.Point(112, 2);
			this.mzCmbTiposDocumento.MaxItemsDisplay = 7;
			this.mzCmbTiposDocumento.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbTiposDocumento.Name = "mzCmbTiposDocumento";
			this.mzCmbTiposDocumento.Size = new System.Drawing.Size(136, 21);
			this.mzCmbTiposDocumento.SorterMember = "";
			this.mzCmbTiposDocumento.TabIndex = 63;
			this.mzCmbTiposDocumento.ValueMember = "";
			this.mzCmbTiposDocumento.ValueMemberCaption = "";
			this.mzCmbTiposDocumento.ValueChanged += new System.EventHandler(this.mzCmbTiposDocumento_ValueChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(272, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 23);
			this.label2.TabIndex = 65;
			this.label2.Text = "Numero";
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(328, 2);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(168, 20);
			this.txtNumero.TabIndex = 66;
			this.txtNumero.Text = "";
			// 
			// ComponenteDocumentos
			// 
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.mzCmbTiposDocumento);
			this.Controls.Add(this.label1);
			this.Name = "ComponenteDocumentos";
			this.Size = new System.Drawing.Size(504, 24);
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTiposDocumento)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void mzCmbTiposDocumento_ValueChanged(object sender, System.EventArgs e)
		{
				_tipoDoc=(string)((mz.erp.ui.controls.mzComboEditor) sender).Value;
		}

		private void txtNumero_Leave(object sender, System.EventArgs e)
		{
			if (_propTipoDoc.Contains(this.TipoDocSelected ) )
			{
				if (!Cuit.Control(txtNumero.Text))	 
				{
					MessageBox.Show( this, "El numero indicado es invalido para el tipo de documento seleccionado","Alerta!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
				}					
				_numero= txtNumero.Text;
			}
			else _numero= txtNumero.Text;	
		}
		#region TipoDocSelected

		public string  GetTipoDocSelected()
		{
			return TipoDocSelected ;
		}
		public void SetTipoDoc(string value)
		{
			TipoDocSelected = value;
		}
		//Propiedad de Lectura/Escritura que se usa para set/get el tipo de Documento seleccionado en el coombobox
		public string TipoDocSelected
		{
			get 
			{
				if(mzCmbTiposDocumento.Value== null) return "";
				else return (string)mzCmbTiposDocumento.Value;
			}
			set
			{
				_tipoDoc = value;
				mzCmbTiposDocumento.Value=_tipoDoc;
			}

		}
		#endregion

		#region TipoDocPropEscritura

		/*public void SetTipoDoc(object value)
		{
			TipoDoc = value;
		}*/
		//Propiedad de solo escritura que se usa setear el tipo de documento que se debe validad
		public ArrayList TipoDoc
		{
			set 
			{
				_propTipoDoc = value;
			}

		}

		#endregion
		
		#region Numero
		/*public void SetNumero(string value)
		{
			Numero = value;
		}
		public string  GetNumero()
		{
			return Numero;
		}*/
		
		//Propiedad de L/E que se usa para get/set el numero del componente
		public string Numero
		{
			set 
			{
				if (value != "") 
				{
					_numero = value;				
					txtNumero.Text= _numero;
				}
			}

			get
			{
				this.txtNumero_Leave(this, new EventArgs());
				return  _numero;
			}

		}

		
		


		#endregion

		public void FillFromDataSource( DataTable dataSource, string valueMember, string displayMember, int maxItemsDisplay, string valueMemberCaption, string displayMemberCaption, string sorterMember )
		{
			mzCmbTiposDocumento.FillFromDataSource( dataSource, valueMember, displayMember, maxItemsDisplay, valueMemberCaption,displayMemberCaption, sorterMember);
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			
			// Calling the base class OnPaint
			base.OnPaint(pe);
			// Create two semi-transparent colors
			/*Color c1 = Color.FromArgb
				(0 ,0,0,0 );
			Color c2 = Color.FromArgb
				(0 ,0,0,0);
			Brush b = new System.Drawing.Drawing2D.LinearGradientBrush
				(ClientRectangle, c1, c2, 10);
			pe.Graphics.FillRectangle (b, ClientRectangle);
			b.Dispose();
			*/
			
			
		}
		


		
		public int CantItems
		{
			set
			{
				this.mzCmbTiposDocumento.MaxItemsDisplay = value;
			}
		}

		public class Cuit
		{
			public Cuit()
			{
				//
				// TODO: agregar aquí la lógica del constructor
				//
			}
			public static bool Control(string codigo)
			{			
				//Acepta números de CUIT con o sin guiones.
				string SinGuiones;
				SinGuiones = SacarGuiones(codigo);
				return ControlInt(SinGuiones);
			}

			private static string SacarGuiones(string codigo)
			{
				string resultado=codigo.Replace("-","");
				//Debug.WriteLine(resultado);
				//Debug.WriteLine(Convert.ToInt16('_'));
				return resultado;			
			}

			private static bool ControlInt(string codigo)
			{
				int[,] mat = new int[,] {{5,0}, {4,0}, {3,0}, {2,0}, {7,0}, {6,0}, {5,0}, {4,0}, {3,0}, {2,0}};  
				string str = codigo;	
				//
				if(codigo.Length != 11) return false;
				char[] arrCuit = str.ToCharArray(0, 10);						
				char[] arrVerificador = str.ToCharArray(10,1);
				int Verificador = Convert.ToInt16(arrVerificador.GetValue(0).ToString());	
			
				for (int i=0; i < 10; i++) 			
				{
					mat[i,1] = Convert.ToInt16(arrCuit[i].ToString());				
				}
			
				int suma = 0;
				int resto = 0;
				int dif = 0;			

				for (int j=0; j < 10; j++) 
				{
					suma = suma + mat[j,0] * mat[j,1];
				}
				resto = suma % 11;
				dif = 11 - resto;
				if (dif > 9) 
				{
					dif = 0;
				}		
				return (dif == Verificador);		
			}
			
		}




		}







	}

