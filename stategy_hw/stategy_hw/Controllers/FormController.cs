using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using stategy_hw.Models;
using stategy_hw.Entities;
using stategy_hw.Services;

namespace stategy_hw.Controllers
{
    public class FormController : Controller
    {
        Context logic = new Context();
        string SavedData = string.Empty;
        // GET: Form
        public ActionResult Index()
        {
            return View();
        }

        // GET: Form/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Form/Create
        [HttpPost]
        public ActionResult Create(Estudent student)
        {
            try
            {
                // TODO: Add insert logic here
                SavedData = student.ToString();

                if (student.Save_Option == 1)
                {
                    logic.SetStrategy(new TXTSaving());
                }
                else if (student.Save_Option == 2)
                {
                    logic.SetStrategy(new EXCELsaving());
                }
                else if (student.Save_Option == 3)
                {
                    SavedData = JSONsaving.Serializar(student);
                    logic.SetStrategy(new JSONsaving());
                }

                logic.Ejecutar(SavedData);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
