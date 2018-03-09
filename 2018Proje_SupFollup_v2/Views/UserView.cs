using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using _2018Proje_SupFollup_v2.Models;
using static System.Windows.Forms.Control;

namespace _2018Proje_SupFollup_v2.Views
{
    public class UserView : IUserView
    {
        IUserFormView v;
        private ControlCollection controls;
        private static mUser userr;

        public UserView(IUserFormView v)
        {
            this.v = v;
            controls = v.getFormObjects();
        }

        #region DATAGRİDVİEW ALANI
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        public void setDataGridFromList(List<mUser> list)
        {
            DataGridView dtgv = new DataGridView();
            DataTable dt = ConvertToDatatable(list);
            foreach (object item in controls)
            {
                if (item is DataGridView)
                {
                    dtgv = (DataGridView)item;
                    dtgv.DataSource = dt.DefaultView;
                }
            }
        }
        public void updateDataGrid(List<mUser> list)
        {
            DataGridView dtgv = new DataGridView();
            DataTable dt = ConvertToDatatable(list);
            foreach (object item in controls)
            {
                if (item is DataGridView)
                {
                    dtgv = (DataGridView)item;
                    dtgv.DataSource = dt.DefaultView;
                    dtgv.Refresh();
                }
            }
        }
        private static DataTable ConvertToDatatable<T>(List<T> data)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                if (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    table.Columns.Add(prop.Name, prop.PropertyType.GetGenericArguments()[0]);
                else
                    table.Columns.Add(prop.Name, prop.PropertyType);
            }

            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }

        //TIKLANMIŞ SATIR İŞLEMLERİ
        public mUser getCellClicked()
        {
            return userr;
        }
        public void setCellClicked(mUser m)
        {
            userr = m;
        }

        #endregion

        #region LOGİN KONTROL ALANI
        public mUser getLoginedUser()
        {
            return userr ?? new mUser();
        }
        public bool checkLogin(mUser user)
        {
            if (user.IsLoginedUser)
            {
                userr = user;
                return true;
            }
            else
            {
                userr = new mUser();
                return false;
            }
        }

        #endregion

        #region TEXT İŞLEMLERİ ALANI

        public string getTextBoxText(string tag)
        {
            TextBox tb = new TextBox();
            foreach (object item in controls)
            {
                if (item is TextBox)
                {
                    tb = (TextBox)item;
                    if (tb.Tag == tag)
                    {
                        if (tb.Text != null)
                        {
                            return tb.Text;
                        }

                    }
                }
            }
            return null;
        }
        public void setTextboxText(List<string> tag, List<object> value)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            for (int i = 0; i < tag.Count; i++)
            {
                dic.Add(tag[i], value[i]);
            }
            TextBox lb = new TextBox();
            foreach (object item in controls)
            {
                if (item is TextBox)
                {
                    lb = (TextBox)item;
                    for (int i = 0; i < dic.Count; i++)
                    {
                        if (lb.Tag == tag[i])
                        {
                            lb.Text = (string)dic[tag[i]];
                        }
                    }
                }
            }
        }
        public void clearTextBox()
        {
            TextBox tb = new TextBox();
            foreach (object item in controls)
            {
                if (item is TextBox)
                {
                    tb = (TextBox)item;
                    tb.Clear();
                }
            }
        }
        public void setLabelText(List<string> tag, List<object> value)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            for (int i = 0; i < tag.Count; i++)
            {
                dic.Add(tag[i], value[i]);
            }
            Label lb = new Label();
            foreach (object item in controls)
            {
                if (item is Label)
                {
                    lb = (Label)item;
                    for (int i = 0; i < dic.Count; i++)
                    {
                        if (lb.Tag == tag[i])
                        {
                            lb.Text = (string)dic[tag[i]];
                        }
                    }
                }
            }
        }
        #endregion

        #region BUTTON KONTROL ALANI

        public void setButtonSetting(bool visible, bool enabled)
        {
            Button b = new Button();
            foreach (object item in controls)
            {
                if (item is Button)
                {
                    b = (Button)item;
                    b.Visible = visible;
                    b.Enabled = enabled;
                }
            }
        }
        public void setButtonSetting(bool v, bool e, string tag)
        {
            Button b = new Button();
            foreach (object item in controls)
            {
                if (item is Button)
                {
                    b = (Button)item;
                    if (b.Tag == tag)
                    {
                        b.Visible = v;
                        b.Enabled = e;
                    }
                }
            }
        }
        public void setButtonSetting(bool v, bool e, List<string> tags)
        {

            Button b = new Button();
            foreach (object item in controls)
            {
                if (item is Button)
                {
                    b = (Button)item;
                    for (int i = 0; i < tags.Count; i++)
                    {
                        if (b.Tag == tags[i])
                        {
                            b.Visible = v;
                            b.Enabled = e;
                        }
                    }
                }
            }
        }
        #endregion

        #region FORM ÖZEL ALAN

        public void formClosed()
        {
            v.formCloser();
        }

        public void setCurrentuser(mUser m)
        {
            v.setCurrentuser(m);
        }


        #endregion


    }
}
