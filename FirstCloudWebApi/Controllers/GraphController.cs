using System.Web.Http;
using FirstCloudWebApi.Services;

namespace FirstCloudWebApi.Controllers
{
    [RoutePrefix("api/Graph")]
    public class GraphController : ApiController
    {
        private readonly BFS bfs = new BFS();
        private readonly DFS dfs = new DFS();
        private readonly Graph graph = Graph.Create();

        [HttpGet]
        [Route("traverse/bfs")]
        public string BfsTraverse()
        {
            return this.bfs.Traverse(this.graph);
        }

        [HttpGet]
        [Route("traverse/dfs")]
        public string DfsTraverse()
        {
            return this.dfs.Traverse(this.graph);
        }
    }
}
