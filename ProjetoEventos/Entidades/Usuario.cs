using System.ComponentModel.DataAnnotations;

namespace ProjetoEventos.Entidades
{
    public class Usuario
    {
        [Key]
        public int ID { get; set; }
        public string Nome {get;set;}
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
