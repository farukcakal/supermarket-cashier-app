using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_1
{
    public partial class Form1 : Form
    {
        public bool basildi = false;
        decimal odenecek;
        decimal odenen;
        decimal miktar;
        decimal paraustu;

        Label borc = new Label();
        Label odeme = new Label();
        Label lblparaustu = new Label();
        TextBox txtOdeme = new TextBox();
        public Form1()
        {
            InitializeComponent();
        }

        private void radioMeyve_CheckedChanged(object sender, EventArgs e)
        {
            comboMeyve.Visible = true;
            comboSebze.Visible = false;
        }

        private void radioSebze_CheckedChanged(object sender, EventArgs e)
        {
            comboSebze.Visible = true;
            comboMeyve.Visible = false;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            borc.Top = 200;
            borc.Left = 15;

            txtOdeme.Top = 245;
            txtOdeme.Left = 70;
            txtOdeme.Name = "txtOdeme";
            odeme.Top = 250;
            odeme.Left = 15;
            odeme.Text = "Ödeme ";

            lblparaustu.Top = 275;
            lblparaustu.Left = 15;
            if (basildi == false) // ilk tıklama
            {
                if (radioMeyve.Checked) //meyve seçilirse
                {
                    if (comboMeyve.SelectedIndex == 0)
                    {
                        miktar = Convert.ToDecimal(txtMiktar.Text);
                        Elma elma = new Elma();
                        elma.setValues();
                        odenecek = elma.price * miktar;
                        borc.Text = "Borcunuz: " + odenecek.ToString() + "TL";
                    }
                    else if (comboMeyve.SelectedIndex == 1)
                    {
                        miktar = Convert.ToDecimal(txtMiktar.Text);
                        Armut armut = new Armut();
                        armut.setValues();
                        odenecek = armut.price * miktar;
                        borc.Text = "Borcunuz: " + odenecek.ToString() + "TL";
                    }
                    else if (comboMeyve.SelectedIndex == 2)
                    {
                        miktar = Convert.ToDecimal(txtMiktar.Text);
                        Portakal portakal = new Portakal();
                        portakal.setValues();
                        odenecek = portakal.price * miktar;
                        borc.Text = "Borcunuz: " + odenecek.ToString() + "TL";
                    }
                    else if (comboMeyve.SelectedIndex == 3)
                    {
                        miktar = Convert.ToDecimal(txtMiktar.Text);
                        Uzum uzum = new Uzum();
                        uzum.setValues();
                        odenecek = uzum.price * miktar;
                        borc.Text = "Borcunuz: " + odenecek.ToString() + "TL";
                    }
                    else
                    {
                        MessageBox.Show("Ürün seçiniz");
                    }
                }
                else if (radioSebze.Checked) //sebze seçilirse
                {
                    if (comboSebze.SelectedIndex == 0)
                    {
                        miktar = Convert.ToDecimal(txtMiktar.Text);
                        Patlican patlican = new Patlican();
                        patlican.setValues();
                        odenecek = patlican.price * miktar;
                        borc.Text = "Borcunuz: " + odenecek.ToString() + "TL";
                    }
                    else if (comboSebze.SelectedIndex == 1)
                    {
                        miktar = Convert.ToDecimal(txtMiktar.Text);
                        Havuc havuc = new Havuc();
                        havuc.setValues();
                        odenecek = havuc.price * miktar;
                        borc.Text = "Borcunuz: " + odenecek.ToString() + "TL";
                    }
                    else if (comboSebze.SelectedIndex == 2)
                    {
                        miktar = Convert.ToDecimal(txtMiktar.Text);
                        Kabak kabak = new Kabak();
                        kabak.setValues();
                        odenecek = kabak.price * miktar;
                        borc.Text = "Borcunuz: " + odenecek.ToString() + "TL";
                    }
                    else if (comboSebze.SelectedIndex == 3)
                    {
                        miktar = Convert.ToDecimal(txtMiktar.Text);
                        Limon limon = new Limon();
                        limon.setValues();
                        odenecek = limon.price * miktar;
                        borc.Text = "Borcunuz: " + odenecek.ToString() + "TL";
                    }
                    else
                    {
                        MessageBox.Show("Ürün seçiniz");
                    }
                }
                else // ikiside seçilmezse
                {
                    MessageBox.Show("Ürün seçiniz");
                }
                basildi = true;
                this.Controls.Add(txtOdeme);
                this.Controls.Add(odeme);
            }
            else // ikinci tıklama - ödeme işlemleri
            {

                odenen = Convert.ToDecimal(txtOdeme.Text);
                paraustu = odenen - odenecek;
                lblparaustu.Text = "Para üstünüz: " + paraustu.ToString() + " TL.";
                //MessageBox.Show(paraustu.ToString());
                basildi = false;
            }
            this.Controls.Add(borc);
            this.Controls.Add(lblparaustu);
        }
    }
}
