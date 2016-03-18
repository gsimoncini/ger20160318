using System;
using System.Data;

using System.Text.RegularExpressions;
using System.Text;
    

using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;

namespace mz.erp.commontypes
{
	/// <summary>
	/// Descripción breve de sy_SentenciasReplicacion.
	/// </summary>
	public class SentenciasReplicacion
	{
		public SentenciasReplicacion()
		{
			this._sentence = new StringBuilder();
			this._sentence.Append( string.Empty );
		
		}

		private sy_SentenciasReplicacionDataset _data;

		
		private string _nombreTabla;
		private long _idConexion;
		private string _versionBD;
		private StringBuilder _sentence;
		private string _destino;
		private long _sucGeneradora;
		private string _idTipoDeSentencia;

		public sy_SentenciasReplicacionDataset Data
		{
			get{return _data;}
			set{_data = value;}

		}
		
		public long SucGeneradora
		{
			get{return _sucGeneradora;}
			set{_sucGeneradora = value;}
		}
		
		public string IdTipoDeSentencia
		{
			get{return _idTipoDeSentencia; }
			set{_idTipoDeSentencia = value;}
		}
		


		public string NombreTabla
		{
			get{return _nombreTabla;}
			set{_nombreTabla = value;}
		}

		public long IdConexion
		{
			get{return _idConexion;}
			set{_idConexion = value;}
		}

		public string VersionBD
		{
			get{return _versionBD;}
			set{_versionBD = value;}
		}

		public StringBuilder Sentence
		{
			get{return _sentence;}
			set{
				_sentence = value;
			}
		}

		public string Destino
		{
			get{return _destino;}
			set{_destino = value;}
		}

		public void Update()
		{
			_data = new sy_SentenciasReplicacionDataset();
			sy_SentenciasReplicacionDataset.sy_SentenciasReplicacionRow row = _data.sy_SentenciasReplicacion.Newsy_SentenciasReplicacionRow();
			row.IdSentenciaReplicacion = 0; 
			row.IdTabla =this._nombreTabla;
			row.IdTipoSentencia = this._idTipoDeSentencia;
			row.Sentencia = this._sentence.ToString();
			row.SentenciaRowId = Guid.Empty;
			row.NombreArchivo = null;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = this._idConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = this._idConexion;
			row.RowId = Guid.Empty;
			row.IdSucursalGeneradora = this._sucGeneradora;
			row.IdConexion = this._idConexion;
			row.Destino = this._destino;
			row.VersionBD = null;

			_data.sy_SentenciasReplicacion.Addsy_SentenciasReplicacionRow(row);

			

		}

	}
}
