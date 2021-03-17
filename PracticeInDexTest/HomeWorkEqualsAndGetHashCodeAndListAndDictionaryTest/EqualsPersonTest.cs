using System;
using System.Runtime.Serialization.Json;
using NUnit.Framework;
using NUnit.Framework.Internal;
using ObjectLibrary.DirectoryPerson;

namespace PracticeInDexTest.HomeWorkEqualsAndGetHashCodeAndListAndDictionaryTest
{
    [TestFixture]
    public class EqualsPersonTest
    {
        private Person person;
        [SetUp]
        public void CreatePerson()
        {
            person = new Person("Нагиев Григорий Андреевич", "10.03.1990",
                Town.Dubossari, 12345);
        }

        [Test]
        public void EqualsCreateClonePersonCheckAndCreateNoCloneCheckTrue()
        {
            //Arrange
            var clonePerson = new Person("Нагиев Григорий Андреевич", "10.03.1990",
                Town.Dubossari, 12345);
            var noClonePerson = new Person("Нагиев Григорий Андреевич", "10.03.1990",
                Town.Dubossari, 12346);
            //Act    
            var check = person.Equals(clonePerson) && !person.Equals(noClonePerson);
            //Assert     
            Assert.True(check);
        }
        [Test]
        public void GetHashCodeCheckFirstPropertyGetHashCodeTrue()
        {
            //Act
            var check = person.GetHashCode() == person.GetHashCode() ;
            //Assert
            Assert.True(check);
        }

        [Test]
        public void GetHashCodeCheckSecondPropertyGetHashCodeTrue()
        {
            //Arrange
            var clonePerson = new Person("Нагиев Григорий Андреевич", "10.03.1990",
                Town.Dubossari, 12345);
            var noClonePerson = new Person("Нагиев Григорий Андреевич", "10.03.1990",
                Town.Dubossari, 12346);
            //Act
            var check = person.GetHashCode() == clonePerson.GetHashCode() &&
                        person.GetHashCode() != noClonePerson.GetHashCode();
            //Assert
            Assert.True(check);
        }
    }
}