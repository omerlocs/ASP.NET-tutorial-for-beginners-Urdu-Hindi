using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Library.CUI
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Enter the Author Name.");
            string author = Console.ReadLine();
            Console.Write("Enter the Publisher.");
            string publisher = Console.ReadLine();
            Console.Write("Enter the Book Title.");
            string title = Console.ReadLine();
            Console.Write("Enter the ISBN.");
            string isbn = Console.ReadLine();
            string filepath = "F://library.txt";
            StreamWriter write;
            if (File.Exists(filepath))
                write =new StreamWriter(filepath, true);
            else
            write = new StreamWriter(filepath);
            write.Write(string.Format("{0},",author));
            write.Write(string.Format("{0},",publisher));
            write.Write(string.Format("{0},",title));
            write.WriteLine(string.Format("{0}",isbn));
            write.Close();
            Console.WriteLine("Data Saved Successfully!!!");
            StreamReader reader = new StreamReader("F://library.txt");
            while(!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] values = line.Split(',');
                Console.WriteLine(string.Format("Author Name is {0}", values[0]));
                Console.WriteLine(string.Format("Publisher Name is {0}", values[1]));
                Console.WriteLine(string.Format("Book Title is {0}", values[2]));
                Console.WriteLine(string.Format("ISBN is {0}", values[3]));
            
            }
            
            reader.Close();
            Console.ReadKey();// any key press
            //Console.ReadLine();// enter key press
        }
    }
}
