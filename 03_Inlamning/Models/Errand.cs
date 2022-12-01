using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace _03_Inlamning.Models
{
    public class Errand
    {
      
        [Required]
        [StringLength(20)]
        public string ErrandName { get; set; } = null!;
        
        [Required]
        public int ErrandId { get; set; }

        [Required]
        [StringLength(200)]
        public string ErrandDescription { get; set; } = null!;

        [Required]
        public int CreateErrandDate { get; set; } 

        [Required]
        public int ChangeErrandDate { get; set; }

        [Required]
        [StringLength(20)]
        public string ErrandStatus { get; set; } = null!;






    }
}
