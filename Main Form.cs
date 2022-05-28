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
using System.IO;

namespace Lawyer
{
    public partial class Main_Form : Form
    {
        double New_Pay = 0, Paid = 0, sub = 0;        // initialize some variables for payment

        static string PhoneNumber = string.Empty;
        static string IssueNumber = string.Empty;

        // a connection string to connect to the database
        string str = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Lawyer_DB.mdf;Integrated Security = True; Connect Timeout = 30";
        SqlConnection Conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Lawyer_DB.mdf;Integrated Security = True; Connect Timeout = 30");

        public Main_Form()
        {
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            InitializeComponent();

            Copmetitor1_panel.Visible = false;
            IssueStages1_panel.Visible = false;
            Witness1_panel.Visible = false;
            Client1_panel.Visible = true;
            IssueTopic_panel.Visible = false;
            Salary1_panel.Visible = false;
            Query_panel.Visible = false;
            AddNewCompetitor.Visible = false;
            AddNewWitness.Visible = false;
            AddNewStage.Visible = false;
            Refreshbutton.Visible = false;
            GoToSalarybutton.Visible = false;


            // try this block of code if there any error an exeption will be thrown
            try
            {
                /*
                 * Show all data in Competitor from the database into the datagridview
                 */
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Competitor", Conn);
                DataTable Data = new DataTable();
                sqlDa.Fill(Data);
                CompetitordataGridView.DataSource = Data;


                /*
                 * Show all data in Competitor table from the database into the datagridview
                 */
                sqlDa = new SqlDataAdapter("SELECT IssueNumebr, Date_Of_Last_Meeting, Judge_Verdict, FileName, Exten FROM IssueStages", Conn);
                Data = new DataTable();
                sqlDa.Fill(Data);
                IssueStagedataGridView.DataSource = Data;



                /*
                 * Show all data in Topic table from the database into the datagridview
                 */
                sqlDa = new SqlDataAdapter("SELECT * FROM Topic", Conn);
                Data = new DataTable();
                sqlDa.Fill(Data);
                TopicdataGridView.DataSource = Data;


                /*
                 * Show all data in Witness table from the database into the datagridview
                 */
                sqlDa = new SqlDataAdapter("SELECT * FROM Witness", Conn);
                Data = new DataTable();
                sqlDa.Fill(Data);
                WitnessdataGridView.DataSource = Data;



                /*
                 * Show all data in Client table from the database into the datagridview
                 */
                sqlDa = new SqlDataAdapter("SELECT * FROM Client", Conn);
                Data = new DataTable();
                sqlDa.Fill(Data);
                ClientdataGridView.DataSource = Data;


                /*
                 * Show all data in Salary table from the database into the datagridview
                 */
                sqlDa = new SqlDataAdapter("SELECT Issue_Number, Total, paid, Residual  FROM Salary", Conn);
                Data = new DataTable();
                sqlDa.Fill(Data);
                SalarydataGridView.DataSource = Data;
            }
            catch (Exception E)      //  if there is any error the program will throw an exception 
            {
                MessageBox.Show(E.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client1_panel.Visible = true;
            IssueStages1_panel.Visible = false;
            Witness1_panel.Visible = false;
            Copmetitor1_panel.Visible = false;
            IssueTopic_panel.Visible = false;
            Salary1_panel.Visible = false;
            Query_panel.Visible = false;
            AddNewCompetitor.Visible = false;
            AddNewWitness.Visible = false;
            AddNewStage.Visible = false;
            Refreshbutton.Visible = false;
            GoToSalarybutton.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Witness1_panel.Visible = false;
            IssueStages1_panel.Visible = false;
            Copmetitor1_panel.Visible = true;
            Client1_panel.Visible = false;
            IssueTopic_panel.Visible = false;
            Salary1_panel.Visible = false;
            Query_panel.Visible = false;
            AddNewCompetitor.Visible = false;
            AddNewWitness.Visible = false;
            AddNewStage.Visible = false;
            Refreshbutton.Visible = false;
            GoToSalarybutton.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Copmetitor1_panel.Visible = false;
            Witness1_panel.Visible = true;
            IssueStages1_panel.Visible = false;
            Client1_panel.Visible = false;
            IssueTopic_panel.Visible = false;
            Salary1_panel.Visible = false;
            Query_panel.Visible = false;
            AddNewCompetitor.Visible = false;
            AddNewWitness.Visible = false;
            AddNewStage.Visible = false;
            Refreshbutton.Visible = false;
            GoToSalarybutton.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddNewCompetitor.Visible = true;
            AddNewWitness.Visible = true;
            AddNewStage.Visible = true;
            Refreshbutton.Visible = false;
            GoToSalarybutton.Visible = true;
            Copmetitor1_panel.Visible = false;
            IssueStages1_panel.Visible = false;
            Witness1_panel.Visible = false;
            Client1_panel.Visible = false;
            Salary1_panel.Visible = false;
            IssueTopic_panel.Visible = true;
            Query_panel.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Copmetitor1_panel.Visible = false;
            IssueTopic_panel.Visible = false;
            Witness1_panel.Visible = false;
            Client1_panel.Visible = false;
            IssueStages1_panel.Visible = true;
            Salary1_panel.Visible = false;
            Query_panel.Visible = false;
            AddNewCompetitor.Visible = false;
            AddNewWitness.Visible = false;
            AddNewStage.Visible = false;
            Refreshbutton.Visible = false;
            GoToSalarybutton.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Copmetitor1_panel.Visible = false;
            IssueStages1_panel.Visible = false;
            Witness1_panel.Visible = false;
            Salary1_panel.Visible = true;
            IssueTopic_panel.Visible = false;
            Client1_panel.Visible = false;
            Query_panel.Visible = false;
            AddNewCompetitor.Visible = false;
            AddNewWitness.Visible = false;
            AddNewStage.Visible = false;
            Refreshbutton.Visible = false;
            GoToSalarybutton.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Copmetitor1_panel.Visible = false;
            IssueStages1_panel.Visible = false;
            Witness1_panel.Visible = false;
            Client1_panel.Visible = false;
            IssueTopic_panel.Visible = false;
            Salary1_panel.Visible = false;
            Query_panel.Visible = true;
            AddNewCompetitor.Visible = false;
            AddNewWitness.Visible = false;
            AddNewStage.Visible = false;
            Refreshbutton.Visible = true;
            GoToSalarybutton.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Books_Form Form = new Books_Form();
            Form.Show();
            this.Hide();
        }

        private void AddNewWitness_Click(object sender, EventArgs e)
        {
            Copmetitor1_panel.Visible = false;
            Witness1_panel.Visible = true;
            IssueStages1_panel.Visible = false;
            Client1_panel.Visible = false;
            IssueTopic_panel.Visible = false;
            Salary1_panel.Visible = false;
            AddNewCompetitor.Visible = false;
            AddNewWitness.Visible = false;
            AddNewStage.Visible = false;
            Query_panel.Visible = false;
            GoToSalarybutton.Visible = false;
            Refreshbutton.Visible = false;
        }

        private void GoToSalarybutton_Click(object sender, EventArgs e)
        {
            Copmetitor1_panel.Visible = false;
            IssueStages1_panel.Visible = false;
            Witness1_panel.Visible = false;
            Salary1_panel.Visible = true;
            IssueTopic_panel.Visible = false;
            Client1_panel.Visible = false;
            AddNewCompetitor.Visible = false;
            AddNewWitness.Visible = false;
            AddNewStage.Visible = false;
            Query_panel.Visible = false;
            Refreshbutton.Visible = false;
            GoToSalarybutton.Visible = false;
            IssueNumberSalarytextBox.Text = IssueNumbertextBox.Text;     // Copy the Issue Number from the Topic Page to salary page  
        }

        private void AddNewStage_Click(object sender, EventArgs e)
        {
            Copmetitor1_panel.Visible = false;
            IssueStages1_panel.Visible = true;
            Witness1_panel.Visible = false;
            Client1_panel.Visible = false;
            IssueTopic_panel.Visible = false;
            Salary1_panel.Visible = false;
            AddNewCompetitor.Visible = false;
            AddNewWitness.Visible = false;
            AddNewStage.Visible = false;
            Query_panel.Visible = false;
            Refreshbutton.Visible = false;
            GoToSalarybutton.Visible = false;
            StageNumbertextBox.Text = IssueNumbertextBox.Text;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(str))
                {
                    conn.Open();

                    // insert Topic's Details in the database
                    SqlCommand cmd = new SqlCommand("INSERT INTO Topic(Topic, Topic.Issue_Number, Section, Issue_Type,Topic.Client_Phone_Number, Power_Of_Attorney_Office, Power_Of_Attorney_Number,Date_of_power_of_attorney) VALUES(@Topic, @Issue_Number, @Section, @Issue_Type,@Client_PhoneNumber, @Power_of_attorney_office, @Power_of_attorney_number,@Date_of_the_power_of_attorney)", conn);
                    cmd.Parameters.AddWithValue("@Topic", TopictextBox.Text);
                    cmd.Parameters.AddWithValue("@Issue_Number", IssueNumbertextBox.Text);
                    cmd.Parameters.AddWithValue("@Issue_Type", IssueTypecomboBox.Text);
                    cmd.Parameters.AddWithValue("@Section", SectiontextBox.Text);
                    cmd.Parameters.AddWithValue("@Client_PhoneNumber", ClientNumbertextBox.Text);
                    cmd.Parameters.AddWithValue("@Power_of_attorney_office", PowerOfficetextBox.Text);
                    cmd.Parameters.AddWithValue("@Power_of_attorney_number", PowerNumbertextBox.Text);
                    cmd.Parameters.AddWithValue("@Date_of_the_power_of_attorney", PowerdateTimePicker.Text);
                    cmd.ExecuteNonQuery();


                    // set the dara from the database to a datagridview
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Topic", conn);
                    DataTable Data = new DataTable();
                    sqlDa.Fill(Data);
                    TopicdataGridView.DataSource = Data;


                    //clear textBoxes to re-Enter new data  
                    IssueNumbertextBox.Clear();
                    ClientNumbertextBox.Clear();
                    PowerOfficetextBox.Clear();
                    TopictextBox.Clear();

                    conn.Close();
                }
            }
            catch (Exception E)       //  if there is any error the program will throw an exception 
            {
                MessageBox.Show(E.Message);
                Conn.Close();
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();

                int i = TopicdataGridView.SelectedRows[0].Index;      //  Select the row
                string IssueNumber = TopicdataGridView.Rows[i].Cells[0].Value.ToString();     //  Select the column

                // Update specific data from the database 
                string Query = "UPDATE Topic SET Topic='" + this.TopictextBox.Text + "' , Section='" + this.SectiontextBox.Text + "', Issue_Type='" + this.IssueTypecomboBox.Text + "', Date_Of_Power_Of_Attorney='" + this.PowerdateTimePicker.Text + "', Power_of_attorney_number='" + this.PowerNumbertextBox.Text + "' ,Power_of_attorney_office='" + this.PowerOfficetextBox.Text + "' WHERE Issue_Number='" + IssueNumber + "'";
                SqlConnection ConDataDase = new SqlConnection(str);
                ConDataDase.Open();
                SqlCommand CMD = new SqlCommand(Query, ConDataDase);
                CMD.ExecuteNonQuery();


                // select all data from table Topic to be shown in the datagridview
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Topic", Conn);
                DataTable Data = new DataTable();
                sqlDa.Fill(Data);
                TopicdataGridView.DataSource = Data;


                //clear textBoxes to re-Enter new data  
                ClientNumbertextBox.Clear();
                IssueNumbertextBox.Clear();
                PowerNumbertextBox.Clear();
                PowerOfficetextBox.Clear();
                TopictextBox.Clear();

                ConDataDase.Close();
                Conn.Close();
            }
            catch (Exception E)      //  if there is any error the program will throw an exception 
            {
                MessageBox.Show(E.Message);
                Conn.Close();
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();

                int i = TopicdataGridView.SelectedRows[0].Index;   //  Select the row
                string IssueNumber = TopicdataGridView.Rows[i].Cells[0].Value.ToString();   //  Select the column

                string Query = "UPDATE [RelationTopic_Competitor] SET [RelationTopic_Competitor].IssueNumber=NULL WHERE [RelationTopic_Competitor].IssueNumber='" + IssueNumber + "'";
                SqlConnection ConDataDase = new SqlConnection(str);
                ConDataDase.Open();
                SqlCommand CMD = new SqlCommand(Query, ConDataDase);
                CMD.ExecuteNonQuery();

                Query = "UPDATE [RelationTopic_Witness] SET [RelationTopic_Witness].IssueNumber=NULL WHERE [RelationTopic_Witness].IssueNumber='" + IssueNumber + "'";
                ConDataDase = new SqlConnection(str);
                ConDataDase.Open();
                CMD = new SqlCommand(Query, ConDataDase);
                CMD.ExecuteNonQuery();

                //delete specific data from the database 
                Query = "DELETE FROM Topic WHERE Issue_Number='" + IssueNumber + "'";
                ConDataDase = new SqlConnection(str);
                ConDataDase.Open();
                CMD = new SqlCommand(Query, ConDataDase);
                CMD.ExecuteNonQuery();


                // set the dara from the database to a datagridview
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Topic", Conn);
                DataTable Data = new DataTable();
                sqlDa.Fill(Data);
                TopicdataGridView.DataSource = Data;


                //clear textBoxes to re-Enter new data  
                IssueNumbertextBox.Clear();
                PowerNumbertextBox.Clear();
                ClientNumbertextBox.Clear();
                PowerOfficetextBox.Clear();
                TopictextBox.Clear();

                ConDataDase.Close();
                Conn.Close();
            }
            catch (Exception E)     //  if there is any error the program will throw an exception 
            {
                MessageBox.Show(E.Message);
                Conn.Close();
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            try
            {
                if (SalarydataGridView.SelectedRows.Count >= 0)     // make sure that the number of row greater or equal to zero  (if there are any data)
                {
                    Conn.Open();

                    int i = SalarydataGridView.SelectedRows[0].Index;     //  Select the row
                    string Issue_Number = SalarydataGridView.Rows[i].Cells[0].Value.ToString();    //  Select the column

                    SqlCommand CMD = new SqlCommand("SELECT Issue_Number, Total, paid, Residual  FROM Salary WHERE Issue_Number='" + Issue_Number + "'", Conn);
                    CMD.Parameters.AddWithValue(Issue_Number, Convert.ToString(IssueNumberSalarytextBox.Text));

                    SqlDataReader Read = CMD.ExecuteReader();


                    // read data
                    while (Read.Read())
                    {
                        TotaltextBox.Text = Read.GetValue(1).ToString();     // store the total from the database into a variable 
                        Paid = double.Parse(Read.GetValue(2).ToString());   // store the paid from the database into a variable 
                    }
                    ResidualtextBox.Text = TotaltextBox.Text;     // copy the value from the TotaltextBox into ResidualtextBox

                    double num = double.Parse(ResidualtextBox.Text);

                    New_Pay = double.Parse(PrePaidtextBox.Text);   // take new payment from the user and store it in avariable


                    // make sure that the values greater than zero
                    if (num > 0 && New_Pay > 0)
                    {
                        Paid += New_Pay;   // add the new pay with the previous value taken from the database
                        sub = num - Paid;    // withdrawal the new pay from the total

                        ResidualtextBox.Text = sub.ToString();
                        PaytextBox.Text = Paid.ToString();

                        // change the values in the database
                        string Query = "UPDATE Salary SET Residual='" + sub + "', paid='" + Paid + "' WHERE Issue_Number='" + Issue_Number + "'";
                        SqlConnection ConDataDase = new SqlConnection(str);
                        ConDataDase.Open();
                        CMD = new SqlCommand(Query, ConDataDase);
                        CMD.ExecuteNonQuery();
                        Conn.Close();

                        Conn.Open();
                        // refresh the screen with the new data
                        SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Issue_Number, Total, paid, Residual FROM Salary", Conn);
                        DataTable Data = new DataTable();  // store data in a tablular form
                        sqlDa.Fill(Data);
                        SalarydataGridView.DataSource = Data;  // dlisplay results in the datagridview


                        //clear textBox to re-Enter new data  
                        PrePaidtextBox.Clear();
                    }
                    Conn.Close();
                }
            }
            catch (Exception E)       //  if there is any error the program will throw an exception 
            {
                MessageBox.Show(E.Message);
                Conn.Close();
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(str))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Salary(Issue_Number, Total, paid, Residual) VALUES(@IssueNumber,@Total, @Paid, @Residual)", conn);
                    cmd.Parameters.AddWithValue("@IssueNumber", IssueNumberSalarytextBox.Text);
                    cmd.Parameters.AddWithValue("@Total", TotaltextBox.Text);
                    cmd.Parameters.AddWithValue("@Paid", PaytextBox.Text);
                    cmd.Parameters.AddWithValue("@Residual", TotaltextBox.Text);
                    cmd.ExecuteNonQuery();


                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Issue_Number, Total, paid, Residual  FROM Salary", conn);
                    DataTable Data = new DataTable();
                    sqlDa.Fill(Data);
                    SalarydataGridView.DataSource = Data;


                    //clear textBoxes to re-Enter new data  
                    IssueNumberSalarytextBox.Clear();
                    TotaltextBox.Clear();
                    PrePaidtextBox.Clear();
                    PaytextBox.Clear();
                    ResidualtextBox.Clear();

                    conn.Close();
                }
            }
            catch (Exception E)       //  if there is any error the program will throw an exception 
            {
                MessageBox.Show(E.Message);
                Conn.Close();
            }

        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();

