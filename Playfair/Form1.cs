using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
//arraylist için system collections kutuphanesini kullandık
namespace Şifreleme
{
    public partial class Form1 : Form
    {
        //matris içine harfleri yazıcaz ilk önce yazılan metini boşluksuz halde tutucaz 
        public Form1()
        {
            InitializeComponent();
        }
        int[] yazilabilenler = { 97, 98, 99, 231, 100, 101, 102, 103, 287, 104, 105, 305, 106, 107, 108, 109, 110,
            111, 246, 112, 114, 115, 351, 116, 117, 252, 118, 121, 122, 44, 46, 63, 33, 120, 119, 113, 32, 8, 3, 22, 1, 24 };
        //32 space
        //8 backspace
        ArrayList anahtarmetin = new ArrayList();
        ArrayList Metin = new ArrayList();
        private void tbAnahtarMetin_KeyPress(object sender, KeyPressEventArgs e)
        {
            int basilantus = Convert.ToInt32(e.KeyChar);
            if ((Array.IndexOf(yazilabilenler, basilantus) == -1))
            {
                e.Handled = true;
            }
        }
        private void tbMetin_KeyPress(object sender, KeyPressEventArgs e)
        {
            int basilantus = Convert.ToInt32(e.KeyChar);
            if ((Array.IndexOf(yazilabilenler, basilantus) == -1))
            {
                e.Handled = true;
            }
        }
        //3 kopyala 22 yapıştırma 1 hepsini seçme 24 kesme 
        private void tbSonucMetin_KeyPress(object sender, KeyPressEventArgs e)
        {
            int basilantus = Convert.ToInt32(e.KeyChar);
            if ((Array.IndexOf(yazilabilenler, basilantus) == -1))
            {
                e.Handled = true;
            }
        }

        string[] alfabe = { "a", "b", "c", "ç", "d", "e", "f", "g", "ğ", "h", "i", "ı",
            "j", "k", "l", "m", "n", "o", "ö", "p", "r", "s", "ş",
            "t", "u", "ü", "v", "y", "z", ",", ".", "?", "!", "x", "w", "q" };

