using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace mz.erp.commontypes
{	/// <summary>
	/// Descripción breve de StatementSQLFactory.
	/// </summary>
	public class StatementSQLForReplicationFactory
	{
		public StatementSQLForReplicationFactory()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static void GetSqlStatement(SqlCommand command,StringBuilder sentence)
		{
			
			StringBuilder statementAux = new StringBuilder();
		
			SqlParameterCollection parameters = command.Parameters;
			statementAux.Append("Exec ").Append(command.CommandText).Append(" ");
            foreach(SqlParameter parameter in parameters)
			{
				try
				{
					string parameterName = parameter.ParameterName;
					statementAux.Append(parameterName + " = ");
					object valor = parameter.Value;
					if((valor == System.DBNull.Value) || (valor == null))
						statementAux.Append("NULL");
					else
					{
						string valorString = mz.erp.systemframework.Util.ToString(valor, parameter.SqlDbType);
						statementAux.Append(valorString);
					}
					if(parameters.IndexOf(parameter) != parameters.Count - 1)
						statementAux.Append(", ");
					else statementAux.Append(";");
				}
				catch(Exception e)
				{
					
				}

				


			}

			sentence.Append(statementAux.ToString());


		}

        /* Silvina 20100727 - Tarea 799 */

        public static string GetSqlStatementString(SqlCommand command, StringBuilder sentence)
        {

            StringBuilder statementAux = new StringBuilder();

            SqlParameterCollection parameters = command.Parameters;
            statementAux.Append("Exec ").Append(command.CommandText).Append(" ");
            foreach (SqlParameter parameter in parameters)
            {
                try
                {
                    string parameterName = parameter.ParameterName;
                    statementAux.Append(parameterName + " = ");
                    object valor = parameter.Value;
                    if ((valor == System.DBNull.Value) || (valor == null))
                        statementAux.Append("NULL");
                    else
                    {
                        string valorString = mz.erp.systemframework.Util.ToString(valor, parameter.SqlDbType);
                        statementAux.Append(valorString);
                    }
                    if (parameters.IndexOf(parameter) != parameters.Count - 1)
                        statementAux.Append(", ");
                    else statementAux.Append(";");
                }
                catch (Exception e)
                {

                }




            }

            return statementAux.ToString();


        }

		public static void GetSqlStatement(SqlCommand command,StringBuilder sentence, System.Data.DataRow row, string ColumnKey)
		{
			
			StringBuilder statementAux = new StringBuilder();
		
			SqlParameterCollection parameters = command.Parameters;
			statementAux.Append("Exec ").Append(command.CommandText).Append(" ");
			foreach(SqlParameter parameter in parameters)
			{
				try
				{
					
					string parameterName = parameter.ParameterName;
					statementAux.Append(parameterName + " = ");
					object valor = null;
					if(parameter.SourceColumn.Equals("IdGenerado"))
						valor = row[ColumnKey];
					else
						if(parameter.SourceColumn.Equals("RowIdGenerado"))
							valor = row["RowID"];
					else
						valor = row[parameter.SourceColumn];

					if((valor == System.DBNull.Value) || (valor == null))
						statementAux.Append("NULL");
					else
					{
						string valorString = mz.erp.systemframework.Util.ToString(valor, parameter.SqlDbType);
						statementAux.Append(valorString);
					}
					if(parameters.IndexOf(parameter) != parameters.Count - 1)
						statementAux.Append(", ");
					else statementAux.Append(";");
				}
				catch(Exception e)
				{
					
				}

				


			}

			sentence.Append(statementAux.ToString());


		}





	}
}
