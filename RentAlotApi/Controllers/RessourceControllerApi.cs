using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentAlot.Domain;
using RentAlot.Domain.Interfaces;
using RentAlotApi.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAlotApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RessourceControllerApi : Controller
    {
        private readonly IRessourceRepo _IressourceRepo;
        
        public RessourceControllerApi(IRessourceRepo iRessourceRepo) 
        {
            _IressourceRepo = iRessourceRepo;
        }

        // GET: RessourceControllerApi
        [HttpGet]
        public async Task<IEnumerable<Ressource>> Index()
        {
            //IEnumerable<Ressource> ressources = _ressourceRepo.GetAllRessourcesAsync();
            return await _IressourceRepo.GetAllRessourcesAsync();
            //View();
        }

        // GET: RessourceControllerApi/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RessourceControllerApi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RessourceControllerApi/Create
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

        // GET: RessourceControllerApi/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RessourceControllerApi/Edit/5
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

        // GET: RessourceControllerApi/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RessourceControllerApi/Delete/5
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
