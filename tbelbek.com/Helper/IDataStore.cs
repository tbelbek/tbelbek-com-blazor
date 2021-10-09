using System.Collections.Generic;
using tbelbek.com.Model;

namespace tbelbek.com.Helper
{
    public interface IDataStore
    {
        public List<WorkInfoModel> GetWorkInfo();
        public List<EduInfoModel> GetEduInfo();
        public List<SkillInfoModel> GetSkillInfo();
        public List<PortfolioHeaderModel> GetPortfolioHeaderInfo();
        public List<PortfolioDetailModel> GetPortfolioDetailInfo();
    }
}