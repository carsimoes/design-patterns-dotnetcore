using design_patterns_dotnetcore.SOLID.OpenClosed.Principle;
using design_patterns_dotnetcore.SOLID.OpenClosed.Principle.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_dotnetcore.Solid.OpenClosed.Principle
{
    public class SizeSpecification : ISpecification<Product>
    {
        private Size size;

        public SizeSpecification(Size size)
        {
            this.size = size;
        }

        public bool IsSatisfied(Product p)
        {
            return p.Size == size;
        }
    }
}
