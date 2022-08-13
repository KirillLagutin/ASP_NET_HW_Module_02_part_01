using ASP_NET_HW_Module_02_part_01.Models;
using ASP_NET_HW_Module_02_part_01.Models.Figures;
using ASP_NET_HW_Module_02_part_01.Repositories;
using ASP_NET_HW_Module_02_part_01.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_HW_Module_02_part_01.Controllers
{
    public class TasksController : Controller
	{
		private readonly IRepositoryAnimals _repositoryAnimals;
		private readonly IRepositoryFigures _repositoryFigures;
		public Dictionary<List<string>, List<string>> figures;

		public TasksController(IRepositoryAnimals repositoryAnimals, IRepositoryFigures repositoryFigures)
        {
			_repositoryAnimals = repositoryAnimals;
			_repositoryFigures = repositoryFigures;
			figures = new Dictionary<List<string>, List<string>>();
        }
		public IActionResult SaveFile()
		{
			_repositoryAnimals.WritingToFile();

			return View();
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Task1()
		{

			return View(_repositoryAnimals.GetAnimals());
		}

        public IActionResult Task2()
        {
			figures.Add(_repositoryFigures.GetName(), _repositoryFigures.GetVisual());

			return View(figures);
        }
	}
}
