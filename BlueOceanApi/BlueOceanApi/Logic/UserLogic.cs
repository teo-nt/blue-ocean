using BlueOcean.DTOs;
using BlueOcean.DTOs.User;
using BlueOcean.Helpers.Security;
using BlueOcean.Repositories.Interfaces;

namespace BlueOceanApi.Logic
{
    public class UserLogic
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;

        public UserLogic(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
        }

        public async Task<MainResponseDTO<LoginResponseDTO>> Login(LoginRequestDTO loginRequest)
        {
            var response = new MainResponseDTO<LoginResponseDTO>();

            try
            {
                var user = await _unitOfWork.UserRepository.GetUserAsync(loginRequest.Username, loginRequest.Password);

                if (user == null)
                {
                    response.Error = "Invalid credentials";
                    return response;
                }

                var jwtToken = TokenUtil.CreateToken(user, _configuration);
                var responseModel = new LoginResponseDTO
                {
                    Token = jwtToken,
                };
                response.Result = responseModel;
            }
            catch (Exception e)
            {
                response.Error = $"An error occured: {e.Message}";
            }

            return response;
        }

        //public async Task<> Register()
        //{

        //}
    }
}
