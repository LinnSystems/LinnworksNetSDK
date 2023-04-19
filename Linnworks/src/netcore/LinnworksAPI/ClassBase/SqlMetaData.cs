using System.Collections.Generic;
using System.Text;
using System;
using System.Data.SqlTypes;
using System.Data;
using System.Data.SqlClient;

namespace LinnworksAPI
{ 
    public class SqlMetaData : LinnObject
	{
		public SqlCompareOptions CompareOptions { get; set; }

		public DbType DbType { get; set; }

		public Boolean IsUniqueKey { get; set; }

		public Int64 LocaleId { get; set; }

		public Int64 Max { get; set; }

		public Int64 MaxLength { get; set; }

		public String Name { get; set; }

		public Byte Precision { get; set; }

		public Byte Scale { get; set; }

		public SortOrder SortOrder { get; set; }

		public Int32 SortOrdinal { get; set; }

		public SqlDbType SqlDbType { get; set; }

		public Type Type { get; set; }

		public String TypeName { get; set; }

		public Boolean UseServerDefault { get; set; }

		public String XmlSchemaCollectionDatabase { get; set; }

		public String XmlSchemaCollectionName { get; set; }

		public String XmlSchemaCollectionOwningSchema { get; set; }
	} 
}