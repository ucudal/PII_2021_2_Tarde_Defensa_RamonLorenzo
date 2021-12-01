using System;

namespace Ucu.Poo.Defense
{
    public class PromoCode : IOfferItem
    {
        public Residue Residue { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        private string code {get;set;}
        private int amount;
        public int SubTotal
        {
            get
            {
                return this.amount;
            }
            set
            {
                this.amount = value;
            }
        }
        public PromoCode(string code, int amount)
        {
            
            if(amount >= 0)
            {
                throw new ArgumentException("El descuento no puede ser mayor a 0");
            }
            this.code = code;
            this.SubTotal = amount;
        }
        
    }
}