using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
   [Serializable]
   public class DataBase
    {
        public List<Client> Clients { get; set; } = new List<Client>();
        public List<Dish> Dishes { get; set; } = new List<Dish>();
        public List<Menu> Menus { get; set; } = new List<Menu>();
        public List<Order> Orders { get; set; } = new List<Order>();
        public List<Waiter> Waiters { get; set; } = new List<Waiter>();
    }
}
