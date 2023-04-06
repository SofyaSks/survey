using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace survey
{
    public partial class Survey : Form
    {
        public Survey()
        {
            InitializeComponent();
        }

        private void comboBox_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strcountry = comboBox_country.SelectedItem.ToString();
            // по ифам коллекцию городов
            MessageBox.Show(strcountry);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender; // приводим к типу
            if (rb.Checked)
            {
                MessageBox.Show("man");
            }
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            string str = "Анкета: \n";
            if (textBox1.Text != string.Empty)
            {
                str += $"Surname: {textBox1.Text}\n";

            }
            if(comboBox_country.Text!= string.Empty)
            {
                str += comboBox_country.SelectedItem.ToString() + "\n";
            }
            if(maskedTextBox1.Text!= string.Empty)
            {
                str += maskedTextBox1.Text + "\n";
            }
            if (radioButton1.Checked == true)
            {
                str += $"Gender: {radioButton1.Text}\n";
            }

            MessageBox.Show(str);
        }
    }
}
