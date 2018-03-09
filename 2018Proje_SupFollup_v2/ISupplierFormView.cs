using _2018Proje_SupFollup_v2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018Proje_SupFollup_v2
{
    public interface ISupplierFormView : IFormView
    {
        void setCurrentSuppSysModel(SupplierSystemModel m);
    }
}
