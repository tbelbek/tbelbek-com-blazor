using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Localization;
using tbelbek.com.Model;

namespace tbelbek.com.Helper
{
    public class DataStore : IDataStore
    {
        private IStringLocalizer Localizer { get; set; }

        public DataStore(IStringLocalizer localizer)
        {
            Localizer = localizer;
        }

        public List<WorkInfoModel> GetWorkInfo()
        {
            var list = new List<WorkInfoModel>();

            list.Add(new WorkInfoModel()
            {
                Company = "KoçSistem",
                Title = Localizer["SoftwareDevelopmentTechnologyManager"],
                Date = $"{Localizer["Temmuz"]} 2021 - {Localizer["Now"]}",
                Line = 5
            });

            list.Add(new WorkInfoModel()
            {
                Company = "KoçSistem",
                Title = Localizer["SoftwareDevelopmentLead"],
                Date = $"{Localizer["Mart"]} 2020 - {Localizer["Haziran"]} 2021",
                Line = 4
            });

            list.Add(new WorkInfoModel()
            {
                Company = "KoçSistem",
                Title = Localizer["SeniorSoftwareDeveloper"],
                Date = $"{Localizer["Mart"]} 2018 - {Localizer["Mart"]} 2020",
                Line = 3
            });

            list.Add(new WorkInfoModel()
            {
                Company = "Antasya Software",
                Title =Localizer["SoftwareSpecialist"] ,
                Date = $"{Localizer["Aralik"]} 2016 - {Localizer["Mart"]} 2018",
                Line = 2
            });

            list.Add(new WorkInfoModel()
            {
                Company = "BilgeAdam",
                Title = Localizer["SoftwareConsultant"],
                Date = $"{Localizer["Agustos"]} 2014 - {Localizer["Aralik"]} 2016",
                Line = 1
            });

            return list.OrderByDescending(t => t.Line).ToList();
        }

        public List<EduInfoModel> GetEduInfo()
        {
            var list = new List<EduInfoModel>();

            list.Add(new EduInfoModel()
            {
                School = $"Beykent {Localizer["University"]}",
                Tag = Localizer["EducationTag4"],
                Date = $"{Localizer["Haziran"]} 2017",
                Line = 2
            });

            list.Add(new EduInfoModel()
            {
                School = $"Marmara {Localizer["University"]}",
                Tag = Localizer["EducationTag2"],
                Date = $"{Localizer["Haziran"]} 2014",
                Line = 1
            });

            return list.OrderByDescending(t => t.Line).ToList();
        }

        public List<SkillInfoModel> GetSkillInfo()
        {
            var list = new List<SkillInfoModel>();

            list.Add(new SkillInfoModel()
            {
                Skill = "ASP.NET",
                Class = "aspnet",
                Line = 1
            });

            list.Add(new SkillInfoModel()
            {
                Skill = ".NET Core",
                Class = "netcore",
                Line = 2
            });

            list.Add(new SkillInfoModel()
            {
                Skill = "C#",
                Class = "csharp",
                Line = 3
            });

            list.Add(new SkillInfoModel()
            {
                Skill = "C++",
                Class = "cpp",
                Line = 4
            });

            list.Add(new SkillInfoModel()
            {
                Skill = "MS SQL",
                Class = "mssql",
                Line = 5
            });

            list.Add(new SkillInfoModel()
            {
                Skill = "MVC",
                Class = "mvc",
                Line = 6
            });

            list.Add(new SkillInfoModel()
            {
                Skill = "Windows Apps",
                Class = "winapps",
                Line = 7
            });

            list.Add(new SkillInfoModel()
            {
                Skill = "Linux",
                Class = "linux",
                Line = 8
            });

            list.Add(new SkillInfoModel()
            {
                Skill = "DevSecOps",
                Class = "devops",
                Line = 9
            });

            list.Add(new SkillInfoModel()
            {
                Skill = "Azure",
                Class = "azure",
                Line = 10
            });

            list.Add(new SkillInfoModel()
            {
                Skill = "AGILE/SCRUM",
                Class = "linux",
                Line = 11
            });

            list.Add(new SkillInfoModel()
            {
                Skill = "Queue structures, No-Sql databases, ORM Tools, ETC.",
                Class = "no-sql",
                Line = 12
            });

            return list.OrderBy(t => t.Line).ToList();
        }

