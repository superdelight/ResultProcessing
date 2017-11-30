using PortalAdminAPI.AdminService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PortalAdminAPI.Areas.Admin.Controllers
{
    public class CityController : ApiController
    {
        // GET: api/City
        public IEnumerable<CityDTO> Get(int id)
        {
            PortalAdminServiceClient client = new PortalAdminServiceClient();
            var response = client.GetAllCities(id);
            return response;
        }

        // GET: api/City/5
        public CityDTO Get(string id)
        {
            PortalAdminServiceClient client = new PortalAdminServiceClient();
            var response = client.GetCity(id);
            return response;
        }

        // POST: api/City
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/City/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/City/5
        public void Delete(int id)
        {
        }
    }
}