                int i = SalarydataGridView.SelectedRows[0].Index;    //  Select the row
                string IssueNumber = SalarydataGridView.Rows[i].Cells[0].Value.ToString();   //  Select the column

                string Query = "UPDATE Salary SET Total='" + this.TotaltextBox.Text + "', WHERE Issue_Number='" + IssueNumber + "'";
                SqlConnection ConDataDase = new SqlConnection(str);
                ConDataDase.Open();
                SqlCommand CMD = new SqlCommand(Query, ConDataDase);
                CMD.ExecuteNonQuery();

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Issue_Number, Total, paid, Residual  FROM Salary", Conn);
                DataTable Data = new DataTable();
                sqlDa.Fill(Data);
                SalarydataGridView.DataSource = Data;


                //clear textBoxes to re-Enter new data  
                IssueNumberSalarytextBox.Clear();
                TotaltextBox.Clear();
                PrePaidtextBox.Clear();
                PaytextBox.Clear();
                ResidualtextBox.Clear();

                ConDataDase.Close();
                Conn.Close();
            }
            catch (Exception E)          //  if there is any error the program will throw an exception 
            {
                MessageBox.Show(E.Message);
                Conn.Close();
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();

                int i = SalarydataGridView.SelectedRows[0].Index;    //  Select the row
                string IssueNumber = SalarydataGridView.Rows[i].Cells[0].Value.ToString();   //  Select the column

                string Query = "DELETE FROM Salary WHERE Issue_number='" + IssueNumber + "'";
                SqlConnection ConDataDase = new SqlConnection(str);
                ConDataDase.Open();
                SqlCommand CMD = new SqlCommand(Query, ConDataDase);
                CMD.ExecuteNonQuery();

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Issue_Number, Total, paid, Residual  FROM Salary", Conn);
                DataTable Data = new DataTable();
                sqlDa.Fill(Data);
                SalarydataGridView.DataSource = Data;


                //clear textBoxes to re-Enter new data  
                IssueNumberSalarytextBox.Clear();
                TotaltextBox.Clear();
                PrePaidtextBox.Clear();
                PaytextBox.Clear();
                ResidualtextBox.Clear();

                ConDataDase.Close();
                Conn.Close();
            }
            catch (Exception E)      //  if there is any error the program will throw an exception 
            {
                MessageBox.Show(E.Message);
                Conn.Close();
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(str))
                {
                    conn.Open();          // Open connection with the database

                    // insert data that are taken from the textBoxes into the Client Table in the database
                    SqlCommand cmd = new SqlCommand("INSERT INTO Client(Client_Name, Client_NickName, Client_Address, Client_Phone_Number) VALUES(@Name,@NickName, @Address, @Phone_Number)", conn);
                    cmd.Parameters.AddWithValue("@Name", ClientNametextBox.Text);
                    cmd.Parameters.AddWithValue("@NickName", ClientNickNametextBox.Text);
                    cmd.Parameters.AddWithValue("@Address", ClientAddresstextBox.Text);
                    cmd.Parameters.AddWithValue("@Phone_Number", PhoneNumbertextBox.Text);
                    cmd.ExecuteNonQuery();


                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Client", conn);     //select all data from table Client to be shown in the datagridview
                    DataTable Data = new DataTable();     //Display the data in a tabluler 
                    sqlDa.Fill(Data);
                    ClientdataGridView.DataSource = Data;


                    // clear all textBoxes to insert new data in them
                    ClientNametextBox.Clear();
                    ClientAddresstextBox.Clear();
                    ClientNickNametextBox.Clear();
                    PhoneNumbertextBox.Clear();

                    conn.Close();        // Close connection with the database
                }
            }
            catch (Exception E)     //  if there is any error the program will throw an exception 
            {
                MessageBox.Show(E.Message);
                Conn.Close();         // Close connection with the database
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Copmetitor1_panel.Visible = false;
            IssueStages1_panel.Visible = false;
            Witness1_panel.Visible = false;
            Client1_panel.Visible = false;
            Salary1_panel.Visible = false;
            IssueTopic_panel.Visible = true;
            AddNewCompetitor.Visible = true;
            AddNewWitness.Visible = true;
            AddNewStage.Visible = true;
            Query_panel.Visible = false;
            Refreshbutton.Visible = false;
            GoToSalarybutton.Visible = true;
            ClientNumbertextBox.Text = PhoneNumbertextBox.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();

                int i = ClientdataGridView.SelectedRows[0].Index;     //  Select the row from the datagridview
                string PhoneNumber = ClientdataGridView.Rows[i].Cells[3].Value.ToString();     //  Select the column from the datagridview


                // update a specific row's Notes using the Serial_Number 
                string Query = "UPDATE Client SET Client_Name='" + this.ClientNametextBox.Text + "' , Client_Address='" + this.ClientAddresstextBox.Text + "', Client_NickName='" + this.ClientNickNametextBox.Text + "'WHERE Client_Phone_Number='" + PhoneNumber + "'";
                SqlConnection ConDataDase = new SqlConnection(str);
                ConDataDase.Open();
                SqlCommand CMD = new SqlCommand(Query, ConDataDase);
                CMD.ExecuteNonQuery();


                //select all data from table Client to be shown in the datagridview
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Client", Conn);
                DataTable Data = new DataTable();    // Display data in a tabluler form
                sqlDa.Fill(Data);
                ClientdataGridView.DataSource = Data;


                //clear textBoxes to re-Enter new data  
                ClientNametextBox.Clear();
                ClientAddresstextBox.Clear();
                ClientNickNametextBox.Clear();
                PhoneNumbertextBox.Clear();

                ConDataDase.Close();
                Conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                Conn.Close();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();        // Open connection with the database

                int i = ClientdataGridView.SelectedRows[0].Index;      //  Select the row from the datagridview
                string PhoneNumber = ClientdataGridView.Rows[i].Cells[3].Value.ToString();    //  Select the column from the datagridview
                string Query;
                SqlConnection ConDataDase;
                SqlCommand CMD;


                // Update the data and replace it with new values inserted in the textBboxes
                Query = "UPDATE Topic SET Client_Phone_Number=NULL WHERE Client_Phone_Number='" + PhoneNumbertextBox.Text + "'";
                ConDataDase = new SqlConnection(str);
                ConDataDase.Open();          // Open connection with the database
                CMD = new SqlCommand(Query, ConDataDase);
                CMD.ExecuteNonQuery();

                // delete the selected record
                Query = "DELETE FROM Client WHERE Client_Phone_Number='" + PhoneNumber + "'";
                ConDataDase = new SqlConnection(str);
                ConDataDase.Open();             // Open connection with the database
                CMD = new SqlCommand(Query, ConDataDase);
                CMD.ExecuteNonQuery();



                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Client", Conn);     //select all data from table Client to be shown in the datagridview
                DataTable Data = new DataTable();     //Display the data in a tabuler
                sqlDa.Fill(Data);
                ClientdataGridView.DataSource = Data;   // put the data in the datagridview



                sqlDa = new SqlDataAdapter("SELECT * FROM Topic", Conn);            //select all data from table Topic to be shown in the datagridview
                Data = new DataTable();   //Display the data in a tabuler
                sqlDa.Fill(Data);
                TopicdataGridView.DataSource = Data;    // put the data in the datagridview


                // clear all textBoxes to insert new data in them
                ClientNametextBox.Clear();
                ClientNickNametextBox.Clear();
                ClientAddresstextBox.Clear();
                PhoneNumbertextBox.Clear();

                ConDataDase.Close();      // Close connection with the database
                Conn.Close();         // Close connection with the database
            }
            catch (Exception E)     //  if there is any error the program will throw an exception 
            {
                MessageBox.Show(E.Message);
                Conn.Close();          // Close connection with the database
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Conn.Open();
            OpenFileDialog Open = new OpenFileDialog();

            if (Open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                AttachmentstextBox.Text = Open.FileName;     // put the file path in a textBox
            }
            Conn.Close();
        }

        private void OpenFile(int IssueNumebr)
        {
            using (SqlConnection conn = new SqlConnection(str))
            {
                string query = "SELECT Data, FileName, Exten FROM IssueStages WHERE IssueNumebr=@IssueNumebr";    // select specific item from the database to be shown in the datagridview
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IssueNumebr", SqlDbType.Int).Value = IssueNumebr;
                conn.Open();
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    var name = reader["FileName"].ToString();
                    var data = (byte[])reader["Data"];
                    var extn = Convert.ToString(reader["Exten"]);
                    File.WriteAllBytes(name + extn, data);     // collect the file name and its extension to open the file

                    System.Diagnostics.Process.Start(name);     // Open the file
                }
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                var selectRow = IssueStagedataGridView.SelectedRows;    // select all items from the datagridview in a specific row
                foreach (var row in selectRow)
                {
                    int IssueNumebr = Convert.ToInt32(((DataGridViewRow)row).Cells[0].Value);   //  select item from the datagridview in a specific column
                    OpenFile(IssueNumebr);   // pass this item to the Open function
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                Conn.Close();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(str))   // open a connection with the database 
                {
                    conn.Open();
                    using (Stream stream = File.OpenRead(AttachmentstextBox.Text))
                    {
                        byte[] buffer = new byte[stream.Length];
                        stream.Read(buffer, 0, buffer.Length);
                        string extn = new FileInfo(AttachmentstextBox.Text).Extension;


                        // Insert some data from the textBox into the database 
                        SqlCommand cmd = new SqlCommand("INSERT INTO IssueStages(Data, Exten, IssueNumebr, Date_Of_Last_Meeting, Judge_Verdict, FileName) VALUES(@data, @extn, @IssueNumebr, @Date_Of_Last_Meeting, @Judge_Verdict, @FileName)", conn);
                        cmd.Parameters.AddWithValue("@IssueNumebr", StageNumbertextBox.Text);
                        cmd.Parameters.AddWithValue("@Date_Of_Last_Meeting", MeetingdateTimePicker1.Text);
                        cmd.Parameters.AddWithValue("@Judge_Verdict", JudgetextBox.Text);
                        cmd.Parameters.AddWithValue("@FileName", AttachmentstextBox.Text);
                        cmd.Parameters.AddWithValue("@data", SqlDbType.VarBinary).Value = buffer;
                        cmd.Parameters.AddWithValue("@extn", SqlDbType.NVarChar).Value = extn;

                        cmd.ExecuteNonQuery();
                    }

                    // select all data from table Issue Stages to be shown in the datagridview
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT IssueNumebr, Date_Of_Last_Meeting, Judge_Verdict, FileName, Exten FROM IssueStages", conn);
                    DataTable Data = new DataTable();
                    sqlDa.Fill(Data);
                    IssueStagedataGridView.DataSource = Data;


                    //clear textBoxes to Re-Enter new data  
                    StageNumbertextBox.Clear();
                    JudgetextBox.Clear();
                    AttachmentstextBox.Clear();

                    conn.Close();
                }
            }
            catch (Exception E)        //  if there is any error the program will throw an exception 
            {
                MessageBox.Show(E.Message);
                Conn.Close();
            }

        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();

                int i = IssueStagedataGridView.SelectedRows[0].Index;    //  Select the row
                string IssueNumebr = IssueStagedataGridView.Rows[i].Cells[0].Value.ToString();   //  Select the column
                byte[] buffer;
                string extn;

                // take some data from the path of the file
                using (Stream stream = File.OpenRead(AttachmentstextBox.Text))
                {
                    buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, buffer.Length);
                    extn = new FileInfo(AttachmentstextBox.Text).Extension;
                }

                // update a specific row's Issue Stages using the Issue Numebr 
                string Query = "UPDATE IssueStages SET Judge_Verdict='" + JudgetextBox.Text + "', Exten ='" + extn + "',Date_Of_Last_Meeting='" + MeetingdateTimePicker1.Text + "', FileName ='" + AttachmentstextBox.Text + "'  WHERE IssueNumebr='" + IssueNumebr + "'";
                SqlConnection ConDataDase = new SqlConnection(str);
                ConDataDase.Open();
                SqlCommand CMD = new SqlCommand(Query, ConDataDase);
                CMD.ExecuteNonQuery();

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT IssueNumebr, Date_Of_Last_Meeting, Judge_Verdict, FileName, Exten FROM IssueStages", Conn);
                DataTable Data = new DataTable();
                sqlDa.Fill(Data);
                IssueStagedataGridView.DataSource = Data;


                //clear textBoxes to re-Enter new data  
                StageNumbertextBox.Clear();
                JudgetextBox.Clear();
                AttachmentstextBox.Clear();

                ConDataDase.Close();
                Conn.Close();
            }
            catch (Exception E)         //  if there is any error the program will throw an exception 
            {
                MessageBox.Show(E.Message);
                Conn.Close();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();

                int i = IssueStagedataGridView.SelectedRows[0].Index;    // Select the row from the datagridview
                string PhoneNumber = IssueStagedataGridView.Rows[i].Cells[0].Value.ToString();     // Select the column from the datagridview


                // Delete rows from Issue Stages table in the database
                string Query = "DELETE FROM IssueStages WHERE IssueNumebr='" + PhoneNumber + "'";
                SqlConnection ConDataDase = new SqlConnection(str);
                ConDataDase.Open();
                SqlCommand CMD = new SqlCommand(Query, ConDataDase);
                CMD.ExecuteNonQuery();

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT IssueNumebr, Date_Of_Last_Meeting, Judge_Verdict, FileName, Exten FROM IssueStages", Conn);
                DataTable Data = new DataTable();
                sqlDa.Fill(Data);
                IssueStagedataGridView.DataSource = Data;


                //clear textBoxes to re-Enter new data  
                StageNumbertextBox.Clear();
                JudgetextBox.Clear();
                AttachmentstextBox.Clear();

                ConDataDase.Close();
                Conn.Close();
            }
            catch (Exception E)       //  if there is any error the program will throw an exception 
            {
                MessageBox.Show(E.Message);
                Conn.Close();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(str))
                {
                    conn.Open();

                    // insert some data from the textBox into the database
                    SqlCommand cmd = new SqlCommand("INSERT INTO Witness(Witness_Name, Witness_NickName, Witness_Address, Witness_Phone_Number) VALUES(@Name,@NickName, @Address, @Phone_Number)", conn);
                    cmd.Parameters.AddWithValue("@Name", WitnessNametextBox.Text);
                    cmd.Parameters.AddWithValue("@NickName", WitnessNickNametextBox.Text);
                    cmd.Parameters.AddWithValue("@Address", WitnessAddresstextBox.Text);
                    cmd.Parameters.AddWithValue("@Phone_Number", WitnessPhoneNumbertextBox.Text);
                    cmd.ExecuteNonQuery();

                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Witness", conn);   //select all data from table Witness to be shown in the datagridview
                    DataTable Data = new DataTable();  //  Display the data in a tabluler
                    sqlDa.Fill(Data);
                    WitnessdataGridView.DataSource = Data;    // put the data in the datagridview

                    // insert values to make a relations between data in the database
                    cmd = new SqlCommand("INSERT INTO RelationTopic_Witness(IssueNumber, PhoneNumber) VALUES(@Issue_Number, @Witness_Phone_Number)", conn);
                    cmd.Parameters.AddWithValue("@Issue_Number", IssueNumbertextBox.Text);
                    cmd.Parameters.AddWithValue("@Witness_Phone_Number", WitnessPhoneNumbertextBox.Text);
                    cmd.ExecuteNonQuery();


                    // clear textBoxes to Re-Enter new data  
                    WitnessNametextBox.Clear();
                    WitnessNickNametextBox.Clear();
                    WitnessAddresstextBox.Clear();
                    WitnessPhoneNumbertextBox.Clear();

                    conn.Close();
                }
            }
            catch (Exception E)          //  if there is any error the program will throw an exception 
            {
                MessageBox.Show(E.Message);
                Conn.Close();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();

                int i = WitnessdataGridView.SelectedRows[0].Index;    //  Select the row from the datagridview
                string PhoneNumber = WitnessdataGridView.Rows[i].Cells[3].Value.ToString();    //  Select the column from the datagridview

                string Query = "UPDATE Witness SET Witness_Name='" + this.WitnessNametextBox.Text + "' , Witness_Address='" + this.WitnessAddresstextBox.Text + "', Witness_NickName='" + this.WitnessNickNametextBox.Text + "'WHERE Witness_Phone_Number='" + PhoneNumber + "'";
                SqlConnection ConDataDase = new SqlConnection(str);
                ConDataDase.Open();
                SqlCommand CMD = new SqlCommand(Query, ConDataDase);
                CMD.ExecuteNonQuery();

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Witness", Conn);   //select all data from table Witness to be shown in the datagridview
                DataTable Data = new DataTable();
                sqlDa.Fill(Data);
                WitnessdataGridView.DataSource = Data;


                //clear textBoxes to re-Enter new data  
                WitnessNametextBox.Clear();
                WitnessNickNametextBox.Clear();
                WitnessAddresstextBox.Clear();
                WitnessPhoneNumbertextBox.Clear();

                ConDataDase.Close();
                Conn.Close();
            }
            catch (Exception E)      //  if there is any error the program will throw an exception 
            {
                MessageBox.Show(E.Message);
                Conn.Close();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();

                int i = WitnessdataGridView.SelectedRows[0].Index;    //  Select the row from the datagridview
                string PhoneNumber = WitnessdataGridView.Rows[i].Cells[3].Value.ToString();     //  Select the column from the datagridview


                //  set the deleted values with NULL in the database
                string Query = "UPDATE RelationTopic_Witness SET IssueNumber=NULL, PhoneNumber = NULL WHERE PhoneNumber='" + WitnessPhoneNumbertextBox.Text + "'";
                SqlConnection ConDataDase = new SqlConnection(str);
                ConDataDase.Open();
                SqlCommand CMD = new SqlCommand(Query, ConDataDase);
                CMD.ExecuteNonQuery();


                // Delete rows from Witness table in the database
                Query = "DELETE FROM Witness WHERE Witness_Phone_Number='" + PhoneNumber + "'";
                ConDataDase = new SqlConnection(str);
                ConDataDase.Open();
                CMD = new SqlCommand(Query, ConDataDase);
                CMD.ExecuteNonQuery();

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Witness", Conn);      //select all data from table Witness to be shown in the datagridview
                DataTable Data = new DataTable();     //  Display the data in a tabluler
                sqlDa.Fill(Data);
                WitnessdataGridView.DataSource = Data;    // put the data in the datagridview


                //clear textBoxes to re-Enter new data  
                WitnessNametextBox.Clear();
                WitnessNickNametextBox.Clear();
                WitnessAddresstextBox.Clear();
                WitnessPhoneNumbertextBox.Clear();

                ConDataDase.Close();
                Conn.Close();
            }
            catch (Exception E)       //  if there is any error the program will throw an exception 
            {
                MessageBox.Show(E.Message);
                Conn.Close();
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(str))
                {
                    conn.Open();   // open connection with the database


                    // insert some data from the textBox into the database
                    SqlCommand cmd = new SqlCommand("INSERT INTO Competitor(Competitor_Name, Competitor_NickName, Competitor_Address, Competitor_Phone_Number) VALUES(@Name,@NickName, @Address, @Phone_Number)", conn);
                    cmd.Parameters.AddWithValue("@Name", CompetitorNametextBox.Text);
                    cmd.Parameters.AddWithValue("@NickName", CompetitorNickNametextBox.Text);
                    cmd.Parameters.AddWithValue("@Address", CompetitorAddresstextBox.Text);
                    cmd.Parameters.AddWithValue("@Phone_Number", CompetitorPhoneNumbertextBox.Text);
                    cmd.ExecuteNonQuery();


                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Competitor", conn);     //select all data from table Competitor to be shown in the datagridview
                    DataTable Data = new DataTable();     //Display the data in a tabluler
                    sqlDa.Fill(Data);
                    CompetitordataGridView.DataSource = Data;      // put the data in the datagridview


                    // insert some data to make the relation between tables into the database 
                    cmd = new SqlCommand("INSERT INTO RelationTopic_Competitor(IssueNumber, PhoneNumber) VALUES(@Issue_Number, @Competitor_Phone_Number)", conn);
                    cmd.Parameters.AddWithValue("@Issue_Number", IssueNumbertextBox.Text);
                    cmd.Parameters.AddWithValue("@Competitor_Phone_Number", CompetitorPhoneNumbertextBox.Text);
                    cmd.ExecuteNonQuery();


                    // clear all textBoxes to insert new data in them
                    CompetitorNametextBox.Clear();
                    CompetitorNickNametextBox.Clear();
                    CompetitorAddresstextBox.Clear();
                    CompetitorPhoneNumbertextBox.Clear();

                    conn.Close();   // close connection with the database
                }
            }
            catch (Exception E)     //  if there is any error the program will throw an exception 
            {
                MessageBox.Show(E.Message);
                Conn.Close();    // close connection with the database
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();     // open connection with the database

                int i = CompetitordataGridView.SelectedRows[0].Index;         //  Select the row from the datagridview
                string PhoneNumber = CompetitordataGridView.Rows[i].Cells[3].Value.ToString();        //  Select the column from the datagridview

                string Query = "UPDATE Competitor SET Competitor_Name='" + this.CompetitorNametextBox.Text + "' , Competitor_Address='" + this.CompetitorAddresstextBox.Text + "', Competitor_NickName='" + this.CompetitorNickNametextBox.Text + "'WHERE Competitor_Phone_Number='" + PhoneNumber + "'";
                SqlConnection ConDataDase = new SqlConnection(str);
                ConDataDase.Open();         // open connection with the database
                SqlCommand CMD = new SqlCommand(Query, ConDataDase);
                CMD.ExecuteNonQuery();

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Competitor", Conn);      //select all data from table Competitor to be shown in the datagridview
                DataTable Data = new DataTable();      //Display the data in a tabluler
                sqlDa.Fill(Data);
                CompetitordataGridView.DataSource = Data;    // put the data in the datagridview


                // clear all textBoxes to insert new data in them
                CompetitorNametextBox.Clear();
                CompetitorNickNametextBox.Clear();
                CompetitorAddresstextBox.Clear();
                CompetitorPhoneNumbertextBox.Clear();

                ConDataDase.Close();// close connection with the database
                Conn.Close();// close connection with the database
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                Conn.Close();    // close connection with the database
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();       // open connection with the database

                int i = CompetitordataGridView.SelectedRows[0].Index;      //  Select the row from the datagridview
                string PhoneNumber = CompetitordataGridView.Rows[i].Cells[3].Value.ToString();        //  Select the column from the datagridview


                //  set the deleted values with NULL in the database
                string Query = "UPDATE RelationTopic_Competitor SET IssueNumber=NULL, PhoneNumber=NULL WHERE PhoneNumber ='" + CompetitorPhoneNumbertextBox.Text + "'";
                SqlConnection ConDataDase = new SqlConnection(str);
                ConDataDase.Open();        // open connection with the database
                SqlCommand CMD = new SqlCommand(Query, ConDataDase);
                CMD.ExecuteNonQuery();


                // delete the selected record
                Query = "DELETE FROM Competitor WHERE Competitor_Phone_Number='" + PhoneNumber + "'";
                ConDataDase = new SqlConnection(str);
                ConDataDase.Open();          // open connection with the database
                CMD = new SqlCommand(Query, ConDataDase);
                CMD.ExecuteNonQuery();

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Competitor", Conn);      //select all data from table Competitor to be shown in the datagridview
                DataTable Data = new DataTable();     //Display the data in a tabluler
                sqlDa.Fill(Data);
                CompetitordataGridView.DataSource = Data;    // put the data in the datagridview


                // clear all textBoxes to insert new data in them
                CompetitorNametextBox.Clear();
                CompetitorNickNametextBox.Clear();
                CompetitorAddresstextBox.Clear();
                CompetitorPhoneNumbertextBox.Clear();

                ConDataDase.Close();        // close connection with the database
                Conn.Close();         // close connection with the database
            }
            catch (Exception E)    //  if there is any error the program will throw an exception 
            {
                MessageBox.Show(E.Message);
                Conn.Close();       // close connection with the database
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void CompetitordataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (CompetitordataGridView.SelectedRows.Count >= 0)    // make sure that the number of row greater or equal to zero  (if there are any data)
                {
                    Conn.Open();

                    int i = CompetitordataGridView.SelectedRows[0].Index;     //  Select the row from the datagridview
                    string PhoneNumber = CompetitordataGridView.Rows[i].Cells[3].Value.ToString();      //  Select the column

                    SqlCommand CMD = new SqlCommand("SELECT * FROM Competitor WHERE Competitor_Phone_Number='" + PhoneNumber + "'", Conn);
                    CMD.Parameters.AddWithValue(PhoneNumber, Convert.ToString(CompetitorPhoneNumbertextBox.Text));

                    SqlDataReader Read = CMD.ExecuteReader();

                    // read data taken from the database and show it in the textBoxes
                    while (Read.Read())
                    {
                        CompetitorNametextBox.Text = Read.GetValue(1).ToString();
                        CompetitorNickNametextBox.Text = Read.GetValue(4).ToString();
                        CompetitorAddresstextBox.Text = Read.GetValue(2).ToString();
                        CompetitorPhoneNumbertextBox.Text = Read.GetValue(3).ToString();
                    }
                    Conn.Close();
                }
            }
            catch (Exception E)       //  if there is any error the program will throw an exception 
            {
                MessageBox.Show(E.Message);
                Conn.Close();
            }
        }

        private void ClientdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (ClientdataGridView.SelectedRows.Count >= 0)
                {
                    Conn.Open();    // open connection with the database

                    int i = ClientdataGridView.SelectedRows[0].Index;    //  Select the row from the datagridview
                    string PhoneNumber = ClientdataGridView.Rows[i].Cells[3].Value.ToString();     //  Select the column from the datagridview

                    SqlCommand CMD = new SqlCommand("SELECT * FROM Client WHERE Client_Phone_Number='" + PhoneNumber + "'", Conn);     //select specifif data from table Client to be shown in the datagridview
                    CMD.Parameters.AddWithValue(PhoneNumber, Convert.ToString(PhoneNumbertextBox.Text));

                    SqlDataReader Read = CMD.ExecuteReader();

                    while (Read.Read())
                    {
                        ClientNametextBox.Text = Read.GetValue(1).ToString();
                        ClientNickNametextBox.Text = Read.GetValue(4).ToString();
                        ClientAddresstextBox.Text = Read.GetValue(2).ToString();
                        PhoneNumbertextBox.Text = Read.GetValue(3).ToString();
                    }
                    Conn.Close();         // Close connection with the database
                }
            }
            catch (Exception E)    //  if there is any error the program will throw an exception 
            {
                MessageBox.Show(E.Message);
                Conn.Close();        // Close connection with the database
            }
        }

        private void WitnessdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (WitnessdataGridView.SelectedRows.Count >= 0)       // make sure that the number of row greater or equal to zero  (if there are any data)
                {
                    Conn.Open();

                    int i = WitnessdataGridView.SelectedRows[0].Index;    //  Select the row from the datagridview
                    string PhoneNumber = WitnessdataGridView.Rows[i].Cells[3].Value.ToString();   //  Select the column from the datagridview

                    SqlCommand CMD = new SqlCommand("SELECT * FROM Witness WHERE Witness_Phone_Number='" + PhoneNumber + "'", Conn);
                    CMD.Parameters.AddWithValue(PhoneNumber, Convert.ToString(WitnessPhoneNumbertextBox.Text));

                    SqlDataReader Read = CMD.ExecuteReader();

                    // read data taken from the database and show it in the textBoxes
                    while (Read.Read())
                    {
                        WitnessNametextBox.Text = Read.GetValue(1).ToString();
                        WitnessNickNametextBox.Text = Read.GetValue(4).ToString();
                        WitnessAddresstextBox.Text = Read.GetValue(2).ToString();
                        WitnessPhoneNumbertextBox.Text = Read.GetValue(3).ToString();
                    }
                    Conn.Close();
                }
            }
            catch (Exception E)        //  if there is any error the program will throw an exception 
            {
                MessageBox.Show(E.Message);
                Conn.Close();
            }
        }

        private void IssueStagedataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (IssueStagedataGridView.SelectedRows.Count >= 0)      // make sure that the number of row greater or equal to zero  (if there are any data)
                {
                    Conn.Open();

                    int i = IssueStagedataGridView.SelectedRows[0].Index;       // Select the row from the datagridview
                    string PhoneNumber = IssueStagedataGridView.Rows[i].Cells[0].Value.ToString();   //  Select the column from the datagridview


                    // Select specific data from the database by selecting a row in the datagridview
                    SqlCommand CMD = new SqlCommand("SELECT * FROM IssueStages WHERE IssueNumebr='" + PhoneNumber + "'", Conn);
                    CMD.Parameters.AddWithValue(PhoneNumber, Convert.ToString(StageNumbertextBox.Text));

                    SqlDataReader Read = CMD.ExecuteReader();

                    // read data taken from the database and show it in the textBoxes
                    while (Read.Read())
                    {
                        StageNumbertextBox.Text = Read.GetValue(0).ToString();
                        MeetingdateTimePicker1.Text = Read.GetValue(1).ToString();
                        JudgetextBox.Text = Read.GetValue(2).ToString();
                        AttachmentstextBox.Text = Read.GetValue(5).ToString();
                    }
                    Conn.Close();
                }
            }
            catch (Exception E)      //  if there is any error the program will throw an exception 
            {
                MessageBox.Show(E.Message);
                Conn.Close();
            }
        }

        private void Witness1_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SalarydataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (SalarydataGridView.SelectedRows.Count >= 0)    // make sure that the number of row greater or equal to zero  (if there are any data)
                {
                    Conn.Open();

                    int i = SalarydataGridView.SelectedRows[0].Index;    //  Select the row
                    string Issue_Number = SalarydataGridView.Rows[i].Cells[0].Value.ToString();    //  Select the Column

                    SqlCommand CMD = new SqlCommand("SELECT * FROM Salary WHERE Issue_Number='" + Issue_Number + "'", Conn);
                    CMD.Parameters.AddWithValue(PhoneNumber, Convert.ToString(IssueNumberSalarytextBox.Text));

                    SqlDataReader Read = CMD.ExecuteReader();
                    while (Read.Read())
                    {
                        IssueNumberSalarytextBox.Text = Read.GetValue(0).ToString();
                        TotaltextBox.Text = Read.GetValue(1).ToString();
                        PaytextBox.Text = Read.GetValue(2).ToString();
                        ResidualtextBox.Text = Read.GetValue(4).ToString();
                    }
                    Conn.Close();
                }
            }
            catch (Exception E)      //  if there is any error the program will throw an exception 
            {
                MessageBox.Show(E.Message);
                Conn.Close();
            }
        }

        private void TopicdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (TopicdataGridView.SelectedRows.Count >= 0)    // make sure that the number of row greater or equal to zero  (if there are any data)
                {
                    Conn.Open();

                    int i = TopicdataGridView.SelectedRows[0].Index;    //  Select the row
                    string IssueNumber = TopicdataGridView.Rows[i].Cells[0].Value.ToString();     //  Select the column

                    SqlCommand CMD = new SqlCommand("SELECT * FROM Topic WHERE Issue_Number='" + IssueNumber + "'", Conn);   // select a specific row in the database
                    CMD.Parameters.AddWithValue(IssueNumber, Convert.ToString(IssueNumbertextBox.Text));

                    SqlDataReader Read = CMD.ExecuteReader();


                    // get the data from the database
                    while (Read.Read())
                    {
                        IssueNumbertextBox.Text = Read.GetValue(0).ToString();
                        IssueTypecomboBox.Text = Read.GetValue(1).ToString();
                        ClientNumbertextBox.Text = Read.GetValue(2).ToString();
                        SectiontextBox.Text = Read.GetValue(3).ToString();
                        PowerdateTimePicker.Text = Read.GetValue(4).ToString();
                        PowerNumbertextBox.Text = Read.GetValue(5).ToString();
                        PowerOfficetextBox.Text = Read.GetValue(6).ToString();
                        TopictextBox.Text = Read.GetValue(7).ToString();
                    }
                    Conn.Close();
                }
            }
            catch (Exception E)     //  if there is any error the program will throw an exception 
            {
                MessageBox.Show(E.Message);
                Conn.Close();
            }
        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            // get data using client name
            if (ClientNameradioButton.Checked)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT [Client].[Client_Phone_Number], [Client_Address], [Competitor_Name], [Competitor_Address], [Competitor_Phone_Number], [Witness_Name], [Witness_Address], [Witness_Phone_Number], [Issue_Number], [Issue_Type], [Section], [Date_Of_Power_Of_Attorney], [Power_Of_Attorney_Office], [Topic]FROM [Client]INNER JOIN ( [Topic] INNER JOIN ( [dbo].[Competitor] INNER JOIN [RelationTopic_Competitor] ON [Competitor].[Competitor_Phone_Number]=[RelationTopic_Competitor].[PhoneNumber] )ON [RelationTopic_Competitor].[IssueNumber]=[Topic].[Issue_Number] INNER JOIN ([Witness] INNER JOIN [RelationTopic_Witness] ON [RelationTopic_Witness].PhoneNumber=[Witness].Witness_Phone_Number) ON [RelationTopic_Witness].IssueNumber=[Topic].Issue_Number)ON [Topic].Client_Phone_Number=[Client].Client_Phone_Number WHERE [Client_Name]='" + QueryClientNametextBox.Text + "'", Conn);
                DataTable Data = new DataTable();
                sqlDa.Fill(Data);
                QuerydataGridView.DataSource = Data;
            }

            // get data using Competitor name
            if (CompetitorNameradioButton.Checked)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT [Client_Name], [Client].[Client_Phone_Number], [Client_Address], [Witness_Name], [Witness_Address], [Witness_Phone_Number], [Issue_Number], [Issue_Type], [Section], [Date_Of_Power_Of_Attorney], [Power_Of_Attorney_Office], [Topic] FROM [Competitor]INNER JOIN ( [RelationTopic_Competitor] INNER JOIN ( [Topic] INNER JOIN ( [RelationTopic_Witness] INNER JOIN [Witness] ON [RelationTopic_Witness].PhoneNumber=[Witness].Witness_Phone_Number ) ON [Topic].Issue_Number=[RelationTopic_Witness].IssueNumber INNER JOIN [dbo].[Client] ON [Client].Client_Phone_Number=[Topic].Client_Phone_Number ) ON [Topic].Issue_Number=[RelationTopic_Competitor].IssueNumber )ON [Competitor].[Competitor_Phone_Number]=[RelationTopic_Competitor].[PhoneNumber] WHERE [Competitor_Name]='" + QueryCompetitorNametextBox.Text + "'", Conn);
                DataTable Data = new DataTable();
                sqlDa.Fill(Data);
                QuerydataGridView.DataSource = Data;
            }

            // get data using Witness name
            if (WitnessNameradioButton.Checked)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT[Client_Name], [Client].[Client_Phone_Number], [Client_Address], [Competitor_Name], [Competitor_Address], [Competitor_Phone_Number], [Issue_Number], [Issue_Type], [Section], [Date_Of_Power_Of_Attorney], [Power_Of_Attorney_Office], [Topic] FROM[Witness] INNER JOIN([RelationTopic_Witness] INNER JOIN([Topic] INNER JOIN( [RelationTopic_Competitor] INNER JOIN[Competitor] ON[RelationTopic_Competitor].PhoneNumber =[Competitor].Competitor_Phone_Number) ON[Topic].Issue_Number =[RelationTopic_Competitor].IssueNumber INNER JOIN[dbo].[Client] ON[Client].Client_Phone_Number =[Topic].Client_Phone_Number) ON[Topic].Issue_Number =[RelationTopic_Witness].IssueNumber) ON[Witness].[Witness_Phone_Number] =[RelationTopic_Witness].[PhoneNumber] WHERE[Witness_Name] = '" + QueryWitnessNametextBox.Text + "'", Conn);
                DataTable Data = new DataTable();
                sqlDa.Fill(Data);
                QuerydataGridView.DataSource = Data;
            }

            // get data using Client Phone Number
            if (ClientPhoneNumberradioButton.Checked)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT[Client].[Client_Phone_Number], [Client_Address], [Competitor_Name], [Competitor_Address], [Competitor_Phone_Number], [Witness_Name], [Witness_Address], [Witness_Phone_Number], [Issue_Number], [Issue_Type], [Section], [Date_Of_Power_Of_Attorney], [Power_Of_Attorney_Office], [Topic]FROM[Client] INNER JOIN([Topic] INNER JOIN( [dbo].[Competitor] INNER JOIN[RelationTopic_Competitor] ON[Competitor].[Competitor_Phone_Number] =[RelationTopic_Competitor].[PhoneNumber]) ON[RelationTopic_Competitor].[IssueNumber] =[Topic].[Issue_Number] INNER JOIN([Witness] INNER JOIN [RelationTopic_Witness] ON[RelationTopic_Witness].PhoneNumber=[Witness].Witness_Phone_Number) ON[RelationTopic_Witness].IssueNumber =[Topic].Issue_Number )ON[Topic].Client_Phone_Number =[Client].Client_Phone_Number WHERE[Client].[Client_Phone_Number] = '" + QueryClientPhoneNumbertextBox.Text + "'", Conn);
                DataTable Data = new DataTable();
                sqlDa.Fill(Data);
                QuerydataGridView.DataSource = Data;
            }

            // get data using Competitor Phone Number
            if (CompetitorPhoneNumberradioButton.Checked)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT[Client_Name], [Client].[Client_Phone_Number], [Client_Address], [Witness_Name], [Witness_Address], [Witness_Phone_Number], [Issue_Number], [Issue_Type], [Section], [Date_Of_Power_Of_Attorney], [Power_Of_Attorney_Office], [Topic] FROM[Competitor] INNER JOIN( [RelationTopic_Competitor] INNER JOIN( [Topic] INNER JOIN( [RelationTopic_Witness] INNER JOIN[Witness] ON[RelationTopic_Witness].PhoneNumber =[Witness].Witness_Phone_Number) ON[Topic].Issue_Number =[RelationTopic_Witness].IssueNumber INNER JOIN[dbo].[Client] ON[Client].Client_Phone_Number =[Topic].Client_Phone_Number) ON[Topic].Issue_Number =[RelationTopic_Competitor].IssueNumber) ON[Competitor].[Competitor_Phone_Number] =[RelationTopic_Competitor].[PhoneNumber] WHERE[Competitor_Phone_Number] = '" + QueryCompetitorPhoneNumbertextBox.Text + "'", Conn);
                DataTable Data = new DataTable();
                sqlDa.Fill(Data);
                QuerydataGridView.DataSource = Data;
            }

            // get data using Witness Phone Number
            if (WitnessPhoneNumberradioButton.Checked)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT[Client_Name], [Client].[Client_Phone_Number], [Client_Address], [Competitor_Name], [Competitor_Address], [Competitor_Phone_Number], [Issue_Number], [Issue_Type], [Section], [Date_Of_Power_Of_Attorney], [Power_Of_Attorney_Office], [Topic] FROM[Witness] INNER JOIN([RelationTopic_Witness] INNER JOIN( [Topic] INNER JOIN( [RelationTopic_Competitor] INNER JOIN[Competitor] ON[RelationTopic_Competitor].PhoneNumber =[Competitor].Competitor_Phone_Number) ON[Topic].Issue_Number =[RelationTopic_Competitor].IssueNumber INNER JOIN[dbo].[Client] ON[Client].Client_Phone_Number =[Topic].Client_Phone_Number ) ON[Topic].Issue_Number =[RelationTopic_Witness].IssueNumber) ON[Witness].[Witness_Phone_Number] =[RelationTopic_Witness].[PhoneNumber] WHERE[Witness_Phone_Number] = '" + QueryWitnessPhoneNumbertextBox.Text + "'", Conn);
                DataTable Data = new DataTable();
                sqlDa.Fill(Data);
                QuerydataGridView.DataSource = Data;
            }

            // get data using Competitor Address
            if (CompetitorAddressradioButton.Checked)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT[Client_Name], [Client].[Client_Phone_Number], [Client_Address], [Witness_Name], [Witness_Address], [Witness_Phone_Number], [Issue_Number], [Issue_Type], [Section], [Date_Of_Power_Of_Attorney], [Power_Of_Attorney_Office], [Topic] FROM[Competitor] INNER JOIN([RelationTopic_Competitor] INNER JOIN( [Topic] INNER JOIN([RelationTopic_Witness] INNER JOIN[Witness] ON[RelationTopic_Witness].PhoneNumber =[Witness].Witness_Phone_Number) ON[Topic].Issue_Number =[RelationTopic_Witness].IssueNumber INNER JOIN[dbo].[Client] ON[Client].Client_Phone_Number =[Topic].Client_Phone_Number)ON[Topic].Issue_Number =[RelationTopic_Competitor].IssueNumber) ON[Competitor].[Competitor_Phone_Number] =[RelationTopic_Competitor].[PhoneNumber] WHERE[Competitor_Address] = '" + QueryCompetitorAddresstextBox.Text + "'", Conn);
                DataTable Data = new DataTable();
                sqlDa.Fill(Data);
                QuerydataGridView.DataSource = Data;
            }

            // get data using Client Address
            if (ClientAddressradioButton.Checked)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT[Client].[Client_Phone_Number], [Client_Address], [Competitor_Name], [Competitor_Address], [Competitor_Phone_Number], [Witness_Name], [Witness_Address], [Witness_Phone_Number], [Issue_Number], [Issue_Type], [Section], [Date_Of_Power_Of_Attorney], [Power_Of_Attorney_Office], [Topic] FROM[Client] INNER JOIN([Topic] INNER JOIN( [dbo].[Competitor] INNER JOIN[RelationTopic_Competitor] ON[Competitor].[Competitor_Phone_Number] =[RelationTopic_Competitor].[PhoneNumber]) ON[RelationTopic_Competitor].[IssueNumber] =[Topic].[Issue_Number] INNER JOIN([Witness] INNER JOIN [RelationTopic_Witness] ON[RelationTopic_Witness].PhoneNumber=[Witness].Witness_Phone_Number) ON[RelationTopic_Witness].IssueNumber =[Topic].Issue_Number) ON[Topic].Client_Phone_Number =[Client].Client_Phone_Number WHERE[Client].[Client_Address] = '" + QueryClientAddresstextBox.Text + "'", Conn);
                DataTable Data = new DataTable();
                sqlDa.Fill(Data);
                QuerydataGridView.DataSource = Data;
            }

            // get data using Witness Address
            if (WitnessAddressradioButton.Checked)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT[Client_Name], [Client].[Client_Phone_Number], [Client_Address], [Competitor_Name], [Competitor_Address], [Competitor_Phone_Number], [Issue_Number], [Issue_Type], [Section], [Date_Of_Power_Of_Attorney], [Power_Of_Attorney_Office], [Topic] FROM[Witness] INNER JOIN([RelationTopic_Witness] INNER JOIN([Topic] INNER JOIN([RelationTopic_Competitor] INNER JOIN[Competitor] ON[RelationTopic_Competitor].PhoneNumber =[Competitor].Competitor_Phone_Number) ON[Topic].Issue_Number =[RelationTopic_Competitor].IssueNumber INNER JOIN[dbo].[Client] ON[Client].Client_Phone_Number =[Topic].Client_Phone_Number) ON[Topic].Issue_Number =[RelationTopic_Witness].IssueNumber) ON[Witness].[Witness_Phone_Number] =[RelationTopic_Witness].[PhoneNumber] WHERE[Witness_Address] = '" + QueryWitnessAddresstextBox.Text + "'", Conn);
                DataTable Data = new DataTable();
                sqlDa.Fill(Data);
                QuerydataGridView.DataSource = Data;
            }

            // get data using Section
            if (SectionradioButton.Checked)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT[Client_Name], [Client].[Client_Phone_Number], [Client_Address], [Competitor_Name], [Competitor_Phone_Number], [Competitor_Address], [Witness_Name], [Witness_Phone_Number], [Witness_Address], [Issue_Type], [Topic], [Issue_Number] FROM[Topic] INNER JOIN( [dbo].[RelationTopic_Competitor] INNER JOIN[dbo].[Competitor] ON[RelationTopic_Competitor].PhoneNumber =[Competitor].Competitor_Phone_Number) ON[RelationTopic_Competitor].IssueNumber =[Topic].Issue_Number INNER JOIN([dbo].[RelationTopic_Witness] INNER JOIN [dbo].[Witness] ON[RelationTopic_Witness].PhoneNumber=[Witness].Witness_Phone_Number)ON[RelationTopic_Witness].IssueNumber =[Topic].Issue_Number INNER JOIN[dbo].[Client] ON[Client].Client_Phone_Number =[Topic].Client_Phone_Number WHERE[Section] = '" + QuerySectiontextBox.Text + "'", Conn);
                DataTable Data = new DataTable();
                sqlDa.Fill(Data);
                QuerydataGridView.DataSource = Data;
            }

            // get data using Issue Number
            if (IssueNumberradioButton.Checked)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT[Client_Name], [Client].[Client_Phone_Number], [Client_Address], [Competitor_Name], [Competitor_Phone_Number], [Competitor_Address], [Witness_Name], [Witness_Phone_Number], [Witness_Address], [Issue_Type], [Topic], [Section] FROM[Topic] INNER JOIN([dbo].[RelationTopic_Competitor] INNER JOIN[dbo].[Competitor] ON[RelationTopic_Competitor].PhoneNumber =[Competitor].Competitor_Phone_Number) ON[RelationTopic_Competitor].IssueNumber =[Topic].Issue_Number INNER JOIN([dbo].[RelationTopic_Witness] INNER JOIN [dbo].[Witness] ON[RelationTopic_Witness].PhoneNumber=[Witness].Witness_Phone_Number) ON[RelationTopic_Witness].IssueNumber =[Topic].Issue_Number INNER JOIN[dbo].[Client] ON[Client].Client_Phone_Number =[Topic].Client_Phone_Number WHERE[Issue_Number] = '" + QueryIssueNumbertextBox.Text + "'", Conn);
                DataTable Data = new DataTable();
                sqlDa.Fill(Data);
                QuerydataGridView.DataSource = Data;
            }

            // get data using Issue Type
            if (IssueTyperadioButton.Checked)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT[Client_Name], [Client].[Client_Phone_Number], [Client_Address], [Competitor_Name], [Competitor_Phone_Number], [Competitor_Address], [Witness_Name], [Witness_Phone_Number], [Witness_Address], [Topic], [Section], [Issue_Number] FROM[Topic] INNER JOIN( [dbo].[RelationTopic_Competitor] INNER JOIN[dbo].[Competitor] ON[RelationTopic_Competitor].PhoneNumber =[Competitor].Competitor_Phone_Number) ON[RelationTopic_Competitor].IssueNumber =[Topic].Issue_Number INNER JOIN([dbo].[RelationTopic_Witness] INNER JOIN [dbo].[Witness] ON[RelationTopic_Witness].PhoneNumber=[Witness].Witness_Phone_Number) ON[RelationTopic_Witness].IssueNumber =[Topic].Issue_Number INNER JOIN[dbo].[Client] ON[Client].Client_Phone_Number =[Topic].Client_Phone_Number WHERE[Issue_Type] = '" + QueryIssueTypetextBox.Text + "'", Conn);
                DataTable Data = new DataTable();
                sqlDa.Fill(Data);
                QuerydataGridView.DataSource = Data;
            }

            // get data using Issue Topic
            if (IssueTopicradioButton.Checked)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT[Client_Name], [Client].[Client_Phone_Number], [Client_Address], [Competitor_Name], [Competitor_Phone_Number], [Competitor_Address], [Witness_Name], [Witness_Phone_Number], [Witness_Address], [Issue_Type], [Section], [Issue_Number] FROM[Topic] INNER JOIN( [dbo].[RelationTopic_Competitor] INNER JOIN[dbo].[Competitor] ON[RelationTopic_Competitor].PhoneNumber =[Competitor].Competitor_Phone_Number) ON[RelationTopic_Competitor].IssueNumber =[Topic].Issue_Number INNER JOIN([dbo].[RelationTopic_Witness] INNER JOIN [dbo].[Witness] ON[RelationTopic_Witness].PhoneNumber=[Witness].Witness_Phone_Number) ON[RelationTopic_Witness].IssueNumber =[Topic].Issue_Number INNER JOIN[dbo].[Client] ON[Client].Client_Phone_Number =[Topic].Client_Phone_Number WHERE[Topic] = '" + QueryIssueTopictextBox.Text + "'", Conn);
                DataTable Data = new DataTable();
                sqlDa.Fill(Data);
                QuerydataGridView.DataSource = Data;
            }

            // get data using Date Of Last Meeting
            if (DateOfLastMeetingradioButton.Checked)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT [Client_Name], [Client].[Client_Phone_Number], [Client_Address], [Competitor_Name], [Competitor_Phone_Number], [Competitor_Address], [Witness_Name], [Witness_Phone_Number], [Witness_Address], [Issue_Type], [Topic], [Section], [Issue_Number], [Judge_Verdict] FROM [dbo].[IssueStages] INNER JOIN( [Topic] INNER JOIN ( [RelationTopic_Competitor] INNER JOIN [Competitor] ON [Competitor].Competitor_Phone_Number=[RelationTopic_Competitor].PhoneNumber) ON [RelationTopic_Competitor].IssueNumber=[Topic].Issue_Number INNER JOIN ( [RelationTopic_Witness] INNER JOIN [Witness] ON [Witness].Witness_Phone_Number=[RelationTopic_Witness].PhoneNumber) ON [RelationTopic_Witness].IssueNumber=[Topic].Issue_Number INNER JOIN [Client] ON [Client].Client_Phone_Number=[Topic].Client_Phone_Number ) ON [Topic].Issue_Number=[IssueStages].IssueNumebr WHERE [IssueStages].Date_Of_Last_Meeting='" + DateOfLastMeetingtextBox.Text + "'", Conn);
                DataTable Data = new DataTable();
                sqlDa.Fill(Data);
                QuerydataGridView.DataSource = Data;
            }

            // get data using Date Of Power Of Attorney
            if (DateOfPowerOfAttorneyradioButton.Checked)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT[Client_Name], [Client].[Client_Phone_Number], [Client_Address], [Competitor_Name], [Competitor_Phone_Number], [Competitor_Address], [Witness_Name], [Witness_Phone_Number], [Witness_Address], [Issue_Type], [Topic], [Section], [Issue_Number] FROM[Topic] INNER JOIN( [dbo].[RelationTopic_Competitor] INNER JOIN[dbo].[Competitor] ON[RelationTopic_Competitor].PhoneNumber =[Competitor].Competitor_Phone_Number) ON[RelationTopic_Competitor].IssueNumber =[Topic].Issue_Number INNER JOIN([dbo].[RelationTopic_Witness] INNER JOIN [dbo].[Witness] ON[RelationTopic_Witness].PhoneNumber=[Witness].Witness_Phone_Number) ON[RelationTopic_Witness].IssueNumber =[Topic].Issue_Number INNER JOIN[dbo].[Client] ON[Client].Client_Phone_Number =[Topic].Client_Phone_Number WHERE[Topic].Power_Of_Attorney_Office = '" + DateOfPowertextBox.Text + "'", Conn);
                DataTable Data = new DataTable();
                sqlDa.Fill(Data);
                QuerydataGridView.DataSource = Data;
            }

            // get data using Judge Verdict
            if (JudgeVerdictradioButton.Checked)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT[Client_Name], [Client].[Client_Phone_Number], [Client_Address], [Competitor_Name], [Competitor_Phone_Number], [Competitor_Address], [Witness_Name], [Witness_Phone_Number], [Witness_Address], [Issue_Type], [Topic], [Section], [Issue_Number], [Judge_Verdict] FROM[dbo].[IssueStages]INNER JOIN([Topic] INNER JOIN( [RelationTopic_Competitor] INNER JOIN[Competitor] ON[Competitor].Competitor_Phone_Number =[RelationTopic_Competitor].PhoneNumber) ON[RelationTopic_Competitor].IssueNumber =[Topic].Issue_Number INNER JOIN([RelationTopic_Witness] INNER JOIN [Witness] ON[Witness].Witness_Phone_Number=[RelationTopic_Witness].PhoneNumber) ON[RelationTopic_Witness].IssueNumber =[Topic].Issue_Number INNER JOIN[Client] ON[Client].Client_Phone_Number =[Topic].Client_Phone_Number)ON[Topic].Issue_Number =[IssueStages].IssueNumebr WHERE[IssueStages].Judge_Verdict = '" + QueryJudgeVerdicttextBox.Text + "'", Conn);
                DataTable Data = new DataTable();
                sqlDa.Fill(Data);
                QuerydataGridView.DataSource = Data;
            }
        }

        private void AddNewCompetitor_Click(object sender, EventArgs e)
        {
            Witness1_panel.Visible = false;
            IssueStages1_panel.Visible = false;
            Copmetitor1_panel.Visible = true;
            Client1_panel.Visible = false;
            IssueTopic_panel.Visible = false;
            Salary1_panel.Visible = false;
            AddNewCompetitor.Visible = false;
            AddNewWitness.Visible = false;
            AddNewStage.Visible = false;
            Query_panel.Visible = false;
            Refreshbutton.Visible = false;
            GoToSalarybutton.Visible = false;
        }
    }
}
