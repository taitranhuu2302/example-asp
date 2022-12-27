using System.ComponentModel.DataAnnotations;

namespace Example.Models.Dtos;

public record ContactUpdateDto(
    string? FullName,
    [EmailAddress]string? Email,
    string? NumberPhone,
    string? Country
);