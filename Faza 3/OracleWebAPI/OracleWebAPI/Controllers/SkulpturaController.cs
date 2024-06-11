using Microsoft.AspNetCore.Mvc;
using DatabaseAccess;
using DatabaseAccess.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class SkulpturaController : ControllerBase
{
    [HttpPost]
    [Route("DodajSkulpturu/{IdZastite}/{IdParka}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> AddSkulptura([FromBody] SkulpturaPregled r, int IdZastite, int IdParka)
    {
        var data = await DataProvider.dodajSkulpturu(r, IdZastite, IdParka); //trebalo bi da ovako treba

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspešno dodata zastita");
    }


    [HttpGet("PreuzmiSveSkulpture")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public ActionResult vratiSveSkulpture()
    {
        var (isError, skulpture, error) = DataProvider.vratiSveSkulpture();

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(skulpture);
    }


    [HttpGet("PreuzmiSkulpturu/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> vratiSkulpturu(int id) //trebalo bi da ide IAction
    {
        var (isError, skulptura, error) = await DataProvider.vratiSkulpturu(id);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(skulptura);
    }


    [HttpDelete]
    [Route("IzbrisiSkulpturu/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> deleteSkulptura(int id)
    {
        var data = await DataProvider.obrisiSkulpturu(id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(204, $"Uspešno obrisana skulptura.");
    }


}