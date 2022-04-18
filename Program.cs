using BookNamespace;

namespace Properties
{
    public class Properties
    {
        static void Main(string[] args)
        {
            /*
            //New instance of the Book class
            //using the 1st constructor
            Book book = new Book("Harry Potter", "J.K Rowling");

            //Using the 2nd constructor
            //Book book = new Book("Harry Potter", "J.K Rowling", 25, 1000 );

            //Changed my mind. Let's use the full name.
            book.SetTitle("Harry Potter and the Half-Blood Price");

            //Now I forgot.What was the title again?
            Console.WriteLine(book.GetTitle());
            */

            /*
            Book book = new Book();
            book.Title = "Millionaire Fast Lane"; //Set
            book.Author = "MJ Demarco"; //set
            */

            //Object Initializer Sysntax
            Book book = new Book() { Title = "Fastlane", Author = "MJ"};

            

            //Read-Only Auto-Implementation
            /*
            Book book = new Book("M Fastlane", "MJ ");
            */


    

            Console.WriteLine(book.Title+ " Is a book written by " + book.Author);
        }
    }
}
