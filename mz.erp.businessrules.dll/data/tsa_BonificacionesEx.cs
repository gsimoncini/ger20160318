using System;
using System.Data;
using System.Text.RegularExpressions;
using mz.erp.businessrules;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.dataaccess;
using mz.erp.systemframework;

namespace mz.erp.businessrules.data
{
	/// <summary>
	/// Descripción breve de tsa_BonificacionesEx.
	/// </summary>
	public class tsa_BonificacionesEx
	{
		public tsa_BonificacionesEx()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}


		#region Custom Members
		public static decimal GetBonificacionCuenta( string IdCuenta )
		{
			return GetBonificacionCuenta( IdCuenta, 0);
		}

		public static decimal GetBonificacionCuenta( string IdCuenta, decimal valor )
		{
			tsa_CuentasDataset.tsa_CuentasRow rowCuenta = tsa_Cuentas.GetByPk( IdCuenta );
			decimal bonificacion = 0;
			if (rowCuenta == null)
			{
				return 0;
			}

			tsa_BonificacionesDetDataset dataBonificacionDet = tsa_BonificacionesDet.GetList( rowCuenta.IdBonificacion, valor );
			if (dataBonificacionDet.tsa_BonificacionesDet.Rows.Count > 0)
			{
				bonificacion =  ((tsa_BonificacionesDetDataset.tsa_BonificacionesDetRow)dataBonificacionDet.tsa_BonificacionesDet.Rows[0]).Valor;
			}
			return bonificacion;
		}


		[ atMethodNewRow ]
		public static tsa_BonificacionesExDataset NewRow()
		{
			tsa_BonificacionesExDataset data= new tsa_BonificacionesExDataset();
			tsa_BonificacionesExDataset.tsa_BonificacionesRow row= data.tsa_Bonificaciones.Newtsa_BonificacionesRow();
			SetRowDefaultValues(row);
			data.tsa_Bonificaciones.Rows.Add(row);
			return data;

		}

		public static tsa_BonificacionesExDataset.tsa_BonificacionesRow SetRowDefaultValues( tsa_BonificacionesExDataset.tsa_BonificacionesRow row )
		{
			row.IdBonificacion = Util.NewStringId(); 
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			row.Descripcion = string.Empty;
			row.IdTipoBonificacion = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;

			return row;
		}


