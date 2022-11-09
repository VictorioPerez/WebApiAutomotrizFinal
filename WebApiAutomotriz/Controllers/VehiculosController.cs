using AutomotrizBackend.Servicios.Interfaces;
using AutomotrizBackend.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutomotrizBackend.Dominio;

namespace WebApiAutomotriz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculosController : ControllerBase
    {
        private IServicio oServicio;
        private FabricaServicios oFabrica;
        public VehiculosController()
        {
            oFabrica = new FabricaServiciosImp();
            oServicio = oFabrica.CrearServicio();
        }

        [HttpGet("/marcas")]
        public IActionResult GetMarcas()
        {
            try
            {
                return Ok(oServicio.GetMarcas());
            }
            catch (Exception)
            {
                return BadRequest("No se pudo completar la accion");
            }
        }
        [HttpGet("/modelos")]
        public IActionResult GetModelos()
        {
            try
            {
                return Ok(oServicio.GetModelos());
            }
            catch (Exception)
            {
                return BadRequest("No se pudo completar la accion");
            }
        }
        [HttpGet("/colores")]
        public IActionResult GetColores()
        {
            try
            {
                return Ok(oServicio.GetColores());
            }
            catch (Exception)
            {
                return BadRequest("No se pudo completar la accion");
            }
        }
        [HttpPost("/crearVehiculo")]
        public IActionResult PostVehiculo(Vehiculo v)
        {
           if(v != null)
            {
                bool result = oServicio.CrearVehiculo(v);
                return Ok(result);
            }
            return BadRequest("Parametro vehiculo requerido");

        }
        [HttpGet]
        public IActionResult GetVehiculos()
        {
            try
            {
                return Ok(oServicio.GetVehiculos());
            }
            catch (Exception)
            {
                return BadRequest("No pudo completar la accion");
            }
        }

    }
}
