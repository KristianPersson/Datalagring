using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace _01_Inlamning.Models
{
    [Index(nameof(Email), IsUnique = true)]
    internal class Customer
    {
     
        
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string LastName { get; set; } = null!;

        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string StreetName { get; set; } = null!;

        [Required]
        [StringLength(5)]
        public int StreetNumber { get; set; }

        [Required]
        [StringLength(6)]
        public int PostalCode { get; set; }

        [Required]
        [StringLength(20)]
        public string City { get; set; } = null!;

        [Required]
        [StringLength(10)]
        public int PhoneNumber { get; set; }

    }
}
