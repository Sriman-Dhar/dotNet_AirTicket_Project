using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string email { get; set; }
        [ForeignKey("Admins")]
        public int AId { get; set; }
        public virtual Admin Admins { get; set; }

    }
}
