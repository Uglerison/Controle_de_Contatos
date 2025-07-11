using Contatos.Enums;

namespace Contatos.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email{ get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public PerfilEnum Perfil { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataEdicao { get; set; }
    }
}
