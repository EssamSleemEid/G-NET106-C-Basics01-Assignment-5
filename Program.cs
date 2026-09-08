using System.Runtime.InteropServices;

namespace fourth_assignment
{
    internal class Program
    {
        enum Genre
        {
            Fiction,
            NonFiction,
            Science
        }
        class book
        {
            private string password = "secret";
            internal int copiesInStock = 5;
            public string Title = "essam sleem";
            public Genre Genre;
        }
        static void Main(string[] args)
        {
            #region Question1
            //Add a private string password = "secret"; field to a Book class. Try to print it from Main (outside the class). What happens, and why?

            //book book01=new book();
            //Console.WriteLine(book.password);      // it will not work bc it is private and you can access to it only in book scope
            #endregion

            #region Question2
            //Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile? Why? 

            //book book01 = new book();
            //Console.WriteLine(book01.copiesInStock);    // it will work bc its internal that can be accessed in the same project  
            #endregion

            #region Question3
            //Add a public string Title; field to Book. Set it and print it from Main.

            //book book01 = new book();
            //Console.WriteLine(book01.Title);
            #endregion
            #region Question4
            //Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book, assign it Genre.Science, and print it.

            //book book01 = new book();
            //book01.Genre = Genre.Science;
            //Console.WriteLine(book01.Genre);
            #endregion

            #region Question5
            //Using the Genre enum above, print the underlying int value of Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.

            //Console.WriteLine((int)Genre.Science);
            //Console.WriteLine((int)Genre.Fiction);
            //Console.WriteLine((int)Genre.NonFiction);
            #endregion

            #region Question6
            //Given int genreNumber = 1;, cast it into a Genre value and print the result.

            //int genreNumber = 1;
            //Genre genre01 = new Genre();
            //genre01 = (Genre)genreNumber;
            #endregion

            #region Question7
            //Given Genre genre = Genre.Fiction;, convert it into a string using ToString() and print it. 

            //Genre genre = Genre.Fiction;
            //string converter = genre.ToString();
            //Console.WriteLine(converter);
            #endregion

            #region Question8
            //Given string genreText = "Science";, convert it into a Genre value using Enum.Parse() and print the result. 

            //string genreText = "Science";
            //Genre genre = Enum.Parse<Genre>(genreText);
            //Console.WriteLine(genre);
            #endregion

            #region Question9
            //Given string genreText = "Mystery"; (not a valid Genre value), use Enum.TryParse() to attempt the conversion. Print "Unknown genre" if it fails

            //string genreText = "Mystery";
            //if(Enum.TryParse<Genre>(genreText,out Genre genre))
            //{
            //    Console.WriteLine(genre);
            //}
            //else
            //{
            //    Console.WriteLine("Unknown genre");
            //}
            #endregion

        }
    }
}
