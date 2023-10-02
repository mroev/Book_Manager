using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
}

class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(string title, string author, int year)
    {
        var book = new Book { Title = title, Author = author, Year = year };
        books.Add(book);
        Console.WriteLine($"{title} by {author} added to the library.");
    }

    public void RemoveBook(string title)
    {
        var bookToRemove = books.Find(book => book.Title == title);
        if (bookToRemove != null)
        {
            books.Remove(bookToRemove);
            Console.WriteLine($"{title} removed from the library.");
        }
        else
        {
            Console.WriteLine($"{title} not found in the library.");
        }
    }

    public void UpdateBook(string title, string newTitle, string newAuthor, int newYear)
    {
        var bookToUpdate = books.Find(book => book.Title == title);
        if (bookToUpdate != null)
        {
            bookToUpdate.Title = newTitle;
            bookToUpdate.Author = newAuthor;
            bookToUpdate.Year = newYear;
            Console.WriteLine($"{title} updated in the library.");
        }
        else
        {
            Console.WriteLine($"{title} not found in the library.");
        }
    }

    public void DisplayLibrary()
    {
        Console.WriteLine("Library Contents:");
        foreach (var book in books)
        {
            Console.WriteLine($"{book.Title} by {book.Author}, Published in {book.Year}");
        }
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library();

        while (true)
        {
            Console.WriteLine("\nLibrary Management System");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. Update Book");
            Console.WriteLine("4. Display Library");
            Console.WriteLine("5. Quit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.Write("Enter book title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter book author: ");
                    string author = Console.ReadLine();
                    Console.Write("Enter publication year: ");
                    int year = int.Parse(Console.ReadLine());
                    library.AddBook(title, author, year);
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("Enter the title of the book to remove: ");
                    string bookToRemove = Console.ReadLine();
                    library.RemoveBook(bookToRemove);
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    Console.Write("Enter the title of the book to update: ");
                    string bookToUpdate = Console.ReadLine();
                    Console.Write("Enter the new title: ");
                    string newTitle = Console.ReadLine();
                    Console.Write("Enter the new author: ");
                    string newAuthor = Console.ReadLine();
                    Console.Write("Enter the new publication year: ");
                    int newYear = int.Parse(Console.ReadLine());
                    library.UpdateBook(bookToUpdate, newTitle, newAuthor, newYear);
                    Console.Clear();
                    break;
                case 4:
                    Console.Clear();
                    library.DisplayLibrary();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Exiting the program.");
                    Environment.Exit(0);
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
