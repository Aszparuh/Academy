namespace Persons.Models
{
    using Persons.Models.Enums;
    public static class PersonsGenerator
    {
        private const int DividerForId = 2;
        const string FemaleName = "Jane Doe";
        const string MaleName = "John Doe";

        public static Person CreatePerson(int numberIdToGenerateGenderOn)
        {
            if (numberIdToGenerateGenderOn % 2 == 0)
            {
                return new Person(MaleName, Gender.Male);
            }
            else
            {
                return new Person(FemaleName, Gender.Female);
            }
        }
    }
}