using System.Linq;
using NUnit.Framework;
using ObjectLibrary;

namespace PracticeInDexTest
{
    public class HomeWorkIQueryableTest
    {
        private readonly string[] _nicknameArray =
        {
            "Poostoi", "Pustoi", "P00stoi", "Pystoi", "Helge", "Helgeir"
        };


        public GenerateItem CreateArrayItem()
        {
            GenerateItem generateItem = new GenerateItem();
            generateItem.Generate(_nicknameArray);
            return generateItem;
        }

        public GenerateItem CreateArrayItem(string[] name)
        {
            GenerateItem generateItem = new GenerateItem();
            generateItem.Generate(name);
            return generateItem;
        }


        public void SortingByNicknameTest()
        {
            var items = CreateArrayItem();
        }

        [Test]
        public void InsertNicknameWhereHelgeTrue()
        {
            var items = CreateArrayItem(new string[] {"Helge", "Hello", "Hero"});
            var necessaryItem = items.InsertNicknameWhereHelge().Where(item => item.ToString() == "Helge");
            Assert.NotNull(necessaryItem);
        }
    }
}