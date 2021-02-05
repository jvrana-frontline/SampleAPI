using System;
using FL.PG.PLM_EEM_API.Entities;
using FL.PG.PLM_EEM_API.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FL.PG.PLM_EEM_API.Services
{
    public class ActivityService : IActivityService
    {
        private readonly IPlmReadWriteContext _plmDataContext;
        private readonly ILogger<ActivityService> _logger;
        public ActivityService(IPlmReadWriteContext plmDataContext, ILogger<ActivityService> logger)
        {
            _plmDataContext = plmDataContext;
            _logger = logger;
        }
        public async Task<List<Activity>> GetByDistrictIdAsync(int orgId, bool onlyActive = true)
        {
            throw new NotImplementedException();
            //todo logic goes here
            var query = _plmDataContext.Activities.Where(d => d.District.FlOrgId == orgId);
            if (onlyActive) query = query.Where(x => x.Active == true);
            return await query.ToListAsync();
            var result = string.Empty; //do stuff here
            return result;
        }
    }
}
