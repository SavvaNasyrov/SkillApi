using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using SkillApi.Models;

namespace SkillApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ApplesController : ControllerBase
    {
        private AppDbContext db;
        public ApplesController(AppDbContext dbContext) 
        {
            db = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await db.Apples.ToArrayAsync());
        }
        [HttpPost]
        public async Task<IActionResult> SetApple([FromBody] Apple apple)
        {
            await db.Apples.AddAsync(apple);
            await db.SaveChangesAsync();
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetFilteredApplesAsync(Dictionary<string, string> pairs) 
        {
            if (pairs == null || pairs.Count() == 0) return Ok(db.Apples.ToArrayAsync());

            var apples = db.Apples.AsEnumerable();

            if (pairs.ContainsKey("type"))
            {
                apples = apples.Where(apple => apple.Type.ToString() == pairs["type"]);
            }
        }
    }
}
