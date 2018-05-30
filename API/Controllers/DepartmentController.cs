using Repository;
using System;
using System.Net;
using System.Net.Http;

namespace API.Controllers
{
    public class DepartmentController : BaseController
    {
        DepartmentRepo _repo;
        public DepartmentController()
        {
            _repo = new DepartmentRepo();
        }

        public HttpResponseMessage GetDepartments()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.GetDepartments());
            }
            catch (Exception ex)
            {
                return SetErrorResponse(ex.Message);
            }
        }
    }
}
