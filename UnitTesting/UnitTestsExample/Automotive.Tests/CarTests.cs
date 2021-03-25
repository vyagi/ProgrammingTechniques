using FluentAssertions;
using Xunit;

namespace Automotive.Tests
{
    public class CarTests
    {
        [Fact]
        public void Can_create_a_valid_car_and_its_properties_are_correct()
        {
            var car = new Car("Opel", 60, 6);

            car.Brand.Should().Be("Opel");
            car.FuelConsumptionPer100Km.Should().Be(6);
            car.TankCapacity.Should().Be(60);
            car.CurrentFuelLevel.Should().Be(0);
            car.KilometerCounter.Should().Be(0);
            car.TripKilometerCounter.Should().Be(0);

            Car.CarsCreated.Should().BeGreaterThan(0);
        }

        [Fact]
        public void After_tanking_the_fuel_level_is_correct()
        {
            var car = new Car("Opel", 60, 6);

            car.Tank(50);

            car.CurrentFuelLevel.Should().Be(50);

            car.Tank(6);

            car.CurrentFuelLevel.Should().Be(56);

            car.Tank(10);

            car.CurrentFuelLevel.Should().Be(60);
        }
    }
}
