using _2018Proje_SupFollup_v2.Controllers;
using _2018Proje_SupFollup_v2.Data;
using _2018Proje_SupFollup_v2.Models;
using _2018Proje_SupFollup_v2.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _2018Proje_SupFollup_v2
{
    public partial class Login : Form, IUserFormView
    {
        public Login()
        {
            InitializeComponent();
        }
        private static Control.ControlCollection controls { get; set; }
        private void Login_Load(object sender, EventArgs e)
        {
            controls = this.Controls;
        }

        private void login_btn_login_Click(object sender, EventArgs e)
        {
            //SupplierSystemModel m = new SupplierSystemModel();
            //SupplierSystemModel m2 = new SupplierSystemModel();
            //List<SupplierSystemModel> listm = new List<SupplierSystemModel>();
            //m.id = 1;
            //m.name = "T";
            //m.startdate = DateTime.Now;
            //m.enddate = DateTime.Now;
            //m.piece = 500;
            //m.properties = "tttttttt 555555555";
            //m.personid = 2;
            //m.suppid = 1;
            //m.isinvoice = true;
            //m.agncyprice = 9999;
            //m.price = 9999;
            //m.logid = 1;
            //listm = m.searchSupplierSystem();
            //m2 = m.getSupplierSystem();
            mUser loginedUser = new mUser();
            loginedUser.Kad = login_txtbx_kad.Text;
            loginedUser.Sifre = login_txtbx_sif.Text;
            UserController control = new UserController(new UserView(this), loginedUser);
            control.checkLogin();
           
        }
        private void login_kayıt_ol_Click(object sender, EventArgs e)
        {
            var reg = new Register();
            reg.ShowDialog();
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
            throw new NotImplementedException();
        }
    }
}
