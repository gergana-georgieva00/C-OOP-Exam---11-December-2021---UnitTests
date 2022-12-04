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

        [Test]
        public void CapacityGetterWorks()
        {
            Assert.That(gym.Capacity, Is.EqualTo(70));
        }

        [Test]
        public void CapacityCannotNegativeNumber()
        {
            Assert.Throws<ArgumentException>(() => gym = new Gym("GymName", -1));
        }

        [Test]
        public void CountGetterWorks()
        {
            Assert.That(gym.Count, Is.EqualTo(0));
        }


        [Test]
        public void AddAthleteOnFullGymShouldThrow()
        {
            gym = new Gym("name", 1);
            gym.AddAthlete(athlete);
            Assert.Throws<InvalidOperationException>(() => gym.AddAthlete(athlete));
        }

        [Test]
        public void RemoveAthleteWithNonExistentAthleteShouldThrow()
        {
            Assert.Throws<InvalidOperationException>(() => gym.RemoveAthlete("name"));
        }

        [Test]
        public void RemoveAthleteWorks()
        {
            gym.AddAthlete(athlete);
            gym.RemoveAthlete("AthleteName");
            Assert.That(gym.Count, Is.EqualTo(0));
        }

        [Test]
        public void InjureAthleteWithNonExistentAthleteShouldThrow()
        {
            Assert.Throws<InvalidOperationException>(() => gym.RemoveAthlete("name"));
        }
    }
}
