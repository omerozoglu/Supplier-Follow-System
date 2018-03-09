
using _2018Proje_SupFollup_v2.Models;
using _2018Proje_SupFollup_v2.Views;
using System.Collections.Generic;

namespace _2018Proje_SupFollup_v2.Controllers
{
    public class UserController
    {
        IUserView _view;
        IUser _user;

        public UserController(IUserView v, IUser u)
        {
            this._view = v;
            this._user = u;
        }

        public void getAllUser()
        {
            _view.setDataGridFromList(_user.getModels());
        }
        public void getUser()
        {
            List<string> columns = new List<string>();
            List<string> values = new List<string>();
            columns.Add("kad");
            columns.Add("sifre");
            values.Add((string)_user.Kad);
            values.Add((string)_user.Sifre);
            _user = _user.getUser(columns,values);
        }
        public void insertUser()
        {
            _view.clearTextBox();
            _user.insertUser();
            _view.formClosed();
        }
        public void updateUser()
        {
            _user.updateUser(_user.Id);
            _view.updateDataGrid(_user.getModels());
        }
        public void deleteUser()
        {
            _user.deleteUser(_user.Id);
            _view.updateDataGrid(_user.getModels());
        }
        public void searchUser()
        {
           
            _view.setDataGridFromList(_user.searchUser());
        }
      
        public void checkLogin()
        {
            _view.clearTextBox();
            getUser();
            if (_view.checkLogin((mUser)_user))
            {
                Transactions tr = new Transactions();
                UserController controller = new UserController(new UserView(new Transactions()),_user);
                controller.setCurrentuser();
                tr.Show();
                _view.formClosed();
            }
            else
            {
               
            }
            
        }
        public mUser getLoginedUser()
        {
            return _view.getLoginedUser();
        }

        public void setCellClicked()
        {
            _view.setCellClicked((mUser)_user);
        }

        public void setLabelText(List<string> tags)
        {
            List<object> values = new List<object>();
            values.Add(_user.Ad);
            values.Add(_user.Kad);
            values.Add(_user.Eposta);
            values.Add(_user.Yetki.ToString()??"0");
            _view.setLabelText(tags, values);
        }
        public void setTextboxText(List<string> tags)
        {
            List<object> values = new List<object>();
            values.Add(_user.Ad);
            values.Add(_user.Kad);
            values.Add(_user.Eposta);
            values.Add(_user.Sifre);
           values.Add(_user.Yetki.ToString());
            _view.setTextboxText(tags, values);
        }

        public void setButtonSettings(bool visible,bool enabled)
        {
            _view.setButtonSetting(visible,enabled);
        }
        public void setButtonSettings(bool visible, bool enabled,string tag)
        {
            _view.setButtonSetting(visible, enabled,tag);
        }
        public void setButtonSettings(bool visible, bool enabled,List<string> tags)
        {
            _view.setButtonSetting(visible, enabled,tags);
        }

        public void setCurrentuser()
        {
            _view.setCurrentuser((mUser)_user);
        }
        public void formClosed()
        {
            _view.formClosed();
        }
    }
}
