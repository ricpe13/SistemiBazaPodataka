using Microsoft.AspNetCore.Mvc;
using DatabaseAccess;
using DatabaseAccess.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class SvetiljkaController : ControllerBase
{
    [HttpPost]
    [Route("DodajSvetiljku")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> AddSvetiljka([FromBody] SvetiljkaPregled r, int IdParka)
    {
        var data = await DataProvider.dodajSvetiljku(r, IdParka); //trebalo bi da ovako treba

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspešno dodata svetiljka");
    }


    [HttpGet("PreuzmiSveSvetiljke")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public ActionResult vratiSveSvetiljke()
    {
        var (isError, svetiljke, error) = DataProvider.vratiSveSvetiljke();

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(svetiljke);
    }


    [HttpPut]
    [Route("PromeniSvetiljku")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> changeSvetiljka([FromBody] SvetiljkaPregled p)
    {
        (bool isError, var svetiljka, ErrorMessage? error) = await DataProvider.azurirajSvetiljku(p);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        if (svetiljka == null)
        {
            return BadRequest("Svetiljka nije validna.");
        }

        return Ok($"Uspešno ažurirana svetiljka.");

    }

    [HttpDelete]
    [Route("IzbrisiSvetiljku/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> deleteSvetiljku(int id)
    {
        var data = await DataProvider.obrisiSvetiljku(id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(204, $"Uspešno obrisana svetiljka.");
    }


}