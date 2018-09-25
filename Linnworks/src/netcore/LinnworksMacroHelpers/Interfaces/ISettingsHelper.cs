using System;

namespace LinnworksMacroHelpers.Interfaces
{
    public interface ISettingsHelper
    {
        Guid GetInstallationId();

        string GetPublicSetting(string key);

        string GetSetting(string key);

        long? GetPublicSettingAsLong(string key);

        long? GetSettingAsLong(string key);

        int? GetPublicSettingAsInt(string key);

        int? GetSettingAsInt(string key);

        double? GetPublicSettingAsDouble(string key);

        double? GetSettingAsDouble(string key);

        bool? GetPublicSettingAsBool(string key);

        bool? GetSettingAsBool(string key);

        Guid? GetPublicSettingAsGuid(string key);

        Guid? GetSettingAsGuid(string key);

        void SetPublicSetting(string key, string value);

        void SetSetting(string key, string value);

        void DeletePublicSetting(string key);

        void DeleteSetting(string key);
    }
}
