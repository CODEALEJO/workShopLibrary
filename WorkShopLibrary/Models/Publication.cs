using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace WorkShopLibrary.Models
{
    public class Publication
    {
        public int Id { get; set; }
        public string YearPublication { get; set; }
        public string Title { get; set; }



        public Publication(int id, string yearPublication, string title)
        {
            Id = id;
            YearPublication = yearPublication;
            Title = title;
        }
    }
}