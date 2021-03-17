using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace ObjectLibrary
{
    public class GenerateItem
    {
        private Item[] _arrayItem = new Item[100];

        public void Generate(string[] name)
        {
            Random random = new Random();
            for (int i = 0; i < _arrayItem.Length; i++)
            {
                _arrayItem[i] = new Item(name[random.Next(0, name.Length)], random.Next(0, 500),
                    new DateTime(random.Next(1583, 2021), random.Next(1, 12), random.Next(1, 28)),
                    Convert.ToBoolean(random.Next(0, 1)));
            }
        }

        public void ConsoleOutput(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine("Name: {0},\nDate: {1},\nAmount:{2},\nExist: {3}.", _arrayItem[i].Name,
                    _arrayItem[i].Date, _arrayItem[i].Number, _arrayItem[i].Exist);
            }
        }
        public IEnumerable SortingByNickname()
        {
            var arraySortByNickname = _arrayItem.GroupBy(_arrayItem => _arrayItem.Name);
            return arraySortByNickname;
        }
        public IEnumerable<Item> InsertNicknameWhereHelge()
        {
            IEnumerable<Item> arraySortByNickname = _arrayItem.Where(item => item.Name == "Helge");
            return arraySortByNickname;
        }
    }
}