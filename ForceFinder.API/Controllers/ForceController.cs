using ForceFinder.Logic;
using ForceFinder.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForceFinder.API.Controllers
{
    public class ForceController : Controller
    {

        private readonly IGetForceService _getForce;
        public  ForceController(IGetForceService getForce)
    {
        _getForce = getForce;
    }


        [HttpGet]
        public IActionResult AverageForce(ForceViewModel model)
        {
            double result = _getForce.AverageForce(model);
            return Ok(result);
        }
    }
}
