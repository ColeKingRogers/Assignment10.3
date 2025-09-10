using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Assignment10._3.Models
{
    //master table
    public class Manufacturer
    {
        [Key]
        public int ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }
        public virtual ObservableCollectionListSource<Cars> Cars { get; set; } // Navigation property
    }
}
