using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookInformationKeeper
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> bookList = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string isbnNumber = isbnTextBox.Text;
            string nameInput = nameTextBox.Text;
           
            if (bookList.ContainsKey(isbnNumber))
            {
                MessageBox.Show("This ISBN Number Already Exits");
               
            }
            else if (isbnNumber.Length<13||isbnNumber.Length>13)
            {
                MessageBox.Show("You Need Exact 13 Digit Number");
                
            }
            else
            {
                addListBox.Items.Clear();
                bookList.Add(isbnNumber, nameInput);
                foreach (KeyValuePair<string, string> item in bookList)
                {
                    addListBox.Items.Add(item.Key);
                    addListBox.Items.Add(item.Value);
                }
               
            }

            isbnTextBox.Clear();
            nameTextBox.Clear();
          
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchInput = searchTextBox.Text.ToLower();
            int a = 0;
            if (isbnRadioButton.Checked)
            {
                searchListBox.Items.Clear();
                foreach (KeyValuePair<string,string> item in bookList)
                {
                    if (item.Key== searchInput)
                    {
                     
                        searchListBox.Items.Add(item.Value);
                        a = 0;
                        break;
                    }
                    else
                    {
                        a = 1;
                    }

                }
                if (a == 1)
                {
                    MessageBox.Show("Search Not Match");
                }
                searchTextBox.Clear();
            }
            if (nameRadioButton.Checked)
            {
                foreach (KeyValuePair<string, string> item in bookList)
                {
                    searchListBox.Items.Clear();
                    if (item.Value.ToLower() == searchInput.ToLower())
                    {
                        
                        searchListBox.Items.Add(item.Key);
                        a = 0;
                        break;
                   
                    }
                    else
                    {
                        a = 1;
                    }
                }
                if (a == 1)
                {
                    MessageBox.Show("Search Not Match");
                }
                searchTextBox.Clear();
            }
        }
    }
}
