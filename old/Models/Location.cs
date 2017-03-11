using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace WebApplication.Models {
    public class Location {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }
        public string Notes { get; set; }
        public ICollection<Need> Needs { get; set; }
        public ICollection<Occupant> Occupants { get; set; }
    }
}