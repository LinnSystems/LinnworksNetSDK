using System;

namespace LinnworksMacroHelpers.Classes
{
    public class DropboxSettings : BaseSettings
    {
        public override int Port
        {
            get => 0;
            set { }
        }

        #region PrivateFields
        private String _token = String.Empty;
        #endregion

        /// <summary>
        /// Dropbox token
        /// </summary>
        public string Token
        {
            get { return _token ?? ""; }
            set { _token = (value ?? "").Trim(); }
        }
        
        public override void Validate()
        {
            if (string.IsNullOrWhiteSpace(Token))
                throw new ArgumentException("Token cannot be empty", nameof(Server));
        }
    }
}
