﻿using Kreta.Shared.Enums;

namespace Kreta.Shared.Models.SchoolCitizens
{
    public class Student : IDbEntity<Student>
    {
        public Student(Guid id, string firstName, string lastName, DateTime birthsDay, int schoolYear, SchoolClassType schoolClass, string educationLevel)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthsDay = birthsDay;
            SchoolYear = schoolYear;
            SchoolClass = schoolClass;
            EducationLevel = educationLevel;
        }

        public Student(string firstName, string lastName, DateTime birthsDay, int schoolYear, SchoolClassType schoolClass, string educationLevel)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            BirthsDay = birthsDay;
            SchoolYear = schoolYear;
            SchoolClass = schoolClass;
            EducationLevel = educationLevel;
        }

        public Student()
        {
            Id = Guid.NewGuid();
            FirstName = string.Empty;
            LastName = string.Empty;
            BirthsDay = new DateTime();
            SchoolYear = 9;
            SchoolClass = SchoolClassType.ClassA;
            EducationLevel = string.Empty;
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthsDay { get; set; }
        public int SchoolYear { get; set; }
        public SchoolClassType SchoolClass { get; set; }
        public string EducationLevel { get; set; }
        public bool HasId => Id != Guid.Empty;
        public bool IsWoman { get; set; }
        public bool IsMan => !IsWoman;

        public override string ToString()
        {
            return $"{Id} {LastName} {FirstName} ({SchoolYear}.{SchoolClass}) - ({string.Format("{0:yyyy.MM.dd.}", BirthsDay)}) ({EducationLevel})";
        }
    }
}
