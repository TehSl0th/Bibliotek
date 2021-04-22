using System;
using System.Collections.Generic;

namespace Bibliotek
{
    public class Library
    {
        // Fields / Properties
        private string _name;
        private string _address;
        private List<Shelf> _shelves;
        private List<Book> _loanedBooks;
        private Shelf _currentShelf;
        private Person _person;


        // Constructor
        public Library(string name, string address, List<Shelf> shelves, Person person)
        {
            _name = name;
            _address = address;
            _shelves = shelves;
            _loanedBooks = new List<Book>();
            _person = person;
        }


        // Methods
        public void ChooseGenre(string name)
        {
            foreach (var shelf in _shelves)
            {
                if (shelf.Theme == name)
                {
                    Console.WriteLine("Found shelf " + name);
                    _currentShelf = shelf;
                    return;
                }
            }

            Console.WriteLine("Shelf doesn't exist");
        }

        public void SelectAndLoanBook(string title)
        {
            foreach (var book in _currentShelf.Books)
            {
                if (book.Title == title)
                {
                    _loanedBooks.Add(book);
                }
            }

            RemoveBooksFromShelf();
        }

        private void RemoveBooksFromShelf()
        {
            foreach (var loanedBook in _loanedBooks)
            {
                _person.AddBook(loanedBook);
                _currentShelf.Books.Remove(loanedBook);
                Console.WriteLine("You have now loaned the book " + loanedBook.Title);
            }
        }

        public void ReturnBook(string title)
        {
            _person.ReturnBook(title);
            foreach (var shelf in _shelves)
            {
                if (shelf.Books.Count < 3)
                {
                    shelf.AddBook(_person.ToBeReturned);
                    _person.BookIsReturned();
                }
            }
        }
    }
}