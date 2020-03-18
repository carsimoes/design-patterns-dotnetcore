﻿using design_patterns_dotnetcore.SOLID.Single.Responsibility.Principle;
using System;

namespace design_patterns_dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {

            Creational.Builder.BuilderCoding.Demo demo = new Creational.Builder.BuilderCoding.Demo();
            demo.Init();
        }
    }
}
