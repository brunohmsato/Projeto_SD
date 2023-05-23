namespace SistDist.Models
{
    public class VeterinarioModel
    {
        public int Id { get; set; }
        public DateTime DataContratacao { get; set; }
        public DateTime DataDemissao { get; set; }
        public string CTPSNumero { get; set; }
        public string CTPSSerie { get; set; }
        public string CTPSEstado { get; set; }
        public string PISPasesp { get; set; }
        public float Salario { get; set; }
        public string CRMVNumero { get; set; }
        public string CRMVEstado { get; set; }
        public bool NotificacaoEmail { get; set; }
        public bool NotificacaoWhats { get; set; }
        public int PessoaId { get; set; }

        public virtual PessoaModel Pessoa { get; set; }
    }
}