using System.Configuration;

namespace DataLayer.ApplicationBasics
{
    public class ApplicationBasic
    {
        private ApplicationBasic() { }

        private static string _url;

        private static ApplicationBasic _applicationBasic;

        public static ApplicationBasic GetApplicationBasicInstance()
        {
            return _applicationBasic ?? (_applicationBasic = new ApplicationBasic());
        }

        public static string Url
        {
            get
            {
                _url = ConfigurationManager.AppSettings["urlString"];
                return _url;
            }
        }

    }
}
