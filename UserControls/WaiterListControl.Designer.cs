
namespace Restaurant
{
    partial class WaiterListControl
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
            this.SaveContent = new System.Windows.Forms.Button();
            this.DeleteContent = new System.Windows.Forms.Button();
            this.AddContent = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.TablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.TipsContent = new System.Windows.Forms.NumericUpDown();
            this.WageContent = new System.Windows.Forms.NumericUpDown();
            this.OldContent = new System.Windows.Forms.NumericUpDown();
            this.Patronymic = new System.Windows.Forms.TextBox();
            this.FirstNameContent = new System.Windows.Forms.TextBox();
            this.LastNameContent = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label228 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SexContent = new System.Windows.Forms.ComboBox();
            this.CurrentWageContent = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.IdContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PostContent = new System.Windows.Forms.RichTextBox();
            this.PhotoContent = new System.Windows.Forms.PictureBox();
            this.ShecludeContent = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OrderList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LeftDock.SuspendLayout();
            this.TopBar.SuspendLayout();
            this.TablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TipsContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WageContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OldContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentWageContent)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoContent)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftDock
            // 
            this.LeftDock.Controls.Add(this.ListPanel);
            this.LeftDock.Controls.Add(this.TopBar);
            this.LeftDock.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftDock.Location = new System.Drawing.Point(0, 0);
            this.LeftDock.Name = "LeftDock";
            this.LeftDock.Size = new System.Drawing.Size(170, 600);
            this.LeftDock.TabIndex = 3;
            // 
            // ListPanel
            // 
            this.ListPanel.AutoScroll = true;
            this.ListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.ListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPanel.Location = new System.Drawing.Point(0, 25);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(170, 575);
            this.ListPanel.TabIndex = 2;
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.TopBar.Controls.Add(this.SaveContent);
            this.TopBar.Controls.Add(this.DeleteContent);
            this.TopBar.Controls.Add(this.AddContent);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(170, 25);
            this.TopBar.TabIndex = 1;
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
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(170, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 600);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // TablePanel
            // 
            this.TablePanel.AutoScroll = true;
            this.TablePanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TablePanel.ColumnCount = 2;
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.19843F));
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.80157F));
            this.TablePanel.Controls.Add(this.TipsContent, 1, 7);
            this.TablePanel.Controls.Add(this.WageContent, 1, 6);
            this.TablePanel.Controls.Add(this.OldContent, 1, 5);
            this.TablePanel.Controls.Add(this.Patronymic, 1, 3);
            this.TablePanel.Controls.Add(this.FirstNameContent, 1, 2);
            this.TablePanel.Controls.Add(this.LastNameContent, 1, 1);
            this.TablePanel.Controls.Add(this.label21, 0, 9);
            this.TablePanel.Controls.Add(this.label17, 0, 7);
            this.TablePanel.Controls.Add(this.label15, 0, 6);
            this.TablePanel.Controls.Add(this.label13, 0, 5);
            this.TablePanel.Controls.Add(this.label11, 0, 4);
            this.TablePanel.Controls.Add(this.label9, 0, 3);
            this.TablePanel.Controls.Add(this.label228, 0, 2);
            this.TablePanel.Controls.Add(this.label5, 0, 1);
            this.TablePanel.Controls.Add(this.SexContent, 1, 4);
            this.TablePanel.Controls.Add(this.CurrentWageContent, 1, 8);
            this.TablePanel.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.TablePanel.Controls.Add(this.PhotoContent, 0, 0);
            this.TablePanel.Controls.Add(this.ShecludeContent, 1, 9);
            this.TablePanel.Controls.Add(this.label3, 0, 10);
            this.TablePanel.Controls.Add(this.OrderList, 1, 10);
            this.TablePanel.Controls.Add(this.label4, 0, 8);
            this.TablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablePanel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TablePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.TablePanel.Location = new System.Drawing.Point(173, 0);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.RowCount = 11;
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.TablePanel.Size = new System.Drawing.Size(401, 600);
            this.TablePanel.TabIndex = 5;
            // 
            // TipsContent
            // 
            this.TipsContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.TipsContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TipsContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.TipsContent.Location = new System.Drawing.Point(117, 294);
            this.TipsContent.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.TipsContent.Name = "TipsContent";
            this.TipsContent.ReadOnly = true;
            this.TipsContent.Size = new System.Drawing.Size(280, 27);
            this.TipsContent.TabIndex = 39;
            // 
            // WageContent
            // 
            this.WageContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.WageContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WageContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.WageContent.Location = new System.Drawing.Point(117, 263);
            this.WageContent.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.WageContent.Name = "WageContent";
            this.WageContent.ReadOnly = true;
            this.WageContent.Size = new System.Drawing.Size(280, 27);
            this.WageContent.TabIndex = 38;
            // 
            // OldContent
            // 
            this.OldContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.OldContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OldContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.OldContent.Location = new System.Drawing.Point(117, 232);
            this.OldContent.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.OldContent.Name = "OldContent";
            this.OldContent.Size = new System.Drawing.Size(280, 27);
            this.OldContent.TabIndex = 37;
            // 
            // Patronymic
            // 
            this.Patronymic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.Patronymic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Patronymic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.Patronymic.Location = new System.Drawing.Point(117, 170);
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Size = new System.Drawing.Size(280, 27);
            this.Patronymic.TabIndex = 28;
            // 
            // FirstNameContent
            // 
            this.FirstNameContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.FirstNameContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstNameContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.FirstNameContent.Location = new System.Drawing.Point(117, 139);
            this.FirstNameContent.Name = "FirstNameContent";
            this.FirstNameContent.Size = new System.Drawing.Size(280, 27);
            this.FirstNameContent.TabIndex = 27;
            // 
            // LastNameContent
            // 
            this.LastNameContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.LastNameContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LastNameContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.LastNameContent.Location = new System.Drawing.Point(117, 108);
            this.LastNameContent.Name = "LastNameContent";
            this.LastNameContent.Size = new System.Drawing.Size(280, 27);
            this.LastNameContent.TabIndex = 26;
            // 
            // label21
            // 
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label21.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label21.Location = new System.Drawing.Point(4, 353);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(106, 56);
            this.label21.TabIndex = 20;
            this.label21.Text = "График работы";
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label17.Location = new System.Drawing.Point(4, 291);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 30);
            this.label17.TabIndex = 16;
            this.label17.Text = "Чаевые";
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label15.Location = new System.Drawing.Point(4, 260);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 30);
            this.label15.TabIndex = 14;
            this.label15.Text = "Зарплата";
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label13.Location = new System.Drawing.Point(4, 229);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 30);
            this.label13.TabIndex = 12;
            this.label13.Text = "Возраст";
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label11.Location = new System.Drawing.Point(4, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 30);
            this.label11.TabIndex = 10;
            this.label11.Text = "Пол";
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label9.Location = new System.Drawing.Point(4, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 30);
            this.label9.TabIndex = 8;
            this.label9.Text = "Отчество";
            // 
            // label228
            // 
            this.label228.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label228.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label228.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label228.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label228.Location = new System.Drawing.Point(4, 136);
            this.label228.Name = "label228";
            this.label228.Size = new System.Drawing.Size(106, 30);
            this.label228.TabIndex = 6;
            this.label228.Text = "Имя";
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label5.Location = new System.Drawing.Point(4, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Фамилия";
            // 
            // SexContent
            // 
            this.SexContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.SexContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SexContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SexContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.SexContent.FormattingEnabled = true;
            this.SexContent.Items.AddRange(new object[] {
            "Муж",
            "Жен",
            "Другое"});
            this.SexContent.Location = new System.Drawing.Point(117, 201);
            this.SexContent.Name = "SexContent";
            this.SexContent.Size = new System.Drawing.Size(280, 26);
            this.SexContent.TabIndex = 34;
            // 
            // CurrentWageContent
            // 
            this.CurrentWageContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.CurrentWageContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentWageContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.CurrentWageContent.Location = new System.Drawing.Point(117, 325);
            this.CurrentWageContent.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.CurrentWageContent.Name = "CurrentWageContent";
            this.CurrentWageContent.Size = new System.Drawing.Size(280, 27);
            this.CurrentWageContent.TabIndex = 36;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.82258F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.17742F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.IdContent, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PostContent, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(117, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 97);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(4, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 64);
            this.label2.TabIndex = 26;
            this.label2.Text = "Должность";
            // 
            // IdContent
            // 
            this.IdContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.IdContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdContent.Enabled = false;
            this.IdContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.IdContent.Location = new System.Drawing.Point(82, 4);
            this.IdContent.Name = "IdContent";
            this.IdContent.Size = new System.Drawing.Size(194, 27);
            this.IdContent.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // PostContent
            // 
            this.PostContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.PostContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PostContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PostContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.PostContent.Location = new System.Drawing.Point(82, 35);
            this.PostContent.Name = "PostContent";
            this.PostContent.Size = new System.Drawing.Size(194, 58);
            this.PostContent.TabIndex = 27;
            this.PostContent.Text = "";
            // 
            // PhotoContent
            // 
            this.PhotoContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhotoContent.Image = global::Restaurant.Properties.Resources.images;
            this.PhotoContent.Location = new System.Drawing.Point(4, 4);
            this.PhotoContent.Name = "PhotoContent";
            this.PhotoContent.Size = new System.Drawing.Size(106, 97);
            this.PhotoContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoContent.TabIndex = 42;
            this.PhotoContent.TabStop = false;
            this.PhotoContent.DoubleClick += new System.EventHandler(this.PhotoContent_DoubleClick);
            // 
            // ShecludeContent
            // 
            this.ShecludeContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.ShecludeContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShecludeContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShecludeContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.ShecludeContent.Location = new System.Drawing.Point(117, 356);
            this.ShecludeContent.Name = "ShecludeContent";
            this.ShecludeContent.Size = new System.Drawing.Size(280, 50);
            this.ShecludeContent.TabIndex = 43;
            this.ShecludeContent.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "Заказы";
            // 
            // OrderList
            // 
            this.OrderList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.OrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.OrderList.FormattingEnabled = true;
            this.OrderList.ItemHeight = 18;
            this.OrderList.Location = new System.Drawing.Point(117, 413);
            this.OrderList.Name = "OrderList";
            this.OrderList.Size = new System.Drawing.Size(280, 183);
            this.OrderList.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 46;
            this.label4.Text = "К выплате";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|jpeg files (*.jpeg)|*.jpeg|ico fi" +
    "les (*.ico)|*.ico";
            // 
            // WaiterListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.Controls.Add(this.TablePanel);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.LeftDock);
            this.Name = "WaiterListControl";
            this.Size = new System.Drawing.Size(574, 600);
            this.LeftDock.ResumeLayout(false);
            this.TopBar.ResumeLayout(false);
            this.TablePanel.ResumeLayout(false);
            this.TablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TipsContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WageContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OldContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentWageContent)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftDock;
        private System.Windows.Forms.Panel ListPanel;
        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Button SaveContent;
        private System.Windows.Forms.Button DeleteContent;
        private System.Windows.Forms.Button AddContent;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TableLayoutPanel TablePanel;
        private System.Windows.Forms.NumericUpDown TipsContent;
        private System.Windows.Forms.NumericUpDown WageContent;
        private System.Windows.Forms.NumericUpDown OldContent;
        private System.Windows.Forms.TextBox Patronymic;
        private System.Windows.Forms.TextBox FirstNameContent;
        private System.Windows.Forms.TextBox LastNameContent;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label228;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SexContent;
        private System.Windows.Forms.NumericUpDown CurrentWageContent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox IdContent;
        private System.Windows.Forms.PictureBox PhotoContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox PostContent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox ShecludeContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox OrderList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
    }
}
