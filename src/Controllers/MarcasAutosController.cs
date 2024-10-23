using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using PruebaTecnica_Backend_CSharp.Data;

namespace PruebaTecnica_Backend_CSharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcasAutosController : ControllerBase
    {
        private readonly AutoContext _context;

        public MarcasAutosController(AutoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<MarcaAuto>> GetMarcas()
        {
            return _context.MarcasAutos.ToList();
        }
    }
}

