using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForGenerics
{
    public class Products:IComparer<Products>
    {
        public int Prodid { get; set; }
        public string Prodname { get; set; }
        public int Price { get; set; }

        public int Compare(Products? x, Products? y)
        {
            return x.Price.CompareTo(y.Price);
        }
    }
}
