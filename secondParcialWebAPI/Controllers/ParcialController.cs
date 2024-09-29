using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using secondParcialWebAPI.DTOS;
using secondParcialWebAPI.Models;
using secondParcialWebAPI.Servicios.Interfaces;
using System.Security;

namespace secondParcialWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParcialController : ControllerBase
    {
        private readonly IDeporteService _deporteService;
        private readonly ISocioService _socioService;

        public ParcialController(IDeporteService deporteService, ISocioService socioService)
        {
            _deporteService = deporteService;
            _socioService = socioService;   
        }
        [HttpGet("/Parcial/GetDeportes")]
        public async Task<ActionResult<List<Deporte>>> Get()
        {
            return Ok(await _deporteService.GetDeportes());
        }

        [HttpGet("/Parcial/GetSocios")]
        public async Task<ActionResult> GetSocios()
        {
            return Ok(await _socioService.GetAllSocios());
        }

        [HttpPost("/Parcial/PostSocio")]
        public async Task<IActionResult> AddSocio([FromBody] SocioAltaDto socio)
        {
            try
            {
                var response = await _socioService.AddSocio(socio);

                if (response.Success)
                {
                    return Ok(response.Data);
                }
                else
                {
                    return BadRequest(response.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("/Parcial/GetSocioById/{id}")]
        public async Task<IActionResult> GetSocioById(Guid id)
        {
            var result = await _socioService.GetById(id);

            if (!result.Success)
            {
                return StatusCode((int)result.StatusCode, result.Data);
            }
            return Ok(result.Data);
        }

        

    }
}
