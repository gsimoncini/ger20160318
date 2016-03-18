using System;
using System.Data;
using mz.erp.commontypes.data;
using mz.erp.dataaccess;
using mz.erp.systemframework;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de Controlador.
	/// </summary>
	public class Controlador
	{
		public Controlador()
		{
		}

		public void Init()
		{	

		}

		public void Init(Type tipo) //en tipo llega algo como mz.erp.businessrules.tlg_Transportes
		{	
		}

		public void Init(Object instance)
		{
	
		}
		public void Init(Type tipo, Object instance)
		{	
			System.Console.WriteLine("llego al INIT sobrecargado: "+ tipo.ToString());
			
            //por cada columna que tenga el data set de la tabla que me llegue
			/*try 
			{
				string IdTransporte = ((mz.erp.commontypes.data.tlg_TransportesDataset.tlg_TransportesRow)(instance)).IdTransporte;
				mz.erp.commontypes.data.tlg_TransportesDataset.tlg_TransportesRow row = mz.erp.businessrules.tlg_Transportes.GetByPk(IdTransporte);
				foreach ( DataColumn dc in row.Table.Columns ) 
				{
					if (row[dc] == System.DBNull.Value)
					{
						if (dc.Caption != "RowId" ) 
						{ 
							row[dc] = Util.DefaultValue( dc.DataType ); 
						}					
					}	
				}
			}
			catch (Exception e) 
			{	
				System.Console.WriteLine(e.Message);
			}*/

		}

		public void Save()
		{
		}
		public void Save(Object Instance)
		{
			System.Console.WriteLine("llego al SAVE de la clase controladora");
			mz.erp.commontypes.data.tlg_TransportesDataset.tlg_TransportesRow row = ((mz.erp.commontypes.data.tlg_TransportesDataset.tlg_TransportesRow)(Instance));
			foreach ( DataColumn dc in row.Table.Columns ) 
			{
				//((mz.erp.commontypes.data.tlg_TransportesDataset.tlg_TransportesRow)(_instance)).Descripcion = descripcion.Text;	
		
			}
		}

		
	}
}
