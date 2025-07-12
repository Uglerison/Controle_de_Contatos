using Contatos.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Contatos.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="O campo Nome é obrigatório!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "O campo Email é obrigatório!")]
        [EmailAddress(ErrorMessage ="O Email digitado está inválido.")]
        public string Email{ get; set; }
        [Required(ErrorMessage = "O campo Login é obrigatório!")]
        public string Login { get; set; }
        [Required(ErrorMessage = "O campo Senha é obrigatório!")]
        [PasswordPropertyText]
        public string Password { get; set; }
        public PerfilEnum Perfil { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataEdicao { get; set; }
    }
}
