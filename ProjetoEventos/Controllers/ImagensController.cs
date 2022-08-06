using Microsoft.AspNetCore.Mvc;

namespace ProjetoEventos.Controllers
{
    public class ImagensController : Controller
    {
        private string CaminhoServidor;

        public ImagensController(IWebHostEnvironment sistema)
        {
            CaminhoServidor = sistema.WebRootPath;
        }
        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Upload(IFormFile foto)
        {
            string CaminhoParaSalverImagem = CaminhoServidor + "\\imgPerfUsu\\";
            string NovoNomeParaImagem = Guid.NewGuid().ToString() + foto.FileName;

            if (!Directory.Exists(CaminhoParaSalverImagem)){
                Directory.CreateDirectory(CaminhoParaSalverImagem);
            }

            using(var stream = System.IO.File.Create(CaminhoParaSalverImagem + NovoNomeParaImagem))
            {
                foto.CopyToAsync(stream);
            }

            return RedirectToAction("Upload");
        }
    }
}
