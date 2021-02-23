
namespace Restaurant
{
    partial class DishProfileControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopBar = new System.Windows.Forms.Panel();
            this.SaveContent = new System.Windows.Forms.Button();
            this.PolyContent = new System.Windows.Forms.TableLayoutPanel();
            this.CurrentAmountContent = new System.Windows.Forms.NumericUpDown();
            this.SaleContent = new System.Windows.Forms.NumericUpDown();
            this.AmountContent = new System.Windows.Forms.NumericUpDown();
            this.QualityContent = new System.Windows.Forms.NumericUpDown();
            this.DescriptionContent = new System.Windows.Forms.RichTextBox();
            this.MenuIdContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TitleContent = new System.Windows.Forms.TextBox();
            this.PhotoContent = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.TopBar.SuspendLayout();
            this.PolyContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentAmountContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QualityContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoContent)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.TopBar.Controls.Add(this.SaveContent);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(546, 25);
            this.TopBar.TabIndex = 2;
            // 
            // SaveContent
            // 
            this.SaveContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveContent.FlatAppearance.BorderSize = 0;
            this.SaveContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveContent.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveContent.ForeColor = System.Drawing.Color.Blue;
            this.SaveContent.Location = new System.Drawing.Point(0, 0);
            this.SaveContent.Name = "SaveContent";
            this.SaveContent.Size = new System.Drawing.Size(25, 25);
            this.SaveContent.TabIndex = 2;
            this.SaveContent.Text = "💾";
            this.SaveContent.UseVisualStyleBackColor = true;
            this.SaveContent.Click += new System.EventHandler(this.SaveContent_Click);
            // 
            // PolyContent
            // 
            this.PolyContent.AutoScroll = true;
            this.PolyContent.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.PolyContent.ColumnCount = 2;
            this.PolyContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.65281F));
            this.PolyContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.34719F));
            this.PolyContent.Controls.Add(this.CurrentAmountContent, 1, 7);
            this.PolyContent.Controls.Add(this.SaleContent, 1, 6);
            this.PolyContent.Controls.Add(this.AmountContent, 1, 5);
            this.PolyContent.Controls.Add(this.QualityContent, 1, 4);
            this.PolyContent.Controls.Add(this.DescriptionContent, 1, 3);
            this.PolyContent.Controls.Add(this.MenuIdContent, 1, 1);
            this.PolyContent.Controls.Add(this.label1, 0, 0);
            this.PolyContent.Controls.Add(this.IdContent, 1, 0);
            this.PolyContent.Controls.Add(this.label2, 0, 1);
            this.PolyContent.Controls.Add(this.label3, 0, 2);
            this.PolyContent.Controls.Add(this.label6, 0, 3);
            this.PolyContent.Controls.Add(this.label10, 0, 4);
            this.PolyContent.Controls.Add(this.label11, 0, 5);
            this.PolyContent.Controls.Add(this.label12, 0, 6);
            this.PolyContent.Controls.Add(this.label13, 0, 7);
            this.PolyContent.Controls.Add(this.TitleContent, 1, 2);
            this.PolyContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PolyContent.Location = new System.Drawing.Point(0, 25);
            this.PolyContent.Name = "PolyContent";
            this.PolyContent.RowCount = 9;
            this.PolyContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PolyContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PolyContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PolyContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.PolyContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PolyContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PolyContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PolyContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PolyContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PolyContent.Size = new System.Drawing.Size(546, 360);
            this.PolyContent.TabIndex = 6;
            // 
            // CurrentAmountContent
            // 
            this.CurrentAmountContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.CurrentAmountContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentAmountContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.CurrentAmountContent.Location = new System.Drawing.Point(209, 241);
            this.CurrentAmountContent.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.CurrentAmountContent.Name = "CurrentAmountContent";
            this.CurrentAmountContent.ReadOnly = true;
            this.CurrentAmountContent.Size = new System.Drawing.Size(333, 20);
            this.CurrentAmountContent.TabIndex = 58;
            // 
            // SaleContent
            // 
            this.SaleContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.SaleContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaleContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.SaleContent.Location = new System.Drawing.Point(209, 210);
            this.SaleContent.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.SaleContent.Name = "SaleContent";
            this.SaleContent.Size = new System.Drawing.Size(333, 20);
            this.SaleContent.TabIndex = 57;
            // 
            // AmountContent
            // 
            this.AmountContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.AmountContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AmountContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.AmountContent.Location = new System.Drawing.Point(209, 179);
            this.AmountContent.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.AmountContent.Name = "AmountContent";
            this.AmountContent.Size = new System.Drawing.Size(333, 20);
            this.AmountContent.TabIndex = 56;
            // 
            // QualityContent
            // 
            this.QualityContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.QualityContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QualityContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.QualityContent.Location = new System.Drawing.Point(209, 148);
            this.QualityContent.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.QualityContent.Name = "QualityContent";
            this.QualityContent.Size = new System.Drawing.Size(333, 20);
            this.QualityContent.TabIndex = 55;
            // 
            // DescriptionContent
            // 
            this.DescriptionContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.DescriptionContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.DescriptionContent.Location = new System.Drawing.Point(209, 97);
            this.DescriptionContent.Name = "DescriptionContent";
            this.DescriptionContent.Size = new System.Drawing.Size(333, 44);
            this.DescriptionContent.TabIndex = 54;
            this.DescriptionContent.Text = "";
            // 
            // MenuIdContent
            // 
            this.MenuIdContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.MenuIdContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuIdContent.Enabled = false;
            this.MenuIdContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.MenuIdContent.Location = new System.Drawing.Point(209, 35);
            this.MenuIdContent.Name = "MenuIdContent";
            this.MenuIdContent.Size = new System.Drawing.Size(333, 20);
            this.MenuIdContent.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IdContent
            // 
            this.IdContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.IdContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdContent.Enabled = false;
            this.IdContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.IdContent.Location = new System.Drawing.Point(209, 4);
            this.IdContent.Name = "IdContent";
            this.IdContent.Size = new System.Drawing.Size(333, 20);
            this.IdContent.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(4, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 30);
            this.label2.TabIndex = 26;
            this.label2.Text = "Id меню";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label3.Location = new System.Drawing.Point(4, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 30);
            this.label3.TabIndex = 27;
            this.label3.Text = "Название";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label6.Location = new System.Drawing.Point(4, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 50);
            this.label6.TabIndex = 45;
            this.label6.Text = "Описание";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label10.Location = new System.Drawing.Point(4, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 30);
            this.label10.TabIndex = 49;
            this.label10.Text = "Количество";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label11.Location = new System.Drawing.Point(4, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 30);
            this.label11.TabIndex = 50;
            this.label11.Text = "Стоимость";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label12.Location = new System.Drawing.Point(4, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(198, 30);
            this.label12.TabIndex = 51;
            this.label12.Text = "Скидка";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label13.Location = new System.Drawing.Point(4, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(198, 30);
            this.label13.TabIndex = 52;
            this.label13.Text = "Цена";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TitleContent
            // 
            this.TitleContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.TitleContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.TitleContent.Location = new System.Drawing.Point(209, 66);
            this.TitleContent.Name = "TitleContent";
            this.TitleContent.Size = new System.Drawing.Size(333, 20);
            this.TitleContent.TabIndex = 53;
            // 
            // PhotoContent
            // 
            this.PhotoContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PhotoContent.Image = global::Restaurant.Properties.Resources.вш;
            this.PhotoContent.Location = new System.Drawing.Point(0, 388);
            this.PhotoContent.Name = "PhotoContent";
            this.PhotoContent.Size = new System.Drawing.Size(546, 151);
            this.PhotoContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoContent.TabIndex = 43;
            this.PhotoContent.TabStop = false;
            this.PhotoContent.Click += new System.EventHandler(this.PhotoContent_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|jpeg files (*.jpeg)|*.jpeg";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 385);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(546, 3);
            this.splitter1.TabIndex = 44;
            this.splitter1.TabStop = false;
            // 
            // DishProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.Controls.Add(this.PolyContent);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.PhotoContent);
            this.Name = "DishProfileControl";
            this.Size = new System.Drawing.Size(546, 539);
            this.TopBar.ResumeLayout(false);
            this.PolyContent.ResumeLayout(false);
            this.PolyContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentAmountContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QualityContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Button SaveContent;
        private System.Windows.Forms.TableLayoutPanel PolyContent;
        private System.Windows.Forms.TextBox MenuIdContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PhotoContent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox TitleContent;
        private System.Windows.Forms.RichTextBox DescriptionContent;
        private System.Windows.Forms.NumericUpDown CurrentAmountContent;
        private System.Windows.Forms.NumericUpDown SaleContent;
        private System.Windows.Forms.NumericUpDown AmountContent;
        private System.Windows.Forms.NumericUpDown QualityContent;
        private System.Windows.Forms.Splitter splitter1;
    }
}
