using FluentAssertions;
using Xunit;

namespace Zoology.Tests
{
    public class AnimalTests
    {
        [Fact]
        public void Factory_returns_instance_of_correct_concrete_type()
        {
            var cat = new AnimalFactory().Create("Cat");
            var dog = new AnimalFactory().Create("Dog");
            var fish = new AnimalFactory().Create("Fish");
            var unknown = new AnimalFactory().Create("Not exsistent");

            cat.Should().BeOfType<Cat>();
            dog.Should().BeOfType<Dog>();
            fish.Should().BeOfType<Fish>();
            unknown.Should().BeNull();
        }
    }
}
