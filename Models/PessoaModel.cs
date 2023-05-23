﻿namespace SistDist.Models
{
    public class PessoaModel
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
    }
}