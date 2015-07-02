using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ApplicationBasics
{
    public class ApplicationBasic
    {
        private ApplicationBasic() { }

        private static string url;

        private static ApplicationBasic _applicationBasic;

        public static ApplicationBasic GetApplicationBasicInstance()
        {
            return _applicationBasic ?? (_applicationBasic = new ApplicationBasic());
        }

        public static string Url
        {
            get
            {
                url = ConfigurationManager.AppSettings["urlString"];
                return url;
            }
        }

    }
}
