using MachineTest_Library.Exceptions;
using MachineTest_Library.Models;
using MachineTest_Library.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineTest_Library.Manager
{
    public class Library:IBook
    {
        List<Book> books=new List<Book>();

        public void LibraryMenu()
        {
            int flag = 0;
            do
            {
                Console.WriteLine("Select your Option:\n1.Add New Book\n2.Remove Book\n3.Borrow Book\n4.Display all Books\n5.Exit");
                string opt = Console.ReadLine();
                switch(opt)
                {
                    case "1":
                        AddBooks();
                        break;
                    case "2":
                        RemoveBook();
                        break;
                    case "3":
                        BorrowBook();
                        break;
                    case "4":
                        DisplayAllBooks();
                        break;
                    case "5":
                        Console.WriteLine("Exit");
                        flag = 1;
                        break;
                    default:
                        Console.WriteLine("Wrong Option.Try again!");
                        break;
                }

            } while (flag == 0);
        }

        public void AddBooks()
        {
            Console.WriteLine("Enter the Book Details:\nTitle:");
            string title=Console.ReadLine();
            Console.WriteLine("Author:");
            string author = Console.ReadLine();
            Console.WriteLine("ISBN:");
            string isbn = Console.ReadLine();
            Console.WriteLine("Number of available copies:");
            int copies=Convert.ToInt32(Console.ReadLine());
            Book newbook=new Book(title,author,isbn,copies);
            books.Add(newbook);
        }

        public void RemoveBook()
        {
            Console.WriteLine("Enter the Book' ISBN:");
            string isbn=Console.ReadLine();
            try
            {
                bool bookExists = books.Any(b => b.ISBN == isbn);
                if(bookExists)
                { 
                    foreach(Book book in books)
                    {
                        if(book.ISBN==isbn)
                        {
                            books.Remove(book);
                            Console.WriteLine($"Book with ISBN:{isbn} is removed.");
                        }
                    }
                }
                else
                {
                    throw new DoesNotExistsException();
                }
            }
            catch(DoesNotExistsException ex)
            {
                Console.WriteLine("The Book ISBN Does not exists!Try again!");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DisplayAllBooks()
        {
            Console.WriteLine("Books Details are:\nTitle\tAuthor\tISBN\tNo.of Copies");
            foreach(Book book in books)
            {
                Console.WriteLine($"{book.Title}\t{book.Author}\t{book.ISBN}\t{book.Available_Books}");
            }

        }

        public void BorrowBook()
        {
            Console.WriteLine("Enter the Book ISBN :");
            string isbn = Console.ReadLine();
            try
            {
                foreach (Book book in books)
                {
                    if (book.ISBN == isbn)
                    {
                        if (book.Available_Books > 0)
                        {
                            Console.WriteLine($"Book is available.Number copies are:{book.Available_Books}");
                            book.Available_Books--;
                        }
                        else
                        {
                            throw new OutOfStockException();
                        }
                    }
                    else
                    {
                        throw new DoesNotExistsException();
                    }

                }
            }
            catch (OutOfStockException ex)
            {
                Console.WriteLine("The Book is not in the stock.");

            }
            catch (DoesNotExistsException ex)
            {
                Console.WriteLine("The Book ISBN Does not exists!Try again!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
