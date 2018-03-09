using System.Collections.Generic;

namespace _2018Proje_SupFollup_v2.Models
{
    public interface IUser
    {
        object Id { get; set; }
        object Ad { get; set; }
        object Kad { get; set; }
        object Sifre { get; set; }
        object Eposta { get; set; }
        object Yetki { get; set; }
        bool IsLoginedUser { get; set; }
        List<mUser> getModels();
        List<mUser> searchUser();

        mUser getUser(List<string> columns, List<string> values);
        void insertUser();
        void updateUser(object o);
        void deleteUser(object o);

        void Hata (object o);
    }
}
