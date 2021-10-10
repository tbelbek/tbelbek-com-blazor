using System.IO;
using System.Text.Json;
using tbelbek.com.Model;

namespace tbelbek.com.Helper
{
    public class SiteDataParser : ISiteDataParser
    {
        public SiteData GetSiteDataJson()
        {
            string fileName = "workdata.json";
            string jsonString = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<SiteData>(jsonString);
        }
    }
}