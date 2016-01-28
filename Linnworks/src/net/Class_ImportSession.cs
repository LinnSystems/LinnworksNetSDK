using System;

namespace LinnworksAPI
{
    public class ImportSession
    {
        public DateTime _sessionDateTime;
        public DateTime _completedDateTime;
        public Int32 pkImportSessionId;
        public Int32 fkImportId;
        public DateTime SessionDateTime;
        public DateTime CompletedDateTime;
        public Boolean IsError;
        public Guid FileNameTag;
        public Int32 RowsProcessed;
        public Boolean Skipped;
        public Double SecondsToDownload;
        public Int32 Errors;
    }
}