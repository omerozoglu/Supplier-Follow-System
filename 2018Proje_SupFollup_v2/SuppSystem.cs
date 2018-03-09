using _2018Proje_SupFollup_v2.Controllers;
using _2018Proje_SupFollup_v2.Models;
using _2018Proje_SupFollup_v2.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _2018Proje_SupFollup_v2
{
    public partial class SuppSystem : Form, ISupplierFormView
    {
        public SuppSystem()
        {
            InitializeComponent();
            //this.sys_dtgrd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.sys_dtgrd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        private static Control.ControlCollection controls;
        private void SuppSystem_Load(object sender, EventArgs e)
        {
            controls = this.Controls;
            SupplierSystemController controller = new SupplierSystemController(new SupplierView(this),new SupplierSystemModel());
            controller.getAllSupplier();
        }

        public Control.ControlCollection getFormObjects()
        {
            return controls;
        }

        public void formCloser()
        {
            this.Close();
        }

        public void setCurrentSuppSysModel(SupplierSystemModel m)
        {
            throw new NotImplementedException();
        }

        private void sys_dtgrd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            SupplierSystemModel m = new SupplierSystemModel();
            if (e.ColumnIndex > -1 && e.RowIndex > -1 && e.RowIndex < sys_dtgrd.RowCount - 1)
            {
                m.id =sys_dtgrd.Rows[e.RowIndex].Cells[0].Value;
                m.name = sys_dtgrd.Rows[e.RowIndex].Cells[1].Value;
                m.properties = sys_dtgrd.Rows[e.RowIndex].Cells[2].Value;
                m.startdate = sys_dtgrd.Rows[e.RowIndex].Cells[3].Value;
                m.enddate = sys_dtgrd.Rows[e.RowIndex].Cells[4].Value;
                m.piece = sys_dtgrd.Rows[e.RowIndex].Cells[5].Value;
                m.isinvoice= sys_dtgrd.Rows[e.RowIndex].Cells[6].Value;
                m.price = sys_dtgrd.Rows[e.RowIndex].Cells[7].Value;
                m.agncyprice= sys_dtgrd.Rows[e.RowIndex].Cells[8].Value;
                m.personid= sys_dtgrd.Rows[e.RowIndex].Cells[9].Value;
                m.suppid = sys_dtgrd.Rows[e.RowIndex].Cells[10].Value;
                m.logid = sys_dtgrd.Rows[e.RowIndex].Cells[11].Value;
                SupplierSystemController controller = new SupplierSystemController(new SupplierView(this), m);
                controller.setCellClicked();
                List<string> tags = new List<string>();
                tags.Add("name");
                tags.Add("prop");
                tags.Add("prsn");
                tags.Add("prc");
                tags.Add("log");
                controller.setlabelText(tags);
            }
            else
            {

            }
        }

        private void sy_btn_ekle_Click(object sender, EventArgs e)
        {

        }

        private void sys_btn_günc_Click(object sender, EventArgs e)
        {

        }

        private void sys_btn_sil_Click(object sender, EventArgs e)
        {

        }
    }
}
