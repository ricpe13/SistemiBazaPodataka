using Microsoft.AspNetCore.Mvc;
using DatabaseAccess;
using DatabaseAccess.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class DrvoController : ControllerBase
{
    [HttpPost]
    [Route("DodajDrvo/{IdParka}/{IdZastite}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> AddDrvo([FromBody] DrvoPregled r, int IdParka, int IdZastite = 0)
    {
        var data = await DataProvider.dodajDrvo(r, IdParka, IdZastite); //trebalo bi da ovako treba

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspešno dodato drvo");
    }


    [HttpGet("PreuzmiSvaDrveca")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public ActionResult vratiSvaDrveca()
    {
        var (isError, drvece, error) = DataProvider.vratiSvaDrveca();

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(drvece);
    }

    [HttpGet("PreuzmiDrvo/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> vratiDrvo(int id) //trebalo bi da ide IAction
    {
        var (isError, drvo, error) = await DataProvider.vratiDrvo(id);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(drvo);
    }

    [HttpPut]
    [Route("PromeniDrvo")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> changeDrvo([FromBody] DrvoPregled p)
    {
        (bool isError, var drvo, ErrorMessage? error) = await DataProvider.azurirajDrvo(p);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        if (drvo == null)
        {
            return BadRequest("Drvo nije validno.");
        }

        return Ok($"Uspesno azurirano drvo.");

    }

    [HttpDelete]
    [Route("IzbrisiDrvo/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> deleteDrvo(int id)
    {
        var data = await DataProvider.obrisiDrvo(id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(204, $"Uspesno obrisano drvo.");
    }


}