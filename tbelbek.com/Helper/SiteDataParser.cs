using System.IO;
using System.Text.Json;
using tbelbek.com.Model;

namespace tbelbek.com.Helper
{
    public class SiteDataParser : ISiteDataParser
    {
        public SiteData GetSiteDataJson()
        {
            const string fileName = "workdata.json";
            var jsonString = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<SiteData>(jsonString);
        }
    }
}