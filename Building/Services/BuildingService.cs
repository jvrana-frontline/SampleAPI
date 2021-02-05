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
    public class BuildingService : IBuildingService
    {
        private readonly IPlmReadWriteContext _plmDataContext;
        private readonly ILogger<BuildingService> _logger;
        public BuildingService(IPlmReadWriteContext plmDataContext, ILogger<BuildingService> logger)
        {
            _plmDataContext = plmDataContext;
            _logger = logger;
        }
        public async Task<List<Building>> GetByDistrictIdAsync(int orgId, bool onlyActive = true)
        {
            throw new NotImplementedException();
            //todo logic goes here
            var query = _plmDataContext.Buildings.Where(d => d.District.FlOrgId == orgId);
            if (onlyActive) query = query.Where(x => x.Active == true);
            return await query.ToListAsync();
            var result = string.Empty; //do stuff here
            return result;
        }
    }
}
