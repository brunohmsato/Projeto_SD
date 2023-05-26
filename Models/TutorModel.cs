using System.ComponentModel.DataAnnotations.Schema;

namespace SistDist.Models
{
    [Table("tutor")]
    public class TutorModel
    {
        public int id { get; set; }
        public bool notificacao_email { get; set; }
        public bool notificacao_whats { get; set; }
        public int pessoa_id { get; set; }

        [ForeignKey("pessoa_id")]
        public virtual PessoaModel Pessoa { get; set; }
    }
}