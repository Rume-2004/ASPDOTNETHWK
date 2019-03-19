using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace ASPDOTNETHWK
{
    public class Clothes
    {
        public string ClothingType
        {
            get => default(string);
            set
            {
            }
        }

        public int ClothesID
        {
            get => default(int);
            set
            {
            }
        }

        public int ClothingSize
        {
            get => default(int);
            set
            {
            }
        }

        public string Colour
        {
            get => default(string);
            set
            {
            }
        }

        public Brands Brands
        {
            get => default(Brands);
            set
            {
            }
        }
    }
}