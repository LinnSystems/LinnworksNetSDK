using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderFolder : LinnObject
	{
        /// <summary>
        /// Folder ID 
        /// </summary>
		public Guid pkFolderId { get; set; }

        /// <summary>
        /// Folder name 
        /// </summary>
		public String FolderName { get; set; }
	} 
}