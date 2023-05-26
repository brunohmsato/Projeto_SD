using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistDist.Context;
using SistDist.Models;
using SistDist.Models.CreationModel;

namespace SistDist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeterinarioModelsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public VeterinarioModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/VeterinarioModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VeterinarioCreationModel>>> GetVeterinarios()
        {
            var veterinarios = await _context.Veterinarios.ToListAsync();

            if (veterinarios == null)
            {
                return NotFound();
            }

            var veterinarioCreationModels = veterinarios.Select(veterinario => new VeterinarioCreationModel
            {
                data_contratacao = veterinario.data_contratacao,
                data_demissao = veterinario.data_demissao,
                ctps_numero = veterinario.ctps_numero,
                ctps_serie = veterinario.ctps_serie,
                ctps_estado = veterinario.ctps_estado,
                pis_pasesp = veterinario.pis_pasesp,
                salario = veterinario.salario,
                crmv_numero = veterinario.crmv_numero,
                crmv_estado = veterinario.crmv_estado,
                pessoa_id = veterinario.pessoa_id
            });

            return veterinarioCreationModels.ToList();
        }

        // GET: api/VeterinarioModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VeterinarioCreationModel>> GetVeterinarioModel(int id)
        {
            var veterinarioModel = await _context.Veterinarios.FindAsync(id);

            if (veterinarioModel == null)
            {
                return NotFound();
            }

            var veterinarioCreationModel = new VeterinarioCreationModel
            {
                data_contratacao = veterinarioModel.data_contratacao,
                data_demissao = veterinarioModel.data_demissao,
                ctps_numero = veterinarioModel.ctps_numero,
                ctps_serie = veterinarioModel.ctps_serie,
                ctps_estado = veterinarioModel.ctps_estado,
                pis_pasesp = veterinarioModel.pis_pasesp,
                salario = veterinarioModel.salario,
                crmv_numero = veterinarioModel.crmv_numero,
                crmv_estado = veterinarioModel.crmv_estado,
                pessoa_id = veterinarioModel.pessoa_id
            };

            return veterinarioCreationModel;
        }

        // PUT: api/VeterinarioModels/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVeterinarioModel(int id, VeterinarioCreationModel veterinarioCreationModel)
        {
            var veterinarioModel = await _context.Veterinarios.FindAsync(id);

            if (veterinarioModel == null)
            {
                return NotFound();
            }

            veterinarioModel.data_contratacao = veterinarioCreationModel.data_contratacao;
            veterinarioModel.data_demissao = veterinarioCreationModel.data_demissao;
            veterinarioModel.ctps_numero = veterinarioCreationModel.ctps_numero;
            veterinarioModel.ctps_serie = veterinarioCreationModel.ctps_serie;
            veterinarioModel.ctps_estado = veterinarioCreationModel.ctps_estado;
            veterinarioModel.pis_pasesp = veterinarioCreationModel.pis_pasesp;
            veterinarioModel.salario = veterinarioCreationModel.salario;
            veterinarioModel.crmv_numero = veterinarioCreationModel.crmv_numero;
            veterinarioModel.crmv_estado = veterinarioCreationModel.crmv_estado;
            veterinarioModel.pessoa_id = veterinarioCreationModel.pessoa_id;

            _context.Entry(veterinarioModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VeterinarioModelExists(id))
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

        // POST: api/VeterinarioModels
        [HttpPost]
        public async Task<ActionResult<VeterinarioModel>> PostVeterinarioModel(VeterinarioCreationModel creationModel)
        {
            if (_context.Veterinarios == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Veterinarios'  is null.");
            }

            var entryModel = new VeterinarioModel
            {
                data_contratacao = creationModel.data_contratacao,
                data_demissao = creationModel.data_demissao,
                ctps_numero = creationModel.ctps_numero,
                ctps_serie = creationModel.ctps_serie,
                ctps_estado = creationModel.ctps_estado,
                pis_pasesp = creationModel.pis_pasesp,
                salario = creationModel.salario,
                crmv_numero = creationModel.crmv_numero,
                crmv_estado = creationModel.crmv_estado,
                pessoa_id = creationModel.pessoa_id
            };
            _context.Veterinarios.Add(entryModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVeterinarioModel", new { entryModel.id }, entryModel);
        }

        // DELETE: api/VeterinarioModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVeterinarioModel(int id)
        {
            if (_context.Veterinarios == null)
            {
                return NotFound();
            }
            var veterinarioModel = await _context.Veterinarios.FindAsync(id);
            if (veterinarioModel == null)
            {
                return NotFound();
            }

            _context.Veterinarios.Remove(veterinarioModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VeterinarioModelExists(int id)
        {
            return (_context.Veterinarios?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
