using AutomotrizBackend.Servicios.Interfaces;
using AutomotrizBackend.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutomotrizBackend.Dominio;

namespace WebApiAutomotriz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutopartesController : ControllerBase
    {

        private IServicio oServicio;
        private FabricaServicios oFabrica;
        public AutopartesController()
        {
            oFabrica = new FabricaServiciosImp();
            oServicio = oFabrica.CrearServicio();
        }
        [HttpPost("/crearAutoparte")]
        public IActionResult PostAutoparte(Autopartes a)
        {
            if(a != null)
            {
                bool result = oServicio.CrearAutoparte(a);
                return Ok(result);
            }
            return BadRequest("Parametro autoparte requerido");
        }


    }
}
