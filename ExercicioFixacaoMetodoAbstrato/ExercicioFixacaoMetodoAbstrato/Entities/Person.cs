using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacaoMetodoAbstrato.Entities
{
    abstract class Person
    {
        public string Name { get; set; }

        public double RendaAnual { get; set; }

        public Person(string name, double rendaAnual)
        {
            Name = name;
            RendaAnual = rendaAnual;
        }

        public abstract double Tax();

    }
}
