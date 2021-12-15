using System;
using System.ComponentModel.DataAnnotations;

namespace MudblazorDemo.CRUD.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public int CountryId { get; set; }
        [Required]
        public int ClassId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public virtual Country Country { get; set; }
        public virtual Class Class { get; set; }
    }
}
