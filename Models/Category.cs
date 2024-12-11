namespace PetRegistryApp.Models;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Category
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Category name is required.")]
    public string Name { get; set; }

    [StringLength(250)]
    public string Description { get; set; }

    public ICollection<Pet> Pets { get; set; } = new List<Pet>();
}