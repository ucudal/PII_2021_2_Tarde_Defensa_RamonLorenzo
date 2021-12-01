using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ucu.Poo.Defense
{
    public class Offer
    {
        public DateTime EndDate { get; set; }

        public IReadOnlyCollection<OfferItem> Items
        {
            get
            {
                return new ReadOnlyCollection<OfferItem>(this.items);
            }
        }

        private IList<OfferItem> items = new List<OfferItem>();

        public Offer(DateTime endDate)
        {
            this.EndDate = endDate;
        }

        public void AddItem(OfferItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(OfferItem item)
        {
            this.items.Remove(item);
        }
        public string AsText()
        {
            StringBuilder imprimir = new StringBuilder();
            foreach(OfferItem item in items)
            {
                imprimir.Append(item.Residue.Name);
                imprimir.Append(item.Quantity.ToString());
                imprimir.Append(item.Price.ToString());
            }
            return imprimir.ToString();
        }
    }
}