using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SignYouOut.Controllers
{
    [Route("")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpPost]
        public void Post()
        {
            Process.Start("shutdown.exe", "/l"); // logoff
        }
    }
}