		[atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsa_BonificacionesExDataset data )
		{
			ApplicationAssert.Check( data != null, "El argumento data no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( DatasetIsValid( data ) )
			{
				Update( data );
			}
			
		}

		public static void Update( tsa_BonificacionesExDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_Bonificaciones.Rows.Count > 0, "La tabla dataSet.tsa_BonificacionesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_BonificacionesEx.Update(dataSet);
		}



		
		/// <summary>
		/// Obtiene tabla tsa_Bonificaciones filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_BonificacionesExDataset GetList( string IdBonificacion, string Descripcion, string IdTipoBonificacion )
		{
			return mz.erp.dataaccess.tsa_BonificacionesEx.GetList( IdBonificacion, Descripcion, IdTipoBonificacion );
		}
		



		public static tsa_BonificacionesExDataset GetByPk( string IdBonificacion )
		{
		{
			tsa_BonificacionesExDataset data= new tsa_BonificacionesExDataset();
			data=(tsa_BonificacionesExDataset) mz.erp.dataaccess.tsa_BonificacionesEx.GetByPk(data,IdBonificacion);
			System.Data.DataTable tableBonificaciones=data.Tables["tsa_Bonificaciones"];
			System.Data.DataRow row = tableBonificaciones.Rows[0];
			data=(tsa_BonificacionesExDataset) mz.erp.dataaccess.tsa_BonificacionesEx.GetList(data, IdBonificacion );
			
			
			foreach ( DataTable table in data.Tables) 
			{
				foreach ( DataRow row1 in table.Rows )
				{
					foreach ( DataColumn dc in row1.Table.Columns )
					{
						if (row1[dc] == System.DBNull.Value)
						{
							row1[dc] = Util.DefaultValue( dc.DataType );
						}
					}
				}
				
			}
			return data;
		
		
		}

		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_Bonificaciones que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsa_BonificacionesExDataset GetByPk( object IdBonificacion )
		{
			return GetByPk( ( string )IdBonificacion );
		}
		
		#region delete
		[ atMethodDeleteRow]
		public static void Delete(tsa_BonificacionesExDataset data)
		{
			
			tsa_BonificacionesExDataset.tsa_BonificacionesRow row = (tsa_BonificacionesExDataset.tsa_BonificacionesRow)data.tsa_Bonificaciones.Rows[0];
			row.Delete();
			Update(row);
		
			if	(row.Table.HasErrors)
			{
				row.RejectChanges();
				row["Activo"] = false;
				Update(row);
				if (row.Table.HasErrors)
				{
					row.SetColumnError("IdValor","No se ha podido eliminar el item");
				}
				else
				{
					row.SetColumnError("IdValor","No se ha podido eliminar el item porque existen tablas relacionadas. Se ha procede a desactivar");
				}
			}
		

		}

		public static void Update( tsa_BonificacionesExDataset.tsa_BonificacionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_BonificacionesEx.Update( row );
		}
		
		#endregion




		#endregion




		public static decimal GetBonificacionProducto( string IdProducto, decimal cantidad )
		{
			tsh_ProductosDataset.tsh_ProductosRow rowProducto = tsh_Productos.GetByPk( IdProducto);
			decimal bonificacion = 0;
			if (rowProducto == null)
			{
				return 0;
			}
			tsa_BonificacionesDataset dataBonificacion = tsa_Bonificaciones.GetList( rowProducto.IdBonificacion, null, Constantes.TipoBonificacionProducto );
			tsa_BonificacionesDataset.tsa_BonificacionesRow rowBonificacion = null;
			if (dataBonificacion.tsa_Bonificaciones.Rows.Count > 0)
			{
				rowBonificacion = (tsa_BonificacionesDataset.tsa_BonificacionesRow)dataBonificacion.tsa_Bonificaciones.Rows[0];
			}
			else
			{
				return 0;
			}
			tsa_BonificacionesDetDataset dataBonificacionDet = tsa_BonificacionesDet.GetList( rowBonificacion.IdBonificacion, cantidad );
			if (dataBonificacionDet.tsa_BonificacionesDet.Rows.Count > 0)
			{
				bonificacion =  ((tsa_BonificacionesDetDataset.tsa_BonificacionesDetRow)dataBonificacionDet.tsa_BonificacionesDet.Rows[0]).Valor;
			}
			return bonificacion;

		}


		#region Validaciones


		public static bool DatasetIsValid(tsa_BonificacionesExDataset data)
		{	

			tsa_BonificacionesExDataset.tsa_BonificacionesDataTable tableBonificaciones=data.tsa_Bonificaciones;
			tsa_BonificacionesExDataset.tsa_BonificacionesRow row=(tsa_BonificacionesExDataset.tsa_BonificacionesRow)tableBonificaciones.Rows[0];
			bool ok= false;
			if (RowIsValid(row))
			{
				ok=true;
				tsa_BonificacionesExDataset.tsa_BonificacionesDetDataTable table= data.tsa_BonificacionesDet;
				
				foreach (tsa_BonificacionesExDataset.tsa_BonificacionesDetRow rowSP in table.Rows)
			
				{
					ok = ValidarRangos(rowSP);
					if (!ok  || !RowIsValid(rowSP)){ok=false; break;}
					
				}

			}
			return ok;
			
		}
		#region Validacion Bonificaciones

		public static bool RowIsValid( tsa_BonificacionesExDataset.tsa_BonificacionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			try
			{
			
				if ( !IdBonificacionIsValid( row.IdBonificacion, out mensaje) )
				{ 
					row.SetColumnError( "IdBonificacion" , mensaje);
					isValid=false;
			
				}
						
				if ( !IdEmpresaIsValid( row.IdEmpresa, out mensaje) )
				{ 
					row.SetColumnError( "IdEmpresa" , mensaje);
					isValid=false;
			
				}
						
				if ( !IdSucursalIsValid( row.IdSucursal, out mensaje) )
				{ 
					row.SetColumnError( "IdSucursal" , mensaje);
					isValid=false;
			
				}
						
				if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
				{ 
					row.SetColumnError( "Descripcion" , mensaje);
					isValid=false;
			
				}
						
				if ( !IdTipoBonificacionIsValid( row.IdTipoBonificacion, out mensaje) )
				{ 
					row.SetColumnError( "IdTipoBonificacion" , mensaje);
					isValid=false;
			
				}
						
				if ( !FechaCreacionIsValid( row.FechaCreacion, out mensaje) )
				{ 
					row.SetColumnError( "FechaCreacion" , mensaje);
					isValid=false;
			
				}
						
				if ( !IdConexionCreacionIsValid( row.IdConexionCreacion, out mensaje) )
				{ 
					row.SetColumnError( "IdConexionCreacion" , mensaje);
					isValid=false;
			
				}
						
				/*	if ( !UltimaModificacionIsValid( row.UltimaModificacion, out mensaje) )
					{ 
						row.SetColumnError( "UltimaModificacion" , mensaje);
						isValid=false;
			
					}*/
						
				if ( !IdConexionUltimaModificacionIsValid( row.IdConexionUltimaModificacion, out mensaje) )
				{ 
					row.SetColumnError( "IdConexionUltimaModificacion" , mensaje);
					isValid=false;
			
				}
						
				if ( !IdReservadoIsValid( row.IdReservado, out mensaje) )
				{ 
					row.SetColumnError( "IdReservado" , mensaje);
					isValid=false;
			
				}
						
				if ( !RowIdIsValid( row.RowId, out mensaje) )
				{ 
					row.SetColumnError( "RowId" , mensaje);
					isValid=false;
			
				}
				;
			}
			catch(Exception e){;  }
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdBonificacion.
		/// </summary>
		public static bool IdBonificacionIsValid( string IdBonificacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdBonificacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdBonificacionIsValid( string IdBonificacion)
		{
			string mensaje;
			return IdBonificacionIsValid( IdBonificacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdEmpresa.
		/// </summary>
		public static bool IdEmpresaIsValid( long IdEmpresa , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEmpresa. Metodo Sobrecargado
		/// </summary>
		public static bool IdEmpresaIsValid( long IdEmpresa)
		{
			string mensaje;
			return IdEmpresaIsValid( IdEmpresa, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdSucursal.
		/// </summary>
		public static bool IdSucursalIsValid( long IdSucursal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdSucursal. Metodo Sobrecargado
		/// </summary>
		public static bool IdSucursalIsValid( long IdSucursal)
		{
			string mensaje;
			return IdSucursalIsValid( IdSucursal, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Descripcion.
		/// </summary>
		public static bool DescripcionIsValid( string Descripcion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Descripcion. Metodo Sobrecargado
		/// </summary>
		public static bool DescripcionIsValid( string Descripcion)
		{
			string mensaje;
			return DescripcionIsValid( Descripcion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTipoBonificacion.
		/// </summary>
		public static bool IdTipoBonificacionIsValid( string IdTipoBonificacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoBonificacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdTipoBonificacionIsValid( string IdTipoBonificacion)
		{
			string mensaje;
			return IdTipoBonificacionIsValid( IdTipoBonificacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaCreacion.
		/// </summary>
		public static bool FechaCreacionIsValid( DateTime FechaCreacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaCreacion. Metodo Sobrecargado
		/// </summary>
		public static bool FechaCreacionIsValid( DateTime FechaCreacion)
		{
			string mensaje;
			return FechaCreacionIsValid( FechaCreacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdConexionCreacion.
		/// </summary>
		public static bool IdConexionCreacionIsValid( long IdConexionCreacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConexionCreacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdConexionCreacionIsValid( long IdConexionCreacion)
		{
			string mensaje;
			return IdConexionCreacionIsValid( IdConexionCreacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo UltimaModificacion.
		/// </summary>
		public static bool UltimaModificacionIsValid( byte[] UltimaModificacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo UltimaModificacion. Metodo Sobrecargado
		/// </summary>
		public static bool UltimaModificacionIsValid( byte[] UltimaModificacion)
		{
			string mensaje;
			return UltimaModificacionIsValid( UltimaModificacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdConexionUltimaModificacion.
		/// </summary>
		public static bool IdConexionUltimaModificacionIsValid( long IdConexionUltimaModificacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConexionUltimaModificacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdConexionUltimaModificacionIsValid( long IdConexionUltimaModificacion)
		{
			string mensaje;
			return IdConexionUltimaModificacionIsValid( IdConexionUltimaModificacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdReservado.
		/// </summary>
		public static bool IdReservadoIsValid( long IdReservado , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdReservado. Metodo Sobrecargado
		/// </summary>
		public static bool IdReservadoIsValid( long IdReservado)
		{
			string mensaje;
			return IdReservadoIsValid( IdReservado, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo RowId.
		/// </summary>
		public static bool RowIdIsValid( Guid RowId , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo RowId. Metodo Sobrecargado
		/// </summary>
		public static bool RowIdIsValid( Guid RowId)
		{
			string mensaje;
			return RowIdIsValid( RowId, out mensaje );
		}		
		

		#endregion

		#region Validacion Detalle de Bonificaciones
		
		private static bool ValidarRangos(tsa_BonificacionesExDataset.tsa_BonificacionesDetRow row )
		{
			
				bool isValid= true;
			try 
			{
				decimal val= row.Minimo;
			}
			catch(Exception e) {
				row.SetColumnError( "Minimo" , "Minimo no puede ser nulo, Debe se >= 0");
				isValid=false;
				return isValid;


			}
				try 
				{
				decimal val = row.Maximo;
				}
				catch(Exception e) {row.Maximo = Decimal.MaxValue;}
				if (row.Minimo > row.Maximo) 
				{
					row.SetColumnError( "Minimo" , "Minimo mayor que el maximo");
					isValid=false;
				}
				tsa_BonificacionesExDataset.tsa_BonificacionesDetDataTable table= (tsa_BonificacionesExDataset.tsa_BonificacionesDetDataTable)row.Table;
				foreach (tsa_BonificacionesExDataset.tsa_BonificacionesDetRow rowAux in table.Rows)
				{
					if ( ! (row.Ordinal == rowAux.Ordinal) )
					{
						if ( ( row.Minimo == rowAux.Minimo) || ( row.Maximo ==  rowAux.Maximo))
						{
							
							row.SetColumnError( "Minimo" , "Rangos con idices repetidos");
							isValid=false;
							
						}
						else
							if  ( ( row.Minimo >=  rowAux.Minimo && row.Maximo <=  rowAux.Maximo) || 
							(row.Minimo <=rowAux.Minimo && row.Maximo >= rowAux.Minimo)||
							(row.Minimo >= rowAux.Minimo  &&  row.Minimo <=  rowAux.Maximo))
						{
							row.SetColumnError( "Minimo" , "Rangos no excluyentes");
							isValid=false;
						}
					}
					
				}	

			
			return isValid;
		}


		public static bool RowIsValid( tsa_BonificacionesExDataset.tsa_BonificacionesDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			





							

			try
			{
			
				if ( !IdBonificacionIsValid( row.IdBonificacion, out mensaje) )
				{ 
					row.SetColumnError( "IdBonificacion" , mensaje);
					isValid=false;
			
				}
						
				if ( !OrdinalIsValid( row.Ordinal, out mensaje) )
				{ 
					row.SetColumnError( "Ordinal" , mensaje);
					isValid=false;
			
				}
						
				if ( !MinimoIsValid( row.Minimo, out mensaje) )
				{ 
					row.SetColumnError( "Minimo" , mensaje);
					isValid=false;
			
				}
						
				if ( !MaximoIsValid( row.Maximo, out mensaje) )
				{ 
					row.SetColumnError( "Maximo" , mensaje);
					isValid=false;
			
				}
						
				/*if ( !FechaCreacionIsValid( row.FechaCreacion, out mensaje) )
				{ 
					row.SetColumnError( "FechaCreacion" , mensaje);
					isValid=false;
			
				}
						
				if ( !IdConexionCreacionIsValid( row.IdConexionCreacion, out mensaje) )
				{ 
					row.SetColumnError( "IdConexionCreacion" , mensaje);
					isValid=false;
			
				}
						
				if ( !UltimaModificacionIsValid( row.UltimaModificacion, out mensaje) )
				{ 
					row.SetColumnError( "UltimaModificacion" , mensaje);
					isValid=false;
			
				}
						
				if ( !IdConexionUltimaModificacionIsValid( row.IdConexionUltimaModificacion, out mensaje) )
				{ 
					row.SetColumnError( "IdConexionUltimaModificacion" , mensaje);
					isValid=false;
			
				}
						
				if ( !IdReservadoIsValid( row.IdReservado, out mensaje) )
				{ 
					row.SetColumnError( "IdReservado" , mensaje);
					isValid=false;
			
				}
						
				if ( !RowIdIsValid( row.RowId, out mensaje) )
				{ 
					row.SetColumnError( "RowId" , mensaje);
					isValid=false;
			
				}*/
				;}
			catch(Exception e){;}
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdBonificacion.
		/// </summary>

		/// <summary>
		/// Valida el campo Ordinal.
		/// </summary>
		public static bool OrdinalIsValid( long Ordinal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Ordinal. Metodo Sobrecargado
		/// </summary>
		public static bool OrdinalIsValid( long Ordinal)
		{
			string mensaje;
			return OrdinalIsValid( Ordinal, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Minimo.
		/// </summary>
		public static bool MinimoIsValid( decimal Minimo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Minimo. Metodo Sobrecargado
		/// </summary>
		public static bool MinimoIsValid( decimal Minimo)
		{
			string mensaje;
			return MinimoIsValid( Minimo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Maximo.
		/// </summary>
		public static bool MaximoIsValid( decimal Maximo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Maximo. Metodo Sobrecargado
		/// </summary>
		public static bool MaximoIsValid( decimal Maximo)
		{
			string mensaje;
			return MaximoIsValid( Maximo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaCreacion.
		/// </summary>
		
		


		#endregion

		#endregion



		
	}
}
