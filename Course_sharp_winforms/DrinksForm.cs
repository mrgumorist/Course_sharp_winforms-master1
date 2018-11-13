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
    public partial class DrinksForm : Form
    {
        public User UserTemp;
        public DrinksForm(User user)
        {
            InitializeComponent();
            UserTemp = user;
        }

        public Client Client
        {
            get => default(Client);
            set
            {
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {

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
            Basket basket = new Basket(UserTemp);
            Close();
            basket.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "ITEM ADDED TO YOUR BASKET");
            int total;
            Int32.TryParse(textBox1.Text, out total);
            textBox1.Text = "1";
            total *= Helper.Drink;
            UserTemp.TotalPrice += total;
            UserTemp.listOfTempBuying.Add($"Cola 2$ count {total / Helper.Drink}");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "ITEM ADDED TO YOUR BASKET");
            int total;
            Int32.TryParse(textBox2.Text, out total);
            textBox2.Text = "1";
            total *= Helper.Drink;
            UserTemp.TotalPrice += total;
            UserTemp.listOfTempBuying.Add($"Sprite 2$ count {total / Helper.Drink}");
        }

        private void DrinksForm_Load(object sender, EventArgs e)
        {

        }

        private void DrinksForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                WebInfo webInfo = new WebInfo();
                webInfo.ShowDialog();
            }
        }
    }
}
