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
    public partial class AdminPanel : Form
    {

        public User UserTemp;
        List<User> users = new List<User>();
        public AdminPanel( User Temp)
        {
            UserTemp = Temp;
            InitializeComponent();
          
        }

        public Login Login
        {
            get => default(Login);
            set
            {
            }
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            
            var temp = SingleTon.getInstance();
            toolStripStatusLabel2.Text = $"{temp.users.Count} are registered in this program";
            foreach (var item in temp.users)
            {
               
                    users.Add(item);
                
            }
            dataGridView1.DataSource = users;
           

        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Helper.IDSelected = -1;
            for (int i = 0; i < users.Count; i++)
            {
                if (dataGridView1.CurrentCell.RowIndex == i)
                {

                    Helper.IDSelected = dataGridView1.CurrentCell.RowIndex;


                    break;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.RowCount!=0&& Helper.IDSelected != -1 && users.Count != 0)
            {
                var temp = SingleTon.getInstance();
                temp.users.RemoveAt(Helper.IDSelected);
                MessageBox.Show("Remuved Succesful");
                dataGridView1.DataSource = null;
                users.Clear();
                AdminPanel_Load(sender, e);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0 && Helper.IDSelected != -1 && users.Count != 0)
            {
                var temp = SingleTon.getInstance();
                temp.users[Helper.IDSelected].IsBaned = true;
                MessageBox.Show("Ban of user is Succesful");
                dataGridView1.DataSource = null;
                users.Clear();
                AdminPanel_Load(sender, e);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var temp = SingleTon.getInstance();
            temp.users[Helper.IDSelected].TotalPrice*=2;
            MessageBox.Show("Give premia is succsesful");
            dataGridView1.DataSource = null;
            users.Clear();
            AdminPanel_Load(sender, e);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var temp = SingleTon.getInstance();
            temp.users[Helper.IDSelected].TypeOfAccount=Helper.ListOfTypesUsers[0];
            MessageBox.Show("Give admin is succsesful");
            dataGridView1.DataSource = null;
            users.Clear();
            AdminPanel_Load(sender, e);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            var temp = SingleTon.getInstance();
            temp.users[Helper.IDSelected].TotalPrice /= 2;
            MessageBox.Show("Multc is succsesful");
            dataGridView1.DataSource = null;
            users.Clear();
            AdminPanel_Load(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var temp = SingleTon.getInstance();
            foreach (var item in temp.users)
            {
                if(item.TypeOfAccount!="Client")
                {
                    item.TotalPrice += 2000;
                }
            }
            MessageBox.Show("Paying of salary is succsesful");
            dataGridView1.DataSource = null;
            users.Clear();
            AdminPanel_Load(sender, e);
        }

        private void AdminPanel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                WebInfo webInfo = new WebInfo();
                webInfo.ShowDialog();
            }
        }

        
    }
}
