﻿using Microsoft.AspNetCore.Mvc;
using DatabaseAccess;
using DatabaseAccess.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class SpomenikController : ControllerBase
{
    [HttpPost]
    [Route("DodajSpomenik/{IdZastite}/{IdParka}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> AddSpomenik([FromBody] SpomenikPregled r, int IdZastite, int IdParka)
    {
        var data = await DataProvider.dodajSpomenik(r, IdZastite, IdParka); //trebalo bi da ovako treba

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspešno dodat spomenik");
    }


    [HttpGet("PreuzmiSveSpomenike")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public ActionResult vratiSveSkulpture()
    {
        var (isError, spomenici, error) = DataProvider.vratiSveSpomenike();

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(spomenici);
    }


    [HttpGet("PreuzmiSpomenik/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> vratiSpomenik(int id) //trebalo bi da ide IAction
    {
        var (isError, spomenik, error) = await DataProvider.vratiSpomenik(id);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(spomenik);
    }


    [HttpDelete]
    [Route("IzbrisiSpomenik/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> deleteSpomenik(int id)
    {
        var data = await DataProvider.obrisiSpomenik(id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(204, $"Uspešno obrisan spomenik.");
    }


}