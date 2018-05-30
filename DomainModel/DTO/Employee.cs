using System.Collections.Generic;

namespace DomainModel.DTO
{
    public partial class Employee
    {
        public Employee()
        {
            this.EmployeeMessages = new HashSet<EmployeeMessage>();
        }

        public long EmployeeID { get; set; }
        public string Name { get; set; }

        public ICollection<EmployeeMessage> EmployeeMessages { get; set; }
    }
}
