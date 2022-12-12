using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Dictionary<string, string> Country =
            new Dictionary<string, string>();
            Country.Add("Россия", "Москва");
            Country.Add("Китай", "Шанхай");
            Country.Add("Бразилия", "Бразилиа");
            Country.Add("сша", "вашингтон");
            Country.Add("Швеция", "Стокгольм");
            Country.Add("Италия", "Рим");
            Country.Add("Англия", "Лондон");
            Country.Add("Франция", "Париж");
            Country.Add("Егиепт", "Каир");
            listBox1.DataSource = new BindingSource(Country, null);
            listBox1.DisplayMember = "Key";
            listBox1.ValueMember = "Value";
        }
        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string ITOG = listBox1.SelectedItem.ToString();
            textBox1.Text = ITOG;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string ITOG = listBox1.SelectedItem.ToString();
            textBox1.Text = ITOG;
        }
    }
}
