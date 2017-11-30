using PortalAdminAPI.AdminService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PortalAdminAPI.Areas.Admin.Controllers
{
    public class DepartmentController : ApiController
    {
        // GET: api/Department
        public IEnumerable<DepartmentDTO> Get(int facId)
        {
            PortalAdminServiceClient client = new PortalAdminServiceClient();
            var response = client.GetAllDepartmentsinFAC(facId);
            return response;
        }

        public IEnumerable<DepartmentDTO> Get()
        {
            PortalAdminServiceClient client = new PortalAdminServiceClient();
            var response = client.GetAllDepartments();
            return response;
        }

        // POST: api/Department
        public string Post([FromBody]DepartmentDTO dept)
        {
            PortalAdminServiceClient client = new PortalAdminServiceClient();
            var response = client.CreateDepartment(dept);
            return response.Message;
        }

        // PUT: api/Department/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Department/5
        public void Delete(int id)
        {
        }
    }
}
