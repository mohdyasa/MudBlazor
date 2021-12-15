using MudblazorDemo.CRUD.Dto;

namespace MudblazorDemo.CRUD.Services;
public interface IAnalyticsService
{
    Task<List<ClassStatics>> GetClassData();
    Task<List<CountryStatics>> GetCountryData();
    Task<double> GetAverageAge();
}

