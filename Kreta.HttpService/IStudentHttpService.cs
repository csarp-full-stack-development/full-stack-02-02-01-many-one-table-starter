using Kreta.HttpService.Base;
using Kreta.Shared.Models.SchoolCitizens;

namespace Kreta.HttpService
{
    public interface IStudentHttpService : IBaseHttpService<Student>
    {
        Task<int> GetNumberOfStudentAsync();
    }
}
