namespace MudblazorDemo.CRUD.Services;
public interface IClassService : IUnitOfWork<Class>
{
    Task<IEnumerable<Class>> GetClasses();

}

