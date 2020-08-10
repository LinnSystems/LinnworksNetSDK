using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PackageGroup
	{
        /// <summary>
        /// Package category ID 
        /// </summary>
		public Guid PackageCategoryID { get; set; }

        /// <summary>
        /// Package category name 
        /// </summary>
		public String PackageCategory { get; set; }

        /// <summary>
        /// Record row ID 
        /// </summary>
		public Guid rowguid { get; set; }

        /// <summary>
        /// List of packaging types 
        /// </summary>
		public List<PackageType> PackageTypes { get; set; }
	} 
}