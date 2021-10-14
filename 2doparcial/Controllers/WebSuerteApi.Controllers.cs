using _2doparcial.data;
using _2doparcial.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2doparcial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebSuerteApi : ControllerBase
    {
        private readonly AppDbContext _context;

        public WebSuerteApi(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<Suerte>> GetNaipe()
        {

            var list = await _context.Suerte.ToListAsync();

            var max = list.Count;
            int index = new Random().Next(0, max);

            var Suerte = list[index];

            if (Suerte == null)
            {
                return NoContent();
            }

            return Suerte;
        }
    }
}
    

