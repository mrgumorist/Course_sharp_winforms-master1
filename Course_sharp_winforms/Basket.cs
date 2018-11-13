﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_sharp_winforms
{
    public partial class Basket : Form
    {
        public User UserTemp;
        public Basket(User user)
        {

            UserTemp = user;
          
            InitializeComponent();
           
        }

     

        private void Label4_Click(object sender, EventArgs e)
        {
            ClientBurgers burgers = new ClientBurgers(UserTemp);
            Close();
            burgers.Show();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            ClientBurgers burgers = new ClientBurgers(UserTemp);
            Close();
            burgers.Show();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Client client = new Client(UserTemp);
            Close();
            client.Show();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Client client = new Client(UserTemp);
            Close();
            client.Show();
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            ClientSalads client = new ClientSalads(UserTemp);
            Close();
            client.Show();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            ClientSalads client = new ClientSalads(UserTemp);
            Close();
            client.Show();
        }


        private void Label6_Click(object sender, EventArgs e)
        {
            SnackForm client = new SnackForm(UserTemp);
            Close();
            client.Show();
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            SnackForm client = new SnackForm(UserTemp);
            Close();
            client.Show();
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            DesertClient client = new DesertClient(UserTemp);
            Close();
            client.Show();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            DesertClient client = new DesertClient(UserTemp);
            Close();
            client.Show();

        }

        private void Label8_Click(object sender, EventArgs e)
        {
            DrinksForm client = new DrinksForm(UserTemp);
            Close();
            client.Show();

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            DrinksForm client = new DrinksForm(UserTemp);
            Close();
            client.Show();
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Basket_Load(object sender, EventArgs e)
        {
            metroTextBox1.Clear();
            metroTextBox1.ReadOnly = true;
            
            foreach (var item in UserTemp.listOfTempBuying)
            {
                metroTextBox1.AppendText(item.ToString() + Environment.NewLine);
                
               
            }
            metroTextBox1.AppendText("PRICE: "+UserTemp.TotalPrice + Environment.NewLine);
            //UserTemp.listOfTempBuying.Clear();


        }

        private void MetroTextBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            metroTextBox1.Clear();
            //UserTemp.listOfTempBuying.Clear();
            UserTemp.PriceOforders += UserTemp.TotalPrice;
            UserTemp.TotalPrice = 0;
            MetroFramework.MetroMessageBox.Show(this, "ADDING SUCCESFUL! "+'\n'+"WAIT PLEASE!");
            UserTemp.OrderStatus = "AcceptedByUser";

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            UserTemp.OrderStatus = "null";
            metroTextBox1.Clear();
            UserTemp.listOfTempBuying.Clear();
            UserTemp.TotalPrice = 0;
            MetroFramework.MetroMessageBox.Show(this, "SUCCESFUL");
        }

        private void Basket_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                WebInfo webInfo = new WebInfo();
                webInfo.ShowDialog();
            }
        }
    }
}