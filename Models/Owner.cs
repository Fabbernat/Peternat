using System.ComponentModel.DataAnnotations;

namespace PetRegistryApp.Models
{
    public class Owner
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "The Name field must be between 10 and 100 characters long.")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^\+3630-\d{3}-\d{4}$", ErrorMessage = "The Phone Number field must match the format +3630-123-4567.")]
        public string PhoneNumber { get; set; }

        [Required]
        public LivingEnvironment LivingEnvironment { get; set; }

        [Required(ErrorMessage = "Choose one!")]
        [Display(Name = "Experienced Pet Owner")]
        public bool IsExperiencedPetOwner { get; set; }

        
    }

    public enum LivingEnvironment
    {
        Downtown,
        Suburbs,
        Farm
    }
}