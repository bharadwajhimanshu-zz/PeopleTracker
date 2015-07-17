using System.Web.Http;

namespace peopleService.Controllers
{
    public class AboutController : ApiController
    {
        public string Get()
        {
            return "Fabrikam Fiber (c) 2014.";
            //return "Your application description page.";
        }
    }
}
