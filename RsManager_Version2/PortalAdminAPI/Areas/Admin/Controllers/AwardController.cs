using PortalAdminAPI.AdminService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PortalAdminAPI.Areas.Admin.Controllers
{
    public class AwardController : ApiController
    {
        // GET: api/Award
        public IEnumerable<AwardDTO> Get()
        {
            try
            {
                PortalAdminServiceClient client = new PortalAdminServiceClient();
                var response = client.GetAllAwards();
                return response;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        //// GET: api/Award/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Award
        public string Post([FromBody]AwardDTO awrd)
        {
            PortalAdminServiceClient client = new PortalAdminServiceClient();
            var response = client.CreateNewAward(awrd);
            return response.Message;
        }

        // PUT: api/Award/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Award/5
        public void Delete(int id)
        {
        }
    }
}
