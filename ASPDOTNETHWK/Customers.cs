using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace ASPDOTNETHWK
{
    public class Customers
    {
        public string Name
        {
            get => default(string);
            set
            {
            }
        }

        public string Emails
        {
            get => default(string);
            set
            {
            }
        }

        public int CustomersID
        {
            get => default(int);
            set
            {
            }
        }

        public Address Address
        {
            get => default(Address);
            set
            {
            }
        }
    }
}