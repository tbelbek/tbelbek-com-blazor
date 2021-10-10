using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Localization;
using tbelbek.com.Model;

namespace tbelbek.com.Helper
{
    public class DataStore : IDataStore
    {
        public DataStore(IStringLocalizer localizer, ISiteDataParser siteDataParser)
        {
            Localizer = localizer;
            SiteDataParser = siteDataParser;
        }

        public SiteData SiteData { get; set; }
        private IStringLocalizer Localizer { get; set; }
        private ISiteDataParser SiteDataParser { get; }

        public List<WorkInfoModel> GetWorkInfo()
        {
            var data = SiteDataParser.GetSiteDataJson().WorkInfo;
            data.ForEach(t => t.ObjectFormatter(Localizer));
            return data.OrderByDescending(t => t.Line).ToList();
        }

        public List<EduInfoModel> GetEduInfo()
        {
            var data = SiteDataParser.GetSiteDataJson().EduInfo;
            data.ForEach(t => t.ObjectFormatter(Localizer));
            return data.OrderByDescending(t => t.Line).ToList();
        }

        public List<SkillInfoModel> GetSkillInfo()
        {
            return SiteDataParser.GetSiteDataJson().SkillInfo.OrderBy(t => t.Line).ToList();
        }

        public List<PortfolioHeaderModel> GetPortfolioHeaderInfo()
        {
            return SiteDataParser.GetSiteDataJson().PortfolioHeaderInfo.OrderBy(t => t.Line).ToList();
        }

        public List<PortfolioDetailModel> GetPortfolioDetailInfo()
        {
            var data = SiteDataParser.GetSiteDataJson().PortfolioDetailInfo;
            data.ForEach(t => t.ObjectFormatter(Localizer));
            return data.OrderBy(t => t.Line).ToList();
        }
    }
}