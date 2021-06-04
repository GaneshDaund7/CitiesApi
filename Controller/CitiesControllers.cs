using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First.Api.Controller
{

    [ApiController]
    public class CitiesControllers:ControllerBase
    {
        [HttpGet("api/cities")]
        public JsonResult GetCities()
        {
            return new JsonResult(CityDataStore.Current.cities);
        }
        [HttpGet("api/cities/{id}")]
        public IActionResult GetCity(int id)
        {
            var CityToReturn= CityDataStore.Current.cities.FirstOrDefault(c => c.Id==id);

            if(CityToReturn==null)
            {
               return NotFound();
            }
            return Ok(CityToReturn);
        }
    }
}
