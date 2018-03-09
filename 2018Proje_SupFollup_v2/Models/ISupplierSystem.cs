using System;
using System.Collections.Generic;

namespace _2018Proje_SupFollup_v2.Models
{
    public interface ISupplierSystem
    {

        object id { get; set; }
        object name { get; set; }
        object properties { get; set; }
        object startdate { get; set; }
        object enddate { get; set; }
        object piece { get; set; }
        object personid { get; set; }
        object suppid { get; set; }
        object isinvoice { get; set; }
        object agncyprice { get; set; }
        object price { get; set; }
        object logid { get; set; }

        void insertSupplierSystem();
        void updateSupplierSystem();
        void deleteSupplierSystem();
        SupplierSystemModel getSupplierSystem();
        List<SupplierSystemModel> getallSupplierSystem();
        List<SupplierSystemModel> searchSupplierSystem();

    }
}
