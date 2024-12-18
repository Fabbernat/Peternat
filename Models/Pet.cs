﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetRegistryApp.Models;

public class Pet
{
    public Pet() { }

    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required.")]
    public string Name { get; set; }

    [Required]
    public string Gender { get; set; }

    [Required]
    [Range(0, int.MaxValue, ErrorMessage = "Age cannot be negative.")]
    public int Age { get; set; }

    [Required]
    [Range(0, double.MaxValue, ErrorMessage = "Weight cannot be negative.")]
    public double Weight { get; set; }

    [Required]
    [Url(ErrorMessage = "Please enter a valid URL for the photo.")]
    public string PhotoUrl { get; set; }

    [Required]
    [ForeignKey("Category")]
    public int CategoryId { get; set; }
    public virtual Category ReferencedCategory { get; set; }

}