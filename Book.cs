namespace Bibliotek
{
    public class Book
    {
        public string Title { get; }
        private string _author;
        private string _isbn;

        public Book(string title, string author, string isbn)
        {
            Title = title;
            _author = author;
            _isbn = isbn;
        }
    }
}