using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistDist.Context;
using SistDist.Models;
using SistDist.Models.CreationModel;

namespace SistDist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaModelsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ConsultaModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ConsultaModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConsultaCreationModel>>> GetConsultas()
        {
            var consultas = await _context.Consultas.ToListAsync();

            if (consultas == null)
            {
                return NotFound();
            }

            var consultaCreationModels = consultas.Select(consulta => new ConsultaCreationModel
            {
                data_cadastro = consulta.data_cadastro,
                data_consulta = consulta.data_consulta,
                horario_consulta = consulta.horario_consulta,
                valor_consulta = consulta.valor_consulta,
                diagnostico = consulta.diagnostico,
                animal_id = consulta.animal_id,
                veterinario_id = consulta.veterinario_id,
            });

            return consultaCreationModels.ToList();
        }

        // GET: api/ConsultaModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ConsultaCreationModel>> GetConsultaModel(int id)
        {
            var consultaModel = await _context.Consultas.FindAsync(id);

            if (consultaModel == null)
            {
                return NotFound();
            }

            var consultaCreationModel = new ConsultaCreationModel
            {
                data_cadastro = consultaModel.data_cadastro,
                data_consulta = consultaModel.data_consulta,
                horario_consulta = consultaModel.horario_consulta,
                valor_consulta = consultaModel.valor_consulta,
                diagnostico = consultaModel.diagnostico,
                animal_id = consultaModel.animal_id,
                veterinario_id = consultaModel.veterinario_id,
            };

            return consultaCreationModel;
        }

        // PUT: api/ConsultaModels/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsultaModel(int id, ConsultaCreationModel consultaCreationModel)
        {
            var consultaModel = await _context.Consultas.FindAsync(id);

            if (consultaModel == null)
            {
                return NotFound();
            }

            consultaModel.data_cadastro = consultaCreationModel.data_cadastro;
            consultaModel.data_consulta = consultaCreationModel.data_consulta;
            consultaModel.horario_consulta = consultaCreationModel.horario_consulta;
            consultaModel.valor_consulta = consultaCreationModel.valor_consulta;
            consultaModel.diagnostico = consultaCreationModel.diagnostico;
            consultaModel.animal_id = consultaCreationModel.animal_id;
            consultaModel.veterinario_id = consultaCreationModel.veterinario_id;

            _context.Entry(consultaModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConsultaModelExists(id))
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

        // POST: api/ConsultaModels
        [HttpPost]
        public async Task<ActionResult<ConsultaModel>> PostConsultaModel(ConsultaCreationModel creationModel)
        {
            if (_context.Consultas == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Consultas'  is null.");
            }

            var entryModel = new ConsultaModel
            {
                data_cadastro = creationModel.data_cadastro,
                data_consulta = creationModel.data_consulta,
                horario_consulta = creationModel.horario_consulta,
                valor_consulta = creationModel.valor_consulta,
                diagnostico = creationModel.diagnostico,
                animal_id = creationModel.animal_id,
                veterinario_id = creationModel.veterinario_id,
            };
            _context.Consultas.Add(entryModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCOnsultaModel", new { entryModel.id }, entryModel);
        }

        // DELETE: api/ConsultaModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConsultaModel(int id)
        {
            if (_context.Consultas == null)
            {
                return NotFound();
            }
            var consultaModel = await _context.Consultas.FindAsync(id);
            if (consultaModel == null)
            {
                return NotFound();
            }

            _context.Consultas.Remove(consultaModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ConsultaModelExists(int id)
        {
            return (_context.Consultas?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
