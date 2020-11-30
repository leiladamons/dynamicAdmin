using System;

namespace API.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmployeeNumber { get; set; }
        public string IdNumber { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public string EmployeeContact { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactPersonNumber { get; set; }
    }
}