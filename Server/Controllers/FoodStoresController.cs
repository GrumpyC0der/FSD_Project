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
    public class FoodStoresController : ControllerBase
    {
     private readonly IUnitOfWork _unitOfWork;

        public FoodStoresController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/FoodStores
        [HttpGet]
        public async Task<IActionResult> GetFoodStores()
        {
            var foodstores = await _unitOfWork.FoodStores.GetAll();
            return Ok(foodstores);
        }

        // GET: api/FoodStores/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFoodStore(int id)
        {
            var foodstore = await _unitOfWork.FoodStores.Get(q => q.Id == id);

            if (foodstore == null)
            {
                return NotFound();
            }

            return Ok(foodstore);
        }

        // PUT: api/foodstores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFoodStore(int id, FoodStore foodstore)
        {
            if (id != foodstore.Id)
            {
                return BadRequest();
            }

            _unitOfWork.FoodStores.Update(foodstore);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await FoodStoreExists(id))
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

        // POST: api/FoodStores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FoodStore>> PostFoodStore(FoodStore foodstore)
        {
            await _unitOfWork.FoodStores.Insert(foodstore);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetFoodStore", new { id = foodstore.Id }, foodstore);
        }

        // DELETE: api/FoodStores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFoodStore(int id)
        {
            var foodstore = await _unitOfWork.FoodStores.Get(q => q.Id == id);
            if (foodstore == null)
            {
                return NotFound();
            }

            await _unitOfWork.FoodStores.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> FoodStoreExists(int id)
        {
            var foodstore = await _unitOfWork.FoodStores.Get(q => q.Id == id);
            return foodstore != null;
        }
    }
}

