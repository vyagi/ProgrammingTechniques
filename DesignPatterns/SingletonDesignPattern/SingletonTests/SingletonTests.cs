using System;
using System.Threading.Tasks;
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
            s.CreatedAt.Should().BeCloseTo(DateTime.Now, 1000);
        }

        [Fact]
        public void Can_create_only_one_instance()
        {
            var s1 = Singleton.GetInstance();
            var s2 = Singleton.GetInstance();

            ReferenceEquals(s1, s2).Should().BeTrue();
        }

        [Fact]
        public void There_is_only_one_instance_in_multithreaded_env()
        {
            Singleton s1 = null, s2 = null;

            Task task1 = Task.Factory.StartNew(() => s1 = Singleton.GetInstance());
            Task task2 = Task.Factory.StartNew(() => s2 = Singleton.GetInstance());

            Task.WaitAll(task1, task2);

            ReferenceEquals(s1, s2).Should().BeTrue();
        }
    }
}
