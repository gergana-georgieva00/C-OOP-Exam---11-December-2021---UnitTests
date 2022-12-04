using NUnit.Framework;
using System;

namespace Gyms.Tests
{
    public class GymsTests
    {
        private Athlete athlete;
        private Gym gym;

        [SetUp]
        public void Setup()
        {
            athlete = new Athlete("AthleteName");
            gym = new Gym("GymName", 70);
        }

        [Test]
        public void NameGetterWorks()
        {
            Assert.That(gym.Name, Is.EqualTo("GymName"));
        }

        [Test]
        public void NameCannotBeNull()
        {
            Assert.Throws<ArgumentNullException>(() => gym = new Gym("", 70));
        }
    }
}
