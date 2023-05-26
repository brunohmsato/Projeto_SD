using System.ComponentModel.DataAnnotations.Schema;

namespace SistDist.Models
{
    [Table("animal")]
    public class AnimalModel
    {
        public int id { get; set; }
        public DateTime data_cadastro { get; set; }
        public string nome { get; set; }
        public string especie { get; set; }
        public string raca { get; set; }
        public string sexo { get; set; }
        public string cor { get; set; }
        public DateTime data_nascimento { get; set; }
        public float peso { get; set; }
        public string alergia { get; set; }
        public int tutor_id { get; set; }

        [ForeignKey("tutor_id")]
        public virtual TutorModel Tutor { get; set; }
    }
}