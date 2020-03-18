using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_dotnetcore.Creational.Builder.BuilderCoding
{
    class Class
    {
        public string Name;
        public List<Field> Fields = new List<Field>();

        public Class()
        {

        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"public class {Name}").AppendLine("{");
            foreach (var f in Fields)
                sb.AppendLine($"  {f};");
            sb.AppendLine("}");
            return sb.ToString();
        }
    }
}
