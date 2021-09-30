using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentAlot.Domain;
using RentAlot.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Net.Http.Formatting;

namespace RentAlot.Controllers
{
    public class RessourceController : Controller
    {
        //private readonly IRessourceRepo _ressources;
        static HttpClient client = new HttpClient();
       

        // GET: RessourcesController
        public async Task<IActionResult> Index()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44336/api/");
                HttpResponseMessage response = await client.GetAsync("RessourceControllerApi");
                if (response.IsSuccessStatusCode)
                {
                    IEnumerable<Ressource> ressource = await response.Content.ReadAsAsync<IEnumerable<Ressource>>();
                    return View(ressource);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Something went wrong server side. Contact Admin");
                    return View();
                }
            }
        }

        // GET: RessourcesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RessourcesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RessourcesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RessourceId,DepartmentId,Name,Link,Type,Location,Price")] Ressource ressource)
        //public ActionResult Create(IFormCollection collection)
        {

            //return await _ressources.CreateRessourceAsync(ressource);


            try
            {

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RessourcesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RessourcesController/Edit/5
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

        // GET: RessourcesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RessourcesController/Delete/5
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

