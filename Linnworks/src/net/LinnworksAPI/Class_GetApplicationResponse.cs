using System;

namespace LinnworksAPI
{
    public class GetApplicationResponse
    {
        public DeveloperApplication Application;
        public Boolean AlreadyIntegrated;
        public Guid Token;
        public Boolean LeftReview;
    }
}