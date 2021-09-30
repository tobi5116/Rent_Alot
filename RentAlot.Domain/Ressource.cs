using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentAlot.Domain
{
    public class Ressource
    {
        [Key]
        public int RessourceId { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public string Name { get; set; }
        [ForeignKey("RessourceCategory")]
        public string CategoryType { get; set; }
        public RessourceCategory RessourceCategory { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public string Link { get; set; }
    }
}
