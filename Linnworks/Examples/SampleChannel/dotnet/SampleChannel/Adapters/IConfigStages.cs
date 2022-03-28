using SampleChannel.Models.User;

namespace SampleChannel.Adapters
{
    public interface IConfigStages
    {
        public UserConfigResponse StageResponse(UserConfig userConfig, string errorMessage = "");
    }
}
