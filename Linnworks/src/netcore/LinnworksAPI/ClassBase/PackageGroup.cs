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
		public Guid PackageCategoryID;

        /// <summary>
        /// Package category name 
        /// </summary>
		public String PackageCategory;

        /// <summary>
        /// Record row ID 
        /// </summary>
		public Guid rowguid;

        /// <summary>
        /// List of packaging types 
        /// </summary>
		public List<PackageType> PackageTypes;
	} 
}