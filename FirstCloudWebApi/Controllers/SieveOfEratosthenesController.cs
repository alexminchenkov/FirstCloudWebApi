using System.Collections.Generic;
using System.Web.Http;
using FirstCloudWebApi.Services;

namespace FirstCloudWebApi.Controllers
{
    [RoutePrefix("api/SieveOfEratosthenes")]
    public class SieveOfEratosthenesController : ApiController
    {
        private readonly SieveOfEratosthenes service = new SieveOfEratosthenes();

        [HttpGet]
        [Route("{maxValue}")]
        public IEnumerable<int> Compute(int maxValue)
        {
            return service.ComputeFor(maxValue);
        }
    }
}