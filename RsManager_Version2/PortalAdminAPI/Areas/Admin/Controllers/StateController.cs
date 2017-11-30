using PortalAdminAPI.AdminService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PortalAdminAPI.Areas.Admin.Controllers
{
    public class StateController : ApiController
    {
        // GET: api/State
        public IEnumerable<StateDTO> Get()
        {
            PortalAdminServiceClient client = new PortalAdminServiceClient();
            var response = client.GetAllStates();
            return response;
        }
        public IEnumerable<StateDTO> Get(int id)
        {
            PortalAdminServiceClient client = new PortalAdminServiceClient();
            var response = client.GetAllStates();
            return response;
        }
        // GET: api/State/5
        public StateDTO Get(string id)
        {
            PortalAdminServiceClient client = new PortalAdminServiceClient();
            var response = client.GetState(id);
            return response;
        }

        // POST: api/State
        public string Post([FromBody]StateDTO state)
        {
            PortalAdminServiceClient client = new PortalAdminServiceClient();
            var response = client.CreateNewState(state);
            return response.Message;
        }

        // PUT: api/State/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/State/5
        public void Delete(int id)
        {
        }
    }
}
