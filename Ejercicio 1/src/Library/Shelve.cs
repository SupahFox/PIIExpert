using System;

namespace Ucu.Poo.Expert
{
    public class ShelveBook
    {
        public Book Book { get; }
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }
        public ShelveBook(Book book, String librarySector, String libraryShelve)
        {
            this.Book = book;
            this.LibrarySector = librarySector;
            this.LibraryShelve = libraryShelve;
        }
        public void GetInfo()
        {
            Console.WriteLine($"{this.Book.Title} del autor {this.Book.Author} código: {this.Book.Code}\nSe encuentra en el sector {this.LibrarySector} de la biblioteca estantería {this.LibraryShelve}\n");
        }
    }
}