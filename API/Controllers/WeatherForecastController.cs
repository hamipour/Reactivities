using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistance;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly DataContext _context;
        public WeatherForecastController(DataContext context)
        {
            _context = context;

        }
       [HttpGet]
       public async Task<ActionResult<IEnumerable<Domain.Weather>>> Get(){
           var weathers = await _context.Weathers.ToListAsync();
           return Ok(weathers);
       }

       [HttpGet("{id}")]
       public async Task<ActionResult<Domain.Weather>> Get(int id){
           var weather = await _context.Weathers.FindAsync(id);
           return Ok(weather);
       }
    }
}
