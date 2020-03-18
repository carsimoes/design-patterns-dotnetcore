using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_dotnetcore.Creational.Builder.BuilderFacets
{
    class Demo
    {
        void Init()
        {
            var pb = new PersonBuilder();
            Person person = pb
              .Lives
                .At("123 London Road")
                .In("London")
                .WithPostcode("SW12BC")
              .Works
                .At("Fabrikam")
                .AsA("Engineer")
                .Earning(123000);
        }
    }
}
