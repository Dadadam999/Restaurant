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
    public partial class ClientListControl : UserControl
    {
        private List<Client> _clients = DataSet.Database.Clients;
        private string _selectedId = string.Empty;

        public ClientListControl()
        {
            InitializeComponent();
            UpdateList();
        }

        public void UpdateList()
        {
            ListPanel.Controls.Clear();
            if (_clients.Count > 0)
                foreach (Client client in _clients)
                    ListPanel.Controls.Add(new HumanListElementControl(client.Id.ToString(), client.FrirstName, client.LastName, SelectedClick));
        }

        public void UpdateContent()
        {
            ClearContent();
            if (!string.IsNullOrEmpty(_selectedId) && _clients.Count > 0)
            {
                for (int i = 0; i < _clients.Count; i++)
                    if (_clients[i].Id.ToString() == _selectedId)
                    {
                        IdContent.Text = _clients[i].Id.ToString();
                        TypeContent.Text = _clients[i].Type;
                        UtmContent.Text = _clients[i].UtmSource;
                        FirstNameContent.Text = _clients[i].FrirstName;
                        LastNameContent.Text = _clients[i].LastName;
                        SexContent.Text = _clients[i].Sex;
                        CostAllContent.Value = _clients[i].CostAll;
                        CostMounthContent.Value = _clients[i].CostMounth;
                        SalesContent.Value = _clients[i].Sales;
                        VisitCountContent.Value = _clients[i].VisitCount;
                        LastVisitContent.Text = _clients[i].LastVisit;
                        break;
                    }
            }
        }

        public void ClearContent()
        {
            IdContent.Text = "";
            TypeContent.Text = "";
            UtmContent.Text = "";
            FirstNameContent.Text = "";
            LastNameContent.Text = "";
            SexContent.Text = "";
            CostAllContent.Value = 0;
            CostMounthContent.Value = 0;
            SalesContent.Value = 0;
            VisitCountContent.Value = 0;
            LastVisitContent.Text = "";
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
            _clients.Add(new Client());
            DataSet.SaveToFile();
            UpdateList();
        }

        private void DeleteContent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_selectedId) && _clients.Count > 0)
            {
                for (int i = 0; i < _clients.Count; i++)
                    if (_clients[i].Id.ToString() == _selectedId)
                    {
                        _clients.Remove(_clients[i]);
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
            if (!string.IsNullOrEmpty(_selectedId) && _clients.Count > 0)
            {
                for (int i = 0; i < _clients.Count; i++)
                    if (_clients[i].Id.ToString() == _selectedId)
                    {
                        _clients[i].Type = TypeContent.Text;
                        _clients[i].UtmSource = UtmContent.Text;
                        _clients[i].FrirstName = FirstNameContent.Text;
                        _clients[i].LastName = LastNameContent.Text;
                        _clients[i].Sex = SexContent.Text;
                        _clients[i].CostAll = CostAllContent.Value;
                        _clients[i].CostMounth = CostMounthContent.Value;
                        _clients[i].Sales = SalesContent.Value;
                        _clients[i].VisitCount = Convert.ToInt32(VisitCountContent.Value);
                        _clients[i].LastVisit = FixDate(LastVisitContent.Text);
                        break;
                    }

                foreach (HumanListElementControl element in ListPanel.Controls)
                    if (element.Icon.Tag.ToString() == _selectedId)
                    {
                        element.UpdateElement(IdContent.Text, FirstNameContent.Text, LastNameContent.Text);
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
    }
}
