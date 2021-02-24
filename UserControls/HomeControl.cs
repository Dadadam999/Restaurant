using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class HomeControl : UserControl
    {
        private List<Order> _orders = DataSet.Database.Orders;
        private List<Waiter> _waiters = DataSet.Database.Waiters;
        private List<Dish> _dishes = DataSet.Database.Dishes;
        private List<Client> _clients = DataSet.Database.Clients;

        public HomeControl()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel5_VisibleChanged(object sender, EventArgs e)
        {

            CostAll.Text = _orders.Sum(x => x.Amount).ToString();
            CostMounth.Text = _orders.Where(x => !x.isArchive).Sum(x => x.Amount).ToString();

            DepthWage.Text = _waiters.Sum(x => x.StaticWage).ToString();
            DepthSale.Text = _orders.Where(x => !x.isArchive).Sum(x => x.Sales).ToString(); ;
            DepthTips.Text = _waiters.Sum(x => x.Tips).ToString();

            OrderQuality.Text = _orders.Count().ToString();
            OrderActive.Text = _orders.Where(x => !x.isArchive).Count().ToString();
            OrderArchive.Text = _orders.Where(x => x.isArchive).Count().ToString();

            ClientQuality.Text = _clients.Count().ToString();
            ClientVip.Text = _clients.Where(x => x.Type == "VIP").Count().ToString();
            ClientDefault.Text = _clients.Where(x => x.Type == "Обычный").Count().ToString();
        }
    }
}
