using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineTest_Library.Models
{
    public class Book
    {
        private string Book_Title;
        private string Book_Author;
        private string Book_ISBN;
        private int Book_QtyAvl;

        public string Title
        {
            get {return Book_Title;}
            set { Book_Title = value;}
        }
        public string Author
        {
            get { return Book_Author; }
            set { Book_Author = value; }
        }

        public string ISBN
        {
            get { return Book_ISBN;}
            set { Book_ISBN = value;}
        }
        public int Available_Books
        {
            get { return Book_QtyAvl; }
            set { Book_QtyAvl = value;}
        }

        public Book() { }
        public Book(string title,string author,string isbn,int avlbooks)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Available_Books=avlbooks;
        }
    }
}
