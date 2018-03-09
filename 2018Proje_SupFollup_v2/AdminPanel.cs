using _2018Proje_SupFollup_v2.Controllers;
using _2018Proje_SupFollup_v2.Models;
using _2018Proje_SupFollup_v2.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _2018Proje_SupFollup_v2
{
    public partial class AdminPanel : Form, IUserFormView
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private static Control.ControlCollection controls;
        public mUser currentuser { set; get; }
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            controls = this.Controls;
            currentuser = new mUser();
            admn_datagrd.EditMode = DataGridViewEditMode.EditProgrammatically;
            IUserView v = new UserView(this);
            currentuser = v.getLoginedUser();

            UserController controller = new UserController(new UserView(this), currentuser);
            controller.getAllUser();
            List<string> tags = new List<string>();
            tags.Add("admn_ad");
            tags.Add("admn_kad");
            tags.Add("admn_eposta");
            controller.setLabelText(tags);
        }

        private void admn_datagrd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mUser ccu = new mUser();
            if (e.ColumnIndex > -1 && e.RowIndex > -1 && e.RowIndex < admn_datagrd.RowCount - 1)
            {
                lblSetVisible(true);
                ccu.Id = int.Parse(admn_datagrd.Rows[e.RowIndex].Cells[0].Value.ToString());
                ccu.Ad = admn_datagrd.Rows[e.RowIndex].Cells[1].Value.ToString();
                ccu.Kad = admn_datagrd.Rows[e.RowIndex].Cells[2].Value.ToString();
                ccu.Sifre = admn_datagrd.Rows[e.RowIndex].Cells[3].Value.ToString();
                ccu.Eposta = admn_datagrd.Rows[e.RowIndex].Cells[4].Value.ToString();
                ccu.Yetki = (int)admn_datagrd.Rows[e.RowIndex].Cells[5].Value;
                UserController controller = new UserController(new UserView(this), ccu);
                controller.setCellClicked();
                List<string> tags = new List<string>();
                tags.Add("ad");
                tags.Add("kad");
                tags.Add("eposta");
                tags.Add("yetki");
                controller.setLabelText(tags);
                admn_btn_günc.Visible = true;
                admn_btn_sil.Visible = true;
            }
            else
            {
                lblSetVisible(false);
            }
        }
        private void admn_btn_geri_Click(object sender, EventArgs e)
        {
            UserController control = new UserController(new UserView(this), currentuser);
            control.checkLogin();
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

        /// <summary>
        /// DATABASE TEMEL İŞLEMLER
        /// </summary>
        #region TEMEL CRUD
        /// <summary>
        /// DATABASE SİLME
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void admn_btn_sil_Click(object sender, EventArgs e)
        {
            t_deluser tdu = new t_deluser();
            UserController controller = new UserController(new UserView(new t_deluser()), currentuser);
            controller.setCurrentuser();
            tdu.ShowDialog();
        }
        /// <summary>
        /// DATABASE GÜNCCELLE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void admn_btn_günc_Click(object sender, EventArgs e)
        {
            t_uppuser tup = new t_uppuser();
            tup.ShowDialog();
        }
        /// <summary>
        /// DATABASE ARA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void admn_k_txt_ara_TextChanged(object sender, EventArgs e)
        {
            mUser user = new mUser();
            user.Ad = admn_k_txt_ara.Text;
            user.Kad = admn_k_txt_ara.Text;
            UserController controller = new UserController(new UserView(this), user);
            controller.searchUser();
        }

        #endregion TEMEL CRUD

        private void lblSetVisible(bool t)
        {
            admn_k_ad.Visible = t;
            admn_k_kad.Visible = t;
            admn_k_email.Visible = t;
            admn_k_yetki.Visible = t;
            admn_btn_günc.Visible = t;
            admn_btn_sil.Visible = t;
        }

        public void setCurrentuser(mUser m)
        {
            throw new NotImplementedException();
        }
    }
}
