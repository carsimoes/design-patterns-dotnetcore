using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_dotnetcore.Creational.Builder.BuilderCoding
{
    class Demo
    {
        public void Init()
        {
            var cb = new CodeBuilder("Person")
                .AddField("Name", "string")
                .AddField("Age", "int");

            Console.WriteLine(cb);
        }
    }
}
