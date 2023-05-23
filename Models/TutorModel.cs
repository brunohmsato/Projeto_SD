namespace SistDist.Models
{
    public class TutorModel
    {
        public int Id { get; set; }
        public bool NotificacaoEmail { get; set; }
        public bool NotificacaoWhats { get; set; }
        public int PessoaId { get; set; }
    }
}
