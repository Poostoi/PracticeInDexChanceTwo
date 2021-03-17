using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectLibrary.DirectoryPerson
{
    public enum PlaceWork
    {
        Мясокомбинат,
        Птицефабрика, 
        Квинт,
        Университет,
        Dex,
        Отсутствует
    }

    public class HandBookPerson
    {
        private Dictionary<Person, PlaceWork> _directory = new Dictionary<Person, PlaceWork>{};
        
        
        public void AddHandBookPerson(Person key, PlaceWork placeWork)
        {
            if (key == null|| placeWork == null)
                throw new Exception("Не был введён ключ или место работы");
            _directory.Add(key, placeWork);
        }

        public PlaceWork GetPlaceWork(Person person)
        {
            if (_directory.ContainsKey(person))
                return _directory[person];
            else return PlaceWork.Отсутствует;
        }

    }
}