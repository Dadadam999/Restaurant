using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    [Serializable]
    public class Dish
    {
        public Guid Id { get; }
        public Guid IdMenu { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Quality { get; set; }
        public Bitmap Picture { get; set; } = Properties.Resources.вш;
        public Decimal Amount { get; set; } = 0;
        public Decimal Sales { get; set; } = 0;
        public Decimal AmountSales { get { return ((Amount - Sales) < 0) ? 0 : Amount - Sales; } }

        public Dish()
        {
            Id = Guid.NewGuid();
        }
    }
}
