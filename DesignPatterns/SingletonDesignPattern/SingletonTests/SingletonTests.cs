using System;
using FluentAssertions;
using SingletonDesignPattern;
using Xunit;

namespace SingletonTests
{
    public class SingletonTests
    {
        [Fact]
        public void Can_create_an_instance()
        {
            var s = Singleton.GetInstance();

            s.Should().NotBeNull();
            s.CreatedAt.Should().BeCloseTo(DateTime.Now);
        }

        [Fact]
        public void Can_create_only_one_instance()
        {
            var s1 = Singleton.GetInstance();
            var s2 = Singleton.GetInstance();

            ReferenceEquals(s1, s2).Should().BeTrue();
        }
    }
}
