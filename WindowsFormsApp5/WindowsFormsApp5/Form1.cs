using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int cislo2;

        private int posrany_faktorial()
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
            try
            {
                int cislo1;
                cislo1 = int.Parse(textBox1.Text);

                int cislo2;
                cislo2 = int.Parse(textBox1.Text);

                if(cislo2 == 0)
                {
                    label3.Text = "vysledek A na N-tou je: 0";
                }
                else
                {
                    int vysledek = cislo1;
                    while (cislo2 > 0)
                    {
                        vysledek = vysledek * cislo1;
                        cislo2--;
                    }
                    label3.Text = "vysledek A na N-tou je:" + vysledek;
                }

            } catch(Exception)
            {
                MessageBox.Show("neco se pokazilo");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cislo2 = int.Parse(textBox1.Text);
                posrany_faktorial();
                int vysledečiček = posrany_faktorial();


                label4.Text = "vysledek N! je:" + vysledečiček;
            }
            catch(Exception)
            {
                MessageBox.Show("neco se pokazilo more");
            }
        }
    }
}
