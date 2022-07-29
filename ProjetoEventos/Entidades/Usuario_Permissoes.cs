namespace ProjetoEventos.Entidades
{
    public class Usuario_Permissoes
    {
        public int ID { get; set; }
        public int UsuarioID { get; set; }
        public int PermissaoID { get; set; }
        public Usuario usuario { get; set; }
        public Permissoes permissao { get; set; }
    }
}
