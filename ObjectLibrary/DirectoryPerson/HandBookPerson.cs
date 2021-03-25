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
        private Dictionary<IPerson, PlaceWork> _directory = new Dictionary<IPerson, PlaceWork>{};
        
        
        public void AddHandBookPerson(IPerson key, PlaceWork placeWork)
        {
            if (key == null|| placeWork == null)
                throw new Exception("Не был введён ключ или место работы");
            _directory.Add(key, placeWork);
        }

        public PlaceWork GetPlaceWork(IPerson person)
        {
            
            if (_directory.ContainsKey(person))
                return _directory[person];
            return PlaceWork.Отсутствует;
        }

    }
}