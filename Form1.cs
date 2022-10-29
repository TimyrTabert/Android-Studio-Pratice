using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void buttonOK_Click(object sender, EventArgs e)
        {

          if(comboBoxArithmetic.SelectedItem == "Сложить")
            {
                //int res = Convert.ToInt32(textBoxOne.Text) + Convert.ToInt32(textBoxTwo.Text);
                int res = Summ(Convert.ToInt32(textBoxOne.Text) , Convert.ToInt32(textBoxTwo.Text));
                textBoxResult.Text = Convert.ToString(res);
            }
          else if(comboBoxArithmetic.SelectedItem == "Вычесть")
            {
                int res = Convert.ToInt32(textBoxOne.Text) - Convert.ToInt32(textBoxTwo.Text);
                textBoxResult.Text = Convert.ToString(res);
            }
          else if(comboBoxArithmetic.SelectedItem == "Разделить")
            {
                double res = Convert.ToDouble(textBoxOne.Text) / Convert.ToDouble(textBoxTwo.Text);
                textBoxResult.Text = Convert.ToString(res);
            }
            else if (comboBoxArithmetic.SelectedItem == "Умножить")
            {
                int res = Convert.ToInt32(textBoxOne.Text) * Convert.ToInt32(textBoxTwo.Text);
                textBoxResult.Text = Convert.ToString(res);
            }





        }
       
        
        
        
        
        public int Summ(int first, int two)
        {
            int result = first + two;
            return result;
        }

    }
}
