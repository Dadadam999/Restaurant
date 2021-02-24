
namespace Restaurant
{
    partial class OrderListControl
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
            this.LeftDock = new System.Windows.Forms.Panel();
            this.ListPanel = new System.Windows.Forms.Panel();
            this.TopBar = new System.Windows.Forms.Panel();
            this.DocumentContent = new System.Windows.Forms.Button();
            this.SaveContent = new System.Windows.Forms.Button();
            this.DeleteContent = new System.Windows.Forms.Button();
            this.AddContent = new System.Windows.Forms.Button();
            this.TablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.CheckContent = new System.Windows.Forms.RichTextBox();
            this.DateCreateContent = new System.Windows.Forms.MaskedTextBox();
            this.TipsContent = new System.Windows.Forms.NumericUpDown();
            this.SaleContent = new System.Windows.Forms.NumericUpDown();
            this.AmountContent = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label228 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IdContent = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IdClientContent = new System.Windows.Forms.TextBox();
            this.SelectClientContent = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IdWaiterContent = new System.Windows.Forms.TextBox();
            this.SelectWaiterContent = new System.Windows.Forms.Button();
            this.IsArchiveContent = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DishList = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DeleteDishContent = new System.Windows.Forms.Button();
            this.AddDishContent = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.FindList = new System.Windows.Forms.FlowLayoutPanel();
            this.DishBar = new System.Windows.Forms.Panel();
            this.SelectFindContent = new System.Windows.Forms.Button();
            this.Splitter = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.LeftDock.SuspendLayout();
            this.TopBar.SuspendLayout();
            this.TablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TipsContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountContent)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.DishBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftDock
            // 
            this.LeftDock.Controls.Add(this.ListPanel);
            this.LeftDock.Controls.Add(this.TopBar);
            this.LeftDock.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftDock.Location = new System.Drawing.Point(0, 0);
            this.LeftDock.Name = "LeftDock";
            this.LeftDock.Size = new System.Drawing.Size(158, 397);
            this.LeftDock.TabIndex = 3;
            // 
            // ListPanel
            // 
            this.ListPanel.AutoScroll = true;
            this.ListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.ListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPanel.Location = new System.Drawing.Point(0, 25);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(158, 372);
            this.ListPanel.TabIndex = 2;
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.TopBar.Controls.Add(this.DocumentContent);
            this.TopBar.Controls.Add(this.SaveContent);
            this.TopBar.Controls.Add(this.DeleteContent);
            this.TopBar.Controls.Add(this.AddContent);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(158, 25);
            this.TopBar.TabIndex = 1;
            // 
            // DocumentContent
            // 
            this.DocumentContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.DocumentContent.FlatAppearance.BorderSize = 0;
            this.DocumentContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DocumentContent.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocumentContent.ForeColor = System.Drawing.Color.BlueViolet;
            this.DocumentContent.Location = new System.Drawing.Point(75, 0);
            this.DocumentContent.Name = "DocumentContent";
            this.DocumentContent.Size = new System.Drawing.Size(25, 25);
            this.DocumentContent.TabIndex = 3;
            this.DocumentContent.Text = "📄";
            this.DocumentContent.UseVisualStyleBackColor = true;
            this.DocumentContent.Click += new System.EventHandler(this.DocumentContent_Click);
            // 
            // SaveContent
            // 
            this.SaveContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveContent.FlatAppearance.BorderSize = 0;
            this.SaveContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveContent.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveContent.ForeColor = System.Drawing.Color.Blue;
            this.SaveContent.Location = new System.Drawing.Point(50, 0);
            this.SaveContent.Name = "SaveContent";
            this.SaveContent.Size = new System.Drawing.Size(25, 25);
            this.SaveContent.TabIndex = 2;
            this.SaveContent.Text = "💾";
            this.SaveContent.UseVisualStyleBackColor = true;
            this.SaveContent.Click += new System.EventHandler(this.SaveContent_Click);
            // 
            // DeleteContent
            // 
            this.DeleteContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.DeleteContent.FlatAppearance.BorderSize = 0;
            this.DeleteContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteContent.Font = new System.Drawing.Font("Yu Gothic", 11.25F);
            this.DeleteContent.ForeColor = System.Drawing.Color.Red;
            this.DeleteContent.Location = new System.Drawing.Point(25, 0);
            this.DeleteContent.Name = "DeleteContent";
            this.DeleteContent.Size = new System.Drawing.Size(25, 25);
            this.DeleteContent.TabIndex = 1;
            this.DeleteContent.Text = "-";
            this.DeleteContent.UseVisualStyleBackColor = true;
            this.DeleteContent.Click += new System.EventHandler(this.DeleteContent_Click);
            // 
            // AddContent
            // 
            this.AddContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddContent.FlatAppearance.BorderSize = 0;
            this.AddContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddContent.Font = new System.Drawing.Font("Yu Gothic", 11.25F);
            this.AddContent.ForeColor = System.Drawing.Color.Lime;
            this.AddContent.Location = new System.Drawing.Point(0, 0);
            this.AddContent.Name = "AddContent";
            this.AddContent.Size = new System.Drawing.Size(25, 25);
            this.AddContent.TabIndex = 0;
            this.AddContent.Text = "+";
            this.AddContent.UseVisualStyleBackColor = true;
            this.AddContent.Click += new System.EventHandler(this.AddContent_Click);
            // 
            // TablePanel
            // 
            this.TablePanel.AutoScroll = true;
            this.TablePanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TablePanel.ColumnCount = 2;
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.13405F));
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.86595F));
            this.TablePanel.Controls.Add(this.CheckContent, 1, 8);
            this.TablePanel.Controls.Add(this.DateCreateContent, 1, 6);
            this.TablePanel.Controls.Add(this.TipsContent, 1, 5);
            this.TablePanel.Controls.Add(this.SaleContent, 1, 4);
            this.TablePanel.Controls.Add(this.AmountContent, 1, 3);
            this.TablePanel.Controls.Add(this.label19, 0, 9);
            this.TablePanel.Controls.Add(this.label17, 0, 8);
            this.TablePanel.Controls.Add(this.label15, 0, 7);
            this.TablePanel.Controls.Add(this.label13, 0, 6);
            this.TablePanel.Controls.Add(this.label11, 0, 5);
            this.TablePanel.Controls.Add(this.label9, 0, 4);
            this.TablePanel.Controls.Add(this.label228, 0, 3);
            this.TablePanel.Controls.Add(this.label5, 0, 2);
            this.TablePanel.Controls.Add(this.label3, 0, 1);
            this.TablePanel.Controls.Add(this.label1, 0, 0);
            this.TablePanel.Controls.Add(this.IdContent, 1, 0);
            this.TablePanel.Controls.Add(this.panel1, 1, 1);
            this.TablePanel.Controls.Add(this.panel2, 1, 2);
            this.TablePanel.Controls.Add(this.IsArchiveContent, 1, 7);
            this.TablePanel.Controls.Add(this.panel3, 1, 9);
            this.TablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablePanel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TablePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.TablePanel.Location = new System.Drawing.Point(0, 0);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.RowCount = 10;
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.TablePanel.Size = new System.Drawing.Size(413, 246);
            this.TablePanel.TabIndex = 4;
            // 
            // CheckContent
            // 
            this.CheckContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.CheckContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CheckContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.CheckContent.Location = new System.Drawing.Point(207, 252);
            this.CheckContent.Name = "CheckContent";
            this.CheckContent.ReadOnly = true;
            this.CheckContent.Size = new System.Drawing.Size(195, 94);
            this.CheckContent.TabIndex = 9;
            this.CheckContent.Text = "";
            // 
            // DateCreateContent
            // 
            this.DateCreateContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.DateCreateContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateCreateContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.DateCreateContent.Location = new System.Drawing.Point(207, 190);
            this.DateCreateContent.Mask = "00/00/0000";
            this.DateCreateContent.Name = "DateCreateContent";
            this.DateCreateContent.Size = new System.Drawing.Size(195, 27);
            this.DateCreateContent.TabIndex = 7;
            this.DateCreateContent.ValidatingType = typeof(System.DateTime);
            // 
            // TipsContent
            // 
            this.TipsContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.TipsContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TipsContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.TipsContent.Location = new System.Drawing.Point(207, 159);
            this.TipsContent.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.TipsContent.Name = "TipsContent";
            this.TipsContent.Size = new System.Drawing.Size(195, 27);
            this.TipsContent.TabIndex = 6;
            // 
            // SaleContent
            // 
            this.SaleContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.SaleContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaleContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.SaleContent.Location = new System.Drawing.Point(207, 128);
            this.SaleContent.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.SaleContent.Name = "SaleContent";
            this.SaleContent.ReadOnly = true;
            this.SaleContent.Size = new System.Drawing.Size(195, 27);
            this.SaleContent.TabIndex = 5;
            // 
            // AmountContent
            // 
            this.AmountContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.AmountContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AmountContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.AmountContent.Location = new System.Drawing.Point(207, 97);
            this.AmountContent.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.AmountContent.Name = "AmountContent";
            this.AmountContent.ReadOnly = true;
            this.AmountContent.Size = new System.Drawing.Size(195, 27);
            this.AmountContent.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label19.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label19.Location = new System.Drawing.Point(4, 350);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(196, 200);
            this.label19.TabIndex = 18;
            this.label19.Text = "Список блюд";
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label17.Location = new System.Drawing.Point(4, 249);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(196, 100);
            this.label17.TabIndex = 16;
            this.label17.Text = "Документ";
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label15.Location = new System.Drawing.Point(4, 218);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(196, 30);
            this.label15.TabIndex = 14;
            this.label15.Text = "В архиве";
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label13.Location = new System.Drawing.Point(4, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(196, 30);
            this.label13.TabIndex = 12;
            this.label13.Text = "Дата";
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label11.Location = new System.Drawing.Point(4, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 30);
            this.label11.TabIndex = 10;
            this.label11.Text = "Чаевые";
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label9.Location = new System.Drawing.Point(4, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 30);
            this.label9.TabIndex = 8;
            this.label9.Text = "Скидка";
            // 
            // label228
            // 
            this.label228.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label228.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label228.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label228.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label228.Location = new System.Drawing.Point(4, 94);
            this.label228.Name = "label228";
            this.label228.Size = new System.Drawing.Size(196, 30);
            this.label228.TabIndex = 6;
            this.label228.Text = "Сумма";
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label5.Location = new System.Drawing.Point(4, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Официант";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label3.Location = new System.Drawing.Point(4, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Клиент";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // IdContent
            // 
            this.IdContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.IdContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdContent.Enabled = false;
            this.IdContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.IdContent.Location = new System.Drawing.Point(207, 4);
            this.IdContent.Name = "IdContent";
            this.IdContent.Size = new System.Drawing.Size(195, 27);
            this.IdContent.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IdClientContent);
            this.panel1.Controls.Add(this.SelectClientContent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(207, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 24);
            this.panel1.TabIndex = 41;
            // 
            // IdClientContent
            // 
            this.IdClientContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.IdClientContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdClientContent.Enabled = false;
            this.IdClientContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.IdClientContent.Location = new System.Drawing.Point(0, 0);
            this.IdClientContent.Name = "IdClientContent";
            this.IdClientContent.Size = new System.Drawing.Size(171, 27);
            this.IdClientContent.TabIndex = 2;
            // 
            // SelectClientContent
            // 
            this.SelectClientContent.Dock = System.Windows.Forms.DockStyle.Right;
            this.SelectClientContent.FlatAppearance.BorderSize = 0;
            this.SelectClientContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectClientContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SelectClientContent.Location = new System.Drawing.Point(171, 0);
            this.SelectClientContent.Name = "SelectClientContent";
            this.SelectClientContent.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.SelectClientContent.Size = new System.Drawing.Size(24, 24);
            this.SelectClientContent.TabIndex = 29;
            this.SelectClientContent.Text = "📂";
            this.SelectClientContent.UseVisualStyleBackColor = true;
            this.SelectClientContent.Click += new System.EventHandler(this.SelectClientContent_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.IdWaiterContent);
            this.panel2.Controls.Add(this.SelectWaiterContent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(207, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 24);
            this.panel2.TabIndex = 42;
            // 
            // IdWaiterContent
            // 
            this.IdWaiterContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.IdWaiterContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdWaiterContent.Enabled = false;
            this.IdWaiterContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.IdWaiterContent.Location = new System.Drawing.Point(0, 0);
            this.IdWaiterContent.Name = "IdWaiterContent";
            this.IdWaiterContent.Size = new System.Drawing.Size(171, 27);
            this.IdWaiterContent.TabIndex = 3;
            // 
            // SelectWaiterContent
            // 
            this.SelectWaiterContent.Dock = System.Windows.Forms.DockStyle.Right;
            this.SelectWaiterContent.FlatAppearance.BorderSize = 0;
            this.SelectWaiterContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectWaiterContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SelectWaiterContent.Location = new System.Drawing.Point(171, 0);
            this.SelectWaiterContent.Name = "SelectWaiterContent";
            this.SelectWaiterContent.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.SelectWaiterContent.Size = new System.Drawing.Size(24, 24);
            this.SelectWaiterContent.TabIndex = 28;
            this.SelectWaiterContent.Text = "📂";
            this.SelectWaiterContent.UseVisualStyleBackColor = true;
            this.SelectWaiterContent.Click += new System.EventHandler(this.SelectWaiterContent_Click);
            // 
            // IsArchiveContent
            // 
            this.IsArchiveContent.AutoSize = true;
            this.IsArchiveContent.FlatAppearance.BorderSize = 0;
            this.IsArchiveContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IsArchiveContent.Location = new System.Drawing.Point(207, 221);
            this.IsArchiveContent.Name = "IsArchiveContent";
            this.IsArchiveContent.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.IsArchiveContent.Size = new System.Drawing.Size(12, 18);
            this.IsArchiveContent.TabIndex = 8;
            this.IsArchiveContent.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DishList);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(207, 353);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(195, 194);
            this.panel3.TabIndex = 50;
            // 
            // DishList
            // 
            this.DishList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.DishList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DishList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.DishList.FormattingEnabled = true;
            this.DishList.ItemHeight = 18;
            this.DishList.Location = new System.Drawing.Point(0, 25);
            this.DishList.Name = "DishList";
            this.DishList.Size = new System.Drawing.Size(195, 169);
            this.DishList.TabIndex = 49;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.panel4.Controls.Add(this.DeleteDishContent);
            this.panel4.Controls.Add(this.AddDishContent);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(195, 25);
            this.panel4.TabIndex = 50;
            // 
            // DeleteDishContent
            // 
            this.DeleteDishContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.DeleteDishContent.FlatAppearance.BorderSize = 0;
            this.DeleteDishContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteDishContent.Font = new System.Drawing.Font("Yu Gothic", 11.25F);
            this.DeleteDishContent.ForeColor = System.Drawing.Color.Red;
            this.DeleteDishContent.Location = new System.Drawing.Point(25, 0);
            this.DeleteDishContent.Name = "DeleteDishContent";
            this.DeleteDishContent.Size = new System.Drawing.Size(25, 25);
            this.DeleteDishContent.TabIndex = 1;
            this.DeleteDishContent.Text = "-";
            this.DeleteDishContent.UseVisualStyleBackColor = true;
            this.DeleteDishContent.Click += new System.EventHandler(this.DeleteDishContent_Click);
            // 
            // AddDishContent
            // 
            this.AddDishContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddDishContent.FlatAppearance.BorderSize = 0;
            this.AddDishContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDishContent.Font = new System.Drawing.Font("Yu Gothic", 11.25F);
            this.AddDishContent.ForeColor = System.Drawing.Color.Lime;
            this.AddDishContent.Location = new System.Drawing.Point(0, 0);
            this.AddDishContent.Name = "AddDishContent";
            this.AddDishContent.Size = new System.Drawing.Size(25, 25);
            this.AddDishContent.TabIndex = 0;
            this.AddDishContent.Text = "+";
            this.AddDishContent.UseVisualStyleBackColor = true;
            this.AddDishContent.Click += new System.EventHandler(this.AddDishContent_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(161, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TablePanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.FindList);
            this.splitContainer1.Panel2.Controls.Add(this.DishBar);
            this.splitContainer1.Panel2.Controls.Add(this.Splitter);
            this.splitContainer1.Size = new System.Drawing.Size(413, 397);
            this.splitContainer1.SplitterDistance = 246;
            this.splitContainer1.TabIndex = 5;
            // 
            // FindList
            // 
            this.FindList.AutoScroll = true;
            this.FindList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindList.Location = new System.Drawing.Point(0, 30);
            this.FindList.Name = "FindList";
            this.FindList.Size = new System.Drawing.Size(413, 117);
            this.FindList.TabIndex = 11;
            // 
            // DishBar
            // 
            this.DishBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.DishBar.Controls.Add(this.SelectFindContent);
            this.DishBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.DishBar.Location = new System.Drawing.Point(0, 5);
            this.DishBar.Name = "DishBar";
            this.DishBar.Size = new System.Drawing.Size(413, 25);
            this.DishBar.TabIndex = 10;
            // 
            // SelectFindContent
            // 
            this.SelectFindContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.SelectFindContent.FlatAppearance.BorderSize = 0;
            this.SelectFindContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectFindContent.Font = new System.Drawing.Font("Yu Gothic", 11.25F);
            this.SelectFindContent.ForeColor = System.Drawing.Color.Lime;
            this.SelectFindContent.Location = new System.Drawing.Point(0, 0);
            this.SelectFindContent.Name = "SelectFindContent";
            this.SelectFindContent.Size = new System.Drawing.Size(25, 25);
            this.SelectFindContent.TabIndex = 0;
            this.SelectFindContent.Text = "✔";
            this.SelectFindContent.UseVisualStyleBackColor = true;
            this.SelectFindContent.Click += new System.EventHandler(this.SelectFindContent_Click);
            // 
            // Splitter
            // 
            this.Splitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.Splitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.Splitter.Location = new System.Drawing.Point(0, 0);
            this.Splitter.Name = "Splitter";
            this.Splitter.Size = new System.Drawing.Size(413, 5);
            this.Splitter.TabIndex = 9;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "RTF files (*.rtf)|*.rtf";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(158, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 397);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // OrderListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.LeftDock);
            this.Name = "OrderListControl";
            this.Size = new System.Drawing.Size(574, 397);
            this.LeftDock.ResumeLayout(false);
            this.TopBar.ResumeLayout(false);
            this.TablePanel.ResumeLayout(false);
            this.TablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TipsContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountContent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.DishBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftDock;
        private System.Windows.Forms.Panel ListPanel;
        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Button SaveContent;
        private System.Windows.Forms.Button DeleteContent;
        private System.Windows.Forms.Button AddContent;
        private System.Windows.Forms.TableLayoutPanel TablePanel;
        private System.Windows.Forms.TextBox IdWaiterContent;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label228;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdContent;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel Splitter;
        private System.Windows.Forms.Panel DishBar;
        private System.Windows.Forms.Button SelectFindContent;
        private System.Windows.Forms.FlowLayoutPanel FindList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SelectClientContent;
        private System.Windows.Forms.TextBox IdClientContent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SelectWaiterContent;
        private System.Windows.Forms.MaskedTextBox DateCreateContent;
        private System.Windows.Forms.NumericUpDown TipsContent;
        private System.Windows.Forms.NumericUpDown SaleContent;
        private System.Windows.Forms.NumericUpDown AmountContent;
        private System.Windows.Forms.CheckBox IsArchiveContent;
        private System.Windows.Forms.RichTextBox CheckContent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox DishList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button DeleteDishContent;
        private System.Windows.Forms.Button AddDishContent;
        private System.Windows.Forms.Button DocumentContent;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Splitter splitter1;
    }
}
