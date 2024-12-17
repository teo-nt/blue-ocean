using AutoMapper;
using BlueOcean.DTOs;
using BlueOcean.Repositories.Interfaces;
using BlueOceanApi.Logic;
using Microsoft.AspNetCore.Mvc;


namespace BlueOceanApi.Controllers
{ 
    public class BoatController : BaseController
    {
        private readonly BoatLogic _boatLogic;

        public BoatController(IUnitOfWork unitOfWork, IConfiguration configuration, IMapper mapper) : base(unitOfWork, configuration)
        {
            _boatLogic = new BoatLogic(unitOfWork, configuration, mapper);
        }


        [HttpGet()]
        public async Task<ActionResult<MainResponseDTO<List<BoatDTO>>>> GetBoats()
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
