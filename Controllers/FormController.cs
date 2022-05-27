using BankMillenniumTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankMillenniumTask.Controllers
{
    public class FormController : Controller
    {
        public FormController()
        {

        }

        // GET: FormController/Details/5
        public ActionResult Details(FormDto model)
        {
            return View(model);
        }

        // GET: FormController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FormController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FormDto model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("Details", "Form", model);
        }
    }
}
