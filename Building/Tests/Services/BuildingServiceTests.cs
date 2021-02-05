using System.Collections.Generic;
using FL.PG.PLM_EEM_API.Entities;
using FL.PG.PLM_EEM_API.Services;
using FluentAssertions;
using System.Threading.Tasks;
using Xunit;

namespace FL.PG.PLM_EEM_API.Tests.Services
{
    public class BuildingServiceTests : ServiceTest<BuildingService>
    {
        private readonly BuildingService _service;

        public BuildingServiceTests()
        {
            _service = new BuildingService(_readWriteContext, _logger.Object);
        }

        [Fact]
        public async Task GetByDistrictIdAsync_ReturnsBuildings()
        {
            //Arrange
            var districtId = 12345;

            var BuildingEntities = new List<Building>
            {
                new Building{Id = 1001 , BuildingName = "test name 1"},
                new Building{Id = 1002, BuildingName = "test name 2"},
                new Building{Id = 1003, BuildingName = "test name 3"},
                new Building{Id = 1004 , BuildingName = "test name 4"}
            };

            _readWriteContext.Buildings.AddRange(BuildingEntities);

            _readWriteContext.SaveChanges();

            //Act
            var result = await _service.GetByDistrictIdAsync(districtId);

            //Assert
            result.Should().HaveCount(4);
            result.Should().BeOfType(typeof(List<Building>));
        }
    }
}
