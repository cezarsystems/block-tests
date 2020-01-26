using System;

namespace Block.Entities.Pessoa
{
    public class Pessoa
    {
        public int Id { get; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string EstadoCivil { get; set; }
    }
}
