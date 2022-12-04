using NUnit.Framework;

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
    }
}
