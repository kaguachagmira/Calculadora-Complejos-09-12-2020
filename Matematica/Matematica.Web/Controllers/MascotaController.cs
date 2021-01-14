using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Matematica.Web.Data;
namespace Matematica.Web.Controllers
{
    public class MascotaController : Controller
    {
        // GET: MascotaController
        readonly ApplicationDbContext context = new ApplicationDbContext();
        //https... localhost/oeruto/mascotas/index
        public IActionResult Index()
        {
            var mascotas = context.Mascotas.ToList();
            return View(mascotas);
        }

    }
}
