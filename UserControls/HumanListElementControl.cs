using System;
using System.Drawing;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class HumanListElementControl : UserControl
    {
        public HumanListElementControl(string id, string firstname, string lastname, Image icon, EventHandler clickEvent)
        {
            InitializeComponent();
            Dock = DockStyle.Top;
            UpdateElement(id, firstname, lastname, icon);
            Icon.Tag = id;
            Icon.Click += clickEvent;
        }

        public void UpdateElement(string id, string firstname, string lastname, Image icon)
        {
            Id.Text = id;
            FirstName.Text = firstname;
            LastName.Text = lastname;
            Icon.Image = icon;
        }
    }
}
