using System;

namespace LinnworksAPI
{
    public class DeveloperApplication
    {
        public Guid ApplicationId;
        public Guid DeveloperId;
        public Guid AppSecret;
        public Guid AppVersion;
        public String Name;
        public String Description;
        public String ApplicationWebsite;
        public Int32 IsPublic;
        public Int32 IsDeleted;
        public String SubmitUrl;
        public String Logo;
        public String Permissions;
        public Int32 Rating;
        public Int32 ApplicationType;
        public ApplicationReview Reviews;
    }
}