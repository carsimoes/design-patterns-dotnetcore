using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_dotnetcore.SOLID.OpenClosed.Principle.Interfaces
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
}
