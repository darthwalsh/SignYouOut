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
            Process.Start("cmd.exe", "/l"); //TODO shutdown.exe /l
            //TODO listen only on localhost interface, not external
            //TODO semaphore on process launch
            //TODO document how to set it up
        }
    }
}
