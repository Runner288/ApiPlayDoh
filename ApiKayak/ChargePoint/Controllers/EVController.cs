using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChargePoint.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ChargePoint.Services;
using ChargePoint.Models;

namespace ChargePoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EVController : ControllerBase
    {
        private readonly IDataService _dataService;
        public EVController(IDataService dataService)
        {
            _dataService = dataService;
        }


        // GET: api/EV
        [HttpGet]
        public IActionResult Get()
        {
            var records = _dataService.Get();
            if(records != null)
            {
                if (records.Count > 0)
                {
                    return Ok(records);
                }
            }
            return NotFound();

        }

        // GET: api/EV/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var data = _dataService.GetById(id);
            if(data != null)
            {
                return Ok(data);
            }
            return NotFound();
        }

        // POST: api/EV
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/EV/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
