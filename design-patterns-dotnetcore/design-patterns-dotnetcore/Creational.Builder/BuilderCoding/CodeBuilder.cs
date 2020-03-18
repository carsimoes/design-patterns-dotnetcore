using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_dotnetcore.Creational.Builder.BuilderCoding
{
    class CodeBuilder
    {
        public CodeBuilder(string rootName)
        {
            theClass.Name = rootName;
        }

        public CodeBuilder AddField(string name, string type)
        {
            theClass.Fields.Add(new Field { Name = name, Type = type });
            return this;
        }

        public override string ToString()
        {
            return theClass.ToString();
        }

        private Class theClass = new Class();
    }
}

