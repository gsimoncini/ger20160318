using System;
using System.Drawing;
using System.Windows.Forms;

using Infragistics.Win;
using Infragistics.Win.UltraWinToolbars;
using Infragistics.Win.UltraWinExplorerBar;
using Infragistics.Win.UltraWinDock;

using System.Data;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.businessrules;
using mz.erp.systemframework;
using System.Xml;
using System.Text;


namespace mz.erp.ui.utility
{
	public class ToolsLoader
	{
		private const long ID_MAIN_MENU = 1;
		private const long ID_STANDAR_TOOLBAR = 2;
		private const long ID_EXPLORER_BAR = 3;

		private const long ID_TIPO_RECURSO_TITULO = 1;
		private const long ID_TIPO_RECURSO_IMAGEN = 4;
		private const long ID_TIPO_RECURSO_TOOLTIP = 5;
		private const long ID_TIPO_RECURSO_SEPARATOR = 7;

		private static int _indexSeparator = 1;

		public ToolsLoader()
		{
		}

		/*public static void Load( UltraToolbarsManager toolbar, UltraExplorerBar explorerbar)
		{
			_indexSeparator = 1;
			Load( toolbar );
			Load( explorerbar);
		}*/

		public static void Load( UltraToolbarsManager toolbar, UltraExplorerBar explorerbar, UltraDockManager ultraDockManager )
		{
			_indexSeparator = 1;
			Load( toolbar );
			Load( explorerbar, ultraDockManager );
		}


		public static void Load( UltraToolbarsManager toolbar )
		{

            sy_HerramientasDataset data;
			data = businessrules.sy_Herramientas.GetList( ID_MAIN_MENU, Security.IdPerfil );
			LoadItems( new DataView( data.sy_Herramientas, "IsNull( IdHerramientaPadre, -1 ) = -1", "orden", DataViewRowState.OriginalRows ), toolbar, null );
			
			data = businessrules.sy_Herramientas.GetList( ID_STANDAR_TOOLBAR, Security.IdPerfil );
			LoadItems( new DataView( data.sy_Herramientas, "IsNull( IdHerramientaPadre, -1 ) <> -1", "IdHerramientaPadre, orden", DataViewRowState.OriginalRows ), toolbar );
		}

		#region HasChilds

		private static bool HasChilds( DataTable dt, long idHerramienta )
		{
			return ( ( new DataView( dt, string.Format( "IdHerramientaPadre = {0}", idHerramienta ), null, DataViewRowState.OriginalRows ) ).Count > 0 );
		}

		#endregion


		#region GetRecurso

		public static string GetRecurso( long IdTipoRecurso, long IdHerramienta )
		{
			sy_RecursosDataset _recursos = businessrules.sy_Recursos.GetList( Security.IdIdioma, IdHerramienta );

			DataView dv = new DataView( _recursos.sy_Recursos, string.Format ( "IdTipoRecurso = {0}", IdTipoRecurso ), string.Empty, DataViewRowState.OriginalRows );

			if ( dv.Count == 1 )
			{
				return ( string )dv[ 0 ][ "Descripcion" ];
			}
			else
			{
				return string.Empty;
			}
			
		}

		#endregion
		#region Habilitado

		private static  bool IsAvaible(DataRowView drv)
		{

			return (bool)drv["Habilitado"];

		}


		#endregion



