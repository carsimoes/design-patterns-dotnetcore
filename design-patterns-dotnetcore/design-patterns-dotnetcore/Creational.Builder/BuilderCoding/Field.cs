using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_dotnetcore.Creational.Builder.BuilderCoding
{
    class Field
    {
        public string Type, Name;

        public override string ToString()
        {
            return $"public {Type} {Name}";
        }
    }
}
