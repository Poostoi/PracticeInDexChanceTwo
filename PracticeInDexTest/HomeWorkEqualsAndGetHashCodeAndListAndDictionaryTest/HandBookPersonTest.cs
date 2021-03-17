using NUnit.Framework;
using ObjectLibrary.DirectoryPerson;
using System;
using System.Diagnostics;

namespace PracticeInDexTest.HomeWorkEqualsAndGetHashCodeAndListAndDictionaryTest
{
    [TestFixture]
    public class HandBookPersonTest
    {
        private HandBookPerson _directory;

        private readonly string[] _fullName = new[]
        {
            "Виктор Викторович", "Генадий Алексеевич",
            "Александр Александрович", "Дмитрий Петрович"
        };
        private readonly string[] _dateBirth = new[]
        {
            "01.01.2000", "04.05.1979",
            "10.04.1998", "30.12.1950"
        };

        public Town GenerateTown()
        {
            var rand = new Random();
            switch (rand.Next(0, 4))
            {
                case 0:
                    return Town.Dubossari; 
                    break;
                case 1:
                    return Town.Benderi; 
                    break;
                case 2:
                    return Town.Grigoriopol; 
                    break;
                case 3:
                    return Town.Tiraspol; 
                    break;
                default:
                    return Town.Benderi;
                    break;
            }
        }

        public Person GeneratePerson()
        {
            
            var rand = new Random();
            Person person = new Person(_fullName[rand.Next(0,_fullName.Length)],
                _dateBirth[rand.Next(0,_dateBirth.Length)],
                GenerateTown(),
                rand.Next(10000,100000));
            return person;

        }

        [SetUp]
        public void GenerateDirectory()
        {
            var rand = new Random();
            int number = rand.Next(30, 50);
            for (int i = 0; i < number; i++)
            {
                _directory.AddHandBookPerson(GeneratePerson());
            }
        }
    }
}