using System;

namespace LinnworksAPI
{
    public class ExportSession
    {
        public DateTime _sessionDateTime;
        public DateTime _completedDateTime;
        public Int32 pkExportSessionId;
        public Int32 fkExportId;
        public DateTime SessionDateTime;
        public DateTime CompletedDateTime;
        public Boolean IsError;
        public Int32 RowsExported;
        public Int32 Errors;
    }
}