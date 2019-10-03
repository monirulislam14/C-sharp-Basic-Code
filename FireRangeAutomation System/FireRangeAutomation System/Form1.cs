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

namespace FireRangeAutomation_System
{     
    public partial class Form1 : Form
    {
        List<ListViewItem> showItem = new List<ListViewItem>();
        List<string> searchNameItem = new List<string>();
        List<string> searchNoItem = new List<string>();
        String topAverageScorerName;
        string topTotalScorerName;
        public Form1()
        {
            InitializeComponent();
          
        }
          
        public void saveButton_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            List<float> avg = new List<float>();
            List<float> total = new List<float>();
            String solderNo = solderNoTextBox.Text;
            String solderName= solderNameTextBox.Text;
            float scoreOne = float.Parse(scoreOneTextBox.Text);
            float scoreTwo = float.Parse(scoreTwoTextBox.Text);
            float scoreThree = float.Parse(scoreThreeTextBox.Text);
            float scoreFour = float.Parse(scoreFourTextBox.Text);

            float totalCount = scoreOne + scoreTwo + scoreThree + scoreFour;
            float average = (scoreOne + scoreTwo + scoreThree + scoreFour)/4;
            avg.Add(average);
            total.Add(totalCount);
            float temp;
            for (int j = 0; j < avg.Count; j++)
            {
                for (int i = 0; i < avg.Count - 1; i++)
                {
                    if (avg[i] < avg[i + 1])
                    {
                        temp = avg[i + 1];
                        avg[i + 1] = avg[i];
                        avg[i] = temp;
                    }
                }
            }
            if (avg[0] == average)
            {
                topAverageScorerName = solderName;
            }
            float totalTemp;
            for (int j = 0; j < avg.Count; j++)
            {
                for (int i = 0; i < avg.Count - 1; i++)
                {
                    if (total[i] < total[i + 1])
                    {
                        totalTemp = total[i + 1];
                        total[i + 1] = total[i];
                        total[i] = totalTemp;
                    }
                }
            }
            if (total[0] ==totalCount )
            {
                topTotalScorerName = solderName;
            }
            searchNameItem.Add(solderName);
            searchNoItem.Add(solderNo);
            item.Text=solderNo;
            item.SubItems.Add(solderName);
            item.SubItems.Add(average.ToString());
            item.SubItems.Add(totalCount.ToString());
         
            showItem.Add(item);

          

            //Clear TextBOx
            solderNoTextBox.Clear();
            solderNameTextBox.Clear();
            scoreOneTextBox.Clear();
            scoreTwoTextBox.Clear();
            scoreThreeTextBox.Clear();
            scoreFourTextBox.Clear();

        }

        private void showAllButton_Click(object sender, EventArgs e)
        {

        
            for (int i = 0; i < showItem.Count; i++)
            {
                infoListView.Items.Add(showItem[i]);
               
            }

           
            topAveargeScorerNameTextBox.Text =  topAverageScorerName;
            topTotalScorerTextBox.Text = topTotalScorerName;
        }


        private void solderNameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void solderNoRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (solderNameRadioButton.Checked)
            {
                string searchName = searchTextBox.Text;
                for (int i = 0; i < searchNameItem.Count; i++)
                {
                    infoListView.Items.Clear();
                    if (searchName == searchNameItem[i])
                    {

                        infoListView.Items.Add(showItem[i]);
                    }
                    else
                    {
                        MessageBox.Show("Soldier Not Found");
                        infoListView.Items.Clear();
                    }
                }
                searchTextBox.Clear();
            }

            if (solderNoRadioButton.Checked)
            {
                string searchName = searchTextBox.Text;
                for (int i = 0; i < searchNoItem.Count; i++)
                {
                    infoListView.Items.Clear();
                    if (searchName == searchNoItem[i])
                    {

                        infoListView.Items.Add(showItem[i]);
                    }
                    else
                    {
                        MessageBox.Show("Soldier Not Found");
                        infoListView.Items.Clear();
                    }
                }
                searchTextBox.Clear();
            }

        }
    }
}
