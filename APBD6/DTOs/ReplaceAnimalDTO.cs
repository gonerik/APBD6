namespace APBD6.DTOs;
using System.ComponentModel.DataAnnotations;



public record ReplaceAnimalRequest(
    [Required] [MaxLength(50)] string Name,
    [Required] [MaxLength(50)] string Description, 
    [Required] [MaxLength(10)] string Category, 
    [Required] [MaxLength(50)] string Area
);