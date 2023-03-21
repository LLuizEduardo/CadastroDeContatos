using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroDeContatos
{
    public interface IContatoRepositorio
    {
        ContatoModel Adicionar(ContatoModel contato);
        List<ContatoModel> ListarTodos();
        ContatoModel BuscarPorId(int id);
        ContatoModel Atualizar(ContatoModel contato);
    }
}
