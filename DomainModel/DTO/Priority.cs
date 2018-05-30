using System.Collections.Generic;

namespace DomainModel.DTO
{
    public partial class Priority
    {
        public Priority()
        {
            this.Messages = new HashSet<Message>();
        }

        public int PriorityID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
    }
}
