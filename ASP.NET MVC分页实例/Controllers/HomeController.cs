using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC分页实例.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int page=1)
        {
            PagingInfo pagingInfo = new PagingInfo
            {
                CurrentPage = page,
                TotalItems = 1000,
                ItemsPerPage = 10,
            };
            return View(pagingInfo);
        }
    }
}