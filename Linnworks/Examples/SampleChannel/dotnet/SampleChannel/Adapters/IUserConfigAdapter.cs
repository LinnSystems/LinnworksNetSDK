using SampleChannel.Models.User;
using System;

namespace SampleChannel.Adapters
{
    public interface IUserConfigAdapter
    {
        /// <summary>
        /// Load a user configuration.
        /// </summary>
        /// <param name="authorizationToken">The authorization token for the user account.</param>
        /// <returns>The user configuration.</returns>
        public UserConfig Load(string authorizationToken);

        /// <summary>
        /// Delete a user configuration.
        /// </summary>
        /// <param name="authorizationToken">The authorization token for the user account.</param>
        public void Delete(string authorizationToken);

        /// <summary>
        /// Create a new user configuration.
        /// </summary>
        /// <param name="email">The email address for the account.</param>
        /// <param name="linnworksUniqueIdentifier">The unique identifier assigned by linnworks.</param>
        /// <param name="accountName">The name of the account.</param>
        /// <returns>The newly created user configuration.</returns>
        public UserConfig CreateNew(string email, Guid linnworksUniqueIdentifier, string accountName);

        /// <summary>
        /// Save configuration items in the user config.
        /// </summary>
        /// <param name="userConfig">The user config.</param>
        /// <param name="configItems">The configuration items.</param>
        /// <returns>The result of the action.</returns>
        public UserConfigResponse Save(UserConfig userConfig, ConfigItem[] configItems);
    }
}
