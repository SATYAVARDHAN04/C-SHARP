//Design a Book class with properties for Title, Author, and ISBN. Instantiate three objects and display their details.

using System;
namespace OOPS.CLASSES
{
    public class Q1
    {
        public static void Main(string[] args)
        {
            Book b1 = new Book("Harry Potter","RDJ","14589");
            Console.WriteLine($"Book name is {b1.Title} which is written by {b1.Author} and the ISBN number is {b1.ISBN}");
            Book b2 = new Book("Annie Frank","Maverick","196584");
            Console.WriteLine($"Book name is {b2.Title} which is written by {b2.Author} and the ISBN number is {b2.ISBN}");
        }
    }
    public class Book
    {
        public String Title;
        public String Author;
        public String ISBN;

        public Book (String title,String author, String ISBN)
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = ISBN;
        }
    }
}