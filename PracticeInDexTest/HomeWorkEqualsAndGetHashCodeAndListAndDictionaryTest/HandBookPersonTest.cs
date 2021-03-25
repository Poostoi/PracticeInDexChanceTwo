using NUnit.Framework;
using ObjectLibrary.DirectoryPerson;
using System;
using System.Collections.Generic;
using System.Diagnostics;



namespace PracticeInDexTest.HomeWorkEqualsAndGetHashCodeAndListAndDictionaryTest
{
    [TestFixture]
    public class HandBookPersonTest
    {
        private HandBookPerson _directory;
        private HandBookPerson _directoryBad;
        private Stopwatch stopwatch = new Stopwatch();
        private Stopwatch stopwatchBad = new Stopwatch();
        private  Person _person = new Person("Бербат Григорий", "22.03.2020", Town.Benderi, -20);

        private readonly string[] _fullName = new[]
        {
            "Виктор Викторович", "Генадий Алексеевич",
            "Александр Александрович", "Дмитрий Петрович",
            "Алексей Иванов","Артём Смирнов", "Вадим Кузнецов",
            "Владимир Попов","Валентин Васильев","Данил Петров",
            "Денис Соколов"
        };

        public string GenerateDateBirth()
        {
            Random random = new Random();
            int day = random.Next(1, 366);
            int mounth = random.Next(1, 13);
            int year = random.Next(1700, 2021);
            return $"{day}.{mounth}.{year}";
        }


        private Town GenerateTown()
        {
            var rand = new Random();
            switch (rand.Next(0, 4))
            {
                case 0:
                    return Town.Dubossari;
                case 1:
                    return Town.Benderi;
                case 2:
                    return Town.Grigoriopol;
                case 3:
                    return Town.Tiraspol;
                default:
                    return Town.Benderi;
            }
        }

        private PlaceWork GeneratePlaceWork()
        {
            var rand = new Random();
            switch (rand.Next(0, 5))
            {
                case 0:
                    return PlaceWork.Dex;
                case 1:
                    return PlaceWork.Квинт;
                case 2:
                    return PlaceWork.Мясокомбинат;
                case 3:
                    return PlaceWork.Птицефабрика;
                case 4:
                    return PlaceWork.Университет;
                default:
                    return PlaceWork.Отсутствует;
            }
        }

        private Person GeneratePerson()
        {
            var rand = new Random();
            Person person = new Person(_fullName[rand.Next(0, _fullName.Length)],
                GenerateDateBirth(),
                GenerateTown(),
                rand.Next(100000, 1000000));
            return person;
        }

        //[SetUp]
        public void GenerateDirectory()
        {
            var rand = new Random();
            int number = rand.Next(300000, 500000);
            
            _directory = new HandBookPerson();
            _directoryBad = new HandBookPerson();
            for (int i = 0; i < number; i++)
            {
                _directory.AddHandBookPerson(GeneratePerson(), GeneratePlaceWork());
                _directoryBad.AddHandBookPerson(GeneratePerson(), GeneratePlaceWork());
            }
            
        }

        public void GenerateDirectory(int number, bool flag)
        {
            var random = new Random();
            stopwatch.Reset();
            stopwatchBad.Reset();
            _directory = new HandBookPerson();
            _directoryBad = new HandBookPerson();
            for (int i = 0; i < number; i++)
            {
                if (flag)
                {
                    stopwatch.Start();
                    _directory.AddHandBookPerson(GeneratePerson(), GeneratePlaceWork());
                    stopwatch.Stop();
                }
                else
                {
                    stopwatchBad.Start();
                    _directoryBad.AddHandBookPerson(GeneratePerson(), GeneratePlaceWork());
                    stopwatchBad.Stop();
                }
            }
            _directory.AddHandBookPerson(_person, GeneratePlaceWork());
            _directoryBad.AddHandBookPerson(_person, GeneratePlaceWork());
        }

        public void FindPersonInDirectory( bool flag)
        {
            stopwatch.Reset();
            stopwatchBad.Reset();
            if (flag)
            {
                stopwatch.Start();
                _directory.GetPlaceWork(_person);
                stopwatch.Stop();
            }
            else
            {
                stopwatchBad.Start();
                Console.WriteLine(_person.ToString());
                _directoryBad.GetPlaceWork(_person);
                stopwatchBad.Reset();
            }

            
        }

        [Test]
        public void GetPlaceWorkTryToGetByEmptyKeyTrue()
        {
            //Arrange
            var person = GeneratePerson();
            //Act
            var result = _directory.GetPlaceWork(person);
            //Assert
            Assert.True(result == PlaceWork.Отсутствует);
        }

        [Test]
        public void TimeMeasurementFunctionAddAndContain()
        {
            List<int> list = new List<int>() {100,10000,20000};
            foreach (var l in list)
            {
                _directory = null;
                _directoryBad = null;
                Console.WriteLine("Результат работы при добавлении: ");
                GenerateDirectory(l, true);
                Console.WriteLine("Работа при {0} значениях, нормальная реализация: {1}", l, stopwatch.Elapsed);
                GenerateDirectory(l, false);
                Console.WriteLine("Работа при {0} значениях, плохая реализация: {1}", l, stopwatchBad.Elapsed);
                Console.WriteLine("\nРезультат работы при извлечении: ");
                FindPersonInDirectory(true);
                Console.WriteLine("Работа при {0} значениях, нормальная реализация: {1}", l, stopwatch.Elapsed);
                FindPersonInDirectory(false);
                Console.WriteLine("Работа при {0} значениях, плохая реализация: {1}\n", l, stopwatchBad.Elapsed);
            }

            
        }
    }
}