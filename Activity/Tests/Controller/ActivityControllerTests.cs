using AutoMapper;
using FL.PG.PLM_EEM_API.AutoMapper;
using FL.PG.PLM_EEM_API.AutoMapper.Profiles;
using FL.PG.PLM_EEM_API.Controllers;
using FL.PG.PLM_EEM_API.Entities;
using FL.PG.PLM_EEM_API.Services.Interfaces;
using FL.PG.PLM_EEM_API.ViewModels;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace FL.PG.PLM_EEM_API.Tests.Controller
{
    public class ActivityControllerTest : ControllerTest<ActivityController, IActivityService>
    {
        private readonly ActivityController _controller;

        public ActivityControllerTest()
        {
            var mapperConfig = new MapperConfiguration(cfg => cfg.AddProfile(new ActivityMapProfile()));
            var mapper = new Mapper(mapperConfig);

            _controller = new ActivityController(
                _mockService.Object,
                _mockLogger.Object,
                mapper,
                _mockUserIdentity.Object,
                _mockUserService.Object,
                _mockDistrictService.Object);
        }

        [Fact]
        public void HappyPathInitializeTest()
        {
            // Arrange
            Action ac = () => new ActivityController(
                new Mock<IActivityService>().Object,
                new Mock<ILogger<ActivityController>>().Object,
                new Mock<IMapper>().Object,
                new Mock<IUserIdentity>().Object,
                new Mock<IUserService>().Object,
                new Mock<IDistrictService>().Object);

            // Act and Assert
            ac.Should().NotThrow();
        }

        [Fact]
        public void Initialize_Should_Throw_With_Missing_ActivityService()
        {
            // Arrange
            Action ac = () => new ActivityController(null,
                new Mock<ILogger<ActivityController>>().Object,
                new Mock<IMapper>().Object,
                new Mock<IUserIdentity>().Object,
                new Mock<IUserService>().Object,
                new Mock<IDistrictService>().Object);

            // Act and Assert
            ac.Should().ThrowExactly<ArgumentNullException>().Where(ex => ex.ParamName == "activityService");
        }

        #region GetActivities

        [Fact]
        public async Task GetActivities_ReturnsModels()
        {
            // Arrange
            var orgId = 12345;
            var districtId = 10020;
            var entities = new List<Activity>()
            {
                new Activity(){Id = 1}
            };
            var user = new User() { IsSysAdmin = true };
            var district = new District() { Id = districtId, FlOrgId = orgId };

            _mockUserIdentity.SetupGet(m => m.OrgIds).Returns(new[] { orgId });
            _mockUserService.Setup(m => m.GetByIdAndOrgAsync(It.IsAny<IEnumerable<int>>(), It.IsAny<int>())).ReturnsAsync(user);
            _mockDistrictService.Setup(m => m.GetById(It.IsAny<int>(), It.IsAny<bool>())).ReturnsAsync(district);

            _mockService.Setup(m => m.GetByDistrictIdAsync(It.IsAny<int>(),true)).ReturnsAsync(entities);

            // Act
            var response = await _controller.GetActivities(orgId);

            // Assert
            response.Result.Should().BeOfType<OkObjectResult>()
                .Which.Value.Should().BeOfType<List<ActivityModel>>();
        }
        [Fact]
        public async Task Get_WithInvalidDistrictId_ReturnsBadRequest()
        {
            // Arrange
            var orgId = 999999;
            var districtId = 999999;
            var entities = new List<Activity>()
            {
                new Activity()
                {
                    Id = 1,
                    Active = true
                }
            };
            var user = new User() { IsSysAdmin = true };
            District district = null;

            _mockUserIdentity.SetupGet(m => m.OrgIds).Returns(new[] { orgId });
            _mockUserService.Setup(m => m.GetByIdAndOrgAsync(It.IsAny<IEnumerable<int>>(), It.IsAny<int>())).ReturnsAsync(user);
            _mockDistrictService.Setup(m => m.GetById(It.IsAny<int>(), It.IsAny<bool>())).ReturnsAsync(district);

            _mockService.Setup(m => m.GetByDistrictIdAsync(It.IsAny<int>(), true)).ReturnsAsync(entities);

            // Act
            var response = await _controller.GetActivities(orgId);

            // Assert
            response.Result.Should().BeOfType<BadRequestObjectResult>();

        }
        #endregion
    }
}
