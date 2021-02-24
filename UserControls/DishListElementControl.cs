using System;
using System.Drawing;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class DishListElementControl : UserControl
    {
        public DishListElementControl(string id, string itemname, string amount, Bitmap image, EventHandler clickEvent)
        {
            InitializeComponent();
            Dock = DockStyle.Top;
            UpdateElement(id, itemname, amount, image);
            Icon.Tag = id;
            Icon.Click += clickEvent;
        }

        public void UpdateElement(string id, string itemname, string amount, Bitmap image)
        {
            Id.Text = id;
            ItemName.Text = itemname;
            Amount.Text = amount;
            Icon.Image = image;
        }
    }
}