		public static void LoadItems( DataView dv, UltraToolbarsManager toolbar )
		{
			long IdHerPadre = long.MinValue;
			
			foreach( DataRowView drv in dv )
			{
				if (IsAvaible(drv))
				{
					long IdHerramienta = ( long )drv[ "IdHerramienta" ];
					
					
					ToolBase buttonTool;

					string id = ( string )drv[ "id" ];
					System.Console.WriteLine(IdHerramienta);
					System.Console.WriteLine(id);

					if ( toolbar.Tools.Exists( id )  )
					{
						buttonTool = toolbar.Tools[ id ];
                        //Cristian Tarea 881
                        buttonTool.SharedProps.ToolTipText = GetRecurso(ID_TIPO_RECURSO_TOOLTIP, IdHerramienta);
                        //Fin Tarea 881
					}
					else
					{
						buttonTool = new ButtonTool( id );
						buttonTool.SharedProps.ToolTipText = GetRecurso( ID_TIPO_RECURSO_TITULO, IdHerramienta );
					

						if ( GetRecurso( ID_TIPO_RECURSO_IMAGEN, IdHerramienta ) != string.Empty )
						{
                            //German 20110329 - Tarea 0000093
                            ImageList ilSmall = toolbar.ImageListSmall;
                            string prueba =
                                string.Format(
                                    mz.erp.systemframework.Util.ResourcePath() + "\\resources\\Icons\\" +
                                    GetRecurso(ID_TIPO_RECURSO_IMAGEN, IdHerramienta), "16");
                            Image image1 = null;
                            try
                            {
                                System.Drawing.Icon c = new Icon(prueba);
                                image1 = c.ToBitmap();
                            }
                            catch (Exception e)
                            {
                                image1 = Image.FromFile(prueba);
                                //int smallIndexImage = ilSmall.Images.Add( Image.FromFile(  prueba), System.Drawing.Color.Magenta );

                            }
                            int smallIndexImage = ilSmall.Images.Add(image1, System.Drawing.Color.Magenta);

                            ImageList ilLarge = toolbar.ImageListLarge;
                            prueba =
                                string.Format(
                                    mz.erp.systemframework.Util.ResourcePath() + "\\resources\\Icons\\" +
                                    GetRecurso(ID_TIPO_RECURSO_IMAGEN, IdHerramienta), "24");
                            //int largeIndexImage = ilLarge.Images.Add(Image.FromFile(prueba), System.Drawing.Color.Magenta);
                            try
                            {
                                System.Drawing.Icon c = new Icon(prueba);
                                image1 = c.ToBitmap();
                            }
                            catch (Exception e)
                            {
                                image1 = Image.FromFile(prueba);
                                //int smallIndexImage = ilSmall.Images.Add( Image.FromFile(  prueba), System.Drawing.Color.Magenta );

                            }
                            int largeIndexImage = ilLarge.Images.Add(image1, System.Drawing.Color.Magenta);
                            //Fin German 20110329 - Tarea 0000093


							buttonTool.SharedProps.AppearancesSmall.Appearance.Image = smallIndexImage;
							buttonTool.SharedProps.AppearancesLarge.Appearance.Image = largeIndexImage;
						}
					
						toolbar.Tools.Add( buttonTool );

					}

					buttonTool.SharedProps.DisplayStyle = ToolDisplayStyle.ImageOnlyOnToolbars;

					UltraToolbar standarBar = toolbar.Toolbars[ "Estándar" ];

		
					standarBar.Tools.AddTool( id );
					if (!((long)drv["IdHerramientaPadre"]).Equals(IdHerPadre))
					
				 
					{
						IdHerPadre =(long)drv["IdHerramientaPadre"];
						standarBar.Tools[id].InstanceProps.IsFirstInGroup = true;

					}
				}

			}
		}

