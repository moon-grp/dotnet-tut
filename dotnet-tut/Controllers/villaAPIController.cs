using dotnet_tut.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_tut.Controllers
{
    [Route("api/v1/villapi")]
    [ApiController]
    public class villaAPIController: ControllerBase
    {
        [HttpGet]
        public IEnumerable<Villa> GetVillas()
        {
            return new List<Villa>
            {
                new Villa{Id=1, Name="olumide villa one"},
                new Villa{Id=2, Name="new villa two"}
            };
        }
    }
}
