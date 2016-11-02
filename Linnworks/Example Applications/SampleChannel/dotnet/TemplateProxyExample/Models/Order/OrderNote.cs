using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.Order
{
    public class OrderNote
    {
        public string Note { get; set; }
        public DateTime NoteEntryDate { get; set; }
        public string NoteUserName { get; set; }
        public bool IsInternal { get; set; }
    }
}