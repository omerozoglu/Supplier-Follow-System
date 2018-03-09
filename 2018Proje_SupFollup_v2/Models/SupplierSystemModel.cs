using _2018Proje_SupFollup_v2.Data;
using System;
using System.Collections.Generic;

namespace _2018Proje_SupFollup_v2.Models
{
    public class SupplierSystemModel : ISupplierSystem
    {

        private object _id;
        private object _name;
        private object _properties;
        private object _startdate;
        private object _enddate;
        private object _piece;
        private object _personid;
        private object _suppid;
        private object _isinvoice;
        private object _agncyprice;
        private object _price;
        private object _logid;
        private Exception _exceptionSource;

        public object id
        {
            get => _id; set
            {
                try
                {
                    if (value != null && value is int && (int)value > -1)
                    {
                        _id = value;
                    }
                }
                catch (Exception ex)
                {
                    _exceptionSource = ex;
                    this.Exception();
                }
            }
        }
        public object name
        {
            get => _name; set
            {
                try
                {
                    if (value != null && value is string && value.ToString().Length > -1 && value.ToString().Length < 51)
                    {
                        _name = value;
                    }
                }
                catch (Exception ex)
                {
                    _exceptionSource = ex;
                    this.Exception();
                }
            }
        }
        public object properties
        {
            get => _properties; set
            {
                try
                {
                    if (value != null && value is string && value.ToString().Length > -1 && value.ToString().Length < 501)
                    {
                        _properties = value;
                    }
                }
                catch (Exception ex)
                {
                    _exceptionSource = ex;
                    this.Exception();
                }
            }
        }
        public object startdate
        {
            get => _startdate; set
            {
                try
                {
                    if (value != null && value is DateTime)
                    {
                        _startdate = value;
                    }
                }
                catch (Exception ex)
                {
                    _exceptionSource = ex;
                    this.Exception();
                }
            }
        }
        public object enddate
        {

            get => _enddate; set
            {
                try
                {
                    if (value != null && value is DateTime)
                    {
                        _enddate = value;
                    }
                }
                catch (Exception ex)
                {
                    _exceptionSource = ex;
                    this.Exception();
                }
            }
        }
        public object piece
        {
            get => _piece; set
            {
                try
                {
                    if (value != null && value is int && (int)value > -1)
                    {
                        _piece = value;
                    }
                }
                catch (Exception ex)
                {
                    _exceptionSource = ex;
                    this.Exception();
                }
            }
        }
        public object isinvoice
        {
            get => _isinvoice; set
            {
                try
                {
                    if (value != null)
                    {
                        _isinvoice = value;
                    }
                }
                catch (Exception ex)
                {
                    _exceptionSource = ex;
                    this.Exception();
                }
            }
        }
        public object price
        {
            get => _price; set
            {
                try
                {
                    if (value != null && value is int && (int)value > -1)
                    {
                        _price = value;
                    }
                }
                catch (Exception ex)
                {
                    _exceptionSource = ex;
                    this.Exception();
                }
            }
        }
        public object agncyprice
        {
            get => _agncyprice; set
            {
                try
                {
                    if (value != null && value is int && (int)value > -1)
                    {
                        _agncyprice = value;
                    }
                }
                catch (Exception ex)
                {
                    _exceptionSource = ex;
                    this.Exception();
                }
            }
        }
        public object personid { get => _personid; set => _personid = value; }
        public object suppid { get => _suppid; set => _suppid = value; }
        public object logid { get => _logid; set => _logid = value; }
        private Exception exception { get => _exceptionSource; set => _exceptionSource = value; }

        public List<SupplierSystemModel> getallSupplierSystem()
        {
            SupplierSystemSqlData d = new SupplierSystemSqlData(this);
            return d.getAllSuppSystm();
        }
        public SupplierSystemModel getSupplierSystem()
        {
            SupplierSystemSqlData d = new SupplierSystemSqlData(this);
            return d.getSuppSystm();
        }
        public List<SupplierSystemModel> searchSupplierSystem()
        {
            SupplierSystemSqlData d = new SupplierSystemSqlData(this);
            return d.searchSuppSystm();
        }

        public void insertSupplierSystem()
        {
            SupplierSystemSqlData d = new SupplierSystemSqlData(this);
            d.insert();
        }
        public void updateSupplierSystem()
        {
            SupplierSystemSqlData d = new SupplierSystemSqlData(this);
            d.update();
        }
        public void deleteSupplierSystem()
        {
            SupplierSystemSqlData d = new SupplierSystemSqlData(this);
            d.delete();
            this.Exception();
        }

        private void Exception()
        {
            System.Windows.Forms.MessageBox.Show(exception.Source);
        }
    }
}
