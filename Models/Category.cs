namespace PetRegistryApp.Models;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Category
{

    [Key]
    public int CategoryId { get; set; }

    [Required(ErrorMessage = "Category name is required.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "At least write a few words about this category...")]
    [StringLength(250)]
    public string Description { get; set; }

    public ICollection<Pet> Pets { get; set; } = new List<Pet>();
}