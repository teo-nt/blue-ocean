using AutoMapper;

namespace BlueOcean.Helpers.Mapper
{
    public class BaseProfile : Profile
    {
        public BaseProfile()
        {
            ValueTransformers.Add<string>(s => string.IsNullOrWhiteSpace(s) ? string.Empty : s);
            
        }
    }
}
