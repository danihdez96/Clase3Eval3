using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                label1.Text = "Selecciono el check1";
            }
            if (this.checkBox2.Checked == true)
            {
                label1.Text = "Selecciono el check2";
            }
            if (this.checkBox3.Checked == true)
            {
                label1.Text = "Selecciono el check3";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox1.Checked = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Un solo click ";
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            label1.Text = "Dos click";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.RadioButton1.Checked == true)
            {
                label1.Text = "Selecciono Suma";
            }
            if (this.radioButton2.Checked == true)
            {
                label1.Text = "Selecciono Resta";
            }
            if (this.radioButton3.Checked == true)
            {
                label1.Text = "Selecciono Multiplicaion";
            }
            if (this.radioButton4.Checked == true)
            {
                label1.Text = "Selecciono Division";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label1.BackColor = Color.Blue;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                label1.BackColor = Color.Red;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                label1.BackColor = Color.Green;
            }
            if (comboBox1.SelectedIndex == 2)
            {

                this.BackColor = Color.Pink;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                comboBox1.Items.Add( i.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }
    }
}
