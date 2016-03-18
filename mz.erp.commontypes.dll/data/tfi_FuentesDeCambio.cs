﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2032
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
    public class tfi_FuentesDeCambioDataset : DataSet {
        
        private tfi_FuentesDeCambioDataTable tabletfi_FuentesDeCambio;
        
        public tfi_FuentesDeCambioDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tfi_FuentesDeCambioDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tfi_FuentesDeCambio"] != null)) {
                    this.Tables.Add(new tfi_FuentesDeCambioDataTable(ds.Tables["tfi_FuentesDeCambio"]));
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
        public tfi_FuentesDeCambioDataTable tfi_FuentesDeCambio {
            get {
                return this.tabletfi_FuentesDeCambio;
            }
        }
        
        public override DataSet Clone() {
            tfi_FuentesDeCambioDataset cln = ((tfi_FuentesDeCambioDataset)(base.Clone()));
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
            if ((ds.Tables["tfi_FuentesDeCambio"] != null)) {
                this.Tables.Add(new tfi_FuentesDeCambioDataTable(ds.Tables["tfi_FuentesDeCambio"]));
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
            this.tabletfi_FuentesDeCambio = ((tfi_FuentesDeCambioDataTable)(this.Tables["tfi_FuentesDeCambio"]));
            if ((this.tabletfi_FuentesDeCambio != null)) {
                this.tabletfi_FuentesDeCambio.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tfi_FuentesDeCambioDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tfi_FuentesDeCambio.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletfi_FuentesDeCambio = new tfi_FuentesDeCambioDataTable();
            this.Tables.Add(this.tabletfi_FuentesDeCambio);
        }
        
        private bool ShouldSerializetfi_FuentesDeCambio() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tfi_FuentesDeCambioRowChangeEventHandler(object sender, tfi_FuentesDeCambioRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tfi_FuentesDeCambioDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdFuenteDeCambio;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdEmpresa;
            
            private DataColumn columnIdSucursal;
            
            internal tfi_FuentesDeCambioDataTable() : 
                    base("tfi_FuentesDeCambio") {
                this.InitClass();
            }
            
            internal tfi_FuentesDeCambioDataTable(DataTable table) : 
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
            
            internal DataColumn IdFuenteDeCambioColumn {
                get {
                    return this.columnIdFuenteDeCambio;
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
            
            internal DataColumn IdSucursalColumn {
                get {
                    return this.columnIdSucursal;
                }
            }
            
            public tfi_FuentesDeCambioRow this[int index] {
                get {
                    return ((tfi_FuentesDeCambioRow)(this.Rows[index]));
                }
            }
            
            public event tfi_FuentesDeCambioRowChangeEventHandler tfi_FuentesDeCambioRowChanged;
            
            public event tfi_FuentesDeCambioRowChangeEventHandler tfi_FuentesDeCambioRowChanging;
            
            public event tfi_FuentesDeCambioRowChangeEventHandler tfi_FuentesDeCambioRowDeleted;
            
            public event tfi_FuentesDeCambioRowChangeEventHandler tfi_FuentesDeCambioRowDeleting;
            
            public void Addtfi_FuentesDeCambioRow(tfi_FuentesDeCambioRow row) {
                this.Rows.Add(row);
            }
            
            public tfi_FuentesDeCambioRow Addtfi_FuentesDeCambioRow(string IdFuenteDeCambio, string Descripcion, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdEmpresa, long IdSucursal) {
                tfi_FuentesDeCambioRow rowtfi_FuentesDeCambioRow = ((tfi_FuentesDeCambioRow)(this.NewRow()));
                rowtfi_FuentesDeCambioRow.ItemArray = new object[] {
                        IdFuenteDeCambio,
                        Descripcion,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdEmpresa,
                        IdSucursal};
                this.Rows.Add(rowtfi_FuentesDeCambioRow);
                return rowtfi_FuentesDeCambioRow;
            }
            
            public tfi_FuentesDeCambioRow FindByIdFuenteDeCambio(string IdFuenteDeCambio) {
                return ((tfi_FuentesDeCambioRow)(this.Rows.Find(new object[] {
                            IdFuenteDeCambio})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tfi_FuentesDeCambioDataTable cln = ((tfi_FuentesDeCambioDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tfi_FuentesDeCambioDataTable();
            }
            
            internal void InitVars() {
                this.columnIdFuenteDeCambio = this.Columns["IdFuenteDeCambio"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnIdReservado = this.Columns["IdReservado"];
                this.columnRowId = this.Columns["RowId"];
                this.columnIdEmpresa = this.Columns["IdEmpresa"];
                this.columnIdSucursal = this.Columns["IdSucursal"];
            }
            
            private void InitClass() {
                this.columnIdFuenteDeCambio = new DataColumn("IdFuenteDeCambio", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdFuenteDeCambio);
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
                this.columnIdReservado = new DataColumn("IdReservado", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdReservado);
                this.columnRowId = new DataColumn("RowId", typeof(System.Guid), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRowId);
                this.columnIdEmpresa = new DataColumn("IdEmpresa", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdEmpresa);
                this.columnIdSucursal = new DataColumn("IdSucursal", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdSucursal);
                this.Constraints.Add(new UniqueConstraint("tfi_FuentesDeCambioKey1", new DataColumn[] {
                                this.columnIdFuenteDeCambio}, true));
                this.columnIdFuenteDeCambio.AllowDBNull = false;
                this.columnIdFuenteDeCambio.Unique = true;
                this.columnDescripcion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tfi_FuentesDeCambioRow Newtfi_FuentesDeCambioRow() {
                return ((tfi_FuentesDeCambioRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tfi_FuentesDeCambioRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tfi_FuentesDeCambioRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tfi_FuentesDeCambioRowChanged != null)) {
                    this.tfi_FuentesDeCambioRowChanged(this, new tfi_FuentesDeCambioRowChangeEvent(((tfi_FuentesDeCambioRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tfi_FuentesDeCambioRowChanging != null)) {
                    this.tfi_FuentesDeCambioRowChanging(this, new tfi_FuentesDeCambioRowChangeEvent(((tfi_FuentesDeCambioRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tfi_FuentesDeCambioRowDeleted != null)) {
                    this.tfi_FuentesDeCambioRowDeleted(this, new tfi_FuentesDeCambioRowChangeEvent(((tfi_FuentesDeCambioRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tfi_FuentesDeCambioRowDeleting != null)) {
                    this.tfi_FuentesDeCambioRowDeleting(this, new tfi_FuentesDeCambioRowChangeEvent(((tfi_FuentesDeCambioRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetfi_FuentesDeCambioRow(tfi_FuentesDeCambioRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tfi_FuentesDeCambioRow : DataRow {
            
            private tfi_FuentesDeCambioDataTable tabletfi_FuentesDeCambio;
            
            internal tfi_FuentesDeCambioRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletfi_FuentesDeCambio = ((tfi_FuentesDeCambioDataTable)(this.Table));
            }
            
            public string IdFuenteDeCambio {
                get {
                    return ((string)(this[this.tabletfi_FuentesDeCambio.IdFuenteDeCambioColumn]));
                }
                set {
                    this[this.tabletfi_FuentesDeCambio.IdFuenteDeCambioColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    return ((string)(this[this.tabletfi_FuentesDeCambio.DescripcionColumn]));
                }
                set {
                    this[this.tabletfi_FuentesDeCambio.DescripcionColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletfi_FuentesDeCambio.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_FuentesDeCambio.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletfi_FuentesDeCambio.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_FuentesDeCambio.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletfi_FuentesDeCambio.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_FuentesDeCambio.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletfi_FuentesDeCambio.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_FuentesDeCambio.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletfi_FuentesDeCambio.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_FuentesDeCambio.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletfi_FuentesDeCambio.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_FuentesDeCambio.RowIdColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletfi_FuentesDeCambio.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_FuentesDeCambio.IdEmpresaColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletfi_FuentesDeCambio.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_FuentesDeCambio.IdSucursalColumn] = value;
                }
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletfi_FuentesDeCambio.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletfi_FuentesDeCambio.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletfi_FuentesDeCambio.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletfi_FuentesDeCambio.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletfi_FuentesDeCambio.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletfi_FuentesDeCambio.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletfi_FuentesDeCambio.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletfi_FuentesDeCambio.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletfi_FuentesDeCambio.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletfi_FuentesDeCambio.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletfi_FuentesDeCambio.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletfi_FuentesDeCambio.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletfi_FuentesDeCambio.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletfi_FuentesDeCambio.IdEmpresaColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletfi_FuentesDeCambio.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletfi_FuentesDeCambio.IdSucursalColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tfi_FuentesDeCambioRowChangeEvent : EventArgs {
            
            private tfi_FuentesDeCambioRow eventRow;
            
            private DataRowAction eventAction;
            
            public tfi_FuentesDeCambioRowChangeEvent(tfi_FuentesDeCambioRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tfi_FuentesDeCambioRow Row {
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