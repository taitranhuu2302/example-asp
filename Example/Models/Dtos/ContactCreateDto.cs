using System.ComponentModel.DataAnnotations;

namespace Example.Models.Dtos;

public record ContactCreateDto(
    [Required] string FullName,
    [Required,EmailAddress] string Email,
    [Required] string NumberPhone,
    [Required] string Country 
);