using System.ComponentModel.DataAnnotations.Schema;

namespace SistDist.Models
{
    [Table("pessoa")]
    public class PessoaModel
    {
        public int id { get; set; }
        public DateTime data_cadastro { get; set; }
        public string nome { get; set; }
        public DateTime data_nascimento { get; set; }
        public string email { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public string logradouro { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string cep { get; set; }
    }
}