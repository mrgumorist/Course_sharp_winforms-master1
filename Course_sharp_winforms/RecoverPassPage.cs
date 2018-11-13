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
    public partial class RecoverPassPage : Form
    {
        public RecoverPassPage()
        {
            InitializeComponent();
        }

        public Login Login
        {
            get => default(Login);
            set
            {
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            string login = textBox1.Text;
            int ID = -1;
            int.TryParse(textBox2.Text, out ID);
            string TempPass = textBox3.Text;
            bool Finded = false;
            var Tempurare = SingleTon.getInstance();
            int TempIndex = -1;
            foreach (var item in Tempurare.users)
            {
                TempIndex++;
                if (item.Login== login&&item.ID==ID)
                {
                    Finded = true;
                    break;
                }
            }
            if(Finded==true&&TempPass!=null)
            {
                Tempurare.users[TempIndex].Password = TempPass;

                MetroFramework.MetroMessageBox.Show(this, "Susseful changing");
                Close();
            }
            else if(Finded==false)
            {
                errorProvider1.SetError(textBox1, "NOT FINDED ID OR LOGIN");
            }
            else
            {
                errorProvider2.SetError(textBox1, "I CAN'T BE NULLAREABLE");
            }

        }

        private void RecoverPassPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                WebInfo webInfo = new WebInfo();
                webInfo.ShowDialog();
            }
        }
    }
}
