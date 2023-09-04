using System;

namespace Ucu.Poo.Expert
{
    public class ShelveBook
    {
        //Cargo la clase Book
        public Book Book { get; }

        //Cargo los atributos de la clase ShelveBook
        public string LibrarySector { get ; set; }

        //Cargo los atributos de la clase LibraryShelve
        public string LibraryShelve { get ; set; }

        //Creo el constructor de la clase ShelveBook
        public ShelveBook(Book book, String librarySector, String libraryShelve)
        {
            this.Book = book;
            this.LibrarySector = librarySector;
            this.LibraryShelve = libraryShelve;
        }

        //Creo el método GetInfo para obtener la información de los libros en Program.cs
        public void GetInfo()
        {
            Console.WriteLine($"{this.Book.Title} del autor {this.Book.Author} código: {this.Book.Code}\nSe encuentra en el sector {this.LibrarySector} de la biblioteca estantería {this.LibraryShelve}\n");
        }
    }
}