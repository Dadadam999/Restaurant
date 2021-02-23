using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class DishListElementControl : UserControl
    {
        public DishListElementControl(string id, string itemname, Bitmap image, EventHandler clickEvent)
        {
            InitializeComponent();
            Dock = DockStyle.Top;
            UpdateElement(id, itemname);
            Icon.Image = image;
            Icon.Tag = id;
            Icon.Click += clickEvent;
        }

        public void UpdateElement(string id, string itemname)
        {
            Id.Text = id;
            ItemName.Text = itemname;
        }
    }
}
