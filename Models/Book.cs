namespace console_library.Models
{
  public class Book
  {
    public Book(string title, string author)
    {
      Title = title;
      Author = author;
      bool Avaliable = true;
    }

    public string Title { get; set; }
    public string Author { get; set; }
    public string Avaliable { get; set; }
  }
}