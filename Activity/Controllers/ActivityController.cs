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
    public class ActivityController : ControllerBase
    {
        private readonly IActivityService _activityService;
        private readonly ILogger<ActivityController> _logger;
        private readonly IMapper _mapper;
        private readonly IUserIdentity _userIdentity;
        private readonly IUserService _userService;
        private readonly IDistrictService _districtService;

        public ActivityController(IActivityService activityService, ILogger<ActivityController> logger,
        IMapper mapper, IUserIdentity userIdentity, IUserService userService,
        IDistrictService districtService)
        {
            _activityService = activityService ?? throw new ArgumentNullException(nameof(activityService));
            _logger = logger;
            _mapper = mapper;
            _userIdentity = userIdentity;
            _userService = userService;
            _districtService = districtService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ActivityModel>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(BadRequestObjectResult), (int)HttpStatusCode.BadRequest)]
        async public Task<ActionResult<ActivityModel>> GetActivities(int orgId, bool onlyActive = true)
        {
            var district = await _districtService.GetById(orgId, true);
            if (district == null)
            {
                return BadRequest("invalid orgId.");
            }
            else
            {
            var activitys = await _activityService.GetByDistrictIdAsync(district.Id, onlyActive);
            return Ok(activitys.Select(d => _mapper.Map<ActivityModel>(d)).ToList());
            }
        }
    }
}
