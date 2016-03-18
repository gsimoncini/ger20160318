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
    public class tsa_CuentasObservacionesEstadosDataset : DataSet {
        
        private tsa_CuentasObservacionesEstadosDataTable tabletsa_CuentasObservacionesEstados;
        
        public tsa_CuentasObservacionesEstadosDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tsa_CuentasObservacionesEstadosDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tsa_CuentasObservacionesEstados"] != null)) {
                    this.Tables.Add(new tsa_CuentasObservacionesEstadosDataTable(ds.Tables["tsa_CuentasObservacionesEstados"]));
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
        public tsa_CuentasObservacionesEstadosDataTable tsa_CuentasObservacionesEstados {
            get {
                return this.tabletsa_CuentasObservacionesEstados;
            }
        }
        
        public override DataSet Clone() {
            tsa_CuentasObservacionesEstadosDataset cln = ((tsa_CuentasObservacionesEstadosDataset)(base.Clone()));
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
            if ((ds.Tables["tsa_CuentasObservacionesEstados"] != null)) {
                this.Tables.Add(new tsa_CuentasObservacionesEstadosDataTable(ds.Tables["tsa_CuentasObservacionesEstados"]));
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
            this.tabletsa_CuentasObservacionesEstados = ((tsa_CuentasObservacionesEstadosDataTable)(this.Tables["tsa_CuentasObservacionesEstados"]));
            if ((this.tabletsa_CuentasObservacionesEstados != null)) {
                this.tabletsa_CuentasObservacionesEstados.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tsa_CuentasObservacionesEstadosDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tsa_CuentasObservacionesEstados.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletsa_CuentasObservacionesEstados = new tsa_CuentasObservacionesEstadosDataTable();
            this.Tables.Add(this.tabletsa_CuentasObservacionesEstados);
        }
        
        private bool ShouldSerializetsa_CuentasObservacionesEstados() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tsa_CuentasObservacionesEstadosRowChangeEventHandler(object sender, tsa_CuentasObservacionesEstadosRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsa_CuentasObservacionesEstadosDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdCuentaObservacionEstado;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnActivo;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdSucursal;
            
            private DataColumn columnIdEmpresa;
            
            internal tsa_CuentasObservacionesEstadosDataTable() : 
                    base("tsa_CuentasObservacionesEstados") {
                this.InitClass();
            }
            
            internal tsa_CuentasObservacionesEstadosDataTable(DataTable table) : 
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
            
            internal DataColumn IdCuentaObservacionEstadoColumn {
                get {
                    return this.columnIdCuentaObservacionEstado;
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
            
            internal DataColumn ActivoColumn {
                get {
                    return this.columnActivo;
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
            
            internal DataColumn IdSucursalColumn {
                get {
                    return this.columnIdSucursal;
                }
            }
            
            internal DataColumn IdEmpresaColumn {
                get {
                    return this.columnIdEmpresa;
                }
            }
            
            public tsa_CuentasObservacionesEstadosRow this[int index] {
                get {
                    return ((tsa_CuentasObservacionesEstadosRow)(this.Rows[index]));
                }
            }
            
            public event tsa_CuentasObservacionesEstadosRowChangeEventHandler tsa_CuentasObservacionesEstadosRowChanged;
            
            public event tsa_CuentasObservacionesEstadosRowChangeEventHandler tsa_CuentasObservacionesEstadosRowChanging;
            
            public event tsa_CuentasObservacionesEstadosRowChangeEventHandler tsa_CuentasObservacionesEstadosRowDeleted;
            
            public event tsa_CuentasObservacionesEstadosRowChangeEventHandler tsa_CuentasObservacionesEstadosRowDeleting;
            
            public void Addtsa_CuentasObservacionesEstadosRow(tsa_CuentasObservacionesEstadosRow row) {
                this.Rows.Add(row);
            }
            
            public tsa_CuentasObservacionesEstadosRow Addtsa_CuentasObservacionesEstadosRow(string IdCuentaObservacionEstado, string Descripcion, System.DateTime FechaCreacion, bool Activo, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdSucursal, long IdEmpresa) {
                tsa_CuentasObservacionesEstadosRow rowtsa_CuentasObservacionesEstadosRow = ((tsa_CuentasObservacionesEstadosRow)(this.NewRow()));
                rowtsa_CuentasObservacionesEstadosRow.ItemArray = new object[] {
                        IdCuentaObservacionEstado,
                        Descripcion,
                        FechaCreacion,
                        Activo,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdSucursal,
                        IdEmpresa};
                this.Rows.Add(rowtsa_CuentasObservacionesEstadosRow);
                return rowtsa_CuentasObservacionesEstadosRow;
            }
            
            public tsa_CuentasObservacionesEstadosRow FindByIdCuentaObservacionEstado(string IdCuentaObservacionEstado) {
                return ((tsa_CuentasObservacionesEstadosRow)(this.Rows.Find(new object[] {
                            IdCuentaObservacionEstado})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tsa_CuentasObservacionesEstadosDataTable cln = ((tsa_CuentasObservacionesEstadosDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tsa_CuentasObservacionesEstadosDataTable();
            }
            
            internal void InitVars() {
                this.columnIdCuentaObservacionEstado = this.Columns["IdCuentaObservacionEstado"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnActivo = this.Columns["Activo"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnIdReservado = this.Columns["IdReservado"];
                this.columnRowId = this.Columns["RowId"];
                this.columnIdSucursal = this.Columns["IdSucursal"];
                this.columnIdEmpresa = this.Columns["IdEmpresa"];
            }
            
            private void InitClass() {
                this.columnIdCuentaObservacionEstado = new DataColumn("IdCuentaObservacionEstado", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdCuentaObservacionEstado);
                this.columnDescripcion = new DataColumn("Descripcion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcion);
                this.columnFechaCreacion = new DataColumn("FechaCreacion", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFechaCreacion);
                this.columnActivo = new DataColumn("Activo", typeof(bool), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnActivo);
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
                this.columnIdSucursal = new DataColumn("IdSucursal", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdSucursal);
                this.columnIdEmpresa = new DataColumn("IdEmpresa", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdEmpresa);
                this.Constraints.Add(new UniqueConstraint("tsa_CuentasObservacionesEstadosKey1", new DataColumn[] {
                                this.columnIdCuentaObservacionEstado}, true));
                this.columnIdCuentaObservacionEstado.AllowDBNull = false;
                this.columnIdCuentaObservacionEstado.Unique = true;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tsa_CuentasObservacionesEstadosRow Newtsa_CuentasObservacionesEstadosRow() {
                return ((tsa_CuentasObservacionesEstadosRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tsa_CuentasObservacionesEstadosRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tsa_CuentasObservacionesEstadosRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tsa_CuentasObservacionesEstadosRowChanged != null)) {
                    this.tsa_CuentasObservacionesEstadosRowChanged(this, new tsa_CuentasObservacionesEstadosRowChangeEvent(((tsa_CuentasObservacionesEstadosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tsa_CuentasObservacionesEstadosRowChanging != null)) {
                    this.tsa_CuentasObservacionesEstadosRowChanging(this, new tsa_CuentasObservacionesEstadosRowChangeEvent(((tsa_CuentasObservacionesEstadosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tsa_CuentasObservacionesEstadosRowDeleted != null)) {
                    this.tsa_CuentasObservacionesEstadosRowDeleted(this, new tsa_CuentasObservacionesEstadosRowChangeEvent(((tsa_CuentasObservacionesEstadosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tsa_CuentasObservacionesEstadosRowDeleting != null)) {
                    this.tsa_CuentasObservacionesEstadosRowDeleting(this, new tsa_CuentasObservacionesEstadosRowChangeEvent(((tsa_CuentasObservacionesEstadosRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetsa_CuentasObservacionesEstadosRow(tsa_CuentasObservacionesEstadosRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsa_CuentasObservacionesEstadosRow : DataRow {
            
            private tsa_CuentasObservacionesEstadosDataTable tabletsa_CuentasObservacionesEstados;
            
            internal tsa_CuentasObservacionesEstadosRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletsa_CuentasObservacionesEstados = ((tsa_CuentasObservacionesEstadosDataTable)(this.Table));
            }
            
            public string IdCuentaObservacionEstado {
                get {
                    return ((string)(this[this.tabletsa_CuentasObservacionesEstados.IdCuentaObservacionEstadoColumn]));
                }
                set {
                    this[this.tabletsa_CuentasObservacionesEstados.IdCuentaObservacionEstadoColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    try {
                        return ((string)(this[this.tabletsa_CuentasObservacionesEstados.DescripcionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_CuentasObservacionesEstados.DescripcionColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletsa_CuentasObservacionesEstados.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_CuentasObservacionesEstados.FechaCreacionColumn] = value;
                }
            }
            
            public bool Activo {
                get {
                    try {
                        return ((bool)(this[this.tabletsa_CuentasObservacionesEstados.ActivoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_CuentasObservacionesEstados.ActivoColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletsa_CuentasObservacionesEstados.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_CuentasObservacionesEstados.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletsa_CuentasObservacionesEstados.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_CuentasObservacionesEstados.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletsa_CuentasObservacionesEstados.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_CuentasObservacionesEstados.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletsa_CuentasObservacionesEstados.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_CuentasObservacionesEstados.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletsa_CuentasObservacionesEstados.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_CuentasObservacionesEstados.RowIdColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletsa_CuentasObservacionesEstados.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_CuentasObservacionesEstados.IdSucursalColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletsa_CuentasObservacionesEstados.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_CuentasObservacionesEstados.IdEmpresaColumn] = value;
                }
            }
            
            public bool IsDescripcionNull() {
                return this.IsNull(this.tabletsa_CuentasObservacionesEstados.DescripcionColumn);
            }
            
            public void SetDescripcionNull() {
                this[this.tabletsa_CuentasObservacionesEstados.DescripcionColumn] = System.Convert.DBNull;
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletsa_CuentasObservacionesEstados.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletsa_CuentasObservacionesEstados.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsActivoNull() {
                return this.IsNull(this.tabletsa_CuentasObservacionesEstados.ActivoColumn);
            }
            
            public void SetActivoNull() {
                this[this.tabletsa_CuentasObservacionesEstados.ActivoColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletsa_CuentasObservacionesEstados.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletsa_CuentasObservacionesEstados.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletsa_CuentasObservacionesEstados.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletsa_CuentasObservacionesEstados.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletsa_CuentasObservacionesEstados.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletsa_CuentasObservacionesEstados.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletsa_CuentasObservacionesEstados.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletsa_CuentasObservacionesEstados.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletsa_CuentasObservacionesEstados.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletsa_CuentasObservacionesEstados.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletsa_CuentasObservacionesEstados.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletsa_CuentasObservacionesEstados.IdSucursalColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletsa_CuentasObservacionesEstados.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletsa_CuentasObservacionesEstados.IdEmpresaColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsa_CuentasObservacionesEstadosRowChangeEvent : EventArgs {
            
            private tsa_CuentasObservacionesEstadosRow eventRow;
            
            private DataRowAction eventAction;
            
            public tsa_CuentasObservacionesEstadosRowChangeEvent(tsa_CuentasObservacionesEstadosRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tsa_CuentasObservacionesEstadosRow Row {
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