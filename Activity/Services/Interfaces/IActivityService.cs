using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FL.PG.PLM_EEM_API.Entities;

namespace FL.PG.PLM_EEM_API.Services.Interfaces
{
    public interface IActivityService
    {
        Task<List<Activity>> GetByDistrictIdAsync(int districtId, bool onlyActive = true);
    }
}
