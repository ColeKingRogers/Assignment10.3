using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment10._3.Models
{
    public class Cars
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // To prevent auto-generation
        public double Price { get; set; }
        public string Vin { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int ManufacturerId { get; set; } // Foreign key
        public virtual Manufacturer manufacturer { get; set; } // Navigation property
    }
}
