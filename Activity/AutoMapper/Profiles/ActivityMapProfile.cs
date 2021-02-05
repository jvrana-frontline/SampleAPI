using AutoMapper;
using FL.PG.PLM_EEM_API.Entities;
using FL.PG.PLM_EEM_API.ViewModels;

namespace FL.PG.PLM_EEM_API.AutoMapper.Profiles
{
    public class ActivityMapProfile : Profile
    {
        public ActivityMapProfile()
        {
            CreateMap<Activity, ActivityModel>();
            CreateMap<ActivityModel, Activity>();
        }
    }
}
