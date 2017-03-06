using System.Web.Http;
using FirstCloudWebApi.Services;

namespace FirstCloudWebApi.Controllers
{
    public class TowersOfHanoiController : ApiController
    {
        private readonly TowersOfHanoi service = new TowersOfHanoi();

        [HttpGet]
        [Route("api/TowersOfHanoi/MoveDisks/{disksCount}")]
        public string MoveDisks(int disksCount)
        {
            return this.service.MoveDisks(disksCount);
        }
    }
}
