using PortalAdminAPI.AdminService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PortalAdminAPI.Areas.Admin.Controllers
{
    public class ProgrammeController : ApiController
    {
        // GET: api/Programme
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Programme/5
        public IEnumerable<ProgrammeDTO> Get(int id)
        {
            PortalAdminServiceClient client = new PortalAdminServiceClient();
            var response = client.GetProgrammesInDepartment(id);
            return response;
        }

        // POST: api/Programme
        public string Post([FromBody]ProgrammeDTO programme)
        {
            PortalAdminServiceClient client = new PortalAdminServiceClient();
            var response = client.CreateNewProgramme(programme);
            return response.Message;
        }

        // PUT: api/Programme/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Programme/5
        public void Delete(int id)
        {
        }
    }
}
