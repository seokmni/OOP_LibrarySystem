﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    public partial class Library : Form
    {
        public static Library Instance { get; private set; }
        public Library()
        {
            InitializeComponent();
            Instance = this;
        }

        
        
        public void removeCard(BookContainer userControl)
        {
            flowLayoutPanel1.Controls.Remove(userControl);
        }

        private void Library_Load(object sender, EventArgs e)
        {
            populateItems();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        
        public void populateItems()
        {
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Clear();

            Database database = new Database();
            DataTable data = database.retrieveData();

            if (data != null)
            {
                if (data.Rows.Count > 0)
                {
                    BookContainer[] listItems = new BookContainer[data.Rows.Count];

                    int index = 0;

                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in data.Rows)
                        {
                            if (Convert.ToInt32(row["availableCopies"]) > 0)
                            {
                                listItems[i] = new BookContainer(this);

                                listItems[i].Title = row["title"].ToString();
                                listItems[i].Year = row["published"].ToString();
                                listItems[i].aCopies = Convert.ToInt32(row["availableCopies"]);

                                flowLayoutPanel1.Controls.Add(listItems[i]);
                            }
                            




                        }
                    }
                }
            }


        }

        private void populateItems(string search)
        {

            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Clear();

            Database database = new Database();
            DataTable data = database.retrieveData(search);

            if (data != null)
            {
                if (data.Rows.Count > 0)
                {
                    BookContainer[] listItems = new BookContainer[data.Rows.Count];
                    int index = 0;
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in data.Rows)
                        {
                            if (Convert.ToInt32(row["availableCopies"]) > 0)
                            {
                                listItems[i] = new BookContainer(this);

                                listItems[i].Title = row["title"].ToString();
                                listItems[i].Year = row["published"].ToString();
                                listItems[i].aCopies = Convert.ToInt32(row["availableCopies"]);
                            }
                            


                            flowLayoutPanel1.Controls.Add(listItems[i]);




                        }
                    }
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchbox = searchBox.Text;
            if (searchBox.Text.Length == 0)
            {
                MessageBox.Show("Search field is empty!");
                return;
            }

            else
            {
                populateItems(searchbox);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            populateItems();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            
            BookContainer bookContainer = new BookContainer(this);
            if (bookContainer.getCheckout.Count == 0)
            {
                MessageBox.Show("List is empty");
                return;
            }
            
            Checkout checkout = new Checkout();
            checkout.ShowDialog();
        }

        public void refresh()
        {
            this.Refresh();
        }
    }
}
