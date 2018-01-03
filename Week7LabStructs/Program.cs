using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7LabStructs
{
    /*Create an application that does the following.Submit the complete application: 

Create a struct with at least three properties.Only one of them may be auto-properties DONE
In that struct, create a parameterized constructor that sets the initial values of those properties DONE
In your Main() method, create two instances of the struct. DONE
In the first instance, use the default constructor and manually set values to each property  DONE??
In the second instance, use the parameterized constructor to set values to each property  DONE??
Write the values of each property on each instance of the struct to the screen DONE
*/

    public struct Books
    {
        //FIELDS

        private string title;
        private string author;
        private string cover;

        //PROPERTIES

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Cover
        {
            get { return cover; }
            set { cover = value; }
        }

        //CONSTRUCTORS

        public Books(string inputTitle, string inputAuthor, string inputCover) 
        {
            author = inputAuthor;
            title = inputTitle;
            cover = inputCover; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My summer reading list.\n");

            Books sciFi = new Books();

            sciFi.Title = "Dune";
            sciFi.Author = "Frank Herbert";
            sciFi.Cover = "paperback";

            Books novel = new Books("Anna Karenina", "Leo Tolstoy", "hardback");

            //Not sure I followed instructions correctly. Aren't these two different ways of doing the same thing?

            Console.WriteLine($"This summer's fun reading is " +
                $"{sciFi.Title} by {sciFi.Author} in {sciFi.Cover}.");

            Console.WriteLine($"This summer's serious reading is " +
                $"{novel.Title} by {novel.Author} in {novel.Cover}.");

            Console.ReadLine();
        }
    }
}
