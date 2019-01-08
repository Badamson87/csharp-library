using System;
using System.Collections.Generic;
namespace console_library.Models

{
  public class Library
  {
    public Library(string name, string location)
    {
      Name = name;
      Location = location;
      Checkedout = new List<Book>();
      Books = new List<Book>();
    }

    public string Name { get; set; }
    public string Location { get; set; }

    private List<Book> Books;
    private List<Book> Checkedout;

    public void PrintBooks()
    {
      for (int i = 0; i < Books.Count; i++)
      {
        System.Console.WriteLine($" {i + 1} {Books[i].Title} - {Books[i].Author}");
      }
    }
    public void AddBook(Book book)
    {
      Books.Add(book);
    }


    private Book ValidateUserSelection(string select, List<Book> booklist)
    {
      int bookIndex = -1;
      bool valid = Int32.TryParse(select, out bookIndex);

      if (!valid || bookIndex < 0 || bookIndex > booklist.Count)
      {
        Console.Clear();
        System.Console.WriteLine("please make a valid selection");
        return null;
      }
      return booklist[bookIndex - 1];
    }

    public void Checkout(string select)
    {
      Book selectedBook = ValidateUserSelection(select, Books);
      if (selectedBook == null)
      {
        Console.Clear();
        System.Console.WriteLine("Invalid Selection");
        return;
      }
      Checkedout.Add(selectedBook);
      Books.Remove(selectedBook);
    }


    public void returnBook(string rBook)
    {
      Book selectedBook = ValidateUserSelection(rBook, Checkedout);
      if (selectedBook == null)
      {
        System.Console.WriteLine("Invalid selection please make a valid selection");
        return;
      }
      // selectedBook.Avaliable = true;
      Books.Add(selectedBook);
      Checkedout.Remove(selectedBook);
      Console.Clear();
      Console.WriteLine("Book has been returned");
    }



  }
}
