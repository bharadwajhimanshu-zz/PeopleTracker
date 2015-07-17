namespace peopleService.Controllers
{
   #region using

   using System.Web.Mvc;

   #endregion

   public class HomeController : Controller
   {
      #region Public Methods and Operators

      public ActionResult Index()
      {
         this.ViewBag.Title = "Home Page";

         return this.View();
      }

      #endregion
   }
}