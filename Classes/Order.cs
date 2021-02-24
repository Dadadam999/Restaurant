using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    [Serializable]
    public class Order
    {
        public Guid Id { get; }
        public Guid IdClient { get; set; }
        public Guid IdWaiter { get; set; }
        public Decimal Amount
        {
            get
            {
                Decimal tmpAmount = Dishes.Count > 0 ? Dishes.Sum(x => x.Amount) : 0;
                return tmpAmount > Sales ? tmpAmount - Sales : 0;
            }
        }
        public Decimal Tips { get; set; } = 0;
        public Decimal Sales { get { return Dishes.Count > 0 ? Dishes.Sum(x => x.Sales) : 0; } }
        public string DateCreate { get; set; }
        public List<Dish> Dishes { get; set; } = new List<Dish>();
        public string Document { get; set; }
        public bool isArchive { get; set; } = false;

        public Order()
        {
            Id = Guid.NewGuid();
        }
    }
}
