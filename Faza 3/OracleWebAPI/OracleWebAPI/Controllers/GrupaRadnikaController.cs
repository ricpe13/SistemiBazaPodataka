using Microsoft.AspNetCore.Mvc;
using DatabaseAccess;
using DatabaseAccess.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class GrupaRadnikaController : ControllerBase
{
    [HttpPost]
    [Route("DodajGrupuRadnika")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> AddGrupaRadnika([FromBody] GrupaRadnikaPregled grupaRadnika, int IdParka, int IdSefa)
    {
        var data = await DataProvider.dodajGrupuRadnika(grupaRadnika, IdParka, IdSefa); //trebalo bi da ovako treba

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspešno dodata grupa radnika");
    }


    [HttpGet("PreuzmiSveGrupeRadnike")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public ActionResult vratiSveGrupeRadnika()
    {
        var (isError, gruperadnika, error) = DataProvider.vratiSveGrupe();

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(gruperadnika);
    }


    [HttpPut]
    [Route("PromeniGrupuRadnika")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> changeGrupuRadnika([FromBody] GrupaRadnikaPregled p)
    {
        (bool isError, var gruparadnika, ErrorMessage? error) = await DataProvider.azurirajGrupuRadnika(p);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        if (gruparadnika == null)
        {
            return BadRequest("Grupa radnika nije validna.");
        }

        return Ok($"Uspesno azurirana grupa radnika.");

    }

    [HttpDelete]
    [Route("IzbrisiGrupuRadnika/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> deleteGrupuRadnika(int id)
    {
        var data = await DataProvider.obrisiGrupuRadnika(id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(204, $"Uspesno obrisana grupa radnika.");
    }


}