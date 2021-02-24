
namespace Restaurant
{
    partial class Main
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LeftDock = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.WaiterSelectBtn = new System.Windows.Forms.Button();
            this.MenuSelectBtn = new System.Windows.Forms.Button();
            this.OrderSelectBtn = new System.Windows.Forms.Button();
            this.ClientSelectBtn = new System.Windows.Forms.Button();
            this.PreviewLogoDock = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.LabelLogo = new System.Windows.Forms.Label();
            this.splitter = new System.Windows.Forms.Panel();
            this.TopDock = new System.Windows.Forms.Panel();
            this.FromTray = new System.Windows.Forms.Button();
            this.FromMaximum = new System.Windows.Forms.Button();
            this.FromExit = new System.Windows.Forms.Button();
            this.WorkSpace = new System.Windows.Forms.Panel();
            this.LeftDock.SuspendLayout();
            this.PreviewLogoDock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.TopDock.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftDock
            // 
            this.LeftDock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.LeftDock.Controls.Add(this.label1);
            this.LeftDock.Controls.Add(this.WaiterSelectBtn);
            this.LeftDock.Controls.Add(this.MenuSelectBtn);
            this.LeftDock.Controls.Add(this.OrderSelectBtn);
            this.LeftDock.Controls.Add(this.ClientSelectBtn);
            this.LeftDock.Controls.Add(this.PreviewLogoDock);
            this.LeftDock.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftDock.Location = new System.Drawing.Point(0, 0);
            this.LeftDock.Name = "LeftDock";
            this.LeftDock.Size = new System.Drawing.Size(167, 600);
            this.LeftDock.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(0, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "ver: 1.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // WaiterSelectBtn
            // 
            this.WaiterSelectBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.WaiterSelectBtn.FlatAppearance.BorderSize = 0;
            this.WaiterSelectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WaiterSelectBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WaiterSelectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.WaiterSelectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WaiterSelectBtn.Location = new System.Drawing.Point(0, 244);
            this.WaiterSelectBtn.Name = "WaiterSelectBtn";
            this.WaiterSelectBtn.Size = new System.Drawing.Size(167, 50);
            this.WaiterSelectBtn.TabIndex = 4;
            this.WaiterSelectBtn.Text = "👷 Официанты";
            this.WaiterSelectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WaiterSelectBtn.UseVisualStyleBackColor = true;
            this.WaiterSelectBtn.Click += new System.EventHandler(this.WaiterSelectBtn_Click);
            // 
            // MenuSelectBtn
            // 
            this.MenuSelectBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuSelectBtn.FlatAppearance.BorderSize = 0;
            this.MenuSelectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuSelectBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuSelectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.MenuSelectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuSelectBtn.Location = new System.Drawing.Point(0, 194);
            this.MenuSelectBtn.Name = "MenuSelectBtn";
            this.MenuSelectBtn.Size = new System.Drawing.Size(167, 50);
            this.MenuSelectBtn.TabIndex = 3;
            this.MenuSelectBtn.Text = "🍜 Меню и блюда";
            this.MenuSelectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuSelectBtn.UseVisualStyleBackColor = true;
            this.MenuSelectBtn.Click += new System.EventHandler(this.MenuSelectBtn_Click);
            // 
            // OrderSelectBtn
            // 
            this.OrderSelectBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrderSelectBtn.FlatAppearance.BorderSize = 0;
            this.OrderSelectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderSelectBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderSelectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.OrderSelectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrderSelectBtn.Location = new System.Drawing.Point(0, 144);
            this.OrderSelectBtn.Name = "OrderSelectBtn";
            this.OrderSelectBtn.Size = new System.Drawing.Size(167, 50);
            this.OrderSelectBtn.TabIndex = 2;
            this.OrderSelectBtn.Text = "📝 Заказы";
            this.OrderSelectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrderSelectBtn.UseVisualStyleBackColor = true;
            this.OrderSelectBtn.Click += new System.EventHandler(this.OrderSelectBtn_Click);
            // 
            // ClientSelectBtn
            // 
            this.ClientSelectBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientSelectBtn.FlatAppearance.BorderSize = 0;
            this.ClientSelectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientSelectBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientSelectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.ClientSelectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClientSelectBtn.Location = new System.Drawing.Point(0, 94);
            this.ClientSelectBtn.Name = "ClientSelectBtn";
            this.ClientSelectBtn.Size = new System.Drawing.Size(167, 50);
            this.ClientSelectBtn.TabIndex = 0;
            this.ClientSelectBtn.Text = "👤 Посетители";
            this.ClientSelectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClientSelectBtn.UseVisualStyleBackColor = true;
            this.ClientSelectBtn.Click += new System.EventHandler(this.ClientSelectBtn_Click);
            // 
            // PreviewLogoDock
            // 
            this.PreviewLogoDock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.PreviewLogoDock.Controls.Add(this.Logo);
            this.PreviewLogoDock.Controls.Add(this.LabelLogo);
            this.PreviewLogoDock.Controls.Add(this.splitter);
            this.PreviewLogoDock.Dock = System.Windows.Forms.DockStyle.Top;
            this.PreviewLogoDock.Location = new System.Drawing.Point(0, 0);
            this.PreviewLogoDock.Name = "PreviewLogoDock";
            this.PreviewLogoDock.Size = new System.Drawing.Size(167, 94);
            this.PreviewLogoDock.TabIndex = 1;
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logo.Image = global::Restaurant.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(167, 71);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // LabelLogo
            // 
            this.LabelLogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabelLogo.Font = new System.Drawing.Font("Vladimir Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.LabelLogo.Location = new System.Drawing.Point(0, 71);
            this.LabelLogo.Name = "LabelLogo";
            this.LabelLogo.Size = new System.Drawing.Size(167, 22);
            this.LabelLogo.TabIndex = 1;
            this.LabelLogo.Text = "Restaurant CRM";
            this.LabelLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelLogo.UseCompatibleTextRendering = true;
            this.LabelLogo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // splitter
            // 
            this.splitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.splitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter.Location = new System.Drawing.Point(0, 93);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(167, 1);
            this.splitter.TabIndex = 2;
            // 
            // TopDock
            // 
            this.TopDock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.TopDock.Controls.Add(this.FromTray);
            this.TopDock.Controls.Add(this.FromMaximum);
            this.TopDock.Controls.Add(this.FromExit);
            this.TopDock.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopDock.Location = new System.Drawing.Point(167, 0);
            this.TopDock.Name = "TopDock";
            this.TopDock.Size = new System.Drawing.Size(633, 30);
            this.TopDock.TabIndex = 1;
            this.TopDock.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // FromTray
            // 
            this.FromTray.Dock = System.Windows.Forms.DockStyle.Right;
            this.FromTray.FlatAppearance.BorderSize = 0;
            this.FromTray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FromTray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FromTray.Location = new System.Drawing.Point(543, 0);
            this.FromTray.Name = "FromTray";
            this.FromTray.Size = new System.Drawing.Size(30, 30);
            this.FromTray.TabIndex = 1;
            this.FromTray.Text = "__";
            this.FromTray.UseVisualStyleBackColor = true;
            this.FromTray.Click += new System.EventHandler(this.FromTray_Click);
            // 
            // FromMaximum
            // 
            this.FromMaximum.Dock = System.Windows.Forms.DockStyle.Right;
            this.FromMaximum.FlatAppearance.BorderSize = 0;
            this.FromMaximum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FromMaximum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromMaximum.ForeColor = System.Drawing.Color.Lime;
            this.FromMaximum.Location = new System.Drawing.Point(573, 0);
            this.FromMaximum.Name = "FromMaximum";
            this.FromMaximum.Size = new System.Drawing.Size(30, 30);
            this.FromMaximum.TabIndex = 0;
            this.FromMaximum.Text = "◻";
            this.FromMaximum.UseVisualStyleBackColor = true;
            this.FromMaximum.Click += new System.EventHandler(this.FromMaximum_Click);
            // 
            // FromExit
            // 
            this.FromExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.FromExit.FlatAppearance.BorderSize = 0;
            this.FromExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FromExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromExit.ForeColor = System.Drawing.Color.Red;
            this.FromExit.Location = new System.Drawing.Point(603, 0);
            this.FromExit.Name = "FromExit";
            this.FromExit.Size = new System.Drawing.Size(30, 30);
            this.FromExit.TabIndex = 2;
            this.FromExit.Text = "❌";
            this.FromExit.UseVisualStyleBackColor = true;
            this.FromExit.Click += new System.EventHandler(this.FromExit_Click);
            // 
            // WorkSpace
            // 
            this.WorkSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkSpace.Location = new System.Drawing.Point(167, 30);
            this.WorkSpace.Name = "WorkSpace";
            this.WorkSpace.Size = new System.Drawing.Size(633, 570);
            this.WorkSpace.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.WorkSpace);
            this.Controls.Add(this.TopDock);
            this.Controls.Add(this.LeftDock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.LeftDock.ResumeLayout(false);
            this.PreviewLogoDock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.TopDock.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftDock;
        private System.Windows.Forms.Panel TopDock;
        private System.Windows.Forms.Button FromMaximum;
        private System.Windows.Forms.Button FromTray;
        private System.Windows.Forms.Button FromExit;
        private System.Windows.Forms.Panel PreviewLogoDock;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label LabelLogo;
        private System.Windows.Forms.Button ClientSelectBtn;
        private System.Windows.Forms.Button WaiterSelectBtn;
        private System.Windows.Forms.Button MenuSelectBtn;
        private System.Windows.Forms.Button OrderSelectBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel splitter;
        private System.Windows.Forms.Panel WorkSpace;
    }
}

