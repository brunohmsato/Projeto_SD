namespace SistDist.Models.CreationModel
{
    public class VeterinarioCreationModel
    {
        public DateTime data_contratacao { get; set; }
        public DateTime? data_demissao { get; set; }
        public string ctps_numero { get; set; }
        public string ctps_serie { get; set; }
        public string ctps_estado { get; set; }
        public string pis_pasesp { get; set; }
        public float salario { get; set; }
        public string crmv_numero { get; set; }
        public string crmv_estado { get; set; }
        public int pessoa_id { get; set; }
    }
}
