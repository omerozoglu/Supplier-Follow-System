using System;
using System.Windows.Forms;

namespace _2018Proje_SupFollup_v2
{
    public partial class Splashscreen : Form
    {
        public Splashscreen()
        {
            InitializeComponent();
        }

        private void Splashscreen_Load(object sender, EventArgs e)
        {
            Splashscreen sp = this;
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            var login = new Login();
            login.Show();
        }
    }
}