        private void btnSifrele_Click(object sender, EventArgs e)
        {
            try
            {
                tbSonucMetin.Text = "";
                Metin.RemoveRange(0, Metin.Count);
                anahtarmetin.RemoveRange(0, anahtarmetin.Count);
                //normal metini boşluksuz array içine atma
                string normalMetin = tbMetin.Text;
                for (int i = 0; i < tbMetin.Text.Count(); i++)
                {
                    if (normalMetin.Substring(i, 1) != " ")
                        Metin.Add(normalMetin.Substring(i, 1));
                }
                //anahtar metini boşluksuz ve tekrarsız array içine atma
                string anahtarMetin = tbAnahtarMetin.Text;
                for (int i = 0; i < tbAnahtarMetin.Text.Count(); i++)
                {
                    if (anahtarMetin.Substring(i, 1) != " " && anahtarmetin.IndexOf(anahtarMetin.Substring(i, 1)) == -1)
                        anahtarmetin.Add(anahtarMetin.Substring(i, 1));
                }
                //Anahtar matrisi
                for (int i = 0; i <= 35; i++)
                {
                    if (anahtarmetin.IndexOf(alfabe[i]) == -1)
                        anahtarmetin.Add(alfabe[i]);

                }

                string[,] anahtarMatrisi = new string[6, 6];
                int k = 0;
                for (int i = 0; i <= 5; i++)
                {
                    for (int l = 0; l <= 5; l++)
                    {
                        anahtarMatrisi[i, l] = anahtarmetin[k].ToString();
                        k++;
                    }
                }

                //Digram yapma
                ArrayList Digram = new ArrayList();
                string onceki = "";
                string sonraki = "";
                string digram = "";
                int j = 0;
                while (true)
                {
                    if (j < Metin.Count)
                    {

                        onceki = Metin[j].ToString();
                        if (j < Metin.Count - 1)
                            sonraki = Metin[j + 1].ToString();
                        if (onceki == sonraki)
                        {
                            sonraki = ",";
                            digram = onceki + sonraki;
                            Digram.Add(digram);
                            digram = "";
                            onceki = "";
                            sonraki = "";
                            j++;
                        }
                        else if (j == Metin.Count - 1)
                        {
                            digram = Metin[j].ToString() + ".";
                            Digram.Add(digram);
                            onceki = "";
                            sonraki = "";
                            break;
                        }
                        else if (onceki != sonraki)
                        {
                            digram = onceki + sonraki;
                            Digram.Add(digram);
                            digram = "";
                            onceki = "";
                            sonraki = "";
                            j = j + 2;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                //Şifreleme yapma
                string sifrelenmisMetin = "";
                digram = "";
                int oncekiKonumX = 0;
                int sonrakiKonumX = 0;
                int oncekiKonumY = 0;
                int sonrakiKonumY = 0;
                int x = 0;
                int y = 0;
                for (int i = 0; i < Digram.Count; i++)
                {   //onceki ve sonraki digram da ki tek tek alma harfleri
                    digram = Digram[i].ToString();
                    onceki = digram.Substring(0, 1);
                    sonraki = digram.Substring(1, 1);
                    for (x = 0; x <= 5; x++)
                    {
                        for (y = 0; y <= 5; y++)
                        {
                            if (onceki == anahtarMatrisi[x, y].ToString())
                            {
                                oncekiKonumX = x;
                                oncekiKonumY = y;
                            }
                            if (sonraki == anahtarMatrisi[x, y].ToString())
                            {
                                sonrakiKonumX = x;
                                sonrakiKonumY = y;
                            }
                        }
                    }
                    if (oncekiKonumX == sonrakiKonumX)
                    {
                        sifrelenmisMetin = sifrelenmisMetin + anahtarMatrisi[(oncekiKonumX + 1) % 6, oncekiKonumY];
                        sifrelenmisMetin = sifrelenmisMetin + anahtarMatrisi[(sonrakiKonumX + 1) % 6, sonrakiKonumY];
                    }
                    else if (oncekiKonumY == sonrakiKonumY)
                    {
                        sifrelenmisMetin = sifrelenmisMetin + anahtarMatrisi[oncekiKonumX, (oncekiKonumY + 1) % 6];
                        sifrelenmisMetin = sifrelenmisMetin + anahtarMatrisi[sonrakiKonumX, (sonrakiKonumY + 1) % 6];
                    }
                    else
                    {
                        sifrelenmisMetin = sifrelenmisMetin + anahtarMatrisi[sonrakiKonumX, oncekiKonumY];
                        sifrelenmisMetin = sifrelenmisMetin + anahtarMatrisi[oncekiKonumX, sonrakiKonumY];
                    }
                }
                tbSonucMetin.Text = sifrelenmisMetin;
                //for (int i = 0; i < Digram.Count; i++)
                //{
                //    tbSonucMetin.Text = tbSonucMetin.Text + "-" + Digram[i];
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eksik veya hatalı giriş yaptınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void btnDesifrele_Click(object sender, EventArgs e)
        {
            try
            {


                Metin.RemoveRange(0, Metin.Count);
                anahtarmetin.RemoveRange(0, anahtarmetin.Count);

                tbSonucMetin.Text = "";
                //normal metini boşluksuz array içine atma
                string sifreliMetin = tbMetin.Text;
                for (int i = 0; i < tbMetin.Text.Count(); i++)
                {
                    Metin.Add(sifreliMetin.Substring(i, 1));
                }
                //anahtar metini boşluksuz ve tekrarsız array içine atma
                string anahtarMetin = tbAnahtarMetin.Text;
                for (int i = 0; i < tbAnahtarMetin.Text.Count(); i++)
                {
                    if (anahtarMetin.Substring(i, 1) != " " && anahtarmetin.IndexOf(anahtarMetin.Substring(i, 1)) == -1)
                        anahtarmetin.Add(anahtarMetin.Substring(i, 1));
                }
                //Anahtar matrisi
                for (int i = 0; i <= 35; i++)
                {
                    if (anahtarmetin.IndexOf(alfabe[i]) == -1)
                        anahtarmetin.Add(alfabe[i]);

                }

                string[,] anahtarMatrisi = new string[6, 6];
                int k = 0;
                for (int i = 0; i <= 5; i++)
                {
                    for (int l = 0; l <= 5; l++)
                    {
                        anahtarMatrisi[i, l] = anahtarmetin[k].ToString();
                        k++;
                    }
                }

                //Digram yapma
                ArrayList Digram = new ArrayList();
                string onceki = "";
                string sonraki = "";
                string digram = "";
                int j = 0;
                while (true)
                {
                    if (j < Metin.Count)
                    {

                        onceki = Metin[j].ToString();
                        sonraki = Metin[j + 1].ToString();
                        digram = onceki + sonraki;
                        Digram.Add(digram);
                        digram = "";
                        onceki = "";
                        sonraki = "";
                        j = j + 2;
                    }
                    else
                    {
                        break;
                    }
                }
                //Şifreleme yapma
                string acikMetin = "";
                digram = "";
                int oncekiKonumX = 0;
                int sonrakiKonumX = 0;
                int oncekiKonumY = 0;
                int sonrakiKonumY = 0;
                int x = 0;
                int y = 0;
                for (int i = 0; i < Digram.Count; i++)
                {   //onceki ve sonraki digram da ki tek tek alma harfleri
                    digram = Digram[i].ToString();
                    onceki = digram.Substring(0, 1);
                    sonraki = digram.Substring(1, 1);
                    for (x = 0; x <= 5; x++)
                    {
                        for (y = 0; y <= 5; y++)
                        {
                            if (onceki == anahtarMatrisi[x, y].ToString())
                            {
                                oncekiKonumX = x;
                                oncekiKonumY = y;
                            }
                            if (sonraki == anahtarMatrisi[x, y].ToString())
                            {
                                sonrakiKonumX = x;
                                sonrakiKonumY = y;
                            }
                        }
                    }
                    if (oncekiKonumX == sonrakiKonumX)
                    {
                        acikMetin = acikMetin + anahtarMatrisi[((oncekiKonumX - 1) % 6 + 6) % 6, oncekiKonumY];
                        acikMetin = acikMetin + anahtarMatrisi[((sonrakiKonumX - 1) % 6 + 6) % 6, sonrakiKonumY];
                    }
                    else if (oncekiKonumY == sonrakiKonumY)
                    {
                        acikMetin = acikMetin + anahtarMatrisi[oncekiKonumX, ((oncekiKonumY - 1) % 6 + 6) % 6];
                        acikMetin = acikMetin + anahtarMatrisi[sonrakiKonumX, ((sonrakiKonumY - 1) % 6 + 6) % 6];
                    }
                    else
                    {
                        acikMetin = acikMetin + anahtarMatrisi[sonrakiKonumX, oncekiKonumY];
                        acikMetin = acikMetin + anahtarMatrisi[oncekiKonumX, sonrakiKonumY];
                    }
                }
                tbSonucMetin.Text = acikMetin;
                //for (int i = 0; i < Digram.Count; i++)
                //{
                //    tbSonucMetin.Text = tbSonucMetin.Text + "-" + Digram[i];
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eksik veya hatalı giriş yaptınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
