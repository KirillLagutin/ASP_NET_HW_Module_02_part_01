using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_HW_Module_02_part_01.Controllers
{
    public class TasksController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Task1()
		{
			return View();
		}

        public ActionResult Task2()
        {
            return View();
        }
	}
}
