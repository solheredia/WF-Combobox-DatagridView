using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Combobox_DatagridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            id = comboBox1.SelectedIndex;
            string producto;
            producto = comboBox1.SelectedItem.ToString();
            double punitario;
            punitario = comboBox1.SelectedIndex;
            lblCantidad.Text = textBox1.Text;
            

            switch (id)
            {
                case 0:
                    label6.Text = "0";
                    label8.Text = 2000000.ToString();
                    label7.Text = "Strada";
                break;

                case 1:
                    label6.Text = "1";
                    label8.Text = 1000000.ToString();
                    label7.Text = "Focus";
                break;
                
                case 2:
                    label6.Text = "2";
                    label8.Text = 4000000.ToString();
                    label7.Text = "Corolla";
                break;
                    
                case 3:
                    label6.Text = "3";
                    label8.Text = 6000000.ToString();
                    label7.Text = "C70";
                break;
            }

        }
    }
}
