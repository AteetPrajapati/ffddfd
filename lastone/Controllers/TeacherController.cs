using lastone.models.CustomeModels;
using lastone.repositories.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lastone.Controllers
{
    public class TeacherController : Controller
    {
        public IGlobalRepository globalRepository;
        public ITeacherRepository  teacherRepository;
        public TeacherController(IGlobalRepository _globalRepository, ITeacherRepository _teacherRepository)
        {
            globalRepository = _globalRepository;
            teacherRepository = _teacherRepository;
        }
        // GET: Teacher
        public ActionResult Index()
        {
            return View(teacherRepository.GetTeachers());
        }
        public ActionResult Add()
        {
            ViewBag.Subjects = globalRepository.GetSubjects();
            ViewBag.Countries = globalRepository.GetCountries();
            return View(new TeacherModel());
        }
        [HttpPost]
        public ActionResult Add(TeacherModel teacherModel)
        {
            return teacherRepository.AddTeacher(teacherModel) ? View("Index") :  View("Error");
        }
        public ActionResult Edit(int id)
        {
            ViewBag.Subjects = globalRepository.GetSubjects();
            ViewBag.Countries = globalRepository.GetCountries();
            TeacherModel teacherModel = teacherRepository.GetTeacherByID(id);
            ViewBag.States = globalRepository.GetStates(teacherModel.Country);
            ViewBag.Cities = globalRepository.GetCities(teacherModel.Country, teacherModel.State);
            return View(teacherModel);
        }
        [HttpPost]
        public ActionResult Edit(TeacherModel teacherModel)
        {
            return teacherRepository.AddTeacher(teacherModel) ? View("Index") : View("Error");
        }
    }
}