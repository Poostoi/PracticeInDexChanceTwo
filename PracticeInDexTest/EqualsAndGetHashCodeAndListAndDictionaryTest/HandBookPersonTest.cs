using System;
using System.Collections.Generic;
using System.Diagnostics;
using NUnit.Framework;
using ObjectLibrary.DirectoryPerson;

namespace PracticeInDexTest.EqualsAndGetHashCodeAndListAndDictionaryTest
{
    [TestFixture]
    public class HandBookPersonTest
    {
        private HandBookPerson _directory;
        private HandBookPerson _directoryBad;
        private Stopwatch _stopwatch = new Stopwatch();
        private Stopwatch _stopwatchBad = new Stopwatch();
        IPerson _person;
        

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

        private IPerson GeneratePerson(bool flag)
        {
            IPerson person;
            var rand = new Random();
            if (flag)
            {
                person = new Person(_fullName[rand.Next(0, _fullName.Length)],
                GenerateDateBirth(),
                GenerateTown(),
                rand.Next(100000, 1000000));
            }
            else
            {
                person = new BadPerson(_fullName[rand.Next(0, _fullName.Length)],
                    GenerateDateBirth(),
                    GenerateTown(),
                    rand.Next(100000, 1000000));
            }

            return person;
        }
        public void GenerateDirectory(int number, bool flag)
        {
            var random = new Random();
            _stopwatch.Reset();
            _stopwatchBad.Reset();
            _directory = new HandBookPerson();
            _directoryBad = new HandBookPerson();
            _person = GeneratePerson(flag);
            for (int i = 0; i < number; i++)
            {
                if (i == 0)
                {
                    _directory.AddHandBookPerson(_person,GeneratePlaceWork());
                    _directoryBad.AddHandBookPerson(_person,GeneratePlaceWork());
                }

                if (flag)
                {
                    _stopwatch.Start();
                    _directory.AddHandBookPerson(GeneratePerson(flag), GeneratePlaceWork());
                    _stopwatch.Stop();
                }
                else
                {
                    _stopwatchBad.Start();
                    _directoryBad.AddHandBookPerson(GeneratePerson(flag), GeneratePlaceWork());
                    _stopwatchBad.Stop();
                }
            }
            
        }

        private void FindPersonInDirectory( bool flag)
        {
            _stopwatch.Reset();
            _stopwatchBad.Reset();
            
            if (flag)
            {
                _stopwatch.Start();
                _directory.GetPlaceWork(_person);
                _stopwatch.Stop();
            }
            else
            {
                _stopwatchBad.Start();
                _directoryBad.GetPlaceWork(_person);
                _stopwatchBad.Stop();
            }
        }

        [Test]
        public void GetPlaceWorkTryToGetByEmptyKeyTrue()
        {
            //Arrange
            var person = GeneratePerson(true);
            //Act
            var result = _directory.GetPlaceWork(person);
            //Assert
            Assert.True(result == PlaceWork.Отсутствует);
        }

        [Test]
        public void TimeMeasurementFunctionAddAndContain()
        {
            List<int> list = new List<int>() {100,10000,20000};
            foreach (var number in list)
            {
                _directory = null;
                _directoryBad = null;
                Console.WriteLine("Результат работы при добавлении: ");
                GenerateDirectory(number, true);
                Console.WriteLine("Работа при {0} значениях, нормальная реализация: {1}", number, _stopwatch.Elapsed);
                GenerateDirectory(number, false);
                Console.WriteLine("Работа при {0} значениях, плохая реализация: {1}", number, _stopwatchBad.Elapsed);
                Console.WriteLine("\nРезультат работы при извлечении: ");
                FindPersonInDirectory(true);
                Console.WriteLine("Работа при {0} значениях, нормальная реализация: {1}", number, _stopwatch.Elapsed);
                FindPersonInDirectory(false);
                Console.WriteLine("Работа при {0} значениях, плохая реализация: {1}\n", number, _stopwatchBad.Elapsed);
            }
        }
    }
}