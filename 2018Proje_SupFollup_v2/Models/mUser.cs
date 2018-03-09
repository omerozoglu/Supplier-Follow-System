using _2018Proje_SupFollup_v2.Data;
using _2018Proje_SupFollup_v2.Views;
using System.Collections.Generic;

namespace _2018Proje_SupFollup_v2.Models
{
    public class mUser : IUser
    {
        private object id;
        private object ad;
        private object kad;
        private object sifre;
        private object eposta;
        private object yetki;
        private bool isLoginedUser;
        private object hata = "değer null olamaz";

        public object Id { get => id; set { if (value != null ) { id = value; } else { Hata(hata); } } }
        public object Ad { get => ad; set { if (value != null) { ad = value; } else { Hata(hata); } } }
        public object Kad { get => kad; set { if (value != null) { kad = value; } else { Hata(hata); } } }
        public object Sifre { get => sifre; set { if (value != null) { sifre = value; } else { Hata(hata); } } }
        public object Eposta { get => eposta; set { if (value != null) { eposta = value; } else { Hata(hata); } } }
        public object Yetki { get => yetki; set  { if (value != null) { yetki = value; } else { Hata(hata); } } }
        public bool IsLoginedUser { get => isLoginedUser; set { isLoginedUser = value; } } 

        public List<mUser> getModels()
        {
            UserSqlData data = new UserSqlData(this);
            return data.GetAllUser();
        }
        public List<mUser> searchUser()
        {
            UserSqlData data = new UserSqlData(this);
            return data.SearchUser();
        }
        public mUser getUser(List<string> columns, List<string> values)
        {
            UserSqlData data = new UserSqlData(this);
            return data.GetUser(columns, values);
        }
        public void insertUser()
        {
            UserSqlData data = new UserSqlData(this);
            if (data.InsertUser())
            {

            }

        }
        public void updateUser(object o)
        {
            UserSqlData data = new UserSqlData(this);
            data.UpdateUser(o);
        }
        public void deleteUser(object o)
        {
            UserSqlData data = new UserSqlData(this);
            data.DeleteUser(o);
        }

        public void Hata(object o)
        {
            throw new global::System.Exception { Source = o.ToString() };
        }

 
    }
}
