using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
