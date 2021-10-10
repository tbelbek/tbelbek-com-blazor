using Microsoft.Extensions.Localization;

namespace tbelbek.com.Model
{
    public class WorkInfoModel : ISortInfo, IObjectFormatter
    {
        public WorkInfoModel()
        {
        }

        public string Company { get; set; }
        public string Title { get; set; }
        public string TitleKey { get; set; }
        public string Date { get; set; }
        public string DateStartMonthKey { get; set; }
        public string DateEndMonthKey { get; set; }
        public string StartYear { get; set; }
        public string EndYear { get; set; }
        public int Line { get; set; }

        public void ObjectFormatter(IStringLocalizer localizer)
        {
            Date = string.IsNullOrEmpty(EndYear) && string.IsNullOrEmpty(DateEndMonthKey)
                ? $"{localizer[DateStartMonthKey]} {StartYear} - {localizer["Now"]}"
                : $"{localizer[DateStartMonthKey]} {StartYear} - {localizer[DateEndMonthKey]} {EndYear}";
            Title = localizer[TitleKey];
        }
    }
}