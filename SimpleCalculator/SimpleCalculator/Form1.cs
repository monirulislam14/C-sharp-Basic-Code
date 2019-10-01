using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
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

        private void addLebel_Click(object sender, EventArgs e)
        {
            if (firstNumberTextBox.Text == null || secondNumberTextBox.Text == null)
            {
                MessageBox.Show("First Fill The Blank");
            }
            else { 
                float firstNumber = float.Parse(firstNumberTextBox.Text);
                float secondNumber = float.Parse(secondNumberTextBox.Text);

                float result = firstNumber + secondNumber;
                resultTextBox.Text = result.ToString();
            }
        }

        private void subLebel_Click(object sender, EventArgs e)
        {
            if (firstNumberTextBox.Text == null || secondNumberTextBox.Text == null)
            {
                MessageBox.Show("First Fill The Blank");
            }
            else
            {
                float firstNumber = float.Parse(firstNumberTextBox.Text);
                float secondNumber = float.Parse(secondNumberTextBox.Text);

                float result = firstNumber - secondNumber;
                resultTextBox.Text = result.ToString();
            }
        }

        private void mulLebel_Click(object sender, EventArgs e)
        {

            if (firstNumberTextBox.Text == null || secondNumberTextBox.Text == null)
            {
                MessageBox.Show("First Fill The Blank");
            }
            else
            {
                float firstNumber = float.Parse(firstNumberTextBox.Text);
                float secondNumber = float.Parse(secondNumberTextBox.Text);

                float result = firstNumber * secondNumber;
                resultTextBox.Text = result.ToString();
            }

        }

        private void divLevel_Click(object sender, EventArgs e)
        {
            if (firstNumberTextBox.Text == null || secondNumberTextBox.Text == null)
            {
                MessageBox.Show("First Fill The Blank");
            }
            else
            {
                float firstNumber = float.Parse(firstNumberTextBox.Text);
                float secondNumber = float.Parse(secondNumberTextBox.Text);

                float result = firstNumber / secondNumber;
                resultTextBox.Text = result.ToString();

            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            firstNumberTextBox.Clear();
            secondNumberTextBox.Clear();
            resultTextBox.Clear();
        }
    }
}
