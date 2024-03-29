﻿namespace MessageApp
{
    partial class Celebi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.AddListButton = new System.Windows.Forms.Button();
            this.Numaralar = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.AllAddButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CheckboxData = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.uyeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspUyeHepsiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.Panel();
            this.EnterButton = new System.Windows.Forms.Button();
            this.textboxPassword = new System.Windows.Forms.TextBox();
            this.textboxUsername = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspUyeHepsiBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageBox
            // 
            this.MessageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageBox.Location = new System.Drawing.Point(571, 52);
            this.MessageBox.Multiline = true;
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(357, 145);
            this.MessageBox.TabIndex = 0;
            // 
            // Number
            // 
            this.Number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Number.Location = new System.Drawing.Point(950, 82);
            this.Number.Multiline = true;
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(187, 36);
            this.Number.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12.2F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(481, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mesaj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12.2F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(945, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Telefon Numarası";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(44, 107);
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
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(52, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kişi Ara";
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Yu Gothic", 16.2F);
            this.button2.Location = new System.Drawing.Point(267, 109);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 46);
            this.button2.TabIndex = 8;
            this.button2.Text = "Ara";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddListButton
            // 
            this.AddListButton.BackColor = System.Drawing.Color.Beige;
            this.AddListButton.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddListButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddListButton.Location = new System.Drawing.Point(950, 124);
            this.AddListButton.Name = "AddListButton";
            this.AddListButton.Size = new System.Drawing.Size(187, 45);
            this.AddListButton.TabIndex = 10;
            this.AddListButton.Text = "Ekle";
            this.AddListButton.UseVisualStyleBackColor = false;
            this.AddListButton.Click += new System.EventHandler(this.AddListButton_Click);
            // 
            // Numaralar
            // 
            this.Numaralar.FormattingEnabled = true;
            this.Numaralar.ItemHeight = 16;
            this.Numaralar.Location = new System.Drawing.Point(1217, 64);
            this.Numaralar.Name = "Numaralar";
            this.Numaralar.Size = new System.Drawing.Size(292, 228);
            this.Numaralar.TabIndex = 11;
            // 
            // AllAddButton
            // 
            this.AllAddButton.BackColor = System.Drawing.Color.Beige;
            this.AllAddButton.Location = new System.Drawing.Point(979, 246);
            this.AllAddButton.Name = "AllAddButton";
            this.AllAddButton.Size = new System.Drawing.Size(151, 50);
            this.AllAddButton.TabIndex = 13;
            this.AllAddButton.Text = "Tümünü Ekle";
            this.AllAddButton.UseVisualStyleBackColor = false;
            this.AllAddButton.Click += new System.EventHandler(this.AllAddButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CloseButton.Location = new System.Drawing.Point(1346, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(151, 34);
            this.CloseButton.TabIndex = 18;
            this.CloseButton.Text = "Çıkış";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 267);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 24);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(9, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Filtrele";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckboxData});
            this.dataGridView1.Location = new System.Drawing.Point(12, 314);
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
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 16.2F);
            this.button1.Location = new System.Drawing.Point(1338, 300);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Gönder";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.AutoSize = true;
            this.RemoveBtn.BackColor = System.Drawing.Color.MintCream;
            this.RemoveBtn.Font = new System.Drawing.Font("Yu Gothic", 16.2F);
            this.RemoveBtn.Location = new System.Drawing.Point(1338, 356);
            this.RemoveBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(171, 46);
            this.RemoveBtn.TabIndex = 12;
            this.RemoveBtn.Text = "Temizle";
            this.RemoveBtn.UseVisualStyleBackColor = false;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.BackgroundImage = global::MessageApp.Properties.Resources.background;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.AllAddButton);
            this.panel3.Controls.Add(this.Number);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.AddListButton);
            this.panel3.Controls.Add(this.MessageBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1183, 296);
            this.panel3.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::MessageApp.Properties.Resources.background;
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Controls.Add(this.EnterButton);
            this.panel1.Controls.Add(this.textboxPassword);
            this.panel1.Controls.Add(this.textboxUsername);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1558, 597);
            this.panel1.TabIndex = 18;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Black;
            this.Logo.BackgroundImage = global::MessageApp.Properties.Resources.logobig_a;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Logo.Cursor = System.Windows.Forms.Cursors.Default;
            this.Logo.Location = new System.Drawing.Point(15, 15);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(953, 402);
            this.Logo.TabIndex = 5;
            // 
            // EnterButton
            // 
            this.EnterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnterButton.Location = new System.Drawing.Point(1307, 332);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(114, 35);
            this.EnterButton.TabIndex = 4;
            this.EnterButton.Text = "Giriş Yap";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // textboxPassword
            // 
            this.textboxPassword.Location = new System.Drawing.Point(1217, 270);
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.PasswordChar = '*';
            this.textboxPassword.Size = new System.Drawing.Size(103, 22);
            this.textboxPassword.TabIndex = 3;
            // 
            // textboxUsername
            // 
            this.textboxUsername.Location = new System.Drawing.Point(1217, 219);
            this.textboxUsername.Multiline = true;
            this.textboxUsername.Name = "textboxUsername";
            this.textboxUsername.Size = new System.Drawing.Size(103, 29);
            this.textboxUsername.TabIndex = 2;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.password.Location = new System.Drawing.Point(1023, 274);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(63, 29);
            this.password.TabIndex = 1;
            this.password.Text = "Şifre";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Username.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Username.Location = new System.Drawing.Point(1023, 219);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(145, 29);
            this.Username.TabIndex = 0;
            this.Username.Text = "Kullanıcı Adı";
            // 
            // Celebi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImage = global::MessageApp.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1558, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Numaralar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Celebi";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspUyeHepsiBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckboxData;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.TextBox textboxPassword;
        private System.Windows.Forms.TextBox textboxUsername;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Panel Logo;
    }
}

