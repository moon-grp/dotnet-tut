using dotnet_tut.Models.Dto;

namespace dotnet_tut.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
        {

                new VillaDTO{Id=1, Name="olumide villa one"},
                new VillaDTO{Id=2, Name="new villa two"}
        };
    }
}
