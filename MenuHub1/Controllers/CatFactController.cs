using MenuHub1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MenuHub1.Controllers
{
    public class CatFactController : Controller
    {
        // GET: CatFact
        public async Task<IActionResult> Index()
        {
            string url = "https://meowfacts.herokuapp.com";
            using HttpClient client = new HttpClient();
            Catfact catFact = null;

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                catFact = JsonConvert.DeserializeObject<Catfact>(result);
            }

            return View(catFact);
        }

        // GET: CatFact/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CatFact/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CatFact/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CatFact/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CatFact/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CatFact/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CatFact/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
