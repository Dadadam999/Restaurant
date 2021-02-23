using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public static class ManangerControls
    {
        public static Panel PanelOut { get; set; }
        public static HomeControl Home { get; set; } = new HomeControl();
        public static ClientListControl ClientList { get; set; } = new ClientListControl();
        public static ClientProfileControl ClientProfile { get; set; } = new ClientProfileControl();
        public static DishProfileControl DishProfile { get; set; } = new DishProfileControl();
        public static MenuListControl MenuList { get; set; } = new MenuListControl();
        public static MenuProfileControl MenuProfile { get; set; } = new MenuProfileControl();
        public static OrderListControl OrderList { get; set; } = new OrderListControl();
        public static OrderProfileControl OrderProfile { get; set; } = new OrderProfileControl();
        public static WaiterListControl WaiterList { get; set; } = new WaiterListControl();
        public static WaiterProfileControl WaiterProfile { get; set; } = new WaiterProfileControl();
        public static List<UserControl> Controls { get; set; } = new List<UserControl>();

        public static void InitControls(Panel panelOut)
        {
            PanelOut = panelOut;

            InitControl(Home, "Home");
            InitControl(ClientList, "ClientList");
            InitControl(ClientProfile, "ClientProfile");
            InitControl(DishProfile, "DishProfile");
            InitControl(MenuList, "MenuList");
            InitControl(MenuProfile, "MenuProfile");
            InitControl(OrderList, "OrderList");
            InitControl(OrderProfile, "OrderProfile");
            InitControl(WaiterList, "WaiterList");
            InitControl(WaiterProfile, "WaiterProfile");

            ShowControl("Home");
        }

        private static void InitControl(UserControl control, string name)
        {
            control.Dock = DockStyle.Fill;
            control.Visible = false;
            control.Name = name;
            Controls.Add(control);
            PanelOut.Controls.Add(control);
        }

        public static void ShowControl(string name)
        {
            foreach (UserControl uc in Controls)
                if (uc.Name == name)
                    uc.Visible = true;
                else
                    uc.Visible = false;
        }
    }
}