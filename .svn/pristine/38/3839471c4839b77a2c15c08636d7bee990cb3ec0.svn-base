using System;

using System.Reflection;

using System.Windows.Forms;
using System.Xml;



namespace mz.erp
{
    class Program
    {
        //FIn Tarea 129 20110617
        static private void appendSubFolders()
        {

            String fullPathLib = Application.StartupPath.ToString() + "\\lib";
            String fullPathAssemblies = Application.StartupPath.ToString() + "\\Assemblies";

            AppDomain.CurrentDomain.AppendPrivatePath(fullPathLib);
            AppDomain.CurrentDomain.AppendPrivatePath(fullPathAssemblies);
            //Cristian - Prueba Separacion de Librerias 20110517
          
            XmlDocument modifiedRuntimeSection = new XmlDocument();
            XmlDocument docApp = new XmlDocument();
            
            //Cristian Tarea 0000192
            String fullPath = string.Empty;
            //if (!AppDomain.CurrentDomain.FriendlyName.Contains("vshost"))
            //{
            //    fullPath = AppDomain.CurrentDomain.BaseDirectory + "Configuration\\" +
            //               AppDomain.CurrentDomain.FriendlyName + ".config";
           // }
           // else
           // {
                fullPath = Assembly.GetEntryAssembly().Location + ".config";
            //}
             
            docApp.Load(fullPath);
            //Cristian Tarea 0000192 20110817
             modifiedRuntimeSection.Load(AppDomain.CurrentDomain.BaseDirectory + "Assemblyrebinding.xml");
            //Fin Cristian Tarea 0000192
		    if(docApp.SelectSingleNode("/configuration/runtime") == null)
		    {
                docApp.DocumentElement.InnerXml += modifiedRuntimeSection.InnerXml;
                docApp.Save(fullPath);
		    }

        }
        //Fin Cristian Tarea 20110617 

        [STAThread]
        static void Main()
        {
            //Cristian Tarea 129 20110
            appendSubFolders();

            Assembly ensamblado = Assembly.GetExecutingAssembly();

            //Retorna la lista de librerias referenciadas 
            Assembly MyAssembly, objExecutingAssemblies;
            string strTempAssmbPath = "";
            objExecutingAssemblies = Assembly.GetExecutingAssembly();
            AssemblyName[] arrReferencedAssmbNames = objExecutingAssemblies.GetReferencedAssemblies();

            //Carga de las DLL 
            foreach (AssemblyName strAssmbName in arrReferencedAssmbNames)
            {
                {
                    Console.WriteLine("Referencia ---- " + strAssmbName.Name);
                    MyAssembly = Assembly.Load(strAssmbName);
                }

            }
			
            Type typeMainForm = Type.GetType("mz.erp.MainForm", false);
            Object instanciaForm = Activator.CreateInstance(typeMainForm);
            Application.Run((Form)instanciaForm);

            //FIn Tarea 129 20110617

                  
        }

    }
}
