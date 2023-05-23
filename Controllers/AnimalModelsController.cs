using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistDist.Models;

namespace SistDist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalModelsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AnimalModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/AnimalModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnimalModel>>> GetAnimals()
        {
            if (_context.Animals == null)
            {
                return NotFound();
            }
            return await _context.Animals.ToListAsync();
        }

        // GET: api/AnimalModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AnimalModel>> GetAnimalModel(int id)
        {
            if (_context.Animals == null)
            {
                return NotFound();
            }
            var animalModel = await _context.Animals.FindAsync(id);

            if (animalModel == null)
            {
                return NotFound();
            }

            return animalModel;
        }

        // PUT: api/AnimalModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnimalModel(int id, AnimalModel animalModel)
        {
            if (id != animalModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(animalModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnimalModelExists(id))
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

        // POST: api/AnimalModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AnimalModel>> PostAnimalModel(AnimalModel animalModel)
        {
            if (_context.Animals == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Animals'  is null.");
            }
            _context.Animals.Add(animalModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAnimalModel", new { id = animalModel.Id }, animalModel);
        }

        // DELETE: api/AnimalModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnimalModel(int id)
        {
            if (_context.Animals == null)
            {
                return NotFound();
            }
            var animalModel = await _context.Animals.FindAsync(id);
            if (animalModel == null)
            {
                return NotFound();
            }

            _context.Animals.Remove(animalModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AnimalModelExists(int id)
        {
            return (_context.Animals?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
