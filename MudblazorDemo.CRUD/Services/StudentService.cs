using MudblazorDemo.CRUD.Dto;

namespace MudblazorDemo.CRUD.Services;
public class StudentService : UnitOfWork<Student>, IStudentService
{
    private readonly IUnitOfWork<Student> _unitOfWork;

    public StudentService(ApplicationDbContext databaseContext, IUnitOfWork<Student> unitOfWork) : base(databaseContext)
    {
        _unitOfWork = unitOfWork;
    }

    public async void DeleteStudent(int id)
    {
        var studentDetails = _unitOfWork.Repository.GetAsync().FirstOrDefault(x => x.Id == id);

        if (studentDetails is not null)
        {
            _unitOfWork.Repository.Delete(studentDetails);
            _unitOfWork.Repository.Update(studentDetails);
            await _unitOfWork.SaveAsync();
        }
    }


    public async Task<StudentDto> GetStudentById(int id)
    {
       return await _unitOfWork.Repository.GetAsync(x => x.Id == id, includeProperties: "Class,Country").Select(x=> new StudentDto(x.Name,x.ClassId, x.Id, x.CountryId, x.DateOfBirth)).FirstOrDefaultAsync();
    }

    public async Task<List<Student>> GetStudents()
    {
        return await _unitOfWork.Repository.GetAsync().ToListAsync();
    }

    public async void SaveStudent(Student student)
    {
        if (student.Id == 0) await _unitOfWork.Repository.InsertAsync(student);

        else _unitOfWork.Repository.Update(student);

        await _unitOfWork.SaveAsync();
    }
}

