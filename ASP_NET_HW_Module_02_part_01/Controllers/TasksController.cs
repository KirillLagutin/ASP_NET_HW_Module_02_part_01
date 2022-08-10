using ASP_NET_HW_Module_02_part_01.Models;
using ASP_NET_HW_Module_02_part_01.Repositories;
using ASP_NET_HW_Module_02_part_01.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_HW_Module_02_part_01.Controllers
{
    public class TasksController : Controller
	{
		private readonly IRepository _repository;

		public TasksController(IRepository repository)
        {
			_repository = repository;
        }
		public IActionResult OnPostSaveFile()
		{
			_repository.WritingToFile();
			return RedirectToPage("");
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Task1()
		{

			return View(_repository.GetAnimals());
		}

        public IActionResult Task2()
        {
            return View();
        }
	}
}
