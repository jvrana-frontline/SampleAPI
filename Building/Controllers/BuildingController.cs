using AutoMapper;
using FL.PG.PLM_EEM_API.Entities;
using FL.PG.PLM_EEM_API.Services.Interfaces;
using FL.PG.PLM_EEM_API.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace FL.PG.PLM_EEM_API.Controllers
{
    [Route("api/v1/org/{orgid}/[controller]")]
    [Authorize(Policy = AuthPolicy.UserOrg)]
    [ApiController]
    public class BuildingController : ControllerBase
    {
        private readonly IBuildingService _buildingService;
        private readonly ILogger<BuildingController> _logger;
        private readonly IMapper _mapper;
        private readonly IUserIdentity _userIdentity;
        private readonly IUserService _userService;
        private readonly IDistrictService _districtService;

        public BuildingController(IBuildingService buildingService, ILogger<BuildingController> logger,
        IMapper mapper, IUserIdentity userIdentity, IUserService userService,
        IDistrictService districtService)
        {
            _buildingService = buildingService ?? throw new ArgumentNullException(nameof(buildingService));
            _logger = logger;
            _mapper = mapper;
            _userIdentity = userIdentity;
            _userService = userService;
            _districtService = districtService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<BuildingModel>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(BadRequestObjectResult), (int)HttpStatusCode.BadRequest)]
        async public Task<ActionResult<BuildingModel>> GetBuildings(int orgId, bool onlyActive = true)
        {
            var district = await _districtService.GetById(orgId, true);
            if (district == null)
            {
                return BadRequest("invalid orgId.");
            }
            else
            {
            var buildings = await _buildingService.GetByDistrictIdAsync(district.Id, onlyActive);
            return Ok(buildings.Select(d => _mapper.Map<BuildingModel>(d)).ToList());
            }
        }
    }
}
