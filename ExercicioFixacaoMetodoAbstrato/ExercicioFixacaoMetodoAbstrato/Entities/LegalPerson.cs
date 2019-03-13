using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacaoMetodoAbstrato.Entities
{
    class LegalPerson : Person
    {
        public int EmployeeNumber { get; set; }

        public LegalPerson(string name, double rendaAnual, int employeeNumber) : base(name, rendaAnual)
        {
            EmployeeNumber = employeeNumber;
        }

        public override double Tax()
        {
            if (EmployeeNumber > 10)
            {
                return RendaAnual * 0.14;
            }
            else {
                return RendaAnual * 0.16;
            }
        }
    }
}
