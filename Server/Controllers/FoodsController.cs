using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FSD_Project.Server.Data;
using FSD_Project.Shared.Domain;
using FSD_Project.Server.IRepository;

namespace FSD_Project.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public FoodsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Foods
        [HttpGet]
        public async Task<IActionResult> GetFoods()
        {
            var foods = await _unitOfWork.Foods.GetAll(includes: q => q.Include(x => x.FoodStore));
            return Ok(foods);
        }

        // GET: api/Foods/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFood(int id)
        {
            var food = await _unitOfWork.Foods.Get(q => q.Id == id);

            if (food == null)
            {
                return NotFound();
            }

            return Ok(food);
        }

        // PUT: api/Foods/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFood(int id, Food food)
        {
            if (id != food.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Foods.Update(food);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await FoodExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Foods
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Food>> PostFood(Food food)
        {
            await _unitOfWork.Foods.Insert(food);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetFood", new { id = food.Id }, food);
        }

        // DELETE: api/Foods/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFood(int id)
        {
            var food = await _unitOfWork.Foods.Get(q => q.Id == id);
            if (food == null)
            {
                return NotFound();
            }

            await _unitOfWork.Foods.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> FoodExists(int id)
        {
            var food = await _unitOfWork.Foods.Get(q => q.Id == id);
            return food != null;
        }
    }
}

