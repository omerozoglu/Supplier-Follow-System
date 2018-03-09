
using _2018Proje_SupFollup_v2.Models;
using System.Collections.Generic;

namespace _2018Proje_SupFollup_v2.Views
{
    public interface IUserView
    {
        void setDataGridFromList(List<mUser> list);
        void updateDataGrid(List<mUser> list);
        mUser getCellClicked();
        void setCellClicked(mUser mUser);
        
        bool checkLogin(mUser m);
        mUser getLoginedUser();


        void setTextboxText(List<string> tag, List<object> value);
        string getTextBoxText(string tag);
        void setLabelText(List<string> tag, List<object> value);
        void clearTextBox();

        void setButtonSetting(bool v,bool e);
        void setButtonSetting(bool v, bool e,string tag);
        void setButtonSetting(bool v, bool e, List<string> tag);

        void setCurrentuser(mUser m);
        void formClosed();
    }
}
