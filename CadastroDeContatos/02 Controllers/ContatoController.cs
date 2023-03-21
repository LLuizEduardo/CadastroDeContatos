using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroDeContatos
{
    public class ContatoController : Controller
    {
        //INSERIDO PARA O POST
        private readonly IContatoRepositorio _contatoRepositorio;
        //public ContatoController(IContatoRepositorio contatoRepositorio)
        //{
        //    _contatoRepositorio = contatoRepositorio;
        //}

        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;

        }

        public IActionResult Index()
        {
            List<ContatoModel> contatos =_contatoRepositorio.ListarTodos();
            return View(contatos);
        }
        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult ApagarConfirmacao()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            _contatoRepositorio.Adicionar(contato);
            return RedirectToAction("Index");
        }
    }
}
