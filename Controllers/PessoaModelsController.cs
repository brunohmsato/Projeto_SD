using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistDist.Context;
using SistDist.Models;
using SistDist.Models.CreationModel;

namespace SistDist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaModelsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PessoaModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/PessoaModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PessoaCreationModel>>> GetPessoas()
        {
            var pessoas = await _context.Pessoas.ToListAsync();

            if (pessoas == null)
            {
                return NotFound();
            }

            var pessoaCreationModels = pessoas.Select(pessoa => new PessoaCreationModel
            {
                data_cadastro = pessoa.data_cadastro,
                nome = pessoa.nome,
                data_nascimento = pessoa.data_nascimento,
                email = pessoa.email,
                cpf = pessoa.cpf,
                telefone = pessoa.telefone,
                logradouro = pessoa.logradouro,
                numero = pessoa.numero,
                complemento = pessoa.complemento,
                bairro = pessoa.bairro,
                cidade = pessoa.cidade,
                uf = pessoa.uf,
                cep = pessoa.cep
            });

            return pessoaCreationModels.ToList();
        }

        // GET: api/PessoaModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PessoaCreationModel>> GetPessoaModel(int id)
        {
            var pessoaModel = await _context.Pessoas.FindAsync(id);

            if (pessoaModel == null)
            {
                return NotFound();
            }

            var pessoaCreationModel = new PessoaCreationModel
            {
                data_cadastro = pessoaModel.data_cadastro,
                nome = pessoaModel.nome,
                data_nascimento = pessoaModel.data_nascimento,
                email = pessoaModel.email,
                cpf = pessoaModel.cpf,
                telefone = pessoaModel.telefone,
                logradouro = pessoaModel.logradouro,
                numero = pessoaModel.numero,
                complemento = pessoaModel.complemento,
                bairro = pessoaModel.bairro,
                cidade = pessoaModel.cidade,
                uf = pessoaModel.uf,
                cep = pessoaModel.cep
            };

            return pessoaCreationModel;
        }

        // PUT: api/PessoaModels/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPessoaModel(int id, PessoaCreationModel pessoaCreationModel)
        {
            var pessoaModel = await _context.Pessoas.FindAsync(id);

            if (pessoaModel == null)
            {
                return NotFound();
            }

            pessoaModel.data_cadastro = pessoaCreationModel.data_cadastro;
            pessoaModel.nome = pessoaCreationModel.nome;
            pessoaModel.data_nascimento = pessoaCreationModel.data_nascimento;
            pessoaModel.email = pessoaCreationModel.email;
            pessoaModel.cpf = pessoaCreationModel.cpf;
            pessoaModel.telefone = pessoaCreationModel.telefone;
            pessoaModel.logradouro = pessoaCreationModel.logradouro;
            pessoaModel.numero = pessoaCreationModel.numero;
            pessoaModel.complemento = pessoaCreationModel.complemento;
            pessoaModel.bairro = pessoaCreationModel.bairro;
            pessoaModel.cidade = pessoaCreationModel.cidade;
            pessoaModel.uf = pessoaCreationModel.uf;
            pessoaModel.cep = pessoaCreationModel.cep;

            _context.Entry(pessoaModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PessoaModelExists(id))
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

        // POST: api/PessoaModels
        [HttpPost]
        public async Task<ActionResult<PessoaModel>> PostPessoaModel(PessoaCreationModel creationModel)
        {
            if (_context.Pessoas == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Pessoas'  is null.");
            }

            var entryModel = new PessoaModel
            {
                data_cadastro = creationModel.data_cadastro,
                nome = creationModel.nome,
                data_nascimento = creationModel.data_nascimento,
                email = creationModel.email,
                cpf = creationModel.cpf,
                telefone = creationModel.telefone,
                logradouro = creationModel.logradouro,
                numero = creationModel.numero,
                complemento = creationModel.complemento,
                bairro = creationModel.bairro,
                cidade = creationModel.cidade,
                uf = creationModel.uf,
                cep = creationModel.cep
            };
            _context.Pessoas.Add(entryModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPessoaModel", new { entryModel.id }, entryModel);
        }

        // DELETE: api/PessoaModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePessoaModel(int id)
        {
            if (_context.Pessoas == null)
            {
                return NotFound();
            }
            var pessoaModel = await _context.Pessoas.FindAsync(id);
            if (pessoaModel == null)
            {
                return NotFound();
            }

            _context.Pessoas.Remove(pessoaModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PessoaModelExists(int id)
        {
            return (_context.Pessoas?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
