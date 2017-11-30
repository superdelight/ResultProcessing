using PortalAdminAPI.AdminService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PortalAdminAPI.Areas.Admin.Controllers
{
    public class CentreController : ApiController
    {
        // GET: api/Centre
        public IEnumerable<CentreDTO> Get(int id)
        {
            PortalAdminServiceClient client = new PortalAdminServiceClient();
            var response = client.GetAllCentresinCity(id);
            return response;
        }

        // GET: api/Centre/5
        public CentreDTO Get(string id)
        {
            PortalAdminServiceClient client = new PortalAdminServiceClient();
            var response = client.GetCentre(id);
            return response;
        }

        // POST: api/Centre
        public string Post([FromBody]CentreDTO centre)
        {
            PortalAdminServiceClient client = new PortalAdminServiceClient();
            var response = client.CreateNewCentre(centre);
            return response.Message;
        }

        // PUT: api/Centre/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Centre/5
        public void Delete(int id)
        {
        }
    }
}
