using System;
using System.Collections.Generic;

namespace Bibliotek
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Trollriket", "Malin Falk", "9788242969675");
            Book book2 = new Book("Min Insta tur", "Julie Bjarnes", "9788202708825");
            Book book3 = new Book("Sølvmyntene", "Tom Egeland", "9788284191171");
            Book book4 = new Book("Av mitt blod", "Ruth Lillegraven", "9788248927518");
            Book book5 = new Book("Rottejegeren", "Max Manus", "9788248927655");
            Book book6 = new Book("Hjerteløs", "Jørgen Jeger", "9788284150505");
            Book book7 = new Book("Speilmannen", "Lars Kepler", "9788202704582");
            Book book8 = new Book("Glassvinge", "Kartrine Engberg", "9788284192475");
            Book book9 = new Book("Slagside", "Jørn Lierhorst", "9788284150192");

            Shelf shelf1 = new Shelf(1,"Fantasy", new List<Book> { book1, book2, book3 });
            Shelf shelf2 = new Shelf(2,"Krim", new List<Book> { book4, book5, book6 });
            Shelf shelf3 = new Shelf(3,"Roman", new List<Book> { book7, book8, book9 });

            Person person1 = new Person();
            Library library1 = new Library("Oslo Biblotek", "Anne-Cath, Vestlys plass 1, 0150 Oslo", new List<Shelf> {shelf1, shelf2, shelf3} ,person1);

            library1.ChooseGenre("Fantasy");
            library1.SelectAndLoanBook("Trollriket");
            library1.ReturnBook("Trollriket");
        }
    }
}
