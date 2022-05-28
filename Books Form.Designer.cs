
namespace Lawyer
{
    partial class Books_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.Fontlabel = new System.Windows.Forms.Label();
            this.SizecomboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Readpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AttachtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.BooksReadaxAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.ReaddataGridView = new System.Windows.Forms.DataGridView();
            this.Notepanel = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.NotedataGridView = new System.Windows.Forms.DataGridView();
            this.DeleteNotebutton = new System.Windows.Forms.Button();
            this.EditNotebutton = new System.Windows.Forms.Button();
            this.AddNotebutton = new System.Windows.Forms.Button();
            this.NoterichTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.Readpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksReadaxAcroPDF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReaddataGridView)).BeginInit();
            this.Notepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.Fontlabel);
            this.panel1.Controls.Add(this.SizecomboBox);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1502, 40);
            this.panel1.TabIndex = 0;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button9.Dock = System.Windows.Forms.DockStyle.Right;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Blue;
            this.button9.Location = new System.Drawing.Point(1372, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(65, 40);
            this.button9.TabIndex = 8;
            this.button9.Text = "-";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Fontlabel
            // 
            this.Fontlabel.AutoSize = true;
            this.Fontlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fontlabel.ForeColor = System.Drawing.Color.White;
            this.Fontlabel.Location = new System.Drawing.Point(623, 6);
            this.Fontlabel.Name = "Fontlabel";
            this.Fontlabel.Size = new System.Drawing.Size(94, 24);
            this.Fontlabel.TabIndex = 7;
            this.Fontlabel.Text = "Font Size:";
            // 
            // SizecomboBox
            // 
            this.SizecomboBox.FormattingEnabled = true;
            this.SizecomboBox.Items.AddRange(new object[] {
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26"});
            this.SizecomboBox.Location = new System.Drawing.Point(730, 6);
            this.SizecomboBox.Name = "SizecomboBox";
            this.SizecomboBox.Size = new System.Drawing.Size(156, 24);
            this.SizecomboBox.TabIndex = 7;
            this.SizecomboBox.SelectedIndexChanged += new System.EventHandler(this.SizecomboBox_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(1437, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(40, 554);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(209, 60);
            this.button4.TabIndex = 3;
            this.button4.Text = "Browse";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button5.Location = new System.Drawing.Point(40, 635);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(209, 58);
            this.button5.TabIndex = 4;
            this.button5.Text = "Open";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(269, 635);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(220, 58);
            this.button6.TabIndex = 5;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Lime;
            this.button7.Location = new System.Drawing.Point(269, 554);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(220, 60);
            this.button7.TabIndex = 6;
            this.button7.Text = "Add";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Readpanel
            // 
            this.Readpanel.Controls.Add(this.label1);
            this.Readpanel.Controls.Add(this.AttachtextBox);
            this.Readpanel.Controls.Add(this.label2);
            this.Readpanel.Controls.Add(this.button3);
            this.Readpanel.Controls.Add(this.BooksReadaxAcroPDF1);
            this.Readpanel.Controls.Add(this.ReaddataGridView);
            this.Readpanel.Controls.Add(this.button6);
            this.Readpanel.Controls.Add(this.button7);
            this.Readpanel.Controls.Add(this.button4);
            this.Readpanel.Controls.Add(this.button5);
            this.Readpanel.Location = new System.Drawing.Point(1, 39);
            this.Readpanel.Name = "Readpanel";
            this.Readpanel.Size = new System.Drawing.Size(1501, 742);
            this.Readpanel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(46, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Path";
            // 
            // AttachtextBox
            // 
            this.AttachtextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttachtextBox.Location = new System.Drawing.Point(127, 505);
            this.AttachtextBox.Name = "AttachtextBox";
            this.AttachtextBox.ReadOnly = true;
            this.AttachtextBox.Size = new System.Drawing.Size(350, 32);
            this.AttachtextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(534, 527);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Notes";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button3.BackgroundImage = global::Lawyer.Properties.Resources._1fda6cc9b3d940d7be4acd38366f8fed;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button3.Location = new System.Drawing.Point(511, 554);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 139);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BooksReadaxAcroPDF1
            // 
            this.BooksReadaxAcroPDF1.Dock = System.Windows.Forms.DockStyle.Top;
            this.BooksReadaxAcroPDF1.Enabled = true;
            this.BooksReadaxAcroPDF1.Location = new System.Drawing.Point(0, 0);
            this.BooksReadaxAcroPDF1.Name = "BooksReadaxAcroPDF1";
            this.BooksReadaxAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("BooksReadaxAcroPDF1.OcxState")));
            this.BooksReadaxAcroPDF1.Size = new System.Drawing.Size(1501, 366);
            this.BooksReadaxAcroPDF1.TabIndex = 9;
            // 
            // ReaddataGridView
            // 
            this.ReaddataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReaddataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReaddataGridView.Location = new System.Drawing.Point(676, 505);
            this.ReaddataGridView.Name = "ReaddataGridView";
            this.ReaddataGridView.RowHeadersWidth = 51;
            this.ReaddataGridView.RowTemplate.Height = 24;
            this.ReaddataGridView.Size = new System.Drawing.Size(788, 211);
            this.ReaddataGridView.TabIndex = 8;
            this.ReaddataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReaddataGridView_CellClick);
            // 
            // Notepanel
            // 
            this.Notepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Notepanel.Controls.Add(this.button8);
            this.Notepanel.Controls.Add(this.NotedataGridView);
            this.Notepanel.Controls.Add(this.DeleteNotebutton);
            this.Notepanel.Controls.Add(this.EditNotebutton);
            this.Notepanel.Controls.Add(this.AddNotebutton);
            this.Notepanel.Controls.Add(this.NoterichTextBox);
            this.Notepanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Notepanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notepanel.ForeColor = System.Drawing.Color.Gray;
            this.Notepanel.Location = new System.Drawing.Point(0, 43);
            this.Notepanel.Name = "Notepanel";
            this.Notepanel.Size = new System.Drawing.Size(1502, 735);
            this.Notepanel.TabIndex = 8;
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button8.Location = new System.Drawing.Point(947, 551);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(219, 52);
            this.button8.TabIndex = 6;
            this.button8.Text = "Go To Book";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // NotedataGridView
            // 
            this.NotedataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NotedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotedataGridView.Location = new System.Drawing.Point(46, 503);
            this.NotedataGridView.Name = "NotedataGridView";
            this.NotedataGridView.RowHeadersWidth = 51;
            this.NotedataGridView.RowTemplate.Height = 26;
            this.NotedataGridView.Size = new System.Drawing.Size(776, 217);
            this.NotedataGridView.TabIndex = 4;
            this.NotedataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NotedataGridView_CellClick);
            // 
            // DeleteNotebutton
            // 
            this.DeleteNotebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteNotebutton.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteNotebutton.ForeColor = System.Drawing.Color.Red;
            this.DeleteNotebutton.Location = new System.Drawing.Point(947, 612);
            this.DeleteNotebutton.Name = "DeleteNotebutton";
            this.DeleteNotebutton.Size = new System.Drawing.Size(219, 52);
            this.DeleteNotebutton.TabIndex = 3;
            this.DeleteNotebutton.Text = "Delete";
            this.DeleteNotebutton.UseVisualStyleBackColor = true;
            this.DeleteNotebutton.Click += new System.EventHandler(this.DeleteNotebutton_Click);
            // 
            // EditNotebutton
            // 
            this.EditNotebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditNotebutton.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditNotebutton.ForeColor = System.Drawing.Color.Blue;
            this.EditNotebutton.Location = new System.Drawing.Point(1192, 612);
            this.EditNotebutton.Name = "EditNotebutton";
            this.EditNotebutton.Size = new System.Drawing.Size(219, 52);
            this.EditNotebutton.TabIndex = 2;
            this.EditNotebutton.Text = "Edit";
            this.EditNotebutton.UseVisualStyleBackColor = true;
            this.EditNotebutton.Click += new System.EventHandler(this.EditNotebutton_Click);
            // 
            // AddNotebutton
            // 
            this.AddNotebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNotebutton.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNotebutton.ForeColor = System.Drawing.Color.Lime;
            this.AddNotebutton.Location = new System.Drawing.Point(1192, 551);
            this.AddNotebutton.Name = "AddNotebutton";
            this.AddNotebutton.Size = new System.Drawing.Size(219, 52);
            this.AddNotebutton.TabIndex = 1;
            this.AddNotebutton.Text = "Add";
            this.AddNotebutton.UseVisualStyleBackColor = true;
            this.AddNotebutton.Click += new System.EventHandler(this.AddNotebutton_Click);
            // 
            // NoterichTextBox
            // 
            this.NoterichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.NoterichTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.NoterichTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NoterichTextBox.Location = new System.Drawing.Point(0, 0);
            this.NoterichTextBox.MaximumSize = new System.Drawing.Size(1502, 464);
            this.NoterichTextBox.MinimumSize = new System.Drawing.Size(1502, 464);
            this.NoterichTextBox.Name = "NoterichTextBox";
            this.NoterichTextBox.Size = new System.Drawing.Size(1502, 464);
            this.NoterichTextBox.TabIndex = 0;
            this.NoterichTextBox.Text = "";
            // 
            // Books_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1502, 778);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Readpanel);
            this.Controls.Add(this.Notepanel);
            this.MaximumSize = new System.Drawing.Size(1520, 825);
            this.MinimumSize = new System.Drawing.Size(1520, 825);
            this.Name = "Books_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Readpanel.ResumeLayout(false);
            this.Readpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksReadaxAcroPDF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReaddataGridView)).EndInit();
            this.Notepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NotedataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Fontlabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel Readpanel;
        private System.Windows.Forms.DataGridView ReaddataGridView;
        private System.Windows.Forms.ComboBox SizecomboBox;
        private AxAcroPDFLib.AxAcroPDF BooksReadaxAcroPDF1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Notepanel;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView NotedataGridView;
        private System.Windows.Forms.Button DeleteNotebutton;
        private System.Windows.Forms.Button EditNotebutton;
        private System.Windows.Forms.Button AddNotebutton;
        private System.Windows.Forms.RichTextBox NoterichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AttachtextBox;
        private System.Windows.Forms.Button button9;
    }
}