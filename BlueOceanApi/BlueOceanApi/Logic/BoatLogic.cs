using AutoMapper;
using BlueOcean.DTOs;
using BlueOcean.Repositories.Interfaces;

namespace BlueOceanApi.Logic
{
    public class BoatLogic
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public BoatLogic(IUnitOfWork unitOfWork, IMapper mapper, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _configuration = configuration;
        }

        //public MainResponseDTO GetBoats()
        //{
        //    var response = new MainResponseDTO();

        //    try
        //    {
                
        //        var responseModel = 
        //    }
        //}
    }

   
}
