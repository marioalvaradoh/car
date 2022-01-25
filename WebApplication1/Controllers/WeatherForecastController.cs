using COMMON.Contracts;
using COMMON.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IBLContract bLContract;

        public WeatherForecastController(IBLContract bLContract)
        {
            this.bLContract = bLContract;
        }

        [HttpPost]
        public async Task<ActionResult<DTOResponse>> Create(DTORequest request)
        => await this.bLContract.Create(request);
    }
}
