using AutoMapper;
using COMMON.DomainModels;
using COMMON.DTO;

namespace LOGIC.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DTORequest, Test>().ReverseMap();
            CreateMap<Test, DTOResponse>().ReverseMap();
            
            CreateMap<DTORequest, Car>().ReverseMap();
            CreateMap<Car, DTOResponse>().ReverseMap();
        }
    }
}
