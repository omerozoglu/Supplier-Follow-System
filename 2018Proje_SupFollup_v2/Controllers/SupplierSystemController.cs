
using _2018Proje_SupFollup_v2.Models;
using _2018Proje_SupFollup_v2.Views;
using System.Collections.Generic;

namespace _2018Proje_SupFollup_v2.Controllers
{
    public class SupplierSystemController
    {
        
        ISupplierView _v;
        ISupplierSystem _m;
        public SupplierSystemController(ISupplierView v,ISupplierSystem m)
        {
            _v = v;
            _m = m;
        }
        public void getAllSupplier()
        {
            _v.setDataGridFromList(_m.getallSupplierSystem());
        }
        public void getSuplier()
        {

        }
        public void searchSuplier()
        {

        }
        public void inertSuplier()
        {

        }
        public void updateSuplier()
        {

        }
        public void deleteSuplier()
        {

        }

        public void setlabelText(List<string> tags)
        {
            List<object> values = new List<object>();
            values.Add(_m.name);
            values.Add(_m.properties);
            values.Add(_m.personid.ToString());
            values.Add(_m.price.ToString());
            values.Add(_m.logid.ToString());
            _v.setLabelText(tags, values);
        }

        public void setCellClicked()
        {
            
        }
        public void formClosed()
        {
            
        }
    }
}
