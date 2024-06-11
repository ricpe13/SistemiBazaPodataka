using Microsoft.AspNetCore.Mvc;
using DatabaseAccess;
using DatabaseAccess.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TravnjakController : ControllerBase
{
    [HttpPost]
    [Route("DodajTravnjak")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> AddTravnjak([FromBody] TravnjakPregled t)
    {
        var data = await DataProvider.dodajTravnjak(t); //trebalo bi da ovako treba

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspešno dodat travnjak");
    }


    [HttpGet("PreuzmiSveTravnjake")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public ActionResult vratiSveTravnjake()
    {
        var (isError, travnjaci, error) = DataProvider.vratiSveTravnjake();

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(travnjaci);
    }


    [HttpGet("PreuzmiTravnjak/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> vratiTravnjak(int id) //trebalo bi da ide IAction
    {
        var (isError, travnjak, error) = await DataProvider.vratiTravnjak(id);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(travnjak);
    }


    [HttpDelete]
    [Route("IzbrisiTravnjak/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> deleteTravnjak(int id)
    {
        var data = await DataProvider.obrisiTravnjak(id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(204, $"Uspešno obrisan travnjak.");
    }


}