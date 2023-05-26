using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistDist.Context;
using SistDist.Models;
using SistDist.Models.CreationModel;

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
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<AnimalModel>>> GetAnimals()
        //{
        //    if (_context.Animals == null)
        //    {
        //        return NotFound();
        //    }
        //    return await _context.Animals.ToListAsync();
        //}
        [HttpGet] //ver todos os dados no DB
        public async Task<ActionResult<IEnumerable<AnimalCreationModel>>> GetAnimals()
        {
            var animals = await _context.Animals.ToListAsync();

            if (animals == null)
            {
                return NotFound();
            }

            var animalCreationModels = animals.Select(animal => new AnimalCreationModel
            {
                data_cadastro = animal.data_cadastro,
                nome = animal.nome,
                especie = animal.especie,
                raca = animal.raca,
                sexo = animal.sexo,
                cor = animal.cor,
                data_nascimento = animal.data_nascimento,
                peso = animal.peso,
                alergia = animal.alergia,
                tutor_id = animal.tutor_id
            });

            return animalCreationModels.ToList();
        }


        // GET: api/AnimalModels/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<AnimalModel>> GetAnimalModel(int id)
        //{
        //    if (_context.Animals == null)
        //    {
        //        return NotFound();
        //    }
        //    var animalModel = await _context.Animals.FindAsync(id);

        //    if (animalModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return animalModel;
        //}
        [HttpGet("{id}")] //ver dados no DB relacionado ao ID solicitado
        public async Task<ActionResult<AnimalCreationModel>> GetAnimalModel(int id)
        {
            var animalModel = await _context.Animals.FindAsync(id);

            if (animalModel == null)
            {
                return NotFound();
            }

            var animalCreationModel = new AnimalCreationModel
            {
                data_cadastro = animalModel.data_cadastro,
                nome = animalModel.nome,
                especie = animalModel.especie,
                raca = animalModel.raca,
                sexo = animalModel.sexo,
                cor = animalModel.cor,
                data_nascimento = animalModel.data_nascimento,
                peso = animalModel.peso,
                alergia = animalModel.alergia,
                tutor_id = animalModel.tutor_id
            };

            return animalCreationModel;
        }


        // PUT: api/AnimalModels/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutAnimalModel(int id, AnimalModel animalModel)
        //{
        //    if (id != animalModel.id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(animalModel).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!AnimalModelExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}
        [HttpPut("{id}")] //atualizar dados no DB relacionado ao ID solicitado
        public async Task<IActionResult> PutAnimalModel(int id, AnimalCreationModel animalCreationModel)
        {
            var animalModel = await _context.Animals.FindAsync(id);

            if (animalModel == null)
            {
                return NotFound();
            }

            animalModel.data_cadastro = animalCreationModel.data_cadastro;
            animalModel.nome = animalCreationModel.nome;
            animalModel.especie = animalCreationModel.especie;
            animalModel.raca = animalCreationModel.raca;
            animalModel.sexo = animalCreationModel.sexo;
            animalModel.cor = animalCreationModel.cor;
            animalModel.data_nascimento = animalCreationModel.data_nascimento;
            animalModel.peso = animalCreationModel.peso;
            animalModel.alergia = animalCreationModel.alergia;
            animalModel.tutor_id = animalCreationModel.tutor_id;

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
        [HttpPost] //inserir dados no DB
        public async Task<ActionResult<AnimalModel>> PostAnimalModel(AnimalCreationModel creationModel)
        {
            if (_context.Animals == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Animals'  is null.");
            }

            var entryModel = new AnimalModel
            {
                data_cadastro = creationModel.data_cadastro,
                nome = creationModel.nome,
                especie = creationModel.especie,
                raca = creationModel.raca,
                sexo = creationModel.sexo,
                cor = creationModel.cor,
                data_nascimento = creationModel.data_nascimento,
                peso = creationModel.peso,
                alergia = creationModel.alergia,
                tutor_id = creationModel.tutor_id,
            };
            _context.Animals.Add(entryModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAnimalModel", new { entryModel.id }, entryModel);
        }

        // DELETE: api/AnimalModels/5
        [HttpDelete("{id}")] //deletar dados no DB relacionado ao ID solicitado
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
            return (_context.Animals?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}