using System;
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
    public partial class Client : Form
    {
        public User UserTemp;
        public Client(User user)
        {
            InitializeComponent();
            UserTemp = user;
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            ClientBurgers burgers = new ClientBurgers(UserTemp);
            Close();
            burgers.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ClientBurgers burgers = new ClientBurgers(UserTemp);
            Close();
            burgers.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Client client = new Client(UserTemp);
            Close();
            client.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Client client = new Client(UserTemp);
            Close();
            client.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ClientSalads client = new ClientSalads(UserTemp);
            Close();
            client.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ClientSalads client = new ClientSalads(UserTemp);
            Close();
            client.Show();
        }


        private void label6_Click(object sender, EventArgs e)
        {
            SnackForm client = new SnackForm(UserTemp);
            Close();
            client.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            SnackForm client = new SnackForm(UserTemp);
            Close();
            client.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            DesertClient client = new DesertClient(UserTemp);
            Close();
            client.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DesertClient client = new DesertClient(UserTemp);
            Close();
            client.Show();
        
        }

        private void label8_Click(object sender, EventArgs e)
        {
            DrinksForm client = new DrinksForm(UserTemp);
            Close();
            client.Show();
        
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DrinksForm client = new DrinksForm(UserTemp);
            Close();
            client.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "ITEM ADDED TO YOUR BASKET");
            int total;
            Int32.TryParse(textBox1.Text, out total);
            textBox1.Text = "1";
            total *= Helper.PriceOfFirst;
            UserTemp.TotalPrice += total;
            UserTemp.listOfTempBuying.Add($"Classic meal deal count {total/ Helper.PriceOfFirst}");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Basket basket = new Basket(UserTemp);
             Close();
            basket.Show();
        }

        private void Client_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                WebInfo webInfo = new WebInfo();
                webInfo.ShowDialog();
            }
        }
    }
}
