using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    [Serializable]
    public class Menu
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public string PublishDate { get; set; }
        public string UnPublichhDate { get; set; }
        public Bitmap Photo { get; set; } = Properties.Resources.restaurant_menu;

        public Menu()
        {
            Id = Guid.NewGuid();
        }
    }
}
