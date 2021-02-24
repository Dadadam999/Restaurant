using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class OrderListControl : UserControl
    {
        private List<Order> _orders = DataSet.Database.Orders;
        private List<Waiter> _waiters = DataSet.Database.Waiters;
        private List<Dish> _dishes = DataSet.Database.Dishes;
        private List<Client> _clients = DataSet.Database.Clients;

        private string _selectedId = string.Empty;
        private string _selectedIdFind = string.Empty;
        private string _selectedTypeFind = string.Empty;

        public OrderListControl()
        {
            InitializeComponent();
            UpdateList();
        }

        public void UpdateList()
        {
            ListPanel.Controls.Clear();
            if (_orders.Count > 0)
                foreach (Order order in _orders)
                    ListPanel.Controls.Add(new ItemListElementControl(order.Id.ToString(), order.DateCreate, SelectedClick));
        }

        private void SelectedClick(object sender, EventArgs e)
        {
            foreach (ItemListElementControl element in ListPanel.Controls)
                element.Icon.BackColor = Color.Transparent;

            ((PictureBox)sender).BackColor = Color.Orange;
            _selectedId = ((PictureBox)sender).Tag.ToString();

            UpdateContent();
        }

        public void UpdateContent()
        {
            ClearContent();

            Order order = _orders.Find(x => x.Id.ToString() == _selectedId);

            if (order != null)
            {
                IdContent.Text = order.Id.ToString();
                IdWaiterContent.Text = order.IdWaiter.ToString();
                IdClientContent.Text = order.IdClient.ToString();
                DateCreateContent.Text = order.DateCreate;
                TipsContent.Value = order.Tips;
                SaleContent.Value = order.Sales;
                AmountContent.Value = order.Amount;
                IsArchiveContent.Checked = order.isArchive;
                CheckContent.Text = order.Document;
                FindList.Controls.Clear();
                DishList.Items.AddRange(order.Dishes.Select(x => x.Id.ToString()).ToArray());
            }
        }

        public void ClearContent()
        {
            IdWaiterContent.Text = "";
            IdContent.Text = "";
            IdClientContent.Text = "";
            DateCreateContent.Text = "";
            TipsContent.Value = 0;
            SaleContent.Value = 0;
            AmountContent.Value = 0;
            IsArchiveContent.Checked = false;
            CheckContent.Text = "";
            FindList.Controls.Clear();
            DishList.Items.Clear();
        }

        private void SaveContent_Click(object sender, EventArgs e)
        {
            Order order = _orders.Find(x => x.Id.ToString() == _selectedId);

            if (order != null)
            {
                order.IdWaiter = Guid.Parse(IdWaiterContent.Text);
                order.IdClient = Guid.Parse(IdClientContent.Text);
                order.DateCreate = FixDate(DateCreateContent.Text);
                order.Tips = TipsContent.Value;
                order.isArchive = IsArchiveContent.Checked;
                order.Document = GetDocument(); ;
            }

            foreach (ItemListElementControl element in ListPanel.Controls)
                if (element.Icon.Tag.ToString() == _selectedId)
                {
                    element.UpdateElement(IdContent.Text, DateCreateContent.Text);
                    break;
                }

            UpdateContent();
            DataSet.SaveToFile();
            MessageBox.Show("Данные сохранены");
        }

        private void AddContent_Click(object sender, EventArgs e)
        {
            _orders.Add(new Order());
            DataSet.SaveToFile();
            UpdateList();
        }

        private void DeleteContent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_selectedId) && _orders.Count > 0)
            {
                for (int i = 0; i < _orders.Count; i++)
                    if (_orders[i].Id.ToString() == _selectedId)
                    {
                        _orders.Remove(_orders[i]);
                        break;
                    }

                DataSet.SaveToFile();
                _selectedId = string.Empty;
                ClearContent();
                UpdateList();
            }
        }

        private string GetDocument()
        {
            Order order = _orders.Find(x => x.Id.ToString() == _selectedId);
            string result = "";

            if (order != null)
            {
                result += "ID: " + order.Id + Environment.NewLine;
                result += "Дата: " + order.DateCreate + Environment.NewLine;
                result += Environment.NewLine;
                result += "ID клиента: " + order.IdClient + Environment.NewLine;
                result += "Фамилия: " + DataSet.Database.Clients.Find(x => x.Id == order.IdClient)?.LastName + Environment.NewLine;
                result += "Имя: " + DataSet.Database.Clients.Find(x => x.Id == order.IdClient)?.FrirstName + Environment.NewLine;
                result += Environment.NewLine;
                result += "ID официанта: " + order.IdWaiter + Environment.NewLine;
                result += "Фамилия: " + DataSet.Database.Waiters.Find(x => x.Id == order.IdWaiter)?.LastName + Environment.NewLine;
                result += "Имя: " + DataSet.Database.Waiters.Find(x => x.Id == order.IdWaiter)?.FrirstName + Environment.NewLine;
                result += "Отчество: " + DataSet.Database.Waiters.Find(x => x.Id == order.IdWaiter)?.Patronymic + Environment.NewLine;
                result += Environment.NewLine;
                foreach (Dish dish in order.Dishes)
                {
                    result += "ID блюда: " + dish.Id + Environment.NewLine;
                    result += "Наименование: " + dish.Title + Environment.NewLine;
                    result += "Количество: " + dish.Quality + Environment.NewLine;
                    result += "Стоимость: " + dish.Amount + Environment.NewLine;
                    result += "Скидка: " + dish.Sales + Environment.NewLine;
                    result += "Цена: " + dish.AmountSales + Environment.NewLine;
                    result += Environment.NewLine;
                }
                result += Environment.NewLine;
                result += "Чаевые всего: " + order.Tips + Environment.NewLine;
                result += "Скидка всего: " + order.Sales + Environment.NewLine;
                result += "Цена всего: " + order.Amount + Environment.NewLine;
            }

            return result;
        }

        private void DocumentContent_Click(object sender, EventArgs e)
        {
            Order order = _orders.Find(x => x.Id.ToString() == _selectedId);

            if (order != null)
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    CheckContent.ForeColor = Color.Black;
                    CheckContent.SaveFile(saveFileDialog1.FileName);
                    CheckContent.ForeColor = BackColor;
                    MessageBox.Show("Документ сохранен!");
                    Process.Start(saveFileDialog1.FileName);
                }
        }

        private void SelectedClickFindHuman(object sender, EventArgs e)
        {
            foreach (HumanListElementControl element in FindList.Controls)
                element.Icon.BackColor = Color.Transparent;

            ((PictureBox)sender).BackColor = Color.Orange;
            _selectedIdFind = ((PictureBox)sender).Tag.ToString();
        }

        private void SelectedClickFindDish(object sender, EventArgs e)
        {
            foreach (DishListElementControl element in FindList.Controls)
                element.Icon.BackColor = Color.Transparent;

            ((PictureBox)sender).BackColor = Color.Orange;
            _selectedIdFind = ((PictureBox)sender).Tag.ToString();
        }

        private void SelectClientContent_Click(object sender, EventArgs e)
        {
            FindList.Controls.Clear();
            foreach (Client client in _clients)
                FindList.Controls.Add(new HumanListElementControl(client.Id.ToString(), client.FrirstName, client.LastName, Properties.Resources.DefaultClientIcon, SelectedClickFindHuman));
            _selectedTypeFind = "client";
        }

        private void SelectWaiterContent_Click(object sender, EventArgs e)
        {
            FindList.Controls.Clear();
            foreach (Waiter waiter in _waiters)
                FindList.Controls.Add(new HumanListElementControl(waiter.Id.ToString(), waiter.FrirstName, waiter.LastName, waiter.Photo, SelectedClickFindHuman));
            _selectedTypeFind = "waiter";
        }

        private void AddDishContent_Click(object sender, EventArgs e)
        {
            FindList.Controls.Clear();
            foreach (Dish dish in _dishes)
                FindList.Controls.Add(new DishListElementControl(dish.Id.ToString(), dish.Title, dish.AmountSales.ToString(), dish.Picture, SelectedClickFindDish));
            _selectedTypeFind = "dish";
        }

        private void DeleteDishContent_Click(object sender, EventArgs e)
        {
            Order order = _orders.Find(x => x.Id.ToString() == _selectedId);

            if (order != null && DishList.SelectedIndex > 0)
            {
                order.Dishes.Remove(order.Dishes.Find(x => x.Id.ToString() == DishList.SelectedItem.ToString()));
                DishList.Items.Clear();
                DishList.Items.AddRange(order.Dishes.Select(x => x.Id.ToString()).ToArray());
            }
        }

        private void SelectFindContent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_selectedIdFind))
            {
                if (_selectedTypeFind == "client")
                    IdClientContent.Text = _clients.Find(x => x.Id.ToString() == _selectedIdFind)?.Id.ToString();

                if (_selectedTypeFind == "waiter")
                    IdWaiterContent.Text = _waiters.Find(x => x.Id.ToString() == _selectedIdFind)?.Id.ToString();

                if (_selectedTypeFind == "dish")
                {
                    Order order = _orders.Find(x => x.Id.ToString() == _selectedId);
                    if (order != null)
                    {
                        order.Dishes.Add(_dishes.Find(x => x.Id.ToString() == _selectedIdFind));
                        DishList.Items.Clear();
                        DishList.Items.AddRange(order.Dishes.Select(x => x.Id.ToString()).ToArray());
                    }
                }
                _selectedIdFind = string.Empty;
                _selectedTypeFind = string.Empty;
                FindList.Controls.Clear();
            }
        }

        private string FixDate(string date)
        {
            if (date.Length >= 10)
            {
                string[] numbers = date.Split('.');
                if (Convert.ToInt32(numbers[0]) > 31) numbers[0] = "31";
                if (Convert.ToInt32(numbers[1]) > 12) numbers[1] = "12";
                return string.Join(".", numbers);
            }
            else
                return date;
        }
    }
}