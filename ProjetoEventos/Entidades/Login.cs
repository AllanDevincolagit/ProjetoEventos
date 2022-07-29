namespace ProjetoEventos.Entidades
{
    public class Login
    {
        public int Id { get; set; }
        public string EmailOuLogin { get; set; }
        public string Senha { get; set; }
        public int UsuarioID { get; set; }
        public Usuario usuario { get; set; }
    }
}
