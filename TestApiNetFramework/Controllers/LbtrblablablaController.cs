using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using TestApiNetFramework.Models;

namespace TestApiNetFramework.Controllers
{
    public class LbtrblablablaController : ApiController
    {

        [Route("corelbtr/api/v1/bcorec/inter/validar")]
        [HttpPost]
        public  async Task<IHttpActionResult> ValidarBody([FromBody] LbtrFIToFICstmrCdtTrfInitnClass httpBody)
        {
            return this.Ok(await validar(httpBody));
        }

        private Task<LbtrFIToFICstmrCdtTrfInitnClass> validar(LbtrFIToFICstmrCdtTrfInitnClass lbtr)
        {
            return Task.FromResult(lbtr);
        }
    }
}
