using System.ComponentModel.DataAnnotations;

namespace Contatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="O campo de Nome é obrigatório!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "O campo de Email é obrigatório!")]
        [EmailAddress(ErrorMessage ="O email digitado está inválido!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo de Telefone é obrigatório!")]
        [Phone(ErrorMessage = "O telefone digitado está inválido!")]
        public string Phone { get; set; }
    }
}
