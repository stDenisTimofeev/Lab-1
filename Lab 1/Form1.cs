using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Введите фамилию");
                return;
            }
            else if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Введите имя");
                return;
            }
            else if (comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Выберите группу");
                return;
            }
            else if (!radioButton2.Checked & !radioButton1.Checked)
            {
                MessageBox.Show("Выберите уровень сложности");
                return;
            }
            Form2 tf = new Form2(
                textBox2.Text,
                textBox1.Text,
                comboBox1.Text,
                numericUpDown1.Value,
                radioButton2.Checked);
            tf.ShowDialog();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
