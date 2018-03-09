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
    public partial class Register : Form, IUserFormView
    {
        public Register()
        {
            InitializeComponent();
        }
        private static Control.ControlCollection controls { get; set; }


        private void Register_Load(object sender, EventArgs e)
        {
            controls = this.Controls;
        }

        private void reg_btn_kayıt_Click(object sender, EventArgs e)
        {
            mUser regUser = new mUser();
            try
            {
                regUser.Ad = reg_txtbx_ad.Text != "" ? reg_txtbx_ad.Text : null;
                regUser.Kad = reg_txtbx_kad.Text != "" ? reg_txtbx_kad.Text : null;
                regUser.Eposta = reg_txtbx_email.Text != "" ? reg_txtbx_email.Text : null;
                regUser.Sifre = reg_txtbx_sif.Text != "" ? reg_txtbx_sif.Text : null;
                UserController control = new UserController(new UserView(this), regUser);
                control.insertUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source);
            }

        }
        private void reg_btn_grsyap_Click(object sender, EventArgs e)
        {
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
            
        }
    }
}
