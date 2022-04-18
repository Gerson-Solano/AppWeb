using Microsoft.AspNetCore.Mvc;

using AppWebPractica.Models;

using AppWebPractica.Data;

namespace AppWebPractica.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly Contexto contexto;

        public EmpleadoController(Contexto contexto)
        {
            this.contexto = contexto;
        }
        public IActionResult Index()
        {
            return View(this.contexto.Empleados.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public async Task<IActionResult> Create(
            [Bind("Id, NombreCompleto, Correo, Telefono, FechaRegistro, Estado")] Empleados empleado)
        {
            if (ModelState.IsValid)
            {
                this.contexto.Add(empleado);

                await this.contexto.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View();

        }
    }
}
