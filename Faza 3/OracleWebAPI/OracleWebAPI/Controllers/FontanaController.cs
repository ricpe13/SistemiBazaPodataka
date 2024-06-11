using Microsoft.AspNetCore.Mvc;
using DatabaseAccess;
using DatabaseAccess.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FontanaController : ControllerBase
{
    [HttpPost]
    [Route("DodajFontanu/{IdParka}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> AddFontana([FromBody] FontanaPregled r, int IdParka)
    {
        var data = await DataProvider.dodajFontanu(r, IdParka); //trebalo bi da ovako treba

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspešno dodata fontana");
    }


    [HttpGet("PreuzmiSveFontane")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public ActionResult vratiSveFontane()
    {
        var (isError, fontane, error) = DataProvider.vratiSveFontane();

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(fontane);
    }


    [HttpPut]
    [Route("PromeniFontanu")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> changeFontana([FromBody] FontanaPregled p)
    {
        (bool isError, var fontana, ErrorMessage? error) = await DataProvider.azurirajFontanu(p);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        if (fontana == null)
        {
            return BadRequest("Fontana nije validna.");
        }

        return Ok($"Uspesno azurirana fontana.");

    }

    [HttpDelete]
    [Route("IzbrisiFontanu/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> deleteFontana(int id)
    {
        var data = await DataProvider.obrisiFontanu(id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(204, $"Uspesno obrisana fontana.");
    }


}