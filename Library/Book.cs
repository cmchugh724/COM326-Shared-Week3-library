using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library
{
    public class Book
    {

        private string title;
        private string author;

        private string isbn;


        public string Title
        {
            get { return title; }
            set
            {
                // Ensure name does not contain any numbers
                if (value != "")
                {
                    title = value;
                }
                else
                {
                    Console.WriteLine("Error: Book Title cannot be blank or contain numbers.");
                }
            }
        }

        public string Author
        {
            get { return author; }
            set
            {
                // Ensure name does not contain any numbers
                if (!value.Any(char.IsDigit) && value != "")
                {
                    author = value;
                }
                else
                {
                    Console.WriteLine("Error: Book Author cannot be blank or contain numbers.");
                }
            }
        }

        public string ISBN
        {
            get { return isbn; }
            set
            {
                
                if (value != "")
                {
                    isbn = value;
                }
                else
                {
                    Console.WriteLine("Error: Book ISBN cannot be blank.");
                }
            }
        }

        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
} 
    
