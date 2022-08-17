using ASP_NET_HW_Module_02_part_01.Models;
using ASP_NET_HW_Module_02_part_01.Models.Figures;
using ASP_NET_HW_Module_02_part_01.Repositories;
using ASP_NET_HW_Module_02_part_01.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_HW_Module_02_part_01.Controllers
{
    public class TasksController : Controller
	{
		private IWebHostEnvironment env;
		private readonly IRepositoryAnimals _repositoryAnimals;
		private readonly IRepositoryFigures _repositoryFigures;
		public Dictionary<List<string>, List<string>> figures;

		public TasksController(IWebHostEnvironment env, IRepositoryAnimals repositoryAnimals, IRepositoryFigures repositoryFigures)
        {
			this.env = env;
			_repositoryAnimals = repositoryAnimals;
			_repositoryFigures = repositoryFigures;
			figures = new Dictionary<List<string>, List<string>>();
        }

		public IActionResult OnPostCreate(Figure figure)
		{
			var result = figure.Name + " ," + figure.Visual + Environment.NewLine;

			var dataFile = env.WebRootPath + "/App_Data/data.txt";

			System.IO.File.WriteAllText(@dataFile, result);

			return RedirectToPage("");
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
