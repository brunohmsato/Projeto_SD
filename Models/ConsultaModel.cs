using System.ComponentModel.DataAnnotations.Schema;

namespace SistDist.Models
{
    [Table("consulta")]
    public class ConsultaModel
    {
        public int id { get; set; }
        public DateTime data_cadastro { get; set; }
        public DateTime data_consulta { get; set; }
        public TimeSpan horario_consulta { get; set; }
        public float valor_consulta { get; set; }
        public string diagnostico { get; set; }
        public int animal_id { get; set; }
        public int veterinario_id { get; set; }

        [ForeignKey("animal_id")]
        public virtual AnimalModel Animal { get; set; }

        [ForeignKey("veterinario_id")]
        public virtual VeterinarioModel Veterinario { get; set; }
    }
}