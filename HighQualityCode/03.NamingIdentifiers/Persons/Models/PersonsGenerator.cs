namespace Persons.Models
{
    using Persons.Models.Enums;

    public static class PersonsGenerator
    {
        private const int DividerForId = 2;
        private const string FemaleName = "Jane Doe";
        private const string MaleName = "John Doe";

        public static Person CreatePerson(int numberIdToGenerateGenderOn)
        {
            if (numberIdToGenerateGenderOn % DividerForId == 0)
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