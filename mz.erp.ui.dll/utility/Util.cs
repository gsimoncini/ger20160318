using System;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;

namespace mz.erp.ui.utility
{
	/// <summary>
	/// Descripción breve de Util.
	/// </summary>
	public class Util
	{
        /*Constantes para cargar las imagenes en los formularios*/
        //Cristian Configuracion ImageList 20110717
        private const string IMAGEN_CANCELAR = "cancel16.bmp";
        private const string IMAGEN_ANTERIOR = "arrowleft_red24.bmp";
        private const string IMAGEN_SIGUIENTE = "arrowright_red24.bmp";
        private const string IMAGEN_NUEVA_BUSQUEDA = "new16.bmp";
        private const string IMAGEN_ACTUALIZAR = "refresh16.bmp";
        private const string IMAGEN_BUSCAR_AHORA = "search16.bmp";
        private const string IMAGEN_IMPRIMIR = "print16.bmp";
        private const string IMAGEN_GUARDAR = "save16.bmp";
        private const string IMAGEN_PREVIOUS = "previous16.bmp";
        private const string IMAGEN_NEXT = "next16.bmp";
        private const string IMAGEN_FIRST = "first16.bmp";
        private const string IMAGEN_LAST = "last16.bmp";
        private const string IMAGEN_FINALIZAR = "stop16.bmp";
        //Cristian tarea 0000192 20110817
        private const string IMAGEN_NUEVO = "insert16.bmp"; 
        //Fin Cristian Tarea 0000192
        //Fin Cristian Configuracion ImageList 20110717

        /* Silvina 20110804 - Tarea 0000178 */
        private const string IMAGEN_EDITAR = "edit16.bmp";
        /* Fin Silvina 20110804 - Tarea 0000178 */

        /* Silvina 20111226 - Tarea 0000241 */
        private const string IMAGEN_CTACTE = "user_ctacte.bmp";
        private const string IMAGEN_ACEPTAR = "post16.bmp";
        /* Fin Silvina 20111226 - Tarea 0000241 */

        //Cristian tarea 0000243 20111230
        private const string IMAGEN_CARGA_PRECIO = "insert16.bmp";
        //Fin Cristian Tarea 0000243
		public Util()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

