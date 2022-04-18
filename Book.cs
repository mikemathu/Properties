using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookNamespace
{
    internal class Book
    {
        //Instanct Variables
        private string title;
        private string author;

        /*
        //Constructor. Allows the user of this class to instanciate the instant variables and give them a starting state/initial values
        public Book(string title, string author)
        {
            //class level titile = method level title;
            this.title = title;
            this.author = author;
        }
        public Book(string title, string author, int pages, int wordCount)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.wordCount = wordCount;
        }
        */

       /* //Methods
        //Retrive the current title of the book
        public string GetTitle()
        {
            return title;
        }
        //Specify the new title for the book(Change)
        public void SetTitle(string title)
        {
            this.title = title;
        }
        //Supply the text of the book and update the word count accordingly
        public void AssignWordCountFromText(string text)
        {
            wordCount = text.Split(' ').Length;
        }*/

        //PROPERTIES
        
        //Creating Properties
        /*public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }*/

        //Auto-implemented Properties
        
        public string Title { get; set; }
        public string Author { get; set; }
        

        //Read-Only Auto-Implemented Properties
        /*
        //Using Default Values
        public string Title { get; set; } = "Think and Grow Rich";
        public string Author { get; set; } = "Mike";
        */

        //Using Construstor
        /*
        public string Title { get; }
        public string Author { get; }
        //Constructor
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
        */


    }
}
