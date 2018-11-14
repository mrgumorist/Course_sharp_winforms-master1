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
    public partial class CookPanelCompleted : Form
    {
        public User UserTemp;
        List<User> users = new List<User>();
        public CookPanelCompleted(User user)
        {
            UserTemp = user;
            InitializeComponent();
        }

        public CookPanel CookPanel
        {
            get => default(CookPanel);
            set
            {
            }
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            CookPanel cook = new CookPanel(UserTemp);
            Close();
            cook.ShowDialog();
           
            
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            CookPanel cook = new CookPanel(UserTemp);
            Close();
            cook.ShowDialog();
           
           
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            CookPanelCompleted cook = new CookPanelCompleted(UserTemp);
            Close();
            cook.ShowDialog();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            CookPanelCompleted cook = new CookPanelCompleted(UserTemp);
            Close();
            cook.ShowDialog();
        }

        private void CookPanelCompleted_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CookPanelCompleted_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                WebInfo webInfo = new WebInfo();
                webInfo.ShowDialog();
            }
        }
    }
}
