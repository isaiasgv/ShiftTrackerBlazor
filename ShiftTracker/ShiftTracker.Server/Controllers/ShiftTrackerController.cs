using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShiftTracker.Shared.Models;

namespace ShiftTracker.Server.Controllers
{
    [Route("api/shifthistory")]
    [ApiController]
    public class ShiftTrackerController : ControllerBase
    {
        // GET: api/ShiftTracker/shifthistory
        
        [HttpGet]
        public List<Shift> Get()
        {
            var shifts = new List<Shift>();
            for (int i =0 ;i<10;i++ )
            {
                shifts.Add(new Shift { Name = "NativoPlus", TotalHours = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss")});
               
            }
            return shifts;
        }

        
    }
}
