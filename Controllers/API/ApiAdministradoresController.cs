using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using admin_cms.Models.Infraestrutura.Database;
using System.Linq;

namespace admin_cms.Controllers.API
{
    public class ApiAdministradoresController : ControllerBase
    {
        private readonly ContextoCms _context;

        public ApiAdministradoresController(ContextoCms context)
        {
            _context = context;
        }

        // GET: Administradores
        [Route("/api/administradores.json")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            // return StatusCode(200, await _context.Administradores.ToListAsync());

            //  var adms = from adm in ( await _context.Administradores.ToPagedListAsync(page, AdministradorService.ITENS_POR_PAGINA))
            var adms = from adm in ( await _context.Administradores.ToListAsync())
                select new {
                    Id = adm.Id,
                    Nome = adm.Nome,
                    Telefone = adm.Telefone,
                    Email = adm.Email
                };

            return StatusCode(200, adms);
        }
        
    }
}
