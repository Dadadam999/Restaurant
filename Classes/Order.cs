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
        public string Amount { get; set; }
        public string Tips { get; set; }
        public DateTime DateCreate { get; set; }
        public List<Dish> Dishes { get; set; } = new List<Dish>();
        public double Sales { get; }
        public string Document { get; set; }
        public bool isArchive { get; set; } = false;

        public Order()
        {
            Id = Guid.NewGuid();
        }
    }
}
