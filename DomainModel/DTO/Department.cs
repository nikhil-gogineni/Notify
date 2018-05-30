using System.Collections.Generic;

namespace DomainModel.DTO
{
    public partial class Department
    {
        public Department()
        {
            this.Messages = new HashSet<Message>();
        }
    
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public string LabelColor { get; set; }
        public string Initial { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
    }
}
