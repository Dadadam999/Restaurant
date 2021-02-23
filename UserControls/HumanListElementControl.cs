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
    public partial class HumanListElementControl : UserControl
    {
        public HumanListElementControl(string id, string firstname, string lastname, EventHandler clickEvent)
        {
            InitializeComponent();
            Dock = DockStyle.Top;
            UpdateElement(id, firstname, lastname);
            Icon.Tag = id;
            Icon.Click += clickEvent;
        }

        public void UpdateElement(string id, string firstname, string lastname) 
        {
            Id.Text = id;
            FirstName.Text = firstname;
            LastName.Text = lastname;
        }
    }
}
