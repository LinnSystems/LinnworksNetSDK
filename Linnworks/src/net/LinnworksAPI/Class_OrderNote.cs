using System;

namespace LinnworksAPI
{
    public class OrderNote
    {
        public Guid pkOrderNoteId;
        public Guid fkOrderId;
        public String Note;
        public DateTime NoteEntryDate;
        public String NoteUserName;
        public Boolean? Internal;
        public Byte? NoteTypeId;
    }
}