        /// <summary>
        /// Carga las imagenes para los formularios del estilo Buscador de productos(F3)
        /// </summary>
        //Cristian Configuracion ImageList 20110717
        public static void LoadImagesBuscador(ToolBar toolBar, ImageList imgList)
        {
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_ACTUALIZAR));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_NUEVA_BUSQUEDA));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_BUSCAR_AHORA));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_ANTERIOR));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_SIGUIENTE));
            imgList.Images.Add(Image.FromFile(GetDirImage() + "cancel16.bmp"));
            imgList.Images.Add(Image.FromFile(GetDirImage() + "arrowdown_blue24.bmp"));
            toolBar.ImageList = imgList;
        }

        /// <summary>
        /// Retorna el directorio de los iconos del Sistema
        /// </summary>
        private static string GetDirImage()
        {
            return AppDomain.CurrentDomain.BaseDirectory + "resources\\Icons\\"; ;
        }
        //FIn Cristian Configuracion ImageList 20110717

        /* Silvina 20120416 - Tarea 0000277 */
        public static void LoadImagesCuentaCorriente(ToolBar toolBar, ImageList imgList)
        {
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_FIRST));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_PREVIOUS));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_NEXT));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_LAST));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_ACEPTAR));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_ACTUALIZAR));//5
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_EDITAR));//6
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_CANCELAR));//7
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_ANTERIOR));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_IMPRIMIR));//9
            toolBar.ImageList = imgList;

        }
        /* Fin Silvina 20120416 - Tarea 0000277 */

        /* Silvina 20111226 - Tarea 0000241 */
        public static void LoadImagesBuscadorCuentas(ToolBar toolBar, ImageList imgList)
        {

            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_FIRST));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_PREVIOUS));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_NEXT));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_LAST));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_GUARDAR));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_ACTUALIZAR));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_EDITAR));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_CANCELAR));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_SIGUIENTE));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_ANTERIOR));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_BUSCAR_AHORA));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_NUEVO));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_ACEPTAR));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_CTACTE));

            toolBar.ImageList = imgList;

        }
        /* Fin Silvina 20111226 - Tarea 0000241 */

        //Cristian Configuracion ImageList 20110717
        public static void LoadImages(ToolBar toolBar,ImageList imgList)
        {
 
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_FIRST));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_PREVIOUS));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_NEXT));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_LAST));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_GUARDAR));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_ACTUALIZAR));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_FINALIZAR));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_CANCELAR));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_SIGUIENTE));           
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_ANTERIOR));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_IMPRIMIR));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_IMPRIMIR));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_BUSCAR_AHORA));
            //Cristian Tarea 00243 20111230
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_CARGA_PRECIO));
            //Fin Cristian
           // imgList.Images.Add(Image.FromFile(GetDirImage() + "search16.bmp"));

           // imgList.Images.Add(Image.FromFile(GetDirImage() + "new16.bmp"));


           // imgList.Images.Add(Image.FromFile(GetDirImage() + "cancel16.bmp"));

            //Imagen flecha arriba
           // imgList.Images.Add(Image.FromFile(GetDirImage() + "arrowdown_blue24.bmp"));

            toolBar.ImageList = imgList;

        }
        //FIn Cristian Configuracion ImageList 20110717

        //Cristian Configuracion ImageList 20110717
        public static void LoadImagesWorkflow(ToolBar toolBar, ImageList imgList)
        {            
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_CANCELAR));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_ANTERIOR));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_SIGUIENTE));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_FINALIZAR));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_IMPRIMIR));
            toolBar.ImageList = imgList;

        }
        //FIn Cristian Configuracion ImageList 20110717

        //Cristian Tarea 0000192  20110817
        public static void LoadImagesABMEx(ToolBar toolBar, ImageList imgList)
        {
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_IMPRIMIR));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_NUEVA_BUSQUEDA));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_BUSCAR_AHORA));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_NUEVO));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_EDITAR));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_BUSCAR_AHORA));
            
            toolBar.ImageList = imgList;
        }
        //FIn Cristian 20110817
		
        /* Silvina 20110804 - Tarea 0000178 */
        public static void LoadImagesAbmCuentas(ToolBar toolBar, ImageList imgList)
        {
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_FIRST));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_PREVIOUS));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_NEXT));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_LAST));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_GUARDAR));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_ACTUALIZAR));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_EDITAR));
            imgList.Images.Add(Image.FromFile(GetDirImage() + IMAGEN_CANCELAR));
            toolBar.ImageList = imgList;
        }
        /* Fin Silvina 20110804 - Tarea 0000178 */

		public static void MoveFocus(object sender) 
		{
			if (sender.GetType() == typeof(Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl)) 
			{
				Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl componente = (Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl)sender;								
			
				if (componente.Controls.Count >= 2) 
				{
					if (componente.Controls[0].Focused == true) 
					{
						componente.Controls[1].Select();
					}
					else 
					{
						componente.Controls[0].Select();
					}					
				}
			}
			if (sender.GetType() == typeof(System.Windows.Forms.Panel))
			{
				System.Windows.Forms.Panel componente = (System.Windows.Forms.Panel) sender;
				if (componente.Controls.Count >= 2) 
				{
					if (componente.Controls[0].Focused == true) 
					{
						componente.Controls[1].Select();
					}
					else 
					{
						componente.Controls[0].Select();
					}					
				}
			}
		}

		
		public static void VisualizacionContenedores(Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar, string Proceso, string Tarea)
		{						
			string ListaContenedoresVisibles = mz.erp.businessrules.Variables.GetValueString(Proceso, Tarea, "ContenedoresVisibles");
			string ListaContenedoresHabilitados = mz.erp.businessrules.Variables.GetValueString(Proceso, Tarea, "ContenedoresHabilitados");

			foreach( Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup group in ultraExplorerBar.Groups)
			{				
				group.Visible = false;
				if (group.Container != null)
					group.Container.Enabled = false;
			}

			if(!ListaContenedoresVisibles.Equals(string.Empty))
			{
				ArrayList cont = mz.erp.systemframework.Util.Parse(ListaContenedoresVisibles, ",");
				foreach(string grupo in cont)
				{
					ultraExplorerBar.Groups[grupo].Visible = true;					
				}
			}

			if(!ListaContenedoresHabilitados.Equals(string.Empty))
			{								
				ArrayList cont = mz.erp.systemframework.Util.Parse(ListaContenedoresHabilitados, ",");
				foreach(string grupo in cont)
				{
					if (ultraExplorerBar.Groups[grupo].Container != null)
						ultraExplorerBar.Groups[grupo].Container.Enabled = true;
				}
			}
		}


	}
}
