using AutoMapper;
using BlueOcean.Data.Models;
using BlueOcean.DTOs;
using BlueOcean.Repositories.Interfaces;

namespace BlueOceanApi.Logic
{
    public class BoatLogic
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public BoatLogic(IUnitOfWork unitOfWork, IConfiguration configuration, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
            _mapper = mapper;
        }

        public async Task<MainResponseDTO<List<BoatDTO>>> GetBoats()
        {
            var response = new MainResponseDTO<List<BoatDTO>>();

            try
            {

                var boats = await _unitOfWork.BoatRepository.GetAllBoatsAsync();

                var responseModel = _mapper.Map<List<BoatDTO>>(boats);

                response.Result = responseModel;

            }

            catch (Exception ex)
            {

                response.Error = $"An error occurred: {ex.Message}";
            }

            return response;

        }

        public async Task<MainResponseDTO<List<BoatDTO>>> GetBoat(string boatId)
        {
            var response = new MainResponseDTO<List<BoatDTO>>();

            try
            {
                var boat = await _unitOfWork.BoatRepository.GetBoatAsync(boatId);

                var responseModel = _mapper.Map<List<BoatDTO>>(boat);

                response.Result = responseModel;
            }
            catch (Exception ex)
            {
                response.Error = $"An error occurred: {ex.Message}";
            }

            return response;
        }


    }
}
