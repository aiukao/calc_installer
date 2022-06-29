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
        static string tempA = "first";
        static long result = 0;
        static string tempB = "";
        static int operation_flag = 0;
        static long tempA_parse = 0;
        static long tempB_parse = 0;
        public Form1()
        {

            InitializeComponent();
            
        }

        private void select_variable_flag(string number)
        {
            if(temp != "") 
            { 
            
                if (tempA == "first")
                {
                    tempA_parse = long.Parse(number);
                    clear_temp();
                    tempA = "使用中";
                }
                else 
                {
                    tempB_parse = long.Parse(number);
                    tempB = "使用中";
                    clear_temp();
                }
            }
        }

        private void math_select()
        {
            if (tempA != "" && operation_flag != 0 && tempB != "")
            {
                if (operation_flag == 1)
                {
                    result = tempA_parse + tempB_parse;
                    display_Click_result();

                } else if (operation_flag == 2)
                {
                    result = tempA_parse - tempB_parse;
                    display_Click_result();
                } else if (operation_flag == 3)
                {
                    result = tempA_parse * tempB_parse;
                    display_Click_result();
                } else if (operation_flag == 4)
                {
                    result = tempA_parse / tempB_parse;
                    display_Click_result();
                }

            }
                

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
            temp = "";
            tempA = "first";
            result = 0;
            tempB = "";
            operation_flag = 0;
            tempA_parse = 0;
            tempB_parse = 0;
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
            tempA_parse = result;
            operation_flag = 0;
        }

        private void buttonequal_Click(object sender, EventArgs e)
        {
            select_variable_flag(temp);
            math_select();
            clear_temp();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            select_variable_flag(temp);
            operation_flag = 1;
            math_select();
            
            

        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            select_variable_flag(temp);
            operation_flag = 2;
            math_select();

            
        }

        private void buttonmulti_Click(object sender, EventArgs e)
        {

            select_variable_flag(temp);
            operation_flag = 3;
            math_select();

            
        }

        private void buttondivision_Click(object sender, EventArgs e)
        {
            select_variable_flag(temp);
            operation_flag = 4;
            math_select();

            
        }
    }
}
