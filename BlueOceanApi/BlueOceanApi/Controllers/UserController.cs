using BlueOcean.DTOs;
using BlueOcean.DTOs.User;
using BlueOcean.Repositories.Interfaces;
using BlueOceanApi.Logic;
using Microsoft.AspNetCore.Mvc;

namespace BlueOceanApi.Controllers
{
    public class UserController : BaseController
    {
        private readonly UserLogic _userLogic;

        public UserController(IUnitOfWork unitOfWork, IConfiguration configuration) : base(unitOfWork, configuration)
        {
            _userLogic = new UserLogic(unitOfWork, configuration);
        }

        [HttpPost("login")]
        public async Task<ActionResult<MainResponseDTO<LoginResponseDTO>>> Login(LoginRequestDTO dto)
        {
            try
            {
                var response = await _userLogic.Login(dto);
                if (response.Result != null) return Ok(response);
                return Unauthorized(response.Error);
            }
            catch (Exception ex) 
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
