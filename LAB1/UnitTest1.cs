using System;
using Xunit;
using Bogus;
using Moq;

namespace LAB1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Faker<Address> addressBogus = new Faker<Address>();
            addressBogus.RuleFor(x => x.Description, y => y.Address.FullAddress())
            addressBogus.RuleFor(x => x.Number, y => y.Address.CountryCode());
            var personBogus = new Faker<Person>();
            personBogus.RuleFor(x => x.Name, y => y.Person.FirstName);
            personBogus.RuleFor(x => x.Surname, y => y.Person.LastName);
            personBogus.RuleFor(x => x.Birthday, y => y.Person.DateOfBirth);
            personBogus.RuleFor(x => x.Address, y => addressBogus.Generate());
            var hundredPpl = personBogus.Generate(100);
        }
    }
}
