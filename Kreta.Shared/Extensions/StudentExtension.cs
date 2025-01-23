using Kreta.Shared.Dtos;
using Kreta.Shared.Models.SchoolCitizens;

namespace Kreta.Shared.Extensions
{
    public static class StudentExtension
    {
        public static StudentDto ToStudentDto(this Student student)
        {
            return new StudentDto
            {
                Id= student.Id,
                FirstName = student.FirstName,
                LastName = student.LastName,
                BirthsDay = student.BirthsDay,
                SchoolYear = student.SchoolYear,
                SchoolClass = student.SchoolClass,
                EducationLevel = student.EducationLevel
            };
        }

        public static Student ToStudent(this Dtos.StudentDto studentdto) 
        {
            return new Student
            {
                Id = studentdto.Id,
                FirstName = studentdto.FirstName,
                LastName = studentdto.LastName,
                BirthsDay = studentdto.BirthsDay,
                SchoolYear = studentdto.SchoolYear,
                SchoolClass = studentdto.SchoolClass,
                EducationLevel = studentdto.EducationLevel
            };
        }
    }

}
