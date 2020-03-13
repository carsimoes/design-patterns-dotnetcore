using design_patterns_dotnetcore.SOLID.Single.Responsibility.Principle;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace design_patterns_dotnetcore.Solid.Single.Responsibility.Principle
{
    public class Demo
    {
        public void Run()
        {
            var j = new Journal();
            j.AddEntry("I cried today.");
            j.AddEntry("I ate a bug.");

            var p = new Persistence();
            var filename = @"c:\temp\journal.txt";
            p.SaveToFile(j, filename);
            Process.Start(filename);
        }
    }
}
