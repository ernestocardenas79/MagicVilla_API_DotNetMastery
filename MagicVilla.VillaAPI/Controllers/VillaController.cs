using MagicVilla.VillaAPI.Data;
using MagicVilla.VillaAPI.Models;
using MagicVilla.VillaAPI.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla.VillaAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class VillaController : ControllerBase
{
    [HttpGet]
    public IEnumerable<VillaDTO> GetVillas()
    {
        return VillaStore.VillaList();
    }

    [HttpGet("{id:int}")]
    public IEnumerable<VillaDTO> GetVilla(int id)
    {
        return VillaStore.VillaList().FirstOrDefault(v=> v.Id == id);
    }
}
