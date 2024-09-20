using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bogus;

namespace BusinessTier
{
    public static class clsDataGeneratorBogus
    {
        public static void GenerateClientsAccounts()
        {
            Random Rand = new Random();

            Randomizer.Seed = new Random(Rand.Next());

            var personFaker = new Faker<clsPerson>()
                .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                .RuleFor(u => u.LastName, f => f.Name.LastName())
                .RuleFor(u => u.Phone, f => f.Phone.PhoneNumber())
                .RuleFor(u => u.Email, f => f.Internet.Email())
                .RuleFor(u => u.CountryID, f => f.Random.Int(1, 6))
                .RuleFor(u => u.DateOfBirth, f => f.Date.Past(30))
                .RuleFor(u => u.Address, f => f.Address.StreetAddress());

            var FakePersons = personFaker.Generate(150);

            var accountsFaker = new Faker<clsClientAccount>()
                .RuleFor(u => u.Balance, f => f.Random.Int(13000, 12500000))
                .RuleFor(u => u.CreationDate, f => f.Date.Soon());

            var FakeAccounts = accountsFaker.Generate(150);

            for (int i = 0; i < 150; i++)
            {
                clsPerson Person = FakePersons[i];

                Person.Save();

                clsClientAccount acc = FakeAccounts[i];
                acc.ActivationStatus = true;

                acc.PersonID = Person.PersonID;

                Random rand = new Random();

                acc.Save();

                acc.AddAmountToBalance(rand.Next(13000, 12500000));
            }

        }
    }
}
