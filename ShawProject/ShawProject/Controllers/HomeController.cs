using System.Web.Mvc;
using DataLayer.ApplicationBasics;
using DataLayer.BusinessObject;
using DataLayer.Model;

namespace ShawProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var url = ApplicationBasic.GetApplicationBasicInstance().Url;
            var cityModelObject = GenericJsonOperator.SerializedJsonDataRetriver<CityModel>(url);
            ResultModelSortByName resultModelSortByName = new ResultModelSortByName();
            foreach (var element in cityModelObject)
            {
                element.Results.Sort(resultModelSortByName);
            }
            return View(cityModelObject);
        }
        
    }
}