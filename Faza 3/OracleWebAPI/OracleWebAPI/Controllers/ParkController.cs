using Microsoft.AspNetCore.Mvc;
using DatabaseAccess;
using DatabaseAccess.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ParkController : ControllerBase
{
    [HttpPost]
    [Route("DodajPark/{IdGR}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> AddPark([FromBody] ParkPregled park, int IdGR)
    {
        var data = await DataProvider.dodajPark(park, IdGR); //trebalo bi da ovako treba

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspešno dodat park");
    }


    [HttpGet("PreuzmiSveParkove")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public ActionResult vratiSveParkove()
    {
        var (isError, parkovi, error) = DataProvider.vratiSveParkove();

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(parkovi);
    }


    [HttpGet("PreuzmiPark/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> vratiPark(int id) //trebalo bi da ide IAction
    {
        var (isError, park, error) = await DataProvider.vratiPark(id);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(park);
    }


    [HttpDelete]
    [Route("IzbrisiPark/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> deletePark(int id)
    {
        var data = await DataProvider.obrisiPark(id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(204, $"Uspešno obrisan park.");
    }


}