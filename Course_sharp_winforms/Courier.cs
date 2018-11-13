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
    public partial class Courier : Form
    {
        User UserTemp;
        List<User> users = new List<User>();
       
        bool IsCompletedPage = true;
        public Courier(User user)
        {
            Helper.IDSelected = -1;
            UserTemp = user;
            InitializeComponent();

        }

        public Login Login
        {
            get => default(Login);
            set
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Helper.IDSelected != -1 && users.Count != 0)
            {
                users[Helper.IDSelected].OrderStatus = "Delivered";
                MessageBox.Show("Delivered succesfuly ! Your salary +20 $");
                dataGridView1.DataSource = null;
                users.Clear();
                UserTemp.TotalPrice += 20;
                Courier_Load(sender, e);
               

            }
            else
            {
                MessageBox.Show("LIST is EMPTY");
            }
        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (dataGridView1.CurrentCell.RowIndex == i)
                {

                    Helper.IDSelected = dataGridView1.CurrentCell.RowIndex;


                    break;
                }
            }
        }

        private void Courier_Load(object sender, EventArgs e)
        {
            var temp = SingleTon.getInstance();
            foreach (var item in temp.users)
            {
                if (item.TypeOfAccount == Helper.ListOfTypesUsers[1] && item.OrderStatus == "Coocked")
                {
                    users.Add(item);
                }
            }
            dataGridView1.DataSource = users;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[10].Visible = false;
        }

        private void Courier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                WebInfo webInfo = new WebInfo();
                webInfo.ShowDialog();
            }
        }
    }
        
}
