using System;
using System.Collections;
using System.Data;
using System.Reflection; 

namespace mz.erp.commontypes
{
   public class DataTableConverter
   {
      private bool _enforceKeys = false;
      public DataTableConverter() { } 
      public DataTableConverter(bool enforceKeys)
      {
         _enforceKeys = enforceKeys;
      } 
      
	  public DataTable GetDataTable(IList items)
      {
         DataTable dt = new DataTable(); 
         //Primero construimos el esquema a partir del primer elemento
		  if(items.Count > 0)
		  {
			  dt = this.ConstructDataTableSchema(items[0]);
			  if (dt != null)
			  {
				  // Creamos una fila por cada item de la lista
				  for (int i = 0; i < items.Count; i++)
				  {
					  DataRow dr = dt.NewRow(); 
					  Type type = items[i].GetType();               
					  MemberInfo[] members = type.GetProperties(); 
               
					  foreach (MemberInfo member in members)               
					  {
						  object[] attributes = member.GetCustomAttributes(true); 
						  if (attributes.Length != 0)
						  {
							  foreach (object attribute in attributes)
							  {
								  DataTableConversionAttribute ca = attribute as 
									  DataTableConversionAttribute;
								  if (ca != null)
								  {
									  if (ca.DataTableConversion)
									  {
										  string[] nameArray = member.Name.ToString().Split(Convert.ToChar(" "));
										  PropertyInfo prop = type.GetProperty(                                                       nameArray[0]);
										  Type valueType = prop.GetValue(items[i],                                                             null).GetType(); 
										  dr[nameArray[0]] = prop.GetValue(items[i],null);
									  }
								  }
							  }
						  }
					  } 
               
					  dt.Rows.Add(dr);
				  } 
			  }
			  
		  }
		   return dt;
      }
 
      private DataTable ConstructDataTableSchema(object item)
      {
         string tableName = string.Empty;
         ArrayList schemaContainers = new ArrayList(); 
         Type type = item.GetType();
         MemberInfo[] members = type.GetProperties(); 
         foreach (MemberInfo member in members)
         {
            object[] attributes = member.GetCustomAttributes(true); 
            if (attributes.Length != 0)
            {
               foreach (object attribute in attributes)
               {
                  DataTableConversionAttribute ca = attribute as DataTableConversionAttribute;
                  if (ca != null)
                  {
                     if (ca.DataTableConversion)
                     {
                        //Usamos el nombre de la calse como nombre del DataTable resultado
                        string[] classNameArray = member.ReflectedType.ToString().Split(Convert.ToChar("."));
                        tableName = classNameArray[classNameArray.Length- 1]; 
                        string name = member.Name.ToString();
                        PropertyInfo prop = type.GetProperty(name);
                        Type valueType = prop.GetValue(item, null).GetType(); 
                        schemaContainers.Add(new DataTableConverterContainer(name,
                           valueType, ca.AllowDbNull, ca.KeyField));
                     }
                  }
               }
            }
         } 
         if (schemaContainers.Count > 0)
         {
            DataTable dataTable = new DataTable(tableName);
            DataColumn[] dataColumn = new DataColumn[schemaContainers.Count]; 
            // Cuento la cantidad de columnas que forman parte de la clave de la tabla
            int totalNumberofKeys = 0;
            foreach (DataTableConverterContainer container in schemaContainers)
            {
               if (container.IsKey == true && _enforceKeys == true)
               {
                  totalNumberofKeys = totalNumberofKeys + 1;
               }
            } 
            // Armo las columnas
            DataColumn[] keyColumnArray = new DataColumn[totalNumberofKeys];
            int keyColumnIndex = 0;
            for (int i = 0; i < schemaContainers.Count; i++)
            {
               dataColumn[i] = new DataColumn();
               dataColumn[i].DataType = ((DataTableConverterContainer)schemaContainers[i]).PropertyType;
               dataColumn[i].ColumnName = ((DataTableConverterContainer)schemaContainers[i]).PropertyName;
               dataColumn[i].AllowDBNull = ((DataTableConverterContainer)schemaContainers[i]).AllowDbNull;
               dataTable.Columns.Add(dataColumn[i]); 
               if (((DataTableConverterContainer)schemaContainers[i]).IsKey == true && _enforceKeys == true)
               {
                  keyColumnArray[keyColumnIndex] = dataColumn[i];
                  keyColumnIndex = keyColumnIndex + 1;
               }
            } 
            if (_enforceKeys)
            {
               dataTable.PrimaryKey = keyColumnArray;
            }
            return dataTable;
         } 
         return null;
      } 

      private class DataTableConverterContainer
      {
         private string _propertyName;
         private Type _propertyType;
         private bool _allowDbNull;
         private bool _isKey; 
         internal DataTableConverterContainer(string propertyName, Type propertyType,
            bool allowDbNull, bool isKey)
         {
            _propertyName = propertyName;
            _propertyType = propertyType;
            _allowDbNull = allowDbNull;
            _isKey = isKey;
         } 
         public string PropertyName
         {
            get { return _propertyName; }
            set { _propertyName = value; }
         } 
         public Type PropertyType
         {
            get { return _propertyType; }
            set { _propertyType = value; }
         } 
         public bool AllowDbNull
         {
            get { return _allowDbNull; }
            set { _allowDbNull = value; }
         } 
         public bool IsKey
         {
            get { return _isKey; }
            set { _isKey = value; }
         }
      }      
   }
}


