using Microsoft.AspNetCore.Mvc;
using DatabaseAccess;
using DatabaseAccess.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class DrvoredController : ControllerBase
{
    [HttpPost]
    [Route("DodajDrvored")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> AddDrvored([FromBody] DrvoredPregled r)
    {
        var data = await DataProvider.dodajDrvored(r); //trebalo bi da ovako treba

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspešno dodat drvored");
    }


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


    [HttpGet("PreuzmiDrvored/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> vratiDrvored(int id) //trebalo bi da ide IAction
    {
        var (isError, drvored, error) = await DataProvider.vratiDrvored(id);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(drvored);
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