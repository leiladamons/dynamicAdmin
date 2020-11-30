using System;

namespace API.Entities
{
    public class EmployeeContract
    {
        public int Id { get; set; }
        public DateTimeOffset ContractStartDate { get; set; }
        public DateTimeOffset ContractEndDate { get; set; }
        public int Salary { get; set; }
        public Employee Employee { get; set; }
    }
}