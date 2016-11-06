using CRUDWithJSONInWCF_Client.Models;
using System.Web.Mvc;

namespace CRUDWithJSONInWCF_Client.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            ProductServiceClient psc = new ProductServiceClient();
            ViewBag.listProducts = psc.findAll();
            return View();
        }
    }
}