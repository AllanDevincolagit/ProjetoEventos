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

        [HttpGet("[controller]/[action]/{UsuarioID}/{PermissaoID}")]
        public IActionResult AdicionarPermissao(int UsuarioID, int PermissaoID)
        {
            Usuario_Permissoes novo = new Usuario_Permissoes();
            novo.UsuarioID = UsuarioID;
            novo.PermissaoID = PermissaoID;
            db.USUARIO_PERMISSOES.Add(novo);
            db.SaveChanges();
            return Redirect("/Usuario");
        }
    }
}
