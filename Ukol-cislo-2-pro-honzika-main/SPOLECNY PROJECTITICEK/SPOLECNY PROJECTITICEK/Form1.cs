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
            if (mocninaBox.Checked)
            {
                try
                {
                    int cislo1;
                    cislo1 = int.Parse(textBox1.Text);

                    int cislo2;
                    cislo2 = int.Parse(textBox2.Text);

                    if (cislo2 == 0)
                    {
                        mocninaLabel.Text = "vysledek A na N-tou je: 1";
                    }
                    else
                    {
                        int vysledek = cislo1;
                        while (cislo2 > 1)
                        {
                            vysledek = vysledek * cislo1;
                            cislo2--;
                        }
                        mocninaLabel.Text = "vysledek A na N-tou je:" + vysledek;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("neco se pokazilo");

                }
            }
            else
            {
                mocninaLabel.Text = "";
            }
            if (faktorialBox.Checked)
            {
                try
                {
                    cislo2 = int.Parse(textBox2.Text);
                    int vysledecicek = faktorial();

                    faktorialLabel.Text = "vysledek N! je:" + vysledecicek;
                }
                catch (Exception)
                {
                    MessageBox.Show("neco se pokazilo more");
                }
            }
            else
            {
                faktorialLabel.Text = "";
            }
        }
    }
}
