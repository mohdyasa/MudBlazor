using MudblazorDemo.CRUD.Dto;
using MudblazorDemo.CRUD.Models;
using System.Collections.Generic;

namespace MudblazorDemo.CRUD.Services
{
    public interface IStudentService : IUnitOfWork<Student>
    {
        Task<List<Student>> GetStudents();
        Task<StudentDto> GetStudentById(int id);
        void SaveStudent(Student Student);
        void DeleteStudent(int id);
    }
}
