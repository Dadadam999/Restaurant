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
    public partial class WaiterListControl : UserControl
    {
        private List<Waiter> _waiters = DataSet.Database.Waiters;
        private string _selectedId = string.Empty;

        public WaiterListControl()
        {
            InitializeComponent();
            UpdateList();
        }

        public void UpdateList()
        {
            ListPanel.Controls.Clear();
            if (_waiters.Count > 0)
                foreach (Waiter waiter in _waiters)
                    ListPanel.Controls.Add(new HumanListElementControl(waiter.Id.ToString(), waiter.FrirstName, waiter.LastName, SelectedClick));
        }

        private void PhotoContent_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                PhotoContent.Image = Image.FromFile(openFileDialog1.FileName);
        }

        public void UpdateContent()
        {
            ClearContent();
            if (!string.IsNullOrEmpty(_selectedId) && _waiters.Count > 0)
            {
                for (int i = 0; i < _waiters.Count; i++)
                    if (_waiters[i].Id.ToString() == _selectedId)
                    {
                        PhotoContent.Image = _waiters[i].Photo;
                        IdContent.Text = _waiters[i].Id.ToString();
                        PostContent.Text = _waiters[i].Post;
                        LastNameContent.Text = _waiters[i].LastName;
                        FirstNameContent.Text = _waiters[i].FrirstName;
                        Patronymic.Text = _waiters[i].Patronymic;

                        SexContent.Text = _waiters[i].Sex;
                        OldContent.Value = _waiters[i].Old;
                        WageContent.Value = _waiters[i].StaticWage;

                        TipsContent.Value = _waiters[i].Tips;
                        CurrentWageContent.Value = _waiters[i].CurrentWage;
                        ShecludeContent.Text = _waiters[i].Sheclude;

                        var selectedOrders = (
                                              from order in DataSet.Database.Orders
                                              where _waiters[i].Id == order.IdWaiter && !order.isArchive
                                              orderby order.DateCreate
                                              select order.Id.ToString()
                                             ).ToArray();


                        if (selectedOrders.Length > 0)
                            OrderList.Items.AddRange(selectedOrders);

                        break;
                    }
            }
        }

        public void ClearContent()
        {
            PhotoContent.Image = Properties.Resources.images;
            IdContent.Text = "";
            PostContent.Text = "";
            LastNameContent.Text = "";
            FirstNameContent.Text = "";
            Patronymic.Text = "";
            SexContent.Text = "";
            OldContent.Value = 0;
            WageContent.Value = 0;
            TipsContent.Value = 0;
            CurrentWageContent.Value = 0;
            ShecludeContent.Text = "";
            OrderList.Items.Clear();
        }

        private void SaveContent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_selectedId) && _waiters.Count > 0)
            {
                for (int i = 0; i < _waiters.Count; i++)
                    if (_waiters[i].Id.ToString() == _selectedId)
                    {
                        _waiters[i].Photo = new Bitmap(PhotoContent.Image);
                        _waiters[i].Post = PostContent.Text;
                        _waiters[i].LastName = LastNameContent.Text;
                        _waiters[i].FrirstName = FirstNameContent.Text;
                        _waiters[i].Patronymic = Patronymic.Text;
                        _waiters[i].Sex = SexContent.Text;
                        _waiters[i].Old = Convert.ToInt32(OldContent.Value);
                        _waiters[i].StaticWage = WageContent.Value;
                        _waiters[i].Tips = TipsContent.Value;
                        _waiters[i].Sheclude = ShecludeContent.Text;
                        break;
                    }

                foreach (HumanListElementControl element in ListPanel.Controls)
                    if (element.Icon.Tag.ToString() == _selectedId)
                    {
                        element.UpdateElement(IdContent.Text, Patronymic.Text, FirstNameContent.Text);
                        break;
                    }

                DataSet.SaveToFile();
                MessageBox.Show("Данные сохранены");
            }
        }

        private void SelectedClick(object sender, EventArgs e)
        {
            foreach (HumanListElementControl element in ListPanel.Controls)
                element.Icon.BackColor = Color.Transparent;

            ((PictureBox)sender).BackColor = Color.Orange;
            _selectedId = ((PictureBox)sender).Tag.ToString();

            UpdateContent();
        }

        private void AddContent_Click(object sender, EventArgs e)
        {
           _waiters.Add(new Waiter());
            DataSet.SaveToFile();
            UpdateList();
        }

        private void DeleteContent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_selectedId) &&_waiters.Count > 0)
            {
                for (int i = 0; i < _waiters.Count; i++)
                    if (_waiters[i].Id.ToString() == _selectedId)
                    {
                       _waiters.Remove(_waiters[i]);
                        break;
                    }
                DataSet.SaveToFile();
                _selectedId = string.Empty;
                ClearContent();
                UpdateList();
            }
        }
    }
}
