using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DatabaseAccess;

namespace OracleWebAPIService.Controllers
{

    [ApiController]
    [Microsoft.AspNetCore.Components.Route("[controller]")]
    public class RadnikController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiRadnike")]

        public IActionResult GetRadnici()
        {
            try
            {
                return new JsonResult(DataProvider)
            }

            catch 
            {

            }
        }


    }
}
