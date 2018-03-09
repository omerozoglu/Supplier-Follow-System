
using _2018Proje_SupFollup_v2.Models;
using static System.Windows.Forms.Control;

namespace _2018Proje_SupFollup_v2
{
    public interface IUserFormView :IFormView
    {
        void setCurrentuser(mUser m);
    }
}
