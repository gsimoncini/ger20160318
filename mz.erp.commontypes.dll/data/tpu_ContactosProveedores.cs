﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
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
    public class tpu_ContactosProveedoresDataset : DataSet {
        
        private tpu_ContactosProveedoresDataTable tabletpu_ContactosProveedores;
        
        public tpu_ContactosProveedoresDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tpu_ContactosProveedoresDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tpu_ContactosProveedores"] != null)) {
                    this.Tables.Add(new tpu_ContactosProveedoresDataTable(ds.Tables["tpu_ContactosProveedores"]));
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
        public tpu_ContactosProveedoresDataTable tpu_ContactosProveedores {
            get {
                return this.tabletpu_ContactosProveedores;
            }
        }
        
        public override DataSet Clone() {
            tpu_ContactosProveedoresDataset cln = ((tpu_ContactosProveedoresDataset)(base.Clone()));
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
            if ((ds.Tables["tpu_ContactosProveedores"] != null)) {
                this.Tables.Add(new tpu_ContactosProveedoresDataTable(ds.Tables["tpu_ContactosProveedores"]));
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
            this.tabletpu_ContactosProveedores = ((tpu_ContactosProveedoresDataTable)(this.Tables["tpu_ContactosProveedores"]));
            if ((this.tabletpu_ContactosProveedores != null)) {
                this.tabletpu_ContactosProveedores.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tpu_ContactosProveedoresDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tpu_ContactosProveedores.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletpu_ContactosProveedores = new tpu_ContactosProveedoresDataTable();
            this.Tables.Add(this.tabletpu_ContactosProveedores);
        }
        
        private bool ShouldSerializetpu_ContactosProveedores() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tpu_ContactosProveedoresRowChangeEventHandler(object sender, tpu_ContactosProveedoresRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tpu_ContactosProveedoresDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdPersona;
            
            private DataColumn columnIdProveedor;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdEmpresa;
            
            internal tpu_ContactosProveedoresDataTable() : 
                    base("tpu_ContactosProveedores") {
                this.InitClass();
            }
            
            internal tpu_ContactosProveedoresDataTable(DataTable table) : 
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
            
            internal DataColumn IdPersonaColumn {
                get {
                    return this.columnIdPersona;
                }
            }
            
            internal DataColumn IdProveedorColumn {
                get {
                    return this.columnIdProveedor;
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
            
            internal DataColumn IdReservadoColumn {
                get {
                    return this.columnIdReservado;
                }
            }
            
            internal DataColumn RowIdColumn {
                get {
                    return this.columnRowId;
                }
            }
            
            internal DataColumn IdEmpresaColumn {
                get {
                    return this.columnIdEmpresa;
                }
            }
            
            public tpu_ContactosProveedoresRow this[int index] {
                get {
                    return ((tpu_ContactosProveedoresRow)(this.Rows[index]));
                }
            }
            
            public event tpu_ContactosProveedoresRowChangeEventHandler tpu_ContactosProveedoresRowChanged;
            
            public event tpu_ContactosProveedoresRowChangeEventHandler tpu_ContactosProveedoresRowChanging;
            
            public event tpu_ContactosProveedoresRowChangeEventHandler tpu_ContactosProveedoresRowDeleted;
            
            public event tpu_ContactosProveedoresRowChangeEventHandler tpu_ContactosProveedoresRowDeleting;
            
            public void Addtpu_ContactosProveedoresRow(tpu_ContactosProveedoresRow row) {
                this.Rows.Add(row);
            }
            
            public tpu_ContactosProveedoresRow Addtpu_ContactosProveedoresRow(string IdPersona, long IdProveedor, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdEmpresa) {
                tpu_ContactosProveedoresRow rowtpu_ContactosProveedoresRow = ((tpu_ContactosProveedoresRow)(this.NewRow()));
                rowtpu_ContactosProveedoresRow.ItemArray = new object[] {
                        IdPersona,
                        IdProveedor,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdEmpresa};
                this.Rows.Add(rowtpu_ContactosProveedoresRow);
                return rowtpu_ContactosProveedoresRow;
            }
            
            public tpu_ContactosProveedoresRow FindByIdPersonaIdProveedor(string IdPersona, long IdProveedor) {
                return ((tpu_ContactosProveedoresRow)(this.Rows.Find(new object[] {
                            IdPersona,
                            IdProveedor})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tpu_ContactosProveedoresDataTable cln = ((tpu_ContactosProveedoresDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tpu_ContactosProveedoresDataTable();
            }
            
            internal void InitVars() {
                this.columnIdPersona = this.Columns["IdPersona"];
                this.columnIdProveedor = this.Columns["IdProveedor"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnIdReservado = this.Columns["IdReservado"];
                this.columnRowId = this.Columns["RowId"];
                this.columnIdEmpresa = this.Columns["IdEmpresa"];
            }
            
            private void InitClass() {
                this.columnIdPersona = new DataColumn("IdPersona", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdPersona);
                this.columnIdProveedor = new DataColumn("IdProveedor", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdProveedor);
                this.columnFechaCreacion = new DataColumn("FechaCreacion", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFechaCreacion);
                this.columnIdConexionCreacion = new DataColumn("IdConexionCreacion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexionCreacion);
                this.columnUltimaModificacion = new DataColumn("UltimaModificacion", typeof(System.Byte[]), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnUltimaModificacion);
                this.columnIdConexionUltimaModificacion = new DataColumn("IdConexionUltimaModificacion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexionUltimaModificacion);
                this.columnIdReservado = new DataColumn("IdReservado", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdReservado);
                this.columnRowId = new DataColumn("RowId", typeof(System.Guid), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRowId);
                this.columnIdEmpresa = new DataColumn("IdEmpresa", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdEmpresa);
                this.Constraints.Add(new UniqueConstraint("tpu_ContactosProveedoresKey1", new DataColumn[] {
                                this.columnIdPersona,
                                this.columnIdProveedor}, true));
                this.columnIdPersona.AllowDBNull = false;
                this.columnIdProveedor.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tpu_ContactosProveedoresRow Newtpu_ContactosProveedoresRow() {
                return ((tpu_ContactosProveedoresRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tpu_ContactosProveedoresRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tpu_ContactosProveedoresRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tpu_ContactosProveedoresRowChanged != null)) {
                    this.tpu_ContactosProveedoresRowChanged(this, new tpu_ContactosProveedoresRowChangeEvent(((tpu_ContactosProveedoresRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tpu_ContactosProveedoresRowChanging != null)) {
                    this.tpu_ContactosProveedoresRowChanging(this, new tpu_ContactosProveedoresRowChangeEvent(((tpu_ContactosProveedoresRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tpu_ContactosProveedoresRowDeleted != null)) {
                    this.tpu_ContactosProveedoresRowDeleted(this, new tpu_ContactosProveedoresRowChangeEvent(((tpu_ContactosProveedoresRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tpu_ContactosProveedoresRowDeleting != null)) {
                    this.tpu_ContactosProveedoresRowDeleting(this, new tpu_ContactosProveedoresRowChangeEvent(((tpu_ContactosProveedoresRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetpu_ContactosProveedoresRow(tpu_ContactosProveedoresRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tpu_ContactosProveedoresRow : DataRow {
            
            private tpu_ContactosProveedoresDataTable tabletpu_ContactosProveedores;
            
            internal tpu_ContactosProveedoresRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletpu_ContactosProveedores = ((tpu_ContactosProveedoresDataTable)(this.Table));
            }
            
            public string IdPersona {
                get {
                    return ((string)(this[this.tabletpu_ContactosProveedores.IdPersonaColumn]));
                }
                set {
                    this[this.tabletpu_ContactosProveedores.IdPersonaColumn] = value;
                }
            }
            
            public long IdProveedor {
                get {
                    return ((long)(this[this.tabletpu_ContactosProveedores.IdProveedorColumn]));
                }
                set {
                    this[this.tabletpu_ContactosProveedores.IdProveedorColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletpu_ContactosProveedores.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_ContactosProveedores.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletpu_ContactosProveedores.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_ContactosProveedores.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletpu_ContactosProveedores.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_ContactosProveedores.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletpu_ContactosProveedores.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_ContactosProveedores.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletpu_ContactosProveedores.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_ContactosProveedores.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletpu_ContactosProveedores.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_ContactosProveedores.RowIdColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletpu_ContactosProveedores.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_ContactosProveedores.IdEmpresaColumn] = value;
                }
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletpu_ContactosProveedores.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletpu_ContactosProveedores.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletpu_ContactosProveedores.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletpu_ContactosProveedores.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletpu_ContactosProveedores.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletpu_ContactosProveedores.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletpu_ContactosProveedores.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletpu_ContactosProveedores.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletpu_ContactosProveedores.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletpu_ContactosProveedores.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletpu_ContactosProveedores.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletpu_ContactosProveedores.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletpu_ContactosProveedores.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletpu_ContactosProveedores.IdEmpresaColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tpu_ContactosProveedoresRowChangeEvent : EventArgs {
            
            private tpu_ContactosProveedoresRow eventRow;
            
            private DataRowAction eventAction;
            
            public tpu_ContactosProveedoresRowChangeEvent(tpu_ContactosProveedoresRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tpu_ContactosProveedoresRow Row {
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