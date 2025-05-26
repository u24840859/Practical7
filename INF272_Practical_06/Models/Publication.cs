using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INF272_Practical_06.Models
{
    public class Publication
    {
        public Author Author { get; set; }
        public String LeadingImage { get; set; }  
        public String MainStoryURL { get; set; }
        public String Summary { get; set; }
        public String Title { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Type { get; set;}
    }
}