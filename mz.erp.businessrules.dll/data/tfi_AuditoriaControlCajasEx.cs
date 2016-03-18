namespace mz.erp.businessrules
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.businessrules.comprobantes;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;
	using mz.erp.systemframework;
	using System.Collections;
    using System.Data.SqlClient;
	/// <summary>
	/// Descripción breve de tfi_AuditoriaControlCajasEx.
	/// </summary>
	public class tfi_AuditoriaControlCajasEx
	{
		public tfi_AuditoriaControlCajasEx()
		{
		}

		public static void Update (tfi_AuditoriaControlCajasExDataset data, SentenciasReplicacion replicacion )
		{
			mz.erp.dataaccess.tfi_AuditoriaControlCajasEx.Update( data, replicacion );
		}

		public static System.Data.DataSet GetAuditoriaCajasAbiertas ( string IdCajas)
		{
			return mz.erp.dataaccess.tfi_AuditoriaControlCajasEx.GetAuditoriaCajasAbiertas( IdCajas );
		}

		public static System.Data.DataSet GetAuditoriaCajasCerradas ( string IdCajas, System.DateTime fechaApertura, System.DateTime fechaCierre)
		{
			return mz.erp.dataaccess.tfi_AuditoriaControlCajasEx.GetAuditoriaCajasCerradas( IdCajas, fechaApertura, fechaCierre );
		}
	
		public static System.Data.DataSet GetAuditoriaCajasAbiertasYCerradas ( string IdCajas, System.DateTime fechaApertura, System.DateTime fechaCierre)
		{
			return mz.erp.dataaccess.tfi_AuditoriaControlCajasEx.GetAuditoriaCajasAbiertasYCerradas( IdCajas, fechaApertura, fechaCierre );
		}
	}
}
