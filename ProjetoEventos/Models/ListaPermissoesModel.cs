using ProjetoEventos.Entidades;

namespace ProjetoEventos.Models
{
    public class ListaPermissoesModel
    {
        public int UsuarioID { get; set; }

        public List<Permissoes> TodasPermissoes { get; set; }
        public List<Usuario_Permissoes> PermissoesUsuario { get; set; }
    }
}
