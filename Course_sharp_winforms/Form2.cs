using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_sharp_winforms
{

    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool IsAvaliableLogin(string login)
        {
            bool Avaliable = true;
            var Single = SingleTon.getInstance();
            
            foreach (var item in Single.users)
            {
                if(item.Login==login)
                {
                    Avaliable = false;
                    break;
                }
            }

            return Avaliable;

        }
        private void MetroButton1_Click(object sender, EventArgs e)
        {
            var Single = SingleTon.getInstance();
            string pattern = @"^\p{Lu}[a-z]{1,9}$";
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            errorProvider5.Clear();
            errorProvider6.Clear();
            errorProvider7.Clear();
            bool ISAllTrue = false;
            if (textBox1.Text != null && IsAvaliableLogin(textBox1.Text))
            {
                if(textBox2.Text != null)
                {
                    if(Regex.IsMatch(textBox3.Text, pattern))
                    {
                        if(Regex.IsMatch(textBox4.Text, pattern))
                        {
                            if(maskedTextBox1.Text!=null)
                            {
                                if(comboBox1.SelectedText!=null)
                                {
                                    if(checkBox1.Checked)
                                    {
                                        ISAllTrue = true;
                                    }
                                    else
                                    {
                                        errorProvider7.SetError(checkBox1, "CHECKED PLESE!");
                                    }
                                }
                                else
                                {
                                    errorProvider6.SetError(comboBox1, "PLESE! PUT");
                                }
                            }
                            else
                            {
                                errorProvider5.SetError(maskedTextBox1, "Age have unrealformat! Try change");
                            }
                        }
                        else
                        {
                            errorProvider4.SetError(textBox4, "Surname have unreal format, try change");
                        }
                    }
                    else
                    {
                        errorProvider3.SetError(textBox3, "Name have unreal format, try change");
                    }
                }
                else
                {
                    errorProvider2.SetError(textBox2, "Password can't be nullareble");
                }


            }
            else
            {
                errorProvider1.SetError(textBox1, "Login can't be nullareble or This login was used before! Change it");
            }

            if(ISAllTrue)
            {
                User user = new User();
                user.Login = textBox1.Text;
                user.Password = textBox2.Text;
                user.Name = textBox3.Text;
                user.Surname = textBox4.Text;
                user.Age = maskedTextBox1.Text;
                user.TypeOfAccount = comboBox1.Text;
                user.TimeOfRegestration = DateTime.Now;
                user.ID = Helper.GetID();
                Single.users.Add(user);
                MetroFramework.MetroMessageBox.Show(this, "Account created"+'\n'+"YOUR ID IS "+ user.ID+ '\n'+"Remember it please");


                this.Close();
            }
        }

        private void Register_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                WebInfo webInfo = new WebInfo();
                webInfo.ShowDialog();
            }
        }
    }
}
