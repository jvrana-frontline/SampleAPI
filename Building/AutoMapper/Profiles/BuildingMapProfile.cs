using AutoMapper;
using FL.PG.PLM_EEM_API.Entities;
using FL.PG.PLM_EEM_API.ViewModels;

namespace FL.PG.PLM_EEM_API.AutoMapper.Profiles
{
    public class BuildingMapProfile : Profile
    {
        public BuildingMapProfile()
        {
            CreateMap<Building, BuildingModel>();
            CreateMap<BuildingModel, Building>();
        }
    }
}
