﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2407
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace mz.erp.commontypes.data {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class tsy_MotivoOrdenReparacionDataset : DataSet {
        
        private tsy_MotivoOrdenReparacionDataTable tabletsy_MotivoOrdenReparacion;
        
        public tsy_MotivoOrdenReparacionDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tsy_MotivoOrdenReparacionDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tsy_MotivoOrdenReparacion"] != null)) {
                    this.Tables.Add(new tsy_MotivoOrdenReparacionDataTable(ds.Tables["tsy_MotivoOrdenReparacion"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public tsy_MotivoOrdenReparacionDataTable tsy_MotivoOrdenReparacion {
            get {
                return this.tabletsy_MotivoOrdenReparacion;
            }
        }
        
        public override DataSet Clone() {
            tsy_MotivoOrdenReparacionDataset cln = ((tsy_MotivoOrdenReparacionDataset)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.Reset();
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["tsy_MotivoOrdenReparacion"] != null)) {
                this.Tables.Add(new tsy_MotivoOrdenReparacionDataTable(ds.Tables["tsy_MotivoOrdenReparacion"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        internal void InitVars() {
            this.tabletsy_MotivoOrdenReparacion = ((tsy_MotivoOrdenReparacionDataTable)(this.Tables["tsy_MotivoOrdenReparacion"]));
            if ((this.tabletsy_MotivoOrdenReparacion != null)) {
                this.tabletsy_MotivoOrdenReparacion.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tsy_MotivoOrdenReparacionDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tsy_MotivoOrdenReparacion.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletsy_MotivoOrdenReparacion = new tsy_MotivoOrdenReparacionDataTable();
            this.Tables.Add(this.tabletsy_MotivoOrdenReparacion);
        }
        
        private bool ShouldSerializetsy_MotivoOrdenReparacion() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tsy_MotivoOrdenReparacionRowChangeEventHandler(object sender, tsy_MotivoOrdenReparacionRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsy_MotivoOrdenReparacionDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdMotivo;
            
            private DataColumn columnIdMotivoPadre;
            
            private DataColumn columnEsVerdadero;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            internal tsy_MotivoOrdenReparacionDataTable() : 
                    base("tsy_MotivoOrdenReparacion") {
                this.InitClass();
            }
            
            internal tsy_MotivoOrdenReparacionDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn IdMotivoColumn {
                get {
                    return this.columnIdMotivo;
                }
            }
            
            internal DataColumn IdMotivoPadreColumn {
                get {
                    return this.columnIdMotivoPadre;
                }
            }
            
            internal DataColumn EsVerdaderoColumn {
                get {
                    return this.columnEsVerdadero;
                }
            }
            
            internal DataColumn DescripcionColumn {
                get {
                    return this.columnDescripcion;
                }
            }
            
            internal DataColumn FechaCreacionColumn {
                get {
                    return this.columnFechaCreacion;
                }
            }
            
            internal DataColumn IdConexionCreacionColumn {
                get {
                    return this.columnIdConexionCreacion;
                }
            }
            
            internal DataColumn UltimaModificacionColumn {
                get {
                    return this.columnUltimaModificacion;
                }
            }
            
            internal DataColumn IdConexionUltimaModificacionColumn {
                get {
                    return this.columnIdConexionUltimaModificacion;
                }
            }
            
            internal DataColumn RowIdColumn {
                get {
                    return this.columnRowId;
                }
            }
            
            public tsy_MotivoOrdenReparacionRow this[int index] {
                get {
                    return ((tsy_MotivoOrdenReparacionRow)(this.Rows[index]));
                }
            }
            
            public event tsy_MotivoOrdenReparacionRowChangeEventHandler tsy_MotivoOrdenReparacionRowChanged;
            
            public event tsy_MotivoOrdenReparacionRowChangeEventHandler tsy_MotivoOrdenReparacionRowChanging;
            
            public event tsy_MotivoOrdenReparacionRowChangeEventHandler tsy_MotivoOrdenReparacionRowDeleted;
            
            public event tsy_MotivoOrdenReparacionRowChangeEventHandler tsy_MotivoOrdenReparacionRowDeleting;
            
            public void Addtsy_MotivoOrdenReparacionRow(tsy_MotivoOrdenReparacionRow row) {
                this.Rows.Add(row);
            }
            
            public tsy_MotivoOrdenReparacionRow Addtsy_MotivoOrdenReparacionRow(long IdMotivo, long IdMotivoPadre, bool EsVerdadero, string Descripcion, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId) {
                tsy_MotivoOrdenReparacionRow rowtsy_MotivoOrdenReparacionRow = ((tsy_MotivoOrdenReparacionRow)(this.NewRow()));
                rowtsy_MotivoOrdenReparacionRow.ItemArray = new object[] {
                        IdMotivo,
                        IdMotivoPadre,
                        EsVerdadero,
                        Descripcion,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId};
                this.Rows.Add(rowtsy_MotivoOrdenReparacionRow);
                return rowtsy_MotivoOrdenReparacionRow;
            }
            
            public tsy_MotivoOrdenReparacionRow FindByIdMotivo(long IdMotivo) {
                return ((tsy_MotivoOrdenReparacionRow)(this.Rows.Find(new object[] {
                            IdMotivo})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tsy_MotivoOrdenReparacionDataTable cln = ((tsy_MotivoOrdenReparacionDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tsy_MotivoOrdenReparacionDataTable();
            }
            
            internal void InitVars() {
                this.columnIdMotivo = this.Columns["IdMotivo"];
                this.columnIdMotivoPadre = this.Columns["IdMotivoPadre"];
                this.columnEsVerdadero = this.Columns["EsVerdadero"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnRowId = this.Columns["RowId"];
            }
            
            private void InitClass() {
                this.columnIdMotivo = new DataColumn("IdMotivo", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdMotivo);
                this.columnIdMotivoPadre = new DataColumn("IdMotivoPadre", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdMotivoPadre);
                this.columnEsVerdadero = new DataColumn("EsVerdadero", typeof(bool), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnEsVerdadero);
                this.columnDescripcion = new DataColumn("Descripcion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcion);
                this.columnFechaCreacion = new DataColumn("FechaCreacion", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFechaCreacion);
                this.columnIdConexionCreacion = new DataColumn("IdConexionCreacion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexionCreacion);
                this.columnUltimaModificacion = new DataColumn("UltimaModificacion", typeof(System.Byte[]), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnUltimaModificacion);
                this.columnIdConexionUltimaModificacion = new DataColumn("IdConexionUltimaModificacion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexionUltimaModificacion);
                this.columnRowId = new DataColumn("RowId", typeof(System.Guid), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRowId);
                this.Constraints.Add(new UniqueConstraint("tsy_MotivoOrdenReparacionKey1", new DataColumn[] {
                                this.columnIdMotivo}, true));
                this.columnIdMotivo.AllowDBNull = false;
                this.columnIdMotivo.Unique = true;
                this.columnIdConexionCreacion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tsy_MotivoOrdenReparacionRow Newtsy_MotivoOrdenReparacionRow() {
                return ((tsy_MotivoOrdenReparacionRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tsy_MotivoOrdenReparacionRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tsy_MotivoOrdenReparacionRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tsy_MotivoOrdenReparacionRowChanged != null)) {
                    this.tsy_MotivoOrdenReparacionRowChanged(this, new tsy_MotivoOrdenReparacionRowChangeEvent(((tsy_MotivoOrdenReparacionRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tsy_MotivoOrdenReparacionRowChanging != null)) {
                    this.tsy_MotivoOrdenReparacionRowChanging(this, new tsy_MotivoOrdenReparacionRowChangeEvent(((tsy_MotivoOrdenReparacionRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tsy_MotivoOrdenReparacionRowDeleted != null)) {
                    this.tsy_MotivoOrdenReparacionRowDeleted(this, new tsy_MotivoOrdenReparacionRowChangeEvent(((tsy_MotivoOrdenReparacionRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tsy_MotivoOrdenReparacionRowDeleting != null)) {
                    this.tsy_MotivoOrdenReparacionRowDeleting(this, new tsy_MotivoOrdenReparacionRowChangeEvent(((tsy_MotivoOrdenReparacionRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetsy_MotivoOrdenReparacionRow(tsy_MotivoOrdenReparacionRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsy_MotivoOrdenReparacionRow : DataRow {
            
            private tsy_MotivoOrdenReparacionDataTable tabletsy_MotivoOrdenReparacion;
            
            internal tsy_MotivoOrdenReparacionRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletsy_MotivoOrdenReparacion = ((tsy_MotivoOrdenReparacionDataTable)(this.Table));
            }
            
            public long IdMotivo {
                get {
                    return ((long)(this[this.tabletsy_MotivoOrdenReparacion.IdMotivoColumn]));
                }
                set {
                    this[this.tabletsy_MotivoOrdenReparacion.IdMotivoColumn] = value;
                }
            }
            
            public long IdMotivoPadre {
                get {
                    try {
                        return ((long)(this[this.tabletsy_MotivoOrdenReparacion.IdMotivoPadreColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_MotivoOrdenReparacion.IdMotivoPadreColumn] = value;
                }
            }
            
            public bool EsVerdadero {
                get {
                    try {
                        return ((bool)(this[this.tabletsy_MotivoOrdenReparacion.EsVerdaderoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_MotivoOrdenReparacion.EsVerdaderoColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    try {
                        return ((string)(this[this.tabletsy_MotivoOrdenReparacion.DescripcionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_MotivoOrdenReparacion.DescripcionColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletsy_MotivoOrdenReparacion.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_MotivoOrdenReparacion.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    return ((long)(this[this.tabletsy_MotivoOrdenReparacion.IdConexionCreacionColumn]));
                }
                set {
                    this[this.tabletsy_MotivoOrdenReparacion.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletsy_MotivoOrdenReparacion.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_MotivoOrdenReparacion.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletsy_MotivoOrdenReparacion.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_MotivoOrdenReparacion.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletsy_MotivoOrdenReparacion.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_MotivoOrdenReparacion.RowIdColumn] = value;
                }
            }
            
            public bool IsIdMotivoPadreNull() {
                return this.IsNull(this.tabletsy_MotivoOrdenReparacion.IdMotivoPadreColumn);
            }
            
            public void SetIdMotivoPadreNull() {
                this[this.tabletsy_MotivoOrdenReparacion.IdMotivoPadreColumn] = System.Convert.DBNull;
            }
            
            public bool IsEsVerdaderoNull() {
                return this.IsNull(this.tabletsy_MotivoOrdenReparacion.EsVerdaderoColumn);
            }
            
            public void SetEsVerdaderoNull() {
                this[this.tabletsy_MotivoOrdenReparacion.EsVerdaderoColumn] = System.Convert.DBNull;
            }
            
            public bool IsDescripcionNull() {
                return this.IsNull(this.tabletsy_MotivoOrdenReparacion.DescripcionColumn);
            }
            
            public void SetDescripcionNull() {
                this[this.tabletsy_MotivoOrdenReparacion.DescripcionColumn] = System.Convert.DBNull;
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletsy_MotivoOrdenReparacion.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletsy_MotivoOrdenReparacion.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletsy_MotivoOrdenReparacion.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletsy_MotivoOrdenReparacion.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletsy_MotivoOrdenReparacion.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletsy_MotivoOrdenReparacion.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletsy_MotivoOrdenReparacion.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletsy_MotivoOrdenReparacion.RowIdColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsy_MotivoOrdenReparacionRowChangeEvent : EventArgs {
            
            private tsy_MotivoOrdenReparacionRow eventRow;
            
            private DataRowAction eventAction;
            
            public tsy_MotivoOrdenReparacionRowChangeEvent(tsy_MotivoOrdenReparacionRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tsy_MotivoOrdenReparacionRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}