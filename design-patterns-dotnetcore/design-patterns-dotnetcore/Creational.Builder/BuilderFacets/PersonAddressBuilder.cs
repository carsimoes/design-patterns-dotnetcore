using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_dotnetcore.Creational.Builder.BuilderFacets
{
    public class PersonAddressBuilder : PersonBuilder
    {
        // might not work with a value type!
        public PersonAddressBuilder(Person person)
        {
            this.person = person;
        }

        public PersonAddressBuilder At(string streetAddress)
        {
            person.StreetAddress = streetAddress;
            return this;
        }

        public PersonAddressBuilder WithPostcode(string postcode)
        {
            person.Postcode = postcode;
            return this;
        }

        public PersonAddressBuilder In(string city)
        {
            person.City = city;
            return this;
        }

    }
}
