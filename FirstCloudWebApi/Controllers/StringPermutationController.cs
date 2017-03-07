using System.Web.Http;
using FirstCloudWebApi.Services;
using Swashbuckle.Swagger.Annotations;

namespace FirstCloudWebApi.Controllers
{
    [RoutePrefix("api/StringPermutations")]
    public class StringPermutationController : ApiController
    {
        private readonly StringPermutation2 service = new StringPermutation2();

        [HttpGet]
        [Route("{source}")]
        public string Get(string source)
        {
            return service.GetPermutations(source);
        }
    }
}
