using System;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class ItemListElementControl : UserControl
    {
        public ItemListElementControl(string id, string itemname, EventHandler clickEvent)
        {
            InitializeComponent();
            Dock = DockStyle.Top;
            UpdateElement(id, itemname);
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
