using _2018Proje_SupFollup_v2.Controllers;
using _2018Proje_SupFollup_v2.Models;
using _2018Proje_SupFollup_v2.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _2018Proje_SupFollup_v2
{
    public partial class Transactions : Form, IUserFormView
    {
        public Transactions()
        {
            InitializeComponent();
        }
        private static mUser currentUser;
        private static Control.ControlCollection controls;
        private void Transactions_Load(object sender, EventArgs e)
        {
            controls = this.Controls;
            setButtonSetting();
        }
        private void trns_btn_admn_Click(object sender, EventArgs e)
        {
            //Burası da aynı şeklde
            AdminPanel admin = new AdminPanel();
            this.formCloser();
            UserController controller = new UserController(new UserView(new AdminPanel()),currentUser);
            admin.Show();
        }

        private void trns_btn_sistem_Click(object sender, EventArgs e)
        {
            SuppSystem ss = new SuppSystem();
            ss.Show();
            this.formCloser();
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
            currentUser = m;
        }

        private void setButtonSetting()
        {
            UserController userController = new UserController(new UserView(this), currentUser);
            List<string> list = new List<string>();
            list.Add("si");
            list.Add("ra");
            list.Add("yt");
            switch (currentUser.Yetki)
            {
                case 3:
                    userController.setButtonSettings(true, true, list);
                    break;
                case 2:
                    userController.setButtonSettings(true, true);
                    userController.setButtonSettings(true, false, "yt");
                    break;
                case 1:
                    userController.setButtonSettings(true, false, list);
                    userController.setButtonSettings(true, true, "si");
                    break;
                default:
                    userController.setButtonSettings(false, false);
                    break;
            }

        }
    }
}
