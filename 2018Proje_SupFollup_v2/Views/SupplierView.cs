using _2018Proje_SupFollup_v2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace _2018Proje_SupFollup_v2.Views
{
    public class SupplierView : ISupplierView
    {
        ISupplierFormView v;
        private ControlCollection controls;
        private static SupplierSystemModel supp;
        public SupplierView(ISupplierFormView v)
        {
            this.v = v;
            controls = v.getFormObjects();
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

        public void setDataGridFromList(List<SupplierSystemModel> list)
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

        public void updateDataGrid(List<SupplierSystemModel> list)
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

        public SupplierSystemModel getCellClicked()
        {
            return supp;
        }

        public void setCellClicked(SupplierSystemModel s)
        {
            supp = s;
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

        public void setCurrentSuppSysModel(SupplierSystemModel m)
        {
            v.setCurrentSuppSysModel(m);
        }

        public void formClosed()
        {
            v.formCloser();
        }


    }
}
