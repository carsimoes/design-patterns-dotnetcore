using design_patterns_dotnetcore.SOLID.OpenClosed.Principle;
using design_patterns_dotnetcore.SOLID.OpenClosed.Principle.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_dotnetcore.Solid.OpenClosed.Principle
{
    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var i in items)
                if (spec.IsSatisfied(i))
                    yield return i;
        }
    }
}
