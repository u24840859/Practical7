using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace INF272_Practical_06.Models
{
    public class Book:Publication
    {
        public String Editions { get; set; }
        public override string ToString()
        {
            string res = "";
            res = $"The date of publication is {PublicationDate:dddd, dd MMMM yyyy}";
            res += $" and the number of editions is {Editions}";
            return res;
        }
    }
}