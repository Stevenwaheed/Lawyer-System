using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lawyer
{
    public partial class Login_Form : Form
    {
        string str = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Lawyer_DB.mdf;Integrated Security = True; Connect Timeout = 30";
        SqlConnection Conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Lawyer_DB.mdf;Integrated Security = True; Connect Timeout = 30");
        SqlCommand cmd = new SqlCommand();

        public Login_Form()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            Createpanel.Visible = false;
            Changepanel.Visible = false;
            LogInpanel.Visible = true;

            EnterPasswordlabel.Visible = false;
            EnterUserNamelabel.Visible = false;
            UserNamelabel.Visible = false;
            Passwordlabel.Visible = false;
            ChangeUserNamelabel.Visible = false;
            ChangePasswordlabel.Visible = false;
            ChangePasswordAgainlabel.Visible = false;
            PasswordAgainlabel.Visible = false;
            NoMatchlabel.Visible = false;
            ChangeNoMatchlabel.Visible = false;
        }

        private void LogInbutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    if (UserNameText.Text == "")
                        EnterUserNamelabel.Visible = true;
                    else
                        EnterUserNamelabel.Visible = false;

                    if (PasswordText.Text == "")
                        EnterPasswordlabel.Visible = true;
                    else
                        EnterPasswordlabel.Visible = false;


                    con.Open();
                    string logIn = "SELECT * FROM log_In WHERE UserName='" + UserNameText.Text + "'and Password='" + PasswordText.Text + "'";
                    cmd = new SqlCommand(logIn, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read() == true)
                    {
                        this.Hide();
                        Main_Form form = new Main_Form();
                        form.Show();
                    }
                    else if (dr.GetValue(0) != UserNameText.Text)
                    { MessageBox.Show("This User doesn's exisit..."); }

                    if (dr.GetValue(1) != PasswordText.Text)
                    {
                        EnterPasswordlabel.Visible = true;
                    }
                    else
                    {
                        EnterPasswordlabel.Visible = false;
                    }

                    con.Close();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                Conn.Close();
            }
        }

        private void CreatelinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Createpanel.Visible = true;
            Createpanel.BringToFront();

        }

        private void ChangelinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Changepanel.Visible = true;
            Changepanel.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserNametextBox.Text == "")
                UserNamelabel.Visible = true;
            else
                UserNamelabel.Visible = false;

            if (PasswordtextBox.Text == "")
                Passwordlabel.Visible = true;
            else
                Passwordlabel.Visible = false;

            if (ConfirmPasswordtextBox.Text == "")
                PasswordAgainlabel.Visible = true;
            else
                PasswordAgainlabel.Visible = false;

            if (ConfirmPasswordtextBox.Text != "" && ConfirmPasswordtextBox.Text != PasswordtextBox.Text)
                NoMatchlabel.Visible = true;
            else if (ConfirmPasswordtextBox.Text != "" && ConfirmPasswordtextBox.Text == PasswordtextBox.Text)
                NoMatchlabel.Visible = false;

            if (PasswordtextBox.Text == ConfirmPasswordtextBox.Text && PasswordtextBox.Text != "" && ConfirmPasswordtextBox.Text != "" && UserNametextBox.Text != "")
            {
                try
                {
                    Conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO log_In(UserName, Password) VALUES(@UserName,@Password)", Conn);
                    cmd.Parameters.AddWithValue("@UserName", UserNametextBox.Text);
                    cmd.Parameters.AddWithValue("@Password", PasswordtextBox.Text);
                    cmd.ExecuteNonQuery();

                    PasswordAgainlabel.Visible = false;
                    Passwordlabel.Visible = false;
                    UserNamelabel.Visible = false;
                    NoMatchlabel.Visible = false;
                    MessageBox.Show("Created Successfully");
                    Conn.Close();
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                    Conn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Createpanel.Visible = false;
            Createpanel.SendToBack();
            LogInpanel.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ChangeUserNametextBox.Text == "")
                ChangeUserNamelabel.Visible = true;
            else
                ChangeUserNamelabel.Visible = false;

            if (ChangePasswordtextBox.Text == "")
                ChangePasswordlabel.Visible = true;
            else
                ChangePasswordlabel.Visible = false;

            if (ChangeConfirmtextBox.Text == "")
                ChangePasswordAgainlabel.Visible = true;
            else
                ChangePasswordAgainlabel.Visible = false;

            if (ChangeConfirmtextBox.Text != "" && ChangeConfirmtextBox.Text != ChangePasswordtextBox.Text)
                ChangeNoMatchlabel.Visible = true;
            else if (ChangeConfirmtextBox.Text != "" && ChangeConfirmtextBox.Text == ChangePasswordtextBox.Text)
                ChangeNoMatchlabel.Visible = false;

            if (ChangePasswordtextBox.Text == ChangeConfirmtextBox.Text && ChangePasswordtextBox.Text != "" && ChangeConfirmtextBox.Text != "" && ChangeUserNametextBox.Text != "")
            {
                try
                {
                    Conn.Open();
                    string logIn = "UPDATE log_In SET Password='" + ChangePasswordtextBox.Text + "' WHERE UserName='" + ChangeUserNametextBox.Text + "'";
                    cmd = new SqlCommand(logIn, Conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Changed Successfully");
                    Conn.Close();
                }
                catch (Exception E)
                {
                    Conn.Close();
                    MessageBox.Show(E.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Changepanel.Visible = false;
            Createpanel.SendToBack();
            LogInpanel.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
