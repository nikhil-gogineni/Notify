using DataModel;
using System.Collections.Generic;
using System.Linq;
using DM = DomainModel.DTO;

namespace Repository
{
    public class DepartmentRepo
    {
        public List<DM.Department> GetDepartments()
        {
            using (NotifyEntities db = new NotifyEntities())
            {
                return db.tblDepartments
                     .OrderBy(m => m.Name)
                     .Select((n) => new DM.Department
                     {
                         DepartmentID = n.tblDepartmentID,
                         Name = n.Name,
                         Initial = n.Initial,
                         LabelColor = n.LabelColor
                     }).ToList();
            }
        }
    }
}