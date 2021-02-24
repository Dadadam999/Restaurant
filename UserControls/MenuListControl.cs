using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class MenuListControl : UserControl
    {
        private List<Menu> _menus = DataSet.Database.Menus;
        private List<Dish> _dishes = DataSet.Database.Dishes;
        private string _selectedId = string.Empty;
        private string _selectedIdDish = string.Empty;
        public MenuListControl()
        {
            InitializeComponent();
            UpdateList();
        }

        public void UpdateList()
        {
            ListPanel.Controls.Clear();
            if (_menus.Count > 0)
                foreach (Menu menu in _menus)
                    ListPanel.Controls.Add(new ItemListElementControl(menu.Id.ToString(), menu.Name, SelectedClick));
        }

        public void UpdateContent()
        {
            ClearContent();
            if (!string.IsNullOrEmpty(_selectedId) && _menus.Count > 0)
            {
                for (int i = 0; i < _menus.Count; i++)
                    if (_menus[i].Id.ToString() == _selectedId)
                    {
                        IdContent.Text = _menus[i].Id.ToString(); ;
                        NameContent.Text = _menus[i].Name;
                        PublishContent.Text = _menus[i].PublishDate;
                        UnPublishContent.Text = _menus[i].UnPublichhDate;
                        PhotoContent.Image = _menus[i].Photo;

                        var selectedDish = (
                                            from dish in _dishes
                                            where _menus[i].Id == dish.IdMenu
                                            orderby dish.Sales
                                            select dish
                                           ).ToArray();

                        if (selectedDish.Length > 0)
                            foreach (Dish dish in selectedDish)
                                DishList.Controls.Add(new DishListElementControl(dish.Id.ToString(), dish.Title, dish.AmountSales.ToString(), dish.Picture, SelectedClickDish));
                        break;
                    }
            }
        }

        public void ClearContent()
        {
            IdContent.Text = "";
            NameContent.Text = "";
            PublishContent.Text = "";
            UnPublishContent.Text = "";
            PhotoContent.Image = Properties.Resources.DefaultMenuIcon;
            DishList.Controls.Clear();
        }

        private void SelectedClickDish(object sender, EventArgs e)
        {
            foreach (DishListElementControl element in DishList.Controls)
                element.Icon.BackColor = Color.Transparent;

            ((PictureBox)sender).BackColor = Color.Orange;
            _selectedIdDish = ((PictureBox)sender).Tag.ToString();
        }

        private void SelectedClick(object sender, EventArgs e)
        {
            foreach (ItemListElementControl element in ListPanel.Controls)
                element.Icon.BackColor = Color.Transparent;

            ((PictureBox)sender).BackColor = Color.Orange;
            _selectedId = ((PictureBox)sender).Tag.ToString();

            UpdateContent();
        }

        private void AddContent_Click(object sender, EventArgs e)
        {
            _menus.Add(new Menu());
            DataSet.SaveToFile();
            UpdateList();
        }

        private void DeleteContent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_selectedId) && _menus.Count > 0)
            {
                for (int i = 0; i < _menus.Count; i++)
                    if (_menus[i].Id.ToString() == _selectedId)
                    {
                        _menus.Remove(_menus[i]);
                        break;
                    }
                DataSet.SaveToFile();
                _selectedId = string.Empty;
                ClearContent();
                UpdateList();
            }
        }

        private void SaveContent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_selectedId) && _menus.Count > 0)
            {
                for (int i = 0; i < _menus.Count; i++)
                    if (_menus[i].Id.ToString() == _selectedId)
                    {
                        _menus[i].Name = NameContent.Text;
                        _menus[i].PublishDate = FixDate(PublishContent.Text);
                        _menus[i].UnPublichhDate = FixDate(UnPublishContent.Text);
                        _menus[i].Photo = new Bitmap(PhotoContent.Image);
                        break;
                    }

                foreach (ItemListElementControl element in ListPanel.Controls)
                    if (element.Icon.Tag.ToString() == _selectedId)
                    {
                        element.UpdateElement(IdContent.Text, NameContent.Text);
                        break;
                    }

                DataSet.SaveToFile();
                MessageBox.Show("Данные сохранены");
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

        private void AddDishContent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_selectedId))
            {
                _dishes.Add(new Dish());
                _dishes[_dishes.Count - 1].IdMenu = Guid.Parse(_selectedId);
                ManangerControls.DishProfile.SetDish(_dishes[_dishes.Count - 1]);
                ManangerControls.ShowControl("DishProfile");
            }
        }

        private void DeleteDishContent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_selectedIdDish) && _dishes.Count > 0)
            {
                for (int i = 0; i < _dishes.Count; i++)
                    if (_dishes[i].Id.ToString() == _selectedIdDish)
                    {
                        _dishes.Remove(_dishes[i]);
                        break;
                    }
                DataSet.SaveToFile();
                _selectedIdDish = string.Empty;
                UpdateContent();
            }
        }

        private void PhotoContent_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                PhotoContent.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void OpenDishContent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_selectedId))
            {
                ManangerControls.DishProfile.SetDish(_dishes.Find(x => x.Id.ToString() == _selectedIdDish));
                ManangerControls.ShowControl("DishProfile");
            }
        }
    }
}