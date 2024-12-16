using BlueOcean.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlueOceanApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController : ControllerBase
    {
        protected readonly IUnitOfWork unitOfWork;
        protected readonly IConfiguration configuration;

        public BaseController(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            this.unitOfWork = unitOfWork;
            this.configuration = configuration;
        }

    }

   
}
