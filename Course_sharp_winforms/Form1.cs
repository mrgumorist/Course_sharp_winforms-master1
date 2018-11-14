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
    public partial class Form1 : Form
    {
        public Form1()
        { 
            Helper.Deserialize();
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var login = textBox1.Text;
            var password = textBox2.Text;
            bool TempBool = false;
            errorProvider1.Clear();
            errorProvider2.Clear();
            if (!String.IsNullOrEmpty(login) && !String.IsNullOrEmpty(password))
            {
                var Single = SingleTon.getInstance();
                //TODO VIDALITI CE POLE


                foreach (var item in Single.users)
                {
                    if (item.IsBaned == false)
                    {
                        if (item.Login == login && item.Password == password)
                        {
                            item.LastLogin = DateTime.Now;


                            MetroFramework.MetroMessageBox.Show(this, "Susefull Loggining");
                            //TODO LOGINNING
                            TempBool = true;
                            textBox1.Text = null;
                            textBox2.Text = null;

                            if (item.TypeOfAccount == Helper.ListOfTypesUsers[0])
                            {
                                AdminPanel admin = new AdminPanel(item);

                                admin.ShowDialog();
                            }
                            if (item.TypeOfAccount == Helper.ListOfTypesUsers[1])
                            {
                                Client client = new Client(item);
                                client.Show();


                            }
                            if (item.TypeOfAccount == Helper.ListOfTypesUsers[2])
                            {
                                Courier courier = new Courier(item);

                                courier.ShowDialog();
                            }
                            if (item.TypeOfAccount == Helper.ListOfTypesUsers[3])
                            {
                                CookPanel cook = new CookPanel(item);

                                cook.ShowDialog();
                            }

                            break;
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(textBox1, "SORRY! YOU ARE BANED");
                    }

                }
            }
            else
            {


                if (String.IsNullOrEmpty(login))
                {
                    errorProvider1.SetError(textBox1, "Login can't be nullareble");
                }
                else
                {
                    errorProvider1.Clear();
                }
                if (String.IsNullOrEmpty(password))
                {
                    errorProvider2.SetError(textBox2, "password can't be nullareble");
                }
                else
                {
                    errorProvider2.Clear();
                }
            }
            if ( !TempBool )
            {
                MetroFramework.MetroMessageBox.Show(this, "Wrong login or password" +'\n'+"Try again!!!");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            textBox1.Text = null;
            textBox2.Text = null;
            Register register = new Register();
            register.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
                Helper.Serialize();
                MetroFramework.MetroMessageBox.Show(this, "Thanks for using my program");
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            RecoverPassPage recover = new RecoverPassPage();
            recover.ShowDialog();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                WebInfo webInfo = new WebInfo();
                webInfo.ShowDialog();
            }
        }
    }
    public class Login
    {
        public RecoverPassPage RecoverPassPage
        {
            get => default(RecoverPassPage);
            set
            {
            }
        }

        public Register Register
        {
            get => default(Register);
            set
            {
            }
        }

        public Client Client
        {
            get => default(Client);
            set
            {
            }
        }

        public CookPanel CookPanel
        {
            get => default(CookPanel);
            set
            {
            }
        }

        public Courier Courier
        {
            get => default(Courier);
            set
            {
            }
        }

        public AdminPanel AdminPanel
        {
            get => default(AdminPanel);
            set
            {
            }
        }
    }
}
