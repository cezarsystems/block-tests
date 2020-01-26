using Block.Entities.Pessoa;
using Block.DataAccess._2___Implementations;
using System.Collections.Generic;
using System;

namespace Block.TestesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var dadosPessoa = new Pessoa
            {
                DataNascimento = DateTime.Now,
                EstadoCivil = "Solteiro",
                Nome = "Juliana",
                Sobrenome = "Simone"
            };

            new DbBasicOperations().InUpDe<Pessoa>(dadosPessoa);

            IEnumerable<Pessoa> dadosRetorno = 
                new DbBasicOperations().GetAll<Pessoa>();
        }
    }
}
