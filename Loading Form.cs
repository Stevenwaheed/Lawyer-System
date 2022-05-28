using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lawyer
{
    public partial class Loading_Form : Form
    {
        public Loading_Form()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            // Increment the Width of the loading panel and stop the timer to Open THE log in form
            while (Loadingpanel.Width < 5884)
            {
                Loadingpanel.Width += 1;

                if (Loadingpanel.Width >= 5884)
                {
                    LoadingTimer.Stop();      // stop the timer
                    Login_Form Form = new Login_Form();    // open log in form
                    Form.Show();
                    this.Hide();
                }
            }
        }

        private void Loading_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
