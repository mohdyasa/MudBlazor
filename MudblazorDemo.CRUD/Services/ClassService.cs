namespace MudblazorDemo.CRUD.Services;
public class ClassService : UnitOfWork<Class>, IClassService
{
    private readonly IUnitOfWork<Class> _unitOfWork;

    public ClassService(ApplicationDbContext databaseContext, IUnitOfWork<Class> unitOfWork) : base(databaseContext)
    {
        _unitOfWork = unitOfWork;
    }
    public async Task<IEnumerable<Class>> GetClasses()
    {
        return await _unitOfWork.Repository.GetAsync().ToListAsync();
    }
}

