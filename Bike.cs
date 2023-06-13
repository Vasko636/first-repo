using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Text;

namespace Data.Model
{
    public class Bike
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Model { get; set; }
        public ICollection<Colour> Colours { get; set; }

        [ForeignKey(nameof(Color))]
        public int ColorId { get; set; }
        [ForeignKey(nameof(Brand))]
        public int BrandId { get; set; }
        [ForeignKey(nameof(Tyres))]
        public int TyreId { get; set; }
        public Brand Brand { get; set; }
        public Color Color { get; set; }
        public Tyres Tyres { get; set; }


    }
}
