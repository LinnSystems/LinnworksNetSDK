using System;

namespace LinnworksAPI
{
    public class WarehouseTransferItemNote
    {
        public Guid PkTransferItemNoteId;
        public String NoteUser;
        public String Note;
        public DateTime NoteDateTime;
        public Boolean NoteRead;
        public Guid FkBinId;
        public Guid PkTransferItemId;
    }
}