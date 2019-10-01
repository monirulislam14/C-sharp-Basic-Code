using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace interestClaculator
{
    public partial class InterestCalculator : Form
    {
        public InterestCalculator()
        {
            InitializeComponent();
            ShowFormulaLebel.Text = "";
           
        }
        private void InterestCalculator_Load(object sender, EventArgs e)
        {
            LoadFormulaOfInterest();
          

        }

        private void LoadFormulaOfInterest()
        {
            formulaComboBox.Items.Add("Total P+I(A)");
            formulaComboBox.Items.Add("Principal (P)");
            formulaComboBox.Items.Add("Rate (R)");
            formulaComboBox.Items.Add("Time Period (t)");
          
            TimecomboBox.Items.Add("Weeks");
            TimecomboBox.Items.Add("Months");
            TimecomboBox.Items.Add("Quarters");
            TimecomboBox.Items.Add("Years");
        }
     
        private void formulaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(formulaComboBox.Text== "Total P+I(A)")
            {
                ShowFormulaLebel.Text = "A = P(1 + rt)";
                PrincipalLebel.Text = "Principal (P): $";
                RateLebel.Text = "Rate (R): %";
                TimeLebel.Text = "Time (t):";
                TimecomboBox.Visible = true;

            }
          else if(formulaComboBox.Text == "Principal (P)")
            {
                ShowFormulaLebel.Text = " P = A / (1 + rt)";
                PrincipalLebel.Text = "Total P+I (A): $";
                RateLebel.Text = "Rate (R): %";
                TimeLebel.Text = "Time (t):";
                TimecomboBox.Visible = true;
            }
            else if(formulaComboBox.Text == "Rate (R)")
            {
                ShowFormulaLebel.Text = "r = (1/t)(A/P - 1)";
                PrincipalLebel.Text = "Total P+I (A): $";
                RateLebel.Text = "Principal (P): $";
                TimeLebel.Text = "Time (t):";
                TimecomboBox.Visible =true;
            }
            else if(formulaComboBox.Text == "Time Period (t)")
            {
                ShowFormulaLebel.Text = "t = (1/r)(A/P - 1)";

                PrincipalLebel.Text = "Total P+I (A): $	";

                RateLebel.Text = "Principal (P): $";
                TimeLebel.Text = "Rate (R): %";
                TimecomboBox.Visible =false;

            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (formulaComboBox.Text == "Total P+I(A)" || 
                formulaComboBox.Text == "Principal (P)"||
                formulaComboBox.Text == "Rate (R)") {
                float time = Convert.ToInt32(TimeTextBox.Text);

                if (TimecomboBox.Text == "Months")
                {
                    time = time / 12;
                }
                else if (TimecomboBox.Text == "Weeks")
                {
                    time = time / 52;
                }
                else if (TimecomboBox.Text == "Quarters")
                {
                    time = time / 4;
                }
                else if (TimecomboBox.Text == "Years")
                {
                    time = time;
                }

                if (formulaComboBox.Text == "Total P+I(A)")
                {
                    float principalAmmount = float.Parse(PrincipalTextBox.Text);
                    float rate = float.Parse(RateTextBox.Text);
                    rate = rate / 100;
                    float totalAccrudeAmmount = principalAmmount * (1 + rate * time);
                    ShowAnswerTextBox.Text = totalAccrudeAmmount.ToString();

                }
                else if (formulaComboBox.Text == "Principal (P)")
                {
                    float totalAccrudeAmmount = float.Parse(PrincipalTextBox.Text);
                    float rate = float.Parse(RateTextBox.Text);
                    rate = rate / 100;
                    float principalAmmount = totalAccrudeAmmount / (1 + rate * time);
                    ShowAnswerTextBox.Text = principalAmmount.ToString();

                }
                else if (formulaComboBox.Text == "Rate (R)")
                {
                    float totalAccrudeAmmount = float.Parse(PrincipalTextBox.Text);
                    float principalAmmount = float.Parse(RateTextBox.Text);


                    float rate = (1 / time) * (totalAccrudeAmmount / principalAmmount - 1);
                    rate = rate * 100;
                    ShowAnswerTextBox.Text = rate.ToString();

                }
            }
            else
            {
                
                if (formulaComboBox.Text == "Time Period (t)")
                {
                    float totalAccrudeAmmount = float.Parse(PrincipalTextBox.Text);
                    float principalAmmount = float.Parse(RateTextBox.Text);
                    float rate = float.Parse(TimeTextBox.Text);
                    rate = rate / 100;


                    float time = (1 / rate) * (totalAccrudeAmmount / principalAmmount - 1);
                    ShowAnswerTextBox.Text = time.ToString();

                }
            }

            

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            PrincipalTextBox.Clear();
            RateTextBox.Clear();
            TimeTextBox.Clear();
            ShowFormulaLebel.Visible = false ;
            formulaComboBox.Visible = false;
            TimecomboBox.Visible = false;
            ShowAnswerTextBox.Clear();
        }
    }
}
