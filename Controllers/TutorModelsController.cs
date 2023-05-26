using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistDist.Context;
using SistDist.Models;
using SistDist.Models.CreationModel;

namespace SistDist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TutorModelsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TutorModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TutorModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TutorCreationModel>>> GetTutores()
        {
            var tutores = await _context.Tutores.ToListAsync();

            if (tutores == null)
            {
                return NotFound();
            }

            var tutorCreationModels = tutores.Select(tutor => new TutorCreationModel
            {
                notificacao_email = tutor.notificacao_email,
                notificacao_whats = tutor.notificacao_whats,
                pessoa_id = tutor.pessoa_id,
            });

            return tutorCreationModels.ToList();
        }

        // GET: api/TutorModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TutorCreationModel>> GetTutorModel(int id)
        {
            var tutorModel = await _context.Tutores.FindAsync(id);

            if (tutorModel == null)
            {
                return NotFound();
            }

            var tutorCreationModel = new TutorCreationModel
            {
                notificacao_email = tutorModel.notificacao_email,
                notificacao_whats = tutorModel.notificacao_whats,
                pessoa_id = tutorModel.pessoa_id,
            };

            return tutorCreationModel;
        }

        // PUT: api/TutorModels/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTutorModel(int id, TutorCreationModel tutorCreationModel)
        {
            var tutorModel = await _context.Tutores.FindAsync(id);

            if (tutorModel == null)
            {
                return NotFound();
            }

            tutorModel.notificacao_email = tutorCreationModel.notificacao_email;
            tutorModel.notificacao_whats = tutorCreationModel.notificacao_whats;
            tutorModel.pessoa_id = tutorCreationModel.pessoa_id;

            _context.Entry(tutorModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TutorModelExists(id))
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

        // POST: api/TutorModels
        [HttpPost]
        public async Task<ActionResult<TutorModel>> PostTutorModel(TutorCreationModel creationModel)
        {
            if (_context.Tutores == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Tutores'  is null.");
            }

            var entryModel = new TutorModel
            {
                notificacao_email = creationModel.notificacao_email,
                notificacao_whats = creationModel.notificacao_whats,
                pessoa_id = creationModel.pessoa_id,
            };
            _context.Tutores.Add(entryModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTutorModel", new { entryModel.id }, entryModel);
        }

        // DELETE: api/TutorModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTutorModel(int id)
        {
            if (_context.Tutores == null)
            {
                return NotFound();
            }
            var tutorModel = await _context.Tutores.FindAsync(id);
            if (tutorModel == null)
            {
                return NotFound();
            }

            _context.Tutores.Remove(tutorModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TutorModelExists(int id)
        {
            return (_context.Tutores?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
