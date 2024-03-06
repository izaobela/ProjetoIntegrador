using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoIntegrador.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AmortizationController : ControllerBase
    {
        private readonly ILogger<AmortizationController> _logger;

        public AmortizationController(ILogger<AmortizationController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> GetAmortization()
        {
            _logger.LogInformation("Log de teste");
            List<string> retorno = new();
            retorno.Add("lista teste 1");
            retorno.Add("lista teste 2");

            return retorno;
        }
    }
}
