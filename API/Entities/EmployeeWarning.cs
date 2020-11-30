using System;

namespace API.Entities
{
    public class EmployeeWarning
    {
        public int Id { get; set; }
        public string ReasonForWarning { get; set; }
        public DateTimeOffset DateOfWarning { get; set; }
        public Employee Employee { get; set; }
    }
}