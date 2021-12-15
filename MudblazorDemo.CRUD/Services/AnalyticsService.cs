using MudblazorDemo.CRUD.Dto;

namespace MudblazorDemo.CRUD.Services
{
    public class AnalyticsService : IAnalyticsService
    {
        private readonly ApplicationDbContext context;

        public AnalyticsService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<double> GetAverageAge()
        {
           return  await context.Students.AverageAsync(x => (DateTime.Now - x.DateOfBirth).TotalDays);
        }

        public async Task<List<ClassStatics>> GetClassData()
        {
            return await context.Students.GroupBy(x => x.Class).Select(x => new ClassStatics(x.Key.Name, x.Count())).ToListAsync();
        }

        public async Task<List<CountryStatics>> GetCountryData()
        {
            return await context.Students.GroupBy(x => x.Country).Select(x => new CountryStatics(x.Key.Name, x.Count())).ToListAsync();
        }
    }
}
