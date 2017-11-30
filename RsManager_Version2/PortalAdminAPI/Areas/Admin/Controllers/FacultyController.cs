using PortalAdminAPI.AdminService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PortalAdminAPI.Areas.Admin.Controllers
{
    public class FacultyController : ApiController
    {
        // GET: api/Faculty
        public IEnumerable<FacultyDTO> Get()
        {
            try
            {
                PortalAdminServiceClient client = new PortalAdminServiceClient();
                var response = client.GetAllFaculties();
                return response;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
        // POST: api/Faculty
        public string Post([FromBody]FacultyDTO faculty)
        {
            PortalAdminServiceClient client = new PortalAdminServiceClient();
            var response=client.CreateFaculty(faculty);
            return response.Message;
        }
        // PUT: api/Faculty/5
        public void Put(int id, [FromBody]string value)
        {
        }
        // DELETE: api/Faculty/5
        public void Delete(int id)
        {
        }
    }
}
