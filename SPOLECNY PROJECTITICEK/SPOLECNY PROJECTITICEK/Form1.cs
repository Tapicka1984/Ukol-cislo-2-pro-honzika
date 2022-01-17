using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPOLECNY_PROJECTITICEK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int cislo2;
        private int faktorial()
        {
            int vysledek = 1;
            while (cislo2 > 0)
            {
                vysledek *= cislo2;
                cislo2--;
            }
            return vysledek;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                try
                {
                    int cislo1;
                    cislo1 = int.Parse(textBox1.Text);

                    int cislo2;
                    cislo2 = int.Parse(textBox2.Text);

                    if (cislo2 == 0)
                    {
                        label6.Text = "vysledek A na N-tou je: 1";
                    }
                    else
                    {
                        int vysledek = cislo1;
                        while (cislo2 > 0)
                        {
                            vysledek = vysledek * cislo1;
                            cislo2--;
                        }
                        label6.Text = "vysledek A na N-tou je:" + vysledek;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("neco se pokazilo");

                }
            else
            {
                label5.Text = "";
            }
            if(checkBox2.Checked)
            {
                try
                {
                    cislo2 = int.Parse(textBox2.Text);
                    int vysledečiček = faktorial();

                    label5.Text = "vysledek N! je:" + vysledečiček;
                }
                catch (Exception)
                {
                    MessageBox.Show("neco se pokazilo more");
                }
            }   
            else
            {
                label6.Text = "";
            }
        }
    }
}
