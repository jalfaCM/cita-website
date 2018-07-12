using CarMax.Cita.Web.Gateways;
using System;
using System.Linq;
using Xunit;

namespace CarMax.Cita.Web.Tests
{
    public class InMemorySearchGatewayTests
    {
        private readonly InMemorySearchGateway _gateway;
        public InMemorySearchGatewayTests()
        {
            _gateway = new InMemorySearchGateway();
        }
        [Fact]
        public void ShouldREturnCars()
        {
            //Arrange 

            //Act
            var results = _gateway.GetCars();
            //Assert
            Assert.NotNull(results);
            Assert.Equal(2, results.Count());
        }
    }
}
