using System;

namespace LinnworksAPI
{
    public class AjaxResult<Boolean>
    {
        public Boolean FinishedOK;
        public Boolean Data;
        public String ErrorMessage;
    }
}