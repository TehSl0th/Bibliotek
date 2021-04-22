using System;
using System.Collections.Generic;

namespace Bibliotek
{
    public class Person
    {
        private List<Book> _loanedBooks;
        public Book ToBeReturned { get; private set; }

        public void AddBook(Book book)
        {
            _loanedBooks.Add(book);
        }

        public Person()
        {
            _loanedBooks = new List<Book>();
        }

        public void ReturnBook(string title)
        {
            foreach (var book in _loanedBooks)
            {
                if (book.Title == title)
                {
                    ToBeReturned = book;
                }
            }
        }

        public void BookIsReturned()
        {
            RemoveBookFromLoanedBooks();
            ToBeReturned = null;
        }

        private void RemoveBookFromLoanedBooks()
        {
            Console.WriteLine("The book " + ToBeReturned.Title + " is returned");
            _loanedBooks.Remove(ToBeReturned);
        }
    }
}