using Prism.Mvvm;

namespace MTCO.InspectionMobileApp.Models
{
    public class UpdateTile: BindableBase
    {
        private string title;
        public string Title { get { return title; } set { SetProperty(ref title, value); } }

        private string message;
        public string Message { get { return message; } set { SetProperty(ref message, value); } }

        private string url;
        public string Url { get { return url; } set { SetProperty(ref url, value); } }

        private string urlTitle;
        public string UrlTitle { get { return urlTitle; } set { SetProperty(ref urlTitle, value); } }
    }
}
