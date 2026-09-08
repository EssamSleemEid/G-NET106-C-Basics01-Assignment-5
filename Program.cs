using System.Runtime.InteropServices;

namespace fourth_assignment
{
    internal class Program
    {
        class book
        {
            private string password = "secret";

        }
        static void Main(string[] args)
        {
            #region Question1
            //Add a private string password = "secret"; field to a Book class. Try to print it from Main (outside the class). What happens, and why?

            //book book01=new book();
            //Console.WriteLine(book.password);      // it will not work bc it is private and you can access to it only in book scope
            #endregion


        }
    }
}
