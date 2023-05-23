namespace SistDist.Models
{
    public class ConsultaModel
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataConsulta { get; set; }
        public TimeSpan HorarioConsulta { get; set; }
        public float ValorConsulta { get; set; }
        public string Diagnostico { get; set; }
        public int VeterinarioId { get; set; }
        public int AnimalId { get; set; }

        public virtual VeterinarioModel Veterinario { get; set; }
        public virtual AnimalModel Animal { get; set; }
    }
}