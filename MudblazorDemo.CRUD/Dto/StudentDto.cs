using System.ComponentModel.DataAnnotations;

namespace MudblazorDemo.CRUD.Dto;
    public record StudentDto([Required]string Name, [Required] int ClassId, [Required] int StudentId, [Required] int CountryId, [Required] DateTime DateOfBirth);
public record ClassStatics(string Name, int Value);
public record CountryStatics(string Name, int Value);
