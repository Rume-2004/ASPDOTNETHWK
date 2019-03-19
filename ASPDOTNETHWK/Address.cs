using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace ASPDOTNETHWK
{
    public class Address
    {
        public int HouseNumber
        {
            get => default(int);
            set
            {
            }
        }

        public string StreetName
        {
            get => default(string);
            set
            {
            }
        }

        public string City
        {
            get => default(string);
            set
            {
            }
        }

        public string PostCode
        {
            get => default(string);
            set
            {
            }
        }

        public int AddressID
        {
            get => default(int);
            set
            {
            }
        }

        //public Customers Customers
        //{
        //    get => default(Customers);
        //    set
        //    {
        //    }
        //}
    }
}