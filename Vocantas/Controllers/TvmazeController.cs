using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VocantsBusinessLogic.Interface;
using VocantsBusinessLogic.Models;
using VocantsBusinessLogic.Manager;

namespace Vocantas.Controllers
{
    public class TvmazeController : Controller
    {
		private readonly ITvMazeManager _TvMazeManager;
		public TvmazeController(ITvMazeManager TvMazeManager)
		{
			_TvMazeManager = TvMazeManager;
		}
		public TvmazeController()
		{
			_TvMazeManager = new TvMazeManager();
		}

		// GET: Tvmaze
		public ActionResult Index()
        {
            return View();
        }

		public ActionResult Serverside()
		{
			
			var result = _TvMazeManager.GetData();

			return View(result);	
		}
		public ActionResult Clientside()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Clientside(FormCollection fc)
		{
			return View();
		}
	}
}