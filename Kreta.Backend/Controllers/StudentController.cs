using Kreta.Backend.Controllers.Base;
using Kreta.Backend.Repos;
using Kreta.Shared.Assemblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models.SchoolCitizens;
using Microsoft.AspNetCore.Mvc;

namespace Kreta.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public partial class StudentController : BaseController<Student, StudentDto>
    {        
        private readonly IStudentRepo _studentRepo;
        public StudentController(StudentAssembler? assambler, IStudentRepo? repo) : base(assambler, repo) 
        {
            _studentRepo = repo ?? throw new ArgumentException(nameof(repo));
        }
        
        [HttpGet("NumberOfStudent")]
        public async Task<IActionResult> GetNumberOfStudentAsync()
        {
            //int numberOfStudent = await _studentRepo.GetNumberOfStudentAsync();
            return Ok(await _studentRepo.GetNumberOfStudentAsync());
        }
    }
}
