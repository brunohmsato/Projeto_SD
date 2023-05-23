namespace SistDist.Models
{
    public class AnimalModel
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Nome { get; set; }
        public string Especie { get; set; }
        public string Raca { get; set; }
        public string Sexo { get; set; }
        public string Cor { get; set; }
        public DateTime DataNascimento { get; set; }
        public float Peso { get; set; }
        public string Alergia { get; set; }
        public int TutorId { get; set; }
    }
}
