using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kelime_oyunu
{

    public partial class Form1 : Form
    {
        public static string adYolla;
        public static string puanYolla;
        public static string kalanYolla;
        public static string saatYolla;
        public static string Tarihyolla;
        int saniyesayac,dakikasayac,sorusayac,sorusaysayac,rastgelsayi1,z,rastgelsayi2,harfsayac,rastgelsayac,sorupuan,toplampuan,ysayac;
        int [] rastgelesayilar = new int[15];
        string kelime;
        bool durum;

       //string[] sorular;


        string[] sorular;
        string[] cevaplar;
        Random r = new Random();

        private void button6_Click(object sender, EventArgs e)
        {

        }


        //Oyun sonunda sonuçların gösterilmesini sağlayan buton
        private void sonucbtn_Click(object sender, EventArgs e)
        {
            adYolla = oyuncu.Text;
            puanYolla = topPuanLbl.Text;
            kalanYolla = zamanlbl.Text;
            saatYolla = saatlbl.Text;
            Tarihyolla = tarihlbl.Text;
            Form3 form3 = new Form3();
            form3.Show();
            
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
        //Girilen kelimelerin büyük ve imlecin sonuna gelmesini sağlar
        private void cevaplatxt_TextChanged(object sender, EventArgs e)
        {
            cevaplatxt.Text = cevaplatxt.Text.ToUpper();
            cevaplatxt.SelectionStart = cevaplatxt.Text.Length;
        }

        private void tarihlbl_Click(object sender, EventArgs e)
        {

        }

        private void saatlbl_Click(object sender, EventArgs e)
        {

        }

       

        private void label17_Click(object sender, EventArgs e)
        {

        }
        //Güncel saat ve tarihi yazdırır
        private void timer3_Tick_1(object sender, EventArgs e)
        {
            tarihlbl.Text = DateTime.Now.ToLongDateString();
            saatlbl.Text = DateTime.Now.ToLongTimeString();
        }
        //20 saniye içerisinde cevaplanmazsa - puan
        int dursayac = 0;

       
        public void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Interval = 1000;
          
          
            
            dursayac++;
            durlbl.Text = dursayac.ToString();
            if (dursayac == 20)
            {

                toplampuan = toplampuan - sorupuan;
                topPuanLbl.Text = toplampuan.ToString();
                timer4.Stop();
            }

        }

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            sonucbtn.Visible = false;
            cevaplabtn.Visible = false;
            oyuncu.Text = Form2.adGonder;
            timer3.Start();
            harf1lbl.Visible = false; harf2lbl.Visible = false; harf3lbl.Visible = false; harf4lbl.Visible = false;
            harf5lbl.Visible = false; harf6lbl.Visible = false; harf7lbl.Visible = false; harf8lbl.Visible = false;
            harf9lbl.Visible = false; harf10lbl.Visible = false;
            timer1.Enabled = false;
            timer2.Enabled = false;
            
            timer1.Interval = 1000;
            timer2.Interval = 20;
            harfalbtn.Enabled = true;
            cevaplabtn.Enabled = true;
            baslabtn.Enabled = true;

            zamanlbl.Text = "04:00";
            durum = true;
            sorusayac = 0; sorusaysayac = 1; harfsayac = 0; 
          
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void baslabtn_Click(object sender, EventArgs e)
        {
            string dosya_yolu = @"C:\Users\Aygun\Desktop\Projelerim\Yazgel1\kelime_oyunu\kelime_oyunu\sorular.txt";
            string[] sorular = System.IO.File.ReadAllLines(dosya_yolu);
            string dosya_yolu1 = @"C:\Users\Aygun\Desktop\Projelerim\Yazgel1\kelime_oyunu\kelime_oyunu\cevaplar.txt";
            string[] cevaplar = System.IO.File.ReadAllLines(dosya_yolu1);
            try
            {
                if (durum == true)
                {
                    timer1.Enabled = true;
                }
                timer4.Stop();
                dursayac = 0;
                label11.Text = sorular[sorusayac];
                sorusayac++;
                durum = false;
                cevaplatxt.Text = "";
                durlbl.Visible = false;
                if (sorusaysayac == 1)
                {
                    cevaplabtn.Visible = false;
                    kelime = cevaplar[0];
                    harf1lbl.Visible = true; harf2lbl.Visible = true; harf3lbl.Visible = true; harf4lbl.Visible = true;
                    harf5lbl.Visible = false; harf6lbl.Visible = false; harf7lbl.Visible = false; harf8lbl.Visible = false;
                    harf9lbl.Visible = false; harf10lbl.Visible = false; 
                    sorupuan = 400;
                    topPuanLbl.Text = toplampuan.ToString();
                    sorupuanlbl.Text=sorupuan.ToString();
                    
                }
                if (sorusaysayac == 2)
                {
                    cevaplabtn.Visible = false;
                    kelime = cevaplar[1];
                    harf1lbl.Visible = true; harf2lbl.Visible = true; harf3lbl.Visible = true; harf4lbl.Visible = true;
                    harf5lbl.Visible = false; harf6lbl.Visible = false; harf7lbl.Visible = false; harf8lbl.Visible = false;
                    harf9lbl.Visible = false; harf10lbl.Visible = false;
                    sorupuan = 400;
                    topPuanLbl.Text = toplampuan.ToString();
                    sorupuanlbl.Text = sorupuan.ToString();
                }
                if (sorusaysayac == 3)
                {
                    cevaplabtn.Visible = false;
                    kelime = cevaplar[2];
                    harf1lbl.Visible = true; harf2lbl.Visible = true; harf3lbl.Visible = true; harf4lbl.Visible = true;
                    harf5lbl.Visible = true; harf6lbl.Visible = false; harf7lbl.Visible = false; harf8lbl.Visible = false;
                    harf9lbl.Visible = false; harf10lbl.Visible = false;
                    sorupuan = 500;
                    topPuanLbl.Text = toplampuan.ToString();
                    sorupuanlbl.Text = sorupuan.ToString();
                }
                if (sorusaysayac == 4)
                {
                    cevaplabtn.Visible = false;
                    kelime = cevaplar[3];
                    harf1lbl.Visible = true; harf2lbl.Visible = true; harf3lbl.Visible = true; harf4lbl.Visible = true;
                    harf5lbl.Visible = true; harf6lbl.Visible = false; harf7lbl.Visible = false; harf8lbl.Visible = false;
                    harf9lbl.Visible = false; harf10lbl.Visible = false;
                    sorupuan = 500;
                    topPuanLbl.Text = toplampuan.ToString();
                    sorupuanlbl.Text = sorupuan.ToString();
                }
                if (sorusaysayac == 5)
                {
                    cevaplabtn.Visible = false;
                    kelime = cevaplar[4];
                    harf1lbl.Visible = true; harf2lbl.Visible = true; harf3lbl.Visible = true; harf4lbl.Visible = true;
                    harf5lbl.Visible = true; harf6lbl.Visible = true; harf7lbl.Visible = false; harf8lbl.Visible = false;
                    harf9lbl.Visible = false; harf10lbl.Visible = false;
                    sorupuan = 600;
                    topPuanLbl.Text = toplampuan.ToString();
                    sorupuanlbl.Text = sorupuan.ToString();
                }
                if (sorusaysayac == 6)
                {
                    cevaplabtn.Visible = false;
                    kelime = cevaplar[5];
                    harf1lbl.Visible = true; harf2lbl.Visible = true; harf3lbl.Visible = true; harf4lbl.Visible = true;
                    harf5lbl.Visible = true; harf6lbl.Visible = true; harf7lbl.Visible = false; harf8lbl.Visible = false;
                    harf9lbl.Visible = false; harf10lbl.Visible = false;
                    sorupuan = 600;
                    topPuanLbl.Text = toplampuan.ToString();
                    sorupuanlbl.Text = sorupuan.ToString();
                }
                if (sorusaysayac == 7)
                {
                    cevaplabtn.Visible = false;
                    kelime = cevaplar[6];
                    harf1lbl.Visible = true; harf2lbl.Visible = true; harf3lbl.Visible = true; harf4lbl.Visible = true;
                    harf5lbl.Visible = true; harf6lbl.Visible = true; harf7lbl.Visible = true; harf8lbl.Visible = false;
                    harf9lbl.Visible = false; harf10lbl.Visible = false;
                    sorupuan = 700;
                    topPuanLbl.Text = toplampuan.ToString();
                    sorupuanlbl.Text = sorupuan.ToString();
                }
                if (sorusaysayac == 8)
                {
                    cevaplabtn.Visible = false;
                    kelime = cevaplar[7];
                    harf1lbl.Visible = true; harf2lbl.Visible = true; harf3lbl.Visible = true; harf4lbl.Visible = true;
                    harf5lbl.Visible = true; harf6lbl.Visible = true; harf7lbl.Visible = true; harf8lbl.Visible = false;
                    harf9lbl.Visible = false; harf10lbl.Visible = false;
                    sorupuan = 700;
                    topPuanLbl.Text = toplampuan.ToString();
                    sorupuanlbl.Text = sorupuan.ToString();
                }
                if (sorusaysayac == 9)
                {
                    cevaplabtn.Visible = false;
                    kelime = cevaplar[8];
                    harf1lbl.Visible = true; harf2lbl.Visible = true; harf3lbl.Visible = true; harf4lbl.Visible = true;
                    harf5lbl.Visible = true; harf6lbl.Visible = true; harf7lbl.Visible = true; harf8lbl.Visible = true;
                    harf9lbl.Visible = false; harf10lbl.Visible = false;
                    sorupuan = 800;
                    topPuanLbl.Text = toplampuan.ToString();
                    sorupuanlbl.Text = sorupuan.ToString();
                }
                if (sorusaysayac == 10)
                {
                    cevaplabtn.Visible = false;
                    kelime = cevaplar[9];
                    harf1lbl.Visible = true; harf2lbl.Visible = true; harf3lbl.Visible = true; harf4lbl.Visible = true;
                    harf5lbl.Visible = true; harf6lbl.Visible = true; harf7lbl.Visible = true; harf8lbl.Visible = true;
                    harf9lbl.Visible = false; harf10lbl.Visible = false;
                    sorupuan = 800;
                    topPuanLbl.Text = toplampuan.ToString();
                    sorupuanlbl.Text = sorupuan.ToString();
                }
                if (sorusaysayac == 11)
                {
                    kelime = cevaplar[10];
                    harf1lbl.Visible = true; harf2lbl.Visible = true; harf3lbl.Visible = true; harf4lbl.Visible = true;
                    harf5lbl.Visible = true; harf6lbl.Visible = true; harf7lbl.Visible = true; harf8lbl.Visible = true;
                    harf9lbl.Visible = true; harf10lbl.Visible = false;
                    sorupuan = 900;
                    topPuanLbl.Text = toplampuan.ToString();
                    sorupuanlbl.Text = sorupuan.ToString();
                }
                if (sorusaysayac == 12)
                {
                    kelime = cevaplar[11];
                    harf1lbl.Visible = true; harf2lbl.Visible = true; harf3lbl.Visible = true; harf4lbl.Visible = true;
                    harf5lbl.Visible = true; harf6lbl.Visible = true; harf7lbl.Visible = true; harf8lbl.Visible = true;
                    harf9lbl.Visible = true; harf10lbl.Visible = false;
                    sorupuan = 900;
                    topPuanLbl.Text = toplampuan.ToString();
                    sorupuanlbl.Text = sorupuan.ToString();
                }
                if (sorusaysayac == 13)
                {
                    kelime = cevaplar[12];
                    harf1lbl.Visible = true; harf2lbl.Visible = true; harf3lbl.Visible = true; harf4lbl.Visible = true;
                    harf5lbl.Visible = true; harf6lbl.Visible = true; harf7lbl.Visible = true; harf8lbl.Visible = true;
                    harf9lbl.Visible = true; harf10lbl.Visible = true;
                    sorupuan = 1000;
                    topPuanLbl.Text = toplampuan.ToString();
                    sorupuanlbl.Text = sorupuan.ToString();

                }
                if (sorusaysayac == 14)
                {
                    kelime = cevaplar[13];
                    harf1lbl.Visible = true; harf2lbl.Visible = true; harf3lbl.Visible = true; harf4lbl.Visible = true;
                    harf5lbl.Visible = true; harf6lbl.Visible = true; harf7lbl.Visible = true; harf8lbl.Visible = true;
                    harf9lbl.Visible = true; harf10lbl.Visible = true;
                    sorupuan = 1000;
                    topPuanLbl.Text = toplampuan.ToString();
                    sorupuanlbl.Text = sorupuan.ToString();


                }
                sorusaysayac++;
                if (sorusaysayac < 15)
                {
                   
                    baslabtn.Text = "Soru " + sorusaysayac;
                }
                else
                {
                    sonucbtn.Visible = true;
                    baslabtn.Text = "Başla";
                    
                    baslabtn.Enabled = false;
                    
                }//
                harfsayac = 0;
                harf1lbl.Text = "___";
                harf2lbl.Text = "___";
                harf3lbl.Text = "___";
                harf4lbl.Text = "___";
                harf5lbl.Text = "___";
                harf6lbl.Text = "___";
                harf7lbl.Text = "___";
                harf8lbl.Text = "___";
                harf9lbl.Text = "___";
                harf10lbl.Text = "___";
                harfalbtn.Enabled = true;
                cevaplabtn.Enabled = true;

                Array.Clear(rastgelesayilar, 0, (rastgelesayilar.Length));
            }
            catch
            {
                ;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {           
            saniyesayac++;
            if (saniyesayac > 50)
            {
                zamanlbl.Text ="0"+ (3 - dakikasayac).ToString() + " : 0" + (60 - saniyesayac).ToString();
            }
            else
            {
                zamanlbl.Text = "0" + (3 - dakikasayac).ToString() + " : " + (60 - saniyesayac).ToString();
            }
           
           
            if (saniyesayac ==60)
            {
                dakikasayac++;
                saniyesayac = 0;
            }
            if (dakikasayac == 4)
            {
                harfalbtn.Enabled = false;
                cevaplabtn.Enabled = false;
                baslabtn.Enabled = false;
                timer1.Enabled = false;                
            }   //     
        }
        private void harfalbtn_Click(object sender, EventArgs e)
        {
            string dosya_yolu = @"C:\Users\Aygun\Desktop\Projelerim\Yazgel1\kelime_oyunu\kelime_oyunu\sorular.txt";
            string[] sorular = System.IO.File.ReadAllLines(dosya_yolu);
            string dosya_yolu1 = @"C:\Users\Aygun\Desktop\Projelerim\Yazgel1\kelime_oyunu\kelime_oyunu\cevaplar.txt";
            string[] cevaplar = System.IO.File.ReadAllLines(dosya_yolu1);
            rastgelsayac = 0;
                harfsayac++;
                switch (sorusayac)
                {
                    case 1:
                        {
                            sorupuan -= 100;
                        sorupuanlbl.Text = sorupuan.ToString();
                        kelime = cevaplar[0];
                            while (rastgelsayac == 0)
                            {
                                rastgelsayi1 = r.Next(5);
                                if (Array.IndexOf(rastgelesayilar, rastgelsayi1) == -1)
                                {
                                    rastgelesayilar[harfsayac] = rastgelsayi1;
                                    rastgelsayac++;
                                    ysayac++;
                                 }
                            }
                            timer2.Enabled = true;
                            if (ysayac == 4)
                            {
                                ysayac = 0;
                                harfalbtn.Enabled = false;
                            }
                            
                            break;

                        }
                    case 2:
                        {
                            sorupuan -= 100;
                            sorupuanlbl.Text = sorupuan.ToString();
                            kelime = cevaplar[1];
                            while (rastgelsayac == 0)
                            {
                                rastgelsayi1 = r.Next(5);
                                if (Array.IndexOf(rastgelesayilar, rastgelsayi1) == -1)
                                {
                                    rastgelesayilar[harfsayac] = rastgelsayi1;
                                    rastgelsayac++;
                                    ysayac++;                                   
                                }
                            }
                            timer2.Enabled = true;
                            if (ysayac == 4)
                            {
                                ysayac = 0;
                                harfalbtn.Enabled = false;
                            }
                           
                            break;

                        }
                    case 3:
                        {
                            sorupuan -= 100;
                            sorupuanlbl.Text = sorupuan.ToString();
                            kelime = cevaplar[2];
                            while (rastgelsayac == 0)
                            {
                                rastgelsayi1 = r.Next(6);
                                if (Array.IndexOf(rastgelesayilar, rastgelsayi1) == -1)
                                {
                                    rastgelesayilar[harfsayac] = rastgelsayi1;
                                    rastgelsayac++;
                                    ysayac++;
                                }
                            }
                            timer2.Enabled = true;
                            if (ysayac == 5)
                            {
                                ysayac = 0;
                                harfalbtn.Enabled = false;
                            }
                            break;

                        }
                    case 4:
                        {
                            sorupuan -= 100;
                        sorupuanlbl.Text = sorupuan.ToString();
                        kelime = cevaplar[3];
                            while (rastgelsayac == 0)
                            {
                                rastgelsayi1 = r.Next(6);
                                if (Array.IndexOf(rastgelesayilar, rastgelsayi1) == -1)
                                {
                                    rastgelesayilar[harfsayac] = rastgelsayi1;
                                    rastgelsayac++;
                                    ysayac++;
                                }
                            }
                            timer2.Enabled = true;
                            if (ysayac == 5)
                            {
                                ysayac = 0;
                                harfalbtn.Enabled = false;
                            }
                            break;

                        }
                    case 5:
                        {
                            sorupuan -= 100;
                        sorupuanlbl.Text = sorupuan.ToString();
                        kelime = cevaplar[4];
                            while (rastgelsayac == 0)
                            {
                                rastgelsayi1 = r.Next(7);
                                if (Array.IndexOf(rastgelesayilar, rastgelsayi1) == -1)
                                {
                                    rastgelesayilar[harfsayac] = rastgelsayi1;
                                    rastgelsayac++;
                                    ysayac++;
                                }
                            }
                            timer2.Enabled = true;
                            if (ysayac == 6)
                            {
                                ysayac = 0;
                                harfalbtn.Enabled = false;
                            }
                            break;

                        }
                    case 6:
                        {
                            sorupuan -= 100;
                        sorupuanlbl.Text = sorupuan.ToString();
                        kelime = cevaplar[5];
                            while (rastgelsayac == 0)
                            {
                                rastgelsayi1 = r.Next(7);
                                if (Array.IndexOf(rastgelesayilar, rastgelsayi1) == -1)
                                {
                                    rastgelesayilar[harfsayac] = rastgelsayi1;
                                    rastgelsayac++;
                                    ysayac++;
                                }
                            }
                            timer2.Enabled = true;
                            if (ysayac == 6)
                            {
                                ysayac = 0;
                                harfalbtn.Enabled = false;
                            }
                            break;

                        }
                    case 7:
                        {
                            sorupuan -= 100;
                        sorupuanlbl.Text = sorupuan.ToString();
                        kelime = cevaplar[6];
                            while (rastgelsayac == 0)
                            {
                                rastgelsayi1 = r.Next(8);
                                if (Array.IndexOf(rastgelesayilar, rastgelsayi1) == -1)
                                {
                                    rastgelesayilar[harfsayac] = rastgelsayi1;
                                    rastgelsayac++;
                                    ysayac++;
                                }
                            }
                            timer2.Enabled = true;
                            if (ysayac == 7)
                            {
                                ysayac = 0;
                                harfalbtn.Enabled = false;
                            }
                            break;

                        }
                    case 8:
                        {
                            sorupuan -= 100;
                        sorupuanlbl.Text = sorupuan.ToString();
                        kelime = cevaplar[7];
                            while (rastgelsayac == 0)
                            {
                                rastgelsayi1 = r.Next(8);
                                if (Array.IndexOf(rastgelesayilar, rastgelsayi1) == -1)
                                {
                                    rastgelesayilar[harfsayac] = rastgelsayi1;
                                    rastgelsayac++;
                                    ysayac++;
                                }
                            }
                            timer2.Enabled = true;
                            if (ysayac == 7)
                            {
                                ysayac = 0;
                                harfalbtn.Enabled = false;
                            }
                            break;

                        }
                    case 9:
                        {
                            sorupuan -= 100;
                        sorupuanlbl.Text = sorupuan.ToString();
                        kelime = cevaplar[8];
                            while (rastgelsayac == 0)
                            {
                                rastgelsayi1 = r.Next(9);
                                if (Array.IndexOf(rastgelesayilar, rastgelsayi1) == -1)
                                {
                                    rastgelesayilar[harfsayac] = rastgelsayi1;
                                    rastgelsayac++;
                                    ysayac++;
                                }
                            }
                            timer2.Enabled = true;
                            if (ysayac == 8)
                            {
                                ysayac = 0;
                                harfalbtn.Enabled = false;
                            }
                            break;

                        }
                    case 10:
                        {
                            sorupuan -= 100;
                        sorupuanlbl.Text = sorupuan.ToString();
                        kelime = cevaplar[9];
                            while (rastgelsayac == 0)
                            {
                                rastgelsayi1 = r.Next(9);
                                if (Array.IndexOf(rastgelesayilar, rastgelsayi1) == -1)
                                {
                                    rastgelesayilar[harfsayac] = rastgelsayi1;
                                    rastgelsayac++;
                                    ysayac++;
                                }
                            }
                            timer2.Enabled = true;
                            if (ysayac == 8)
                            {
                                ysayac = 0;
                                harfalbtn.Enabled = false;
                            }
                            break;

                        }
                    case 11:
                        {
                            sorupuan -= 100;
                        sorupuanlbl.Text = sorupuan.ToString();
                        kelime = cevaplar[10];
                            while (rastgelsayac == 0)
                            {
                                rastgelsayi1 = r.Next(10);
                                if (Array.IndexOf(rastgelesayilar, rastgelsayi1) == -1)
                                {
                                    rastgelesayilar[harfsayac] = rastgelsayi1;
                                    rastgelsayac++;
                                    ysayac++;
                                }
                            }
                            timer2.Enabled = true;
                            if (ysayac == 9)
                            {
                                ysayac = 0;
                                harfalbtn.Enabled = false;
                            }
                            break;

                        }
                    case 12:
                        {
                            sorupuan -= 100;
                        sorupuanlbl.Text = sorupuan.ToString();
                        kelime = cevaplar[11];
                            while (rastgelsayac == 0)
                            {
                                rastgelsayi1 = r.Next(10);
                                if (Array.IndexOf(rastgelesayilar, rastgelsayi1) == -1)
                                {
                                    rastgelesayilar[harfsayac] = rastgelsayi1;
                                    rastgelsayac++;
                                    ysayac++;
                                }
                            }
                            timer2.Enabled = true;
                            if (ysayac == 9)
                            {
                                ysayac = 0;
                                harfalbtn.Enabled = false;
                            }
                            break;

                        }
                    case 13:
                        {
                            sorupuan -= 100;
                        sorupuanlbl.Text = sorupuan.ToString();
                        kelime = cevaplar[12];
                            while (rastgelsayac == 0)
                            {
                                rastgelsayi1 = r.Next(11);
                                if (Array.IndexOf(rastgelesayilar, rastgelsayi1) == -1)
                                {
                                    rastgelesayilar[harfsayac] = rastgelsayi1;
                                    rastgelsayac++;
                                    ysayac++;
                                }
                            }
                            timer2.Enabled = true;
                            if (ysayac == 10)
                            {
                                ysayac = 0;
                                harfalbtn.Enabled = false;
                            }
                            break;

                        }
                    case 14:
                        {
                            sorupuan -= 100;
                        sorupuanlbl.Text = sorupuan.ToString();
                        kelime = cevaplar[13];
                            while (rastgelsayac == 0)
                            {
                                rastgelsayi1 = r.Next(11);
                                if (Array.IndexOf(rastgelesayilar, rastgelsayi1) == -1)
                                {
                                    rastgelesayilar[harfsayac] = rastgelsayi1;
                                    rastgelsayac++;
                                    ysayac++;
                                }
                            }
                            timer2.Enabled = true;
                            if (ysayac == 10)
                            {
                                ysayac = 0;
                                harfalbtn.Enabled = false;
                                timer1.Enabled = false;
                            }
                            
                            break;

                        }


                }
            
           
           
            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                switch (rastgelsayi1)
                {
                    case 1:
                        if (z < 25)
                        {
                            rastgelsayi2 = r.Next(65, 91);
                            harf1lbl.Text = ((char)rastgelsayi2).ToString();
                            z++;
                            harfalbtn.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            harf1lbl.Text = kelime[0].ToString();
                            z = 0;
                            harfalbtn.Enabled = true;
                        }

                        break;
                    case 2:
                        if (z < 25)
                        {
                            rastgelsayi2 = r.Next(65, 91);
                            harf2lbl.Text = ((char)rastgelsayi2).ToString();
                            z++;
                            harfalbtn.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            harf2lbl.Text = kelime[1].ToString();
                            z = 0;
                            harfalbtn.Enabled = true;
                        }
                        break;
                    case 3:
                        if (z < 25)
                        {
                            rastgelsayi2 = r.Next(65, 91);
                            harf3lbl.Text = ((char)rastgelsayi2).ToString();
                            z++;
                            harfalbtn.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            harf3lbl.Text = kelime[2].ToString();
                            z = 0;
                            harfalbtn.Enabled = true;
                        }
                        break;
                    case 4:
                        if (z < 25)
                        {
                            rastgelsayi2 = r.Next(65, 91);
                            harf4lbl.Text = ((char)rastgelsayi2).ToString();
                            z++;
                            harfalbtn.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            harf4lbl.Text = kelime[3].ToString();
                            z = 0;
                            harfalbtn.Enabled = true;
                        }
                        break;
                    case 5:
                        if (z < 25)
                        {
                            rastgelsayi2 = r.Next(65, 91);
                            harf5lbl.Text = ((char)rastgelsayi2).ToString();
                            z++;
                            harfalbtn.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            harf5lbl.Text = kelime[4].ToString();
                            z = 0;
                            harfalbtn.Enabled = true;
                        }
                        break;
                    case 6:
                        if (z < 25)
                        {
                            rastgelsayi2 = r.Next(65, 91);
                            harf6lbl.Text = ((char)rastgelsayi2).ToString();
                            z++;
                            harfalbtn.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            harf6lbl.Text = kelime[5].ToString();
                            z = 0;
                            harfalbtn.Enabled = true;
                        }
                        break;
                    case 7:
                        if (z < 25)
                        {
                            rastgelsayi2 = r.Next(65, 91);
                            harf7lbl.Text = ((char)rastgelsayi2).ToString();
                            z++;
                            harfalbtn.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            harf7lbl.Text = kelime[6].ToString();
                            z = 0;
                            harfalbtn.Enabled = true;
                        }
                        break;
                    case 8:
                        if (z < 25)
                        {
                            rastgelsayi2 = r.Next(65, 91);
                            harf8lbl.Text = ((char)rastgelsayi2).ToString();
                            z++;
                            harfalbtn.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            harf8lbl.Text = kelime[7].ToString();
                            z = 0;
                            harfalbtn.Enabled = true;
                        }
                        break;
                    case 9:
                        if (z < 25)
                        {
                            rastgelsayi2 = r.Next(65, 91);
                            harf9lbl.Text = ((char)rastgelsayi2).ToString();
                            z++;
                            harfalbtn.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            harf9lbl.Text = kelime[8].ToString();
                            z = 0;
                            harfalbtn.Enabled = true;
                        }
                        break;
                    case 10:
                        if (z < 25)
                        {
                            rastgelsayi2 = r.Next(65, 91);
                            harf10lbl.Text = ((char)rastgelsayi2).ToString();
                            z++;
                            harfalbtn.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            harf10lbl.Text = kelime[9].ToString();
                            z = 0;
                            harfalbtn.Enabled = true;
                        }
                        break;
                    default:
                        MessageBox.Show("Hata");
                        break;
                }
            }
            catch
            { ;
            }


        }
        private void cevaplabtn_Click(object sender, EventArgs e)
        {
            string dosya_yolu = @"C:\Users\Aygun\Desktop\Projelerim\Yazgel1\kelime_oyunu\kelime_oyunu\sorular.txt";
            string[] sorular = System.IO.File.ReadAllLines(dosya_yolu);
            string dosya_yolu1 = @"C:\Users\Aygun\Desktop\Projelerim\Yazgel1\kelime_oyunu\kelime_oyunu\cevaplar.txt";
            string[] cevaplar = System.IO.File.ReadAllLines(dosya_yolu1);
            switch (sorusayac)
            {
                case 1:
                    {
                        if (cevaplatxt.Text.ToUpper() == cevaplar[0])                        
                            toplampuan += sorupuan;                        
                        else
                            toplampuan -= sorupuan;
                        topPuanLbl.Text = toplampuan.ToString();
                        harf1lbl.Text = kelime[0].ToString(); harf2lbl.Text = kelime[1].ToString(); 
                        harf3lbl.Text= kelime[2].ToString(); harf4lbl.Text = kelime[3].ToString(); 
                        break;
                    }
                case 2:
                    {
                        if (cevaplatxt.Text.ToUpper() == cevaplar[1])
                            toplampuan += sorupuan;
                        else
                            toplampuan -= sorupuan;
                        topPuanLbl.Text = toplampuan.ToString();
                        harf1lbl.Text = kelime[0].ToString(); harf2lbl.Text = kelime[1].ToString();
                        harf3lbl.Text = kelime[2].ToString(); harf4lbl.Text = kelime[3].ToString();
                        break;
                    }
                case 3:
                    {
                        if (cevaplatxt.Text.ToUpper() == cevaplar[2])
                            toplampuan += sorupuan;
                        else
                            toplampuan -= sorupuan;
                        topPuanLbl.Text = toplampuan.ToString();
                        harf1lbl.Text = kelime[0].ToString(); harf2lbl.Text = kelime[1].ToString();
                        harf3lbl.Text = kelime[2].ToString(); harf4lbl.Text = kelime[3].ToString();
                        harf5lbl.Text = kelime[4].ToString();
                        break;
                    }
                case 4:
                    {
                        if (cevaplatxt.Text.ToUpper() == cevaplar[3])
                            toplampuan += sorupuan;
                        else
                            toplampuan -= sorupuan;
                        topPuanLbl.Text = toplampuan.ToString();
                        harf1lbl.Text = kelime[0].ToString(); harf2lbl.Text = kelime[1].ToString();
                        harf3lbl.Text = kelime[2].ToString(); harf4lbl.Text = kelime[3].ToString();
                        harf5lbl.Text = kelime[4].ToString();
                        break;
                    }
                case 5:
                    {
                        if (cevaplatxt.Text.ToUpper() == cevaplar[4])
                            toplampuan += sorupuan;
                        else
                            toplampuan -= sorupuan;
                        topPuanLbl.Text = toplampuan.ToString();
                        harf1lbl.Text = kelime[0].ToString(); harf2lbl.Text = kelime[1].ToString();
                        harf3lbl.Text = kelime[2].ToString(); harf4lbl.Text = kelime[3].ToString();
                        harf5lbl.Text = kelime[4].ToString(); harf6lbl.Text = kelime[5].ToString();
                        break;
                    }
                case 6:
                    {
                        if (cevaplatxt.Text.ToUpper() == cevaplar[5])
                            toplampuan += sorupuan;
                        else
                            toplampuan -= sorupuan;
                        topPuanLbl.Text = toplampuan.ToString();
                        harf1lbl.Text = kelime[0].ToString(); harf2lbl.Text = kelime[1].ToString();
                        harf3lbl.Text = kelime[2].ToString(); harf4lbl.Text = kelime[3].ToString();
                        harf5lbl.Text = kelime[4].ToString(); harf6lbl.Text = kelime[5].ToString();
                        break;
                    }
                case 7:
                    {
                        if (cevaplatxt.Text.ToUpper() == cevaplar[6])
                            toplampuan += sorupuan;
                        else
                            toplampuan -= sorupuan;
                        topPuanLbl.Text = toplampuan.ToString();
                        harf1lbl.Text = kelime[0].ToString(); harf2lbl.Text = kelime[1].ToString();
                        harf3lbl.Text = kelime[2].ToString(); harf4lbl.Text = kelime[3].ToString();
                        harf5lbl.Text = kelime[4].ToString(); harf6lbl.Text = kelime[5].ToString();
                        harf7lbl.Text = kelime[6].ToString();
                        break;
                    }
                case 8:
                    {
                        if (cevaplatxt.Text.ToUpper() == cevaplar[7])
                            toplampuan += sorupuan;
                        else
                            toplampuan -= sorupuan;
                        topPuanLbl.Text = toplampuan.ToString();
                        harf1lbl.Text = kelime[0].ToString(); harf2lbl.Text = kelime[1].ToString();
                        harf3lbl.Text = kelime[2].ToString(); harf4lbl.Text = kelime[3].ToString();
                        harf5lbl.Text = kelime[4].ToString(); harf6lbl.Text = kelime[5].ToString();
                        harf7lbl.Text = kelime[6].ToString();
                        break;
                    }
                case 9:
                    {
                        if (cevaplatxt.Text.ToUpper() == cevaplar[8])
                            toplampuan += sorupuan;
                        else
                            toplampuan -= sorupuan;
                        topPuanLbl.Text = toplampuan.ToString();
                        harf1lbl.Text = kelime[0].ToString(); harf2lbl.Text = kelime[1].ToString();
                        harf3lbl.Text = kelime[2].ToString(); harf4lbl.Text = kelime[3].ToString();
                        harf5lbl.Text = kelime[4].ToString(); harf6lbl.Text = kelime[5].ToString();
                        harf7lbl.Text = kelime[6].ToString(); harf8lbl.Text = kelime[7].ToString();
                        break;
                    }
                case 10:
                    {
                        if (cevaplatxt.Text.ToUpper() == cevaplar[9])
                            toplampuan += sorupuan;
                        else
                            toplampuan -= sorupuan;
                        topPuanLbl.Text = toplampuan.ToString();
                        harf1lbl.Text = kelime[0].ToString(); harf2lbl.Text = kelime[1].ToString();
                        harf3lbl.Text = kelime[2].ToString(); harf4lbl.Text = kelime[3].ToString();
                        harf5lbl.Text = kelime[4].ToString(); harf6lbl.Text = kelime[5].ToString();
                        harf7lbl.Text = kelime[6].ToString(); harf8lbl.Text = kelime[7].ToString();
                        break;
                    }
                case 11:
                    {
                        if (cevaplatxt.Text.ToUpper() == cevaplar[10])
                            toplampuan += sorupuan;
                        else
                            toplampuan -= sorupuan;
                        topPuanLbl.Text = toplampuan.ToString();
                        harf1lbl.Text = kelime[0].ToString(); harf2lbl.Text = kelime[1].ToString();
                        harf3lbl.Text = kelime[2].ToString(); harf4lbl.Text = kelime[3].ToString();
                        harf5lbl.Text = kelime[4].ToString(); harf6lbl.Text = kelime[5].ToString();
                        harf7lbl.Text = kelime[6].ToString(); harf8lbl.Text = kelime[7].ToString();
                        harf9lbl.Text = kelime[8].ToString();
                        break;
                    }
                case 12:
                    {
                        if (cevaplatxt.Text.ToUpper() == cevaplar[11])
                            toplampuan += sorupuan;
                        else
                            toplampuan -= sorupuan;
                        topPuanLbl.Text = toplampuan.ToString();
                        harf1lbl.Text = kelime[0].ToString(); harf2lbl.Text = kelime[1].ToString();
                        harf3lbl.Text = kelime[2].ToString(); harf4lbl.Text = kelime[3].ToString();
                        harf5lbl.Text = kelime[4].ToString(); harf6lbl.Text = kelime[5].ToString();
                        harf7lbl.Text = kelime[6].ToString(); harf8lbl.Text = kelime[7].ToString();
                        harf9lbl.Text = kelime[8].ToString();
                        break;
                    }
                case 13:
                    {
                        if (cevaplatxt.Text.ToUpper() == cevaplar[12])
                            toplampuan += sorupuan;
                        else
                            toplampuan -= sorupuan;
                        topPuanLbl.Text = toplampuan.ToString();
                        harf1lbl.Text = kelime[0].ToString(); harf2lbl.Text = kelime[1].ToString();
                        harf3lbl.Text = kelime[2].ToString(); harf4lbl.Text = kelime[3].ToString();
                        harf5lbl.Text = kelime[4].ToString(); harf6lbl.Text = kelime[5].ToString();
                        harf7lbl.Text = kelime[6].ToString(); harf8lbl.Text = kelime[7].ToString();
                        harf9lbl.Text = kelime[8].ToString(); harf10lbl.Text = kelime[9].ToString();
                        break;
                    }
                case 14:
                    {
                        if (cevaplatxt.Text.ToUpper() == cevaplar[13])
                            toplampuan += sorupuan;
                        else
                            toplampuan -= sorupuan;
                        topPuanLbl.Text = toplampuan.ToString();
                        harf1lbl.Text = kelime[0].ToString(); harf2lbl.Text = kelime[1].ToString();
                        harf3lbl.Text = kelime[2].ToString(); harf4lbl.Text = kelime[3].ToString();
                        harf5lbl.Text = kelime[4].ToString(); harf6lbl.Text = kelime[5].ToString();
                        harf7lbl.Text = kelime[6].ToString(); harf8lbl.Text = kelime[7].ToString();
                        harf9lbl.Text = kelime[8].ToString(); harf10lbl.Text = kelime[9].ToString();
                        timer1.Enabled = false;
                        break;
                    }


            }
        }
        
       private void durdurbtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer4.Enabled = true;
            durum = true;

            timer4.Start();
            cevaplabtn.Visible = true;
            
           
        }
       

        

      
    
    }    
}
