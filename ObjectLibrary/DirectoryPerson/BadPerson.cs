namespace ObjectLibrary.DirectoryPerson
{
    public class BadPerson : Person
    {
        public BadPerson(string fullName, string dateOfBirth, Town placeOfBirth, int numberId) : base(fullName,
            dateOfBirth, placeOfBirth, numberId)
        {
        }

        public override int GetHashCode()
        {
            return 5;
        }
    }
}