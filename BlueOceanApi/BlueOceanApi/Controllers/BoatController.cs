using AutoMapper;
using BlueOcean.DTOs;
using BlueOcean.Repositories.Interfaces;
using BlueOceanApi.Logic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace BlueOceanApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BoatController : BaseController
    {
        private readonly BoatLogic _boatLogic;

        public BoatController(IUnitOfWork unitOfWork, IConfiguration configuration, IMapper mapper) : base(unitOfWork, configuration)
        {
            _boatLogic = new BoatLogic(unitOfWork, configuration, mapper);
        }


        [HttpGet("GetBoats")]
        public async Task<IActionResult> GetBoats()
        {
            try
            {
                var response = await _boatLogic.GetBoats();

                if (response.Result != null)
                {
                    return Ok(response);
                }

                return NotFound(new { Message = "No boats found" });

            }
            catch (Exception exception)
            {
                return StatusCode(500, exception.Message);
            }
        }
    }
}
