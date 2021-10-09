namespace tbelbek.com.Model
{
    public class PortfolioDetailModel : ISortInfo
    {
        public LangImage Language { get; set; }
        public string LanguageLogo => GetLanguageImage();
        public string ProjectName { get; set; }
        public string ModalDetail { get; set; }
        public string TechDetail { get; set; }
        public int Line { get; set; }

        public string GetLanguageImage()
        {
            return this.Language == LangImage.CSharp ? "images/portfolio/csharp.png" : "images/portfolio/cpp_logo.png";
        }
    }
}