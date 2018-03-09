using _2018Proje_SupFollup_v2.Models;
using System.Collections.Generic;

namespace _2018Proje_SupFollup_v2.Views
{
    public interface ISupplierView
    {
        void setDataGridFromList(List<SupplierSystemModel> list);
        void updateDataGrid(List<SupplierSystemModel> list);

        SupplierSystemModel getCellClicked();
        void setCellClicked(SupplierSystemModel mUser);

        void setTextboxText(List<string> tag, List<object> value);
        string getTextBoxText(string tag);
        void setLabelText(List<string> tag, List<object> value);
        void clearTextBox();

        void setCurrentSuppSysModel(SupplierSystemModel m);
        void formClosed();
    }
}
