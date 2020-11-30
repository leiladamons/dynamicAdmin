namespace API.Entities
{
    public class EmployeeContractDocument
    {
        public int Id { get; set; }
        public string DocumentName { get; set; }
        public string FileToken { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public EmployeeContract EmployeeContract { get; set; }
    }
}