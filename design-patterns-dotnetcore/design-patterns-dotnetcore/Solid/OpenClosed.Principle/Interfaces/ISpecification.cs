using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_dotnetcore.SOLID.OpenClosed.Principle.Interfaces
{
    // we introduce two new interfaces that are open for extension
    public interface ISpecification<T>
    {
        bool IsSatisfied(Product p);
    }
}
