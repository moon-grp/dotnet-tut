using dotnet_tut.Data;
using dotnet_tut.Models;
using dotnet_tut.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_tut.Controllers
{
    [Route("api/v1/villapi")]
    [ApiController]
    public class villaAPIController: ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return VillaStore.villaList;
        }

        [HttpGet("id")]
        public VillaDTO GetVilla(int id)
        {
            return VillaStore.villaList.FirstOrDefault(u => u.Id == id);
        }
    }
}
