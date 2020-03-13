using design_patterns_dotnetcore.SOLID.Single.Responsibility.Principle;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace design_patterns_dotnetcore.Solid.Single.Responsibility.Principle
{

    // handles the responsibility of persisting objects
    public class Persistence
    {
        public void SaveToFile(Journal journal, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
                File.WriteAllText(filename, journal.ToString());
        }
    }
}
