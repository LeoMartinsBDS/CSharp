using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacaoMetodoAbstrato.Entities
{
    class PhysicalPerson : Person
    {
        public double  HealthSpending { get; set; }

        public PhysicalPerson(string name, double rendaAnual, double healthSpending) : base(name, rendaAnual)
        {
            HealthSpending = healthSpending;
        }

        public override double Tax()
        {
            double tax = 0.0;
            if (RendaAnual < 20000)
            {
                tax = RendaAnual * 0.15 - HealthSpending * 0.5;
            }
            else {
                tax = RendaAnual * 0.25 - HealthSpending * 0.5;
            }
            

            return tax;
        }
    }
}
