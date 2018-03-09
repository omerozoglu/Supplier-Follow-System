using _2018Proje_SupFollup_v2.Controllers;
using _2018Proje_SupFollup_v2.Models;
using _2018Proje_SupFollup_v2.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2018Proje_SupFollup_v2
{
    public partial class t_deluser : Form, IUserFormView
    {
        public t_deluser()
        {
            InitializeComponent();
        }

        private static Control.ControlCollection controls;
        public static mUser currentuser { set; get; }
        private void t_deluser_Load(object sender, EventArgs e)
        {
            controls = this.Controls;
            IUserView v = new UserView(this);
            currentuser = v.getCellClicked();

            UserController controller = new UserController(new UserView(this), currentuser);
            List<string> tags = new List<string>();
            tags.Add("ad");
            tags.Add("kad");
            tags.Add("eposta");
            tags.Add("sifre");
            controller.setTextboxText(tags);
        }
        private void del_btn_Click(object sender, EventArgs e)
        {
            // eminmisin ? yapılcak
            UserController controller = new UserController(new UserView(new AdminPanel()),currentuser);
            controller.deleteUser();
            controller = new UserController(new UserView(this), new mUser());
            controller.formClosed();
        }
        public Control.ControlCollection getFormObjects()
        {
            return controls;
        }

        public void formCloser()
        {
            this.Close();
        }

        public void setCurrentuser(mUser m)
        {
            
        }
    }
}
