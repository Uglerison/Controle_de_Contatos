using Contatos.Models;

namespace Contatos.Repositorio
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel ListarPorId(int id);
        UsuarioModel Adicionar(UsuarioModel usuario);
        List<UsuarioModel> BuscarTodos();
        UsuarioModel Atualizar(UsuarioModel usuario);
        bool Apagar(int id);
    }
}
