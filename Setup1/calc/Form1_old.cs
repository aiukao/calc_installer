using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {

        static string temp = "";
        static long result = 0;
        public Form1()
        {

            InitializeComponent();
            
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if(temp != "")
            {
                temp += "0";
                display_Click_temp();
            } 
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            temp += "1";
            display_Click_temp();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temp += "2";
            display_Click_temp();
        }

      
        private void button3_Click(object sender, EventArgs e)
        {
            temp += "3";
            display_Click_temp();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            temp += "4";
            display_Click_temp();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            temp += "5";
            display_Click_temp();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            temp += "6";
            display_Click_temp();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            temp += "7";
            display_Click_temp();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            temp += "8";
            display_Click_temp();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            temp += "9";
            display_Click_temp();
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            clear_result();
            clear_temp();
            display_Click_result();
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            clear_temp();
            display_Click_temp();
        }
        private void clear_temp()
        {
            temp = "";
        }
        private void clear_result()
        {
            result = 0;
        }

        private void display_Click_temp()
        {
            this.displayText.Text = temp;
        }

        private void display_Click_result()
        {
            this.displayText.Text = result.ToString();
        }

        private void buttonequal_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            long parse_temp = long.Parse(temp);
            result += parse_temp;
            display_Click_result();
            clear_temp();

        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            long parse_temp = long.Parse(temp);
            result -= parse_temp;
            display_Click_result();
            clear_temp();
        }

        private void buttonmulti_Click(object sender, EventArgs e)
        {
            
            long parse_temp = long.Parse(temp);
            if(result == 0)
            {
                result = parse_temp;
            }
            else
            {
                result = result * parse_temp;
            }
          
            display_Click_result();
            clear_temp();
        }

        private void buttondivision_Click(object sender, EventArgs e)
        {
            long parse_temp = long.Parse(temp);
            if (result == 0)
            {
                result = parse_temp;
            }
            else
            {
                result = result / parse_temp;
            }

            display_Click_result();
            clear_temp();
        }
    }
}
