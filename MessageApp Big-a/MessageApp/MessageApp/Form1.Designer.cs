namespace MessageApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MessageBox = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.TextBox();
            this.uyeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspUyeHepsiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CheckboxData = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AddListButton = new System.Windows.Forms.Button();
            this.Numaralar = new System.Windows.Forms.ListBox();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.AllAddButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uyeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspUyeHepsiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageBox
            // 
            this.MessageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageBox.Location = new System.Drawing.Point(416, 73);
            this.MessageBox.Multiline = true;
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(357, 145);
            this.MessageBox.TabIndex = 0;
            // 
            // Number
            // 
            this.Number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Number.Location = new System.Drawing.Point(907, 73);
            this.Number.Multiline = true;
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(187, 36);
            this.Number.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 16.2F);
            this.button1.Location = new System.Drawing.Point(3, 266);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Gönder";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12.2F);
            this.label1.Location = new System.Drawing.Point(411, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mesaj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12.2F);
            this.label2.Location = new System.Drawing.Point(902, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Telefon Numarası";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(68, 125);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(208, 48);
            this.textBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 12.2F);
            this.label3.Location = new System.Drawing.Point(62, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kişi Ara";
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Yu Gothic", 16.2F);
            this.button2.Location = new System.Drawing.Point(68, 181);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 46);
            this.button2.TabIndex = 8;
            this.button2.Text = "Ara";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckboxData});
            this.dataGridView1.Location = new System.Drawing.Point(68, 309);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1169, 210);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CheckboxData
            // 
            this.CheckboxData.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CheckboxData.HeaderText = "Ekle";
            this.CheckboxData.MinimumWidth = 6;
            this.CheckboxData.Name = "CheckboxData";
            this.CheckboxData.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckboxData.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CheckboxData.Width = 125;
            // 
            // AddListButton
            // 
            this.AddListButton.BackColor = System.Drawing.Color.Turquoise;
            this.AddListButton.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddListButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddListButton.Location = new System.Drawing.Point(907, 171);
            this.AddListButton.Name = "AddListButton";
            this.AddListButton.Size = new System.Drawing.Size(146, 47);
            this.AddListButton.TabIndex = 10;
            this.AddListButton.Text = "Ekle";
            this.AddListButton.UseVisualStyleBackColor = false;
            this.AddListButton.Click += new System.EventHandler(this.AddListButton_Click);
            // 
            // Numaralar
            // 
            this.Numaralar.FormattingEnabled = true;
            this.Numaralar.ItemHeight = 16;
            this.Numaralar.Location = new System.Drawing.Point(3, 46);
            this.Numaralar.Name = "Numaralar";
            this.Numaralar.Size = new System.Drawing.Size(290, 212);
            this.Numaralar.TabIndex = 11;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.AutoSize = true;
            this.RemoveBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.RemoveBtn.Font = new System.Drawing.Font("Yu Gothic", 16.2F);
            this.RemoveBtn.Location = new System.Drawing.Point(3, 322);
            this.RemoveBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(171, 46);
            this.RemoveBtn.TabIndex = 12;
            this.RemoveBtn.Text = "Temizle";
            this.RemoveBtn.UseVisualStyleBackColor = false;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // AllAddButton
            // 
            this.AllAddButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AllAddButton.Location = new System.Drawing.Point(907, 234);
            this.AllAddButton.Name = "AllAddButton";
            this.AllAddButton.Size = new System.Drawing.Size(156, 51);
            this.AllAddButton.TabIndex = 13;
            this.AllAddButton.Text = "Tümünü Ekle";
            this.AllAddButton.UseVisualStyleBackColor = false;
            this.AllAddButton.Click += new System.EventHandler(this.AllAddButton_Click);
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.Numaralar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.RemoveBtn);
            this.panel1.Location = new System.Drawing.Point(1243, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 398);
            this.panel1.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(141, 279);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 24);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(62, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Filtrele";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1509, 473);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AllAddButton);
            this.Controls.Add(this.AddListButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.MessageBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uyeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspUyeHepsiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MessageBox;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource uspUyeHepsiBindingSource;
        private System.Windows.Forms.BindingSource uyeBindingSource;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddListButton;
        private System.Windows.Forms.ListBox Numaralar;
        private System.Windows.Forms.Button RemoveBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button AllAddButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckboxData;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
    }
}