		public static void LoadItems( DataView dv, UltraToolbarsManager toolbar, PopupMenuTool popupMenuTool )
		{
			string id;
			string Shortcut="";

		

				foreach( DataRowView drv in dv )
				{
					if (IsAvaible(drv))
					{
						long IdHerramienta = ( long )drv[ "IdHerramienta" ];
						id = ( string )drv[ "id" ];
						System.Console.WriteLine(IdHerramienta);
						System.Console.WriteLine(id);


						if ( HasChilds( dv.Table, IdHerramienta ) ||  drv[ "IdHerramientaPadre" ] == System.DBNull.Value )
						{
							PopupMenuTool newPopupMenuTool = new PopupMenuTool( id );
				
							newPopupMenuTool.SharedProps.Caption = GetRecurso( ID_TIPO_RECURSO_TITULO, IdHerramienta );

							
							UltraToolbar mainMenuBar = toolbar.Toolbars[ "Menú principal" ];

							toolbar.Tools.Add( newPopupMenuTool );

							bool visible = Convert.ToBoolean(drv["Visible"]);
							newPopupMenuTool.SharedProps.Visible = visible;

                            //German 20110329 - Tarea 0000093
						    newPopupMenuTool.DropDownArrowStyle = DropDownArrowStyle.None;
                            //Fin German 20110329 - Tarea 0000093
                            
                            if ( drv[ "IdHerramientaPadre" ] == System.DBNull.Value )
							{
								mainMenuBar.Tools.Add( newPopupMenuTool );
                                //German 20110328 - Tarea 0000093
                                //newPopupMenuTool.SharedProps.DisplayStyle = ToolDisplayStyle.TextOnlyInMenus;
                                
                                //Fin German 20110328 - Tarea 0000093
							}
							else
							{
								if ( GetRecurso( ID_TIPO_RECURSO_SEPARATOR, IdHerramienta ) != string.Empty )
								{	
									newPopupMenuTool.InstanceProps.IsFirstInGroup = true;	
								}
								
								popupMenuTool.Tools.Add( newPopupMenuTool );

							}

							LoadItems( new DataView( dv.Table, string.Format( "IdHerramientaPadre = {0}", drv[ "IdHerramienta" ] ), null, DataViewRowState.OriginalRows ), toolbar, newPopupMenuTool );
						}
						else
						{
							//Debería tomar de herramientas recursos idiomas
							//ButtonTool newButtonTool = new ButtonTool( GetRecurso( ID_TIPO_RECURSO_TITULO, IdHerramienta ) );
						
								ButtonTool newButtonTool = new ButtonTool( id );
					
								
								newButtonTool.SharedProps.Caption = GetRecurso( ID_TIPO_RECURSO_TITULO, IdHerramienta );
								
								if (drv["Shortcut"] != System.DBNull.Value)
								{
									Shortcut= (string ) drv["Shortcut"];
									newButtonTool.SharedProps.Shortcut = (System.Windows.Forms.Shortcut )Enum.Parse(typeof(System.Windows.Forms.Shortcut),Shortcut,true);
								}
								if ( GetRecurso( ID_TIPO_RECURSO_IMAGEN, IdHerramienta ) != string.Empty )
								{
                                    //German 20110329 - Tarea 0000093
                                    ImageList ilSmall = toolbar.ImageListSmall;
								    string prueba =
								        string.Format(
								            mz.erp.systemframework.Util.ResourcePath() + "\\resources\\Icons\\" +
								            GetRecurso(ID_TIPO_RECURSO_IMAGEN, IdHerramienta), "16");
								    Image image1 = null;
                                    try
								    {
								        System.Drawing.Icon c = new Icon(prueba);
								        image1 = c.ToBitmap();
								    }
                                    catch(Exception e)
								    {
								        image1 = Image.FromFile(prueba);
                                        //int smallIndexImage = ilSmall.Images.Add( Image.FromFile(  prueba), System.Drawing.Color.Magenta );
								        
								    }
                                    int smallIndexImage = ilSmall.Images.Add(image1, System.Drawing.Color.Magenta);

									ImageList ilLarge = toolbar.ImageListLarge;
								    prueba =
								        string.Format(
								            mz.erp.systemframework.Util.ResourcePath() + "\\resources\\Icons\\" +
								            GetRecurso(ID_TIPO_RECURSO_IMAGEN, IdHerramienta), "24");
                                    //int largeIndexImage = ilLarge.Images.Add(Image.FromFile(prueba), System.Drawing.Color.Magenta);
                                    try
								    {
								        System.Drawing.Icon c = new Icon(prueba);
								        image1 = c.ToBitmap();
								    }
                                    catch(Exception e)
								    {
								        image1 = Image.FromFile(prueba);
                                        //int smallIndexImage = ilSmall.Images.Add( Image.FromFile(  prueba), System.Drawing.Color.Magenta );
								        
								    }
                                    int largeIndexImage = ilLarge.Images.Add(image1, System.Drawing.Color.Magenta);

                                    //Fin German 20110329 - Tarea 0000093
									newButtonTool.SharedProps.AppearancesSmall.Appearance.Image = smallIndexImage;
									newButtonTool.SharedProps.AppearancesLarge.Appearance.Image = largeIndexImage;
								}
								
								newButtonTool.SharedProps.DisplayStyle = ToolDisplayStyle.ImageAndText;
								string SepKey = GetRecurso( ID_TIPO_RECURSO_SEPARATOR, IdHerramienta );
								bool visible = Convert.ToBoolean(drv["Visible"]);
							
					
								toolbar.Tools.Add( newButtonTool );
								
							try
							{
								popupMenuTool.Tools.Add( newButtonTool );
								if (  SepKey != string.Empty )
								{	
									popupMenuTool.Tools[id].InstanceProps.IsFirstInGroup = true;
									//newButtonTool.InstanceProps.IsFirstInGroup = true;
									
								}
								if(!visible)
									popupMenuTool.Tools[id].InstanceProps.Visible = Infragistics.Win.DefaultableBoolean.False;

							}
							catch(Exception e)
							{
								Console.WriteLine(e.Message);
							}
							
						
					
						}
					}
				}
			
		}

