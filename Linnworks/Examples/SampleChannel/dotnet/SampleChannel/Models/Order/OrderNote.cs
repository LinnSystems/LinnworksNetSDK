using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleChannel.Models.Order
{
    public class OrderNote
    {
        /// <summary>
        /// Note text, duplicates will be ignored.
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Date of the note Format: ​"yyyy-MM-dd HH:mm:ssZ".
        /// </summary>
        public DateTime NoteEntryDate { get; set; }

        /// <summary>
        /// User who entered the note, if left blank "Channel" will be entered.
        /// </summary>
        public string NoteUserName { get; set; }

        /// <summary>
        /// User who entered the note, if left blank "Channel" will be entered.
        /// </summary>
        public bool IsInternal { get; set; }
    }
}