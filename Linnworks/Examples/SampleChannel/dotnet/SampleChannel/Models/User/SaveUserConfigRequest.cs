namespace SampleChannel.Models.User
{
    public class SaveUserConfigRequest : BaseRequest
    {
        /// <summary>
        /// The next wizard step name.
        /// </summary>
        public string StepName { get; set; }

        /// <summary>
        /// Config Items.
        /// </summary>
        public ConfigItem[] ConfigItems { get; set; }
    }
}