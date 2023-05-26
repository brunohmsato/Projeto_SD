namespace SistDist.Models.CreationModel
{
    public class ConsultaCreationModel
    {
        public DateTime data_cadastro { get; set; }
        public DateTime data_consulta { get; set; }
        public TimeSpan horario_consulta { get; set; }
        public float valor_consulta { get; set; }
        public string diagnostico { get; set; }
        public int animal_id { get; set; }
        public int veterinario_id { get; set; }
    }
}
