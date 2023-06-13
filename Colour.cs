using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Model
{
    public class Colour
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
        public List<Bike> Bike { get; set; }
    }
}
