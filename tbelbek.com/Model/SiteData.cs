using System.Collections.Generic;

namespace tbelbek.com.Model
{
    public class SiteData
    {
        public List<WorkInfoModel> WorkInfo { get; set; }
        public List<EduInfoModel> EduInfo { get; set; }
        public List<SkillInfoModel> SkillInfo { get; set; }
        public List<PortfolioHeaderModel> PortfolioHeaderInfo { get; set; }
        public List<PortfolioDetailModel> PortfolioDetailInfo { get; set; }
    }
}