using MessageApp.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace MessageApp
{
    public partial class Celebi : Form
    {
        #region Note
        //Not: Telefon Numarası Herzaman Grid'de 4.Kolona denk gelmesi gerekir.
        //Note: The Phone Number must always correspond to the 4th Column of the Grid.
        //Alternative solution: bring to the first column of the table or solve with a function
        //Alternatif çözüm: tablonun ilk sütununa getirin veya bir fonksiyon Oluştur.
        //gerekli sorguları kendinize göre uyarlamanız gerekir.

        //Package: 
        #endregion

        //SqlConnection 
        #region SqlConnect
        SqlConnection conn = new SqlConnection("Data Source=local\\berjcode;Initial Catalog=test;"); //connectionstring
        #endregion

        // Create New Objects
        #region Create Object 
        Sms sms = new Sms();
        SmsModel smsModel = new SmsModel();
        SmsApiService apiService = new SmsApiService();
        #endregion

        #region SettingsResolution

        int nowWidth = 1920;
        int nowHeight = 1080;



        #endregion
        public Celebi()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // FormNmae
           this.Text = "test";

            // set the resolution //Çözünürlük ayarı 
            #region Resolution

            this.Location = new Point(0, 0);

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            Rectangle ClienResolution = new Rectangle();

            ClienResolution = Screen.GetBounds(ClienResolution);

            float ratioWidth = ((float)ClienResolution.Width / (float)nowWidth);
            float ratioHeight = ((float)ClienResolution.Height / (float)nowHeight);

            this.Scale(new SizeF(ratioWidth, ratioHeight));
            #endregion 

            //Uygulama açılırken combobox'ları doldurur.
            #region ComboBoxUpload
            ComboboxDataAdd(); //filling comboboxes
            #endregion


            #region AppSettings
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink; //
            this.StartPosition = FormStartPosition.CenterScreen; //ekranın ortasına alma 
            this.FormBorderStyle = FormBorderStyle.Sizable; //Cerceveyi Oynatma
            this.Size = new Size(1600, 600);//Cerceve boyutu
            this.MaximumSize = new Size(1600, 600);
            #endregion



            #region ThemaAndButtonSettings
            ThemaAndPropertiesSettings();
            #endregion
        }

        //Listbox'daki tüm numaralara mesaj atar. tekil veya coğul şekilde atar.
        #region SmsSendButton
        private void button1_Click(object sender, EventArgs e)
        {
          
                foreach (var listBoxItem in Numaralar.Items)
                {
                try
                {
                    apiService.apiSmsGonder($"{MessageBox.Text}", $"{listBoxItem}");

                   
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
         

            }




            //apiService.apiSmsGonder($"{MessageBox.Text}", $"{Number.Text}"); //single send

        }

        #endregion

        // İsim ve soyada göre search işlemi yapar.
        #region SearchTextBox
        private void button2_Click(object sender, EventArgs e)
        {

            //tel numarasını 4. kolona denk getirin.  Example : Tel1
            

            SqlCommand command = new SqlCommand("select Id,Name, Surname,Tel1 from Uyetbl where Ad like '% " + textBox3.Text + "%'  or Soyad like '% " + textBox3.Text + "%' ", conn);

            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(command);

            DataSet ds = new DataSet();

            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            conn.Close();





        }
        #endregion


        //Numarayı Listbox'a Ekle, Tekli ekleme
        //Listbox'daki tüm veriyi siler.
        #region AddandRemoveButton
        private void AddListButton_Click(object sender, EventArgs e)
        {
            Numaralar.Items.Add(Number.Text);
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            Numaralar.Items.Clear();

           
        }

        #endregion

        
        //Checkbox true ise Listbox'a ekle eğer false ise Listbox'dan kaldır.
        #region AddCheckBoxListbox
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var checkBox = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
            try
            {
              
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;
                if (selectedRow.Cells[4].Value != null)
                {
                    string cellValue = selectedRow.Cells[4].Value.ToString();
                    //Numaralar.Items.Add(cellValue);
                    int index = Numaralar.Items.IndexOf(cellValue);
                   if(checkBox != null)//Checkbox kolonundan  bir değer gelip gelmediğini kontrol ediyoruz.
                    {
                        //İndex kontrolü yapar o değerin var olup olmadığını anlamak için .
                        if (index != -1)
                        {

                            Numaralar.Items.RemoveAt(index);
                            checkBox.Value = false;

                        }
                        else
                        {

                            Numaralar.Items.Add(cellValue);
                            checkBox.Value = false;
                        }
                    }else
                    {
                        System.Windows.Forms.MessageBox.Show("Lütfen CheckBox üzerinden işlem yapın. ");
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }


        }
        #endregion


        //Grid'deki her satırı ListBox'a ekle.
        #region AllGridAddListBox 
        private void AllAddButton_Click(object sender, EventArgs e)
            {
                List<string> cellValues = new List<string>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        cellValues.Add(row.Cells[4].Value.ToString());
                    }
                }

                foreach (string value in cellValues)
                {
                    Numaralar.Items.Add(value);
                }




            }
        #endregion


        //Combobox'ları doldur.
        //Combobox filtreleme işlemleri. 
        #region Combobox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectValue = comboBox1.SelectedItem.ToString();

            if(selectValue == "Tümü")
            {
                SqlCommand command = new SqlCommand("select Id,Ad,Soyad,Tel1,Tel2, Adres,Paket,Durum  from Uyetbl", conn);

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);

                DataSet ds = new DataSet();

                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();


            }
            else if(selectValue == "Devam Eden veya İzinli")
            {
                SqlCommand command = new SqlCommand("select Id,Ad,Soyad,Tel1,Tel2, Adres,Paket,Durum from Uyetbl where Durum =1 or Durum =3 ",conn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);

                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }else if(selectValue =="Devam Eden")
            {
                SqlCommand command = new SqlCommand("select Id,Ad,Soyad,Tel1,Tel2, Adres,Paket,Durum from Uye where Durum =1 ", conn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);

                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            else if(selectValue == "İzinli")
            {
                SqlCommand command = new SqlCommand("select Id,Ad,Soyad,Tel1,Tel2, Adres,Paket,Durum from Uyetbl where Durum =3 ", conn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);

                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            else if(selectValue == "Branş")
            {
                SqlCommand command = new SqlCommand("select Uye.Id,Uye.Ad,Soyad,Tel1,Tel2, Adres,Paket,Durum,Brans.Ad  from Uyetbl inner join Brans on Uye.BransId = Brans.Id  ", conn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);

                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            else if (selectValue == "Alt Branş")
            {
                SqlCommand command = new SqlCommand("select Id,Ad,Soyad,Tel1,Tel2, Adres,Paket,Durum,BransId,AltBransId from Uye  ", conn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);

                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            else if (selectValue == "Devam Eden Borçlu")
            {
                SqlCommand command = new SqlCommand("select Id,Ad,Soyad,Tel1,Tel2, Adres,Paket,aidat from Uyetbl  ", conn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);

                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            else if (selectValue == "Paketi Biten ve Devam Etmeyen")
            {
                SqlCommand command = new SqlCommand("select Id,Ad,Soyad,Tel1,Tel2, Adres,Paket,Durum from Uyetbl where Durum = 0  ", conn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);

                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            else if (selectValue == "Kaydı Silinen")
            {
                SqlCommand command = new SqlCommand("select Id,Ad,Soyad,Tel1,Tel2, Adres,Paket,Durum from Uyetbl where Durum = 0  ", conn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);

                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
        }
       

        private void ComboboxDataAdd()
        {
            comboBox1.Items.Add("Tümü");
            comboBox1.Items.Add("Devam Eden veya İzinli");
            comboBox1.Items.Add("Devam Eden");
            comboBox1.Items.Add("İzinli");
            comboBox1.Items.Add("Branş");
            comboBox1.Items.Add("Alt Branş");
            comboBox1.Items.Add("Devam Eden Borçlu");
            comboBox1.Items.Add("Paketi Biten ve Devam Etmeyen");
            comboBox1.Items.Add("Kaydı Silinen");
        }
        #endregion


        #region App Settings
        //Close Button
        private void CloseButton_Click(object sender, EventArgs e)
        {

            DialogResult result = System.Windows.Forms.MessageBox.Show("Uygulamayı kapatmak istediğinizden Emin misiniz?","Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
           
        }

       

        public void  ThemaAndPropertiesSettings()
        {
            //Button3 GirişYap
            EnterButton.Height = 40;
            EnterButton.Width = 200;
            EnterButton.BackColor = Color.Beige;
            EnterButton.Text = "Giriş Yap";
            EnterButton.Font = new Font("Georgia", 14);


            ////Label Kullanıcı Adı
            Username.Height = 40;
            Username.Width = 200;
            //Username.BackColor = Color.Beige;
            Username.Text = "Kullanıcı Adı";
            Username.Font = new Font("Georgia", 14);
            ////Label Password
            password.Height = 40;
            password.Width = 200;
            //password.BackColor = Color.Beige;

            password.Text= "Şifre        ";
            password.Font = new Font("georgia", 14);

            //// //Login textbox1 and textbox2

           
            textboxUsername.Height = 40;
            textboxUsername.Width = 200;
            textboxUsername.BackColor = Color.Beige;

            textboxUsername.Font = new Font("Georgia", 14);

            ////2
            textboxPassword.Height = 40;
            textboxPassword.Width = 200;
            textboxPassword.BackColor = Color.Beige;

            textboxPassword.Font = new Font("Georgia", 14);

            //Search Button
            button2.Height = 40;
            button2.Width = 200;
            button2.BackColor = Color.Beige;
            button2.Text = "Ara";
            button2.Font = new Font("Georgia", 14);

            //Close Button
           CloseButton.Height = 40;
            CloseButton.Width = 100;
            CloseButton.BackColor = Color.Beige;
            
            CloseButton.Font = new Font("Georgia", 14);

            //RemoveButton
            RemoveBtn.Height = 40;
            RemoveBtn.Width = 200;
            RemoveBtn.BackColor = Color.Beige;
            RemoveBtn.Text = "Temizle";
            RemoveBtn.Font = new Font("Georgia", 14);
            //AllAddButton
            AllAddButton.Height = 40;
            AllAddButton.Width = 200;
            AllAddButton.BackColor = Color.Beige;
            AllAddButton.Text = "Hepsini Ekle";
            AllAddButton.Font = new Font("Georgia", 14);

            //AddLİstButton

            AddListButton.Height = 40;

            AddListButton.Width = 200;

            AddListButton.BackColor = Color.Beige;

            AddListButton.Text = "Ekle";

            AddListButton.Font = new Font("Georgia", 14);

            //Send Button
            button1.Height = 40;

            button1.Width = 200;
            button1.BackColor = Color.Beige;

            button1.Text = "Gönder";
            button1.Font = new Font("Georgia", 14);

           
           
        }

        #endregion
        #region Login



        //async 
        //this: o andaki form nesnesini gösterir.
        private async  void EnterButton_Click(object sender, EventArgs e)
        {
            //veritabanı login kontrol işlemi
            SqlCommand command = new SqlCommand("select COUNT(*) from MessageApp where UserName = @userName and Password = @password ", conn);

            conn.Open();

            command.Parameters.AddWithValue("@userName", textboxUsername.Text);
            command.Parameters.AddWithValue("@password", textboxPassword.Text);
            int result = (int)command.ExecuteScalar();   // tek bir değer beklediğimizi belirttik.
            if (result > 0)
            {
                if (panel1.Visible == false)
                {
                    for (int i = 0; i <= 100; i += 10)
                    {
                        await Task.Delay(100);
                        this.Opacity = i / 100.0;
                        
                    }

                    panel1.Visible = true;
                }
                else
                {

                    panel1.Visible = false;
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Kullanıcı adı veya şifre yanlış... ");
            }

            conn.Close();
        }


        private void textboxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnterButton.PerformClick();
            }
        }


        #endregion



        private void Form1_Resize(object sender, EventArgs e)
        {

           // //Login
           // //EnterButton 
           // int x = (this.ClientSize.Width - EnterButton.Width) / 2;
           // int y = (this.ClientSize.Height - EnterButton.Height) / 2;
           // EnterButton.Location = new Point(x, y);

           //// textboxUsername

           //  int textboxUsernameLocalx = (this.ClientSize.Width - textboxUsername.Width) / 2;
           // int textboxUsernameLocaly = (this.ClientSize.Height - textboxUsername.Height) / 2;
           // textboxUsername.Location = new Point(textboxUsernameLocalx, textboxUsernameLocaly);



           // //label

           // int UsernameLocalx = (this.ClientSize.Width - Username.Width) / 2;
           // int UsernameLocaly = (this.ClientSize.Height - Username.Height) / 2;
           // textboxUsername.Location = new Point(UsernameLocalx, UsernameLocaly);

        }


        //Form 

    }
}

