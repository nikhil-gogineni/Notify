using Repository;
using System;
using System.Net;
using System.Net.Http;

namespace API.Controllers
{
    public class MessageController : BaseController
    {
        MessageRepo _repo;
        public MessageController()
        {
            _repo = new MessageRepo();
        }

        public HttpResponseMessage GetMessages(long empID)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.GetMessages(empID));
            }
            catch (Exception ex)
            {
                return SetErrorResponse(ex.Message);
            }
        }
    }
}
