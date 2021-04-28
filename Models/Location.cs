using System;
using System.ComponentModel.DataAnnotations;

namespace P12Location.Models
{
  public class Location
  {
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Range(0, 1000, ErrorMessage = "Lat must be 0 - to 1000")]
    public double Latitude { get; set; }

    [Range(0, 1000)]
    public double Longitude { get; set; }

    public bool Active { get; set; }
  }
}