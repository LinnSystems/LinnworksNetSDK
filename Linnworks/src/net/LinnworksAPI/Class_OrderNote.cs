using System;

namespace LinnworksAPI
{
    [Serializable]
    public class OrderNote
    {
        public Guid OrderNoteId;
        public DateTime NoteDate;
        public Boolean Internal;
        public String Note;
        public String CreatedBy;
    }
}