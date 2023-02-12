﻿using MessageApp.Models;
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
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MessageApp
{
    public partial class Form1 : Form
    {
        //Not: Telefon Numarası Herzaman Grid'de 4.Kolona denk gelmesi gerekir.
        #region SqlConnect
        SqlConnection conn = new SqlConnection("Data Source=176.236.132.247;Initial Catalog=Celebi;User Id=sa;Password=XjsqEEWdvP17pMe");
        #endregion

        #region Create Object 
        Sms sms = new Sms();
        SmsModel smsModel = new SmsModel();
        SmsApiService apiService = new SmsApiService();
        #endregion

        #region SettingsResolution

        int nowWidth = 1920;
        int nowHeight = 1080;



        #endregion
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            #region Resolution

            this.Location = new Point(0, 0);

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            Rectangle ClienResolution = new Rectangle();

            ClienResolution = Screen.GetBounds(ClienResolution);

            float ratioWidth = ((float)ClienResolution.Width / (float)nowWidth);
            float ratioHeight = ((float)ClienResolution.Height / (float)nowHeight);

            this.Scale(new SizeF(ratioWidth, ratioHeight));
            #endregion


            #region ComboBoxUpload
            ComboboxDataAdd();
            #endregion

        }


        private void button1_Click(object sender, EventArgs e)
        {



            //apiSmsGonder();


            System.Windows.Forms.MessageBox.Show("Butona Tıklandı");


            foreach (var listBoxItem in Numaralar.Items)
            {

                apiService.apiSmsGonder($"{MessageBox.Text}", $"{listBoxItem}");

            }

            //apiService.apiSmsGonder($"{MessageBox.Text}", $"{Number.Text}");




        }




        private void button2_Click(object sender, EventArgs e)
        {



            SqlCommand command = new SqlCommand("select Id,Ad, Soyad,Tel1,Tel2 from Uye where Ad like '% " + textBox3.Text + "%'  or Soyad like '% " + textBox3.Text + "%' ", conn);

            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(command);

            DataSet ds = new DataSet();

            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            conn.Close();





        }

        private void AddListButton_Click(object sender, EventArgs e)
        {
            Numaralar.Items.Add(Number.Text);
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            Numaralar.Items.Clear();
        }

      

        //private List<string> selectedValues = new List<string>();
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




            //DataGridViewRow selectedRow = dataGridView1.CurrentRow;
            //string cellValue = selectedRow.Cells[4].Value.ToString();





            //var checkBox = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
            //       DataGridViewRow selectedRow = dataGridView1.CurrentRow;
            //   string cellValue = selectedRow.Cells[4].Value.ToString();
            //   Numaralar.Items.Add(cellValue);


            //var checkBox = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
            //try
            //{
            //    DataGridViewRow selectedRow = dataGridView1.CurrentRow;
            //if (selectedRow.Cells[4].Value != null)
            //{
            //    string cellValue = selectedRow.Cells[4].Value.ToString();
            //    Numaralar.Items.Add(cellValue);


            //}
            //}
            //catch (Exception ex)
            //{
            //     System.Windows.Forms.MessageBox.Show("Bir hata oluştu: " + ex.Message);
            //}

            var checkBox = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
            try
            {
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;
                if (selectedRow.Cells[4].Value != null)
                {
                    string cellValue = selectedRow.Cells[4].Value.ToString();
                    //Numaralar.Items.Add(cellValue);
                    int index = Numaralar.Items.IndexOf(cellValue);
                    if (index != -1)
                    {
                        Numaralar.Items.RemoveAt(index);
                        checkBox.Value = true;

                    }
                    else
                    {
                        Numaralar.Items.Add(cellValue);
                        checkBox.Value = false;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }



        }

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

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectValue = comboBox1.SelectedItem.ToString();

            if(selectValue == "Tümü")
            {
                SqlCommand command = new SqlCommand("select Id,Ad,Soyad,Tel1,Tel2, Adres,Paket,Durum  from Uye", conn);

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);

                DataSet ds = new DataSet();

                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();


            }
            else if(selectValue == "Devam Eden veya İzinli")
            {
                SqlCommand command = new SqlCommand("select Id,Ad,Soyad,Tel1,Tel2, Adres,Paket,Durum from Uye where Durum =1 or Durum =3 ",conn);
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
                SqlCommand command = new SqlCommand("select Id,Ad,Soyad,Tel1,Tel2, Adres,Paket,Durum from Uye where Durum =3 ", conn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);

                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            else if(selectValue == "Branş")
            {
                SqlCommand command = new SqlCommand("select Id,Ad,Soyad,Tel1,Tel2, Adres,Paket,Durum,BransId from Uye  ", conn);
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
                SqlCommand command = new SqlCommand("select Id,Ad,Soyad,Tel1,Tel2, Adres,Paket,aidat from Uye   ", conn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);

                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            else if (selectValue == "Paketi Biten ve Devam Etmeyen")
            {
                SqlCommand command = new SqlCommand("select Id,Ad,Soyad,Tel1,Tel2, Adres,Paket,Durum from Uye where Durum = 0  ", conn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);

                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            else if (selectValue == "Kaydı Silinen")
            {
                SqlCommand command = new SqlCommand("select Id,Ad,Soyad,Tel1,Tel2, Adres,Paket,Durum from Uye where Durum = 0  ", conn);
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
    }
    }

