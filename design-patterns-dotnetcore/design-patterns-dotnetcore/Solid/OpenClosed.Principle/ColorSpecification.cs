using design_patterns_dotnetcore.SOLID.OpenClosed.Principle.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_dotnetcore.SOLID.OpenClosed.Principle
{
    public class ColorSpecification : ISpecification<Product>
    {
        private Color color;

        public ColorSpecification(Color color)
        {
            this.color = color;
        }

        public bool IsSatisfied(Product p)
        {
            return p.Color == color;
        }
    }
}
