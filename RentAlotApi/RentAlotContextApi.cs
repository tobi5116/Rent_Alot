using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using RentAlot.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAlotApi
{
    public class RentAlotContextApi : DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public RentAlotContextApi(DbContextOptions<RentAlotContextApi> options, IHttpContextAccessor httpContextAccessor) : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Ressource> Ressources { get; set; }
        public DbSet<RessourceCategory> RessourceCategories { get; set; }
    }
}
