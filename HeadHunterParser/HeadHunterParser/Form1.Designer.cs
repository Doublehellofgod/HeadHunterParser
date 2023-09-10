
namespace HeadHunterParser
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.GreatePage = new System.Windows.Forms.TabPage();
            this.Page1 = new System.Windows.Forms.TabPage();
            this.textAdd = new System.Windows.Forms.TextBox();
            this.DelNeed = new System.Windows.Forms.Button();
            this.AddNeed = new System.Windows.Forms.Button();
            this.dataGridViewAdd = new System.Windows.Forms.DataGridView();
            this.Page2 = new System.Windows.Forms.TabPage();
            this.textBoxUseless = new System.Windows.Forms.TextBox();
            this.DelUseless = new System.Windows.Forms.Button();
            this.AddUseless = new System.Windows.Forms.Button();
            this.dataGridViewUseless = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.GreatePage.SuspendLayout();
            this.Page1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdd)).BeginInit();
            this.Page2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUseless)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 48);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(136, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(650, 409);
            this.listBox1.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.GreatePage);
            this.tabControl1.Controls.Add(this.Page1);
            this.tabControl1.Controls.Add(this.Page2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 7;
            // 
            // GreatePage
            // 
            this.GreatePage.Controls.Add(this.listBox1);
            this.GreatePage.Controls.Add(this.label1);
            this.GreatePage.Controls.Add(this.button1);
            this.GreatePage.Controls.Add(this.progressBar1);
            this.GreatePage.Location = new System.Drawing.Point(4, 24);
            this.GreatePage.Name = "GreatePage";
            this.GreatePage.Padding = new System.Windows.Forms.Padding(3);
            this.GreatePage.Size = new System.Drawing.Size(792, 422);
            this.GreatePage.TabIndex = 1;
            this.GreatePage.Text = "Главная";
            this.GreatePage.UseVisualStyleBackColor = true;
            // 
            // Page1
            // 
            this.Page1.Controls.Add(this.textAdd);
            this.Page1.Controls.Add(this.DelNeed);
            this.Page1.Controls.Add(this.AddNeed);
            this.Page1.Controls.Add(this.dataGridViewAdd);
            this.Page1.Location = new System.Drawing.Point(4, 24);
            this.Page1.Name = "Page1";
            this.Page1.Padding = new System.Windows.Forms.Padding(3);
            this.Page1.Size = new System.Drawing.Size(792, 422);
            this.Page1.TabIndex = 0;
            this.Page1.Text = "Нужное";
            this.Page1.UseVisualStyleBackColor = true;
            // 
            // textAdd
            // 
            this.textAdd.Location = new System.Drawing.Point(155, 7);
            this.textAdd.Name = "textAdd";
            this.textAdd.Size = new System.Drawing.Size(463, 23);
            this.textAdd.TabIndex = 3;
            // 
            // DelNeed
            // 
            this.DelNeed.Location = new System.Drawing.Point(24, 35);
            this.DelNeed.Name = "DelNeed";
            this.DelNeed.Size = new System.Drawing.Size(111, 23);
            this.DelNeed.TabIndex = 2;
            this.DelNeed.Text = "Удалить";
            this.DelNeed.UseVisualStyleBackColor = true;
            // 
            // AddNeed
            // 
            this.AddNeed.Location = new System.Drawing.Point(24, 6);
            this.AddNeed.Name = "AddNeed";
            this.AddNeed.Size = new System.Drawing.Size(111, 23);
            this.AddNeed.TabIndex = 1;
            this.AddNeed.Text = "Добавить";
            this.AddNeed.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAdd
            // 
            this.dataGridViewAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdd.Location = new System.Drawing.Point(8, 74);
            this.dataGridViewAdd.Name = "dataGridViewAdd";
            this.dataGridViewAdd.RowTemplate.Height = 25;
            this.dataGridViewAdd.Size = new System.Drawing.Size(781, 340);
            this.dataGridViewAdd.TabIndex = 0;
            // 
            // Page2
            // 
            this.Page2.Controls.Add(this.textBoxUseless);
            this.Page2.Controls.Add(this.DelUseless);
            this.Page2.Controls.Add(this.AddUseless);
            this.Page2.Controls.Add(this.dataGridViewUseless);
            this.Page2.Location = new System.Drawing.Point(4, 24);
            this.Page2.Name = "Page2";
            this.Page2.Size = new System.Drawing.Size(792, 422);
            this.Page2.TabIndex = 2;
            this.Page2.Text = "Отсутствующее";
            this.Page2.UseVisualStyleBackColor = true;
            // 
            // textBoxUseless
            // 
            this.textBoxUseless.Location = new System.Drawing.Point(159, 12);
            this.textBoxUseless.Name = "textBoxUseless";
            this.textBoxUseless.Size = new System.Drawing.Size(463, 23);
            this.textBoxUseless.TabIndex = 6;
            // 
            // DelUseless
            // 
            this.DelUseless.Location = new System.Drawing.Point(28, 40);
            this.DelUseless.Name = "DelUseless";
            this.DelUseless.Size = new System.Drawing.Size(111, 23);
            this.DelUseless.TabIndex = 5;
            this.DelUseless.Text = "Удалить";
            this.DelUseless.UseVisualStyleBackColor = true;
            // 
            // AddUseless
            // 
            this.AddUseless.Location = new System.Drawing.Point(28, 11);
            this.AddUseless.Name = "AddUseless";
            this.AddUseless.Size = new System.Drawing.Size(111, 23);
            this.AddUseless.TabIndex = 4;
            this.AddUseless.Text = "Добавить";
            this.AddUseless.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUseless
            // 
            this.dataGridViewUseless.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUseless.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUseless.Location = new System.Drawing.Point(8, 69);
            this.dataGridViewUseless.Name = "dataGridViewUseless";
            this.dataGridViewUseless.RowTemplate.Height = 25;
            this.dataGridViewUseless.Size = new System.Drawing.Size(781, 345);
            this.dataGridViewUseless.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.GreatePage.ResumeLayout(false);
            this.GreatePage.PerformLayout();
            this.Page1.ResumeLayout(false);
            this.Page1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdd)).EndInit();
            this.Page2.ResumeLayout(false);
            this.Page2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUseless)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Page1;
        private System.Windows.Forms.TabPage GreatePage;
        private System.Windows.Forms.TabPage Page2;
        private System.Windows.Forms.DataGridView dataGridViewAdd;
        private System.Windows.Forms.TextBox textAdd;
        private System.Windows.Forms.Button DelNeed;
        private System.Windows.Forms.Button AddNeed;
        private System.Windows.Forms.DataGridView dataGridViewUseless;
        private System.Windows.Forms.TextBox textBoxUseless;
        private System.Windows.Forms.Button DelUseless;
        private System.Windows.Forms.Button AddUseless;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Label label1;
    }
}

