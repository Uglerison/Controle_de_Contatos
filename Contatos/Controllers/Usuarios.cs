using Contatos.Models;
using Contatos.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Contatos.Controllers
{
    public class Usuarios : Controller
    {
            private readonly IUsuarioRepositorio _usuarioRepositorio;
            public Usuarios(IUsuarioRepositorio usuarioRepositorio)
            {
                _usuarioRepositorio = usuarioRepositorio;
            }
            public IActionResult Index()
            {
                List<UsuarioModel> usuarios = _usuarioRepositorio.BuscarTodos();
                return View(usuarios);
            }
            public IActionResult Criar()
            {
                return View();
            }
        [HttpPost]
        public IActionResult Criar(UsuarioModel usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _usuarioRepositorio.Adicionar(usuario);
                    TempData["okMsg"] = "Usuario cadastrado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(usuario);
            }
            catch (Exception erro)
            {
                TempData["erroMsg"] = $"Usuario não cadastrado! {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }   
}

