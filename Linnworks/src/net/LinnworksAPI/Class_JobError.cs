using System;

namespace LinnworksAPI
{
    public class JobError
    {
        public Int32 JobErrorId;
        public String Action;
        public Guid? OrderId;
        public Int32 ErrorType;
        public String ErrorText;
    }
}