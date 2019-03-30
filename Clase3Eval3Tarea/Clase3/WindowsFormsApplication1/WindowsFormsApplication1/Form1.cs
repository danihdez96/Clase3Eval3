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
                label1.Text = "Selecciono Suma";
            }
            if (this.checkBox2.Checked == true)
            {
                label1.Text = "Selecciono Resta";
            }
            if (this.checkBox3.Checked == true)
            {
                label1.Text = "Selecciono Multiplicacion";
            }
            if (this.checkBox4.Checked == true)
            {
                label1.Text = "Selecciono Division";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            Suma obj1 = new Suma();
            obj1.N1 = double.Parse(textBox3.Text);
            obj1.N2 = double.Parse(textBox4.Text);
            label4.Text = obj1.Calculos().ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            Resta obj2 = new Resta();
            obj2.N1 = double.Parse(textBox3.Text);
            obj2.N2 = double.Parse(textBox4.Text);
            label4.Text = obj2.Calculos().ToString();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox1.Checked = false;
            checkBox4.Checked = false;
            Multiplicacion obj3 = new Multiplicacion();
            obj3.N1 = double.Parse(textBox3.Text);
            obj3.N2 = double.Parse(textBox4.Text);
            label4.Text = obj3.Calculos().ToString();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            Division obj4 = new Division();
            obj4.N1 = double.Parse(textBox3.Text);
            obj4.N2 = double.Parse(textBox4.Text);
            label4.Text = obj4.Calculos().ToString();
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

                this.BackColor = Color.White;
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
