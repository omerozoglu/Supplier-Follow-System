using _2018Proje_SupFollup_v2.Controllers;
using _2018Proje_SupFollup_v2.Models;
using _2018Proje_SupFollup_v2.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _2018Proje_SupFollup_v2
{
    public partial class t_uppuser : Form ,IUserFormView
    {
        public t_uppuser()
        {
            InitializeComponent();
        }
        private static Control.ControlCollection controls;
        public static mUser currentuser { set; get; }

        private void t_uppuser_Load(object sender, EventArgs e)
        {
            controls = Controls;
            currentuser = new mUser();
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

        private void up_btn_kayıt_Click(object sender, EventArgs e)
        {
            mUser regUser = new mUser();
            regUser.Id = currentuser.Id;
            regUser.Yetki = currentuser.Yetki;
            regUser.Ad = up_txtbx_ad.Text??currentuser.Ad;
            regUser.Kad = up_txtbx_kad.Text??currentuser.Kad;
            regUser.Eposta = up_txtbx_email.Text??currentuser.Eposta;
            regUser.Sifre = up_txtbx_sif.Text??currentuser.Sifre;
            UserController control = new UserController(new UserView(new AdminPanel()), regUser);
            control.updateUser();
            control = new UserController(new UserView(this),new mUser());
            control.formClosed();
        }

        public void formCloser()
        {
            this.Close();
        }

        public Control.ControlCollection getFormObjects()
        {
            return controls;
        }

        public void setCurrentuser(mUser m)
        {
        }
    }
}
