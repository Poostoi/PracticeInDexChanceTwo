using System;

namespace ObjectLibrary
{
    public class Item
    {
        public string Name { get; private set; }
        public int Number { get; private set; }
        public DateTime Date { get; private set; }
        public bool Exist { get; private set; }

        public Item(string name, int number, DateTime date, bool exist)
        {
            Name = name;
            Number = number;
            Date = date;
            Exist = exist;
        }
    }
}