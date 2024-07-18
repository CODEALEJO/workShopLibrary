using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkShopLibrary.Models
{
    //create class book
    public class Book : Publication
    {
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Gender { get; set; }
        public double Price { get; set; }

        //constructor
        public Book(string author, string isbn, string gender, double price, int id, string yearPublication, string title) : base(id, yearPublication, title)
        {
            Author = author;
            ISBN = isbn;
            Gender = gender;
            Price = price;

        }
    }



}