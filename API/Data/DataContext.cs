using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeContract> EmployeeContracts { get; set; }
        public DbSet<EmployeeContractDocument> EmployeeContractDocuments { get; set; }
        public DbSet<EmployeeWarning> EmployeeWarnings { get; set; }
        public DbSet<EmployeeWarningDocument> EmployeeWarningDocuments { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<TimeAndAttendance> TimeAndAttendances { get; set; }
        public DbSet<User> Users { get; set; }
    }
}