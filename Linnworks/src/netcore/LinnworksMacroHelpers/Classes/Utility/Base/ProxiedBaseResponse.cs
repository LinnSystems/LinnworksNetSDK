namespace LinnworksMacroHelpers.Classes.Utility
{
    public class ProxiedBaseResponse
    {
        /// <summary>
        /// If the request returns an error, this field will be populated with it
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        /// A boolean representation of whether the request returned an erroneous response
        /// </summary>
        public bool IsError => !string.IsNullOrWhiteSpace(Error);
    }
}
