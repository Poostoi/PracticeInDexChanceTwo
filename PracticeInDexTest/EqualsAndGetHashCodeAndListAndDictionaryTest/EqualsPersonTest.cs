using NUnit.Framework;
using ObjectLibrary.DirectoryPerson;

namespace PracticeInDexTest.EqualsAndGetHashCodeAndListAndDictionaryTest
{
    [TestFixture]
    public class EqualsPersonTest
    {
        private Person _person;
        [SetUp]
        public void CreatePerson()
        {
            _person = new Person("Нагиев Григорий Андреевич", "10.03.1990",
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
            var check = _person.Equals(clonePerson) && !_person.Equals(noClonePerson);
            //Assert     
            Assert.True(check);
        }
        [Test]
        public void GetHashCodeCheckFirstPropertyGetHashCodeTrue()
        {
            //Act
            var check = _person.GetHashCode() == _person.GetHashCode() ;
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
            var check = _person.GetHashCode() == clonePerson.GetHashCode() &&
                        _person.GetHashCode() != noClonePerson.GetHashCode();
            //Assert
            Assert.True(check);
        }
    }
}