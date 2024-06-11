using Microsoft.AspNetCore.Mvc;
using DatabaseAccess;
using DatabaseAccess.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class RadnikController : ControllerBase
{
    [HttpPost]
    [Route("DodajRadnika/{IdZP}/{IdGR}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> AddRadnik([FromBody] RadnikPregled r, int IdZP, int IdGR = 0)
    {
        var data = await DataProvider.dodajRadnika( r, IdZP, IdGR = 0); //trebalo bi da ovako treba

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspešno dodat radnik");
    }


    [HttpGet("PreuzmiSveRadnike")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public ActionResult vratiSveRadnike()
    {
        var (isError, radnici, error) = DataProvider.vratiSveRadnike();

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(radnici);
    }


    [HttpGet("PreuzmiRadnika/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> vratiRadnika(int id) //trebalo bi da ide IAction
    {
        var (isError, radnik, error) = await DataProvider.vratiRadnika(id);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(radnik);
    }


    [HttpPut]
    [Route("PromeniRadnika")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> changeRadnik([FromBody] RadnikPregled p)
    {
        (bool isError, var radnik, ErrorMessage? error) = await DataProvider.azurirajRadnika(p);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        if (radnik == null)
        {
            return BadRequest("Radnik nije validan.");
        }

        return Ok($"Uspešno ažuriran radnik.");

    }

    [HttpDelete]
    [Route("IzbrisiRadnika/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> deleteRadnika(int id)
    {
        var data = await DataProvider.obrisiRadnika(id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(204, $"Uspešno obrisan radnik.");
    }


}