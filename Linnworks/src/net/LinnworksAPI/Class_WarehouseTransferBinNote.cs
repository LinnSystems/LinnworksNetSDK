using System;

namespace LinnworksAPI
{
    public class WarehouseTransferBinNote
    {
        public Guid PkTransferBinNoteId;
        public String NoteUser;
        public String Note;
        public DateTime NoteDateTime;
        public Boolean NoteRead;
        public Guid PkBinId;
    }
}