using System.Web.Http;
using FirstCloudWebApi.Services;
using Swashbuckle.Swagger.Annotations;

namespace FirstCloudWebApi.Controllers
{
    [RoutePrefix("api/StringPermutation")]
    public class StringPermutationController : ApiController
    {
        private readonly StringPermutationService service = new StringPermutationService();

        //[HttpGet]
        [Route("{source}/{checking}")]
        public bool Get(string source, string checking)
        {
            return service.IsPermutation(source, checking);
        }
    }
}
