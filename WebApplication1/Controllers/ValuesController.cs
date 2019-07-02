using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.DTO;
using WebApplication1.Entities;
using WebApplication1.Services.Abstract;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IContactService _contactService; 
        public ValuesController(IContactService contactService, ILogger<ValuesController> logger)
        {
            _contactService = contactService ?? throw new ArgumentNullException(nameof(contactService)); 
        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<ContactDto>> Get()
        {
            var dto = await _contactService.GetContactDto();

            return dto;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
