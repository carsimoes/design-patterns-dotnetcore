using design_patterns_dotnetcore.SOLID.OpenClosed.Principle;
using design_patterns_dotnetcore.SOLID.OpenClosed.Principle.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_dotnetcore.Solid.OpenClosed.Principle
{
    // combinator
    public class AndSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> first, second;

        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this.first = first ?? throw new ArgumentNullException(paramName: nameof(first));
            this.second = second ?? throw new ArgumentNullException(paramName: nameof(second));
        }

        public bool IsSatisfied(Product p)
        {
            return first.IsSatisfied(p) && second.IsSatisfied(p);
        }
    }
}
