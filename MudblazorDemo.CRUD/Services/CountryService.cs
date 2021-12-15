namespace MudblazorDemo.CRUD.Services;
public class CountryService : UnitOfWork<Country>, ICountryService
{
    private readonly IUnitOfWork<Country> _unitOfWork;

    public CountryService(ApplicationDbContext databaseContext, IUnitOfWork<Country> unitOfWork) : base(databaseContext)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Country>> GetCountryData()
    {
        return await _unitOfWork.Repository.GetAsync().ToListAsync();
    }
}

