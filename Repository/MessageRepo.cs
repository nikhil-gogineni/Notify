using DataModel;
using System.Collections.Generic;
using System.Linq;
using DM = DomainModel.DTO;

namespace Repository
{
    public class MessageRepo
    {
        public List<DM.Message> GetMessages(long empID)
        {
            using (NotifyEntities db = new NotifyEntities())
            {
                return db.tblMessages
                    .Where(m => m.IsActive)
                    .OrderByDescending((m) => m.tblMessageID)
                     .Select((m) => new DM.Message
                     {
                         MessageID = m.tblMessageID,
                         Description = m.Description,
                         CreatedAt = m.CreatedAt,
                         ModifiedAt = m.ModifiedAt,
                         Subject = m.Subject,
                         Department = new DM.Department
                         {
                             DepartmentID = m.tblDepartment.tblDepartmentID,
                             Initial = m.tblDepartment.Initial,
                             LabelColor = m.tblDepartment.LabelColor,
                             Name = m.tblDepartment.Name
                         },
                       //  IsRead = m.tblEmployeeMessages.Where(n => n.tblEmployeeID == empID).FirstOrDefault().IsRead,
                         Priority = new DM.Priority
                         {
                             Color = m.tblPriority.Color,
                             Name = m.tblPriority.Name,
                             PriorityID = m.tblPriority.tblPriorityID
                         },
                     }).ToList();
            }
        }
    }
}