using Microsoft.AspNetCore.Mvc;
using DatabaseAccess;
using DatabaseAccess.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class DecijeIgralisteController : ControllerBase
{
    [HttpPost]
    [Route("DodajDecijeIgraliste")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> AddDecijeIgraliste([FromBody] DecijeIgralistePregled r)
    {
        var data = await DataProvider.dodajDecijeIgraliste(r); //trebalo bi da ovako treba

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspešno dodato decije igraliste");
    }


    [HttpGet("PreuzmiSvaDecijaIgralista")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public ActionResult vratiSvaDecijaIgralista()
    {
        var (isError, decijaigralista, error) = DataProvider.vratiSvaDecijaIgralista();

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(decijaigralista);
    }


    [HttpPut]
    [Route("PromeniDecijeIgraliste")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> changeDecijeIgraliste([FromBody] DecijeIgralistePregled p)
    {
        (bool isError, var decijeigraliste, ErrorMessage? error) = await DataProvider.azurirajDecijeIgraliste(p);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        if (decijeigraliste == null)
        {
            return BadRequest("Decije igraliste nije validno.");
        }

        return Ok($"Uspesno azurirano decije igraliste.");

    }

    [HttpDelete]
    [Route("IzbrisiDecijeIgraliste/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> deleteDecijeIgraliste(int id)
    {
        var data = await DataProvider.obrisiDecijeIgraliste(id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(204, $"Uspesno obrisano decije igraliste.");
    }


}