        public List<PortfolioHeaderModel> GetPortfolioHeaderInfo()
        {
            var list = new List<PortfolioHeaderModel>();

            list.Add(new PortfolioHeaderModel()
            {
                Company = "Borusan Otomotiv",
                Explanation = "Web app with MVC",
                Image = "images/borusanotomotiv-logo-facebook.jpg",
                Line = 1
            });

            list.Add(new PortfolioHeaderModel()
            {
                Company = "Boyner",
                Explanation = "Web app with MVC",
                Image = "images/boyner.jpg",
                Line = 2
            });

            list.Add(new PortfolioHeaderModel()
            {
                Company = "Kordsa",
                Explanation = "Web app with MVC",
                Image = "images/kordsa.png",
                Line = 3
            });

            list.Add(new PortfolioHeaderModel()
            {
                Company = "Medical Park",
                Explanation = "Web app with MVC",
                Image = "images/mlp.png",
                Line = 4
            });

            list.Add(new PortfolioHeaderModel()
            {
                Company = "Modyo Signage",
                Explanation = "MVC, Web API, Android",
                Image = "images/modyo_logo_v-copy.jpg",
                Line = 5
            });

            list.Add(new PortfolioHeaderModel()
            {
                Company = "İETT",
                Explanation = "Qt C++ app, Embedded",
                Image = "images/iett.jpg",
                Line = 6
            });

            list.Add(new PortfolioHeaderModel()
            {
                Company = "Arçelik",
                Explanation = "C#, VB, Webforms, Winforms, .Net Core",
                Image = "images/ICRON-customer-logo-Arcelik-1.png",
                Line = 7
            });

            list.Add(new PortfolioHeaderModel()
            {
                Company = "Bosch Siemens Hausgerate",
                Explanation = "C#, .Net Core",
                Image = "images/bsh.png",
                Line = 8
            });

            list.Add(new PortfolioHeaderModel()
            {
                Company = "Aygaz",
                Explanation = "C#, .Net Core",
                Image = "images/aygaz.png",
                Line = 9
            });

            list.Add(new PortfolioHeaderModel()
            {
                Company = "Ford",
                Explanation = "C#, MVC, WebForms",
                Image = "images/ford.jpg",
                Line = 10
            });

            return list.OrderBy(t => t.Line).ToList();
        }

        public List<PortfolioDetailModel> GetPortfolioDetailInfo()
        {
            var list = new List<PortfolioDetailModel>();

            list.Add(new PortfolioDetailModel()
            {
                ProjectName = "Borusan Otomotiv Uzatılmış Garanti",
                TechDetail = "C#, MVC. ASP.Net",
                ModalDetail = Localizer["Modal1"],
                Language = LangImage.CSharp,
                Line = 1
            });

            list.Add(new PortfolioDetailModel()
            {
                ProjectName = "Boyner GiftCard Automation",
                TechDetail = "C#, MVC. ASP.Net",
                ModalDetail = Localizer["Modal2"],
                Language = LangImage.CSharp,
                Line = 2
            });

            list.Add(new PortfolioDetailModel()
            {
                ProjectName = "Kordsa Global Octopus",
                TechDetail = "C#, MVC. ASP.Net",
                ModalDetail = Localizer["Modal3"],
                Language = LangImage.CSharp,
                Line = 3
            });

            list.Add(new PortfolioDetailModel()
            {
                ProjectName = "MedicalPark Reflex",
                TechDetail = "C#, MVC. ASP.Net",
                ModalDetail = Localizer["Modal4"],
                Language = LangImage.CSharp,
                Line = 4
            });

            list.Add(new PortfolioDetailModel()
            {
                ProjectName = "Modyo Signage App",
                TechDetail = "C#, MVC. ASP.Net, Web API",
                ModalDetail = Localizer["Modal5"],
                Language = LangImage.CSharp,
                Line = 5
            });

            list.Add(new PortfolioDetailModel()
            {
                ProjectName = "AraçPc 2.0 IETT - AkYolBil 2.0 IETT",
                TechDetail = "C++, Qt Framework, Embedded Programming, C#, MVC. ASP.Net, Web API",
                ModalDetail = $"{Localizer["Modal6"]} - {Localizer["Modal7"]}",
                Language = LangImage.CPlusPlus,
                Line = 6
            });

            list.Add(new PortfolioDetailModel()
            {
                ProjectName = "Arçelik",
                TechDetail = "C#,.net Core, Winforms, Webforms",
                ModalDetail = Localizer["Modal8"],
                Language = LangImage.CSharp,
                Line = 7
            });

            list.Add(new PortfolioDetailModel()
            {
                ProjectName = "Bosch Siemens Hausgerate",
                TechDetail = "C#,.net Core, React.js",
                ModalDetail = Localizer["Modal9"],
                Language = LangImage.CSharp,
                Line = 8
            });

            list.Add(new PortfolioDetailModel()
            {
                ProjectName = "Aygaz",
                TechDetail = "C#,.net Core, React.js",
                ModalDetail = Localizer["Modal10"],
                Language = LangImage.CSharp,
                Line = 9
            });

            list.Add(new PortfolioDetailModel()
            {
                ProjectName = "Ford",
                TechDetail = "C#, WebForms, Oracle",
                ModalDetail = Localizer["Modal11"],
                Language = LangImage.CSharp,
                Line = 10
            });

            return list.OrderBy(t => t.Line).ToList();
        }
    }
}