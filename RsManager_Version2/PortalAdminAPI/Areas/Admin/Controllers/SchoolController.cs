using PortalAdminAPI.AdminService;
using PortalAdminAPI.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PortalAdminAPI.Areas.Admin.Controllers
{
    public class SchoolController : ApiController
    {
        // GET: api/School
      
        // GET: api/School/5
        public SchoolDTO Get()
        {
            PortalAdminServiceClient client = new AdminService.PortalAdminServiceClient();
            return client.GetDefaultSchool();
        }

        // POST: api/School
        public string Post([FromBody]SchoolDTO school)
        {
            try
            {
                PortalAdminServiceClient client = new AdminService.PortalAdminServiceClient();
                var response=client.CreateSchool(school);
                return response.Message;
            }
            catch
            {
                return "NIL";
            }
        }

        // PUT: api/School/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/School/5
        public void Delete(int id)
        {
        }
    }
}
