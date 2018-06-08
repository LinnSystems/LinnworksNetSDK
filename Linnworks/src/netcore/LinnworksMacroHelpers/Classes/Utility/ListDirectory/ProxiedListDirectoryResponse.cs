using System.Collections.Generic;

namespace LinnworksMacroHelpers.Classes.Utility
{
    public class ProxiedListDirectoryResponse : ProxiedBaseResponse
    {
        /// <summary>
        /// A list of files contained in the requested directory
        /// </summary>
        public List<BaseDirectoryItem> FileList { get; set; }
    }

    public class BaseDirectoryItem
    {
        /// <summary>
        /// Item path
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Item type
        /// </summary>
        public DirectoryItemType Type { get; set; }

        /// <summary>
        /// Directory Item type
        /// Specifies the item type when listing a directory
        /// </summary>
        public enum DirectoryItemType
        {
            Directory,
            File
        }
    }
}
