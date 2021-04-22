using System.Collections.Generic;

namespace Bibliotek
{
    public class Shelf
    {
        private int _index;
        public string Theme { get; }
        public List<Book> Books { get; }

        public Shelf(int index, string theme, List<Book> books)
        {
            _index = index;
            Theme = theme;
            Books = books;
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }
    }
}