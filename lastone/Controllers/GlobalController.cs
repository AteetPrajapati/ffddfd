using lastone.models.DBModels;
using lastone.repositories.Repos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lastone.Controllers
{
    public class GlobalController : Controller
    {
        // GET: Global
        public IGlobalRepository globalRepository;
        public GlobalController(IGlobalRepository _globalRepository)
        {
            globalRepository = _globalRepository;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetStates(int countryId)
        {
            List<State> states = globalRepository.GetStates(countryId);
            return Json(states, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetCities(int countryId, int stateId)
        {
            List<City> cities = globalRepository.GetCities(countryId, stateId);
            return Json(cities, JsonRequestBehavior.AllowGet);
        }
    }
}