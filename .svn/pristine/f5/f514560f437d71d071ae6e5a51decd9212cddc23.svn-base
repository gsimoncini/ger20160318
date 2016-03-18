using System;
using System.Data;
using mz.erp.systemframework;
using mz.erp.commontypes.data;
using System.Collections;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de st_OrdenReparacion.
	/// </summary>
	public class st_OrdenReparacion
	{
		public st_OrdenReparacion()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}


		public static st_OrdenReparacionDataset.st_OrdenReparacionRow GetByPk(string IdOrdenReparacion)
		{
			st_OrdenReparacionDataset.st_OrdenReparacionRow row = mz.erp.dataaccess.st_OrdenReparacion.GetByPk(IdOrdenReparacion);
			foreach ( DataColumn dc in row.Table.Columns ) 
			{
				if (row[dc] == System.DBNull.Value && !dc.Caption.ToUpper().Equals("ULTIMAMODIFICACION"))
				{
					row[dc] = Util.DefaultValue( dc.DataType );
				}
			}
			return row;
		}

		public static DataSet GetDetalleTareasByPk(string IdOrdenReparacion)
		{
			return mz.erp.dataaccess.st_OrdenReparacion.GetDetalleTareasByPk( IdOrdenReparacion);
		}
		
		public static DataSet GetDetalleRepuestosByPk(string IdOrdenReparacion)
		{
			return mz.erp.dataaccess.st_OrdenReparacion.GetDetalleRepuestosByPk( IdOrdenReparacion);
		}
		
		public static ArrayList IncluyeProducto(string IdComprobante, long  OrdinalOrigen, string IdProducto)
		{
			ArrayList result = new ArrayList();
			DataTable table = mz.erp.dataaccess.st_OrdenReparacion.IncluyeProducto(IdComprobante, OrdinalOrigen,  IdProducto);
			result.Add(table.Rows.Count == 1);
			result.Add(table);
			return result;
		}

		public static DataSet GetProductosParaDevolver(string IdOrdenReparacion, long IdInstanciaOrdenReparacion, string IdEstadosDeStock) 
		{
			return mz.erp.dataaccess.st_OrdenReparacion.GetProductosParaDevolver(IdOrdenReparacion, IdInstanciaOrdenReparacion, IdEstadosDeStock);
		}
		
		public static DataSet GetNumerosDeSeriesParaDevolver(long IdOrdenReparacion, long IdInstanciaOrdenReparacion, string IdEstadosDeStock) 
		{
			return mz.erp.dataaccess.st_OrdenReparacion.GetNumerosDeSeriesParaDevolver(IdOrdenReparacion, IdInstanciaOrdenReparacion, IdEstadosDeStock);
		}
		


		
		public static DataSet GetByComprobanteAsociado(string IdComprobante, long Ordinal)
		{
			return mz.erp.dataaccess.st_OrdenReparacion.GetByComprobanteAsociado(IdComprobante, Ordinal);
		}

		public static DataSet ListarTareasRealizadas(long IdOrdenReparacion, string IdPersona)
		{
			return mz.erp.dataaccess.st_OrdenReparacion.ListarTareasRealizadas(IdOrdenReparacion, IdPersona);
		}
	
		public static DataSet GetComentarios(long IdOrdenReparacion)
		{
			return mz.erp.dataaccess.st_OrdenReparacion.GetComentarios(IdOrdenReparacion);
		}

		public static DataSet GetFallas(long IdOrdenReparacion)
		{
			return mz.erp.dataaccess.st_OrdenReparacion.GetFallas(IdOrdenReparacion);
		}
	}
}
