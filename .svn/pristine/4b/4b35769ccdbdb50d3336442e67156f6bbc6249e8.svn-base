using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;
using mz.erp.businessrules.reportes;

namespace mz.erp.businessrules
{
    //Cristian Tarea 0000067 20110329
    public class ExportarCitiVentas
    {

        public ExportarCitiVentas()
            {
                //
                // TODO: agregar aquí la lógica del constructor
                //
            }

            #region Variables Privadas
            private DateTime _fechaDesde = System.DateTime.Now.AddDays(-30);
            private DateTime _fechaHasta = System.DateTime.Now;

            private string _filePath = string.Empty;
            #endregion

            #region Propiedades
            public DateTime FechaDesde
            {
                get { return this._fechaDesde; }
                set { this._fechaDesde = value; }
            }

            public DateTime FechaHasta
            {
                get { return this._fechaHasta; }
                set { this._fechaHasta = value; }
            }

            public string FilePath
            {
                get { return _filePath; }
                set { _filePath = value; }
            }

            #endregion

            #region Metodos Publicos
            public bool ValidarDatos()
            {
                return true;
            }

            public bool ExportarDatos()
            {
                if ((_filePath != null) && (!_filePath.Equals(string.Empty)))
                {
                    // Armar el archivo
                    FileInfo file = new FileInfo(this._filePath);

                    System.IO.FileStream fs;
                    try
                    {
                        if (System.IO.File.Exists(_filePath))
                        {
                            fs = System.IO.File.Open(_filePath, FileMode.Open, FileAccess.Read, FileShare.None);
                            fs.Close();
                        }

                        StreamWriter debugWriter = new StreamWriter(file.Open(FileMode.Append, FileAccess.Write, FileShare.ReadWrite), System.Text.Encoding.ASCII);
                        DataTable result = rep_ListadoCitiVentas.GetList(this._fechaDesde, this._fechaHasta);
                        foreach (DataRow row in result.Rows)
                            if (row[0] != null)
                            {
                                debugWriter.WriteLine(Convert.ToString(row[0])); // VER COLUMNA para agregar al archivo txt
                            }
                        debugWriter.Flush();
                        return true;

                    }
                    catch (Exception exp)
                    {
                        return false;
                    }
                }
                return false;
            }

            public void Commit()
            {

            }

            public void Flush()
            {

            }


            #endregion

            public bool PreguntarAlCancelar
            {
                get
                {
                    bool _preguntarAlCancelar = Variables.GetValueBool("ExportarCitiVentas.PreguntarAlCancelar", false);
                    return _preguntarAlCancelar;
                }
            }

        }
     //Fin Cristian
}
