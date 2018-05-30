using System;

namespace DomainModel.DTO
{
    public class EmployeeMessage
    {
        public string MessageID { get; set; }
        public long EmployeeID { get; set; }
        public Nullable<bool> IsRead { get; set; }

        public Employee Employee { get; set; }
        public Message Message { get; set; }
    }
}