		public static void LoadItems( DataView dv, UltraExplorerBar explorerBar, UltraExplorerBarGroup explorerBarGroup )
		{
			foreach( DataRowView drv in dv )
			{
				long IdHerramienta = ( long )drv[ "IdHerramienta" ];
				string id = ( string )drv[ "id" ];
				System.Console.WriteLine(IdHerramienta);
				System.Console.WriteLine(id);

				if ( HasChilds( dv.Table, IdHerramienta ) )
				{

					UltraExplorerBarGroup newExplorerBarGroup = new UltraExplorerBarGroup( GetRecurso( ID_TIPO_RECURSO_TITULO, IdHerramienta ) );
					newExplorerBarGroup.Text = GetRecurso( ID_TIPO_RECURSO_TITULO, IdHerramienta );
					
					explorerBar.Groups.Add( newExplorerBarGroup );

					LoadItems( new DataView( dv.Table, string.Format( "IdHerramientaPadre = {0}", drv[ "IdHerramienta" ] ), null, DataViewRowState.OriginalRows ), explorerBar, newExplorerBarGroup );
				}
				else
				{
					UltraExplorerBarItem newExplorerBarItem = new UltraExplorerBarItem(id );
					newExplorerBarItem.Text = GetRecurso( ID_TIPO_RECURSO_TITULO, IdHerramienta );

					if ( GetRecurso( ID_TIPO_RECURSO_IMAGEN, IdHerramienta ) != string.Empty )
					{
                        //German 20110329 - Tarea 0000093
                        ImageList ilSmall = explorerBar.ImageListSmall;
                        string prueba =
                            string.Format(
                                mz.erp.systemframework.Util.ResourcePath() + "\\resources\\Icons\\" +
                                GetRecurso(ID_TIPO_RECURSO_IMAGEN, IdHerramienta), "16");
                        Image image1 = null;
                        try
                        {
                            System.Drawing.Icon c = new Icon(prueba);
                            image1 = c.ToBitmap();
                        }
                        catch (Exception e)
                        {
                            image1 = Image.FromFile(prueba);
                            //int smallIndexImage = ilSmall.Images.Add( Image.FromFile(  prueba), System.Drawing.Color.Magenta );

                        }
                        int smallIndexImage = ilSmall.Images.Add(image1, System.Drawing.Color.Magenta);

                        ImageList ilLarge = explorerBar.ImageListLarge;
                        prueba =
                            string.Format(
                                mz.erp.systemframework.Util.ResourcePath() + "\\resources\\Icons\\" +
                                GetRecurso(ID_TIPO_RECURSO_IMAGEN, IdHerramienta), "24");
                        //int largeIndexImage = ilLarge.Images.Add(Image.FromFile(prueba), System.Drawing.Color.Magenta);
                        try
                        {
                            System.Drawing.Icon c = new Icon(prueba);
                            image1 = c.ToBitmap();
                        }
                        catch (Exception e)
                        {
                            image1 = Image.FromFile(prueba);
                            //int smallIndexImage = ilSmall.Images.Add( Image.FromFile(  prueba), System.Drawing.Color.Magenta );

                        }
                        int largeIndexImage = ilLarge.Images.Add(image1, System.Drawing.Color.Magenta);
                        //Fin German 20110329 - Tarea 0000093


						newExplorerBarItem.Settings.AppearancesSmall.Appearance.Image = smallIndexImage;
						newExplorerBarItem.Settings.AppearancesLarge.Appearance.Image = largeIndexImage;
					}

					try 
					{
						explorerBarGroup.Items.Add( newExplorerBarItem );
					}
					catch{}
				}
			}
		}

		/*
			ultraExplorerBarGroup1.Items.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem[] {
																													  ultraExplorerBarItem1});
			ultraExplorerBarGroup1.ItemSettings.Style = Infragistics.Win.UltraWinExplorerBar.ItemStyle.Button;
			ultraExplorerBarGroup1.Text = "Tareas";
			ultraExplorerBarGroup2.Text = "Favoritos";
			this.explorerBar.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																												  ultraExplorerBarGroup1,
																												  ultraExplorerBarGroup2});
		
		*/

		/*public static void Load( UltraExplorerBar toolbar)
		{
			//sy_HerramientasDataset data = businessrules.sy_Herramientas.GetList( ID_EXPLORER_BAR, Security.IdPerfil );
			//LoadItems( new DataView( data.sy_Herramientas, "IsNull( IdHerramientaPadre, -1 ) = -1", "IdHerramienta", DataViewRowState.OriginalRows ), toolbar, null );

			sy_HerramientasDataset data = businessrules.sy_Herramientas.GetList( ID_EXPLORER_BAR, Security.IdPerfil );

			if (data.sy_Herramientas.Count == 0)
			{
				toolbar.Visible = false;
			}			
			else 
			{
				LoadItems( new DataView( data.sy_Herramientas, "IsNull( IdHerramientaPadre, -1 ) = -1", "IdHerramienta", DataViewRowState.OriginalRows ), toolbar, null );
				toolbar.Visible = true;
			}
		}*/

		public static void Load( UltraExplorerBar toolbar, UltraDockManager ultraDockManager )
		{
			sy_HerramientasDataset data = businessrules.sy_Herramientas.GetList( ID_EXPLORER_BAR, Security.IdPerfil );
			if (data.sy_Herramientas.Count == 0)
			{
				ultraDockManager.Visible = false;
			}			
			else 
			{
				LoadItems( new DataView( data.sy_Herramientas, "IsNull( IdHerramientaPadre, -1 ) = -1", "IdHerramienta", DataViewRowState.OriginalRows ), toolbar, null );
				ultraDockManager.Visible = true;
			}

		}



	}
}
