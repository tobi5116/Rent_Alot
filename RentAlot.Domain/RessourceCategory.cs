using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentAlot.Domain
{
    public class RessourceCategory
    {
        [Key]
        public string Categorytype { get; set; }
    }
}
