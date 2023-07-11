using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinnMacroCustomer;
public class Api2Helper
{
    public string GetUrl(string baseApi1Server)
    {
        var (region, environment) = ExtractRegionAndLocation(baseApi1Server);
        if (environment == EnvironmentType.PROD)
        {
            return $"https://apim-{region.ToString().ToLower()}.linnworks.net/gateway";
        }
        return $"https://apim-{environment.ToString().ToLower()}.linnworks.net/gateway";
    }
    private (RegionType, EnvironmentType) ExtractRegionAndLocation(string baseApi1Server)
    {
        RegionType region = RegionType.EU;
        EnvironmentType environment = EnvironmentType.PROD;
        if (baseApi1Server.ToLower().Contains("dev"))
        {
            environment = EnvironmentType.DEV;
        }
        else if (baseApi1Server.ToLower().Contains("staging"))
        {
            environment = EnvironmentType.STAGING;
        }
        if (baseApi1Server.ToLower().Contains("us"))
        {
            region = RegionType.US;
        }
        else if (baseApi1Server.ToLower().Contains("as"))
        {
            region = RegionType.AS;
        }
        return (region, environment);
    }
}
public enum EnvironmentType
{
    DEV,
    STAGING,
    PROD
}
public enum RegionType
{
    US,
    EU,
    AS
}