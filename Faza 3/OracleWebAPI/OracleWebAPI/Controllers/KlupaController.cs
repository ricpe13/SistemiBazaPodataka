using Microsoft.AspNetCore.Mvc;
using DatabaseAccess;
using DatabaseAccess.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class KlupaController : ControllerBase
{
    [HttpPost]
    [Route("DodajKlupu/{IdParka}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> AddKlupa([FromBody] KlupaPregled r, int IdParka)
    {
        var data = await DataProvider.dodajKlupu(r, IdParka); //trebalo bi da ovako treba

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspešno dodata klupa");
    }


    [HttpGet("PreuzmiSveParkove")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public ActionResult vratiSveKlupe()
    {
        var (isError, klupe, error) = DataProvider.vratiSveKlupe();

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(klupe);
    }


    [HttpGet("PreuzmiKlupu/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> vratiKlupu(int id) //trebalo bi da ide IAction
    {
        var (isError, klupa, error) = await DataProvider.vratiKlupu(id);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(klupa);
    }


    [HttpDelete]
    [Route("IzbrisiKlupu/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> deleteKlupa(int id)
    {
        var data = await DataProvider.obrisiKlupu(id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(204, $"Uspešno obrisana klupa.");
    }


}