namespace MudblazorDemo.CRUD.Services;
public interface ICountryService : IUnitOfWork<Country>
{
    Task<IEnumerable<Country>> GetCountryData();

}

