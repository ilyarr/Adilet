using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Adilet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] measure = { "Фунт", "Пуд", "Унция", "Уругвай", "Колумбия" };
            listBox1.Items.AddRange(measure);
            textBox2.Text = "Nenenene";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Changed();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox2.Font = new Font(textBox2.Font, FontStyle.Italic);
            else textBox2.Font = new Font(textBox2.Font, FontStyle.Regular);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked)
                textBox2.ForeColor = Color.Red;
            else textBox2.ForeColor = Color.Black;
        }
        public void Changed()
        {
            if (radioButton4.Checked)
            {
                if (textBox1.Text != null)
                {
                    string[] nums = textBox1.Text.Split(' ');
                    textBox2.Text = $"в интервале ({nums[0]}, {nums[1]}) грамм = {MeasureTwice(listBox1.SelectedItem.ToString(), Convert.ToDouble(nums[0]), Convert.ToDouble(nums[1]))} {listBox1.SelectedItem.ToString()}";
                }
            }
            else
            {
                if (textBox1.Text != null)
                {
                    textBox2.Text = $"{textBox1.Text} грамм = {MeasureOnce(listBox1.SelectedItem.ToString(), Convert.ToDouble(textBox1.Text))} {listBox1.SelectedItem.ToString()}";
                }
            }
        }
        public double MeasureOnce(string measure, double textbox)
        {
            switch (measure)
            {
                case "Фунт":
                    return (textbox * 0.002205);
                case "Унция":
                    return (textbox * 0.035);
                case "Пуд":
                    return (textbox * 0.000061);
            }
            return 0;
        }
        public double MeasureTwice(string measure, double startNumber, double endNumber)
        {
            switch (measure)
            {
                case "Фунт":
                    return (endNumber * 0.002205 - startNumber * 0.002205);
                case "Унция":
                    return (endNumber * 0.035 - startNumber * 0.035);
                case "Пуд":
                    return (endNumber * 0.000061 - startNumber * 0.000061);
            }
            return 0;
        }
    }
    
}
