using System;
using System.Drawing;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class DishProfileControl : UserControl
    {
        private Dish _dish;
        public DishProfileControl()
        {
            InitializeComponent();
        }

        public void SetDish(Dish element)
        {
            _dish = element;
            UpdateContent();
        }

        public void UpdateContent()
        {
            ClearContent();

            IdContent.Text = _dish.Id.ToString();
            MenuIdContent.Text = _dish.IdMenu.ToString();
            TitleContent.Text = _dish.Title;
            DescriptionContent.Text = _dish.Description;
            QualityContent.Value = _dish.Quality;
            AmountContent.Value = _dish.Amount;
            SaleContent.Value = _dish.Sales;
            CurrentAmountContent.Value = _dish.AmountSales;
            PhotoContent.Image = _dish.Picture;
        }

        public void ClearContent()
        {
            IdContent.Text = "";
            MenuIdContent.Text = "";
            TitleContent.Text = "";
            DescriptionContent.Text = "";
            QualityContent.Value = 0;
            AmountContent.Value = 0;
            SaleContent.Value = 0;
            CurrentAmountContent.Value = 0;
            PhotoContent.Image = Properties.Resources.DefaultMenuIcon;
        }

        private void SaveContent_Click(object sender, EventArgs e)
        {
            _dish.Title = TitleContent.Text;
            _dish.Description = DescriptionContent.Text;
            _dish.Quality = Convert.ToInt32(QualityContent.Value);
            _dish.Amount = AmountContent.Value;
            _dish.Sales = SaleContent.Value;
            _dish.Picture = new Bitmap(PhotoContent.Image);
            DataSet.SaveToFile();
            ManangerControls.MenuList.UpdateContent();
            ManangerControls.ShowControl("MenuList");
        }

        private void PhotoContent_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                PhotoContent.Image = Image.FromFile(openFileDialog1.FileName);
        }
    }
}
