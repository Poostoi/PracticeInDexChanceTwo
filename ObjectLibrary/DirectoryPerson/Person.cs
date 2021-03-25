using System;

namespace ObjectLibrary.DirectoryPerson
{
    public enum Town
    {
        Dubossari,
        Tiraspol,
        Benderi,
        Grigoriopol
    }
    public class Person: IPerson
    {
        private readonly string _fullName;
        private readonly string _dateOfBirth;
        private readonly Town _placeOfBirth;
        private readonly int _numberID;
        
        public Person(string fullName,string dateOfBirth, Town placeOfBirth, int numberId)
        {
            _fullName = fullName;
            _dateOfBirth = dateOfBirth;
            _placeOfBirth = placeOfBirth;
            _numberID = numberId;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Person))
                return false;
            var person = (Person) obj;
            return this._fullName == person._fullName &&
                   this._dateOfBirth == person._dateOfBirth &&
                   this._numberID == person._numberID &&
                   this._placeOfBirth ==person._placeOfBirth;
        }

        public override int GetHashCode()
        {
            return _numberID+2;
        }

        public override string ToString()
        {
            return _fullName;
        }

        public static bool operator ==(Person firstPerson, Person secondPerson)
        {
            return  firstPerson.Equals(secondPerson);
            
        }

        public static bool operator !=(Person firstPerson, Person secondPerson)
        {
            return !(firstPerson == secondPerson);
        }
    }
}