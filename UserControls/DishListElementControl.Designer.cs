
namespace Restaurant
{
    partial class DishListElementControl
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
            this.Content = new System.Windows.Forms.Panel();
            this.LeftDock = new System.Windows.Forms.Panel();
            this.ItemName = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.Icon = new System.Windows.Forms.PictureBox();
            this.Content.SuspendLayout();
            this.LeftDock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.Controls.Add(this.LeftDock);
            this.Content.Controls.Add(this.Icon);
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(111, 121);
            this.Content.TabIndex = 9;
            // 
            // LeftDock
            // 
            this.LeftDock.Controls.Add(this.ItemName);
            this.LeftDock.Controls.Add(this.Id);
            this.LeftDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftDock.Location = new System.Drawing.Point(0, 63);
            this.LeftDock.Name = "LeftDock";
            this.LeftDock.Size = new System.Drawing.Size(111, 58);
            this.LeftDock.TabIndex = 4;
            // 
            // ItemName
            // 
            this.ItemName.Dock = System.Windows.Forms.DockStyle.Top;
            this.ItemName.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.ItemName.Location = new System.Drawing.Point(0, 23);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(111, 30);
            this.ItemName.TabIndex = 5;
            this.ItemName.Text = "ItemName";
            // 
            // Id
            // 
            this.Id.Dock = System.Windows.Forms.DockStyle.Top;
            this.Id.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.Id.Location = new System.Drawing.Point(0, 0);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(111, 23);
            this.Id.TabIndex = 4;
            this.Id.Text = "ID";
            // 
            // Icon
            // 
            this.Icon.Dock = System.Windows.Forms.DockStyle.Top;
            this.Icon.Image = global::Restaurant.Properties.Resources.вш;
            this.Icon.Location = new System.Drawing.Point(0, 0);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(111, 63);
            this.Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon.TabIndex = 0;
            this.Icon.TabStop = false;
            // 
            // DishListElementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Content);
            this.Name = "DishListElementControl";
            this.Size = new System.Drawing.Size(111, 121);
            this.Content.ResumeLayout(false);
            this.LeftDock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.Panel LeftDock;
        public System.Windows.Forms.Label ItemName;
        public System.Windows.Forms.Label Id;
        public System.Windows.Forms.PictureBox Icon;
    }
}
