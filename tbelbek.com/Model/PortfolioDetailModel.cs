using Microsoft.Extensions.Localization;

namespace tbelbek.com.Model
{
    public class PortfolioDetailModel : ISortInfo, IObjectFormatter
    {
        public LangImage Language { get; set; }
        public string LanguageLogo => GetLanguageImage();
        public string ProjectName { get; set; }
        public string ModalDetail { get; set; }
        public string ModalKey { get; set; }
        public string TechDetail { get; set; }

        public void ObjectFormatter(IStringLocalizer localizer)
        {
            ModalDetail = localizer[ModalKey];
        }

        public int Line { get; set; }

        private string GetLanguageImage()
        {
            return Language == LangImage.CSharp ? "images/portfolio/csharp.png" : "images/portfolio/cpp_logo.png";
        }
    }
}