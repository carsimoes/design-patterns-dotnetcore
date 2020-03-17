using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_dotnetcore.Creational.Builder
{
    // here's another inheritance level
    // note there's no PersonInfoBuilder<PersonJobBuilder<PersonBirthDateBuilder<SELF>>>!

    public class PersonBirthDateBuilder<T> : PersonJobBuilder<PersonBirthDateBuilder<T>> where T : PersonBirthDateBuilder<T>
    {
        public T Born(DateTime dateOfBirth)
        {
            person.DateOfBirth = dateOfBirth;
            return (T)this;
        }
    }
}
