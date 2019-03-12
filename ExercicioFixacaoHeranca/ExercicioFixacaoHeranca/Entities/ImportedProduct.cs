﻿using System.Globalization;

namespace ExercicioFixacaoHeranca.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice() {
            return base.Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return Name + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) 
                + " (Customs fee: $ " + CustomsFee + ")";
        }
    }
    
}
