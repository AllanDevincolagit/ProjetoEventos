using Microsoft.AspNetCore.Mvc;
using ProjetoEventos.Entidades;

namespace ProjetoEventos.Controllers
{
    public class UsuarioPermissoesController : Controller
    {
        private readonly Contexto db;
        public UsuarioPermissoesController(Contexto contexto)
        {
            db = contexto;
        }
        [HttpGet("[Controller]/[Action]/{UsuarioID}/{PermissoesID}/")]
        public IActionResult AdicionarPermissao(int UsuarioID, int PermissoesID)
        {
            Usuario_Permissoes novo = new Usuario_Permissoes();
            novo.UsuarioID = UsuarioID;
            novo.PermissoesID = PermissoesID;
            db.USUARIO_PERMISSOES.Add(novo);
            db.SaveChanges();
            return Redirect("/Usuario");
        }
    }
}
