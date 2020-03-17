using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_dotnetcore.Creational.Builder.PersonExample
{
    class Demo
    {
        public void Init()
        {
            var me = Person.New
               .Called("Dmitri")
               .WorksAsA("Quant")
               .Born(DateTime.UtcNow)
               .Build();

            Console.WriteLine(me);
        }
    }
}
