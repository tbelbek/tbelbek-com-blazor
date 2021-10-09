namespace tbelbek.com.Model
{
    public class WorkInfoModel : ISortInfo
    {
        public WorkInfoModel()
        {
        }

        public string Company { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public int Line { get; set; }
    }

    public interface ISortInfo
    {
        public int Line { get; set; }
    }
}