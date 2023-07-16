using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS_GROUP.Models
{
    public class Admin
    {
        [Key]
        public int AId { get; set; }
        public string AdminName { get; set; }

        public string AdminPassword { get; set; }
    }
}
