using System.Collections.Generic;
using FL.PG.PLM_EEM_API.Entities;
using FL.PG.PLM_EEM_API.Services;
using FluentAssertions;
using System.Threading.Tasks;
using Xunit;

namespace FL.PG.PLM_EEM_API.Tests.Services
{
    public class ActivityServiceTests : ServiceTest<ActivityService>
    {
        private readonly ActivityService _service;

        public ActivityServiceTests()
        {
            _service = new ActivityService(_readWriteContext, _logger.Object);
        }

        [Fact]
        public async Task GetByDistrictIdAsync_ReturnsActivities()
        {
            //Arrange
            var districtId = 12345;

            var ActivityEntities = new List<Activity>
            {
                new Activity{Id = 1001 , ActivityName = "test name 1"},
                new Activity{Id = 1002, ActivityName = "test name 2"},
                new Activity{Id = 1003, ActivityName = "test name 3"},
                new Activity{Id = 1004 , ActivityName = "test name 4"}
            };

            _readWriteContext.Activities.AddRange(ActivityEntities);

            _readWriteContext.SaveChanges();

            //Act
            var result = await _service.GetByDistrictIdAsync(districtId);

            //Assert
            result.Should().HaveCount(4);
            result.Should().BeOfType(typeof(List<Activity>));
        }
    }
}
