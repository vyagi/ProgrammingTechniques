using System;
using FluentAssertions;
using Xunit;

namespace Automotive.Tests
{
    public class CarTests
    {
        [Fact]
        public void Can_create_a_valid_car_and_its_properties_are_correct()
        {
            //Arrange
            //Act
            var car = new Car("Opel", 60, 6);

            car.Brand.Should().Be("Opel");
            car.FuelConsumptionPer100Km.Should().Be(6);
            car.TankCapacity.Should().Be(60);
            car.CurrentFuelLevel.Should().Be(0);
            car.KilometerCounter.Should().Be(0);
            car.TripKilometerCounter.Should().Be(0);

            Car.CarsCreated.Should().Be(1);
        }
    }
}
