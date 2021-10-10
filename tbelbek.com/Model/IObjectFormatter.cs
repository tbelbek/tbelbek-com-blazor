using Microsoft.Extensions.Localization;

namespace tbelbek.com.Model
{
    public interface IObjectFormatter
    {
        public void ObjectFormatter(IStringLocalizer localizer);
    }
}