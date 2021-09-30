using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentAlot.Domain.Interfaces
{
    public interface IRessourceRepo
    {
        Task<IEnumerable<Ressource>> GetAllRessourcesAsync();
        Task<Ressource> GetRessourceByIdAsync(int id);
        Task<Ressource> CreateRessourceAsync(Ressource ressource);
    }
}
