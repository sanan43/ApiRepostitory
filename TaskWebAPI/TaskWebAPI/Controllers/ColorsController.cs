using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using TaskWebAPI.DAL.EFCore;
using TaskWebAPI.Entities.Dtos.Brands;
using TaskWebAPI.Entities;
using TaskWebAPI.Entities.Dtos.Colors;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;

namespace TaskWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ColorsController(AppDbContext context, IMapper mapper = null)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _context.Colors.ToListAsync();
            if (result == null)
            {
                return NotFound();
            }
            return StatusCode((int)HttpStatusCode.OK, result);
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _context.Colors.Where(b => b.Id == id).FirstOrDefaultAsync();
            if (result == null)
            {
                return NotFound();
            }
            return StatusCode((int)HttpStatusCode.OK, result);
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CreateColorDto ColorDto)
        {
            //Color color = new Color()
            //{
            //    Name = ColorDto.Name,
            //};
            Color color = _mapper.Map<Color>(ColorDto);
            await _context.Colors.AddAsync(color);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, UpdateColorDto updateColorDto)
        {

            var result = await _context.Colors.FindAsync(id);
            if (result == null) { return NotFound(); }
            result.Name = updateColorDto.Name;
            result.Id = updateColorDto.Id;


            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _context.Colors.FindAsync(id);
            if (result == null) return BadRequest(new
            {
                StatusCode = 201,
                Message = "Tapilmadi"
            });
            _context.Colors.Remove(result);
            await _context.SaveChangesAsync();
            return Ok();

        }
    }
}
