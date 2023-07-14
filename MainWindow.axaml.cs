using Avalonia.Controls;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Linq;
using System;
using Avalonia.Interactivity;
using System.Data;
using System.Linq.Expressions;

namespace AvaloniaApplication2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        DataTable dataTable = new DataTable();
        string a;  
        public void onee(object source, RoutedEventArgs args)
        {
            inputexpression.Text = inputexpression.Text + "1";
        }
        public void twoo(object source, RoutedEventArgs args)
        {
            inputexpression.Text = inputexpression.Text + "2";
        }
        public void three(object source, RoutedEventArgs args)
        {
            inputexpression.Text = inputexpression.Text + "3";
        }
        public void four(object source, RoutedEventArgs args)
        {
            inputexpression.Text = inputexpression.Text + "4";
        }
        public void five(object source, RoutedEventArgs args)
        {
            inputexpression.Text = inputexpression.Text + "5";
        }
        public void Sixx(object source, RoutedEventArgs args)
        {
            inputexpression.Text = inputexpression.Text + "6";
        }
        public void seven(object source, RoutedEventArgs args)
        {
            inputexpression.Text = inputexpression.Text + "7";
        }
        public void eight(object source, RoutedEventArgs args)
        {
            inputexpression.Text = inputexpression.Text + "8";
        }
        public void nine(object source, RoutedEventArgs args)
        {
            inputexpression.Text = inputexpression.Text + "9";
        }
        public void addd(object source, RoutedEventArgs args)
        {
            inputexpression.Text = inputexpression.Text + "+";
        }
        public void subb(object source, RoutedEventArgs args)
        {
            inputexpression.Text = inputexpression.Text + "-";
        }
        public void mull(object source, RoutedEventArgs args)
        {
            inputexpression.Text = inputexpression.Text + "*";
        }
        public void dott(object source, RoutedEventArgs args)
        {
            inputexpression.Text = inputexpression.Text + ".";
        }
        public void equall(object source, RoutedEventArgs args)
        {
            try
            {
                outputresult.Text = dataTable.Compute(inputexpression.Text, " ").ToString();
                a = outputresult.Text;
            }
            catch(Exception e)
            {
                outputresult.Text = e.Message;
            }
        }
        public void zeroo(object source, RoutedEventArgs args)
        {
            inputexpression.Text = inputexpression.Text + "0";
        }
        public void answer(object source, RoutedEventArgs args)
        {
            inputexpression.Clear();
            outputresult.Clear();
            inputexpression.Text = inputexpression.Text + a;
        }
       
        public void divv(object source, RoutedEventArgs args)
        {
            inputexpression.Text = inputexpression.Text + "/";
        }
        public void clear(object source, RoutedEventArgs args)
        {
            inputexpression.Clear();
            outputresult.Clear();
            
        }
        public void dell(object source, RoutedEventArgs args)
        {

            inputexpression.Text = inputexpression.Text.Remove(inputexpression.Text.Length - 1); 

        }
        /* private void button2_Click_1(object sender, EventArgs e)
         {
             txtTotal.Text = txtTotal.Text + "2";
         }
         private void button3_Click(object sender, EventArgs e)
         {
             txtTotal.Text = txtTotal.Text + "3";
         }
         private void button4_Click_1(object sender, EventArgs e)
         {
             txtTotal.Text = txtTotal.Text + "4";
         }
         private void button5_Click_1(object sender, EventArgs e)
         {
             txtTotal.Text = txtTotal.Text + "5";
         }
         private void button6_Click_1(object sender, EventArgs e)
         {
             txtTotal.Text = txtTotal.Text + "6";
         }
         private void button7_Click_1(object sender, EventArgs e)
         {
             txtTotal.Text = txtTotal.Text + "7";
         }
         private void button8_Click_1(object sender, EventArgs e)
         {
             txtTotal.Text = txtTotal.Text + "8";
         }
         private void button9_Click_1(object sender, EventArgs e)
         {
             txtTotal.Text = txtTotal.Text + "9";
         }
         private void button0_Click_1(object sender, EventArgs e)
         {
             txtTotal.Text = txtTotal.Text + "0";
         }

         private void buttonAdd_Click(object sender, EventArgs e)
         {
             operation = "+";
             number1 = int.Parse(txtTotal.Text);

             txtTotal.Clear();
         }
         private void buttonSub_Click_1(object sender, EventArgs e)
         {
             operation = "-";
             number1 = int.Parse(txtTotal.Text);
             txtTotal.Clear();
         }
         private void buttonMul_Click(object sender, EventArgs e)
         {
             operation = "*";
             number1 = int.Parse(txtTotal.Text);
             txtTotal.Clear();
         }
         private void buttonDiv_Click_1(object sender, EventArgs e)
         {
             operation = "/";
             number1 = int.Parse(txtTotal.Text);
             txtTotal.Clear();
         }

         private void buttonEq_Click(object sender, EventArgs e)
         {
             number2 = int.Parse(txtTotal.Text);

             if (operation.Equals("+"))
             {
                 result = number1 + number2;
             }
             if (operation.Equals("-"))
             {
                 result = number1 - number2;
             }
             if (operation.Equals("*"))
             {
                 result = number1 * number2;
             }
             if (operation.Equals("/"))
             {
                 result = number1 / number2;
             }
             txtTotal.Text = result + "";
         }*/
    }
}