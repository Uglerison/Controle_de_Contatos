using Contatos.Controllers;
using Contatos.Data;
using Contatos.Models;

namespace Contatos.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly BancoContext _bancoContext;
        public UsuarioRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public UsuarioModel Adicionar(UsuarioModel usuario)
        {
            usuario.DataCriacao = DateTime.Now;
            _bancoContext.TblUsuarios.Add(usuario);
            _bancoContext.SaveChanges();
            return usuario;
        }

        public bool Apagar(int id)
        {
            UsuarioModel UsuarioDB = ListarPorId(id);

            if (UsuarioDB == null) throw new System.Exception("Não foi possível deletar o usuario");

            _bancoContext.TblUsuarios.Remove(UsuarioDB);
            _bancoContext.SaveChanges();
            return true;
        }

        public UsuarioModel Atualizar(UsuarioModel usuario)
        {
            UsuarioModel usuarioDB = ListarPorId(usuario.Id);

            if (usuarioDB == null) throw new System.Exception("Não foi possível alterar o usuario");

            usuarioDB.Name = usuario.Name;
            usuarioDB.Email = usuario.Email;
            usuarioDB.Login = usuario.Login;
            usuarioDB.Perfil = usuario.Perfil;
            usuarioDB.DataEdicao = DateTime.Now;

            _bancoContext.TblUsuarios.Update(usuarioDB);
            _bancoContext.SaveChanges();

            return usuarioDB;
        }

        public List<UsuarioModel> BuscarTodos()
        {
            return _bancoContext.TblUsuarios.ToList();
        }

        public UsuarioModel ListarPorId(int id)
        {
            return _bancoContext.TblUsuarios.FirstOrDefault(x => x.Id == id);
        }
    }
}


