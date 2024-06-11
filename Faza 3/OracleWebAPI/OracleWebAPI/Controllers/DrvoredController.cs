using Microsoft.AspNetCore.Mvc;
using DatabaseAccess;
using DatabaseAccess.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class DrvoredController : ControllerBase
{
    [HttpGet("PreuzmiSveDrvorede")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public ActionResult vratiSveDrvorede()
    {
        var (isError, drvoredi, error) = DataProvider.vratiSveDrvorede();

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(drvoredi);
    }


    [HttpPut]
    [Route("PromeniDrvored")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> changeDrvored([FromBody] DrvoredPregled p)
    {
        (bool isError, var drvored, ErrorMessage? error) = await DataProvider.azurirajDrvored(p);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        if (drvored == null)
        {
            return BadRequest("Drvored nije validna.");
        }

        return Ok($"Uspesno azuriran drvored.");

    }

    [HttpDelete]
    [Route("IzbrisiDrvored/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> deleteDrvored(int id)
    {
        var data = await DataProvider.obrisiDrvored(id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(204, $"Uspesno obrisan drvored.");
    }


}