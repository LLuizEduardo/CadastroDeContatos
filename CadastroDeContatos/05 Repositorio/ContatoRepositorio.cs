using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroDeContatos
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            // gravar no banco
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();

            return contato;
        }

        public List<ContatoModel> ListarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }

        public ContatoModel BuscarPorId(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(x => x.Id == id);
        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDB = BuscarPorId(contato.Id);
            if (contatoDB == null) throw new Exception("Houve um erro na atualização");

            contatoDB.Nome = contato.Nome;
            contatoDB.Email = contato.Email;
            contatoDB.Telefone= contato.Telefone;

            _bancoContext.Contatos.Update(contatoDB);
            _bancoContext.SaveChanges();

            return contatoDB;
        }
    }
}
