using Block.Entities.Pessoa;
using System.Collections.Generic;

namespace Block.Repository._1___Interfaces
{
    public interface IPessoaRepository
    {
        IEnumerable<Pessoa> GetAll();
        bool Insert(Pessoa pessoa);
        bool Update(Pessoa pessoa);
        bool DeletePessoa(long idPessoa);
    }
}
