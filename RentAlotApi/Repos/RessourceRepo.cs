using Microsoft.EntityFrameworkCore;
using RentAlot.Domain;
using RentAlot.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAlotApi.Repos
{
    public class RessourceRepo : IRessourceRepo
    {
        private readonly RentAlotContextApi _rentAlotContextApi; //Laver instans af min EF Context
        public RessourceRepo(RentAlotContextApi rentalDbContext) //Dependency injection af min EF Context
        {
            _rentAlotContextApi = rentalDbContext;
        }
        public async Task<Ressource> CreateRessourceAsync(Ressource ressource)
        {
            _rentAlotContextApi.Ressources.Add(ressource);
            await _rentAlotContextApi.SaveChangesAsync();
            return ressource;
        }

       

        public async Task<IEnumerable<Ressource>> GetAllRessourcesAsync()
        {
            return _rentAlotContextApi.Ressources.AsEnumerable();
        }

        public async Task<Ressource> GetRessourceByIdAsync(int id)
        {
            return await _rentAlotContextApi.Ressources.FirstOrDefaultAsync(ressource => ressource.RessourceId == id);
        }

        

        Task<Ressource> IRessourceRepo.GetRessourceByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
