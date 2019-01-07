using System;
using console_library.Models;

namespace library
{
  class Program
  {
    static void Main(string[] args)
    {
      System.Console.WriteLine("Welcome to the library");
      var library = new Library("Brians Library", "Boise");

      Book whereTheSidewalkEnds = new Book("Shel Silverstein", "Where the Sidewalk Ends");
      Book hobbit = new Book("J.R.R. Tolkien", "The Hobbit");
      Book lionWitchWardrobe = new Book("C.S. Lewis", "The Lion, The Witch, and the Wardrobe");
      Book harryPotter = new Book("J.K. Rowling", "Harry Potter");
      library.AddBook(lionWitchWardrobe);
      library.AddBook(harryPotter);
      library.AddBook(whereTheSidewalkEnds);
      library.AddBook(hobbit);

      library.PrintBooks();


    }

  }
}
