using System.Collections.Generic;
using System.Windows.Forms;

namespace Restaurant
{
    public static class ManangerControls
    {
        public static Panel PanelOut { get; set; }
        public static HomeControl Home { get; set; } = new HomeControl();
        public static ClientListControl ClientList { get; set; } = new ClientListControl();
        public static DishProfileControl DishProfile { get; set; } = new DishProfileControl();
        public static MenuListControl MenuList { get; set; } = new MenuListControl();
        public static OrderListControl OrderList { get; set; } = new OrderListControl();
        public static WaiterListControl WaiterList { get; set; } = new WaiterListControl();
        public static List<UserControl> Controls { get; set; } = new List<UserControl>();

        public static void InitControls(Panel panelOut)
        {
            PanelOut = panelOut;

            InitControl(Home, "Home");
            InitControl(ClientList, "ClientList");
            InitControl(DishProfile, "DishProfile");
            InitControl(MenuList, "MenuList");
            InitControl(OrderList, "OrderList");
            InitControl(WaiterList, "WaiterList");
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