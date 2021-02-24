
namespace Restaurant
{
    partial class MenuListControl
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
            this.DishList = new System.Windows.Forms.FlowLayoutPanel();
            this.PolyContent = new System.Windows.Forms.TableLayoutPanel();
            this.NameContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PublishContent = new System.Windows.Forms.MaskedTextBox();
            this.UnPublishContent = new System.Windows.Forms.MaskedTextBox();
            this.PhotoContent = new System.Windows.Forms.PictureBox();
            this.SplitContent = new System.Windows.Forms.SplitContainer();
            this.DishBar = new System.Windows.Forms.Panel();
            this.OpenDishContent = new System.Windows.Forms.Button();
            this.DeleteDishContent = new System.Windows.Forms.Button();
            this.AddDishContent = new System.Windows.Forms.Button();
            this.Splitter = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LeftDock.SuspendLayout();
            this.TopBar.SuspendLayout();
            this.PolyContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContent)).BeginInit();
            this.SplitContent.Panel1.SuspendLayout();
            this.SplitContent.Panel2.SuspendLayout();
            this.SplitContent.SuspendLayout();
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
            this.LeftDock.Size = new System.Drawing.Size(147, 395);
            this.LeftDock.TabIndex = 3;
            // 
            // ListPanel
            // 
            this.ListPanel.AutoScroll = true;
            this.ListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.ListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPanel.Location = new System.Drawing.Point(0, 25);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(147, 370);
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
            this.TopBar.Size = new System.Drawing.Size(147, 25);
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
            // DishList
            // 
            this.DishList.AutoScroll = true;
            this.DishList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DishList.Location = new System.Drawing.Point(0, 30);
            this.DishList.Name = "DishList";
            this.DishList.Size = new System.Drawing.Size(433, 161);
            this.DishList.TabIndex = 4;
            // 
            // PolyContent
            // 
            this.PolyContent.AutoScroll = true;
            this.PolyContent.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.PolyContent.ColumnCount = 2;
            this.PolyContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.65281F));
            this.PolyContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.34719F));
            this.PolyContent.Controls.Add(this.NameContent, 1, 1);
            this.PolyContent.Controls.Add(this.label1, 0, 0);
            this.PolyContent.Controls.Add(this.IdContent, 1, 0);
            this.PolyContent.Controls.Add(this.label2, 0, 1);
            this.PolyContent.Controls.Add(this.label3, 0, 2);
            this.PolyContent.Controls.Add(this.label4, 0, 3);
            this.PolyContent.Controls.Add(this.label5, 0, 4);
            this.PolyContent.Controls.Add(this.PublishContent, 1, 2);
            this.PolyContent.Controls.Add(this.UnPublishContent, 1, 3);
            this.PolyContent.Controls.Add(this.PhotoContent, 1, 4);
            this.PolyContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PolyContent.Location = new System.Drawing.Point(0, 0);
            this.PolyContent.Name = "PolyContent";
            this.PolyContent.RowCount = 6;
            this.PolyContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PolyContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PolyContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PolyContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PolyContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.PolyContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.PolyContent.Size = new System.Drawing.Size(433, 200);
            this.PolyContent.TabIndex = 5;
            // 
            // NameContent
            // 
            this.NameContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.NameContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.NameContent.Location = new System.Drawing.Point(163, 35);
            this.NameContent.Name = "NameContent";
            this.NameContent.Size = new System.Drawing.Size(256, 20);
            this.NameContent.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // IdContent
            // 
            this.IdContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.IdContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdContent.Enabled = false;
            this.IdContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.IdContent.Location = new System.Drawing.Point(163, 4);
            this.IdContent.Name = "IdContent";
            this.IdContent.Size = new System.Drawing.Size(256, 20);
            this.IdContent.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(4, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 30);
            this.label2.TabIndex = 26;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label3.Location = new System.Drawing.Point(4, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 30);
            this.label3.TabIndex = 27;
            this.label3.Text = "Опубликация";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label4.Location = new System.Drawing.Point(4, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 30);
            this.label4.TabIndex = 28;
            this.label4.Text = "Действительна";
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.label5.Location = new System.Drawing.Point(4, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 200);
            this.label5.TabIndex = 29;
            this.label5.Text = "Бумажный вид";
            // 
            // PublishContent
            // 
            this.PublishContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.PublishContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PublishContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.PublishContent.Location = new System.Drawing.Point(163, 66);
            this.PublishContent.Mask = "00/00/0000";
            this.PublishContent.Name = "PublishContent";
            this.PublishContent.Size = new System.Drawing.Size(256, 20);
            this.PublishContent.TabIndex = 3;
            this.PublishContent.ValidatingType = typeof(System.DateTime);
            // 
            // UnPublishContent
            // 
            this.UnPublishContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.UnPublishContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnPublishContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.UnPublishContent.Location = new System.Drawing.Point(163, 97);
            this.UnPublishContent.Mask = "00/00/0000";
            this.UnPublishContent.Name = "UnPublishContent";
            this.UnPublishContent.Size = new System.Drawing.Size(256, 20);
            this.UnPublishContent.TabIndex = 4;
            this.UnPublishContent.ValidatingType = typeof(System.DateTime);
            // 
            // PhotoContent
            // 
            this.PhotoContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhotoContent.Image = global::Restaurant.Properties.Resources.DefaultMenuIcon;
            this.PhotoContent.Location = new System.Drawing.Point(163, 128);
            this.PhotoContent.Name = "PhotoContent";
            this.PhotoContent.Size = new System.Drawing.Size(256, 194);
            this.PhotoContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoContent.TabIndex = 43;
            this.PhotoContent.TabStop = false;
            this.PhotoContent.DoubleClick += new System.EventHandler(this.PhotoContent_DoubleClick);
            // 
            // SplitContent
            // 
            this.SplitContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContent.Location = new System.Drawing.Point(147, 0);
            this.SplitContent.Name = "SplitContent";
            this.SplitContent.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContent.Panel1
            // 
            this.SplitContent.Panel1.Controls.Add(this.PolyContent);
            // 
            // SplitContent.Panel2
            // 
            this.SplitContent.Panel2.Controls.Add(this.DishList);
            this.SplitContent.Panel2.Controls.Add(this.DishBar);
            this.SplitContent.Panel2.Controls.Add(this.Splitter);
            this.SplitContent.Size = new System.Drawing.Size(433, 395);
            this.SplitContent.SplitterDistance = 200;
            this.SplitContent.TabIndex = 6;
            // 
            // DishBar
            // 
            this.DishBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.DishBar.Controls.Add(this.OpenDishContent);
            this.DishBar.Controls.Add(this.DeleteDishContent);
            this.DishBar.Controls.Add(this.AddDishContent);
            this.DishBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.DishBar.Location = new System.Drawing.Point(0, 5);
            this.DishBar.Name = "DishBar";
            this.DishBar.Size = new System.Drawing.Size(433, 25);
            this.DishBar.TabIndex = 5;
            // 
            // OpenDishContent
            // 
            this.OpenDishContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.OpenDishContent.FlatAppearance.BorderSize = 0;
            this.OpenDishContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenDishContent.Font = new System.Drawing.Font("Yu Gothic", 11.25F);
            this.OpenDishContent.ForeColor = System.Drawing.Color.Orange;
            this.OpenDishContent.Location = new System.Drawing.Point(50, 0);
            this.OpenDishContent.Name = "OpenDishContent";
            this.OpenDishContent.Size = new System.Drawing.Size(25, 25);
            this.OpenDishContent.TabIndex = 2;
            this.OpenDishContent.Text = "📂";
            this.OpenDishContent.UseVisualStyleBackColor = true;
            this.OpenDishContent.Click += new System.EventHandler(this.OpenDishContent_Click);
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
            // Splitter
            // 
            this.Splitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.Splitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.Splitter.Location = new System.Drawing.Point(0, 0);
            this.Splitter.Name = "Splitter";
            this.Splitter.Size = new System.Drawing.Size(433, 5);
            this.Splitter.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|jpeg files (*.jpeg)|*.jpeg";
            // 
            // MenuListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.Controls.Add(this.SplitContent);
            this.Controls.Add(this.LeftDock);
            this.Name = "MenuListControl";
            this.Size = new System.Drawing.Size(580, 395);
            this.LeftDock.ResumeLayout(false);
            this.TopBar.ResumeLayout(false);
            this.PolyContent.ResumeLayout(false);
            this.PolyContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoContent)).EndInit();
            this.SplitContent.Panel1.ResumeLayout(false);
            this.SplitContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContent)).EndInit();
            this.SplitContent.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer SplitContent;
        private System.Windows.Forms.TableLayoutPanel PolyContent;
        private System.Windows.Forms.FlowLayoutPanel DishList;
        private System.Windows.Forms.Panel DishBar;
        private System.Windows.Forms.Button DeleteDishContent;
        private System.Windows.Forms.Button AddDishContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameContent;
        private System.Windows.Forms.MaskedTextBox PublishContent;
        private System.Windows.Forms.MaskedTextBox UnPublishContent;
        private System.Windows.Forms.PictureBox PhotoContent;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel Splitter;
        private System.Windows.Forms.Button OpenDishContent;
    }
}
