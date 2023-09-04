using System;

namespace Ucu.Poo.Expert
{

    class Program
    {
        static void Main()
        {
            //Creo los libros
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");

            //Creo los estantes
            ShelveBook book1_sh = new ShelveBook(book1, "A", "7");
            ShelveBook book2_sh = new ShelveBook(book2, "B", "3");

            //Obtengo la información de los libros
            book1_sh.GetInfo();
            book2_sh.GetInfo();

        }
    }
}