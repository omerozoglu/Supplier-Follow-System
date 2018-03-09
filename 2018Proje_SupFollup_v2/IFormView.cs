using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Control;

namespace _2018Proje_SupFollup_v2
{
    public  interface IFormView
    {
        ControlCollection getFormObjects();
        void formCloser();
    }
}
