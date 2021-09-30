using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentAlot.Domain
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string City { get; set; }
        public int PostCode { get; set; }
    }
}
