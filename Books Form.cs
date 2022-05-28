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
    public partial class Books_Form : Form
    {
        
        string str = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Lawyer_DB.mdf;Integrated Security = True; Connect Timeout = 30";
        SqlConnection Conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Lawyer_DB.mdf;Integrated Security = True; Connect Timeout = 30");

        public Books_Form()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            Readpanel.Visible = true;
            Notepanel.Visible = false;
            SizecomboBox.Visible = false;
            Fontlabel.Visible = false;

            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Notes", Conn);   // select all data from table Notes to be shown in the datagridview 
            DataTable Data = new DataTable();
            sqlDa.Fill(Data);
            NotedataGridView.DataSource = Data;

            sqlDa = new SqlDataAdapter("SELECT ID, FileName, Exten FROM Books", Conn);    // select all data from table Books to be shown in the datagridview
            Data = new DataTable();
            sqlDa.Fill(Data);
            ReaddataGridView.DataSource = Data;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Readpanel.Visible = false;
            Notepanel.Visible = true;
            SizecomboBox.Visible = true;
            Fontlabel.Visible = true;
        }

        private void AddNotebutton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(str))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Notes(Note) VALUES(@Note)", conn);  // insert notes in the database
                    cmd.Parameters.AddWithValue("@Note", NoterichTextBox.Text);
                    cmd.ExecuteNonQuery();

                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Notes", conn);    //select all data from table Notes to be shown in the datagridview
                    DataTable Data = new DataTable();         // Display data in a tabluler form
                    sqlDa.Fill(Data);
                    NotedataGridView.DataSource = Data;

                    NoterichTextBox.Clear();   // clear NoterichTextBox after entering data

                    conn.Close();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                Conn.Close();
            }
        }

        private void EditNotebutton_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();

                int i = NotedataGridView.SelectedRows[0].Index;    //  Select the row from the datagridview
                string NOTES = NotedataGridView.Rows[i].Cells[0].Value.ToString();    //  Select the column from the datagridview

                string Query = "UPDATE Notes SET Note='" + this.NoterichTextBox.Text + "' WHERE Serial_Number='" + NOTES + "'";  // update a specific row's Notes using the Serial_Number  
                SqlConnection ConDataDase = new SqlConnection(str);
                ConDataDase.Open();
                SqlCommand CMD = new SqlCommand(Query, ConDataDase);
                CMD.ExecuteNonQuery();

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Notes", Conn);    //select all data from table Notes to be shown in the datagridview
                DataTable Data = new DataTable();        // Display data in a tabluler form
                sqlDa.Fill(Data);
                NotedataGridView.DataSource = Data;

                NoterichTextBox.Clear();

                ConDataDase.Close();
                Conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                Conn.Close();
            }
        }

        private void DeleteNotebutton_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();

                int i = NotedataGridView.SelectedRows[0].Index;           //  Select the row from the datagridview
                string NOTES = NotedataGridView.Rows[i].Cells[0].Value.ToString();       //  Select the column from the datagridview

                string Query = "DELETE FROM Notes WHERE Serial_Number='" + NOTES + "'";   //delete specific data from the datsbase 
                SqlConnection ConDataDase = new SqlConnection(str);
                ConDataDase.Open();
                SqlCommand CMD = new SqlCommand(Query, ConDataDase);
                CMD.ExecuteNonQuery();

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Notes", Conn);
                DataTable Data = new DataTable();            // Display data in a tabluler form
                sqlDa.Fill(Data);
                NotedataGridView.DataSource = Data;

                NoterichTextBox.Clear();      // clear NoterichTextBox after entering data

                ConDataDase.Close();
                Conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                Conn.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Readpanel.Visible = true;
            Notepanel.Visible = false;
            SizecomboBox.Visible = false;
            Fontlabel.Visible = false;
        }

        private void SizecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                NoterichTextBox.Font = new Font(NoterichTextBox.Font.FontFamily, float.Parse(SizecomboBox.SelectedItem.ToString()));
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conn.Open();
            OpenFileDialog Open = new OpenFileDialog();
            Open.Filter = "PDF(*.PDF)|*.pdf";    // we choose the pdf file

            if (Open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BooksReadaxAcroPDF1.src = Open.FileName;    // open the pdf file in the screen
                AttachtextBox.Text = Open.FileName;        // put the file path in a textBox
            }
            Conn.Close();
        }

        private void OpenFile(int ID)
        {
            using (SqlConnection conn = new SqlConnection(str))
            {
                string query = "SELECT Data, FileName, Exten FROM Books WHERE ID=@ID";      // select specific item from the database to be shown in the datagridview
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = ID;
                conn.Open();
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    var name = reader["FileName"].ToString();
                    var data = (byte[])reader["Data"];
                    var extn = Convert.ToString(reader["Exten"]);
                    File.WriteAllBytes(name + extn, data);    // collect the file name and its extension to open the file

                    System.Diagnostics.Process.Start(name);      // Open the file
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                var selectRow = ReaddataGridView.SelectedRows;     // select all items from the datagridview in a specific row
                foreach (var row in selectRow)
                {
                    int ID = Convert.ToInt32(((DataGridViewRow)row).Cells[0].Value);    //  select item from the datagridview in a specific column
                    OpenFile(ID);     // pass this item to the Open function
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                Conn.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(str))
                {
                    conn.Open();
                    using (Stream stream = File.OpenRead(AttachtextBox.Text))     // add the file using the path that is stored in the AttachtextBox
                    {
                        byte[] buffer = new byte[stream.Length];
                        stream.Read(buffer, 0, buffer.Length);
                        string extn = new FileInfo(AttachtextBox.Text).Extension;

                        SqlCommand cmd = new SqlCommand("INSERT INTO Books(Data, Exten, FileName) VALUES(@data, @extn, @FileName)", conn);  // insert the data , the extention and the file name in the database
                        cmd.Parameters.AddWithValue("@FileName", AttachtextBox.Text);
                        cmd.Parameters.AddWithValue("@data", SqlDbType.VarBinary).Value = buffer;
                        cmd.Parameters.AddWithValue("@extn", SqlDbType.NVarChar).Value = extn;

                        cmd.ExecuteNonQuery();
                    }
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT ID, FileName, Exten FROM Books", conn);    // select specific item from the database to be shown in the datagridview
                    DataTable Data = new DataTable();                // Display data in a tabluler form
                    sqlDa.Fill(Data);
                    ReaddataGridView.DataSource = Data;

                    AttachtextBox.Clear();

                    conn.Close();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                Conn.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();

                int i = ReaddataGridView.SelectedRows[0].Index;     //  Select the row from the datagridview
                string ID = ReaddataGridView.Rows[i].Cells[0].Value.ToString();    //  Select the column from the datagridview

                // Delete Specific items from the database
                string Query = "DELETE FROM Books WHERE ID='" + ID + "'";
                SqlConnection ConDataDase = new SqlConnection(str);
                ConDataDase.Open();
                SqlCommand CMD = new SqlCommand(Query, ConDataDase);
                CMD.ExecuteNonQuery();

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT ID, FileName, Exten FROM Books", Conn);     // select specific item from the database to be shown in the datagridview
                DataTable Data = new DataTable();     // Display data in a tabluler form
                sqlDa.Fill(Data);
                ReaddataGridView.DataSource = Data;

                AttachtextBox.Clear();

                ConDataDase.Close();
                Conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                Conn.Close();
            }
        }

        private void ReaddataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (ReaddataGridView.SelectedRows.Count >= 0)    // make sure that the number of row greater or equal to zero  (if there are any data)
                {
                    Conn.Open();

                    int i = ReaddataGridView.SelectedRows[0].Index;     //  Select the row from the datagridview
                    string ID = ReaddataGridView.Rows[i].Cells[0].Value.ToString();   //  Select the column from the datagridview

                    SqlCommand CMD = new SqlCommand("SELECT * FROM Books WHERE ID='" + ID + "'", Conn);     // select Specific data from table Books to be shown in the datagridview
                    CMD.Parameters.AddWithValue(ID, Convert.ToString(AttachtextBox.Text));

                    SqlDataReader Read = CMD.ExecuteReader();
                    while (Read.Read())
                    {
                        AttachtextBox.Text = Read.GetValue(1).ToString();
                    }
                    Conn.Close();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                Conn.Close();
            }
        }

        private void NotedataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (NotedataGridView.SelectedRows.Count >= 0)     // make sure that the number of row greater or equal to zero  (if there are any data)
                {
                    Conn.Open();

                    int i = NotedataGridView.SelectedRows[0].Index;    //  Select the row
                    string NOTES = NotedataGridView.Rows[i].Cells[0].Value.ToString();    //  Select the column

                    SqlCommand CMD = new SqlCommand("SELECT * FROM Notes WHERE Serial_Number='" + NOTES + "'", Conn);   // select a specific row in the database
                    CMD.Parameters.AddWithValue(NOTES, Convert.ToString(NoterichTextBox.Text));

                    SqlDataReader Read = CMD.ExecuteReader();
                    while (Read.Read())      // get the data from the database
                    {
                        NoterichTextBox.Text = Read.GetValue(1).ToString();    //put the retrieved data into a textBox
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

        private void button1_Click(object sender, EventArgs e)
        {
            Main_Form form = new Main_Form();
            this.Close();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
