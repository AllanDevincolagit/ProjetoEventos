namespace ProjetoEventos.Entidades
{
    public class Usuario_Permissoes
    {
        public int ID { get; set; }
        public int UsuarioID { get; set; }
        public int PermissoesID { get; set; }
        public Usuario usuario { get; set; }
        public Permissoes permissoes { get; set; }
    }
}
