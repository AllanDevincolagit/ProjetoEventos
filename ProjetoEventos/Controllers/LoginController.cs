using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using ProjetoEventos.Entidades;
using System.Security.Claims;

namespace ProjetoEventos.Controllers
{
    public class LoginController : Controller
    {
        private readonly Contexto db;
        public LoginController(Contexto contexto)
        {
            db = contexto;
        }
        public IActionResult Entrar()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Entrar(string login, string senha)
        {
            Usuario usuarioLogado = db.USUARIO.Where(a => a.Login == login && a.Senha == senha).FirstOrDefault();

            if (usuarioLogado == null)
            {
                TempData["erro"] = "Login ou Senha Incorretos";
                return View();
            }

            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, usuarioLogado.Nome));
            claims.Add(new Claim(ClaimTypes.Sid, usuarioLogado.ID.ToString()));

            var userIdentity = new ClaimsIdentity(claims, "Acesso");
            ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
            await HttpContext.SignInAsync("CookieAuthentication", principal, new AuthenticationProperties());
            return Redirect("/");
        }

        public async Task<IActionResult> Logoff()
        {
            await HttpContext.SignOutAsync("CookieAuthentication");
            return Redirect("/Login/Entrar");
        }
    }
}
