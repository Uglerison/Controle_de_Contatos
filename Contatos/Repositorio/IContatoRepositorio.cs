using Contatos.Models;

namespace Contatos.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel ListarPorId(int id);
        ContatoModel Adicionar(ContatoModel contato);
        List<ContatoModel> BuscarTodos();
        ContatoModel Atualizar(ContatoModel contato);
        bool Apagar(int id);
    }
    
}
