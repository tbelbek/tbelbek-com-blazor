using Microsoft.Extensions.Localization;

namespace tbelbek.com.Model
{
    public class EduInfoModel : ISortInfo, IObjectFormatter
    {
        public string School { get; set; }
        public string SchoolStartName { get; set; }
        public string Date { get; set; }
        public string MonthKey { get; set; }
        public string Year { get; set; }
        public string Tag { get; set; }
        public string TagName { get; set; }

        public void ObjectFormatter(IStringLocalizer localizer)
        {
            School = $"{SchoolStartName} {localizer["University"]}";
            Date = $"{localizer[MonthKey]} {Year}";
            Tag = localizer[TagName];
        }

        public int Line { get; set; }
    }
}